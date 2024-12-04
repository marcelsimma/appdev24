SELECT DISTINCT
    name, river.length
FROM
    River,
    geo_river,
    encompasses
WHERE
    River.name = geo_river.river
        AND geo_river.country = encompasses.Country
        AND encompasses.continent = 'Europe'
ORDER BY river.namecountrycountrycontinent;