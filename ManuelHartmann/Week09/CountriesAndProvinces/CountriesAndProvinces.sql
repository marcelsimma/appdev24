-- Country etc.
use mondial;
SELECT country.Name, country.Capital, country.Population, encompasses.Continent
FROM 
-- Beziehung country und ismember
country inner join encompasses ON country.Code = encompasses.Country
-- Zusätzliche Filter
WHERE country.Code = 'A'
ORDER BY country.Code ASC;

-- Provinces etc.
use mondial;
SELECT province.Name, province.Capital, province.Population
FROM
-- Beziehung country und ismember
country inner join province ON country.Code = province.Country
-- Zusätzliche Filter
WHERE country.Code = 'A'
ORDER BY country.Code ASC;