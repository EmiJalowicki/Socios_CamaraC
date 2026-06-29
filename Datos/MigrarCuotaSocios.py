from dbfread import DBF
from datetime import date, timedelta

INPUT_DBF = "COBRANZA.dbf"
OUTPUT_SQL = "InsertarCuotaSocioNEW.sql"

# -----------------------------------------------------
# UTIL: primer lunes de la segunda quincena (16-fin del mes)
# -----------------------------------------------------
def primer_lunes_segunda_quincena(anio, mes):
    d = date(anio, mes, 15)
    while d.weekday() != 0:  # 0 = lunes
        d += timedelta(days=1)
        # evitar pasarse del mes
        if d.month != mes:
            return None
    return d

# -----------------------------------------------------
# FECHA DE PAGO (desde FECPAG)
# -----------------------------------------------------
def convertir_fecha(fecpag_raw):
    if not fecpag_raw:
        return None

    # FECPAG viene como date
    if isinstance(fecpag_raw, date):
        return fecpag_raw

    # String "1/2/2026"
    try:
        day, mes, anio = map(int, str(fecpag_raw).split('/'))
        return date(anio, mes, day)
    except:
        return None

# -----------------------------------------------------
# PERIODO (desde MESPAG y FECPAG)
# -----------------------------------------------------
def obtener_periodo(mespag, fecha_pago):
    anio = fecha_pago.year
    # cuota atrasada
    if mespag > fecha_pago.month:
        anio -= 1
    return date(anio, mespag, 1)

# -----------------------------------------------------
# FechaPago final para CUOTA_SOCIO
# -----------------------------------------------------
def calcular_fecha_pago(fecha_pago):
    if fecha_pago.day == 1:
        return fecha_pago.replace(day=1)
    elif fecha_pago.day == 2:
        # primer lunes segunda quincena
        return primer_lunes_segunda_quincena(fecha_pago.year, fecha_pago.month)
    else:
        return None

# -----------------------------------------------------
# MAIN
# -----------------------------------------------------
def main():
    tabla = DBF(INPUT_DBF, load=True, encoding='latin1')

    updates = []
    errores = 0
    procesados = 0

    for row in tabla:
        try:
            num_socio = row['NCAMARA']
            mespag = row['MESPAG']
            fecpag_raw = row['FECPAG']

            # Ignorar anual
            if mespag == 13:
                continue

            if not num_socio or not fecpag_raw:
                continue

            # Fecha de pago original
            fecha_pago = convertir_fecha(fecpag_raw)
            if not fecha_pago:
                continue

            # Solo pagos desde Noviembre 2025 en adelante
            if fecha_pago < date(2025, 11, 1):
                continue

            # Periodo PK
            periodo = obtener_periodo(mespag, fecha_pago)

            # FechaPago en CUOTA_SOCIO
            fecha_pago_final = calcular_fecha_pago(fecha_pago)
            if not fecha_pago_final:
                errores += 1
                continue

            fecha_pago_str = fecha_pago_final.strftime('%Y-%m-%d')
            periodo_str = periodo.strftime('%Y-%m-%d')

            # UPDATE seguro
            sql = f"""
UPDATE CUOTA_SOCIO
SET EstaPaga = 1,
    FechaPago = '{fecha_pago_str}'
WHERE NumSocio = {num_socio}
  AND Periodo = '{periodo_str}'
  AND EstaPaga = 0;
""".strip()

            updates.append(sql)
            procesados += 1

        except Exception:
            errores += 1

    # Escribir archivo SQL
    with open(OUTPUT_SQL, 'w', encoding='utf-8') as f:
        f.write("-- MIGRACION DE CUOTAS PAGAS DESDE NOV 2025\n")
        f.write("BEGIN TRANSACTION;\n\n")
        for u in updates:
            f.write(u + "\n\n")
        f.write("COMMIT;\n")

    print(f"✔ Updates generados: {procesados}")
    print(f"⚠️ Errores: {errores}")
    print(f"📄 Archivo: {OUTPUT_SQL}")
    
if __name__ == "__main__":
    main()
