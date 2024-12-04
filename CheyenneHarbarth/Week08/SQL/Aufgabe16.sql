WITH MountainperContinent AS(SELECT distinct encompasses.Continent, mountain.Name, mountain.Height, RANK () OVER(PARTITION BY encompasses.Continent ORDER BY mountain.height DESC) AS Rang
FROM mountain
JOIN geo_mountain ON mountain.Name = geo_mountain.Mountain
JOIN encompasses ON geo_mountain.Country = encompasses.Country)
SELECT *
FROM MountainperContinent
WHERE Rang = 1 
