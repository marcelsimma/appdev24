SELECT distinct c.Name AS Country, gs.Sea AS Sea
FROM mondial.country c
LEFT JOIN mondial.geo_sea gs
ON c.Code = gs.Country
order by mondial.gs.Sea
;