-- phpMyAdmin SQL Dump
-- version 4.7.1
-- https://www.phpmyadmin.net/
--
-- Host: sql6.freemysqlhosting.net
-- Generation Time: May 18, 2021 at 10:42 PM
-- Server version: 5.5.62-0ubuntu0.14.04.1
-- PHP Version: 7.0.33-0ubuntu0.16.04.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sql6410796`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`sql6410796`@`%` PROCEDURE `AddEditSale` (IN `p_Order_Number` INT(10), IN `p_Product_ID` INT(6), IN `p_Datetime` DATETIME, IN `p_Quantity` INT(4))  NO SQL
IF EXISTS(SELECT * FROM sales_table WHERE Order_Number = p_Order_Number AND Product_ID = p_Product_ID)
  THEN

  UPDATE
    sales_table
  SET
    Datetime = p_Datetime,
    Quantity = p_Quantity
  WHERE
    Order_Number = p_Order_Number
    AND Product_ID = p_Product_ID;
  
  ELSE
    INSERT INTO
      sales_table(Order_Number, Product_ID, Datetime, Quantity)
    VALUES
      (
        p_Order_Number,
        p_Product_ID,
        p_Datetime,
        p_Quantity
      );
END IF$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `products_table`
--

CREATE TABLE `products_table` (
  `Product_ID` int(6) NOT NULL,
  `Product_Name` text NOT NULL,
  `Cost` decimal(5,2) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `products_table`
--

INSERT INTO `products_table` (`Product_ID`, `Product_Name`, `Cost`) VALUES
(1, 'Tissues', '0.99'),
(2, 'Sensodyne', '9.75'),
(3, 'Sunscreen', '4.95');

-- --------------------------------------------------------

--
-- Table structure for table `sales_table`
--

CREATE TABLE `sales_table` (
  `Order_Number` int(10) NOT NULL,
  `Product_ID` int(6) NOT NULL,
  `Datetime` datetime NOT NULL,
  `Quantity` int(4) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sales_table`
--

INSERT INTO `sales_table` (`Order_Number`, `Product_ID`, `Datetime`, `Quantity`) VALUES
(1, 1, '2021-05-03 16:11:19', 2),
(1, 2, '2021-05-03 16:11:19', 1),
(2, 1, '2021-05-03 16:16:09', 5),
(3, 2, '2021-05-03 16:22:34', 4),
(5, 1, '0000-00-00 00:00:00', 1),
(6, 1, '0000-00-00 00:00:00', 10000),
(7, 1, '2021-05-11 03:24:30', 1),
(8, 1, '2021-05-11 09:19:29', 1),
(9, 1, '2021-05-11 10:10:47', 2),
(10, 1, '2021-05-11 13:02:30', 1),
(11, 1, '2021-05-11 13:02:31', 1),
(12, 1, '2021-05-12 04:52:13', 300),
(13, 1, '2021-05-21 13:02:00', 1),
(14, 1, '0001-01-01 00:00:00', 5),
(15, 1, '0000-00-00 00:00:00', 5),
(16, 1, '0001-01-01 00:00:00', 5),
(17, 0, '0000-00-00 00:00:00', 5),
(18, 2, '0000-00-00 00:00:00', 3),
(18, 1, '0000-00-00 00:00:00', 3),
(19, 2, '0000-00-00 00:00:00', 52),
(19, 1, '0000-00-00 00:00:00', 52),
(20, 1, '2021-05-12 12:16:59', 500),
(21, 2, '0000-00-00 00:00:00', 10),
(21, 1, '0000-00-00 00:00:00', 10),
(21, 3, '0000-00-00 00:00:00', 10),
(22, 2, '0000-00-00 00:00:00', 900),
(23, 1, '0000-00-00 00:00:00', 15),
(100, 0, '2021-05-12 04:34:02', 0),
(23, 3, '0000-00-00 00:00:00', 15),
(101, 0, '2021-05-12 04:34:02', 0),
(25, 2, '0000-00-00 00:00:00', 456),
(102, 3, '0000-00-00 00:00:00', 9),
(102, 2, '0000-00-00 00:00:00', 9),
(102, 1, '0000-00-00 00:00:00', 9),
(103, 2, '0000-00-00 00:00:00', 5),
(104, 2, '0001-01-01 00:00:00', 520),
(104, 45, '0001-01-01 00:00:00', 520),
(105, 2, '0000-00-00 00:00:00', 5),
(106, 3, '2021-05-12 04:53:00', 400),
(106, 2, '0000-00-00 00:00:00', 400),
(106, 1, '2021-05-12 04:55:20', 34),
(50, 2, '2021-05-12 04:55:54', 25),
(107, 2, '0000-00-00 00:00:00', 5),
(107, 1, '0001-01-01 00:00:00', 10),
(50, 1, '0001-01-01 00:00:00', 10),
(50, 3, '0001-01-01 00:00:00', 50),
(5, 3, '0001-01-01 00:00:00', 50),
(108, 1, '0001-01-01 00:00:00', 508),
(109, 2, '0000-00-00 00:00:00', 8),
(110, 2, '0000-00-00 00:00:00', 89),
(111, 2, '0000-00-00 00:00:00', 54),
(112, 2, '2021-05-12 05:53:28', 7000),
(113, 2, '2021-05-12 06:44:10', 104),
(113, 1, '2021-05-12 06:44:10', 6),
(113, 3, '2021-05-12 06:44:10', 500),
(114, 1, '2021-05-13 10:20:04', 3),
(114, 3, '2021-05-13 10:20:04', 5),
(115, 1, '2021-05-14 04:18:38', 5),
(116, 1, '2021-05-14 04:19:00', 20),
(116, 2, '2021-05-14 04:19:00', 15),
(117, 1, '2021-05-14 04:19:56', 35),
(117, 2, '2021-05-14 04:19:57', 15),
(117, 3, '2021-05-14 04:19:57', 20),
(117, 5, '2021-05-14 04:19:57', 1500),
(118, 1, '2021-05-14 07:14:16', 2),
(119, 1, '2021-05-14 07:14:46', 2),
(119, 3, '2021-05-14 07:14:46', 1),
(120, 1, '2021-05-14 07:15:15', 2),
(120, 3, '2021-05-14 07:15:15', 1),
(120, 2, '2021-05-14 07:15:15', 2),
(121, 2, '2021-05-14 07:37:40', 6000),
(122, 1, '2021-05-14 07:45:18', 2),
(123, 1, '2021-05-14 07:52:48', 1),
(124, 1, '2021-05-17 03:41:03', 1),
(125, 1, '2021-05-17 03:41:38', 1),
(125, 0, '2021-05-17 03:41:38', 1),
(125, 2, '2021-05-17 03:41:38', 1),
(126, 1, '2021-05-17 06:28:03', 7),
(127, 1, '2021-05-17 07:05:29', 20),
(128, 1, '2021-05-17 07:05:39', 35),
(129, 2, '2021-05-18 22:21:12', 5),
(129, 1, '2021-05-18 22:21:13', 10),
(129, 3, '2021-05-18 22:21:13', 5);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `products_table`
--
ALTER TABLE `products_table`
  ADD PRIMARY KEY (`Product_ID`);

--
-- Indexes for table `sales_table`
--
ALTER TABLE `sales_table`
  ADD PRIMARY KEY (`Order_Number`,`Product_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `products_table`
--
ALTER TABLE `products_table`
  MODIFY `Product_ID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `sales_table`
--
ALTER TABLE `sales_table`
  MODIFY `Order_Number` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=130;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
