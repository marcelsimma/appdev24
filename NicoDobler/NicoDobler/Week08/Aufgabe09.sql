USE Mondial;
SELECT percentage, rele.name, sea, fortnite.name
FROM  Island fortnite , geo_island glan, Country tilted, religion rele, islandin izi
WHERE izi.island = fortnite.name
AND fortnite.name = glan.island
AND glan.country = tilted.Code
AND tilted.code = rele.country
AND rele.Name LIKE 'MUSLIM'
AND sea LIKE 'Pacific Ocean'
AND rele.percentage > 50;