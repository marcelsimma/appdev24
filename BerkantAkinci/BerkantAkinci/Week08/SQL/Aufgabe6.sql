--  Alle Flüsse die durch Europa fließen (nur Flüsse und deren Länge), sortiert nach Länge

SELECT river.Name, river.Length
FROM mondial.encompasses
JOIN mondial.geo_river ON encompasses.Country = geo_river.Country
JOIN mondial.river ON geo_river.River = river.Name
WHERE Continent = 'Europe'
GROUP BY river.Name
ORDER BY river.Length ASC;