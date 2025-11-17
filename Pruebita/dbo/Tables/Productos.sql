CREATE TABLE [dbo].[Productos] (
    [Id]     INT             IDENTITY (1, 1) NOT NULL,
    [Nombre] NVARCHAR (100)  NOT NULL,
    [Precio] DECIMAL (10, 2) NOT NULL,
    [Stock]  INT             NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

