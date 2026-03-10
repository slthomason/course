create database restaurant;
use restaurant;

create table categories(
    catId INT NOT NULL IDENTITY(1,1) PRIMARY Key,
    catName VARCHAR(50) Not NULL
);
CREATE UNIQUE INDEX IX_CatId ON categories(catId);

create table products(
    productId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    productName varchar(50),
    price decimal(4,2),
    catId INT,
    CONSTRAINT FK_Products_Categories FOREIGN KEY (catId) REFERENCES categories(catId)
);

Create UNIQUE INDEX IX_PRODUCTID ON products (productId);


Insert INTO categories values('Fast Food');
Insert INTO categories values('Burger');
Insert INTO categories values('Pizza');
Insert INTO categories values('Roasted');
Insert INTO categories values('Drinks');
Insert INTO categories values('Italian');


INSERT INTO products values ('Fish',20.5,1);
INSERT INTO products values ('Chips',10.5,1);
INSERT INTO products values ('Sandwiches',10.5,1);

INSERT INTO products values ('Turkey burger',50.5,2);
INSERT INTO products values ('Veggie burger',25.5,2);
INSERT INTO products values ('Bean burger',30.5,2);

INSERT INTO products values ('Chicago Deep-Dish Pizza',10.5,3);
INSERT INTO products values ('New York-style Pizza.',5.5,3);
INSERT INTO products values ('Detroit-style Pizza.',45.5,3);

INSERT INTO products values ('Roasted Potatoes',5.1,4);
INSERT INTO products values ('Roasted Butternut Squash',4.56,4);
INSERT INTO products values ('Roasted Chicken',60.5,4);

INSERT INTO products values ('Coke',2.5,5);
INSERT INTO products values ('Pepsi',2.5,5);
INSERT INTO products values ('Mint Margarita',3.2,5);

INSERT INTO products values ('Spaghetti',10.5,6);
INSERT INTO products values ('Risotto',15.5,6);
INSERT INTO products values ('Polenta',12.5,6);


-- Select that matches Bur
select 
    cat.catId as categoryId,
    cat.catName as categoryName
From categories cat
Where cat.catName like 'bur%';

-- Select that matches za
select 
    cat.catId as categoryId,
    cat.catName as categoryName
From categories cat
Where cat.catName like '%za';

-- Avarage Price of Burgers
select 
    AVG(prod.price) as averagePrice
From products prod
Where prod.catId = 2;

-- Items having Price is between 5 and 30
select 
    prod.productId,
    prod.productName,
    prod.price
From products prod
Where prod.price >= 5 and prod.price <= 20;


-- Update Product
update products set price = 90 where catId = 1;

-- Delete Product
delete from products where catId = 6;