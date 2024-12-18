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

alter table CaRoGameAccounts add Wins int default 0 
alter table CaRoGameAccounts add Rank nvarchar(100) default 'plastic'

select * from dbo.CaRoGameAccounts

