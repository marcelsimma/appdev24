-- 30.1) Es gibt eine weitere "Organization", die nicht in unserer Datenbank vorhanden ist: die Visegrad Gruppe.
INSERT INTO organization
VALUES      ('V4',
             'Visegrád-Gruppe',
             'Visegrad',
             'H',
             'Szentendre',
             '1991-02-15');  
-- 30.2) Erstelle die "Organization" und ordne ihr Mitglieder zu. Die Hauptstadt dieses Bündnisses ist die ungarische Stadt Visegrad.
INSERT INTO ismember
VALUES      ('PL',
             'V4',
             'member'),
            ('CZ',
             'V4',
             'member'),
            ('SK',
             'V4',
             'member'),
            ('H',
             'V4',
             'member');  