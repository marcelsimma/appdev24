-- 23)Nachdem die Organisation “DCV-Grundkurs” keine Mitglieder mehr hat, soll diese gelöscht werden.
USE Mondial;
DELETE FROM organization
WHERE  abbreviation = 'DCV';  