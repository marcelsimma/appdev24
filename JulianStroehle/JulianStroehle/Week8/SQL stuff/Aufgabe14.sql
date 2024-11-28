USE mondial;

SELECT DISTINCT geo_desert.Country, politics.Independence
FROM politics, geo_desert
LEFT JOIN  ethnicgroup ON geo_desert.Country = ethnicgroup.Country
WHERE ethnicgroup.Country = politics.Country AND ethnicgroup.Name = 'African';