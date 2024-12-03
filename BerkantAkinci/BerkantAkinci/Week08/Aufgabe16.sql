-- Was ist der größte Berg pro Kontinent? Wie hoch sind diese?

SELECT DISTINCT encompasses.Country, encompasses.Continent, geo_mountain.Mountain, mountain.Height
FROM mondial.encompasses
JOIN mondial.geo_mountain ON encompasses.Country = geo_mountain.Country
JOIN mondial.mountain ON geo_mountain.Mountain = mountain.Name

-- noch nicht fertig