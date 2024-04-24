-- to create a new database
create database db_apple;

--to create a new database table in existing database
use db_apple;
create table tbl_students
(
	roll int primary key identity(1,1),
	sname varchar(255) not null,
	saddress varchar(255) not null,
	smarks int not null,
	sdob date not null
);

-- to insert a piece of information into database table with table fields : Method 1
use db_apple;
insert into tbl_students (sname,saddress,smarks,sdob) values ('Ram','Pokhara',45,'1999-02-14');

-- to see all the data from database table
use db_apple;
select * from tbl_students;


-- to insert a piece of information into database table without using table fields : Method 2
use db_apple;
insert into tbl_students values ('Sita','Dharan',55,'2000-02-22');


-- to insert multiple information into database table without using table fields : Method 3
use db_apple;
insert into tbl_students values
('Hari','Butwal',56,'2012-02-22'),
('Gita','Chitwan',78,'1998-03-26'),
('Nita','Itahari',99,'2013-11-25'),
('Mita','Biratnagar',90,'2022-04-27'),
('Mina','Pokhara',23,'1999-12-02');