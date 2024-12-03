SELECT distinct(politics.Country), politics.Independence, geo_desert.Desert, ethnicgroup.Name
FROM politics
INNER JOIN geo_desert ON politics.Country = geo_desert.Country
INNER JOIN ethnicgroup ON politics.Country = ethnicgroup.Country
WHERE ethnicgroup.Name LIKE 'African';