-- find the product on the basis of Category Name

SELECT *
  FROM [products] WHERE [CategoryID]  in (SELECT [CategoryID] FROM [categories] WHERE CategoryName = 'Beverages')