-- Create temp table


CREATE TABLE dbo.country
	(
	Id int NOT NULL IDENTITY (1, 1),
	Name nvarchar(50) NULL
	)  ON [PRIMARY]



CREATE TRIGGER dbo.trg_customers
ON [dbo].[customers]
AFTER INSERT
AS
BEGIN
   insert into country
   SELECT
        country
    FROM
        inserted i
END


-- insert this row  and country table will have one row
INSERT INTO [dbo].[customers]
     VALUES
           (94
           ,'Spencer'
           ,'Spencer'
           ,'2732 Baker Blvd.'
           ,'Eugene'
           ,'97403'
           ,'USA')

SELECT * FROM country