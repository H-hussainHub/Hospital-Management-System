-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 22, 2020 at 03:46 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hospmansys`
--

-- --------------------------------------------------------

--
-- Table structure for table `appointment`
--

CREATE TABLE `appointment` (
  `ID` int(11) NOT NULL,
  `PatientID` int(11) NOT NULL,
  `Time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `id` int(11) NOT NULL,
  `name` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`id`, `name`) VALUES
(1, 'Consultant_clerk'),
(2, 'Financial_clerk'),
(3, 'Appointment_manager'),
(4, 'Senior_management'),
(5, 'Administrator');

-- --------------------------------------------------------

--
-- Table structure for table `insurance`
--

CREATE TABLE `insurance` (
  `ID` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `Name` varchar(255) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `PhoneNumber` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `insurance`
--

INSERT INTO `insurance` (`ID`, `user_id`, `Name`, `Email`, `PhoneNumber`) VALUES
(2, 4, 'PoorPeopleInsurance', 'PPI@PoorPeopleInsurance.com', '111');

-- --------------------------------------------------------

--
-- Table structure for table `patient`
--

CREATE TABLE `patient` (
  `NHS_Number` int(11) NOT NULL,
  `user_id` int(11) DEFAULT NULL,
  `InsuranceID` int(10) DEFAULT NULL,
  `name` varchar(255) NOT NULL,
  `DateOfBirth` date NOT NULL,
  `email` varchar(255) NOT NULL,
  `phonenumber` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `patient_referral`
--

CREATE TABLE `patient_referral` (
  `NHS_Number` int(11) NOT NULL,
  `referral_id` int(11) NOT NULL,
  `approved` tinyint(1) NOT NULL,
  `DateOfApproval` date NOT NULL,
  `Invoiced` tinyint(1) NOT NULL DEFAULT 0,
  `Paid` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `referral`
--

CREATE TABLE `referral` (
  `ID` int(11) NOT NULL,
  `NHS_NUMBER` int(11) NOT NULL,
  `Name` varchar(55) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Age` int(11) NOT NULL,
  `DateOfBirth` date NOT NULL,
  `PhoneNumber` varchar(20) NOT NULL,
  `DateOfReferral` date NOT NULL,
  `GP` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `referral`
--

INSERT INTO `referral` (`ID`, `NHS_NUMBER`, `Name`, `Email`, `Age`, `DateOfBirth`, `PhoneNumber`, `DateOfReferral`, `GP`) VALUES
(1, 0, 'Myles May', 'Myles2317@gmail.com', 24, '1996-04-02', '999', '2020-04-18', 'John Winston'),
(2, 12342, 'Fred Flinstone', 'FF@gmail.com', 20, '2000-01-02', '123469540', '2020-04-18', 'JFK'),
(4, 2317, 'Make Me Cry', 'MMC.com', 0, '2020-04-19', '07900584120', '2020-04-19', 'DR. Birth Giver');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `department_id` int(11) NOT NULL,
  `name` varchar(55) NOT NULL,
  `email` varchar(255) NOT NULL,
  `phonenumber` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`id`, `user_id`, `department_id`, `name`, `email`, `phonenumber`) VALUES
(2, 2, 3, 'Myles May', 'Myles2317@gmail.com', '07854642482'),
(3, 3, 4, 'Bob Ross', 'BobRoss@BRIndustries.com', '999'),
(4, 2, 1, 'Myles May', 'Myles2317@gmail.com', '07854642482'),
(5, 2, 2, 'Myles May', 'Myles2317@gmail.com', '07854642482'),
(6, 2, 4, 'Myles May', 'Myles2317@gmail.com', '07854642482'),
(7, 2, 5, 'Myles May', 'Myles2317@gmail.com', '07854642482');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `ID` int(11) NOT NULL,
  `username` varchar(55) NOT NULL,
  `password` varchar(55) NOT NULL,
  `role` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`ID`, `username`, `password`, `role`) VALUES
(0, '', '123', 2),
(2, 'mylesmay', '123', 2),
(3, 'BobRoss', 'br123', 2),
(4, 'PoorPeopleInsurance', 'ppi', 3);

-- --------------------------------------------------------

--
-- Table structure for table `user_role`
--

CREATE TABLE `user_role` (
  `ID` int(11) NOT NULL,
  `role` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user_role`
--

INSERT INTO `user_role` (`ID`, `role`) VALUES
(1, 'patient'),
(2, 'staff'),
(3, 'insurance');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `appointment`
--
ALTER TABLE `appointment`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `PatientID` (`PatientID`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `insurance`
--
ALTER TABLE `insurance`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`NHS_Number`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `InsuranceID` (`InsuranceID`);

--
-- Indexes for table `patient_referral`
--
ALTER TABLE `patient_referral`
  ADD PRIMARY KEY (`NHS_Number`,`referral_id`),
  ADD KEY `patient_id` (`NHS_Number`),
  ADD KEY `refferal_id` (`referral_id`);

--
-- Indexes for table `referral`
--
ALTER TABLE `referral`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `NHS_NUMBER` (`NHS_NUMBER`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_id` (`user_id`),
  ADD KEY `department_id` (`department_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `type` (`role`);

--
-- Indexes for table `user_role`
--
ALTER TABLE `user_role`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `insurance`
--
ALTER TABLE `insurance`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `referral`
--
ALTER TABLE `referral`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `staff`
--
ALTER TABLE `staff`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `insurance`
--
ALTER TABLE `insurance`
  ADD CONSTRAINT `insurance_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `user` (`ID`);

--
-- Constraints for table `patient`
--
ALTER TABLE `patient`
  ADD CONSTRAINT `patient_ibfk_2` FOREIGN KEY (`InsuranceID`) REFERENCES `insurance` (`ID`),
  ADD CONSTRAINT `patient_ibfk_3` FOREIGN KEY (`user_id`) REFERENCES `user` (`ID`);

--
-- Constraints for table `patient_referral`
--
ALTER TABLE `patient_referral`
  ADD CONSTRAINT `patient_referral_ibfk_2` FOREIGN KEY (`NHS_Number`) REFERENCES `patient` (`NHS_Number`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `patient_referral_ibfk_3` FOREIGN KEY (`referral_id`) REFERENCES `referral` (`ID`);

--
-- Constraints for table `staff`
--
ALTER TABLE `staff`
  ADD CONSTRAINT `staff_ibfk_2` FOREIGN KEY (`department_id`) REFERENCES `department` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `staff_ibfk_3` FOREIGN KEY (`user_id`) REFERENCES `user` (`ID`);

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_ibfk_1` FOREIGN KEY (`role`) REFERENCES `user_role` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
