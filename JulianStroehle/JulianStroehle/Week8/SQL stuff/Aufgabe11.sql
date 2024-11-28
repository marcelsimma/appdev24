USE mondial;

SELECT religion.Name, SUM(country.Population) AS Population
FROM religion
JOIN country ON religion.Country = country.Code
GROUP BY religion.Name;