/*
SQLyog Ultimate v9.63 
MySQL - 5.5.5-10.1.19-MariaDB : Database - enrollment
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`enrollment` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `enrollment`;

/*Table structure for table `studinfo` */

DROP TABLE IF EXISTS `studinfo`;

CREATE TABLE `studinfo` (
  `cstudno` CHAR(5) NOT NULL DEFAULT '',
  `cfname` VARCHAR(50) NOT NULL DEFAULT '',
  `cmname` VARCHAR(50) NOT NULL DEFAULT '',
  `clname` VARCHAR(50) NOT NULL DEFAULT '',
  `cnickname` VARCHAR(50) NOT NULL DEFAULT '',
  `clocked` DECIMAL(1,0) NOT NULL,
  PRIMARY KEY (`cstudno`)
) ENGINE=INNODB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `studparents`;

CREATE TABLE `studparents` (
  `cstudid` CHAR(5) NOT NULL,
  `cparentlname` VARCHAR(100) NOT NULL,
  `cparentfname` VARCHAR(100) NOT NULL,
  `cparentmname` VARCHAR(100) NOT NULL,
  `cparentbdate` DATE NOT NULL,
  `coccupation` VARCHAR(100) NOT NULL,
  `cgender` VARCHAR(10) NOT NULL,
  `ccitizenship` VARCHAR(50) NOT NULL,
  `cpermaddress` VARCHAR(200) NOT NULL,
  `cpresaddress` VARCHAR(200) NOT NULL,
  `creligion` VARCHAR(50) NOT NULL,
  KEY `cstudid` (`cstudid`),
  CONSTRAINT `studparents_ibfk_1` FOREIGN KEY (`cstudid`) REFERENCES `studinfo` (`cstudno`)
) ENGINE=INNODB DEFAULT CHARSET=latin1;

/*Data for the table `studparents` */

/*Table structure for table `studpersonalinfo` */

DROP TABLE IF EXISTS `studpersonalinfo`;

CREATE TABLE `studpersonalinfo` (
  `cstudid` CHAR(5) NOT NULL,
  `cbirthdate` DATE NOT NULL,
  `cbirthplace` VARCHAR(100) NOT NULL,
  `cgender` VARCHAR(10) NOT NULL,
  `ccitizenship` VARCHAR(50) NOT NULL,
  `cheight` DECIMAL(5,2) NOT NULL,
  `cweight` DECIMAL(5,2) NOT NULL,
  `creligion` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`cstudid`),
  CONSTRAINT `studpersonalinfo_ibfk_1` FOREIGN KEY (`cstudid`) REFERENCES `studinfo` (`cstudno`)
) ENGINE=INNODB DEFAULT CHARSET=latin1;

DROP TABLE IF EXISTS `teacherinfo`;

CREATE TABLE `teacherinfo` (
  `cteachno` CHAR(5) NOT NULL,
  `cteacherfname` VARCHAR(100) DEFAULT NULL,
  `cteachermname` VARCHAR(100) DEFAULT NULL,
  `cteacherlname` VARCHAR(100) DEFAULT NULL,
  PRIMARY KEY (`cteachno`)
) ENGINE=INNODB DEFAULT CHARSET=latin1;

/*Data for the table `teacherinfo` */

/*Table structure for table `teacherpersonalinfo` */

DROP TABLE IF EXISTS `teacherpersonalinfo`;

CREATE TABLE `teacherpersonalinfo` (
  `cteachID` CHAR(5) NOT NULL,
  `cbirthdate` DATE DEFAULT NULL,
  `cbirthplacecode` CHAR(6) DEFAULT NULL,
  `cbirthplace2` VARCHAR(100) DEFAULT NULL,
  `cgender` CHAR(1) DEFAULT NULL,
  `ccitizenship` CHAR(3) DEFAULT NULL,
  `cheight` DECIMAL(5,2) DEFAULT NULL,
  `cweight` DECIMAL(5,2) DEFAULT NULL,
  `creligion` CHAR(3) DEFAULT NULL,
  PRIMARY KEY (`cteachID`)
) ENGINE=INNODB DEFAULT CHARSET=latin1;

/*Data for the table `teacherpersonalinfo` */

/*Table structure for table `teacherskills` */

DROP TABLE IF EXISTS `teacherskills`;

CREATE TABLE `teacherskills` (
  `cteacherid` CHAR(5) DEFAULT NULL,
  `cskills` VARCHAR(100) DEFAULT NULL
) ENGINE=INNODB DEFAULT CHARSET=latin1;

/*Data for the table `teacherskills` */

/*Table structure for table `teacherskillslist` */

DROP TABLE IF EXISTS `teacherskillslist`;

CREATE TABLE `teacherskillslist` (
  `cskillcode` CHAR(6) DEFAULT NULL,
  `cskilldesc` VARCHAR(100) DEFAULT NULL
) ENGINE=INNODB DEFAULT CHARSET=latin1;

/*Data for the table `teacherskillslist` */

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `username` CHAR(50) NOT NULL,
  `password` CHAR(50) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=INNODB DEFAULT CHARSET=latin1;

/*Data for the table `user` */


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
