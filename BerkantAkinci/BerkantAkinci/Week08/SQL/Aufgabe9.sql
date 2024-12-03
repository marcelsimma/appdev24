-- Alle Inseln im Pazifik mit >50% islamischem Bekenntnis

SELECT islandin.Sea, islandin.Island, religion.Name, religion.Percentage 
FROM mondial.religion
JOIN mondial.geo_island ON religion.Country = geo_island.Country
JOIN mondial.islandin ON geo_island.Island = islandin.Island
WHERE religion.Percentage > 50 
	AND religion.Name = 'Muslim' 
    AND islandin.Sea = 'Pacific Ocean';