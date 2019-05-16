ALTER TABLE [dbo].[Ventas] 
DROP CONSTRAINT FK_Ventas_Clientes;

ALTER TABLE [dbo].[Ventas] 
DROP CONSTRAINT [FK_Ventas_Stock];
