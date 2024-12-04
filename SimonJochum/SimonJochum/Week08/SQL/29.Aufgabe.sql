-- 29) Thailand hat eine neue Hauptstadt: Nusantara. Speichere das in die Datenbank.
UPDATE country
SET    capital = 'Nusantara'
WHERE  NAME = 'Thailand';  