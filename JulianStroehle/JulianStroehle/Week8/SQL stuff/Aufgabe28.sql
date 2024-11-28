USE mondial;

-- search for population in Germany
SELECT Population FROM country WHERE Code = 'D';

-- insert population for each province
UPDATE province SET Population = 83536115/16 WHERE province.Country = 'D';