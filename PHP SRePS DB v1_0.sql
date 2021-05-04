-- PHP SRePS
-- Database version 1.0
-- Andy King
-- 05/05/2021 0930

-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 05, 2021 at 09:29 AM
-- Server version: 10.2.37-MariaDB
-- PHP Version: 7.3.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `wcweb_andy_mitp`
--

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
(1, 'Tissues (3 ply, 224 sheets)', 1.99),
(2, 'Sensodyne Sensitive Teeth Pain Repair & Protect Whitening Toothpaste 100g', 10.75);

-- --------------------------------------------------------

--
-- Table structure for table `sales_table`
--

CREATE TABLE `sales_table` (
  `Order_Number` int(10) NOT NULL,
  `Product_ID` int(6) NOT NULL,
  `Datetime` datetime(6) NOT NULL,
  `Quantity` int(4) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sales_table`
--

INSERT INTO `sales_table` (`Order_Number`, `Product_ID`, `Datetime`, `Quantity`) VALUES
(1, 1, '2021-05-03 16:11:19.000000', 2),
(1, 2, '2021-05-03 16:11:19.000000', 1),
(2, 1, '2021-05-03 16:16:09.000000', 5),
(4, 9, '2021-05-03 16:22:34.000000', 9);

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
  MODIFY `Product_ID` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `sales_table`
--
ALTER TABLE `sales_table`
  MODIFY `Order_Number` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
