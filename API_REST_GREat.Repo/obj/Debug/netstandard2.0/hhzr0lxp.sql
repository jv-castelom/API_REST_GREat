IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Usuarios] (
    [Id] int NOT NULL IDENTITY,
    [Nome] nvarchar(50) NOT NULL,
    [CPF] nvarchar(max) NULL,
    [RG] nvarchar(max) NULL,
    [Filiacao_Mae] nvarchar(50) NOT NULL,
    [Filiacao_Pai] nvarchar(max) NULL,
    [DataNasc] nvarchar(max) NULL,
    [DataCadastro] nvarchar(max) NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200727205843_initial', N'3.1.0');

GO

