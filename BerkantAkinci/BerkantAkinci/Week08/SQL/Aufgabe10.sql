-- Alle 3000er, welche in einem Land sind, welches zu mindestens 60% römisch Katholisch ist

SELECT geo_mountain.Country AS Country, mountain.Name AS MountainName, mountain.Height AS MountainHeight, religion.Name AS Religion, religion.Percentage AS Percentage
FROM mondial.country
JOIN mondial.geo_mountain ON country.Code = geo_mountain.Country
JOIN mondial.mountain ON geo_mountain.mountain = mountain.Name
JOIN mondial.religion ON geo_mountain.Country = religion.Country
WHERE mountain.Height >= 3000 AND religion.Name = 'Roman Catholic' AND religion.Percentage >= 60
ORDER BY geo_mountain.Country ASC