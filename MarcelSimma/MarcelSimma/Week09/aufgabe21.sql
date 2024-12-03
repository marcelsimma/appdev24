USE mondial;

SELECT o.name, im.type, c.name FROM organization o
INNER JOIN ismember im ON o.abbreviation = im.organization
INNER JOIN country c ON im.country = c.code
WHERE o.name = 'DCV'
ORDER BY type DESC;