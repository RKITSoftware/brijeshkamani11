-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: librarymanagmentsystem
-- ------------------------------------------------------
-- Server version	8.0.28

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
  PRIMARY KEY (`S01F01`),
  UNIQUE KEY `S01F02_UNIQUE` (`S01F02`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Country';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms01`
--

LOCK TABLES `lms01` WRITE;
/*!40000 ALTER TABLE `lms01` DISABLE KEYS */;
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
  PRIMARY KEY (`S02F01`),
  KEY `StateCountryID_idx` (`S02F03`),
  CONSTRAINT `StateCountryID` FOREIGN KEY (`S02F03`) REFERENCES `lms01` (`S01F01`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='State';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms02`
--

LOCK TABLES `lms02` WRITE;
/*!40000 ALTER TABLE `lms02` DISABLE KEYS */;
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
  PRIMARY KEY (`S03F01`),
  KEY `CityStateID_idx` (`S03F04`),
  CONSTRAINT `CityStateID` FOREIGN KEY (`S03F04`) REFERENCES `lms02` (`S02F01`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='City';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms03`
--

LOCK TABLES `lms03` WRITE;
/*!40000 ALTER TABLE `lms03` DISABLE KEYS */;
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
  PRIMARY KEY (`S04F01`),
  KEY `AddressCityID_idx` (`S04F03`),
  KEY `AddressStateID_idx` (`S04F04`),
  KEY `AddressCountryID_idx` (`S04F05`),
  CONSTRAINT `AddressCityID` FOREIGN KEY (`S04F03`) REFERENCES `lms03` (`S03F01`),
  CONSTRAINT `AddressCountryID` FOREIGN KEY (`S04F05`) REFERENCES `lms01` (`S01F01`),
  CONSTRAINT `AddressStateID` FOREIGN KEY (`S04F04`) REFERENCES `lms02` (`S02F01`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Address';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms04`
--

LOCK TABLES `lms04` WRITE;
/*!40000 ALTER TABLE `lms04` DISABLE KEYS */;
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
  PRIMARY KEY (`S06F01`),
  UNIQUE KEY `S06F02_UNIQUE` (`S06F02`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Language';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms06`
--

LOCK TABLES `lms06` WRITE;
/*!40000 ALTER TABLE `lms06` DISABLE KEYS */;
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
  PRIMARY KEY (`S07F01`),
  UNIQUE KEY `S07F02_UNIQUE` (`S07F02`),
  KEY `PublisherCountryID_idx` (`S07F04`),
  CONSTRAINT `PublisherCountryID` FOREIGN KEY (`S07F04`) REFERENCES `lms01` (`S01F01`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Publisher';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms07`
--

LOCK TABLES `lms07` WRITE;
/*!40000 ALTER TABLE `lms07` DISABLE KEYS */;
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
  PRIMARY KEY (`S08F01`),
  UNIQUE KEY `S08F02_UNIQUE` (`S08F02`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Book Cetegory';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms08`
--

LOCK TABLES `lms08` WRITE;
/*!40000 ALTER TABLE `lms08` DISABLE KEYS */;
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
  PRIMARY KEY (`S09F01`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Shelf';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms09`
--

LOCK TABLES `lms09` WRITE;
/*!40000 ALTER TABLE `lms09` DISABLE KEYS */;
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Author';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms10`
--

LOCK TABLES `lms10` WRITE;
/*!40000 ALTER TABLE `lms10` DISABLE KEYS */;
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
  `S11F03` int DEFAULT NULL COMMENT 'ISBN number',
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Book';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lms11`
--

LOCK TABLES `lms11` WRITE;
/*!40000 ALTER TABLE `lms11` DISABLE KEYS */;
/*!40000 ALTER TABLE `lms11` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'librarymanagmentsystem'
--

--
-- Dumping routines for database 'librarymanagmentsystem'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-07 17:49:43
