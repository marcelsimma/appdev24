-- Alle Länder die mit einem A anfangen und deren Bundesländer mit Einwohnerzahl, sortiert nach Einwohnerzahl

SELECT country.Name, province.Name, province.Population
FROM mondial.country
JOIN mondial.province ON country.Code = province.Country
WHERE country.Name Like 'A%'
ORDER by country.Name ASC, province.Population ASC;