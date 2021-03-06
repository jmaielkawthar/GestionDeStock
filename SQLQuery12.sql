--creation der base de donn?es
CREATE DATABASE GESTION_DE_STOCK

--creation des tables
--table client-------------------------------------------------------
CREATE TABLE Client
(
ID_Client int NOT NULL IDENTITY(1,1), --ajouter automatique
Nom_Client nvarchar(250) NOT NULL,
Prenom_Client nvarchar(250) NOT NULL,
Adresse_Client nvarchar(250) NOT NULL,
Telephonne_Client nvarchar(250) NOT NULL,
Pays_Client nvarchar(250) NOT NULL,
Ville_Client nvarchar(250) NOT NULL,
--cl? primaire

CONSTRAINT PK_CLIENT PRIMARY KEY(ID_Client)
)
-- table produit --------------------------------------------------------
CREATE TABLE Produit
(
Id_Produit int NOT NULL IDENTITY(1,1), --ajouter automatique
Nom_Produit nvarchar(250) NOT NULL,
Quantite_Produit int NOT NULL,
Prix_Produit nvarchar(250) NOT NULL,
Image_Produit IMAGE NOT NULL,
-------------------------------
ID_CATEGORIE int NOT NULL, --cl? ?trang?re de table caterogie
--cl? primaire
CONSTRAINT PK_PRODUIT PRIMARY KEY(Id_Produit)
)
-- table categorie-------------------------------------------------------
CREATE TABLE Categorie
(
ID_CATEGORIE int NOT NULL, --ajouter automatique
Nom_Categorie nvarchar(250) NOT NULL,
--cle primaire 

CONSTRAINT PK_Categorie PRIMARY KEY(ID_CATEGORIE)
)

-- table Commande ---------------------------------------------------------
CREATE TABLE Commande
(
ID_Commande int NOT NULL IDENTITY(1,1),
DATE_Commande DATETIME NOT NULL, 
------
ID_Client int NOT NULL, --cl? ?trang?re de table client
--cl? primaire 
CONSTRAINT PK_Commande PRIMARY KEY(ID_Commande)
)


-- table details  Commande ---------------------------------------------------------
CREATE TABLE Details_Commande
(
ID_Commande int NOT NULL,--cl? ?trang?re de table commande
ID_Produit int NOT NULL , --cl? ?trang?re de table produit
Quantite int NOT NULL
)


-- table details  utilisateur ---------------------------------------------------------
CREATE TABLE Utilisateur
(
NomUser nvarchar(250) NOT NULL,
Mot_De_Passe nvarchar(250) NOT NULL,
-- cl? primaire
CONSTRAINT PK_Utilisateur PRIMARY KEY(NomUser)
)
