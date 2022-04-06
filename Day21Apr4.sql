use AdventureWorks2019
go
--Task1
select  COUNT(+StandardCost) Totalnoofrows
from Production.ProductCostHistory
--USING SUM()
select SUM(StandardCost) SumCost
from Production.ProductCostHistory
--USING DATEDIFF()
select DATEDIFF(YY,StartDate,EndDate) datedifference
from Production.ProductCostHistory
--USING ADDDATE()
SELECT DATEADD(year, 3, '2017/08/25') AS DateAdd
--USING CONVERT()
SELECT CONVERT(int,55.69);
--USING LEFT()
SELECT LEFT('Dilli', 3) AS ExtractString;
--USING LEN()
select LEN('Dillikumaran')
--USING REVERSE()
select REVERSE('TeneT')

--Task 2 

create function fn_RupeesC(@amount as Nvarchar(20))
returns Nvarchar(20)
as 
begin
return (N'₹'+@amount)
end
select BusinessEntityID,dbo.fn_RupeesC(rate) as Rupees
from HumanResources.EmployeePayHistory

--Task3

create table tbl_student
(
Sno int primary key identity(1,1),
StuName varchar(20),
StuAge int,
Gender char(1),
MobileNO char(10)
)
go
create view task3
as
(
select Sno,StuName,StuAge,Gender,MobileNO
from dbo.tbl_student
)
go
insert into task3 values('selena',18,'F',9945213662)
select * from tbl_student
insert into tbl_student values('dilli',19,'M',9677052314)
select * from task3

--Task4

use dillidb
go
exec sp_help tbl_just
create table tbl_just
(
sno int primary key identity(1,1),
name varchar(50),
age int,
gender char(1)
)
select * from dbo.tbl_just
go
create proc taskIns_sp
@name varchar(50),
@gender char(1)
as
insert into tbl_just(name,gender)
values(@name,@gender)

taskIns_sp 'gayathri','F'
go
create proc taskUp_sp
@age int,
@sno int
as
update tbl_just set age=@age where sno = @sno

taskup_sp 20,3
go
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
where DaysToManufacture = (select DaysToManufacture from Production.Product where Name = 'Blade')

--Task6

select Name
from Production.Product
where  Name like '%ALL%'  or name like '%ANY%' or name like '%soME%'

select ProductModelID,weight
from  Production.Product
where weight in (select max(weight) from Production.Product GRoup By ProductModelID)

--Task7

use  AdventureWorks2019
go

select FirstName,LastName,ster.name,CountryRegionCode
from Person.Person per
join Sales.SalesPerson sper
on per.BusinessEntityID = sper.BusinessEntityID
join Sales.SalesTerritory ster
on sper.TerritoryID= ster.TerritoryID
where sper.salesYTD in (select MAX(SalesYTD) from Sales.SalesPerson group by TerritoryID)
