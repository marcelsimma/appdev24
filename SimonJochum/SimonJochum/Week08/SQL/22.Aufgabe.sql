-- 22.1) Wir gehen 2 Monate in die Zukunft: Der Kurs ist vorbei. Jetzt gibt es eine neue internationale Organisation: “Alumni DCV-Grundkurs”. 
USE Mondial;
INSERT INTO organization
VALUES      ('ADCV',
             'Alumni DCV-Grundkurs',
             'Bregenz',
             'A',
             'Vorarlberg',
             '2025-01-28');  
-- 22.2) Alle Mitglieder von “DCV-Grundkurs” werden nun automatisch Mitglied in der Organisation “Alumni DCV Grundkurs”. Die Mitgliedschaft bei "DCV-Grundkurs" endet im selben Moment.
USE Mondial;
UPDATE ismember
SET    organization = 'ADCV'
WHERE  organization = 'DCV'
       AND country = 'A';  