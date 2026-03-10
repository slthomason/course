-- updates the first customer (CustomerID = 1) with a new contact person and a new city.

UPDATE Customers
SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
WHERE CustomerID = 1;