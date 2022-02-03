CREATE DATABASE  IF NOT EXISTS `addressbook` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `addressbook`;
-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: addressbook
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
-- Table structure for table `adrsbk01`
--

DROP TABLE IF EXISTS `adrsbk01`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `adrsbk01` (
  `K01F01` int NOT NULL AUTO_INCREMENT COMMENT 'USERID',
  `K01F02` varchar(100) NOT NULL COMMENT 'username',
  `K01F03` varchar(100) NOT NULL COMMENT 'password',
  `K01F04` varchar(100) NOT NULL COMMENT 'DisplayName',
  `K01F05` varchar(100) DEFAULT NULL COMMENT 'Address',
  `K01F06` varchar(20) DEFAULT NULL COMMENT 'MobileNo',
  PRIMARY KEY (`K01F01`),
  UNIQUE KEY `K01F01_UNIQUE` (`K01F02`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='USER';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk01`
--

LOCK TABLES `adrsbk01` WRITE;
/*!40000 ALTER TABLE `adrsbk01` DISABLE KEYS */;
INSERT INTO `adrsbk01` VALUES (1,'brijeshkamani','1234','Brijesh Kamani','Rajkot','1234567890'),(2,'rajkamani','1234','Raj Kamani','Rajkot','1234567890');
/*!40000 ALTER TABLE `adrsbk01` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `adrsbk02`
--

DROP TABLE IF EXISTS `adrsbk02`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `adrsbk02` (
  `K02F01` int NOT NULL AUTO_INCREMENT COMMENT 'CountryID',
  `K02F02` varchar(50) NOT NULL COMMENT 'CountryName',
  `K02F03` int NOT NULL COMMENT 'CountryCode',
  `K02F04` int NOT NULL COMMENT 'UserID',
  PRIMARY KEY (`K02F01`),
  UNIQUE KEY `K02F01_UNIQUE` (`K02F02`),
  UNIQUE KEY `K02F03_UNIQUE` (`K02F03`),
  KEY `UserID_idx` (`K02F04`),
  CONSTRAINT `UserID` FOREIGN KEY (`K02F04`) REFERENCES `adrsbk01` (`K01F01`)
) ENGINE=InnoDB AUTO_INCREMENT=177 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Country';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk02`
--

LOCK TABLES `adrsbk02` WRITE;
/*!40000 ALTER TABLE `adrsbk02` DISABLE KEYS */;
INSERT INTO `adrsbk02` VALUES (1,'Afghanistan ',93,1),(2,'Albania ',355,1),(3,'Algeria ',213,1),(4,'Andorra, Principality of ',376,1),(5,'Angola',244,1),(6,'Antarctica',672,1),(7,'Argentina ',54,1),(8,'Armenia',374,1),(9,'Aruba',297,1),(10,'Australia',61,1),(11,'Austria',43,1),(12,'Bahrain, Kingdom of (Former Dilmun)',973,1),(13,'Bangladesh (Former East Pakistan)',880,1),(14,'Belgium ',32,1),(15,'Belize (Former British Honduras)',501,1),(16,'Benin (Former Dahomey)',229,1),(17,'Bhutan, Kingdom of',975,1),(18,'Bolivia ',591,1),(19,'Bosnia and Herzegovina ',387,1),(20,'Botswana (Former Bechuanaland)',267,1),(21,'Brazil ',55,1),(22,'Brunei (Negara Brunei Darussalam) ',673,1),(23,'Bulgaria ',359,1),(24,'Burkina Faso (Former Upper Volta)',226,1),(25,'Burundi (Former Urundi)',257,1),(26,'Cameroon (Former French Cameroon)',237,1),(27,'Canada ',1,1),(28,'Cape Verde ',238,1),(29,'Central African Republic ',236,1),(30,'Chad ',235,1),(31,'Chile ',56,1),(32,'China ',86,1),(33,'Christmas Island ',53,1),(35,'Colombia ',57,1),(36,'Comoros, Union of the ',269,1),(37,'Congo, Democratic Republic of the (Former Zaire) ',243,1),(38,'Congo, Republic of the',242,1),(39,'Cook Islands (Former Harvey Islands)',682,1),(40,'Costa Rica ',506,1),(41,'Cote D\'Ivoire (Former Ivory Coast) ',225,1),(42,'Croatia (Hrvatska) ',385,1),(44,'Cyprus ',357,1),(45,'Czech Republic',420,1),(46,'Denmark ',45,1),(47,'East Timor (Former Portuguese Timor)',670,1),(48,'Ecuador ',593,1),(49,'Egypt (Former United Arab Republic - with Syria)',20,1),(50,'El Salvador ',503,1),(51,'Equatorial Guinea (Former Spanish Guinea)',240,1),(52,'Ethiopia (Former Abyssinia, Italian East Africa)',251,1),(53,'Falkland Islands (Islas Malvinas) ',500,1),(54,'Faroe Islands ',298,1),(55,'Fiji ',679,1),(56,'Finland ',358,1),(57,'France ',33,1),(58,'French Guiana or French Guyana ',594,1),(59,'French Polynesia (Former French Colony of Oceania)',689,1),(60,'Gabon (Gabonese Republic)',241,1),(61,'Gambia, The ',220,1),(62,'Germany ',49,1),(63,'Ghana (Former Gold Coast)',233,1),(64,'Gibraltar ',350,1),(65,'Greece ',30,1),(66,'Greenland ',299,1),(67,'Guadeloupe',590,1),(68,'Guatemala ',502,1),(69,'Guinea (Former French Guinea)',224,1),(70,'Guinea-Bissau (Former Portuguese Guinea)',245,1),(71,'Guyana (Former British Guiana)',592,1),(72,'Haiti ',509,1),(73,'Honduras ',504,1),(74,'Hong Kong ',852,1),(75,'Hungary ',36,1),(76,'Iceland ',354,1),(77,'India ',91,1),(78,'Iran, Islamic Republic of',98,1),(79,'Iraq ',964,1),(80,'Ireland ',353,1),(81,'Israel ',972,1),(82,'Italy ',39,1),(83,'Japan ',81,1),(84,'Jordan (Former Transjordan)',962,1),(85,'Kenya (Former British East Africa)',254,1),(86,'Korea, Republic of (South Korea) ',82,1),(87,'Kuwait ',965,1),(88,'Lao People\'s Democratic Republic (Laos)',856,1),(89,'Latvia (Former Latvian Soviet Socialist Republic)',371,1),(90,'Lebanon ',961,1),(91,'Lesotho (Former Basutoland)',266,1),(92,'Liberia ',231,1),(93,'Libya (Libyan Arab Jamahiriya)',218,1),(94,'Liechtenstein ',423,1),(95,'Luxembourg ',352,1),(96,'Macau ',853,1),(97,'Macedonia, The Former Yugoslav Republic of',389,1),(98,'Madagascar (Former Malagasy Republic)',261,1),(99,'Malaysia ',60,1),(100,'Maldives ',960,1),(101,'Mali (Former French Sudan and Sudanese Republic) ',223,1),(102,'Malta ',356,1),(103,'Martinique (French) ',596,1),(104,'Mauritania ',222,1),(105,'Mauritius ',230,1),(107,'Mexico ',52,1),(108,'Moldova, Republic of',373,1),(109,'Monaco, Principality of',377,1),(110,'Mongolia (Former Outer Mongolia)',976,1),(111,'Morocco ',212,1),(112,'Mozambique (Former Portuguese East Africa)',258,1),(113,'Myanmar, Union of (Former Burma)',95,1),(114,'Nauru (Former Pleasant Island)',674,1),(115,'Nepal ',977,1),(116,'Netherlands ',31,1),(117,'New Caledonia ',687,1),(118,'New Zealand (Aotearoa) ',64,1),(119,'Nicaragua ',505,1),(120,'Niger ',227,1),(121,'Nigeria ',234,1),(122,'Niue (Former Savage Island)',683,1),(124,'Norway ',47,1),(125,'Oman, Sultanate of (Former Muscat and Oman)',968,1),(126,'Pakistan (Former West Pakistan)',92,1),(127,'Palestinian State (Proposed)',970,1),(128,'Panama ',507,1),(129,'Paraguay ',595,1),(130,'Peru ',51,1),(131,'Philippines ',63,1),(132,'Poland ',48,1),(133,'Portugal ',351,1),(134,'Qatar, State of ',974,1),(135,'Reunion (French) (Former Bourbon Island)',262,1),(136,'Romania ',40,1),(137,'Russian Federation ',7,1),(138,'Rwanda (Rwandese Republic) (Former Ruanda)',250,1),(139,'Saint Helena ',290,1),(140,'Saint Pierre and Miquelon ',508,1),(141,'Samoa (Former Western Samoa)',685,1),(142,'San Marino ',378,1),(143,'Sao Tome and Principe ',239,1),(144,'Saudi Arabia ',966,1),(145,'Senegal ',221,1),(146,'Seychelles ',248,1),(147,'Sierra Leone ',232,1),(148,'Singapore ',65,1),(149,'Slovakia',421,1),(150,'Slovenia ',386,1),(151,'Solomon Islands (Former British Solomon Islands)',677,1),(152,'South Africa (Former Union of South Africa)',27,1),(153,'Spain ',34,1),(154,'Sri Lanka (Former Serendib, Ceylon) ',94,1),(155,'Sudan (Former Anglo-Egyptian Sudan) ',249,1),(156,'Suriname (Former Netherlands Guiana, Dutch Guiana)',597,1),(157,'Swaziland, Kingdom of ',268,1),(158,'Sweden ',46,1),(159,'Switzerland ',41,1),(160,'Taiwan (Former Formosa)',886,1),(161,'Thailand (Former Siam)',66,1),(162,'Tokelau ',690,1),(163,'Tonga, Kingdom of (Former Friendly Islands)',676,1),(164,'Tunisia ',216,1),(165,'Turkey ',90,1),(166,'Tuvalu (Former Ellice Islands)',688,1),(167,'Uganda, Republic of',256,1),(168,'United Kingdom (Great Britain / UK)',44,1),(170,'Vanuatu (Former New Hebrides)',678,1),(171,'Vatican City State (Holy See)',418,1),(172,'Venezuela ',58,1),(173,'Vietnam ',84,1),(174,'Wallis and Futuna Islands ',681,1),(175,'Yemen ',967,1),(176,'Zambia, Republic of (Former Northern Rhodesia) ',260,1);
/*!40000 ALTER TABLE `adrsbk02` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `adrsbk03`
--

DROP TABLE IF EXISTS `adrsbk03`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `adrsbk03` (
  `K03F01` int NOT NULL AUTO_INCREMENT COMMENT 'StateID',
  `K03F02` varchar(50) NOT NULL COMMENT 'StateName',
  `K03F03` int NOT NULL COMMENT 'CountryID',
  `K03F04` int NOT NULL COMMENT 'UserID',
  PRIMARY KEY (`K03F01`),
  KEY `CountryID_idx` (`K03F03`),
  KEY `UserID_idx` (`K03F04`),
  CONSTRAINT `CountryID` FOREIGN KEY (`K03F03`) REFERENCES `adrsbk02` (`K02F01`),
  CONSTRAINT `UserIDForeignKEY` FOREIGN KEY (`K03F04`) REFERENCES `adrsbk01` (`K01F01`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='States';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk03`
--

LOCK TABLES `adrsbk03` WRITE;
/*!40000 ALTER TABLE `adrsbk03` DISABLE KEYS */;
INSERT INTO `adrsbk03` VALUES (1,'Andhra Pradesh',77,1),(2,'Arunachal Pradesh',77,1),(3,'Assam',77,1),(4,'Bihar',77,1),(5,'Chhattisgarh',77,1),(6,'Goa',77,1),(7,'Gujarat',77,1),(8,'Haryana',77,1),(9,'Himachal Pradesh',77,1),(10,'Jammu and Kashmir',77,1),(11,'Jharkhand',77,1),(12,'Karnataka',77,1),(13,'Kerala',77,1),(14,'Madhya Pradesh',77,1),(15,'Maharashtra',77,1),(16,'Manipur',77,1),(17,'Meghalaya',77,1),(18,'Mizoram',77,1),(19,'Nagaland',77,1),(20,'Odisha',77,1),(21,'Punjab',77,1),(22,'Rajasthan',77,1),(23,'Sikkim',77,1),(24,'Tamil Nadu',77,1),(25,'Telangana',77,1),(26,'Tripura',77,1),(27,'Uttarakhand',77,1),(28,'Uttar Pradesh',77,1),(29,'West Bengal',77,1),(30,'Andaman and Nicobar Islands',77,1),(31,'Chandigarh',77,1),(32,'Dadra and Nagar Haveli',77,1),(33,'Daman and Diu',77,1),(34,'Delhi',77,1),(35,'Lakshadweep',77,1),(36,'Puducherry',77,1);
/*!40000 ALTER TABLE `adrsbk03` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `adrsbk04`
--

DROP TABLE IF EXISTS `adrsbk04`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `adrsbk04` (
  `K04F01` int NOT NULL AUTO_INCREMENT COMMENT 'CityID',
  `K04F02` varchar(100) NOT NULL COMMENT 'CityName',
  `K04F03` varchar(20) DEFAULT NULL COMMENT 'STDCode',
  `K04F04` varchar(10) DEFAULT NULL,
  `K04F05` int NOT NULL COMMENT 'StateID',
  `K04F06` int NOT NULL COMMENT 'UserID',
  PRIMARY KEY (`K04F01`),
  KEY `StateID_idx` (`K04F05`),
  KEY `UserID_idx` (`K04F06`),
  CONSTRAINT `StateID` FOREIGN KEY (`K04F05`) REFERENCES `adrsbk03` (`K03F01`),
  CONSTRAINT `UserIDCity` FOREIGN KEY (`K04F06`) REFERENCES `adrsbk01` (`K01F01`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Cities';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk04`
--

LOCK TABLES `adrsbk04` WRITE;
/*!40000 ALTER TABLE `adrsbk04` DISABLE KEYS */;
INSERT INTO `adrsbk04` VALUES (1,'Ahmedabad',NULL,NULL,7,1),(2,'Amreli',NULL,NULL,7,1),(3,'Anand',NULL,NULL,7,1),(4,'Aravalli',NULL,NULL,7,1),(5,'Banaskantha',NULL,NULL,7,1),(6,'Bharuch',NULL,NULL,7,1),(7,'Bhavnagar',NULL,NULL,7,1),(8,'Botad',NULL,NULL,7,1),(9,'Chhota Udepur',NULL,NULL,7,1),(10,'Dahod',NULL,NULL,7,1),(11,'Dang',NULL,NULL,7,1),(12,'Devbhoomi Dwarka',NULL,NULL,7,1),(13,'Gandhinagar',NULL,NULL,7,1),(14,'Gir Somnath',NULL,NULL,7,1),(15,'Jamnagar',NULL,NULL,7,1),(16,'Junagadh',NULL,NULL,7,1),(17,'Kheda',NULL,NULL,7,1),(18,'Kutch',NULL,NULL,7,1),(19,'Mahisagar',NULL,NULL,7,1),(20,'Mehsana',NULL,NULL,7,1),(21,'Morbi',NULL,NULL,7,1),(22,'Narmada',NULL,NULL,7,1),(23,'Navsari',NULL,NULL,7,1),(24,'Panchmahal',NULL,NULL,7,1),(25,'Patan',NULL,NULL,7,1),(26,'Porbandar',NULL,NULL,7,1),(27,'Rajkot',NULL,NULL,7,1),(28,'Sabarkantha',NULL,NULL,7,1),(29,'Surat',NULL,NULL,7,1),(30,'Surendranagar',NULL,NULL,7,1),(31,'Tapi',NULL,NULL,7,1),(32,'Vadodara',NULL,NULL,7,1),(33,'Valsad',NULL,NULL,7,1);
/*!40000 ALTER TABLE `adrsbk04` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `adrsbk05`
--

DROP TABLE IF EXISTS `adrsbk05`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `adrsbk05` (
  `K05F01` int NOT NULL AUTO_INCREMENT COMMENT 'ContactCategoryID',
  `K05F02` varchar(45) NOT NULL COMMENT 'ContactCategoryName',
  `K05F03` int NOT NULL COMMENT 'UserID',
  PRIMARY KEY (`K05F01`),
  KEY `UserIDContactCateogry_idx` (`K05F03`),
  CONSTRAINT `UserIDContactCateogry` FOREIGN KEY (`K05F03`) REFERENCES `adrsbk01` (`K01F01`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='ContactCategory';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk05`
--

LOCK TABLES `adrsbk05` WRITE;
/*!40000 ALTER TABLE `adrsbk05` DISABLE KEYS */;
INSERT INTO `adrsbk05` VALUES (1,'Primary',1),(2,'Business',1),(3,'Work',1),(4,'Favorite',1),(5,'Family',1);
/*!40000 ALTER TABLE `adrsbk05` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `adrsbk06`
--

DROP TABLE IF EXISTS `adrsbk06`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `adrsbk06` (
  `K06F01` int NOT NULL AUTO_INCREMENT COMMENT 'BloodGroupID',
  `K06F02` varchar(10) NOT NULL COMMENT 'BloodGroupName',
  `K06F03` int NOT NULL COMMENT 'UserID',
  PRIMARY KEY (`K06F01`),
  KEY `UserID_idx` (`K06F03`),
  CONSTRAINT `UserIDBloodGroup` FOREIGN KEY (`K06F03`) REFERENCES `adrsbk01` (`K01F01`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='BloodGroups';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk06`
--

LOCK TABLES `adrsbk06` WRITE;
/*!40000 ALTER TABLE `adrsbk06` DISABLE KEYS */;
INSERT INTO `adrsbk06` VALUES (1,'A+',1),(2,'B+',1);
/*!40000 ALTER TABLE `adrsbk06` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `adrsbk07`
--

DROP TABLE IF EXISTS `adrsbk07`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `adrsbk07` (
  `K07F01` int NOT NULL AUTO_INCREMENT COMMENT 'ContactID',
  `K07F02` varchar(100) NOT NULL COMMENT 'ContactName',
  `K07F03` varchar(500) DEFAULT NULL COMMENT 'Address',
  `K07F04` int DEFAULT NULL COMMENT 'CityID',
  `K07F05` int DEFAULT NULL COMMENT 'StateID',
  `K07F06` int DEFAULT NULL COMMENT 'CountryID',
  `K07F07` varchar(10) DEFAULT NULL COMMENT 'Pincode',
  `K07F08` varchar(20) NOT NULL COMMENT 'MobileNo',
  `K07F09` int DEFAULT NULL COMMENT 'TelePhoneNo',
  `K07F10` varchar(50) DEFAULT NULL COMMENT 'EmailID',
  `K07F11` varchar(10) DEFAULT NULL COMMENT 'Gendar',
  `K07F12` date DEFAULT NULL COMMENT 'BirthDate',
  `K07F13` int DEFAULT NULL COMMENT 'Age',
  `K07F14` int DEFAULT NULL COMMENT 'BloodGroupID',
  `K07F15` varchar(45) DEFAULT NULL COMMENT 'Profession',
  `K07F16` int NOT NULL COMMENT 'ContactCategoryID',
  `K07F17` int NOT NULL COMMENT 'UserID',
  PRIMARY KEY (`K07F01`),
  KEY `CotactCityID_idx` (`K07F04`),
  KEY `ContactStateID_idx` (`K07F05`),
  KEY `ContactCountryID_idx` (`K07F06`),
  KEY `ContactBloodGroupID_idx` (`K07F14`),
  KEY `ContactContactCategoryID_idx` (`K07F16`),
  KEY `ContactUserID_idx` (`K07F17`),
  CONSTRAINT `ContactBloodGroupID` FOREIGN KEY (`K07F14`) REFERENCES `adrsbk06` (`K06F01`),
  CONSTRAINT `ContactContactCategoryID` FOREIGN KEY (`K07F16`) REFERENCES `adrsbk05` (`K05F01`),
  CONSTRAINT `ContactCountryID` FOREIGN KEY (`K07F06`) REFERENCES `adrsbk02` (`K02F01`),
  CONSTRAINT `ContactStateID` FOREIGN KEY (`K07F05`) REFERENCES `adrsbk03` (`K03F01`),
  CONSTRAINT `ContactUserID` FOREIGN KEY (`K07F17`) REFERENCES `adrsbk01` (`K01F01`),
  CONSTRAINT `CotactCityID` FOREIGN KEY (`K07F04`) REFERENCES `adrsbk04` (`K04F01`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Contacts';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk07`
--

LOCK TABLES `adrsbk07` WRITE;
/*!40000 ALTER TABLE `adrsbk07` DISABLE KEYS */;
INSERT INTO `adrsbk07` VALUES (1,'Brijesh Kamani','Rajkot',27,7,77,'360002','8320247480',NULL,'brijeshkamani11@gmail.com','Male','2001-03-30',20,1,'Employee',1,1);
/*!40000 ALTER TABLE `adrsbk07` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'addressbook'
--

--
-- Dumping routines for database 'addressbook'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-01-24 14:26:12
