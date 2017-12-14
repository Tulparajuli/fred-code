SELECT * FROM SalesLT.Address;

--simple INSERT
insert into SalesLT.Address
values ('123 main st', null, 'reston', 'virginia', 'usa', '20190', '268AF621-76D7-4C78-9441-144FD139821F', '2017-12-13');

--normal insert
insert into SalesLT.Address(ModifiedDate, AddressLine1, City, StateProvince, CountryRegion, PostalCode, rowguid)
values 
('2017-12-13', '187 main st', 'reston', 'virginia', 'usa', '20190', '268AF621-76D7-4C78-9441-144FD139821D')
,('2017-12-13', '312 main st', 'reston', 'virginia', 'usa', '20190', '268AF621-76D7-4C78-9441-144FD139821C')
,('2017-12-13', '509 main st', 'reston', 'virginia', 'usa', '20190', '268AF621-76D7-4C78-9441-144FD139821B');

--enhanced insert
insert into SalesLT.Address(ModifiedDate, AddressLine1, City, StateProvince, CountryRegion, PostalCode)
select ModifiedDate as Epoch, AddressLine1 as Street1, City as Town, StateProvince, CountryRegion, PostalCode
from SalesLT.Address
where ModifiedDate = '2006-07-01';

--bulk insert
bulk insert SalesLT.Address from 'C:\Users\fredio\Downloads\data.csv' with (fieldterminator = ',', rowterminator = '\n');

--simple update
update SalesLT.Address
set AddressLine2 = 'plaza america';

--normal update
select *
from SalesLT.Address
where ModifiedDate = '07-01-2006';

update SalesLT.Address
set AddressLine2 = 'revature'
where ModifiedDate = '07-01-2006';

--enhanced update
update a
set a.addressline2 = 'dotnet'
from SalesLT.Address as a
where a.addressline2 = 'plaza america';


--simple delete
--delete from SalesLT.Address;

--normal delete
select *
from SalesLT.Address
where ModifiedDate = '12-13-2017';

delete from SalesLT.Address
where ModifiedDate = '12-13-2017';

--enhanced update
delete from a
from SalesLT.Address as a
where a.modifieddate = '12-13-2017';


