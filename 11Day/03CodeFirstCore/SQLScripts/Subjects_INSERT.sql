USE [CodeFirstDB]
GO

IF NOT EXISTS(SELECT * FROM Subjects WHERE Name = 'History' AND TeacherId = 1)
BEGIN
	INSERT INTO [dbo].[Subjects]
			   ([Name]
			   ,[TeacherId])
		 VALUES
			   ('History'
			   ,1)
END
GO

IF NOT EXISTS(SELECT * FROM Subjects WHERE Name = 'Math' AND TeacherId = 1)
BEGIN
	INSERT INTO [dbo].[Subjects]
			   ([Name]
			   ,[TeacherId])
		 VALUES
			   ('Math'
			   ,1)
END
GO

