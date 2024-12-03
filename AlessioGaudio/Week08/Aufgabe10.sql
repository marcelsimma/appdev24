USE Mondial;
SELECT distinct mountain.name, religion.name, mountain.Height
FROM  Mountain, geo_mountain, country, religion
WHERE mountain.name = geo_mountain.mountain
AND geo_mountain.country = country.code
AND country.code = religion.country
AND Religion.Name LIKE 'Roman Catholic'
AND mountain.height >= 3000
AND religion.percentage >= 60
ORDER BY mountain.Height;