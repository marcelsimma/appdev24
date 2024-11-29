USE mondial;

UPDATE province
SET Population = (SELECT Population FROM country WHERE country.Code = 'D')/16
WHERE province.Country = 'D';