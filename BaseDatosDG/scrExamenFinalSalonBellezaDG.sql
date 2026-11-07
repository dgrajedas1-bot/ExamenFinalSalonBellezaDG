/* Examen Final Programación II - Tema III - Salón de Belleza
   Script no destructivo: crea la base y la tabla solo si no existen. */
IF DB_ID(N'ExamenFinalSalonBellezaDG') IS NULL
    CREATE DATABASE ExamenFinalSalonBellezaDG;
GO
USE ExamenFinalSalonBellezaDG;
GO
IF OBJECT_ID(N'dbo.tblCuentaDG', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.tblCuentaDG
    (
        IdCuentaDG        INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_tblCuentaDG PRIMARY KEY,
        NombreCompletoDG  NVARCHAR(150) NOT NULL,
        ServicioUnasDG    DECIMAL(12,2) NOT NULL CONSTRAINT CK_tblCuentaDG_Unas CHECK (ServicioUnasDG >= 0),
        HonorariosDG      DECIMAL(12,2) NOT NULL CONSTRAINT CK_tblCuentaDG_Honorarios CHECK (HonorariosDG >= 0),
        PeinadoDG         DECIMAL(12,2) NOT NULL CONSTRAINT CK_tblCuentaDG_Peinado CHECK (PeinadoDG >= 0),
        AplicacionTinteDG DECIMAL(12,2) NOT NULL CONSTRAINT CK_tblCuentaDG_Tinte CHECK (AplicacionTinteDG >= 0),
        BasesDG           DECIMAL(12,2) NOT NULL CONSTRAINT CK_tblCuentaDG_Bases CHECK (BasesDG >= 0),
        OtrosDG           DECIMAL(12,2) NOT NULL CONSTRAINT CK_tblCuentaDG_Otros CHECK (OtrosDG >= 0),
        TotalServiciosDG  DECIMAL(12,2) NOT NULL,
        TotalCuentaDG     DECIMAL(12,2) NOT NULL,
        FechaDG           DATETIME2(0)  NOT NULL CONSTRAINT DF_tblCuentaDG_Fecha DEFAULT (SYSDATETIME())
    );
END
GO
SELECT TOP (20) * FROM dbo.tblCuentaDG ORDER BY IdCuentaDG DESC;
GO
