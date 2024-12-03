-- Welches sind die 3 größten Städte von Amerika (Kontinent)?

SELECT continent.Name, encompasses.Country, city.Name, city.Population
FROM mondial.continent
JOIN mondial.encompasses ON continent.Name = encompasses.Continent
JOIN mondial.city ON encompasses.Country = city.Country
WHERE encompasses.Continent = 'America'
Order By city.Population DESC
LIMIT 3