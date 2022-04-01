use AdventureWorks2019
go
--task1
select FirstName,LastName
from Person.Person
where (Title)is not null 
go
--task2
select FirstName,LastName
from Person.Person
where FirstName like'%a%' or LastName like '%a%'
go
--task3
create view CodeandName
as
select Name,CountryRegionCurrency.CurrencyCode
from Sales.Currency,Sales.CountryRegionCurrency
go
select * from CodeandName
--task4
select * from HumanResources.Department
select * into HumanResources.Dept from HumanResources.Department
select * from HumanResources.Dept
--task5
create table Task5
(
SNo int primary key identity (1,1),
NAme varchar(50),
age int,
Department varchar(50),
salery int
)
insert into Task5 (NAme,age,Department,salery) values('Dillikumaran',19,'salesandMarketing',10000)
insert into Task5 (NAme,age,Department,salery) values('Hariswar',20,'executive',9000)
insert into Task5 (NAme,age,Department,salery) values('Giridharan',22,'cto',15000)
insert into Task5 (NAme,age,Department,salery) values('Abdul',20,'salesandmarketing',20000)
insert into Task5 (NAme,age,Department,salery) values('Sanntosh',18,'ceo',25000)
insert into Task5 (NAme,age,Department,salery) values('Dillikumaran',19,'salesandMarketing',10000)
insert into Task5 (NAme,age,Department,salery) values('Hariswar',20,'executive',9000)
insert into Task5 (NAme,age,Department,salery) values('Giridharan',22,'cto',15000)
insert into Task5 (NAme,age,Department,salery) values('Abdul',20,'salesandmarketing',20000)
insert into Task5 (NAme,age,Department,salery) values('Sanntosh',18,'ceo',25000)
insert into Task5 (NAme,age,Department,salery) values('Dillikumaran',19,'salesandMarketing',10000)
insert into Task5 (NAme,age,Department,salery) values('Hariswar',20,'executive',9000)
insert into Task5 (NAme,age,Department,salery) values('Giridharan',22,'cto',15000)
insert into Task5 (NAme,age,Department,salery) values('Abdul',20,'salesandmarketing',20000)
insert into Task5 (NAme,age,Department,salery) values('Sanntosh',18,'ceo',25000)
insert into Task5 (NAme,age,Department,salery) values('Dillikumaran',19,'salesandMarketing',10000)
insert into Task5 (NAme,age,Department,salery) values('Hariswar',20,'executive',9000)
insert into Task5 (NAme,age,Department,salery) values('Giridharan',22,'cto',15000)
insert into Task5 (NAme,age,Department,salery) values('Abdul',20,'salesandmarketing',20000)
insert into Task5 (NAme,age,Department,salery) values('Sanntosh',18,'ceo',25000)
select * from Task5
--Task6
select dhis.BusinessEntityID,AddressTypeID
from HumanResources.Department dept
join HumanResources.EmployeeDepartmentHistory dhis
on dept.DepartmentID = dhis.DepartmentID
join Person.BusinessEntityAddress benad
on dhis.BusinessEntityID = benad.BusinessEntityID
--Task7

select * from HumanResources.Department
select distinct GroupName
from HumanResources.Department
--Task8
select * from Production.Product
select * from Production.ProductCostHistory
select pro.StandardCost, sum(pro.ListPrice) ListPriceSum,sum(prod.StandardCost)StandardCostSum
from Production.ProductCostHistory prod
join production.Product pro
on prod.ProductID = pro.ProductID
group by pro.StandardCost
go

--Task9

select datediff(yy,StartDate,EndDate) Years_on_role
from HumanResources.EmployeeDepartmentHistory

--task10

select sum(SalesQuota) salesQuotaSum 
from Sales.SalesPersonQuotaHistory
where SalesQuota>5000 and salesQuota<100000
group by SalesQuota
order by salesQuotaSum
--task11

select max(TaxRate) Max_taxrate
from sales.SalesTaxRate
--Task12

select dept.DepartmentID,dhis.BusinessEntityID,dhis.shiftId,datediff(YYYY,emp.BirthDate,GETDATE()) BirthDate
from HumanResources.Department dept
join HumanResources.EmployeeDepartmentHistory dhis
on dept.DepartmentID = dhis.DepartmentID
join [HumanResources].[Employee] emp
on emp.BusinessEntityID=dhis.BusinessEntityID
go
--Task13

create view Name_age
as
select dept.DepartmentID,dhis.BusinessEntityID,dhis.shiftId,datediff(YYYY,emp.BirthDate,GETDATE()) BirthDate
from HumanResources.Department dept
join HumanResources.EmployeeDepartmentHistory dhis
on dept.DepartmentID = dhis.DepartmentID
join [HumanResources].[Employee] emp
on emp.BusinessEntityID=dhis.BusinessEntityID
select* from Name_age
go
--Task14

select count(*) No_of_rows_hr
from HumanResources.Department,
HumanResources.Employee,
HumanResources.EmployeeDepartmentHistory,
HumanResources.EmployeePayHistory,
HumanResources.JobCandidate,
HumanResources.Shift
go
--Task15

select dep.name, max(Rate) Max_rate
from HumanResources.EmployeePayHistory ph
join HumanResources.EmployeeDepartmentHistory emp
on ph.BusinessEntityID=emp.BusinessEntityID
join HumanResources.Department dep
on emp.DepartmentID=dep.DepartmentID
group by Name

--Task16

select FirstName,MiddleName,Title,AddressTypeID,benad.BusinessEntityID
from person.Person per
left outer join Person.BusinessEntityAddress benad
on per.BusinessEntityID = benad.BusinessEntityID
where (Title)is not null
--Task17

select ProductID,LocationID,Shelf
from Production.ProductInventory
where (ProductID>300 and ProductID<=350) and( LocationID = 50 or Shelf = 'E')
--Task18

select lp.LocationID,Shelf,Name
from Production.ProductInventory inp
join Production.Location lp
on lp.LocationID = inp.LocationID
--task19

select AddressID,AddressLine1,AddressLine2,pa.StateProvinceID,StateProvinceCode,CountryRegionCode
from person.Address pa
join person.StateProvince psp
on pa.StateProvinceID=psp.StateProvinceID
--Task20

select CurrencyCode,sum(SubTotal) SubTotalSum,sum(TaxAmt) TaxAmtSum
from sales.CountryRegionCurrency crc
join sales.SalesTerritory st
on crc.CountryRegionCode=st.CountryRegionCode
join Sales.SalesOrderHeader soh
on soh.TerritoryID=st.TerritoryID
group by crc.CurrencyCode

select * from Sales.CountryRegionCurrency
select * from Sales.SalesTerritory