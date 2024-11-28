USE mondial;

SELECT DISTINCT country.Name
FROM country, geo_lake, lake, geo_mountain, mountain
WHERE geo_lake.Country = country.Code AND geo_lake.Lake = lake.Name AND lake.Depth > 100 AND geo_mountain.Country = country.Code AND geo_mountain.Mountain = mountain.Name AND mountain.Height > 1500
ORDER BY country.Name;