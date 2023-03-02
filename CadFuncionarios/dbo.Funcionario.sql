CREATE TABLE [dbo].[Funcionario] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [CargoId]       INT            NOT NULL,
    [Nome]          NVARCHAR (250) NOT NULL,
    [CPF]           NVARCHAR (14)  NOT NULL,
    [DataAdmissao]  DATETIME2 (7)  NOT NULL,
    [DataCadastro]  DATETIME2 (7)  NOT NULL,
    [DataAlteracao] DATETIME2 (7)  NOT NULL,
    [DataExclusao]  DATETIME2 (7)  NOT NULL,
    [UtilizaVT]     BIT            NOT NULL,
    CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED ([Id] ASC)
);

