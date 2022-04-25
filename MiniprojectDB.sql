use dillidb
go
create table ProductTable(
ProdID int primary key identity(1,1),
ProdName varchar(50),
Price float,
MFD date default Getdate(),
ExpiryDate date default dateadd(year,1,getdate()) 
)
select * from ProductTable
insert into ProductTable(ProdName,Price) values('milk bikies',15),('sunrise coffee',5),('AAVIN Milk 500ML',26),('Marie Gold',20),('Sugar 1KG',50),('Lays',5)
create table CustomerTable
(
CustID int primary key identity(1,1),
Name varchar(50),
Gender char(1),
DoB varchar(20),
ContactNo varchar(10),
EmailID varchar(50),
City varchar(50)
)
select * from CustomerTable 
insert into CustomerTable(Name,Gender,DoB,ContactNo,EmailID,City) values
('DilliKumaran','M','12-07-2002','9677054298','dilliskumaran@gmail.com','Chennai'),
('Hariswar','M','20-06-2002','8752323654','hariswarharis@bmail.com','Mumbai'),
('Giridharan','M','22-05-2000','9957654221','giridhar2000@vmail.com','Chennai'),
('Divya','F','12-04-2001','6584952152','Divyashree2002','Mumbai')
create table Purchase
(
BillNo int primary key identity(4001,1),
CustID int ,
ProdID int,
Quantity int,
Total_Amount int,
Date date default getdate()
)
select * from Purchase
