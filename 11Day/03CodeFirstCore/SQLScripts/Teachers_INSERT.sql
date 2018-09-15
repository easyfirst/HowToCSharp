USE [CodeFirstDB]
GO

IF NOT EXISTS(SELECT * FROM Teachers WHERE Name = 'John Smith')
BEGIN
	INSERT INTO [dbo].[Teachers]
			   ([Name])
		 VALUES
			   ('John Smith')
END
GO


