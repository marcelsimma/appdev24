SELECT distinct(geo_river.River)
FROM geo_river
JOIN encompasses ON geo_river.Country = encompasses.Country
WHERE encompasses.Continent = 'Europe'
ORDER BY geo_river.River ASC;