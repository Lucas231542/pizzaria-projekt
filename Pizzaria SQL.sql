Drop Table If EXISTS Booking;
Drop Table IF EXISTS Bord;

Create TABLE Bruger
(
KundeId Int identity(1,1) primary Key,
Navn Varchar(255)
)

Create Table [Bord]
(
BordId int Primary Key,
[Space] int Not null
)

Create Table [Booking]
(
BookingId int Primary Key,
StartDato DateTime,
Antalmennesker int not Null
)


Insert Into Bruger (Navn)
Values ('Lucas'),
	   ('Anton'),
	   ('Aleks');


Insert INTO Bord (BordId, [Space])
Values (205, 4),
	   (104, 8);



