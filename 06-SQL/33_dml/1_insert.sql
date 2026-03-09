--insert with column names

INSERT INTO Customers (CustomerID,CustomerName, ContactName, Address, City, PostalCode, Country)
VALUES (92,'Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway');

--insert without column names
INSERT INTO Customers VALUES (93,'Cardinal', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway');



-- creating temp table
CREATE TABLE [dbo].[customers_temp](
	[CustomerID] [int] NOT NULL,
	[CustomerName] [varchar](255) NULL,
	[ContactName] [varchar](255) NULL,
	[Address] [varchar](255) NULL,
	[City] [varchar](255) NULL,
	[PostalCode] [varchar](255) NULL,
	[Country] [varchar](255) NULL
) ON [PRIMARY]
GO

-- insert into select
INSERT INTO customers_temp 
SELECT * FROM customers;


-- drop temp table
drop table [customers_temp]