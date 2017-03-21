USE Sample;

alter table dbo.tblEmployee
alter column EmployeeId integer not null;

alter table dbo.tblEmployee
add constraint PK_tblEmployee primary key (EmployeeId);


alter table dbo.tblEmployee
alter column EmployeeId int;

alter table dbo.tblEmployee
drop Constraint PK_tblEmployee;


alter table dbo.tblEmployee
add DepartmentId int;

alter table tblEmployee
add foreign key (DepartmentId)
references tblDepartment(Id);

alter table dbo.tblDepartment
add constraint PK_tblDepartment primary key (Id);

alter table dbo.tblEmployee
alter column DepartmentId integer not null;