create database CAROACCOUNTS
go

use CAROACCOUNTS
go

SET DATEFORMAT DMY
-----------------------
create table CaRoGameAccounts (
	UserName nvarchar(100) primary key,
	PassWord nvarchar(500) not null default 0,
	FullName nvarchar(100) not null default N'User',
	Email nvarchar(150) not null,
	BirthDay Date not null,
)

select * from dbo.CaRoGameAccounts

