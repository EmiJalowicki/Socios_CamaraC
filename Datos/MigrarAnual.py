# -----------------------------------------------------
# CONFIG
# -----------------------------------------------------
ANIO_DESDE = 2026
ANIO_HASTA = 2026   # podés cambiar después

OUTPUT_SQL = "InsertarAnuales.sql"

# -----------------------------------------------------
def main():
    inserts = []

    for anio in range(ANIO_DESDE, ANIO_HASTA + 1):
        sql = f"INSERT OR IGNORE INTO ANUAL (Anio) VALUES ({anio});"
        inserts.append(sql)

    # ---------------------------------------------
    # OUTPUT
    # ---------------------------------------------
    with open(OUTPUT_SQL, 'w', encoding='utf-8') as f:
        f.write("-- INSERTS TABLA ANUAL\n")
        f.write("BEGIN TRANSACTION;\n\n")

        for ins in inserts:
            f.write(ins + "\n")

        f.write("\nCOMMIT;\n")

    print(f"✔ Años generados: {ANIO_DESDE} - {ANIO_HASTA}")
    print(f"📄 Archivo: {OUTPUT_SQL}")

# -----------------------------------------------------
if __name__ == "__main__":
    main()
