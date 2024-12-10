USE mondial;

DELETE FROM ismember
WHERE Organization = 'EU' AND (Country = 'GB' OR Country = 'TR' OR Country = 'MK');