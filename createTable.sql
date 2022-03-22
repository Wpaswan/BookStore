create Table UserRegister(
userId int primary key identity(1,1),
FullName varchar(10),
EmailId varchar(25),
phNo varchar(20),
password varchar(20))
procedure sp_UserRegister
@FullName varchar(10),
@EmailId varchar(25),
@phNo varchar(20),
@password varchar(20)
As
Begin
Insert into UserRegister (FullName,EmailId,phNo,password) values (@FullName,@EmailId,@phNo,@password)
End