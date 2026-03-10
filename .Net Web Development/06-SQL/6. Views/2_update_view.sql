CREATE OR REPLACE VIEW [Brazil_Customers] AS
SELECT CustomerName, ContactName, City
FROM Customers
WHERE Country = 'Brazil';