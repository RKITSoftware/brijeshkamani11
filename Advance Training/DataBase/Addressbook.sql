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
  `K01F05` varchar(20) NOT NULL COMMENT 'MobileNo',
  PRIMARY KEY (`K01F01`),
  UNIQUE KEY `K01F01_UNIQUE` (`K01F02`),
  UNIQUE KEY `K01F05_UNIQUE` (`K01F05`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Users';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk01`
--

LOCK TABLES `adrsbk01` WRITE;
/*!40000 ALTER TABLE `adrsbk01` DISABLE KEYS */;
INSERT INTO `adrsbk01` VALUES (1,'brijeshkamani','1234','Brijesh Kamani','1234567890'),(2,'rajkamani','4321','Raj Kamani','0987654321');
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
  PRIMARY KEY (`K02F01`),
  UNIQUE KEY `K02F01_UNIQUE` (`K02F02`),
  UNIQUE KEY `K02F03_UNIQUE` (`K02F03`)
) ENGINE=InnoDB AUTO_INCREMENT=178 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Countries';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk02`
--

LOCK TABLES `adrsbk02` WRITE;
/*!40000 ALTER TABLE `adrsbk02` DISABLE KEYS */;
INSERT INTO `adrsbk02` VALUES (1,'Afghanistan ',93),(2,'Albania ',355),(3,'Algeria ',213),(4,'Andorra, Principality of ',376),(5,'Angola',244),(6,'Antarctica',672),(7,'Argentina ',54),(8,'Armenia',374),(9,'Aruba',297),(10,'Australia',61),(11,'Austria',43),(12,'Bahrain, Kingdom of (Former Dilmun)',973),(13,'Bangladesh (Former East Pakistan)',880),(14,'Belgium ',32),(15,'Belize (Former British Honduras)',501),(16,'Benin (Former Dahomey)',229),(17,'Bhutan, Kingdom of',975),(18,'Bolivia ',591),(19,'Bosnia and Herzegovina ',387),(20,'Botswana (Former Bechuanaland)',267),(21,'Brazil ',55),(22,'Brunei (Negara Brunei Darussalam) ',673),(23,'Bulgaria ',359),(24,'Burkina Faso (Former Upper Volta)',226),(25,'Burundi (Former Urundi)',257),(26,'Cameroon (Former French Cameroon)',237),(27,'Canada ',1),(28,'Cape Verde ',238),(29,'Central African Republic ',236),(30,'Chad ',235),(31,'Chile ',56),(32,'China ',86),(33,'Christmas Island ',53),(35,'Colombia ',57),(36,'Comoros, Union of the ',269),(37,'Congo, Democratic Republic of the (Former Zaire) ',243),(38,'Congo, Republic of the',242),(39,'Cook Islands (Former Harvey Islands)',682),(40,'Costa Rica ',506),(41,'Cote D\'Ivoire (Former Ivory Coast) ',225),(42,'Croatia (Hrvatska) ',385),(44,'Cyprus ',357),(45,'Czech Republic',420),(46,'Denmark ',45),(47,'East Timor (Former Portuguese Timor)',670),(48,'Ecuador ',593),(49,'Egypt (Former United Arab Republic - with Syria)',20),(50,'El Salvador ',503),(51,'Equatorial Guinea (Former Spanish Guinea)',240),(52,'Ethiopia (Former Abyssinia, Italian East Africa)',251),(53,'Falkland Islands (Islas Malvinas) ',500),(54,'Faroe Islands ',298),(55,'Fiji ',679),(56,'Finland ',358),(57,'France ',33),(58,'French Guiana or French Guyana ',594),(59,'French Polynesia (Former French Colony of Oceania)',689),(60,'Gabon (Gabonese Republic)',241),(61,'Gambia, The ',220),(62,'Germany ',49),(63,'Ghana (Former Gold Coast)',233),(64,'Gibraltar ',350),(65,'Greece ',30),(66,'Greenland ',299),(67,'Guadeloupe',590),(68,'Guatemala ',502),(69,'Guinea (Former French Guinea)',224),(70,'Guinea-Bissau (Former Portuguese Guinea)',245),(71,'Guyana (Former British Guiana)',592),(72,'Haiti ',509),(73,'Honduras ',504),(74,'Hong Kong ',852),(75,'Hungary ',36),(76,'Iceland ',354),(77,'India ',91),(78,'Iran, Islamic Republic of',98),(79,'Iraq ',964),(80,'Ireland ',353),(81,'Israel ',972),(82,'Italy ',39),(83,'Japan ',81),(84,'Jordan (Former Transjordan)',962),(85,'Kenya (Former British East Africa)',254),(86,'Korea, Republic of (South Korea) ',82),(87,'Kuwait ',965),(88,'Lao People\'s Democratic Republic (Laos)',856),(89,'Latvia (Former Latvian Soviet Socialist Republic)',371),(90,'Lebanon ',961),(91,'Lesotho (Former Basutoland)',266),(92,'Liberia ',231),(93,'Libya (Libyan Arab Jamahiriya)',218),(94,'Liechtenstein ',423),(95,'Luxembourg ',352),(96,'Macau ',853),(97,'Macedonia, The Former Yugoslav Republic of',389),(98,'Madagascar (Former Malagasy Republic)',261),(99,'Malaysia ',60),(100,'Maldives ',960),(101,'Mali (Former French Sudan and Sudanese Republic) ',223),(102,'Malta ',356),(103,'Martinique (French) ',596),(104,'Mauritania ',222),(105,'Mauritius ',230),(107,'Mexico ',52),(108,'Moldova, Republic of',373),(109,'Monaco, Principality of',377),(110,'Mongolia (Former Outer Mongolia)',976),(111,'Morocco ',212),(112,'Mozambique (Former Portuguese East Africa)',258),(113,'Myanmar, Union of (Former Burma)',95),(114,'Nauru (Former Pleasant Island)',674),(115,'Nepal ',977),(116,'Netherlands ',31),(117,'New Caledonia ',687),(118,'New Zealand (Aotearoa) ',64),(119,'Nicaragua ',505),(120,'Niger ',227),(121,'Nigeria ',234),(122,'Niue (Former Savage Island)',683),(124,'Norway ',47),(125,'Oman, Sultanate of (Former Muscat and Oman)',968),(126,'Pakistan (Former West Pakistan)',92),(127,'Palestinian State (Proposed)',970),(128,'Panama ',507),(129,'Paraguay ',595),(130,'Peru ',51),(131,'Philippines ',63),(132,'Poland ',48),(133,'Portugal ',351),(134,'Qatar, State of ',974),(135,'Reunion (French) (Former Bourbon Island)',262),(136,'Romania ',40),(137,'Russian Federation ',7),(138,'Rwanda (Rwandese Republic) (Former Ruanda)',250),(139,'Saint Helena ',290),(140,'Saint Pierre and Miquelon ',508),(141,'Samoa (Former Western Samoa)',685),(142,'San Marino ',378),(143,'Sao Tome and Principe ',239),(144,'Saudi Arabia ',966),(145,'Senegal ',221),(146,'Seychelles ',248),(147,'Sierra Leone ',232),(148,'Singapore ',65),(149,'Slovakia',421),(150,'Slovenia ',386),(151,'Solomon Islands (Former British Solomon Islands)',677),(152,'South Africa (Former Union of South Africa)',27),(153,'Spain ',34),(154,'Sri Lanka (Former Serendib, Ceylon) ',94),(155,'Sudan (Former Anglo-Egyptian Sudan) ',249),(156,'Suriname (Former Netherlands Guiana, Dutch Guiana)',597),(157,'Swaziland, Kingdom of ',268),(158,'Sweden ',46),(159,'Switzerland ',41),(160,'Taiwan (Former Formosa)',886),(161,'Thailand (Former Siam)',66),(162,'Tokelau ',690),(163,'Tonga, Kingdom of (Former Friendly Islands)',676),(164,'Tunisia ',216),(165,'Turkey ',90),(166,'Tuvalu (Former Ellice Islands)',688),(167,'Uganda, Republic of',256),(168,'United Kingdom (Great Britain / UK)',44),(170,'Vanuatu (Former New Hebrides)',678),(171,'Vatican City State (Holy See)',418),(172,'Venezuela ',58),(173,'Vietnam ',84),(174,'Wallis and Futuna Islands ',681),(175,'Yemen ',967),(176,'Zambia, Republic of (Former Northern Rhodesia) ',260),(177,'Other',-1);
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
  `K03F03` int DEFAULT NULL COMMENT 'CountryID',
  PRIMARY KEY (`K03F01`),
  KEY `CountryID_idx` (`K03F03`),
  CONSTRAINT `CountryID` FOREIGN KEY (`K03F03`) REFERENCES `adrsbk02` (`K02F01`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='States';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk03`
--

LOCK TABLES `adrsbk03` WRITE;
/*!40000 ALTER TABLE `adrsbk03` DISABLE KEYS */;
INSERT INTO `adrsbk03` VALUES (1,'Andhra Pradesh',77),(2,'Arunachal Pradesh',77),(3,'Assam',77),(4,'Bihar',77),(5,'Chhattisgarh',77),(6,'Goa',77),(7,'Gujarat',77),(8,'Haryana',77),(9,'Himachal Pradesh',77),(10,'Jammu and Kashmir',77),(11,'Jharkhand',77),(12,'Karnataka',77),(13,'Kerala',77),(14,'Madhya Pradesh',77),(15,'Maharashtra',77),(16,'Manipur',77),(17,'Meghalaya',77),(18,'Mizoram',77),(19,'Nagaland',77),(20,'Odisha',77),(21,'Punjab',77),(22,'Rajasthan',77),(23,'Sikkim',77),(24,'Tamil Nadu',77),(25,'Telangana',77),(26,'Tripura',77),(27,'Uttarakhand',77),(28,'Uttar Pradesh',77),(29,'West Bengal',77),(30,'Andaman and Nicobar Islands',77),(31,'Chandigarh',77),(32,'Dadra and Nagar Haveli',77),(33,'Daman and Diu',77),(34,'Delhi',77),(35,'Lakshadweep',77),(36,'Puducherry',77),(38,'Other',NULL);
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
  `K04F03` varchar(10) DEFAULT NULL COMMENT 'Pincode',
  `K04F05` int DEFAULT NULL COMMENT 'StateID',
  PRIMARY KEY (`K04F01`),
  KEY `StateID_idx` (`K04F05`),
  CONSTRAINT `StateID` FOREIGN KEY (`K04F05`) REFERENCES `adrsbk03` (`K03F01`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Cities';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk04`
--

LOCK TABLES `adrsbk04` WRITE;
/*!40000 ALTER TABLE `adrsbk04` DISABLE KEYS */;
INSERT INTO `adrsbk04` VALUES (1,'Ahmedabad',NULL,7),(2,'Amreli',NULL,7),(3,'Anand',NULL,7),(4,'Aravalli',NULL,7),(5,'Banaskantha',NULL,7),(6,'Bharuch',NULL,7),(7,'Bhavnagar',NULL,7),(8,'Botad',NULL,7),(9,'Chhota Udepur',NULL,7),(10,'Dahod',NULL,7),(11,'Dang',NULL,7),(12,'Devbhoomi Dwarka',NULL,7),(13,'Gandhinagar',NULL,7),(14,'Gir Somnath',NULL,7),(15,'Jamnagar',NULL,7),(16,'Junagadh',NULL,7),(17,'Kheda',NULL,7),(18,'Kutch',NULL,7),(19,'Mahisagar',NULL,7),(20,'Mehsana',NULL,7),(21,'Morbi',NULL,7),(22,'Narmada',NULL,7),(23,'Navsari',NULL,7),(24,'Panchmahal',NULL,7),(25,'Patan',NULL,7),(26,'Porbandar',NULL,7),(27,'Rajkot',NULL,7),(28,'Sabarkantha',NULL,7),(29,'Surat',NULL,7),(30,'Surendranagar',NULL,7),(31,'Tapi',NULL,7),(32,'Vadodara',NULL,7),(33,'Valsad',NULL,7),(34,'Other',NULL,NULL);
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
  PRIMARY KEY (`K05F01`),
  UNIQUE KEY `K05F02_UNIQUE` (`K05F02`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='ContactCategory';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk05`
--

LOCK TABLES `adrsbk05` WRITE;
/*!40000 ALTER TABLE `adrsbk05` DISABLE KEYS */;
INSERT INTO `adrsbk05` VALUES (2,'Business'),(5,'Family'),(4,'Favorite'),(6,'Other'),(1,'Primary'),(3,'Work');
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
  PRIMARY KEY (`K06F01`),
  UNIQUE KEY `K06F02_UNIQUE` (`K06F02`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='BloodGroups';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk06`
--

LOCK TABLES `adrsbk06` WRITE;
/*!40000 ALTER TABLE `adrsbk06` DISABLE KEYS */;
INSERT INTO `adrsbk06` VALUES (1,'A+'),(2,'B+'),(3,'Other');
/*!40000 ALTER TABLE `adrsbk06` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `adrsbk07`
--

DROP TABLE IF EXISTS `adrsbk07`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `adrsbk07` (
  `K07F01` int NOT NULL AUTO_INCREMENT COMMENT 'GenderID',
  `K07F02` varchar(50) NOT NULL COMMENT 'GenderName',
  PRIMARY KEY (`K07F01`),
  UNIQUE KEY `K07F02_UNIQUE` (`K07F02`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Gender';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk07`
--

LOCK TABLES `adrsbk07` WRITE;
/*!40000 ALTER TABLE `adrsbk07` DISABLE KEYS */;
INSERT INTO `adrsbk07` VALUES (2,'Female'),(1,'Male'),(3,'Other');
/*!40000 ALTER TABLE `adrsbk07` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `adrsbk08`
--

DROP TABLE IF EXISTS `adrsbk08`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `adrsbk08` (
  `K08F01` int NOT NULL AUTO_INCREMENT COMMENT 'ContactID',
  `K08F02` varchar(100) NOT NULL COMMENT 'ContactName',
  `K08F03` varchar(500) DEFAULT NULL COMMENT 'Address',
  `K08F04` int DEFAULT NULL COMMENT 'CityID',
  `K08F05` int DEFAULT NULL COMMENT 'StateID',
  `K08F06` int DEFAULT NULL COMMENT 'CountryID',
  `K08F07` varchar(10) DEFAULT NULL COMMENT 'Pincode',
  `K08F08` varchar(20) NOT NULL COMMENT 'MobileNo',
  `K08F09` int DEFAULT NULL COMMENT 'TelePhoneNo',
  `K08F10` varchar(50) DEFAULT NULL COMMENT 'EmailID',
  `K08F11` int DEFAULT NULL COMMENT 'GenderID',
  `K08F12` date DEFAULT NULL COMMENT 'BirthDate',
  `K08F13` int DEFAULT NULL COMMENT 'Age',
  `K08F14` int DEFAULT NULL COMMENT 'BloodGroupID',
  `K08F15` varchar(45) DEFAULT NULL COMMENT 'Profession',
  `K08F16` int NOT NULL COMMENT 'ContactCategoryID',
  `K08F17` int NOT NULL COMMENT 'UserID',
  PRIMARY KEY (`K08F01`),
  KEY `CotactCityID_idx` (`K08F04`),
  KEY `ContactStateID_idx` (`K08F05`),
  KEY `ContactCountryID_idx` (`K08F06`),
  KEY `ContactBloodGroupID_idx` (`K08F14`),
  KEY `ContactContactCategoryID_idx` (`K08F16`),
  KEY `ContactUserID_idx` (`K08F17`) /*!80000 INVISIBLE */,
  KEY `ContactGenderID_idx` (`K08F11`),
  CONSTRAINT `ContactBloodGroupID` FOREIGN KEY (`K08F14`) REFERENCES `adrsbk06` (`K06F01`),
  CONSTRAINT `ContactContactCategoryID` FOREIGN KEY (`K08F16`) REFERENCES `adrsbk05` (`K05F01`),
  CONSTRAINT `ContactCountryID` FOREIGN KEY (`K08F06`) REFERENCES `adrsbk02` (`K02F01`),
  CONSTRAINT `ContactGenderID` FOREIGN KEY (`K08F11`) REFERENCES `adrsbk07` (`K07F01`),
  CONSTRAINT `ContactStateID` FOREIGN KEY (`K08F05`) REFERENCES `adrsbk03` (`K03F01`),
  CONSTRAINT `ContactUserID` FOREIGN KEY (`K08F17`) REFERENCES `adrsbk01` (`K01F01`),
  CONSTRAINT `CotactCityID` FOREIGN KEY (`K08F04`) REFERENCES `adrsbk04` (`K04F01`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Contacts';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adrsbk08`
--

LOCK TABLES `adrsbk08` WRITE;
/*!40000 ALTER TABLE `adrsbk08` DISABLE KEYS */;
INSERT INTO `adrsbk08` VALUES (1,'Brijesh Kamani','Rajkot',27,7,77,'360002','8320247480',NULL,'brijeshkamani11@gmail.com',1,'2001-03-30',20,1,'Employee',1,1),(2,'Raj Kamani','Rajkot',27,7,77,'360002','9558438530',NULL,'rajkamani2000@gmail.com',1,'2000-12-21',21,2,'Employee',1,1);
/*!40000 ALTER TABLE `adrsbk08` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `vv_selectallcontactsdetails`
--

DROP TABLE IF EXISTS `vv_selectallcontactsdetails`;
/*!50001 DROP VIEW IF EXISTS `vv_selectallcontactsdetails`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vv_selectallcontactsdetails` AS SELECT 
 1 AS `K08F01`,
 1 AS `K08F02`,
 1 AS `K08F03`,
 1 AS `K08F04`,
 1 AS `K04F02`,
 1 AS `K08F05`,
 1 AS `K03F02`,
 1 AS `K08F06`,
 1 AS `K02F02`,
 1 AS `K08F07`,
 1 AS `K08F08`,
 1 AS `K08F09`,
 1 AS `K08F10`,
 1 AS `K08F11`,
 1 AS `K07F02`,
 1 AS `K08F12`,
 1 AS `K08F13`,
 1 AS `K08F14`,
 1 AS `K06F02`,
 1 AS `K08F15`,
 1 AS `K08F16`,
 1 AS `K05F02`,
 1 AS `K08F17`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'addressbook'
--

--
-- Dumping routines for database 'addressbook'
--
/*!50003 DROP PROCEDURE IF EXISTS `sp_DeleteContactByContactIDAndUserID` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_DeleteContactByContactIDAndUserID`(IN p_ContactID INT, IN p_UserID INT)
BEGIN
	DELETE FROM
		`addressbook`.`adrsbk08`
	WHERE
		`K08F01` = p_ContactID
	AND
		`K08F17` = p_UserID
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_InsertContact` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_InsertContact`(out p_ContactID INT, IN p_ContactName varchar(100),IN p_Address varchar(500),IN p_CityID INT, IN p_StateID INT,
     IN p_CountryID INT, IN p_Pincode varchar(10), IN p_MobileNo varchar(20), IN p_TelePhoneNo INT, IN p_EmailID varchar(50),
	 IN p_GenderID INT, IN p_Birthdate DATE, IN p_Age INT, IN p_BloodGroupID INT, IN p_Profession varchar(45), IN p_ContactCategoryID INT,
	 IN p_UserID INt
	)
BEGIN
	INSERT INTO `addressbook`.`adrsbk08`
	(	`K08F02`,
		`K08F03`,
		`K08F04`,
		`K08F05`,
		`K08F06`,
		`K08F07`,
		`K08F08`,
		`K08F09`,
		`K08F10`,
		`K08F11`,
		`K08F12`,
		`K08F13`,
		`K08F14`,
		`K08F15`,
		`K08F16`,
		`K08F17`
	)
	VALUES
	(	p_ContactName,
		p_Address,
		p_CityID,
		p_StateID,
		p_CountryID,
		p_Pincode,
		p_MobileNo,
		p_TelePhoneNo,
		p_EmailID,
		p_GenderID,
		p_Birthdate,
		p_Age,
		p_BloodGroupID,
		p_Profession,
		p_ContactCategoryID,
		p_UserID
	);
	SET p_ContactID = LAST_INSERT_ID(); 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_SelectAllContectsByUserID` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_SelectAllContectsByUserID`(IN p_UserID int)
BEGIN
	SELECT
		`K08F01`,
		`K08F02`,
		`K08F03`,
		`K04F02`,
		`K03F02`,
		`K02F02`,
		`K08F07`,
		`K08F08`,
		`K08F09`,
		`K08F10`,
		`K07F02`,
		`K08F12`,
		`K08F13`,
		`K06F02`,
		`K08F15`,
		`K05F02`,
		`K08F17`
	FROM
		`vv_selectAllContactsDetails`
	Where
		`K08F17` = p_UserID;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_SelectContactByContactID` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_SelectContactByContactID`(IN p_ContactID int)
BEGIN
	SELECT
		`K08F01`,
		`K08F02`,
		`K08F03`,
		`K04F02`,
		`K03F02`,
		`K02F02`,
		`K08F07`,
		`K08F08`,
		`K08F09`,
		`K08F10`,
		`K07F02`,
		`K08F12`,
		`K08F13`,
		`K06F02`,
		`K08F15`,
		`K05F02`,
		`K08F17`
	FROM
		`vv_selectAllContactsDetails`
	Where
		`K08F01` = p_ContactID
	Limit 1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sp_UpdateContactByContactIDAndUserID` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_UpdateContactByContactIDAndUserID`(INOUT p_ContactID INT, IN p_ContactName varchar(100),IN p_Address varchar(500),IN p_CityID INT, IN p_StateID INT,
     IN p_CountryID INT, IN p_Pincode varchar(10), IN p_MobileNo varchar(20), IN p_TelePhoneNo INT, IN p_EmailID varchar(50),
	 IN p_GenderID INT, IN p_Birthdate DATE, IN p_Age INT, IN p_BloodGroupID INT, IN p_Profession varchar(45), IN p_ContactCategoryID INT,
	 IN p_UserID INt
	)
BEGIN
	UPDATE
		`addressbook`.`adrsbk08`
	SET
		`K08F01` = p_ContactID,
		`K08F02` = p_ContactName,
		`K08F03` = p_Address,
		`K08F04` = p_CityID,
		`K08F05` = p_StateID,
		`K08F06` = p_CountryID,
		`K08F07` = p_Pincode,
		`K08F08` = p_MobileNo,
		`K08F09` = p_TelePhoneNo,
		`K08F10` = p_EmailID,
		`K08F11` = p_GenderID,
		`K08F12` = p_Birthdate,
		`K08F13` = p_Age,
		`K08F14` = p_BloodGroupID,
		`K08F15` = p_Profession,
		`K08F16` = p_ContactCategoryID,
		`K08F17` = p_UserID
	WHERE
		`K08F01` = p_ContactID
	AND
		`K08F17` = p_UserID
	;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `vv_selectallcontactsdetails`
--

/*!50001 DROP VIEW IF EXISTS `vv_selectallcontactsdetails`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vv_selectallcontactsdetails` AS select `adrsbk08`.`K08F01` AS `K08F01`,`adrsbk08`.`K08F02` AS `K08F02`,`adrsbk08`.`K08F03` AS `K08F03`,`adrsbk08`.`K08F04` AS `K08F04`,`adrsbk04`.`K04F02` AS `K04F02`,`adrsbk08`.`K08F05` AS `K08F05`,`adrsbk03`.`K03F02` AS `K03F02`,`adrsbk08`.`K08F06` AS `K08F06`,`adrsbk02`.`K02F02` AS `K02F02`,`adrsbk08`.`K08F07` AS `K08F07`,`adrsbk08`.`K08F08` AS `K08F08`,`adrsbk08`.`K08F09` AS `K08F09`,`adrsbk08`.`K08F10` AS `K08F10`,`adrsbk08`.`K08F11` AS `K08F11`,`adrsbk07`.`K07F02` AS `K07F02`,`adrsbk08`.`K08F12` AS `K08F12`,`adrsbk08`.`K08F13` AS `K08F13`,`adrsbk08`.`K08F14` AS `K08F14`,`adrsbk06`.`K06F02` AS `K06F02`,`adrsbk08`.`K08F15` AS `K08F15`,`adrsbk08`.`K08F16` AS `K08F16`,`adrsbk05`.`K05F02` AS `K05F02`,`adrsbk08`.`K08F17` AS `K08F17` from ((((((`adrsbk08` left join `adrsbk02` on((`adrsbk08`.`K08F06` = `adrsbk02`.`K02F01`))) left join `adrsbk03` on((`adrsbk08`.`K08F05` = `adrsbk03`.`K03F01`))) left join `adrsbk04` on((`adrsbk08`.`K08F04` = `adrsbk04`.`K04F01`))) left join `adrsbk05` on((`adrsbk08`.`K08F16` = `adrsbk05`.`K05F01`))) left join `adrsbk06` on((`adrsbk08`.`K08F14` = `adrsbk06`.`K06F01`))) left join `adrsbk07` on((`adrsbk08`.`K08F11` = `adrsbk07`.`K07F01`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-01-25 13:09:46
