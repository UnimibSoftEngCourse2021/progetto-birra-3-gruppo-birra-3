-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2021-01-30 07:15:00
-- --------------------------------------
-- Server version 5.7.26-log MySQL Community Server (GPL)

-- 
-- Create schema birradb
-- 

CREATE DATABASE IF NOT EXISTS `birradb` /*!40100 DEFAULT CHARACTER SET utf8 */;
Use `birradb`;



/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of attrezzo
-- 

DROP TABLE IF EXISTS `attrezzo`;
CREATE TABLE IF NOT EXISTS `attrezzo` (
  `idAttrezzo` int(11) NOT NULL AUTO_INCREMENT,
  `nomeAtt` varchar(45) NOT NULL,
  `proprietario` varchar(45) NOT NULL,
  `capacita` int(11) NOT NULL,
  PRIMARY KEY (`idAttrezzo`),
  KEY `emailat` (`proprietario`),
  CONSTRAINT `emailat` FOREIGN KEY (`proprietario`) REFERENCES `utenti` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;



/*!40000 ALTER TABLE `attrezzo` DISABLE KEYS */;


-- 
-- Definition of listadellaspesa
-- 

DROP TABLE IF EXISTS `listadellaspesa`;
CREATE TABLE IF NOT EXISTS `listadellaspesa` (
  `proprietario` varchar(45) NOT NULL,
  `Prodotto` varchar(100) NOT NULL,
  `Quantita` int(11) NOT NULL,
  KEY `proprietarior` (`proprietario`),
  CONSTRAINT `proprietarior` FOREIGN KEY (`proprietario`) REFERENCES `utenti` (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;




-- 
-- Definition of prodotto
-- 

DROP TABLE IF EXISTS `prodotto`;
CREATE TABLE IF NOT EXISTS `prodotto` (
  `proprietario` varchar(45) NOT NULL,
  `nomeProd` varchar(45) NOT NULL,
  `quantita` int(11) NOT NULL,
  `idProdotto` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`idProdotto`),
  KEY `emailp` (`proprietario`),
  CONSTRAINT `emailp` FOREIGN KEY (`proprietario`) REFERENCES `utenti` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;



-- 
-- Definition of prodricetta
-- 

DROP TABLE IF EXISTS `prodricetta`;
CREATE TABLE IF NOT EXISTS `prodricetta` (
  `idRicetta` int(11) NOT NULL,
  `nomeProd` varchar(45) NOT NULL,
  `quantita` int(11) NOT NULL,
  `proprietario` varchar(45) NOT NULL,
  KEY `idRicettar` (`idRicetta`),
  CONSTRAINT `idRicettar` FOREIGN KEY (`idRicetta`) REFERENCES `ricetta` (`idRicetta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;



-- 
-- Definition of ricetta
-- 

DROP TABLE IF EXISTS `ricetta`;
CREATE TABLE IF NOT EXISTS `ricetta` (
  `idRicetta` int(11) NOT NULL AUTO_INCREMENT,
  `nomeRic` varchar(45) NOT NULL,
  `preparazione` varchar(1000) DEFAULT NULL,
  `note` varchar(1000) DEFAULT NULL,
  `proprietario` varchar(45) NOT NULL,
  `elencoAttrezzi` varchar(1000) NOT NULL,
  PRIMARY KEY (`idRicetta`),
  KEY `emailr` (`proprietario`),
  CONSTRAINT `emailr` FOREIGN KEY (`proprietario`) REFERENCES `utenti` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8;



-- 
-- Definition of utenti
-- 

DROP TABLE IF EXISTS `utenti`;
CREATE TABLE IF NOT EXISTS `utenti` (
  `email` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2021-01-30 07:15:01
-- Total time: 0:0:0:0:234 (d:h:m:s:ms)
