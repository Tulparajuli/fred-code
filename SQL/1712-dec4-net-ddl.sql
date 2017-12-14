/*
use master;
go

create database PizzaDB;
go

use PizzaDB;
go
*/

create schema Pizza;
go
/*
create table Pizza.Topping
(
	ToppingId int identity primary key --tinyint, smallint, int, bigint
	,Name nvarchar(50) not null --char, varchar, nchar, nvarchar
	,ModifiedDate Datetime2(0) not null --date, time, datetime
	,Active bit not null default(1)
);
go
*/

create table Pizza.Topping
(
	ToppingId int not null identity --primary key --tinyint, smallint, int, bigint
	,Name nvarchar(50) not null --char, varchar, nchar, nvarchar
	,ModifiedDate Datetime2(0) not null --date, time, datetime
	,Active bit not null --default(1)
);

create table Pizza.Crust
(
	CrustId int not null IDENTITY
	,Name nvarchar(50) not null
	,ModifiedDate Datetime2(0) not NULL
	,Active bit not null
);

create table Pizza.Pizza
(
	PizzaId int not null identity
	,CrustId int null
	,Name nvarchar(50) not null
	,ModifiedDate Datetime2(0) not NULL
	,Active bit not null
);

create table Pizza.PizzaTopping
(
	PizzaToppingId int not null identity
	,PizzaId int not null
	,ToppingId int not null
);
go

--primary key
alter table Pizza.Crust
	add constraint PK_Crust_CrustId primary key clustered (CrustId);

alter table Pizza.Pizza
	add constraint PK_Pizza_PizzaId primary key clustered (PizzaId);

alter table Pizza.PizzaTopping
	add constraint PK_PizzaTopping_PizzaToppingId primary key clustered (PizzaToppingId);

alter table Pizza.Topping
	add constraint PK_Topping_ToppingId primary key clustered (ToppingId);

--foreign key
alter table Pizza.Pizza
	add constraint FK_Pizza_CrustId foreign key (CrustId) references Pizza.Crust(CrustId) on update cascade;

alter table Pizza.PizzaTopping
	add constraint FK_PizzaTopping_PizzaId foreign key (PizzaId) references Pizza.Pizza(PizzaId) on update cascade;

alter table Pizza.PizzaTopping
	add constraint FK_PizzaTopping_ToppingId foreign key (ToppingId) references Pizza.Topping(ToppingId) on update cascade;

--default
alter table Pizza.Pizza
	add constraint DF_Pizza_Active default(1) for Active;

--check
alter table Pizza.Pizza
	add constraint CK_Pizza_ModifiedDate check (ModifiedDate = getdate()); --sysutcdatetime
	
--computed
alter table Pizza.Pizza
	add ComputedName as Name + '-' + CrustId persisted;
go

--view
create view Pizza.VW_Toppings with schemabinding
as
select Name
from Pizza.Topping
where Active = 1;
go

--function
create function Pizza.FN_Toppings()
returns nvarchar(max)
as
begin
	declare @ret nvarchar(max);

	select top(1) @ret = Name
	from Pizza.Topping;

	return @ret;
end
go

create function Pizza.FN_ToppingsStatus(@status bit)
returns nvarchar(max)
as
begin
	declare @ret nvarchar(max);

	select top(1) @ret = Name
	from Pizza.Topping
	where Active = @status;

	return @ret;
end
go

create function Pizza.FN_ToppingsTable()
returns table
as
begin
	return
	select Name
	from Pizza.Topping;
end
go

create function Pizza.FN_ToppingsTableStatus(@status bit)
returns table
as
return
	select Name
	from Pizza.Topping
	where Active = @status;
go


--stored procedure
create procedure Pizza.SP_Toppings(@topping nvarchar(50))
as
begin
	begin transaction
	begin try
		declare @topid int;

		select @topid = toppingid
		from Pizza.Topping
		where Name = @topping;
	
		if @topid is not null
		begin
			update Pizza.Topping
			set Name = @topping
			where toppingid = @topid;

			raiserror('this is an error', 16, 50000);
		
			return
				select @topid = toppingid
				from Pizza.Topping
				where Name = @topping;
		end
		else
		begin
			insert into Pizza.Topping(Name, ModifiedDate)
			values (@topping, getutcdate());

			throw 50001, 'this is another error', 16;
		end

		commit transaction;
	end try

	begin catch
		print error_message();
		print error_state();
		print error_number();
		print error_severity();
		print @@rowcount;
		print @@trancount;
		print @@error;
		rollback transaction;
	end catch
end
go

alter procedure Pizza.SP_Toppings(@topping nvarchar(50), @something nvarchar(max) out)
as
begin
	begin transaction
	begin try
		declare @topid int;

		select @topid = toppingid
		from Pizza.Topping
		where Name = @topping;
	
		if @topid is not null
		begin
			update Pizza.Topping
			set Name = @topping
			where toppingid = @topid;

			--raiserror('this is an error', 16, 50000);

			set @something = 'variable';

			--return
			select name
			from Pizza.Topping
			where Name = @topping;
		end
		else
		begin
			--set identity_insert pizza.topping on;
			insert into Pizza.Topping(Name, ModifiedDate, Active)
			values (@topping, getutcdate(), 1);

			--throw 50001, 'this is another error', 16;
		end

		--commit transaction;
		--set identity_insert pizza.topping off;
	end try

	begin catch
		print @@error;
		print error_message();
		print error_state();
		print error_number();
		print error_severity();
		print @@rowcount;
		print @@trancount;
		rollback transaction;
	end catch
end

--use procedure, function, view
declare @response nvarchar(max);
execute Pizza.SP_Toppings 'pepperoni', @response out;
print @response;

select * from Pizza.FN_ToppingsTableStatus(1);

update Pizza.Topping
set Name = Pizza.FN_ToppingsStatus(1);

select * from Pizza.VW_Toppings;

select * from Pizza.Topping;
go


--drop and truncate
--truncate table Pizza.Topping;
--drop table Pizza.Topping;

create trigger Pizza.TR_Topping on Pizza.Topping
for update
as
select * from Pizza.Topping;
go

alter trigger Pizza.TR_ToppingIO on Pizza.Topping
instead of update
as
if object_id(N'inserted') is not null
begin
	select ToppingId, Name, ModifiedDate, Active from inserted; --local temporal table, temporary table.
	select ToppingId, Name, ModifiedDate, Active from deleted;
	select * from Pizza.Topping;
end
go

declare @@TempTable table(Id int);

update Pizza.Topping
set Name = 'pepperoni'
output inserted.ToppingId into @@TempTable
where name = 'peppers';

select * from @@TempTable;


--case when
select
case

	Name when 'peppers' then 'pepperoni'
end
from Pizza.Topping;

select
case when Name > 'a' then 'it is good'
end
from Pizza.Topping;