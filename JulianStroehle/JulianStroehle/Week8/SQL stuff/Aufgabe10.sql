USE mondial;

SELECT DISTINCT mountain.Name, mountain.Height
FROM mountain, religion, geo_mountain
WHERE mountain.Name = geo_mountain.Mountain AND geo_mountain.Country = religion.Country AND mountain.Height > 3000 AND religion.Percentage > 60
ORDER BY mountain.Height;