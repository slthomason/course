-- where clause -- string comparision
SELECT * FROM Customers
WHERE Country='Mexico';

--  where clause -- number comparision
SELECT * FROM Customers
WHERE CustomerID=1;

--  where clause with greater than 
SELECT * FROM Products
WHERE Price > 30;

--  where clause with less than 
SELECT * FROM Products
WHERE Price < 30;

--  where clause with greater than and equal to
SELECT * FROM Products
WHERE Price >= 30;

--  where clause with less than and equal to
SELECT * FROM Products
WHERE Price <= 30;

--  where clause with not equal to
SELECT * FROM Products
WHERE Price <> 18;

--  where clause with between
SELECT * FROM products
WHERE Price BETWEEN 50 AND 60;

--  where clause with IN
SELECT * FROM Customers
WHERE City LIKE '%s%'
