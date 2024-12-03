SELECT (SUM(CASE WHEN encompasses.Continent = 'Europe' THEN country.Population END)) AS BevökerungEuropas
FROM country
JOIN encompasses ON country.Code = encompasses.Country;