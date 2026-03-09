-- modify the trigger to only insert the country if it's does not exists

ALTER  TRIGGER dbo.trg_customers
ON [dbo].[customers]
AFTER INSERT
AS
BEGIN
   insert into country
   SELECT
        country
    FROM
        inserted i where i.country not in (SELECT country FROM country)
END