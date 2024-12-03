-- Wie viele Einwohner hat der Kontinent Europa?

SELECT SUM(Population) 
FROM mondial.country, mondial.encompasses 
WHERE country.code = encompasses.country 
    AND Continent = 'Europe';