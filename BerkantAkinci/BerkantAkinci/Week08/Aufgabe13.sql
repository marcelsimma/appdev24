--  Wie viel Prozent der Menschen leben im Kontinent Europa?

SELECT SUM(country.Population) AS PopulationEurope, SUM(country.Population) AS Population
FROM mondial.encompasses
JOIN mondial.country ON encompasses.Country = country.Code
WHERE encompasses.Continent = 'Europe'

-- noch nicht fertig