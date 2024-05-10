USE [dbEmployeeTrackerCF]
GO

INSERT INTO [dbo].[Requests]
           ([RequestMessage]
           ,[RequestDate]
           ,[ClosedDate]
           ,[RequestStatus]
           ,[RequestRaisedBy]
           ,[RequestClosedBy])
     VALUES
           ('Need Laptop',	'2024-05-09 00:00:00.0000000',	NULL,	'Open',	103,	101)
GO


