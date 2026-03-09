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


-- Get Products that are in Burger Category
select 
    cat.catId as categoryId,
    cat.catName as categoryName,
    prod.productId,
    prod.productName,
    prod.price
From products prod
Join categories cat on cat.catId = prod.catId
Where cat.catName like '%burge%'


-- Get Products Order By Category Name
select 
    cat.catId as categoryId,
    cat.catName as categoryName,
    prod.productId,
    prod.productName,
    prod.price
From products prod
Join categories cat on cat.catId = prod.catId
Order by cat.catName;


Create Table users(
    userId INT Not Null PRIMARY KEY IDENTITY(1,1),
    customerName varchar(50),
    phoneNumber varchar(50)
);

Insert into users values ('Jon Doe','+1 680 256 0084');
Insert into users values ('Jon Wick','+1 680 256 0085');
Insert into users values ('Tom Cruise','+1 680 256 0086');

Create Table orders(
    orderId Int Not Null PRIMARY KEY IDENTITY(1,1),
    orderBy INT Not Null,
    CONSTRAINT FK_Order_Customers FOREIGN KEY (orderBy) REFERENCES users(userId)
);

insert into orders values (1);
insert into orders values (2);
insert into orders values (3);


Create Table orderProducts(
    id int not null primary key IDENTITY(1,1),
    productId Int Not null,
    orderId Int not null,
    CONSTRAINT FK_OrderProducts_Product FOREIGN KEY (productId) REFERENCES products(productId),
    CONSTRAINT FK_OrderProducts_Order FOREIGN KEY (orderId) REFERENCES orders(orderId)
);


insert into orderProducts values (1,1);
insert into orderProducts values (2,1);
insert into orderProducts values (3,1);

insert into orderProducts values (5,2);
insert into orderProducts values (6,2);
insert into orderProducts values (7,2);
insert into orderProducts values (8,2);
insert into orderProducts values (9,2);

insert into orderProducts values (11,3);
insert into orderProducts values (12,3);
insert into orderProducts values (13,3);

-- Order Of John Wick With Total Price and Number Of Products
SELECT
    [user].userId,
    [user].customerName,
    [user].phoneNumber,
    [order].orderId,
    COUNT(orderProduct.id) as noOfProductsOrdered,
    SUM(product.price) as totalOrderPrice

From users [user]
Join orders [order] on [order].[orderBy] = [user].[userId]
Join orderProducts orderProduct on orderProduct.orderId = [order].[orderId]
Join products product on product.productId = [orderProduct].productId
where [user].[customerName] LIKE '%Wick%'
Group By 
[user].[userId],
[user].[customerName],
[user].[phoneNumber],
[order].[orderId];


-- Get the list of the products customer orderd with customer name 
Select 
    [user].userId,
    [user].customerName,
    [user].phoneNumber as customerPhoneNumber,
    product.productId,
    product.productName,
    product.price as productPrice
From [orderProducts] [orderProduct]

LEFT Join orders [order] on [order].[orderId] = orderProduct.orderId
LEFT Join [users] [user] on [user].[userId] = [order].[orderBy]
LEFT Join [products] [product] on [product].[productId] = orderProduct.productId;