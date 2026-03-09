
-- add new column
ALTER TABLE Persons
ADD Email varchar(255);


-- drop the column
ALTER TABLE Persons
DROP COLUMN LastName;


-- change the datatype of the column

ALTER TABLE Persons
ALTER COLUMN FirstName varchar(500);
