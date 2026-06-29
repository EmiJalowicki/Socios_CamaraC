from dbfread import DBF
from datetime import date, datetime
import unicodedata

# =========================
# FORMATEO DE FECHAS
# =========================
def formatear_fecha(valor):
    if valor is None:
        return 'NULL'

    if isinstance(valor, date):
        return f"'{valor.strftime('%Y-%m-%d')}'"

    for fmt in ("%d/%m/%Y", "%Y%m%d"):
        try:
            dt = datetime.strptime(str(valor), fmt)
            return f"'{dt.strftime('%Y-%m-%d')}'"
        except:
            continue

    return 'NULL'


# =========================
# DOMICILIO
# =========================
def parsear_domicilio(domicilio):
    if not domicilio:
        return '', 'NULL'

    partes = domicilio.strip().split()
    if not partes:
        return '', 'NULL'

    ultimo = partes[-1]
    if ultimo.isdigit():
        calle = " ".join(partes[:-1])
        numero = ultimo
    else:
        calle = domicilio
        numero = 'NULL'

    calle = calle.replace("'", "''")
    return calle, numero


# =========================
# FORMATO HUMANO (Title Case)
# =========================
def formatear_nombre(texto):
    if not texto:
        return ''

    texto = texto.lower()
    excepciones = ['de', 'del', 'la', 'las', 'los', 'y']

    palabras = texto.split()
    resultado = []

    for i, p in enumerate(palabras):
        if p in excepciones and i != 0:
            resultado.append(p)
        else:
            resultado.append(p.capitalize())

    return " ".join(resultado)


# =========================
# NORMALIZACIÓN (para búsqueda)
# =========================
def normalizar(texto):
    if not texto:
        return ''

    # minúscula
    texto = texto.lower()

    # FormD para separar acentos y tildes
    texto = unicodedata.normalize('NFD', texto)

    resultado = []
    for c in texto:
        # eliminar marcas diacríticas
        if unicodedata.category(c) == 'Mn':
            continue
        # reemplazar ñ por n
        if c == 'ñ' or c == 'Ñ':
            resultado.append('n')
        else:
            resultado.append(c)

    return ''.join(resultado)


# =========================
# MAPA LOCALIDADES
# =========================
mapa_localidades = {
    'TS': 'Tristán Suárez',
    'CS': 'Spegazzini',
    'BBB': 'Tristán Suárez',
    'CCC': 'Tristán Suárez'
}


# =========================
# LECTURA DBF Y GENERACIÓN SQL
# =========================
tabla = DBF('04-2026.dbf', encoding='latin1')

# Contador de registros
total_socios = 0

with open('InsertarSociosNEW.sql', 'w', encoding='utf-8') as f:
    for row in tabla:
        num = row['NCAMARA']
        apellido_raw = str(row['APELLIDO']).strip()

        # Separar apellido / nombre
        partes = apellido_raw.split()
        if len(partes) == 0:
            apellido, nombre = '', ''
        elif len(partes) == 1:
            apellido, nombre = partes[0], ''
        else:
            apellido, nombre = partes[0], " ".join(partes[1:])

        # Formato humano
        apellido = formatear_nombre(apellido)
        nombre = formatear_nombre(nombre)

        # Normalización para búsqueda
        apellido_norm = normalizar(apellido)
        nombre_norm = normalizar(nombre)

        # Escape SQL
        apellido_sql = apellido.replace("'", "''")
        nombre_sql = nombre.replace("'", "''")

        # DNI
        tipo = str(row['TIPO'] or '').strip().upper()
        dni = str(row['DOC'] or '').strip().zfill(8)

        # Fecha nacimiento
        fecha_nacimiento = formatear_fecha(row['FECNACI'])

        # Teléfono
        telefono = str(row['TELEFONO'] or '').strip().replace("'", "''")

        # Domicilio
        domicilio = str(row['DOMICILIO']).strip()
        calle, numero = parsear_domicilio(domicilio)
        if numero != 'NULL':
            numero = int(numero)

        # Localidad
        codigo_localidad = str(row['LOCALIDAD']).strip().upper()
        localidad = mapa_localidades.get(codigo_localidad, codigo_localidad).replace("'", "''")

        # Fecha alta
        fecha_alta = formatear_fecha(row['FECING'])

        # Categoría
        categoria = row['CATEGORIA']
        categoria_map = {5: 1, 6: 2, 7: 3}
        categoria = categoria_map.get(categoria, 1)

        # =========================
        # INSERT SQL
        # =========================
        sql = f"""
        INSERT OR IGNORE INTO SOCIO (
            NumSocio, Apellido, ApellidoNorm,
            Nombre, NombreNorm,
            DNI, Sexo,
            FechaNacimiento,
            NumTelefono,
            CalleNombre, CalleNum, Localidad,
            FechaAlta, Categoria, EstaActivo
        ) VALUES (
            {num},
            '{apellido_sql}', '{apellido_norm}',
            '{nombre_sql}', '{nombre_norm}',
            '{dni}', 'M',
            {fecha_nacimiento},
            '{telefono}',
            '{calle}', {numero}, '{localidad}',
            {fecha_alta},
            {categoria},
            1
        );
        """
        f.write(sql)

        total_socios += 1

# =========================
# Print final
# =========================
print("Archivo InsertarSociosNEW.sql generado ✔️")
print(f"Total de miembros procesados: {total_socios}")