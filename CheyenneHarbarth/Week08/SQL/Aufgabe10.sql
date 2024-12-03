SELECT mountain.Name, mountain.Height, geo_mountain.Country, religion.Name, religion.Percentage
FROM mountain
INNER JOIN geo_mountain ON mountain.Name = geo_mountain.Mountain
INNER JOIN religion ON geo_mountain.Country = religion.Country
WHERE mountain.Height >= 3000 AND religion.Name = 'Roman Catholic' AND religion.Percentage >= 60;