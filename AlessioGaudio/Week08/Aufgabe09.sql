USE Mondial;
SELECT percentage, rele.name, sea, Island.name
FROM  Island, geo_island , Country , religion rele, islandin izi
WHERE izi.island = island.name
AND island.name = geo_island.island
AND geo_island.country = country.Code
AND country.code = rele.country
AND rele.Name LIKE 'MUSLIM'
AND sea LIKE 'Pacific Ocean'
AND rele.percentage > 50;