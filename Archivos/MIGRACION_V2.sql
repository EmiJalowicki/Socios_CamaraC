BEGIN TRANSACTION;

-- =====================================================
-- RECREAR VIEW VW_HISTORIAL_CUOTAS
-- =====================================================

DROP VIEW IF EXISTS VW_HISTORIAL_CUOTAS;

CREATE VIEW VW_HISTORIAL_CUOTAS AS
SELECT
    cs.FechaPago,
    s.NumSocio,
    s.Nombre || ', ' || s.Apellido AS NombreCompleto,
    c.IdCategoria,
    q.Periodo,
    q.Importe,

    CASE
        WHEN a.NumSocio IS NOT NULL THEN 1
        ELSE 0
    END AS EsAnual,

    a.PeriodoInicio,
    a.FechaRegistro,
    a.ImporteTotal,
    a.ImportePorCuota

FROM CUOTA_SOCIO cs

JOIN SOCIO s
    ON s.NumSocio = cs.NumSocio

JOIN CATEGORIA c
    ON c.IdCategoria = cs.Categoria

JOIN CUOTA q
    ON q.Periodo = cs.Periodo
   AND q.Categoria = cs.Categoria

LEFT JOIN ANUAL_SOCIO a
    ON a.NumSocio = cs.NumSocio
   AND date(cs.Periodo) >= date(a.PeriodoInicio)
   AND date(cs.Periodo) <= date(
        a.PeriodoInicio,
        '+11 months',
        'start of month',
        '+1 month',
        '-1 day'
   )

WHERE cs.EstaPaga = 1;

-- =====================================================
-- ACTUALIZAR VERSION
-- =====================================================

PRAGMA user_version = 2;

COMMIT;