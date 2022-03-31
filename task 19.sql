create database Regform
go
use Regform
go
create table employeeInfo
(
ApplicantId int not null identity(20220001,1),
Fname varchar(50),
Lname varchar(50),
Gender char(10),
Address_Street varchar (100),
City varchar (100),
State varchar(100),
PinCode int,
ContactNo varchar(10),
EmailId varchar(50),
Dob date,
HighSchoolName varchar(50),
HYop int,
HMark float,
HrSec_SchoolName varchar(50),
HrSecYop int,
HrSecMark float,
Graduation_Degree varchar(50),
CollegeName varchar(50),
YoGraduation int,
Graduation_cgpa float,
Skill varchar(255),
PrevWork varchar(255),
DateofApplication date,
Constraint Pk_sno primary key(ApplicantId),
constraint Ck_gen check (Gender in('Male','Female','Other'))
)