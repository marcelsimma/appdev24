-- 19) Alle Länder, nur die Namen, und wenn sie haben, das Meer dazu
USE Mondial;
SELECT DISTINCT country.name,
                geo_sea.sea
FROM   country
       LEFT JOIN geo_sea
              ON country.code = geo_sea.country;  