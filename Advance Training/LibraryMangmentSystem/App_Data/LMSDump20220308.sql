CREATE DATABASE  IF NOT EXISTS `lms` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `lms`;
-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: lms
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `lms01`
--

DROP TABLE IF EXISTS `lms01`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms01` (
  `S01F01` int NOT NULL AUTO_INCREMENT COMMENT 'Country ID',
  `S01F02` varchar(50) NOT NULL COMMENT 'Country Name',
  `S01F03` datetime DEFAULT NULL COMMENT 'created_At',
  `S01F04` datetime DEFAULT NULL COMMENT 'modified_at',
  PRIMARY KEY (`S01F01`),
  UNIQUE KEY `S01F02_UNIQUE` (`S01F02`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Country';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms01`
--

LOCK TABLES `lms01` WRITE;
/*!40000 ALTER TABLE `lms01` DISABLE KEYS */;
INSERT INTO `lms01` VALUES (1,'India',NULL,NULL),(2,'United Kingdom',NULL,NULL);
/*!40000 ALTER TABLE `lms01` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lms02`
--

DROP TABLE IF EXISTS `lms02`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms02` (
  `S02F01` int NOT NULL AUTO_INCREMENT COMMENT 'State ID',
  `S02F02` varchar(45) NOT NULL,
  `S02F03` int NOT NULL COMMENT 'Country ID',
  `S02F04` datetime DEFAULT NULL COMMENT 'created_At',
  `S02F05` datetime DEFAULT NULL COMMENT 'modified_at',
  PRIMARY KEY (`S02F01`),
  KEY `StateCountryID_idx` (`S02F03`),
  CONSTRAINT `StateCountryID` FOREIGN KEY (`S02F03`) REFERENCES `lms01` (`S01F01`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='State';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms02`
--

LOCK TABLES `lms02` WRITE;
/*!40000 ALTER TABLE `lms02` DISABLE KEYS */;
INSERT INTO `lms02` VALUES (1,'Gujarat',1,NULL,NULL);
/*!40000 ALTER TABLE `lms02` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lms03`
--

DROP TABLE IF EXISTS `lms03`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms03` (
  `S03F01` int NOT NULL AUTO_INCREMENT COMMENT 'City ID',
  `S03F02` varchar(45) NOT NULL COMMENT 'City Name',
  `S03F03` int DEFAULT NULL COMMENT 'PINCODE',
  `S03F04` int NOT NULL COMMENT 'State ID',
  `S03F05` datetime DEFAULT NULL COMMENT 'created_At',
  `S03F06` datetime DEFAULT NULL COMMENT 'modified_at',
  PRIMARY KEY (`S03F01`),
  KEY `CityStateID_idx` (`S03F04`),
  CONSTRAINT `CityStateID` FOREIGN KEY (`S03F04`) REFERENCES `lms02` (`S02F01`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='City';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms03`
--

LOCK TABLES `lms03` WRITE;
/*!40000 ALTER TABLE `lms03` DISABLE KEYS */;
INSERT INTO `lms03` VALUES (1,'Rajkot',1,1,NULL,NULL);
/*!40000 ALTER TABLE `lms03` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lms04`
--

DROP TABLE IF EXISTS `lms04`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms04` (
  `S04F01` int NOT NULL AUTO_INCREMENT COMMENT 'Address ID',
  `S04F02` varchar(250) NOT NULL COMMENT 'Address',
  `S04F03` int NOT NULL COMMENT 'City ID',
  `S04F04` int NOT NULL COMMENT 'State ID',
  `S04F05` int NOT NULL COMMENT 'Country ID',
  `S04F06` datetime DEFAULT NULL COMMENT 'created_At',
  `S04F07` datetime DEFAULT NULL COMMENT 'modified_at',
  PRIMARY KEY (`S04F01`),
  KEY `AddressCityID_idx` (`S04F03`),
  KEY `AddressStateID_idx` (`S04F04`),
  KEY `AddressCountryID_idx` (`S04F05`),
  CONSTRAINT `AddressCityID` FOREIGN KEY (`S04F03`) REFERENCES `lms03` (`S03F01`),
  CONSTRAINT `AddressCountryID` FOREIGN KEY (`S04F05`) REFERENCES `lms01` (`S01F01`),
  CONSTRAINT `AddressStateID` FOREIGN KEY (`S04F04`) REFERENCES `lms02` (`S02F01`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Address';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms04`
--

LOCK TABLES `lms04` WRITE;
/*!40000 ALTER TABLE `lms04` DISABLE KEYS */;
INSERT INTO `lms04` VALUES (1,'Kothariya Road',1,1,1,NULL,NULL);
/*!40000 ALTER TABLE `lms04` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lms05`
--

DROP TABLE IF EXISTS `lms05`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms05` (
  `S05F01` int NOT NULL AUTO_INCREMENT COMMENT 'Role ID',
  `S05F02` varchar(50) NOT NULL COMMENT 'Role Name',
  `S05F03` datetime DEFAULT NULL COMMENT 'created_At',
  `S05F04` datetime DEFAULT NULL COMMENT 'modified_at',
  PRIMARY KEY (`S05F01`),
  UNIQUE KEY `S05F02_UNIQUE` (`S05F02`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Role';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms05`
--

LOCK TABLES `lms05` WRITE;
/*!40000 ALTER TABLE `lms05` DISABLE KEYS */;
/*!40000 ALTER TABLE `lms05` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lms06`
--

DROP TABLE IF EXISTS `lms06`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms06` (
  `S06F01` int NOT NULL AUTO_INCREMENT COMMENT 'Language ID',
  `S06F02` varchar(45) NOT NULL COMMENT 'Language Name',
  `S06F03` datetime DEFAULT NULL COMMENT 'created_At',
  `S06F04` datetime DEFAULT NULL COMMENT 'modified_at',
  PRIMARY KEY (`S06F01`),
  UNIQUE KEY `S06F02_UNIQUE` (`S06F02`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Language';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms06`
--

LOCK TABLES `lms06` WRITE;
/*!40000 ALTER TABLE `lms06` DISABLE KEYS */;
INSERT INTO `lms06` VALUES (1,'Gujarati',NULL,NULL),(2,'Hindi',NULL,NULL),(3,'English',NULL,NULL);
/*!40000 ALTER TABLE `lms06` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lms07`
--

DROP TABLE IF EXISTS `lms07`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms07` (
  `S07F01` int NOT NULL AUTO_INCREMENT COMMENT 'PublisherID',
  `S07F02` varchar(50) NOT NULL COMMENT 'Publisher Name',
  `S07F03` int DEFAULT NULL COMMENT 'Total Books Published',
  `S07F04` int DEFAULT NULL COMMENT 'Origin Country ID',
  `S07F05` datetime DEFAULT NULL COMMENT 'created_At',
  `S07F06` datetime DEFAULT NULL COMMENT 'modified_at',
  PRIMARY KEY (`S07F01`),
  UNIQUE KEY `S07F02_UNIQUE` (`S07F02`),
  KEY `PublisherCountryID_idx` (`S07F04`),
  CONSTRAINT `PublisherCountryID` FOREIGN KEY (`S07F04`) REFERENCES `lms01` (`S01F01`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Publisher';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms07`
--

LOCK TABLES `lms07` WRITE;
/*!40000 ALTER TABLE `lms07` DISABLE KEYS */;
INSERT INTO `lms07` VALUES (1,'Bloomsbury Publishing ',200,2,'2022-03-08 00:00:00','2022-03-08 00:00:00');
/*!40000 ALTER TABLE `lms07` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lms08`
--

DROP TABLE IF EXISTS `lms08`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms08` (
  `S08F01` int NOT NULL AUTO_INCREMENT COMMENT 'Book Cetegory ID',
  `S08F02` varchar(50) NOT NULL COMMENT 'Book Cetegory Name',
  `S08F03` datetime DEFAULT NULL COMMENT 'created_At',
  `S08F04` datetime DEFAULT NULL COMMENT 'modified_at',
  PRIMARY KEY (`S08F01`),
  UNIQUE KEY `S08F02_UNIQUE` (`S08F02`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Book Cetegory';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms08`
--

LOCK TABLES `lms08` WRITE;
/*!40000 ALTER TABLE `lms08` DISABLE KEYS */;
INSERT INTO `lms08` VALUES (1,'Novel','2022-08-03 00:00:00','2022-08-03 00:00:00');
/*!40000 ALTER TABLE `lms08` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lms09`
--

DROP TABLE IF EXISTS `lms09`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms09` (
  `S09F01` int NOT NULL AUTO_INCREMENT COMMENT 'Shelf ID',
  `S09F02` int NOT NULL COMMENT 'Shelf No',
  `S09F03` int NOT NULL COMMENT 'Floor No',
  `S09F04` datetime DEFAULT NULL COMMENT 'created_At',
  `S09F05` datetime DEFAULT NULL COMMENT 'modified_at',
  PRIMARY KEY (`S09F01`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Shelf';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms09`
--

LOCK TABLES `lms09` WRITE;
/*!40000 ALTER TABLE `lms09` DISABLE KEYS */;
INSERT INTO `lms09` VALUES (1,1,1,'2022-08-03 00:00:00','2022-08-03 00:00:00');
/*!40000 ALTER TABLE `lms09` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lms10`
--

DROP TABLE IF EXISTS `lms10`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms10` (
  `S10F01` int NOT NULL AUTO_INCREMENT COMMENT 'Author ID',
  `S10F02` varchar(45) NOT NULL COMMENT 'Author Name',
  `S10F03` varchar(999) DEFAULT NULL COMMENT 'Biography',
  `S10F04` int DEFAULT NULL COMMENT 'No of Books Written till date',
  `S10F05` int DEFAULT NULL COMMENT 'Country ID',
  `S10F06` datetime DEFAULT NULL COMMENT 'Created At',
  `S10F07` datetime DEFAULT NULL COMMENT 'Last Modified At',
  PRIMARY KEY (`S10F01`),
  KEY `AuthorCountryID_idx` (`S10F05`),
  CONSTRAINT `AuthorCountryID` FOREIGN KEY (`S10F05`) REFERENCES `lms01` (`S01F01`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Author';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms10`
--

LOCK TABLES `lms10` WRITE;
/*!40000 ALTER TABLE `lms10` DISABLE KEYS */;
INSERT INTO `lms10` VALUES (1,'J. K. Rowling','J.K. Rowling is best known as the British author of the Harry Potter series, the bestselling book series in history with more than 400 million copies sold and one of the most popular movie series of all time. She also writes novels for adults, including crime novels under the pen name Robert Galbraith. J.K. Rowling lives in Edinburgh with her husband and three children.',11,2,'2022-08-03 00:00:00','2022-08-03 00:00:00');
/*!40000 ALTER TABLE `lms10` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lms11`
--

DROP TABLE IF EXISTS `lms11`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms11` (
  `S11F01` int NOT NULL AUTO_INCREMENT COMMENT 'Book ID',
  `S11F02` varchar(50) NOT NULL COMMENT 'Book Title',
  `S11F03` varchar(50) DEFAULT NULL COMMENT 'ISBN number',
  `S11F04` year DEFAULT NULL COMMENT 'Published_Year',
  `S11F05` int DEFAULT NULL COMMENT 'Edition',
  `S11F06` int NOT NULL COMMENT 'Total Copies',
  `S11F07` int NOT NULL COMMENT 'Available Copies',
  `S11F08` int DEFAULT NULL COMMENT 'Total Pages',
  `S11F09` int DEFAULT NULL COMMENT 'Language ID',
  `S11F10` int DEFAULT NULL COMMENT 'Publisher ID',
  `S11F11` int DEFAULT NULL COMMENT 'Category ID',
  `S11F12` int DEFAULT NULL COMMENT 'Shelf ID',
  `S11F13` int DEFAULT NULL COMMENT 'Author ID',
  `S11F14` datetime DEFAULT NULL COMMENT 'created_at',
  `S11F15` datetime DEFAULT NULL COMMENT 'modified_at',
  `S11F16` decimal(10,2) DEFAULT '0.00',
  PRIMARY KEY (`S11F01`),
  UNIQUE KEY `S11F02_UNIQUE` (`S11F02`),
  UNIQUE KEY `S11F03_UNIQUE` (`S11F03`),
  KEY `BookLanguageID_idx` (`S11F09`),
  KEY `BookPublisherID_idx` (`S11F10`),
  KEY `BookCategoryID_idx` (`S11F11`),
  KEY `BookShelfID_idx` (`S11F12`),
  KEY `BookAuthorID_idx` (`S11F13`),
  CONSTRAINT `BookAuthorID` FOREIGN KEY (`S11F13`) REFERENCES `lms10` (`S10F01`),
  CONSTRAINT `BookCategoryID` FOREIGN KEY (`S11F11`) REFERENCES `lms08` (`S08F01`),
  CONSTRAINT `BookLanguageID` FOREIGN KEY (`S11F09`) REFERENCES `lms06` (`S06F01`),
  CONSTRAINT `BookPublisherID` FOREIGN KEY (`S11F10`) REFERENCES `lms07` (`S07F01`),
  CONSTRAINT `BookShelfID` FOREIGN KEY (`S11F12`) REFERENCES `lms09` (`S09F01`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Book';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms11`
--

LOCK TABLES `lms11` WRITE;
/*!40000 ALTER TABLE `lms11` DISABLE KEYS */;
INSERT INTO `lms11` VALUES (1,'Harry Potter and the Philosopher\'s Stone','0-7475-3269-9',1997,5,5,223,1,1,1,1,1,1,'2022-03-05 00:00:00','2022-03-08 00:00:00',50.00);
/*!40000 ALTER TABLE `lms11` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lms12`
--

DROP TABLE IF EXISTS `lms12`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms12` (
  `S12F01` int NOT NULL AUTO_INCREMENT COMMENT 'Staff ID',
  `S12F02` varchar(255) NOT NULL COMMENT 'username',
  `S12F03` varchar(255) NOT NULL COMMENT 'password',
  `S12F04` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Have Admin Rights?',
  `S12F05` datetime DEFAULT NULL COMMENT 'created_at',
  `S12F06` datetime DEFAULT NULL COMMENT 'modified_at',
  PRIMARY KEY (`S12F01`),
  UNIQUE KEY `S12F02_UNIQUE` (`S12F02`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Staff';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms12`
--

LOCK TABLES `lms12` WRITE;
/*!40000 ALTER TABLE `lms12` DISABLE KEYS */;
INSERT INTO `lms12` VALUES (1,'librarian1','1234',0,'2022-03-05 00:00:00','2022-03-05 00:00:00'),(2,'admin','1234',1,'2022-03-05 00:00:00','2022-03-05 00:00:00');
/*!40000 ALTER TABLE `lms12` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lms13`
--

DROP TABLE IF EXISTS `lms13`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms13` (
  `S13F01` int NOT NULL AUTO_INCREMENT COMMENT 'Member ID',
  `S13F02` varchar(100) NOT NULL COMMENT 'First name',
  `S13F03` varchar(100) NOT NULL COMMENT 'Last Name',
  `S13F04` varchar(250) NOT NULL COMMENT 'Emaild Id',
  `S13F05` varchar(50) DEFAULT NULL COMMENT 'Contact No',
  `S13F06` date DEFAULT NULL COMMENT 'Joining Date',
  `S13F07` datetime DEFAULT NULL COMMENT 'Birthdate',
  `S13F08` int DEFAULT NULL COMMENT 'Age',
  `S13F09` int NOT NULL DEFAULT '0' COMMENT 'Total Booked Issued',
  `S13F10` decimal(10,2) NOT NULL DEFAULT '0.00' COMMENT 'Total fine to Pay',
  `S13F11` int DEFAULT NULL COMMENT 'Address ID',
  `S13F12` datetime DEFAULT NULL COMMENT 'created_at',
  `S13F13` datetime DEFAULT NULL COMMENT 'modified_at',
  PRIMARY KEY (`S13F01`),
  UNIQUE KEY `S13F04_UNIQUE` (`S13F04`),
  KEY `MemberAddressID_idx` (`S13F11`),
  CONSTRAINT `MemberAddressID` FOREIGN KEY (`S13F11`) REFERENCES `lms04` (`S04F01`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Member';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms13`
--

LOCK TABLES `lms13` WRITE;
/*!40000 ALTER TABLE `lms13` DISABLE KEYS */;
INSERT INTO `lms13` VALUES (1,'Brijesh','Kamani','brijeshkamani11@gmail.com','8320247480','2022-03-05','2001-03-30 00:00:00',20,0,0.00,1,'2022-03-05 00:00:00','2022-03-05 00:00:00');
/*!40000 ALTER TABLE `lms13` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lms14`
--

DROP TABLE IF EXISTS `lms14`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms14` (
  `S14F01` int NOT NULL AUTO_INCREMENT COMMENT 'Returned ID',
  `S14F02` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'Is Book Returned',
  `S14F03` datetime DEFAULT NULL COMMENT 'Actual Returned Date',
  `S14F04` decimal(10,0) NOT NULL DEFAULT '0' COMMENT 'Fine Amount',
  `S14F05` tinyint(1) NOT NULL DEFAULT '0' COMMENT 'total Fine Payed?',
  `S14F06` datetime DEFAULT NULL COMMENT 'created_at',
  `S14F07` datetime DEFAULT NULL COMMENT 'modified_at',
  `S14F08` int NOT NULL COMMENT 'Member ID',
  `S14F09` int NOT NULL COMMENT 'Book ID',
  PRIMARY KEY (`S14F01`),
  KEY `ReturnedMemberID_idx` (`S14F08`),
  KEY `RetrunedBookID_idx` (`S14F09`),
  CONSTRAINT `RetrunedBookID` FOREIGN KEY (`S14F09`) REFERENCES `lms11` (`S11F01`),
  CONSTRAINT `ReturnedMemberID` FOREIGN KEY (`S14F08`) REFERENCES `lms13` (`S13F01`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Returned Book';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms14`
--

LOCK TABLES `lms14` WRITE;
/*!40000 ALTER TABLE `lms14` DISABLE KEYS */;
INSERT INTO `lms14` VALUES (1,1,'2022-03-08 00:00:00',0,1,'2022-03-08 00:00:00','2022-03-08 00:00:00',1,1);
/*!40000 ALTER TABLE `lms14` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lms15`
--

DROP TABLE IF EXISTS `lms15`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lms15` (
  `S15F01` int NOT NULL AUTO_INCREMENT COMMENT 'Issued ID',
  `S15F02` int NOT NULL COMMENT 'Member Id',
  `S15F03` int NOT NULL COMMENT 'Issued by',
  `S15F04` int NOT NULL COMMENT 'Book ID',
  `S15F05` datetime NOT NULL COMMENT 'Issued Date',
  `S15F06` datetime NOT NULL COMMENT 'return Date',
  `S15F07` int DEFAULT NULL COMMENT 'Return ID',
  `S15F08` datetime DEFAULT NULL COMMENT 'created_at',
  `S15F09` datetime DEFAULT NULL COMMENT 'modified_at',
  PRIMARY KEY (`S15F01`),
  KEY `IssuedReturnedID_idx` (`S15F07`),
  CONSTRAINT `IssuedReturnedID` FOREIGN KEY (`S15F07`) REFERENCES `lms14` (`S14F01`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Book Issued';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms15`
--

LOCK TABLES `lms15` WRITE;
/*!40000 ALTER TABLE `lms15` DISABLE KEYS */;
INSERT INTO `lms15` VALUES (1,1,1,1,'2022-03-05 00:00:00','2022-03-08 00:00:00',1,'2022-03-08 00:00:00','2022-03-08 00:00:00');
/*!40000 ALTER TABLE `lms15` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-08 19:05:32
