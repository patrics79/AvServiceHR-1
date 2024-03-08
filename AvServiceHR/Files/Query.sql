


-----------------------
-- FirstName di persona della tabella PERSON che hanno piu di 50 occorrenze
select p.FirstName, count(*) as occorrenze
from PERSON.Person p
group by p.FirstName
having count(*) > 50;













-------------------------------
----Sulla base della prima query trova in FirstName con piu' occorrenze 

-- forse non ho capito la richiesta: FirstName con più occorrenze?
select top 1 p.FirstName, count(*) as occorrenze
from PERSON.Person p
group by p.FirstName
having count(*) > 50
order by count(*) desc;

-- o voglio sapere tutti i dati delle PERSON che hanno piu di 50 occorrenze dello stesso FirstName?
select p.*
from PERSON.Person p
where p.FirstName in (
		select p.FirstName
	   	  from PERSON.Person p
		 group by p.FirstName
		having count(*) > 50
	)
order by p.FirstName, p.MiddleName, p.LastName;







--------------------------------------------------
----Per ogni Regione americana il numero di occorrenze del FirstName 'Richard' 
select sp.Name as REGION_OF_US, count(p.BusinessEntityID) as NUM_RICHARD
from person.StateProvince sp
left join person.Address a on a.StateProvinceID = sp.StateProvinceID
left join person.BusinessEntityAddress bea on bea.AddressID = a.AddressID
left join person.Person p on p.BusinessEntityID = bea.BusinessEntityID and p.FirstName = 'Richard'
where sp.CountryRegionCode = 'US'
group by sp.Name
order by sp.Name
