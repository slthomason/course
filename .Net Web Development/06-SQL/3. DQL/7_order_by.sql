SELECT * FROM Customers
ORDER BY Country;

SELECT * FROM Customers
ORDER BY Country DESC;

--ORDER BY Several Columns Example 1
SELECT * FROM Customers
ORDER BY Country, CustomerName;

--ORDER BY Several Columns Example 2
SELECT * FROM Customers
ORDER BY Country ASC, CustomerName DESC;
