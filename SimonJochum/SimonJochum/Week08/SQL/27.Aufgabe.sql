-- 27) Ändere den Namen der Türkei auf "Türkiye".
USE Mondial;
UPDATE mondial.country
SET    name = 'Türkiye'
WHERE  name = 'Turkey'
       AND code = 'TR'
       AND capital = 'Ankara';  