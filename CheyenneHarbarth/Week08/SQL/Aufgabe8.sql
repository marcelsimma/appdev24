SELECT mountain.Name, mountain.Height, geo_mountain.Country
FROM mountain
INNER JOIN geo_mountain ON mountain.Name = geo_mountain.Mountain
WHERE geo_mountain.Country = 'A'
ORDER BY Height DESC
LIMIT 1;

