use AdventureWorks2019
go
--Task1
select  COUNT(+[StandardCost]) Totalnoofrows
from [Production].[ProductCostHistory]
--USING SUM()
select SUM([StandardCost]) SumCost
from [Production].[ProductCostHistory]
--USING DATEDIFF()
select DATEDIFF(YY,StartDate,EndDate) datedifference
from [Production].[ProductCostHistory]
--USING ADDDATE()
SELECT DATEADD(year, 3, '2017/08/25') AS DateAdd
--USING CONVERT()
SELECT CONVERT(int,88.77);
--USING LEFT()
SELECT LEFT('Dilli', 3) AS ExtractString;
--USING LEN()
select LEN('Dillikumaran')
--USING REVERSE()
select REVERSE('TeneT')

--Task 2 

create function fn_RupeesC(@amount as Nvarchar(10))
returns Nvarchar(10)
as 
begin
return (N'₹'+@amount)
end
select BusinessEntityID,dbo.fn_RupeesC(rate) as Rupees 
from HumanResources.EmployeePayHistory

--Task3

create table tbl_student
(
Sno int primary key identity (1,1),
StuName varchar(20),
StuAge int,
Gender char(1),
MobileNO char(10)

)
insert into tbl_student values('Dilli',19,'M',9600584521)

create view task3
as
select Sno,StuName,StuAge
from dbo.tbl_student
go
select *from task3
insert into task3 values('selena',19,'F',9945215421)

--Task4

use dillidb
go
create table tbl_just
(
sno int primary key identity(1,1),
name varchar(50),
age int,
gender char(1)
)
exec sp_help tbl_just
select * from dbo.tbl_just

create proc taskIns_sp
@name varchar(50),
@gender char(1)
as
insert into tbl_just(name,gender)
values(@name,@gender)

taskIns_sp 'dilli','M'

create proc taskup_sp
@sno int,
@age int,
as
update tbl_just set age=@age where sno = @sno

taskup_sp 19,1

create proc taskDel_sp
@sno int
as
delete from tbl_just where sno = @sno

taskDel_sp 1

--Task5

use AdventureWorks2019
go
select name, DaysToManufacture
from Production.Product 
where name = ('blade')(select b.Name,b.DaysToManufacture from Production.Product b
where b.DaysToManufacture like('1'))

--Task6

select Name
from Production.Product
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max(Weight) as Maxweight,ProductModelID
from  Production.Product
GRoup By ProductModelID

--Task7

select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name
