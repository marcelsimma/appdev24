-- Das Unabhängigkeitsdatum von Ländern die eine Wüste haben und die ethnische Gruppe African

SELECT distinct politics.Country, politics.Independence, geo_desert.Desert, ethnicgroup.Name 
FROM mondial.politics
JOIN mondial.geo_desert ON politics.Country = geo_desert.Country
JOIN mondial.ethnicgroup ON geo_desert.Country = ethnicgroup.Country
WHERE ethnicgroup.Name = 'African';