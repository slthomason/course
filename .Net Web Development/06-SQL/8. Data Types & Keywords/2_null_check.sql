
--  get the customers whose address is null
SELECT CustomerName, ContactName, Address
FROM Customers
WHERE Address IS NULL;


--  get the customers whose address is not null
SELECT CustomerName, ContactName, Address
FROM Customers
WHERE Address IS not NULL;