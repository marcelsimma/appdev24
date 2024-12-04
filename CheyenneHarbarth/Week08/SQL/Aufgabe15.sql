SELECT COUNT(city.Name) AS AmountOfCities, city.Country, country.Name
FROM city
JOIN country ON city.Country = country.Code
GROUP BY city.Country
HAVING AmountOfCities = 3;
 