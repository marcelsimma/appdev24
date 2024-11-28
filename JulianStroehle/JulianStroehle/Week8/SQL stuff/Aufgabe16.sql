USE mondial;

SELECT encompasses.Continent, MAX(mountain.Height) AS MaxHeight
FROM mountain, encompasses, geo_mountain
WHERE mountain.Name = geo_mountain.Mountain AND geo_mountain.Country = encompasses.Country
GROUP BY encompasses.Continent;