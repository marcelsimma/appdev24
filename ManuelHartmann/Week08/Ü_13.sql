    -- 13   --
-- Gesamtsumme aller Laender.
select sum(country.Population)
from country;
-- Gesamtsumme aller Laender in Europa / Gesamtsumme aller Laender) * 100
select (select sum(country.Population) from country) /
		sum(country.Population * encompasses.Percentage/100) as ergebnix
from country
join encompasses on country.Code = encompasses.Country
where encompasses.Continent = 'Europe'
 ;


    -- 13a  --
select distinct encompasses.Continent, 
		sum(country.Population * encompasses.Percentage/100) over (partition by encompasses.Continent) as pop_per_cont, 
        sum(country.Population * encompasses.Percentage/100) over () as total,
        sum(country.Population * encompasses.Percentage/100) over (partition by encompasses.Continent) / sum(country.Population * encompasses.percentage / 100) over () *100  as perc
from country
join encompasses on country.Code = encompasses.Country
;