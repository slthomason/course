
-- finds the price of the cheapest product:
SELECT MIN(Price) AS SmallestPrice
FROM Products;

-- finds the price of the most expensive product:
SELECT MAX(Price) AS LargestPrice
FROM Products;

-- finds the number of products:
SELECT COUNT(ProductID)
FROM Products;

-- finds the average price of all products:
SELECT AVG(Price)
FROM Products;

-- sum of the "Quantity" fields in the "OrderDetails" table:
SELECT SUM(Quantity)
FROM OrderDetails;