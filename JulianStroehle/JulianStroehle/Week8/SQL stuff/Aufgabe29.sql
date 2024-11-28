USE mondial;

-- in table country
UPDATE country SET Capital = 'Nusantara' WHERE Code = 'THA';

-- in table province
UPDATE province SET Capital = 'Nusantara' WHERE Country = 'THA';