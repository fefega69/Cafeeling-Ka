create table users
(
userID int primary key identity,
username varchar(16) not null,
upass varchar(16) not null,
uName varchar (50) not null,
uphone varchar (20) not null,
masterkey varchar(50) not null,
)

alter table users
add masterkey varchar(50) not null

insert into users(username,upass,uName,uphone,masterkey)values('test','testing','tester','696969696969','monkey')
insert into users(username,upass,uName,uphone,masterkey)values('test1','testing1','tester1','696969696968','dog')
insert into users(username,upass,uName,uphone,masterkey)values('test2','testing2','tester2','696969696967','eagle')

select * from users
