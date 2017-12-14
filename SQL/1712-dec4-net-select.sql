use fredsqlweek;
go

select *
from SalesLT.Customer;

select *
from SalesLT.Customer
where firstname = 'john';

select *
from SalesLT.Customer
where firstname = 'john' and LastName = 'arthur';

-- all with name john that are not arthur and all arthur.
select *
from SalesLT.Customer
where firstname = 'john' and not (lastName = 'arthur') or FirstName = 'arthur';

select *
from SalesLT.Customer
where firstname > 'j';

select *
from SalesLT.Customer
where firstname >= 'j' and FirstName < 'k';

select *
from SalesLT.Customer
where firstname like '%j%' and firstname like '%o%';

select *
from SalesLT.Customer
where firstname like 'j__';

select *
from SalesLT.Customer
where firstname like 'j__' or FirstName like 'o__';

select *
from SalesLT.Customer
where firstname like '[oj]__';

select count(*) as [Name], Title as Salutation, Title as "Greeting"
from SalesLT.Customer
where firstname = 'john' and LastName = 'arthur'
group by Title;

select count(*) as [Name], Title as Salutation, Title as "Greeting"
from SalesLT.Customer
where firstname = 'john'
group by Title;

select count(FirstName)as [count], Firstname, LastName
from SalesLT.Customer
where firstname = 'john'
group by LastName, FirstName
having count(FirstName) >= 0;

select count(FirstName)as [count], Firstname as FN, LastName as LN, CompanyName as CN
from SalesLT.Customer
where firstname = 'john'
group by LastName, FirstName, CompanyName
having count(FirstName) >= 0
order by CN asc, LN desc;

--Execution
--from
--where
--group by
--having
--select
--order by



