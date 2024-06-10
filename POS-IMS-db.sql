-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 10, 2024 at 12:47 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_posdendonut`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_discount`
--

CREATE TABLE `tbl_discount` (
  `ID` int(11) NOT NULL,
  `DISCOUNTID` varchar(100) NOT NULL,
  `DISCOUNT` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_group`
--

CREATE TABLE `tbl_group` (
  `ID` int(11) NOT NULL,
  `progroup` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_group`
--

INSERT INTO `tbl_group` (`ID`, `progroup`) VALUES
(11, 'test'),
(12, 'demo');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pos`
--

CREATE TABLE `tbl_pos` (
  `ID` int(11) NOT NULL,
  `BILLNO` varchar(100) NOT NULL,
  `BILLDATE` date NOT NULL,
  `BMONTH` varchar(100) NOT NULL,
  `BMONTHYEAR` varchar(100) NOT NULL,
  `PROCODE` varchar(100) NOT NULL,
  `PRONAME` varchar(100) NOT NULL,
  `PROGROUP` varchar(100) NOT NULL,
  `PRICE` decimal(10,2) NOT NULL,
  `TAX` decimal(10,2) NOT NULL,
  `TOTALPROPRICE` decimal(10,2) NOT NULL,
  `QTY` varchar(100) NOT NULL,
  `TOTALPRICEQTY` decimal(10,2) NOT NULL,
  `SUBTOTAL` decimal(10,2) NOT NULL,
  `TOTALTAX` decimal(10,2) NOT NULL,
  `DISCOUNT` decimal(10,2) NOT NULL,
  `GRANDTOTAL` decimal(10,2) NOT NULL,
  `PAYMODE` varchar(100) NOT NULL,
  `AMOUNTRECEIVED` decimal(10,2) NOT NULL,
  `BALANCE` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_pos`
--

INSERT INTO `tbl_pos` (`ID`, `BILLNO`, `BILLDATE`, `BMONTH`, `BMONTHYEAR`, `PROCODE`, `PRONAME`, `PROGROUP`, `PRICE`, `TAX`, `TOTALPROPRICE`, `QTY`, `TOTALPRICEQTY`, `SUBTOTAL`, `TOTALTAX`, `DISCOUNT`, `GRANDTOTAL`, `PAYMODE`, `AMOUNTRECEIVED`, `BALANCE`) VALUES
(23, '20244', '2024-05-10', '05', 'May-2024', '12345', 'testing', 'test', 1500.00, 5.00, 1575.00, '5', 1575.00, 18610.00, 3041.40, 2165.14, 19486.26, 'CASH', 20000.00, 513.74),
(24, '20244', '2024-05-10', '05', 'May-2024', 'demo1234', 'demo1', 'demo', 1111.00, 24.00, 1377.64, '10', 1377.64, 18610.00, 3041.40, 2165.14, 19486.26, 'CASH', 20000.00, 513.74),
(25, '20245', '2024-06-05', '06', 'June-2024', '12345', 'testingedit', 'test', 1500.00, 5.00, 1575.00, '1', 1575.00, 1500.00, 75.00, 0.00, 1575.00, 'CASH', 1600.00, 25.00);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_products`
--

CREATE TABLE `tbl_products` (
  `ID` int(11) NOT NULL,
  `PROCODE` varchar(100) NOT NULL,
  `PRONAME` varchar(100) NOT NULL,
  `PROGROUP` varchar(100) NOT NULL,
  `PRICE` decimal(10,2) NOT NULL,
  `TAX` decimal(10,2) NOT NULL,
  `TOTALPRICE` decimal(10,2) NOT NULL,
  `STOCK` decimal(10,2) NOT NULL,
  `BARCODE` blob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_products`
--

INSERT INTO `tbl_products` (`ID`, `PROCODE`, `PRONAME`, `PROGROUP`, `PRICE`, `TAX`, `TOTALPRICE`, `STOCK`, `BARCODE`) VALUES
(15, '12345', 'testingedit', 'test', 1500.00, 5.00, 1575.00, 6.00, 0xffd8ffe000104a46494600010101006000600000ffdb004300080606070605080707070909080a0c140d0c0b0b0c1912130f141d1a1f1e1d1a1c1c20242e2720222c231c1c2837292c30313434341f27393d38323c2e333432ffdb0043010909090c0b0c180d0d1832211c213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232ffc00011080096012c03012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00f7fa28a2800a28aa71eada6cdaa4da5c5a85a3ea10a6f96d166532a2f1cb267207ccbc91dc7ad005ca2b2e3f12e83369736a916b7a6be9f0bec96ed6e90c48dc70cf9c03f32f04f71eb54ffe13bf07ff00d0d7a1ff00e0c61ffe2a803a0a2b2e4f12e830e970ea92eb7a6a69f33ec8aedae9044edcf0af9c13f2b700f63e95624d5b4d8754874b9750b44d4264df15a34ca2575e7954ce48f95b903b1f4a00b94553bcd5b4dd3ee2d6def750b4b69eedf65b4734ca8d33640c20272c72c381ea3d6ae50014565c7e25d066d2e6d522d6f4d7d3e17d92ddadd21891b8e19f3807e65e09ee3d6b4209e1bab78ae2de58e682540f1c91b0657523208238208ef40125154e3d5b4d9b549b4b8b50b47d4214df2da2cca6545e3964ce40f997923b8f5a24d5b4d8754874b9750b44d4264df15a34ca2575e7954ce48f95b903b1f4a00b94553b3d5b4dd42e2eadecb50b4b99ed1f65cc70ccaed0b648c38072a72a783e87d2ae50014565c7e25d066d2e6d522d6f4d7d3e17d92ddadd21891b8e19f3807e65e09ee3d6ae7dbecffb3bfb47ed707d87caf3fed3e60f2fcbc6edfbba6dc739e98a00b14565c9e25d061d2e1d525d6f4d4d3e67d915db5d2089db9e15f3827e56e01ec7d2b52800a2a9d9eada6ea171756f65a85a5ccf68fb2e6386657685b2461c03953953c1f43e9447ab69b36a9369716a168fa8429be5b45994ca8bc72c99c81f32f24771eb401728aa726ada6c3aa43a5cba85a26a1326f8ad1a6512baf3caa67247cadc81d8fa5179ab69ba7dc5adbdeea1696d3ddbecb68e69951a66c818404e58e58703d47ad005ca2a9ea5ab69ba35badc6a9a85a58c0cfb164ba996252d82700b10338078f6354ec7c59e1bd4ef23b3b0f10695777526764305ec723b601270a0e4e0027f0a00d8a2b3e3d77479bedde56ab6327f67e7edbb6e10fd9b19cf99cfc98dadd71f74fa567ffc277e0fff00a1af43ff00c18c3ffc550074145539356d361d521d2e5d42d13509937c568d32895d79e5533923e56e40ec7d28bcd5b4dd3ee2d6def750b4b69eedf65b4734ca8d33640c20272c72c381ea3d6802e5154e3d5b4d9b549b4b8b50b47d4214df2da2cca6545e3964ce40f997923b8f5aaf1f897419b4b9b548b5bd35f4f85f64b76b7486246e3867ce01f997827b8f5a00d4a2b9ff00f84efc1fff00435e87ff0083187ff8aab92789741874b8754975bd3534f99f64576d7482276e7857ce09f95b807b1f4a00d4a28a2800a28a2800a28a2800af1ff0f7fc9d0f8b3fec149ffa0dad7b0578ff0087bfe4e87c59ff0060a4ff00d06d680380f0f7fc9af78b3fec2a9ffa15ad78fd7b0787bfe4d7bc59ff006154ff00d0ad6bc7e803d83c43ff0026bde13ffb0abffe85755dff00887fe4e87c27ff0060a7ff00d06eab80f10ffc9af784ff00ec2aff00fa15d577fe21ff0093a1f09ffd829fff0041baa003e2ff00fc943f863ff6153ffa36debd82bc7fe2ff00fc943f863ff6153ffa36debd82803e60f0f7fc9af78b3fec2a9ffa15ad7bff00813fe49e7867fec156bffa296bc03c3dff0026bde2cffb0aa7fe856b5eff00e04ff9279e19ff00b055affe8a5a00f3ff000f7fc9d0f8b3fec149ff00a0dad1e21ff93a1f09ff00d829ff00f41baa3c3dff002743e2cffb0527fe836b47887fe4e87c27ff0060a7ff00d06ea800f841ff00250fe277fd8547fe8db8af60af1ff841ff00250fe277fd8547fe8db8af60a00f983c3dff0026bde2cffb0aa7fe856b5ebfff0036f5ff0072a7feda5790787bfe4d7bc59ff6154ffd0ad6bd7ffe6debfee54ffdb4a00f20f10ffc9af784ff00ec2aff00fa15d57d3f5f307887fe4d7bc27ff6157ffd0aeabe9fa00f1ff841ff00250fe277fd8547fe8db8a3c3dff2743e2cff00b0527fe836b47c20ff009287f13bfec2a3ff0046dc51e1eff93a1f167fd8293ff41b5a003c43ff002743e13ffb053ffe837547c5ff00f9287f0c7fec2a7ff46dbd1e21ff0093a1f09ffd829fff0041baa3e2ff00fc943f863ff6153ffa36de800fda3bfe49e69fff006158ff00f454b5e41f04bfe4af685ff6f1ff00a224af5ffda3bfe49e69ff00f6158fff00454b5e41f04bfe4af685ff006f1ffa224a00f40f0dff00cd74ff00b79ffdbaaf9febe80f0dff00cd74ff00b79ffdbaaf9fe803e9ff0010ff00c9d0f84ffec14fff00a0dd51f17ffe4a1fc31ffb0a9ffd1b6f47887fe4e87c27ff0060a7ff00d06ea8f8bfff00250fe18ffd854ffe8db7a003c3dff2743e2cff00b0527fe836b5c0787bfe4d7bc59ff6154ffd0ad6bbff000f7fc9d0f8b3fec149ff00a0dad701e1eff935ef167fd8553ff42b5a00f1faf60f10ff00c9af784ffec2afff00a15d578fd7b07887fe4d7bc27ff6157ffd0aea803e9fa28a2800a28a2800a28a2800af1ff0f7fc9d0f8b3fec149ffa0dad7b0578ff0087bfe4e87c59ff0060a4ff00d06d680380f0f7fc9af78b3fec2a9ffa15ad78fd7b0787bfe4d7bc59ff006154ff00d0ad6bc7e803d83c43ff0026bde13ffb0abffe85755dff00887fe4e87c27ff0060a7ff00d06eab80f10ffc9af784ff00ec2aff00fa15d577fe21ff0093a1f09ffd829fff0041baa003e2ff00fc943f863ff6153ffa36debd82bc7fe2ff00fc943f863ff6153ffa36debd82803e60f0f7fc9af78b3fec2a9ffa15ad7bff00813fe49e7867fec156bffa296bc03c3dff0026bde2cffb0aa7fe856b5eff00e04ff9279e19ff00b055affe8a5a00f3ff000f7fc9d0f8b3fec149ff00a0dad1e21ff93a1f09ff00d829ff00f41baa3c3dff002743e2cffb0527fe836b47887fe4e87c27ff0060a7ff00d06ea800f841ff00250fe277fd8547fe8db8af60af1ff841ff00250fe277fd8547fe8db8af60a00f983c3dff0026bde2cffb0aa7fe856b5ebfff0036f5ff0072a7feda5790787bfe4d7bc59ff6154ffd0ad6bd7ffe6debfee54ffdb4a00f20f10ffc9af784ff00ec2aff00fa15d57d3f5f307887fe4d7bc27ff6157ffd0aeabe9fa00f1ff841ff00250fe277fd8547fe8db8a3c3dff2743e2cff00b0527fe836b47c20ff009287f13bfec2a3ff0046dc51e1eff93a1f167fd8293ff41b5a003c43ff002743e13ffb053ffe837547c5ff00f9287f0c7fec2a7ff46dbd1e21ff0093a1f09ffd829fff0041baa3e2ff00fc943f863ff6153ffa36de800fda3bfe49e69fff006158ff00f454b5e41f04bfe4af685ff6f1ff00a224af5ffda3bfe49e69ff00f6158fff00454b5e41f04bfe4af685ff006f1ffa224a00f40f0dff00cd74ff00b79ffdbaaf9febe80f0dff00cd74ff00b79ffdbaaf9fe803e9ff0010ff00c9d0f84ffec14fff00a0dd51f17ffe4a1fc31ffb0a9ffd1b6f47887fe4e87c27ff0060a7ff00d06ea8f8bfff00250fe18ffd854ffe8db7a003c3dff2743e2cff00b0527fe836b5c0787bfe4d7bc59ff6154ffd0ad6bbff000f7fc9d0f8b3fec149ff00a0dad701e1eff935ef167fd8553ff42b5a00f1faf60f10ff00c9af784ffec2afff00a15d578fd7b07887fe4d7bc27ff6157ffd0aea803e9fa28a2800a28a2800a28a2800af1ff0f7fc9d0f8b3fec149ffa0dad7b0578ff0087bfe4e87c59ff0060a4ff00d06d680380f0f7fc9af78b3fec2a9ffa15ad78fd7b0787bfe4d7bc59ff006154ff00d0ad6bc7e803d83c43ff0026bde13ffb0abffe85755dff00887fe4e87c27ff0060a7ff00d06eab80f10ffc9af784ff00ec2aff00fa15d577fe21ff0093a1f09ffd829fff0041baa003e2ff00fc943f863ff6153ffa36debd82bc7fe2ff00fc943f863ff6153ffa36debd82803e60f0f7fc9af78b3fec2a9ffa15ad7bff00813fe49e7867fec156bffa296bc03c3dff0026bde2cffb0aa7fe856b5eff00e04ff9279e19ff00b055affe8a5a00f3ff000f7fc9d0f8b3fec149ff00a0dad1e21ff93a1f09ff00d829ff00f41baa3c3dff002743e2cffb0527fe836b47887fe4e87c27ff0060a7ff00d06ea800f841ff00250fe277fd8547fe8db8af60af1ff841ff00250fe277fd8547fe8db8af60a00f983c3dff0026bde2cffb0aa7fe856b5ebfff0036f5ff0072a7feda5790787bfe4d7bc59ff6154ffd0ad6bd7ffe6debfee54ffdb4a00f20f10ffc9af784ff00ec2aff00fa15d57d3f5f307887fe4d7bc27ff6157ffd0aeabe9fa00f1ff841ff00250fe277fd8547fe8db8a3c3dff2743e2cff00b0527fe836b47c20ff009287f13bfec2a3ff0046dc51e1eff93a1f167fd8293ff41b5a003c43ff002743e13ffb053ffe837547c5ff00f9287f0c7fec2a7ff46dbd1e21ff0093a1f09ffd829fff0041baa3e2ff00fc943f863ff6153ffa36de800fda3bfe49e69fff006158ff00f454b5e41f04bfe4af685ff6f1ff00a224af5ffda3bfe49e69ff00f6158fff00454b5e41f04bfe4af685ff006f1ffa224a00f40f0dff00cd74ff00b79ffdbaaf9febe80f0dff00cd74ff00b79ffdbaaf9fe803e9ff0010ff00c9d0f84ffec14fff00a0dd51f17ffe4a1fc31ffb0a9ffd1b6f47887fe4e87c27ff0060a7ff00d06ea8f8bfff00250fe18ffd854ffe8db7a003c3dff2743e2cff00b0527fe836b5c0787bfe4d7bc59ff6154ffd0ad6bbff000f7fc9d0f8b3fec149ff00a0dad701e1eff935ef167fd8553ff42b5a00f1faf60f10ff00c9af784ffec2afff00a15d578fd7b07887fe4d7bc27ff6157ffd0aea803e9fa28a2800a28a2800a28a2800af1ff0f7fc9d0f8b3fec149ffa0dad7b0578ff0087bfe4e87c59ff0060a4ff00d06d680380f0f7fc9af78b3fec2a9ffa15ad78fd7b0787bfe4d7bc59ff006154ff00d0ad6bc7e803d83c43ff0026bde13ffb0abffe85755dff00887fe4e87c27ff0060a7ff00d06eab80f10ffc9af784ff00ec2aff00fa15d577fe21ff0093a1f09ffd829fff0041baa003e2ff00fc943f863ff6153ffa36debd82bc7fe2ff00fc943f863ff6153ffa36debd82803e60f0f7fc9af78b3fec2a9ffa15ad7bff00813fe49e7867fec156bffa296bc03c3dff0026bde2cffb0aa7fe856b5eff00e04ff9279e19ff00b055affe8a5a00f3ff000f7fc9d0f8b3fec149ff00a0dad1e21ff93a1f09ff00d829ff00f41baa3c3dff002743e2cffb0527fe836b47887fe4e87c27ff0060a7ff00d06ea800f841ff00250fe277fd8547fe8db8af60af1ff841ff00250fe277fd8547fe8db8af60a00f983c3dff0026bde2cffb0aa7fe856b5ebfff0036f5ff0072a7feda5790787bfe4d7bc59ff6154ffd0ad6bd7ffe6debfee54ffdb4a00f20f10ffc9af784ff00ec2aff00fa15d57d3f5f307887fe4d7bc27ff6157ffd0aeabe9fa00f1ff841ff00250fe277fd8547fe8db8a3c3dff2743e2cff00b0527fe836b47c20ff009287f13bfec2a3ff0046dc51e1eff93a1f167fd8293ff41b5a003c43ff002743e13ffb053ffe837547c5ff00f9287f0c7fec2a7ff46dbd1e21ff0093a1f09ffd829fff0041baa3e2ff00fc943f863ff6153ffa36de800fda3bfe49e69fff006158ff00f454b5e41f04bfe4af685ff6f1ff00a224af5ffda3bfe49e69ff00f6158fff00454b5e41f04bfe4af685ff006f1ffa224a00f40f0dff00cd74ff00b79ffdbaaf9febe80f0dff00cd74ff00b79ffdbaaf9fe803e9ff0010ff00c9d0f84ffec14fff00a0dd51f17ffe4a1fc31ffb0a9ffd1b6f47887fe4e87c27ff0060a7ff00d06ea8f8bfff00250fe18ffd854ffe8db7a003c3dff2743e2cff00b0527fe836b5c0787bfe4d7bc59ff6154ffd0ad6bbff000f7fc9d0f8b3fec149ff00a0dad701e1eff935ef167fd8553ff42b5a00f1faf60f10ff00c9af784ffec2afff00a15d578fd7b07887fe4d7bc27ff6157ffd0aea803e9fa28a2800a28a2800a28a2800af1ff0f7fc9d0f8b3fec149ffa0dad7b0578ff0087bfe4e87c59ff0060a4ff00d06d680380f0f7fc9af78b3fec2a9ffa15ad78fd7b0787bfe4d7bc59ff006154ff00d0ad6bc7e803d83c43ff0026bde13ffb0abffe85755dff00887fe4e87c27ff0060a7ff00d06eab80f10ffc9af784ff00ec2aff00fa15d577fe21ff0093a1f09ffd829fff0041baa003e2ff00fc943f863ff6153ffa36debd82bc7fe2ff00fc943f863ff6153ffa36debd82803e60f0f7fc9af78b3fec2a9ffa15ad7bff00813fe49e7867fec156bffa296bc03c3dff0026bde2cffb0aa7fe856b5eff00e04ff9279e19ff00b055affe8a5a00f3ff000f7fc9d0f8b3fec149ff00a0dad1e21ff93a1f09ff00d829ff00f41baa3c3dff002743e2cffb0527fe836b47887fe4e87c27ff0060a7ff00d06ea800f841ff00250fe277fd8547fe8db8af60af1ff841ff00250fe277fd8547fe8db8af60a00f983c3dff0026bde2cffb0aa7fe856b5ebfff0036f5ff0072a7feda5790787bfe4d7bc59ff6154ffd0ad6bd7ffe6debfee54ffdb4a00f20f10ffc9af784ff00ec2aff00fa15d57d3f5f307887fe4d7bc27ff6157ffd0aeabe9fa00f1ff841ff00250fe277fd8547fe8db8a3c3dff2743e2cff00b0527fe836b47c20ff009287f13bfec2a3ff0046dc51e1eff93a1f167fd8293ff41b5a003c43ff002743e13ffb053ffe837547c5ff00f9287f0c7fec2a7ff46dbd1e21ff0093a1f09ffd829fff0041baa3e2ff00fc943f863ff6153ffa36de800fda3bfe49e69fff006158ff00f454b5e41f04bfe4af685ff6f1ff00a224af5ffda3bfe49e69ff00f6158fff00454b5e41f04bfe4af685ff006f1ffa224a00f40f0dff00cd74ff00b79ffdbaaf9febe80f0dff00cd74ff00b79ffdbaaf9fe803e9ff0010ff00c9d0f84ffec14fff00a0dd51f17ffe4a1fc31ffb0a9ffd1b6f47887fe4e87c27ff0060a7ff00d06ea8f8bfff00250fe18ffd854ffe8db7a003c3dff2743e2cff00b0527fe836b5c0787bfe4d7bc59ff6154ffd0ad6bbff000f7fc9d0f8b3fec149ff00a0dad701e1eff935ef167fd8553ff42b5a00f1faf60f10ff00c9af784ffec2afff00a15d578fd7b07887fe4d7bc27ff6157ffd0aea803e9fa28a2800a28a2800a28a2800af1ff0f7fc9d0f8b3fec149ffa0dad7b0578ff0087bfe4e87c59ff0060a4ff00d06d680380f0f7fc9af78b3fec2a9ffa15ad78fd7b0787bfe4d7bc59ff006154ff00d0ad6bc7e803d83c43ff0026bde13ffb0abffe85755dff00887fe4e87c27ff0060a7ff00d06eab80f10ffc9af784ff00ec2aff00fa15d577fe21ff0093a1f09ffd829fff0041baa003e2ff00fc943f863ff6153ffa36debd82bc7fe2ff00fc943f863ff6153ffa36debd82803e60f0f7fc9af78b3fec2a9ffa15ad7bff00813fe49e7867fec156bffa296bc03c3dff0026bde2cffb0aa7fe856b5eff00e04ff9279e19ff00b055affe8a5a00f3ff000f7fc9d0f8b3fec149ff00a0dad1e21ff93a1f09ff00d829ff00f41baa3c3dff002743e2cffb0527fe836b47887fe4e87c27ff0060a7ff00d06ea800f841ff00250fe277fd8547fe8db8af60af1ff841ff00250fe277fd8547fe8db8af60a00f983c3dff0026bde2cffb0aa7fe856b5ebfff0036f5ff0072a7feda5790787bfe4d7bc59ff6154ffd0ad6bd7ffe6debfee54ffdb4a00f20f10ffc9af784ff00ec2aff00fa15d57d3f5f307887fe4d7bc27ff6157ffd0aeabe9fa00f1ff841ff00250fe277fd8547fe8db8a3c3dff2743e2cff00b0527fe836b47c20ff009287f13bfec2a3ff0046dc51e1eff93a1f167fd8293ff41b5a003c43ff002743e13ffb053ffe837547c5ff00f9287f0c7fec2a7ff46dbd1e21ff0093a1f09ffd829fff0041baa3e2ff00fc943f863ff6153ffa36de800fda3bfe49e69fff006158ff00f454b5e41f04bfe4af685ff6f1ff00a224af5ffda3bfe49e69ff00f6158fff00454b5e41f04bfe4af685ff006f1ffa224a00f40f0dff00cd74ff00b79ffdbaaf9febe80f0dff00cd74ff00b79ffdbaaf9fe803e9ff0010ff00c9d0f84ffec14fff00a0dd51f17ffe4a1fc31ffb0a9ffd1b6f47887fe4e87c27ff0060a7ff00d06ea8f8bfff00250fe18ffd854ffe8db7a003c3dff2743e2cff00b0527fe836b5c0787bfe4d7bc59ff6154ffd0ad6bbff000f7fc9d0f8b3fec149ff00a0dad701e1eff935ef167fd8553ff42b5a00f1faf60f10ff00c9af784ffec2afff00a15d578fd7b07887fe4d7bc27ff6157ffd0aea803e9fa28a2800a28a2800a28a2800af1ff0f7fc9d0f8b3fec149ffa0dad7b0578ff0087bfe4e87c59ff0060a4ff00d06d680380f0f7fc9af78b3fec2a9ffa15ad78fd7b0787bfe4d7bc59ff006154ff00d0ad6bc7e803d83c43ff0026bde13ffb0abffe85755dff00887fe4e87c27ff0060a7ff00d06eab80f10ffc9af784ff00ec2aff00fa15d577fe21ff0093a1f09ffd829fff0041baa003e2ff00fc943f863ff6153ffa36debd82bc7fe2ff00fc943f863ff6153ffa36debd82803e60f0f7fc9af78b3fec2a9ffa15ad7bff00813fe49e7867fec156bffa296bc03c3dff0026bde2cffb0aa7fe856b5eff00e04ff9279e19ff00b055affe8a5a00f3ff000f7fc9d0f8b3fec149ff00a0dad1e21ff93a1f09ff00d829ff00f41baa3c3dff002743e2cffb0527fe836b47887fe4e87c27ff0060a7ff00d06ea800f841ff00250fe277fd8547fe8db8af60af1ff841ff00250fe277fd8547fe8db8af60a00f983c3dff0026bde2cffb0aa7fe856b5ebfff0036f5ff0072a7feda5790787bfe4d7bc59ff6154ffd0ad6bd7ffe6debfee54ffdb4a00f20f10ffc9af784ff00ec2aff00fa15d57d3f5f307887fe4d7bc27ff6157ffd0aeabe9fa00f1ff841ff00250fe277fd8547fe8db8a3c3dff2743e2cff00b0527fe836b47c20ff009287f13bfec2a3ff0046dc51e1eff93a1f167fd8293ff41b5a003c43ff002743e13ffb053ffe837547c5ff00f9287f0c7fec2a7ff46dbd1e21ff0093a1f09ffd829fff0041baa3e2ff00fc943f863ff6153ffa36de800fda3bfe49e69fff006158ff00f454b5e41f04bfe4af685ff6f1ff00a224af5ffda3bfe49e69ff00f6158fff00454b5e41f04bfe4af685ff006f1ffa224a00f40f0dff00cd74ff00b79ffdbaaf9febe80f0dff00cd74ff00b79ffdbaaf9fe803e9ff0010ff00c9d0f84ffec14fff00a0dd51f17ffe4a1fc31ffb0a9ffd1b6f47887fe4e87c27ff0060a7ff00d06ea8f8bfff00250fe18ffd854ffe8db7a003c3dff2743e2cff00b0527fe836b5c0787bfe4d7bc59ff6154ffd0ad6bbff000f7fc9d0f8b3fec149ff00a0dad701e1eff935ef167fd8553ff42b5a00f1faf60f10ff00c9af784ffec2afff00a15d578fd7b07887fe4d7bc27ff6157ffd0aea803e9fa28a2800a28a2800a28a2800af2bd0b49d4a1fda37c4faa4ba7dda69f36988915db42c2276db6fc2be304fcadc03d8fa57aa51401f3a685e1ad7a1fd9cbc4fa5cba26a49a84da9a3c568d6ae2575dd6fcaa63247cadc81d8fa5795ff00c209e30ffa1535cffc174dff00c4d7dbf45007ce9aef86b5e9bf672f0c6971689a93ea10ea6ef2da2dab9951775c72c98c81f32f24771eb5dbebba4ea537ed1be18d522d3eedf4f874c7496ed61631236db8e19f1807e65e09ee3d6bd528a00f2bf8a7a4ea5a878ebe1ddc5969f777305a6a65ee64861675857cd80e5c81851853c9f43e95ea9451401f3a685e1ad7a1fd9cbc4fa5cba26a49a84da9a3c568d6ae2575dd6fcaa63247cadc81d8fa57b7f83209ad7c0be1eb7b88a48678b4cb64923914ab2308941041e4107b56e51401e57a1693a943fb46f89f54974fbb4d3e6d31122bb685844edb6df857c609f95b807b1f4a35dd27529bf68df0c6a9169f76fa7c3a63a4b76b0b1891b6dc70cf8c03f32f04f71eb5ea94500795fc2cd2752d3fc75f112e2f74fbbb682ef530f6d24d0b22ccbe6ce72848c30c30e47a8f5af54a28a00f9d342f0d6bd0fece5e27d2e5d13524d426d4d1e2b46b5712baeeb7e5531923e56e40ec7d2bd4fec179ff000a2bfb3bec93fdbbfe11af23ecde59f33ccfb36dd9b7aeecf18eb9aee28a00f9d35df0d6bd37ece5e18d2e2d13527d421d4dde5b45b5732a2eeb8e5931903e65e48ee3d6be8ba28a00f2bf859a4ea5a7f8ebe225c5ee9f776d05dea61eda49a1645997cd9ce5091861861c8f51eb4685a4ea50fed1be27d525d3eed34f9b4c448aeda16113b6db7e15f1827e56e01ec7d2bd528a00f2bd7749d4a6fda37c31aa45a7ddbe9f0e98e92ddac2c6246db71c33e300fccbc13dc7ad1f14f49d4b50f1d7c3bb8b2d3eeee60b4d4cbdcc90c2ceb0af9b01cb9030a30a793e87d2bd528a00f2bf8f9a4ea5acf816c6df4bd3eeefa75d4e3768ed6169582f9528c90a09c648e7dc57967c20f09f8934cf8a5a35e5ff0087f55b4b58fcfdf34f652468b9824032c46064903f1afa9e8a00f10f0fe85ac43ff0b97cdd2afa3fed0fb47d8b75bb8fb4e7ed38f2f8f9f3b97a67ef0f5af0ff00f8413c61ff0042a6b9ff0082e9bff89afb7e8a00f2bd7749d4a6fda37c31aa45a7ddbe9f0e98e92ddac2c6246db71c33e300fccbc13dc7ad1f14f49d4b50f1d7c3bb8b2d3eeee60b4d4cbdcc90c2ceb0af9b01cb9030a30a793e87d2bd528a00f2bd0b49d4a1fda37c4faa4ba7dda69f36988915db42c2276db6fc2be304fcadc03d8fa5711a1786b5e87f672f13e972e89a926a136a68f15a35ab895d775bf2a98c91f2b720763e95f45d1401f107fc209e30ff00a1535cff00c174dffc4d7aa6bbe1ad7a6fd9cbc31a5c5a26a4fa843a9bbcb68b6ae6545dd71cb263207ccbc91dc7ad7d1745001451450014514500145145001451450014514500145145001451450014514500145145001451450014514500145145001451450014514500145145001451450014514500145145001451450014514500145145007fffd9),
(16, 'demo1234', 'demo1', 'demo', 1111.00, 24.00, 1377.64, 10.00, 0xffd8ffe000104a46494600010101006000600000ffdb004300080606070605080707070909080a0c140d0c0b0b0c1912130f141d1a1f1e1d1a1c1c20242e2720222c231c1c2837292c30313434341f27393d38323c2e333432ffdb0043010909090c0b0c180d0d1832211c213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232ffc00011080096012c03012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00f7fa28a2800a28a2800a28acfb7d7747bbfb1fd9b55b19beddbfec9e5dc237da367dfd983f36def8ce3bd0068515cfff00c277e0ff00fa1af43ffc18c3ff00c55687f6ee8ffdb1fd91fdab63fda7ff003e5f684f3beeeefb99ddf779e9d39a00d0a2b3ee35dd1ed3ed9f69d56c61fb0ecfb5f99708bf67dff737e4fcbbbb6719ed46a7aee8fa2795fdadaad8d879d9f2fed770916fc6338dc467191d3d4500685155e6bfb3b7bcb6b39aee08eeaeb77d9e1790079768cb6d53cb607271d2abdc6bba3da7db3ed3aad8c3f61d9f6bf32e117ecfbfee6fc9f97776ce33da803428aaf0dfd9dc5e5cd9c377049756bb7ed10a480bc5b8657728e5723919eb55f4cd7747d6fcdfec9d56c6ff00c9c799f64b849766738ced2719c1ebe86803428acffeddd1ff00b1ff00b5ff00b56c7fb33fe7f7ed09e4fdedbf7f3b7ef71d7af147f6ee8ffdb1fd91fdab63fda7ff003e5f684f3beeeefb99ddf779e9d39a00d0a2b3ee35dd1ed3ed9f69d56c61fb0ecfb5f99708bf67dff737e4fcbbbb6719ed5626bfb3b7bcb6b39aee08eeaeb77d9e1790079768cb6d53cb607271d2802c5155e6bfb3b7bcb6b39aee08eeaeb77d9e1790079768cb6d53cb607271d28b1bfb3d4ece3bcb0bb82eed64cec9a090488d8241c30e0e0823f0a00b14567ff6ee8ffd8ffdaffdab63fd99ff003fbf684f27ef6dfbf9dbf7b8ebd78ab10dfd9dc5e5cd9c377049756bb7ed10a480bc5b8657728e5723919eb401628aaf35fd9dbde5b59cd770477575bbecf0bc803cbb465b6a9e5b03938e955ffb7747fec7fed7fed5b1feccff009fdfb42793f7b6fdfcedfbdc75ebc500685155e1bfb3b8bcb9b386ee092ead76fda21490178b70caee51cae47233d6886fecee2f2e6ce1bb824bab5dbf68852405e2dc32bb9472b91c8cf5a00b14567dbebba3ddfd8fecdaad8cdf6edff64f2ee11bed1b3efecc1f9b6f7c671de8d4f5dd1f44f2bfb5b55b1b0f3b3e5fdaee122df8c671b88ce323a7a8a00d0a2b1e6f16786edecedaf26f106951dadd6efb3ccf7b1849769c36d6270d83c1c74ab171aee8f69f6cfb4eab630fd8767dafccb845fb3eff00b9bf27e5dddb38cf6a00d0a2b3ee35dd1ed3ed9f69d56c61fb0ecfb5f99708bf67dff737e4fcbbbb6719ed55ec7c59e1bd4ef23b3b0f10695777526764305ec723b601270a0e4e0027f0a00d8a2abd8dfd9ea7671de585dc1776b26764d0482446c120e187070411f8558a0028a28a0028a28a0028a28a0028a28a002bc03e1fff00cd1dff00b8d7fecd5eff005e01f0ff00fe68effdc6bff66a00f9febe80ff009bbcff003ff3e15f3fd7d01ff3779fe7fe7c2800f881ff00358bfee0bffb2d1fb4d7fccadff6f7ff00b468f881ff00358bfee0bffb2d1fb4d7fccadff6f7ff00b46803bff16ffc95ef875ff712ff00d10b5c07c40ff9ac5ff705ff00d96bbff16ffc95ef875ff712ff00d10b5c07c40ff9ac5ff705ff00d96803bff097fc95ef88bff70dff00d10d5c07eccbff00334ffdba7fed6aeffc25ff00257be22ffdc37ff4435701fb32ff00ccd3ff006e9ffb5a800ff9b43ff3ff003ff47fcdde7f9ff9f0a3fe6d0ffcff00cffd1ff3779fe7fe7c2800f881ff00358bfee0bffb2d77fe2dff0092bdf0ebfee25ffa216b80f881ff00358bfee0bffb2d77fe2dff0092bdf0ebfee25ffa216800f16ffc95ef875ff712ff00d10b47c12ff9243a17fdbc7fe8f928f16ffc95ef875ff712ff00d10b47c12ff9243a17fdbc7fe8f9280380ff009b43ff003ff3ff005dff0084bfe4af7c45ff00b86ffe886ae03fe6d0ff00cffcff00d77fe12ff92bdf117fee1bff00a21a800f16ff00c95ef875ff00712ffd10b5c07fcda1ff009ff9ff00aeff00c5bff257be1d7fdc4bff00442d701ff3687fe7fe7fe803bff097fc95ef88bff70dff00d10d4784bfe4af7c45ff00b86ffe886a3c25ff00257be22ffdc37ff44351e12ff92bdf117fee1bff00a21a80380f87ff00f3477fee35ff00b351fb4d7fccadff006f7ffb468f87ff00f3477fee35ff00b351fb4d7fccadff006f7ffb46803cff00c5bff2487e1d7fdc4bff0047ad7a07c40ff9ac5ff705ff00d96bcffc5bff002487e1d7fdc4bff47ad7a07c40ff009ac5ff00705ffd96800f881ff358bfee0bff00b2d79ffc12ff0092bda17fdbc7fe8892bd03e207fcd62ffb82ff00ecb5e7ff0004bfe4af685ff6f1ff00a224a00f7ff825ff00248742ff00b78ffd1f257a0579ff00c12ff9243a17fdbc7fe8f92bd02800a28a2800a28a2800a28a2800a28a2800af00f87fff003477fee35ffb357bfd7807c3ff00f9a3bff71aff00d9a803e7fafa03fe6ef3fcff00cf857cff005f407fcdde7f9ff9f0a003e207fcd62ffb82ff00ecb47ed35ff32b7fdbdffed1a3e207fcd62ffb82ff00ecb47ed35ff32b7fdbdffed1a00eff00c5bff257be1d7fdc4bff00442d701f103fe6b17fdc17ff0065aeff00c5bff257be1d7fdc4bff00442d701f103fe6b17fdc17ff0065a00eff00c25ff257be22ff00dc37ff004435701fb32ffccd3ff6e9ff00b5abbff097fc95ef88bff70dff00d10d5c07eccbff00334ffdba7fed6a003fe6d0ff00cffcff00d1ff003779fe7fe7c28ff9b43ff3ff003ff47fcdde7f9ff9f0a003e207fcd62ffb82ff00ecb5dff8b7fe4af7c3affb897fe885ae03e207fcd62ffb82ff00ecb5dff8b7fe4af7c3affb897fe885a003c5bff257be1d7fdc4bff00442d1f04bfe490e85ff6f1ff00a3e4a3c5bff257be1d7fdc4bff00442d1f04bfe490e85ff6f1ff00a3e4a00e03fe6d0ffcff00cffd77fe12ff0092bdf117fee1bffa21ab80ff009b43ff003ff3ff005dff0084bfe4af7c45ff00b86ffe886a003c5bff00257be1d7fdc4bff442d701ff003687fe7fe7febbff0016ff00c95ef875ff00712ffd10b5c07fcda1ff009ff9ff00a00eff00c25ff257be22ff00dc37ff0044351e12ff0092bdf117fee1bffa21a8f097fc95ef88bff70dff00d10d4784bfe4af7c45ff00b86ffe886a00e03e1fff00cd1dff00b8d7fecd47ed35ff0032b7fdbdff00ed1a3e1fff00cd1dff00b8d7fecd47ed35ff0032b7fdbdff00ed1a00f3ff0016ff00c921f875ff00712ffd1eb5e81f103fe6b17fdc17ff0065af3ff16ffc921f875ff712ff00d1eb5e81f103fe6b17fdc17ff65a003e207fcd62ff00b82ffecb5e7ff04bfe4af685ff006f1ffa224af40f881ff358bfee0bff00b2d79ffc12ff0092bda17fdbc7fe8892803dff00e097fc921d0bfede3ff47c95e815e7ff0004bfe490e85ff6f1ff00a3e4af40a0028a28a0028a28a0028a28a0028a28a002bc03e1ff00fcd1dffb8d7fecd5eff5e01f0fff00e68eff00dc6bff0066a00f9febe80ff9bbcff3ff003e15f3fd7d01ff003779fe7fe7c2800f881ff358bfee0bff00b2d1fb4d7fccadff006f7ffb468f881ff358bfee0bff00b2d1fb4d7fccadff006f7ffb46803bff0016ff00c95ef875ff00712ffd10b5c07c40ff009ac5ff00705ffd96bbff0016ff00c95ef875ff00712ffd10b5c07c40ff009ac5ff00705ffd96803bff00097fc95ef88bff0070dffd10d5c07eccbff334ff00dba7fed6aeff00c25ff257be22ff00dc37ff004435701fb32ffccd3ff6e9ff00b5a800ff009b43ff003ff3ff0047fcdde7f9ff009f0a3fe6d0ff00cffcff00d1ff003779fe7fe7c2800f881ff358bfee0bff00b2d77fe2dff92bdf0ebfee25ff00a216b80f881ff358bfee0bff00b2d77fe2dff92bdf0ebfee25ff00a216800f16ff00c95ef875ff00712ffd10b47c12ff009243a17fdbc7fe8f928f16ff00c95ef875ff00712ffd10b47c12ff009243a17fdbc7fe8f9280380ff9b43ff3ff003ff5dff84bfe4af7c45ffb86ff00e886ae03fe6d0ffcff00cffd77fe12ff0092bdf117fee1bffa21a800f16ffc95ef875ff712ff00d10b5c07fcda1ff9ff009ffaeffc5bff00257be1d7fdc4bff442d701ff003687fe7fe7fe803bff00097fc95ef88bff0070dffd10d4784bfe4af7c45ffb86ff00e886a3c25ff257be22ff00dc37ff0044351e12ff0092bdf117fee1bffa21a80380f87fff003477fee35ffb351fb4d7fccadff6f7ff00b468f87fff003477fee35ffb351fb4d7fccadff6f7ff00b46803cffc5bff002487e1d7fdc4bff47ad7a07c40ff009ac5ff00705ffd96bcff00c5bff2487e1d7fdc4bff0047ad7a07c40ff9ac5ff705ff00d96800f881ff00358bfee0bffb2d79ff00c12ff92bda17fdbc7fe8892bd03e207fcd62ff00b82ffecb5e7ff04bfe4af685ff006f1ffa224a00f7ff00825ff248742ffb78ff00d1f257a0579ffc12ff009243a17fdbc7fe8f92bd02800a28a2800a28a2800a28a2800a28a2800af00f87ff00f3477fee35ff00b357bfd7807c3fff009a3bff0071affd9a803e7fafa03fe6ef3fcffcf857cff5f407fcdde7f9ff009f0a003e207fcd62ff00b82ffecb47ed35ff0032b7fdbdff00ed1a3e207fcd62ff00b82ffecb47ed35ff0032b7fdbdff00ed1a00effc5bff00257be1d7fdc4bff442d701f103fe6b17fdc17ff65aeffc5bff00257be1d7fdc4bff442d701f103fe6b17fdc17ff65a00effc25ff00257be22ffdc37ff4435701fb32ff00ccd3ff006e9ffb5abbff00097fc95ef88bff0070dffd10d5c07eccbff334ff00dba7fed6a003fe6d0ffcff00cffd1ff3779fe7fe7c28ff009b43ff003ff3ff0047fcdde7f9ff009f0a003e207fcd62ff00b82ffecb5dff008b7fe4af7c3aff00b897fe885ae03e207fcd62ff00b82ffecb5dff008b7fe4af7c3aff00b897fe885a003c5bff00257be1d7fdc4bff442d1f04bfe490e85ff006f1ffa3e4a3c5bff00257be1d7fdc4bff442d1f04bfe490e85ff006f1ffa3e4a00e03fe6d0ff00cffcff00d77fe12ff92bdf117fee1bff00a21ab80ff9b43ff3ff003ff5dff84bfe4af7c45ffb86ff00e886a003c5bff257be1d7fdc4bff00442d701ff3687fe7fe7febbff16ffc95ef875ff712ff00d10b5c07fcda1ff9ff009ffa00effc25ff00257be22ffdc37ff44351e12ff92bdf117fee1bff00a21a8f097fc95ef88bff0070dffd10d4784bfe4af7c45ffb86ff00e886a00e03e1ff00fcd1dffb8d7fecd47ed35ff32b7fdbdffed1a3e1ff00fcd1dffb8d7fecd47ed35ff32b7fdbdffed1a00f3ff16ffc921f875ff712ff00d1eb5e81f103fe6b17fdc17ff65af3ff0016ff00c921f875ff00712ffd1eb5e81f103fe6b17fdc17ff0065a003e207fcd62ffb82ff00ecb5e7ff0004bfe4af685ff6f1ff00a224af40f881ff00358bfee0bffb2d79ff00c12ff92bda17fdbc7fe8892803dffe097fc921d0bfede3ff0047c95e815e7ff04bfe490e85ff006f1ffa3e4af40a0028a28a0028a28a0028a28a0028a28a002bc03e1fff00cd1dff00b8d7fecd5eff005e01f0ff00fe68effdc6bff66a00f9febe80ff009bbcff003ff3e15f3fd7d01ff3779fe7fe7c2800f881ff00358bfee0bffb2d1fb4d7fccadff6f7ff00b468f881ff00358bfee0bffb2d1fb4d7fccadff6f7ff00b46803bff16ffc95ef875ff712ff00d10b5c07c40ff9ac5ff705ff00d96bbff16ffc95ef875ff712ff00d10b5c07c40ff9ac5ff705ff00d96803bff097fc95ef88bff70dff00d10d5c07eccbff00334ffdba7fed6aeffc25ff00257be22ffdc37ff4435701fb32ff00ccd3ff006e9ffb5a800ff9b43ff3ff003ff47fcdde7f9ff9f0a3fe6d0ffcff00cffd1ff3779fe7fe7c2800f881ff00358bfee0bffb2d77fe2dff0092bdf0ebfee25ffa216b80f881ff00358bfee0bffb2d77fe2dff0092bdf0ebfee25ffa216800f16ffc95ef875ff712ff00d10b47c12ff9243a17fdbc7fe8f928f16ffc95ef875ff712ff00d10b47c12ff9243a17fdbc7fe8f9280380ff009b43ff003ff3ff005dff0084bfe4af7c45ff00b86ffe886ae03fe6d0ff00cffcff00d77fe12ff92bdf117fee1bff00a21a800f16ff00c95ef875ff00712ffd10b5c07fcda1ff009ff9ff00aeff00c5bff257be1d7fdc4bff00442d701ff3687fe7fe7fe803bff097fc95ef88bff70dff00d10d4784bfe4af7c45ff00b86ffe886a3c25ff00257be22ffdc37ff44351e12ff92bdf117fee1bff00a21a80380f87ff00f3477fee35ff00b351fb4d7fccadff006f7ffb468f87ff00f3477fee35ff00b351fb4d7fccadff006f7ffb46803cff00c5bff2487e1d7fdc4bff0047ad7a07c40ff9ac5ff705ff00d96bcffc5bff002487e1d7fdc4bff47ad7a07c40ff009ac5ff00705ffd96800f881ff358bfee0bff00b2d79ffc12ff0092bda17fdbc7fe8892bd03e207fcd62ffb82ff00ecb5e7ff0004bfe4af685ff6f1ff00a224a00f7ff825ff00248742ff00b78ffd1f257a0579ff00c12ff9243a17fdbc7fe8f92bd02800a28a2800a28a2800a28a2800a28a2800af00f87fff003477fee35ffb357bfd7807c3ff00f9a3bff71aff00d9a803e7fafa03fe6ef3fcff00cf857cff005f407fcdde7f9ff9f0a003e207fcd62ffb82ff00ecb47ed35ff32b7fdbdffed1a3e207fcd62ffb82ff00ecb47ed35ff32b7fdbdffed1a00eff00c5bff257be1d7fdc4bff00442d701f103fe6b17fdc17ff0065aeff00c5bff257be1d7fdc4bff00442d701f103fe6b17fdc17ff0065a00eff00c25ff257be22ff00dc37ff004435701fb32ffccd3ff6e9ff00b5abbff097fc95ef88bff70dff00d10d5c07eccbff00334ffdba7fed6a003fe6d0ff00cffcff00d1ff003779fe7fe7c28ff9b43ff3ff003ff47fcdde7f9ff9f0a003e207fcd62ffb82ff00ecb5dff8b7fe4af7c3affb897fe885ae03e207fcd62ffb82ff00ecb5dff8b7fe4af7c3affb897fe885a003c5bff257be1d7fdc4bff00442d1f04bfe490e85ff6f1ff00a3e4a3c5bff257be1d7fdc4bff00442d1f04bfe490e85ff6f1ff00a3e4a00e03fe6d0ffcff00cffd77fe12ff0092bdf117fee1bffa21ab80ff009b43ff003ff3ff005dff0084bfe4af7c45ff00b86ffe886a003c5bff00257be1d7fdc4bff442d701ff003687fe7fe7febbff0016ff00c95ef875ff00712ffd10b5c07fcda1ff009ff9ff00a00eff00c25ff257be22ff00dc37ff0044351e12ff0092bdf117fee1bffa21a8f097fc95ef88bff70dff00d10d4784bfe4af7c45ff00b86ffe886a00e03e1fff00cd1dff00b8d7fecd47ed35ff0032b7fdbdff00ed1a3e1fff00cd1dff00b8d7fecd47ed35ff0032b7fdbdff00ed1a00f3ff0016ff00c921f875ff00712ffd1eb5e81f103fe6b17fdc17ff0065af3ff16ffc921f875ff712ff00d1eb5e81f103fe6b17fdc17ff65a003e207fcd62ff00b82ffecb5e7ff04bfe4af685ff006f1ffa224af40f881ff358bfee0bff00b2d79ffc12ff0092bda17fdbc7fe8892803dff00e097fc921d0bfede3ff47c95e815e7ff0004bfe490e85ff6f1ff00a3e4af40a0028a28a0028a28a0028a28a0028a28a002bc03e1ff00fcd1dffb8d7fecd5eff5e01f0fff00e68eff00dc6bff0066a00f9febe80ff9bbcff3ff003e15f3fd7d01ff003779fe7fe7c2800f881ff358bfee0bff00b2d1fb4d7fccadff006f7ffb468f881ff358bfee0bff00b2d1fb4d7fccadff006f7ffb46803bff0016ff00c95ef875ff00712ffd10b5c07c40ff009ac5ff00705ffd96bbff0016ff00c95ef875ff00712ffd10b5c07c40ff009ac5ff00705ffd96803bff00097fc95ef88bff0070dffd10d5c07eccbff334ff00dba7fed6aeff00c25ff257be22ff00dc37ff004435701fb32ffccd3ff6e9ff00b5a800ff009b43ff003ff3ff0047fcdde7f9ff009f0a3fe6d0ff00cffcff00d1ff003779fe7fe7c2800f881ff358bfee0bff00b2d77fe2dff92bdf0ebfee25ff00a216b80f881ff358bfee0bff00b2d77fe2dff92bdf0ebfee25ff00a216800f16ff00c95ef875ff00712ffd10b47c12ff009243a17fdbc7fe8f928f16ff00c95ef875ff00712ffd10b47c12ff009243a17fdbc7fe8f9280380ff9b43ff3ff003ff5dff84bfe4af7c45ffb86ff00e886ae03fe6d0ffcff00cffd77fe12ff0092bdf117fee1bffa21a800f16ffc95ef875ff712ff00d10b5c07fcda1ff9ff009ffaeffc5bff00257be1d7fdc4bff442d701ff003687fe7fe7fe803bff00097fc95ef88bff0070dffd10d4784bfe4af7c45ffb86ff00e886a3c25ff257be22ff00dc37ff0044351e12ff0092bdf117fee1bffa21a80380f87fff003477fee35ffb351fb4d7fccadff6f7ff00b468f87fff003477fee35ffb351fb4d7fccadff6f7ff00b46803cffc5bff002487e1d7fdc4bff47ad7a07c40ff009ac5ff00705ffd96bcff00c5bff2487e1d7fdc4bff0047ad7a07c40ff9ac5ff705ff00d96800f881ff00358bfee0bffb2d79ff00c12ff92bda17fdbc7fe8892bd03e207fcd62ff00b82ffecb5e7ff04bfe4af685ff006f1ffa224a00f7ff00825ff248742ffb78ff00d1f257a0579ffc12ff009243a17fdbc7fe8f92bd02800a28a2800a28a2800a28a2800a28a2800af10f03e85ac5a7fc2a9fb4e957d0fd87fb5fed7e65bbafd9f7eed9bf23e5dddb38cf6af6fa2803e20ff8413c61ff0042a6b9ff0082e9bff89af70fec2d63fe1a97fb5ffb2afbfb33fe7f7ecefe4ffc796dfbf8dbf7b8ebd78af6fa2803c43c71a16b177ff0b5becda55f4df6efec8fb27976eedf68d9b77ecc0f9b6f7c671de8fda1f42d635bff00846ffb274abebff27ed3e67d92dde5d99f2b19da0e3383d7d0d7b7d1401c3f89ec2f2e3e29780af21b49e4b5b5fed0fb44c9192916e8142ee61c2e4f033d6b88f1c685ac5dff00c2d6fb36957d37dbbfb23ec9e5dbbb7da366ddfb303e6dbdf19c77af6fa280387f0c585e5bfc52f1ede4d693c76b75fd9ff6799e32125db0306dac786c1e0e3a5711fb3c685ac689ff000927f6b6957d61e77d9bcbfb5dbbc5bf1e6e71b80ce323a7a8af6fa2803c43fb0b58ff00865afec8fecabefed3ff009f2fb3bf9dff001fbbbee6377dde7a74e68fec2d63fe1a97fb5ffb2afbfb33fe7f7ecefe4ffc796dfbf8dbf7b8ebd78af6fa2803c43c71a16b177ff0b5becda55f4df6efec8fb27976eedf68d9b77ecc0f9b6f7c671debb7f13d85e5c7c52f015e43693c96b6bfda1f6899232522dd0285dcc385c9e067ad771450070fe27b0bcb8f8a5e02bc86d2792d6d7fb43ed132464a45ba050bb9870b93c0cf5a3e10585e699f0b746b3bfb49ed2ea3f3f7c33c66375ccf211953c8c820fe35dc51401e21fd85ac7fc32d7f647f655f7f69ff00cf97d9dfceff008fdddf731bbeef3d3a735dbf862c2f2dfe2978f6f26b49e3b5bafecffb3ccf19092ed81836d63c360f071d2bb8a280387f13d85e5c7c52f015e43693c96b6bfda1f6899232522dd0285dcc385c9e067ad711fd85ac7fc32d7f647f655f7f69ff00cf97d9dfceff008fdddf731bbeef3d3a735edf450070fe18b0bcb7f8a5e3dbc9ad278ed6ebfb3fecf33c6424bb6060db58f0d83c1c74a3c3161796ff0014bc7b7935a4f1dadd7f67fd9e678c84976c0c1b6b1e1b07838e95dc51401e21e07d0b58b4ff008553f69d2afa1fb0ff006bfdafccb775fb3efddb37e47cbbbb6719ed47ed0fa16b1adffc237fd93a55f5ff0093f69f33ec96ef2eccf958ced0719c1ebe86bdbe8a00f963c4fe13f125c7c2df0159c3e1fd564bab5fed0fb4429652178b74ea57728195c8e467ad771e38d0b58bbff85adf66d2afa6fb77f647d93cbb776fb46cdbbf6607cdb7be338ef5edf450078878e342d62eff00e16b7d9b4abe9beddfd91f64f2edddbed1b36efd981f36def8ce3bd70ff083c27e24d33e2968d797fe1fd56d2d63f3f7cd3d9491a2e60900cb11819240fc6bea7a280387f8416179a67c2dd1acefed27b4ba8fcfdf0cf198dd733c84654f232083f8d771451400514514005145140051451400514514005145140051451400514514005145140051451400514514005145140051451400514514005145140051451400514514005145140051451400514514005145140051451401ffd9);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `ID` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `role` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`ID`, `name`, `username`, `password`, `role`) VALUES
(1, 'ADMIN', 'admin', '12345', 'ADMIN'),
(5, 'cashier1', 'cashier', '12345', 'CASHIER');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_discount`
--
ALTER TABLE `tbl_discount`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_group`
--
ALTER TABLE `tbl_group`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_pos`
--
ALTER TABLE `tbl_pos`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_products`
--
ALTER TABLE `tbl_products`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_discount`
--
ALTER TABLE `tbl_discount`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `tbl_group`
--
ALTER TABLE `tbl_group`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tbl_pos`
--
ALTER TABLE `tbl_pos`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `tbl_products`
--
ALTER TABLE `tbl_products`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;