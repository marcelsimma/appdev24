SELECT ROUND((SUM(CASE WHEN encompasses.Continent = 'Europe' THEN country.Population END)/SUM(country.Population) *100),2) AS BevökerungEuropas
FROM country
JOIN encompasses ON country.Code = encompasses.Country;