-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 13 mai 2022 à 13:13
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `fulbank`
--

-- --------------------------------------------------------

--
-- Structure de la table `account`
--

DROP TABLE IF EXISTS `account`;
CREATE TABLE IF NOT EXISTS `account` (
  `A_ID` int(10) NOT NULL AUTO_INCREMENT,
  `A_ID_ACCOUNTTYPE` int(2) NOT NULL,
  `A_ID_USER` int(10) NOT NULL,
  `A_BALANCE` double NOT NULL,
  `A_OVERDRAFT_LIMIT` char(32) NOT NULL,
  PRIMARY KEY (`A_ID`),
  KEY `FK_ACCOUNT_USER` (`A_ID_USER`),
  KEY `FK_ACCOUNT_ACCOUNT_TYPE` (`A_ID_ACCOUNTTYPE`),
  KEY `A_ID_ACCOUNTTYPE` (`A_ID_ACCOUNTTYPE`,`A_ID_USER`)
) ENGINE=InnoDB AUTO_INCREMENT=1000000005 DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `account_type`
--

DROP TABLE IF EXISTS `account_type`;
CREATE TABLE IF NOT EXISTS `account_type` (
  `AT_ID` int(2) NOT NULL AUTO_INCREMENT,
  `AT_NAME` char(32) NOT NULL,
  `AT_INTEREST` decimal(6,2) NOT NULL,
  `AT_LIMIT` int(10) NOT NULL,
  PRIMARY KEY (`AT_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `account_type`
--

INSERT INTO `account_type` (`AT_ID`, `AT_NAME`, `AT_INTEREST`, `AT_LIMIT`) VALUES
(1, 'COMPTE CHEQUE', '0.00', 100000000),
(2, 'Livret A', '0.50', 25000);

-- --------------------------------------------------------

--
-- Structure de la table `admin`
--

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `A_ID` int(10) NOT NULL,
  PRIMARY KEY (`A_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `admin`
--

INSERT INTO `admin` (`A_ID`) VALUES
(1);

-- --------------------------------------------------------

--
-- Structure de la table `beneficiary`
--

DROP TABLE IF EXISTS `beneficiary`;
CREATE TABLE IF NOT EXISTS `beneficiary` (
  `B_USER_ID` int(11) NOT NULL,
  `B_ACCOUNT_ID` int(11) NOT NULL,
  `B_NAME` varchar(255) NOT NULL,
  PRIMARY KEY (`B_USER_ID`,`B_ACCOUNT_ID`),
  KEY `USER_ID` (`B_USER_ID`),
  KEY `B_ACCOUNT_ID` (`B_ACCOUNT_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `cryptowallet`
--

DROP TABLE IF EXISTS `cryptowallet`;
CREATE TABLE IF NOT EXISTS `cryptowallet` (
  `CW_ID` int(11) NOT NULL AUTO_INCREMENT,
  `CW_UID` int(11) NOT NULL,
  `CW_AMOUNT` float NOT NULL DEFAULT '0',
  `CW_C_SYMBOL` varchar(4) NOT NULL,
  PRIMARY KEY (`CW_UID`,`CW_C_SYMBOL`),
  UNIQUE KEY `CW_ID` (`CW_ID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `crypto_trade`
--

DROP TABLE IF EXISTS `crypto_trade`;
CREATE TABLE IF NOT EXISTS `crypto_trade` (
  `TRADE_ID` int(11) NOT NULL AUTO_INCREMENT,
  `WALLET_ID` int(11) NOT NULL,
  `TRADE_TYPE` tinyint(1) NOT NULL,
  `CURRENCY_VALUE` double NOT NULL,
  `CURRENCY_AMOUNT` double NOT NULL,
  `TOTAL_PRICE` double NOT NULL,
  `TRADE_DATE` datetime NOT NULL,
  PRIMARY KEY (`TRADE_ID`),
  KEY `WALLET_ID` (`WALLET_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `operation`
--

DROP TABLE IF EXISTS `operation`;
CREATE TABLE IF NOT EXISTS `operation` (
  `OP_ID` int(10) NOT NULL AUTO_INCREMENT,
  `OP_ID_TERMINAL` int(10) NOT NULL,
  `OP_ID_ACCOUNT` int(10) NOT NULL,
  `OP_AMOUNT` decimal(10,2) NOT NULL,
  `OP_ISDEBIT` tinyint(1) NOT NULL,
  `OP_DATE` datetime NOT NULL,
  PRIMARY KEY (`OP_ID`),
  KEY `FK_OPERATION_TERMINAL` (`OP_ID_TERMINAL`),
  KEY `FK_OPERATION_ACCOUNT` (`OP_ID_ACCOUNT`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `person`
--

DROP TABLE IF EXISTS `person`;
CREATE TABLE IF NOT EXISTS `person` (
  `P_ID` int(10) NOT NULL AUTO_INCREMENT,
  `P_NAME` char(32) NOT NULL,
  `P_FIRSTNAME` char(32) NOT NULL,
  `P_PASSWORD` char(255) NOT NULL,
  PRIMARY KEY (`P_ID`),
  KEY `P_ID` (`P_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `person`
--

INSERT INTO `person` (`P_ID`, `P_NAME`, `P_FIRSTNAME`, `P_PASSWORD`) VALUES
(1, 'Admin', 'Admin', '$2y$10$r2MtcuCFEM/ooeqElCS1GO94Xsb9Y.nW3YSNZRnqsvJd9WcLRMIWK');

-- --------------------------------------------------------

--
-- Structure de la table `terminal`
--

DROP TABLE IF EXISTS `terminal`;
CREATE TABLE IF NOT EXISTS `terminal` (
  `TL_ID` int(10) NOT NULL AUTO_INCREMENT,
  `TL_ADDRESS` char(64) NOT NULL,
  PRIMARY KEY (`TL_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=90 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `terminal`
--

INSERT INTO `terminal` (`TL_ID`, `TL_ADDRESS`) VALUES
(89, '');

-- --------------------------------------------------------

--
-- Structure de la table `transaction`
--

DROP TABLE IF EXISTS `transaction`;
CREATE TABLE IF NOT EXISTS `transaction` (
  `T_ID` int(10) NOT NULL AUTO_INCREMENT,
  `T_ID_ACCOUNT_TO` int(10) NOT NULL,
  `T_ID_ACCOUNT_FROM` int(10) NOT NULL,
  `T_AMOUNT` decimal(10,2) NOT NULL,
  `T_DATE` datetime NOT NULL,
  `T_TL_ID` int(11) NOT NULL,
  PRIMARY KEY (`T_ID`),
  KEY `FK_TRANSACTION_ACCOUNT` (`T_ID_ACCOUNT_TO`),
  KEY `FK_TRANSACTION_ACCOUNT1` (`T_ID_ACCOUNT_FROM`),
  KEY `T_TERMINALID` (`T_TL_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `U_ID` int(10) NOT NULL,
  `U_MAIL` char(32) NOT NULL,
  `U_PHONE` char(32) NOT NULL,
  `U_LANDLINE` char(32) NOT NULL,
  `U_ADRESS` char(32) NOT NULL,
  PRIMARY KEY (`U_ID`),
  KEY `U_ID` (`U_ID`) USING BTREE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `account`
--
ALTER TABLE `account`
  ADD CONSTRAINT `FK_AT_ID` FOREIGN KEY (`A_ID_ACCOUNTTYPE`) REFERENCES `account_type` (`AT_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_U_ID` FOREIGN KEY (`A_ID_USER`) REFERENCES `user` (`U_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `admin`
--
ALTER TABLE `admin`
  ADD CONSTRAINT `FK_ADMIN_P_ID` FOREIGN KEY (`A_ID`) REFERENCES `person` (`P_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Contraintes pour la table `beneficiary`
--
ALTER TABLE `beneficiary`
  ADD CONSTRAINT `FK_BENEFICIARY_ACCOUNT` FOREIGN KEY (`B_ACCOUNT_ID`) REFERENCES `account` (`A_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_BENEFICIARY_USER` FOREIGN KEY (`B_USER_ID`) REFERENCES `user` (`U_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `crypto_trade`
--
ALTER TABLE `crypto_trade`
  ADD CONSTRAINT `crypto_trade_ibfk_1` FOREIGN KEY (`WALLET_ID`) REFERENCES `cryptowallet` (`CW_ID`);

--
-- Contraintes pour la table `operation`
--
ALTER TABLE `operation`
  ADD CONSTRAINT `FK_OPERATION_ACCOUNT` FOREIGN KEY (`OP_ID_ACCOUNT`) REFERENCES `account` (`A_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_OPERATION_TERMINAL` FOREIGN KEY (`OP_ID_TERMINAL`) REFERENCES `terminal` (`TL_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `transaction`
--
ALTER TABLE `transaction`
  ADD CONSTRAINT `FK_TRANSACTION_ACCOUNT_FROM` FOREIGN KEY (`T_ID_ACCOUNT_FROM`) REFERENCES `account` (`A_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_TRANSACTION_ACCOUNT_TO` FOREIGN KEY (`T_ID_ACCOUNT_TO`) REFERENCES `account` (`A_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_TRANSACTION_TERMINAL` FOREIGN KEY (`T_TL_ID`) REFERENCES `terminal` (`TL_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `FK_USER_P_ID` FOREIGN KEY (`U_ID`) REFERENCES `person` (`P_ID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
