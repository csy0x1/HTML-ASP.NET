CREATE TABLE [dbo].[c_table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [cdcode] CHAR(10) NOT NULL, 
    [cdname] NVARCHAR(50) NOT NULL, 
    [cdbalance] FLOAT NOT NULL, 
    [comments] NVARCHAR(200) NULL
)
