CREATE DATABASE gameProject222;
USE gameProject222;

CREATE TABLE Oyuncular (
    OyuncuID INT PRIMARY KEY IDENTITY(1,1),
    Ad VARCHAR(50)
);


CREATE TABLE Score (
    ScoreID INT PRIMARY KEY IDENTITY(1,1),
    OyuncuID INT,
    ScorePuani INT,
    FOREIGN KEY (OyuncuID) REFERENCES Oyuncular(OyuncuID)
);

CREATE TABLE Sure (
    SureID INT PRIMARY KEY IDENTITY(1,1),
    OyuncuID INT,
    Sure INT,
    FOREIGN KEY (OyuncuID) REFERENCES Oyuncular(OyuncuID)
);

CREATE TABLE Yapimcilar (
    id INT PRIMARY KEY IDENTITY(1,1),
    ad VARCHAR(50),
    soyad VARCHAR(50)
);

CREATE TABLE video (
    videoID INT PRIMARY KEY IDENTITY(1,1),
    video_name VARCHAR(100)
);


INSERT INTO Yapimcilar (ad, soyad)
VALUES 
('Þimal', 'Bülbül'),
('Nisa', 'Usta'),
('Muhammed Rýdvan', 'Beyiþ');
