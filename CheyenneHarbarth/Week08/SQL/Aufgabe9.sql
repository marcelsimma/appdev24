SELECT geo_island.Island, geo_island.Country, islandin.Sea, religion.Name, religion.Percentage
FROM geo_island
INNER JOIN islandin ON islandin.Island = geo_island.Island
INNER JOIN religion ON geo_island.Country = religion.Country
WHERE islandin.Sea = 'Pacific Ocean' AND religion.Name = 'Muslim' AND religion.Percentage > 50;