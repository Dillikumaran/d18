use dillidb
go
create table Tbl_EnrollmentTask
(
studentId int primary key identity(1,1),
StudentName varchar(20),
Gender char(1),
ContactNo varchar(10)
)
go
create proc sp_Inst
@Cont int,
@Name varchar(20)
as
insert into Tbl_EnrollmentTask(StudentName,ContactNo) values(@Name,@Cont)
go
create proc sp_Updt
@sId int,
@Gen char(1)
as
update Tbl_EnrollmentTask set Gender=@Gen where studentId=@sId
go
create proc sp_Delt
@sId int
as
delete from Tbl_EnrollmentTask where studentId=@sId