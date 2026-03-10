CREATE VIEW [Brazil_Customers] AS
SELECT CustomerName, ContactName
FROM Customers
WHERE Country = 'Brazil';