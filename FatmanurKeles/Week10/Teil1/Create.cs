using System;
using MySql.Data.MySqlClient;

namespace FatmanurKeles.Week10.Teil1
{
    public class Create
    {
        public static Zoo zoo;
        public static void erstelleDatenbank(string verknüpfung)
        {
            string query = @"
            CREATE DATABASE ZooDatenbank;
USE ZooDatenbank;

CREATE TABLE Zoo ( 
	ZooID INTEGER auto_increment,
	ZooName VARCHAR(30),
	Gruendungsjahr VARCHAR(30),
	PRIMARY KEY (ZooID)
);

CREATE TABLE Pfleger (
	PflegerID INTEGER auto_increment,
	PflegerName VARCHAR(30),
    ZooID INTEGER,
	PRIMARY KEY (PflegerID),
	foreign key (ZooID) REFERENCES Zoo(ZooID)
);

CREATE TABLE Gehege (
	GehegeID INTEGER auto_increment,
	GehegeName VARCHAR(30),
	PflegerID INTEGER,
	PRIMARY KEY (GehegeID),
	foreign key (PflegerID) REFERENCES Pfleger(PflegerID)
);

-- VERKNÜPFUNG PFLEGER/GEHEGE
CREATE TABLE pflegt (
	PflegerID INTEGER,
	GehegeID INTEGER,
	PRIMARY KEY (PflegerID, GehegeID),
	foreign key (PflegerID) REFERENCES Pfleger(PflegerID),
	foreign key (GehegeID) REFERENCES Gehege(GehegeID)
);

CREATE TABLE Tier (
	TierID INTEGER auto_increment,
	TierName VARCHAR(30),
	Gattung VARCHAR(30),
	PRIMARY KEY(TierID),
	foreign key (GehegeID) REFERENCES Gehege(GehegeID)
);

CREATE TABLE Futter (
	FutterID INTEGER auto_increment,
	FutterName VARCHAR(30),
	Einheit VARCHAR(30),
	Einheitspreis DOUBLE,
	PRIMARY KEY(FutterID),
	foreign key (TierID) REFERENCES Tier(TierID)
);

-- VERKNÜPFUNG TIER/FUTTER
CREATE TABLE anzahl (
	TierID INTEGER,
    FutterID INTEGER,
    PRIMARY KEY (TierID, FutterID),
    foreign key (TierID) REFERENCES Tier(TierID),
    foreign key (FutterID) REFERENCES Futter(FutterID)
); ";

            using (MySqlConnection connection = new MySqlConnection(verknüpfung))
            {
                try
                {
                    connection.Open();

                    MySqlCommand cmd = new(query, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void fuelleDatanbank(string verknüpfung, string query)
        {
            for (int i = 0; i < 7; i++)
            {
                string tabelle= " ";
                switch (i)
                {
                    case 0: tabelle = "anzahl"; break;
                    case 1: tabelle = "futter"; break;
                    case 2: tabelle = "gehege"; break;
                    case 3: tabelle = "pfleger"; break;
                    case 4: tabelle = "pflegt"; break;
                    case 5: tabelle = "tier"; break;
                    case 6: tabelle = "zoo"; break;
                }
            }
        }
    }
}