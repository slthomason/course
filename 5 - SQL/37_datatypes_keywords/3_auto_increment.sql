-- this will create with Id autoincrement

CREATE TABLE Comment (
    Id int IDENTITY(1,1) PRIMARY KEY,
    LastName varchar(255) NOT NULL,
    FirstName varchar(255),
    Comment varchar(500)
);