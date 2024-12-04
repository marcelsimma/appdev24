-- 28) Ändere die Einwohnerzahl der Deutschen Bundesländer: In jedem Bundesland wohnt zukünftig jeweils 1/16 der Gesamtbevölkerung Deutschlands
 UPDATE province
SET    population = (SELECT population
                     FROM   country
                     WHERE  code = 'D') / 16
WHERE  country = 'D';  