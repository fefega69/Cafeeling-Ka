ALTER TABLE staff
ADD 
sUName varchar(50),
sPass varchar(50),
masterkey varchar(50);

select * from staff

INSERT INTO staff (sName, sPhone, sRole, sUName, sPass, masterkey)
VALUES ('Tester', '09567607545', 'Manager', 'test', 'testing', 'monkey');

INSERT INTO staff (sName, sPhone, sRole, sUName, sPass)
VALUES ('Administrator', '09567607545', 'Admin', 'admin', 'admin123');

delete from tblMain;
delete from tblDetails;
delete from products;
delete from category;
