USE mondial;

SELECT islandin.Island, islandin.Sea, religion.Name AS Religion, religion.Percentage
FROM islandin, religion
JOIN geo_island ON religion.Country = geo_island.Country
WHERE islandin.Sea = 'Pacific Ocean' AND islandin.Island = geo_island.Island AND religion.Name = 'Muslim' AND religion.Percentage > 50;