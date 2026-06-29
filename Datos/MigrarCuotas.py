def generar_archivo(configs, nombre="InsertarCuotas.sql"):
    """
    configs: lista de tuplas (anio, categoria, mes_inicio, mes_fin, importe)
    """

    with open(nombre, "w", encoding="utf-8") as f:
        f.write("BEGIN TRANSACTION;\n")

        for anio, categoria, mes_inicio, mes_fin, importe in configs:
            # === Validaciones ===
            if categoria not in (1, 2, 3):
                raise ValueError(f"Categoría inválida: {categoria}")

            if not (1 <= mes_inicio <= 12 and 1 <= mes_fin <= 12):
                raise ValueError(f"Mes inválido: {mes_inicio}-{mes_fin}")

            if mes_inicio > mes_fin:
                raise ValueError(f"Rango inválido: {mes_inicio} > {mes_fin}")

            if importe < 0:
                raise ValueError(f"Importe inválido: {importe}")

            # === Generar meses del rango ===
            for mes in range(mes_inicio, mes_fin + 1):
                periodo = f"{anio}-{mes:02d}-01"

                linea = (
                    "INSERT OR IGNORE INTO CUOTA (Periodo, Categoria, Importe) "
                    f"VALUES ('{periodo}', {categoria}, {importe});"
                )

                f.write(linea + "\n")

        f.write("COMMIT;\n")


if __name__ == "__main__":
    configs = [
        # (anio, categoria, mes_inicio, mes_fin, importe)
        #2025 (NOV.)
        (2025, 1, 11, 11, 2000), # CAT 1
        (2025, 2, 11, 11, 3000), # CAT 2
        (2025, 3, 11, 11, 3300), # CAT 3
        #2025 (DIC.)
        (2025, 1, 12, 12, 3000), # CAT 1
        (2025, 2, 12, 12, 4000), # CAT 2
        (2025, 3, 12, 12, 4500), # CAT 3
        #2026 (ENE. - ABR.)
        (2026, 1, 1, 4, 3000), # CAT 1
        (2026, 2, 1, 4, 4000), # CAT 2
        (2026, 3, 1, 4, 4500), # CAT 3
    ]

    generar_archivo(configs)
    
print("Archivo InsertarCuotas.sql generado ✔️")
