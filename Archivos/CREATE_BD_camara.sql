PRAGMA foreign_keys = ON;

-- =====================================================
-- TABLA: SOCIO
-- =====================================================
CREATE TABLE IF NOT EXISTS SOCIO (
    NumSocio INTEGER PRIMARY KEY,

    Apellido TEXT,
    ApellidoNorm TEXT NOT NULL,

    Nombre TEXT,
    NombreNorm TEXT NOT NULL,

    DNI TEXT,
    Sexo TEXT NOT NULL CHECK (Sexo IN ('M','F')),

    FechaNacimiento DATE,
    NumTelefono TEXT,

    CalleNombre TEXT,
    CalleNum INTEGER,
    Localidad TEXT,

    FechaAlta DATE NOT NULL,

    Categoria INTEGER NOT NULL,
    EstaActivo INTEGER NOT NULL CHECK (EstaActivo IN (0,1)),

    FOREIGN KEY (Categoria)
        REFERENCES CATEGORIA(IdCategoria)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);

-- =====================================================
-- TABLA: CATEGORIA
-- =====================================================
CREATE TABLE IF NOT EXISTS CATEGORIA (
    IdCategoria INTEGER PRIMARY KEY,
    Descripcion TEXT NOT NULL UNIQUE,
    ImporteBase REAL NOT NULL DEFAULT 0 CHECK (ImporteBase >= 0)
);

-- =====================================================
-- TABLA: CUOTA
-- =====================================================
CREATE TABLE IF NOT EXISTS CUOTA (
    Periodo DATE NOT NULL,
    Categoria INTEGER NOT NULL,
    Importe REAL NOT NULL CHECK (Importe >= 0),

    PRIMARY KEY (Periodo, Categoria),

    FOREIGN KEY (Categoria)
        REFERENCES CATEGORIA(IdCategoria)
        ON UPDATE CASCADE
        ON DELETE RESTRICT
);

-- =====================================================
-- TABLA: CUOTA_SOCIO
-- =====================================================
CREATE TABLE IF NOT EXISTS CUOTA_SOCIO (
    NumSocio INTEGER NOT NULL,
    Periodo DATE NOT NULL,
    Categoria INTEGER NOT NULL,

    EstaPaga INTEGER NOT NULL CHECK (EstaPaga IN (0,1)),
    FechaPago DATE,

    PRIMARY KEY (NumSocio, Periodo, Categoria),

    FOREIGN KEY (NumSocio)
        REFERENCES SOCIO(NumSocio)
        ON DELETE CASCADE,

    FOREIGN KEY (Periodo, Categoria)
        REFERENCES CUOTA(Periodo, Categoria)
        ON DELETE CASCADE
);
-- =====================================================
-- INDEX PARA MOROSOS
-- =====================================================
CREATE INDEX IF NOT EXISTS IX_CUOTA_SOCIO_NumSocio_Periodo
ON CUOTA_SOCIO (NumSocio, Periodo DESC);

-- =====================================================
-- TABLA: ANUAL
-- =====================================================
CREATE TABLE IF NOT EXISTS ANUAL (
    Anio INTEGER PRIMARY KEY
);

-- =====================================================
-- TABLA: ANUAL_SOCIO
-- =====================================================
CREATE TABLE IF NOT EXISTS ANUAL_SOCIO (
    NumSocio INTEGER NOT NULL,
    Anio INTEGER NOT NULL,

    PeriodoInicio DATE NOT NULL,
    FechaRegistro DATE NOT NULL,
    ImporteTotal REAL NOT NULL CHECK (ImporteTotal >= 0),
    ImportePorCuota REAL NOT NULL CHECK (ImportePorCuota >= 0),

    PRIMARY KEY (NumSocio, Anio),

    FOREIGN KEY (NumSocio)
        REFERENCES SOCIO(NumSocio)
        ON DELETE CASCADE,

    FOREIGN KEY (Anio)
        REFERENCES ANUAL(Anio)
        ON DELETE CASCADE
);

-- =====================================================
-- DATOS INICIALES
-- =====================================================
INSERT OR IGNORE INTO CATEGORIA (IdCategoria, Descripcion) VALUES (1, 'Adherente');
INSERT OR IGNORE INTO CATEGORIA (IdCategoria, Descripcion) VALUES (2, 'Comercio');
INSERT OR IGNORE INTO CATEGORIA (IdCategoria, Descripcion) VALUES (3, 'Grupo familiar');

-- =====================================================
-- VISTA: HISTORIA DE CUOTAS
-- =====================================================
CREATE VIEW IF NOT EXISTS VW_HISTORIAL_CUOTAS AS
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