--26.1)Speichere die höchsten drei Berge (gibt nur 2). Prüfe die Ergebnisse mit einem SELECT.
USE Mondial;
INSERT INTO geo_mountain
VALUES      ('4 Stolba',
             'PMR',
             'Transnistria'),
            ('Chervonka',
             'PMR',
             'Transnistria');  
            
USE Mondial;
INSERT INTO mountain
VALUES      ('4 Stolba',
             '4 Stolba',
             10,
             NULL,
             NULL,
             NULL),
            ('Chervonka',
             'Chervonka',
             190,
             NULL,
             NULL,
             NULL);  
-- 26.1 Prüfung) 
USE Mondial;
SELECT *
FROM   geo_mountain
       JOIN mountain
         ON mountain.mountains = geo_mountain.mountain
WHERE  country = 'PMR';  
--26.2) sowie die Hauptstadt von Transnistrien in die Datenbank.
INSERT INTO city
VALUES      ('Tiraspol',
             'PMR',
             'Transnistria',
             347251,
             NULL,
             NULL);  
