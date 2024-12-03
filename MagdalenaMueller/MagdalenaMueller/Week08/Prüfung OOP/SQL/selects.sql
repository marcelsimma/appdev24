1. Select name,population From country where name = 'Austria';

2. Select * From geo_river where country = 'A';

3. Select name From country where name like 'A%';

4. 	SELECT SUM(population) AS gesamt_einwohner 
	FROM country inner join encompasses 
	where country.Code = encompasses.country 
	AND encompasses.continent = 'Europe' ;


5. Select DISTINCT river.name
	From river, geo_river, province, country, encompasses, continent
	where river.name = geo_river.river
	and geo_river.province = province.name
	and province.country = country.code
	and country.code = encompasses.country
	and encompasses.continent = continent.name
	and continent.name = 'Europe'
	order by river.name;

6.	SELECT DISTINCT river.name, river.length
	FROM river, geo_river, province, country, encompasses, continent	
	WHERE river.name = geo_river.river
	AND geo_river.province = province.name
	AND province.country = country.code
	AND country.code = encompasses.country
	AND encompasses.continent = continent.name
	AND continent.name = 'Europe'
	ORDER BY river.length desc;

7.	SELECT country.name, province.name, province.population 
	FROM mondial.province 
	INNER JOIN mondial.country 
	ON country.code = province.Country 
	WHERE country.name LIKE 'A%' 
	ORDER BY province.Name, province.Population;

8. 	SELECT geo_mountain.Mountain, mountain.Height  
	FROM geo_mountain INNER JOIN mountain 
	where country = 'A' AND geo_mountain.Mountain = mountain.Name
	ORDER BY mountain.Height DESC 
	LIMIT 1;
	
9.	SELECT DISTINCT island.name, religion.percentage, islandin.sea
	FROM island, islandin, geo_island, province, country, religion
	WHERE island.name = islandin.island
	And islandin.sea = 'Pacific Ocean'
	AND island.name = geo_island.island
	AND geo_island.province = province.name
	AND province.country = country.code
	AND country.code = religion.country
	AND religion.percentage >= 50
	AND religion.name = 'Muslim'
	ORDER BY island.name;

10. SELECT distinct mountain.name as mountainName, mountain.height, country.name as country
	FROM mountain
	JOIN geo_mountain ON mountain.name = geo_mountain.mountain
	JOIN province ON geo_mountain.country = province.country
	JOIN country ON province.country = country.code
	JOIN religion ON country.code = religion.country
	WHERE religion.Percentage >= 60 and religion.name = 'Roman Catholic' and mountain.height >= 3000
	order by mountain.height desc;

11. SELECT religion.name, ROUND(SUM((population * religion.percentage) / 100), 2) AS people
	FROM religion
	JOIN country ON religion.country = country.code
	GROUP BY religion.name;

12. SELECT country.name, country. area
	From country,encompasses,continent
	Where country.code = encompasses.country
	AND encompasses.continent = continent.name
	And continent.name = 'America'
	order by area desc
	Limit 0,3;

13. SELECT continent.name, 
       Round(SUM(country.population) * 100 / (SELECT SUM(country.population) FROM country),0) AS einwohnerProzent
	FROM country
	JOIN encompasses ON encompasses.country = country.code
	JOIN continent ON continent.name = encompasses.continent
	GROUP BY continent.name

	UNION ALL

	SELECT 'Total World Population', Round(SUM(population),0)
	FROM country;


14?. select country.name, politics.independence
	from desert,geo_desert,province, country, politics, ethnicgroup
	where desert.name = geo_desert.desert 
	and geo_desert.country = province.country
	and province.country = country.code
	and country.code = politics.country 
	and country.code = ethnicgroup.country
	and ethnicgroup.name = 'African';

-- city tabelle A:
SELECT * FROM mondial.city
-- city tabelle B:
SELECT * FROM mondial.city order by 2;

15. SELECT city.country, city.name, COUNT(city.country) AS staedteAnzahl
	FROM city
	GROUP BY city.country, city.name
	HAVING staedteAnzahl = 3;

SELECT * 
FROM countProvinces 
WHERE anzahl = 3
order by country;

16. WITH maxMountains as (Select distinct continent.name AS continentName, mountain.name as mountainName, mountain.height,
	RANK() OVER(PARTITION BY continent.name ORDER BY mountain.height DESC) as rang From mountain, geo_mountain, province, country, encompasses, continent
	where mountain.name = geo_mountain.mountain
	and geo_mountain.country = province.country
	and province.country = country.code
	and country.code = encompasses.country
	and encompasses.continent = continent.name
	) SELECT * from maxMountains WHERE rang = 1;

17.	SELECT COUNT(organization.name), organization.name, organization.country
	FROM organization
	where organization.country = 'A'
	Group By organization.name;

18. Select country.name, count(country.name) 
	From country,province,geo_lake,lake,geo_mountain,mountain
	where lake.Depth >= 100
	and lake.name = geo_lake.lake
	and geo_lake.country = province.country
	and province.country = country.code
	and mountain.height >= 1500 
	and mountain.name = geo_mountain.mountain 
	and geo_mountain.country = province.country
	and province.country = country.code
	Group by country.name;

19.	SELECT country.name, sea.name AS sea_name
	FROM country
	LEFT JOIN province ON province.country = country.code
	LEFT JOIN geo_sea ON geo_sea.country = province.country
	LEFT JOIN sea ON sea.name = geo_sea.sea
	GROUP BY country.name, sea.name;

22?. 	UPDATE ismember
	SET organization = 'ADCVG'
	WHERE organization = 'DCVG';

24. Update mountain
	Set height = 3798
	where name = 'Grossglockner';

25. 
Insert into country(name,code,capital,province,area,population)
value ('Cisnistrien', 'PMR', 'Tiraspol', 'Tiraspol', 3576,347251);

Insert Into province(name,country,population,area,capital,capprov)
values('Cisnistrien', 'PMR',347251,3576, 'Tiraspol','Tiraspol' );

Insert INTO encompasses(country,continent,Percentage)
values('PMR', 'Europe', 100);

Insert into city(name,country,province,population)
values('Cisnistrien', 'PMR', 'Cisnistrien', '347251');

26.
Insert Into mountain(name,height)
values('chervonka', 190);

Insert Into mountain(name,height)
value('4 Stolba', 10);

27.
Update country
Set name = 'Tuerkiye'
where name = 'Turkey';

28.
Update province
Set population = 5221007
where country = 'D';

29.
Update country
set capital = 'Nusantara'
where code = 'THA';

30.
SELECT ismember.Organization , country.name
from ismember, country 
where ismember.organization = 'EU' 
and ismember.country = country.code;

31.
Delete From country where name = 'United Kingdom';
