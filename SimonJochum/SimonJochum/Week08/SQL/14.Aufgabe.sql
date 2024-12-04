-- 14) Das Unabhängigkeitsdatum von Ländern die eine Wüste haben und die ethnische Gruppe African
USE Mondial;
SELECT DISTINCT ( geo_desert.country ),
                politics.independence
FROM   politics,
       geo_desert
       LEFT JOIN ethnicgroup
              ON geo_desert.country = ethnicgroup.country
WHERE  ethnicgroup.country = politics.country
       AND ethnicgroup.name = 'African';  