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
  `cstudno` char(5) NOT NULL DEFAULT '',
  `cfname` varchar(50) NOT NULL DEFAULT '',
  `cmname` varchar(50) NOT NULL DEFAULT '',
  `clname` varchar(50) NOT NULL DEFAULT '',
  `cnickname` varchar(50) NOT NULL DEFAULT '',
  `clocked` decimal(1,0) NOT NULL,
  PRIMARY KEY (`cstudno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `studinfo` */

insert  into `studinfo`(`cstudno`,`cfname`,`cmname`,`clname`,`cnickname`,`clocked`) values ('S0001','FRANCIS','PASINAG','DEL ROSARIO','LOUIE','0');

/*Table structure for table `studparents` */

DROP TABLE IF EXISTS `studparents`;

CREATE TABLE `studparents` (
  `cstudid` char(5) NOT NULL,
  `cparentlname` varchar(100) NOT NULL,
  `cparentfname` varchar(100) NOT NULL,
  `cparentmname` varchar(100) NOT NULL,
  `cparentbdate` date NOT NULL,
  `coccupation` varchar(100) NOT NULL,
  `cgender` varchar(10) NOT NULL,
  `ccitizenship` varchar(50) NOT NULL,
  `cpermaddress` varchar(200) NOT NULL,
  `cpresaddress` varchar(200) NOT NULL,
  `creligion` varchar(50) NOT NULL,
  KEY `cstudid` (`cstudid`),
  CONSTRAINT `studparents_ibfk_1` FOREIGN KEY (`cstudid`) REFERENCES `studinfo` (`cstudno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `studparents` */

/*Table structure for table `studpersonalinfo` */

DROP TABLE IF EXISTS `studpersonalinfo`;

CREATE TABLE `studpersonalinfo` (
  `cstudid` char(5) NOT NULL,
  `cbirthdate` date NOT NULL,
  `cbirthplace` varchar(100) NOT NULL,
  `cgender` varchar(10) NOT NULL,
  `ccitizenship` varchar(50) NOT NULL,
  `cheight` decimal(5,2) NOT NULL,
  `cweight` decimal(5,2) NOT NULL,
  `creligion` varchar(50) NOT NULL,
  PRIMARY KEY (`cstudid`),
  CONSTRAINT `studpersonalinfo_ibfk_1` FOREIGN KEY (`cstudid`) REFERENCES `studinfo` (`cstudno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `studpersonalinfo` */

insert  into `studpersonalinfo`(`cstudid`,`cbirthdate`,`cbirthplace`,`cgender`,`ccitizenship`,`cheight`,`cweight`,`creligion`) values ('S0001','2017-02-15','NORAL','MALE','FIL','123.00','123.00','ALL');

/*Table structure for table `teacherinfo` */

DROP TABLE IF EXISTS `teacherinfo`;

CREATE TABLE `teacherinfo` (
  `cteachno` char(5) NOT NULL,
  `cteacherfname` varchar(100) DEFAULT NULL,
  `cteachermname` varchar(100) DEFAULT NULL,
  `cteacherlname` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`cteachno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `teacherinfo` */

/*Table structure for table `teacherpersonalinfo` */

DROP TABLE IF EXISTS `teacherpersonalinfo`;

CREATE TABLE `teacherpersonalinfo` (
  `cteachID` char(5) NOT NULL,
  `cbirthdate` date DEFAULT NULL,
  `cbirthplacecode` char(6) DEFAULT NULL,
  `cbirthplace2` varchar(100) DEFAULT NULL,
  `cgender` char(1) DEFAULT NULL,
  `ccitizenship` char(3) DEFAULT NULL,
  `cheight` decimal(5,2) DEFAULT NULL,
  `cweight` decimal(5,2) DEFAULT NULL,
  `creligion` char(3) DEFAULT NULL,
  PRIMARY KEY (`cteachID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `teacherpersonalinfo` */

/*Table structure for table `teacherskills` */

DROP TABLE IF EXISTS `teacherskills`;

CREATE TABLE `teacherskills` (
  `cteacherid` char(5) DEFAULT NULL,
  `cskills` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `teacherskills` */

/*Table structure for table `teacherskillslist` */

DROP TABLE IF EXISTS `teacherskillslist`;

CREATE TABLE `teacherskillslist` (
  `cskillcode` char(6) DEFAULT NULL,
  `cskilldesc` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `teacherskillslist` */

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `username` char(50) NOT NULL,
  `password` char(50) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `user` */

insert  into `user`(`username`,`password`) values ('admin','admin');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
