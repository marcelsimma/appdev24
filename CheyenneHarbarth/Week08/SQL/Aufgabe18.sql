SELECT DISTINCT(country.Code), country.Name -- , lake.Name, lake.Depth, mountain.Name, mountain.Height
FROM country
JOIN geo_lake ON country.Code = geo_lake.Country
JOIN lake ON geo_lake.Lake = lake.Name
JOIN geo_mountain ON country.Code = geo_mountain.Country
JOIN mountain ON geo_mountain.Mountain = mountain.Name
WHERE lake.Depth >= 100 AND mountain.Height >= 1500;
