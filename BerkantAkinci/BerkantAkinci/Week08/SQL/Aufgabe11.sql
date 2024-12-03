-- Einwohnerzahl pro Religion

SELECT country.Name AS Country, religion.Name AS Religion, country.Population AS Population, religion.Percentage AS Percentage, ROUND(((Population/100) * Percentage),0) AS PopulationPerReligion
FROM mondial.country 
JOIN mondial.religion ON country.Code = religion.Country
ORDER BY country.Name ASC 