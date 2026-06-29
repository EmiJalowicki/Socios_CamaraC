from dbfread import DBF
from datetime import date

INPUT_DBF = "COBRANZA.dbf"
OUTPUT_SQL = "ActualizarFechasAnual.sql"
ANIO_OBJETIVO = 2026

# -----------------------------------------------------
def convertir_fecha(fecpag_raw):
    if not fecpag_raw:
        return None

    if isinstance(fecpag_raw, date):
        return fecpag_raw

    try:
        d, m, a = map(int, str(fecpag_raw).split('/'))
        return date(a, m, d)
    except:
        return None

# -----------------------------------------------------
def main():
    tabla = DBF(INPUT_DBF, load=True, encoding='latin1')

    sqls = []
    procesados = 0
    errores = 0

    anuales_procesados = set()

    for row in tabla:
        try:
            num_socio = row['NCAMARA']
            mespag = row['MESPAG']
            fecpag_raw = row['FECPAG']
            mescan = row['MESCAN']
            importe_total = float(str(row['IMPORTE']).replace(',', '.')) if row['IMPORTE'] else 0

            # -----------------------------
            # Solo ANUAL
            # -----------------------------
            if mespag != 13:
                continue

            if not num_socio or not fecpag_raw or not mescan:
                continue

            fecha_pago = convertir_fecha(fecpag_raw)
            if not fecha_pago:
                continue

            if fecha_pago.year != ANIO_OBJETIVO:
                continue

            # Validar anual real
            if fecha_pago.month + mescan != 12:
                continue

            fecha_str = fecha_pago.strftime('%Y-%m-%d')

            # ---------------------------------
            # 1. ANUAL_SOCIO → Fecha real
            # ---------------------------------
            key = (num_socio, ANIO_OBJETIVO)

            if key not in anuales_procesados:
                sql_anual = f"""
UPDATE ANUAL_SOCIO
SET FechaRegistro = '{fecha_str}'
WHERE NumSocio = {num_socio}
  AND Anio = {ANIO_OBJETIVO};
""".strip()

                sqls.append(sql_anual)
                anuales_procesados.add(key)

                # -----------------------------
                # PRINT para PowerShell
                # -----------------------------
                # Período de inicio = primer mes pagado (supuesto 1)
                periodo_inicio = date(ANIO_OBJETIVO, 1, 1)
                print(
                    f"ANUAL_SOCIO -> \n \tNumSocio: {num_socio}, \n \tAnio: {ANIO_OBJETIVO}, "
                    f"\n \tPeriodoInicio: {periodo_inicio}, \n \tFechaRegistro: {fecha_str}, "
                    f"\n \tImporteTotal: {importe_total:.2f}, \n \tImportePorCuota: {importe_total/mescan:.2f}"
                )

            # ---------------------------------
            # 2. CUOTA_SOCIO → Fecha = Periodo
            # ---------------------------------
            mes_inicio = fecha_pago.month + 1
            anio = fecha_pago.year

            for i in range(mescan):
                mes = mes_inicio + i
                anio_periodo = anio

                if mes > 12:
                    mes -= 12
                    anio_periodo += 1

                periodo = date(anio_periodo, mes, 1)
                periodo_str = periodo.strftime('%Y-%m-%d')

                sql_cuota = f"""
UPDATE CUOTA_SOCIO
SET FechaPago = '{periodo_str}'
WHERE NumSocio = {num_socio}
  AND Periodo = '{periodo_str}';
""".strip()

                sqls.append(sql_cuota)
                procesados += 1

        except Exception:
            errores += 1

    # -------------------------------------------------
    with open(OUTPUT_SQL, 'w', encoding='utf-8') as f:
        f.write(f"-- NORMALIZACION ANUAL ({ANIO_OBJETIVO})\n")
        f.write("BEGIN TRANSACTION;\n\n")

        for s in sqls:
            f.write(s + "\n\n")

        f.write("COMMIT;\n")

    print(f"\n✔ Año: {ANIO_OBJETIVO}")
    print(f"✔ Updates generados: {procesados}")
    print(f"⚠️ Errores: {errores}")
    print(f"📄 Archivo: {OUTPUT_SQL}")

# -----------------------------------------------------
if __name__ == "__main__":
    main()