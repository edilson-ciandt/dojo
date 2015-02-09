CREATE TABLE [dbo].[Cartao]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [IdCliente] NVARCHAR(50) NOT NULL, 
    [IdConta] NVARCHAR(50) NOT NULL, 
    [Limite] FLOAT NOT NULL,

)
