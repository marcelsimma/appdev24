-- 25.1) Erstelle das Land Transnistrien. Es liegt in Europa. 
USE Mondial;
 INSERT INTO country VALUES
            (
                        'Transnistria',
                        'PMR',
                        'Tiraspol',
                        'Transnistria',
                        3567,
                        347251
            )
            &
INSERT INTO encompasses VALUES
            (
                        'PMR',
                        'Europe',
                        100
            ); 
-- 25.2) Wenn du anschließend einen alle europäischen Staaten inkl. Namen selektierst, soll auch Transnistrien in der Ergebnisliste sein.
SELECT country.name,
       country,
       continent
FROM   encompasses
       LEFT JOIN country
              ON country.code = encompasses.country
WHERE  continent = 'Europe';  