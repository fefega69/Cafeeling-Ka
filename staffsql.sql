

create table staff
(
staffID int primary key identity,
sName varchar(50),
sPhone varchar(50),
sRole varchar(50)
)

select * from staff

create table products
(
pID int primary key identity,
pName varchar(50),
pPrice float,
CategoryID int,
pImage image,
)

select pID, pName, pPrice, CategoryID, c.catName from products p inner join category c on c.catID = p.CategoryID


create table tblMain
(
MainID int primary key identity,
CashierName varchar(50),
status varchar(15),
ordertype varchar(15),
total float,
received float,
change float
)

drop table tblMain

create table tblDetails (
DetailID int primary key identity,
MainID int,
proID int,
qty int,
price float,
amount float
)