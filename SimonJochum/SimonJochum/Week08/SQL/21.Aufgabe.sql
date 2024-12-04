-- 21) Gib alle Mitglieder der neuen Organization aus. Sind alle Mitglieder dabei, die du hinzugefügt hast?
USE Mondial;
SELECT *
FROM   ismember
WHERE  organization = 'DCV';  