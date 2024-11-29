USE mondial;

SELECT Name, MAX(mountain.Height) AS HighestMountain
FROM mountain
JOIN geo_mountain ON mountain.Name = geo_mountain.Mountain
WHERE geo_mountain.Country = 'A'
GROUP BY Name
LIMIT 1;