-- Alle Länder mit mindestens einem See mit mindestens 100 Meter Tiefe und 
-- mindestens einem Berg mit mindestens 1500 Höhenmeter

SELECT DISTINCT country.Name, sea.Name, sea.Depth, mountain.Name, mountain.Height
FROM mondial.country
JOIN mondial.geo_sea ON country.Code = geo_sea.Country
JOIN mondial.sea ON geo_sea.Sea = sea.Name
JOIN mondial.geo_mountain ON country.Code = geo_mountain.Country
JOIN mondial.mountain ON geo_mountain.Mountain = mountain.Name
WHERE sea.Depth >= 100 AND mountain.Height >= 1500
ORDER BY country.Name ASC