-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: studmysql01.fhict.local
-- Generation Time: 28 юни 2018 в 02:19
-- Версия на сървъра: 5.7.13-log
-- PHP Version: 5.6.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbi378522`
--

-- --------------------------------------------------------

--
-- Структура на таблица `alert`
--

CREATE TABLE `alert` (
  `Id` int(11) NOT NULL,
  `Alert` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `alert`
--

INSERT INTO `alert` (`Id`, `Alert`) VALUES
(4, '1');

-- --------------------------------------------------------

--
-- Структура на таблица `changesite`
--

CREATE TABLE `changesite` (
  `AboutText` text,
  `VideoURL` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `changesite`
--

INSERT INTO `changesite` (`AboutText`, `VideoURL`) VALUES
('test testtesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttesttest', 'https://www.youtube.com/embed/5CzbQUCs8sc');

-- --------------------------------------------------------

--
-- Структура на таблица `customer`
--

CREATE TABLE `customer` (
  `CustomerId` int(11) NOT NULL,
  `FirstName` varchar(123) NOT NULL,
  `LastName` varchar(123) NOT NULL,
  `Password` varchar(123) NOT NULL,
  `Email` varchar(123) DEFAULT NULL,
  `Age` int(123) DEFAULT NULL,
  `Balance` int(11) NOT NULL,
  `TicketNumber` varchar(20) NOT NULL,
  `Status` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `customer`
--

INSERT INTO `customer` (`CustomerId`, `FirstName`, `LastName`, `Password`, `Email`, `Age`, `Balance`, `TicketNumber`, `Status`) VALUES
(9, 'Dimitar', '', 'fdgfd', 'dimitarpetrov.02.98@gmail.com', NULL, 728, '2800b82096', 0),
(10, 'Dimitar', '', '1', 'dimitarpetrov.02.98@gmail.com', NULL, 850, '0', NULL),
(11, 'Dimitar', '', '2', 'dimitarpetrov.02.98@gmail.com', NULL, 850, '0', NULL),
(12, 'Dimitar', '', '222', 'dimitarpetrov.02.98@gmail.com', NULL, 850, '0', NULL),
(13, 'dasd', '', 'asdad', 'dasd', NULL, 20, '0', NULL),
(19, 'admin', 'admin', 'admin', 'admin', 1, 0, '4a0036e2fe', NULL),
(27, 'Dimitar', 'Petrov', '2', 'dimitarpetrov.02.98@gmail.com', -23, 850, '13', NULL),
(28, 'Dimitar', 'Petrov', '22', 'dimitarpetrov.02.98@gmail.com', 22, 850, '13', NULL),
(29, 'Ivan', 'Ivan', 'Ivan', 'Ivan', 22, 550, '13', NULL),
(30, 'Martin', 'Martin', 'Martin', 'Martin', 2, 50, '13', NULL),
(31, 'Dimitar', 'Petrov', '34342423', 'dimitarpetrov.02.98@gmail.com', 234423, 850, '13', NULL),
(32, 'Dimitar', 'Petrov', '22', 'dimitarpetrov.02.98@gmail.com', 22, 850, '13', NULL),
(33, 'Dimitar', 'Petrov', '22', 'dimitarpetrov.02.98@gmail.com', 22, 850, '13', NULL),
(34, 'Dimitar', 'Petrov', '22', 'dimitarpetrov.02.98@gmail.com2', 2, 0, '13', NULL),
(35, 'Dimitar', 'Petrov', '4234', 'dimitarpetrov.02.98@gmail.com4342323', 4234, 0, '13', NULL),
(37, 'Dimitar', 'Petrov', '231', 'dimitarpetrov.02.98@gmail.com434232334', 4234, 0, '13', NULL),
(38, 'Dimitar', 'Petrov', '3123', 'dimitarpetrov.02.98@gmail.com4342323345', 4234, 0, '13', NULL),
(39, 'Dimitar', 'Petrov', '4', 'dimitarpetrov.02.98@gmail.com43423233454', 4234, 0, '13', NULL),
(40, 'Dimitar', 'Petrov', '4', 'dimitarpetrov.02.98@gmail.com434232334544', 4234, 0, '13', NULL),
(41, 'Dimitar', 'Petrov', '32213', 'dimitar', 4234, 0, '13', NULL),
(42, 'Dimitar', 'Petrov', '4234', 'dimitar44', 4234, 0, '13', NULL),
(43, 'Dimitar', 'Petrov', '123', 'test1', 123, 0, '13', NULL),
(44, 'Dimitar2', 'Petrov', '3', 'test12', 123, 0, '13', NULL),
(45, 'Dimitar23', 'Petrov', '323', 'test123', 123, 0, '13', NULL),
(46, 'Dimitar23', 'Petrov', '32', 'test123455', 123, 0, '13', NULL),
(47, 'Dimitar235', 'Petrov', '5', 'test1234555', 123, 0, '13', NULL),
(48, 'Dimitar235', 'Petrov', '5', 'test12345555', 123, 0, '13', NULL),
(49, 'Dimitar2354', 'Petrov', '432', 'test123455555', 123, 0, '13', NULL),
(50, 'Dimitar23544', 'Petrov', '55', 'test1234555554', 123, 0, '13', NULL),
(51, 'Dimitar23544', 'Petrov', '4', 'test12345555545', 123, 0, '13', NULL),
(52, 'Dimitar23544', 'Petrov', '4', 'test123455555454', 123, 0, '13', NULL),
(53, 'Dimitar23544', 'Petrov', '423', 'test1234555554544', 123, 0, '13', NULL),
(54, 'Dimitar23544', 'Petrov', '4', 'test12345555545444', 123, 0, '13', NULL),
(55, 'Dimitar23544', 'Petrov', '44', 'test123455555454444', 123, 0, '13', NULL),
(56, 'Dimitar23544', 'Petrov', '423', 'test1234555554544444234', 123, 0, '13', NULL),
(57, 'Ivan', 'Petrov', '123', 'test333', 1234, 0, '13', NULL),
(58, 'Dimitar', 'Petrov', '123', 'FinalTestPhpMyadming', 213, 0, '13', NULL),
(59, '42342', '423423', '4234234234', '423423423424', 42342, 0, '13', NULL),
(60, '423424234432', '423424', '242342345', '423423443436366', 645654, 0, '13', NULL),
(61, 'efwerfwefwe', 'fwefwefwe', 'ffwefwf', 'ffwefwefe', 32, 0, '13', NULL),
(62, '423424234', 'fsdf', 'dasd', 'adsd', 23, 0, '13', NULL),
(63, 'Dimitar', 'Petrov', '33', 'dimitarpetrov.02.98@gmail.com5555555555555555555555555', 234, 0, '13', NULL),
(64, 'Dimitar', 'Petrov', '123', '12345678', 2, 0, '13', NULL),
(65, 'Dimitar', 'Petrov', '3123', 'dimitarpetrov.02.98@gmail.com43443', 23, 0, '13', NULL),
(66, 'Dimitar', 'Petrov', '999', '99999999999999', 99, 0, '13', NULL),
(67, 'Dimitar', 'Petrov', '123', 'dimitarpetrov.02.98@gmail.com124243534', 23, 0, '13', NULL),
(68, 'Dimitar', 'Petrov', '123123', 'dimitarpetrov.02.98@gmail.com123213123213122313', 12313, 0, '13', NULL),
(69, 'Dimitar', 'Petrov', '22', 'dimitarpetrov.02.98@gmail.com22222222222222', 23, 0, '13', NULL),
(70, 'Dimitar', 'Petrov', '4243', 'dimitarpetrov.02.98@gmail.com122353532', 123, 0, '13', NULL),
(71, 'Dimitar', 'Petrov', '2342', 'dimitarpetrov.02.98@gmail.com432534535', 22, 0, '13', NULL),
(72, 'Dimitar', 'Petrov', '4234', 'dimitarpetrov.02.98@gmail.com4dsad', 243, 0, '13', NULL),
(73, 'Dimitar', 'Petrov', '2324', 'dimitarpetrov.02.98@gmail.comждргдрг', 4234, 0, '13', NULL),
(74, 'Dimitar', 'Petrov', '123', 'dimitarpetrov.02.98@gmail.com4234234423', 23, 20, '13', NULL),
(75, 'test', '11', '11', 'testpresident', 11, 0, '13', NULL),
(76, 'Dimitar', 'Petrov', '23', 'dimitarpetrov.02.98@gmail.com32423432', 23, 0, '13', NULL),
(77, 'Ivan', 'Ivan', '123', 'Ivan123', 22, 0, '13', NULL),
(78, 'Dimitar', 'Petrov', '123231', 'dimitarpetrov.02.98@gmail.com123231', 213, 0, '13', NULL),
(79, 'Dimitar', 'Petrov', '23', 'dimitarpetrov.02.98@gmail.comerwqewqeqwew', 23, 0, '13', NULL),
(80, 'Kaloyan', 'Dragiev', '123', 'Kaloyan@gmail.com', 20, 50, '13', NULL),
(81, 'Yanis', 'Yanis', '123', 'Yanis', 12, 150, '13', NULL),
(82, 'Carl', 'Doe', '123', 'Carl_doe@gmai.com', 20, 170, '13', NULL),
(83, 'Peter', 'Petrov', '123', 'Peter@abv.bg', 12, 0, '13', NULL),
(84, 'Peter', 'Petrov', '123', 'PEretre', 13, 0, '13', NULL),
(85, 'Dimitar', 'Petrov', '213', 'dimitarpetrov.02.98@gmail.comddd', 12, 0, '13', NULL),
(86, 'Dimitar', 'Petrov', '1234', 'dimitarpetrov.02.98@gmail.com44444444444', 12, 0, '13', NULL),
(87, 'Dimitar', 'Petrov', '123', 'ddpetrov@abv.bg', 14, 0, '13', NULL),
(88, 'FinalTest', 'Test', '123', 'Test@com', 12, 0, '13', NULL),
(89, 'Frank', 'de Lepper', 'frank', 'f.delepper@fontys.nl', 58, 60, '13', NULL),
(90, 'Dimitar', 'Petrov', '123', 'dimitarpetrov.02.98@gmail.com1231234455', 14, 0, '13', NULL),
(91, 'Dimitar', 'Petrov', '123', 'dimitarpetrov.02.98@gmail.com555555555555555555', 12, 0, '13', NULL),
(92, 'Dimitar', 'Petrov', '123', 'dimitarpetrov.02.98@gmail.com555555555', 15, 0, '13', NULL),
(93, 'Dimitar', 'Petrov', '123', 'dimitarpetrov.02.98@gmail.com12312344', 12, 110, '13', NULL),
(94, 'Dimitar', 'Petrov', '123', 'dimitarpetrov.02.98@gmail.com88888', 14, 50, '13', NULL),
(95, 'Dimitar', 'Petrov', '123', 'dimitarpetrov.02.98@gmail.com777777', 17, 0, '13', NULL),
(96, 'Peter', 'Peterson', '123', 'PeterPeterson@gmial.com', 18, 0, '13', NULL),
(97, 'Peter', 'Peterson', '123', 'ptr@test.gmasil.com', 15, 0, '13', NULL),
(98, 'Dimitar', 'Petrov', '123', 'dimitarpetrov.02.98@gmail.comtest123', 19, 0, '13', NULL),
(99, 'kaloyan', 'dragiev', '12345', 'kaloyansadf@gmail.com', 19, 20, '13', NULL);

-- --------------------------------------------------------

--
-- Структура на таблица `employee`
--

CREATE TABLE `employee` (
  `EmployeeId` int(11) NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `employee`
--

INSERT INTO `employee` (`EmployeeId`, `Name`, `Password`) VALUES
(1, 'Artem', '12345'),
(2, 'admin', 'admin');

-- --------------------------------------------------------

--
-- Структура на таблица `extrabed`
--

CREATE TABLE `extrabed` (
  `CustomerId` int(11) NOT NULL,
  `RoomNumber` int(11) NOT NULL,
  `start` date DEFAULT NULL,
  `end` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `extrabed`
--

INSERT INTO `extrabed` (`CustomerId`, `RoomNumber`, `start`, `end`) VALUES
(27, 13, NULL, NULL),
(28, 22, NULL, NULL),
(29, 21, NULL, NULL),
(29, 22, NULL, NULL),
(44, 14, NULL, NULL),
(47, 14, NULL, NULL),
(55, 14, NULL, NULL),
(66, 5, NULL, NULL),
(66, 10, NULL, NULL),
(67, 9, NULL, NULL),
(67, 21, NULL, NULL),
(69, 11, NULL, NULL),
(72, 8, NULL, NULL),
(72, 30, NULL, NULL),
(73, 7, NULL, NULL),
(74, 15, NULL, NULL),
(75, 14, NULL, NULL),
(76, 13, NULL, NULL),
(77, 22, NULL, NULL),
(77, 24, NULL, NULL),
(77, 27, NULL, NULL),
(78, 12, NULL, NULL),
(78, 27, NULL, NULL),
(80, 21, NULL, NULL),
(81, 5, NULL, NULL),
(82, 24, NULL, NULL),
(87, 23, NULL, NULL),
(88, 30, NULL, NULL),
(91, 25, NULL, NULL),
(94, 27, NULL, NULL),
(95, 30, NULL, NULL),
(96, 29, NULL, NULL),
(97, 28, NULL, NULL),
(98, 26, NULL, NULL);

-- --------------------------------------------------------

--
-- Структура на таблица `loan`
--

CREATE TABLE `loan` (
  `LoanId` int(11) NOT NULL,
  `Date` datetime NOT NULL,
  `TransactionId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `loan`
--

INSERT INTO `loan` (`LoanId`, `Date`, `TransactionId`) VALUES
(1, '2018-06-11 00:00:00', 42),
(2, '2018-06-24 00:00:00', 110),
(3, '2018-06-24 17:27:17', 121),
(1, '2018-06-24 23:55:42', 140),
(3, '2018-06-24 23:58:03', 142),
(1, '2018-06-24 23:58:49', 143),
(2, '2018-06-25 00:09:36', 154),
(1, '2018-06-25 00:11:53', 155),
(1, '2018-06-25 00:12:23', 156),
(3, '2018-06-25 00:20:49', 157),
(2, '2018-06-27 10:40:16', 204);

-- --------------------------------------------------------

--
-- Структура на таблица `material`
--

CREATE TABLE `material` (
  `MaterialID` int(11) NOT NULL,
  `LoanId` int(10) DEFAULT NULL,
  `Returned` tinyint(1) NOT NULL,
  `MaterialTypeId` int(11) NOT NULL,
  `StorageMaterialId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `material`
--

INSERT INTO `material` (`MaterialID`, `LoanId`, `Returned`, `MaterialTypeId`, `StorageMaterialId`) VALUES
(1, 1, 1, 1, 1),
(2, 1, 0, 2, 2),
(3, 1, 0, 3, 3),
(4, 1, 0, 4, 4),
(5, 3, 0, 3, 3),
(6, 2, 0, 1, 1);

-- --------------------------------------------------------

--
-- Структура на таблица `materialtype`
--

CREATE TABLE `materialtype` (
  `MaterialTypeId` int(11) NOT NULL,
  `Name` varchar(20) NOT NULL,
  `Price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `materialtype`
--

INSERT INTO `materialtype` (`MaterialTypeId`, `Name`, `Price`) VALUES
(1, 'USB-cabel', 2),
(2, 'Power-bank', 3),
(3, 'Laptop-charger', 5),
(4, 'Iphone-charger', 3);

-- --------------------------------------------------------

--
-- Структура на таблица `moneydeposit`
--

CREATE TABLE `moneydeposit` (
  `ATMDeposit` decimal(10,0) NOT NULL,
  `WebsiteDeposit` decimal(10,0) NOT NULL,
  `TransactionId` int(11) NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура на таблица `pma__bookmark`
--

CREATE TABLE `pma__bookmark` (
  `id` int(11) NOT NULL,
  `dbase` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `user` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `label` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `query` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Bookmarks';

-- --------------------------------------------------------

--
-- Структура на таблица `pma__central_columns`
--

CREATE TABLE `pma__central_columns` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_type` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_length` text COLLATE utf8_bin,
  `col_collation` varchar(64) COLLATE utf8_bin NOT NULL,
  `col_isNull` tinyint(1) NOT NULL,
  `col_extra` varchar(255) COLLATE utf8_bin DEFAULT '',
  `col_default` text COLLATE utf8_bin
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Central list of columns';

-- --------------------------------------------------------

--
-- Структура на таблица `pma__column_info`
--

CREATE TABLE `pma__column_info` (
  `id` int(5) UNSIGNED NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `column_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `comment` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `mimetype` varchar(255) CHARACTER SET utf8 NOT NULL DEFAULT '',
  `transformation` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `transformation_options` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `input_transformation` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT '',
  `input_transformation_options` varchar(255) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Column information for phpMyAdmin';

-- --------------------------------------------------------

--
-- Структура на таблица `pma__designer_settings`
--

CREATE TABLE `pma__designer_settings` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `settings_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Settings related to Designer';

--
-- Схема на данните от таблица `pma__designer_settings`
--

INSERT INTO `pma__designer_settings` (`username`, `settings_data`) VALUES
('dbi378522', '{"angular_direct":"direct","relation_lines":"true","snap_to_grid":"off","full_screen":"off"}');

-- --------------------------------------------------------

--
-- Структура на таблица `pma__export_templates`
--

CREATE TABLE `pma__export_templates` (
  `id` int(5) UNSIGNED NOT NULL,
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `export_type` varchar(10) COLLATE utf8_bin NOT NULL,
  `template_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `template_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Saved export templates';

--
-- Схема на данните от таблица `pma__export_templates`
--

INSERT INTO `pma__export_templates` (`id`, `username`, `export_type`, `template_name`, `template_data`) VALUES
(1, 'dbi378522', 'database', 'Event', '{"quick_or_custom":"quick","what":"sql","structure_or_data_forced":"0","table_select[]":["alert","changesite","customer","employee","extrabed","loan","material","materialtype","moneydeposit","pma__bookmark","pma__central_columns","pma__column_info","pma__designer_settings","pma__export_templates","pma__favorite","pma__history","pma__navigationhiding","pma__pdf_pages","pma__recent","pma__relation","pma__savedsearches","pma__table_coords","pma__table_info","pma__table_uiprefs","pma__tracking","pma__userconfig","pma__usergroups","pma__users","product","productorder","productorderlines","room","roomreservation","roomtype","storagematerials","storageproducts","test","transactions"],"table_structure[]":["alert","changesite","customer","employee","extrabed","loan","material","materialtype","moneydeposit","pma__bookmark","pma__central_columns","pma__column_info","pma__designer_settings","pma__export_templates","pma__favorite","pma__history","pma__navigationhiding","pma__pdf_pages","pma__recent","pma__relation","pma__savedsearches","pma__table_coords","pma__table_info","pma__table_uiprefs","pma__tracking","pma__userconfig","pma__usergroups","pma__users","product","productorder","productorderlines","room","roomreservation","roomtype","storagematerials","storageproducts","test","transactions"],"table_data[]":["alert","changesite","customer","employee","extrabed","loan","material","materialtype","moneydeposit","pma__bookmark","pma__central_columns","pma__column_info","pma__designer_settings","pma__export_templates","pma__favorite","pma__history","pma__navigationhiding","pma__pdf_pages","pma__recent","pma__relation","pma__savedsearches","pma__table_coords","pma__table_info","pma__table_uiprefs","pma__tracking","pma__userconfig","pma__usergroups","pma__users","product","productorder","productorderlines","room","roomreservation","roomtype","storagematerials","storageproducts","test","transactions"],"output_format":"sendit","filename_template":"@DATABASE@","remember_template":"on","charset":"utf-8","compression":"none","maxsize":"","odt_structure_or_data":"structure_and_data","odt_relation":"something","odt_comments":"something","odt_mime":"something","odt_columns":"something","odt_null":"NULL","ods_null":"NULL","ods_structure_or_data":"data","latex_caption":"something","latex_structure_or_data":"structure_and_data","latex_structure_caption":"Структура на таблица @TABLE@","latex_structure_continued_caption":"Структура на таблица @TABLE@ (продължение)","latex_structure_label":"tab:@TABLE@-structure","latex_relation":"something","latex_comments":"something","latex_mime":"something","latex_columns":"something","latex_data_caption":"Съдържание на таблица @TABLE@","latex_data_continued_caption":"Съдържание на таблица @TABLE@ (продължение)","latex_data_label":"tab:@TABLE@-data","latex_null":"\\\\textit{NULL}","xml_structure_or_data":"data","xml_export_events":"something","xml_export_functions":"something","xml_export_procedures":"something","xml_export_tables":"something","xml_export_triggers":"something","xml_export_views":"something","xml_export_contents":"something","codegen_structure_or_data":"data","codegen_format":"0","json_structure_or_data":"data","mediawiki_structure_or_data":"structure_and_data","mediawiki_caption":"something","mediawiki_headers":"something","phparray_structure_or_data":"data","yaml_structure_or_data":"data","htmlword_structure_or_data":"structure_and_data","htmlword_null":"NULL","csv_separator":",","csv_enclosed":"\\"","csv_escaped":"\\"","csv_terminated":"AUTO","csv_null":"NULL","csv_structure_or_data":"data","sql_include_comments":"something","sql_header_comment":"","sql_compatibility":"NONE","sql_structure_or_data":"structure_and_data","sql_create_table":"something","sql_auto_increment":"something","sql_create_view":"something","sql_procedure_function":"something","sql_create_trigger":"something","sql_backquotes":"something","sql_type":"INSERT","sql_insert_syntax":"both","sql_max_query_size":"50000","sql_hex_for_binary":"something","sql_utc_time":"something","pdf_report_title":"","pdf_structure_or_data":"structure_and_data","texytext_structure_or_data":"structure_and_data","texytext_null":"NULL","excel_null":"NULL","excel_edition":"win","excel_structure_or_data":"data","":null,"lock_tables":null,"as_separate_files":null,"ods_columns":null,"json_pretty_print":null,"htmlword_columns":null,"csv_removeCRLF":null,"csv_columns":null,"sql_dates":null,"sql_relation":null,"sql_mime":null,"sql_use_transaction":null,"sql_disable_fk":null,"sql_views_as_tables":null,"sql_metadata":null,"sql_create_database":null,"sql_drop_table":null,"sql_if_not_exists":null,"sql_truncate":null,"sql_delayed":null,"sql_ignore":null,"texytext_columns":null,"excel_removeCRLF":null,"excel_columns":null}');

-- --------------------------------------------------------

--
-- Структура на таблица `pma__favorite`
--

CREATE TABLE `pma__favorite` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `tables` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Favorite tables';

-- --------------------------------------------------------

--
-- Структура на таблица `pma__history`
--

CREATE TABLE `pma__history` (
  `id` bigint(20) UNSIGNED NOT NULL,
  `username` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `timevalue` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `sqlquery` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='SQL history for phpMyAdmin';

-- --------------------------------------------------------

--
-- Структура на таблица `pma__navigationhiding`
--

CREATE TABLE `pma__navigationhiding` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `item_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `item_type` varchar(64) COLLATE utf8_bin NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Hidden items of navigation tree';

-- --------------------------------------------------------

--
-- Структура на таблица `pma__pdf_pages`
--

CREATE TABLE `pma__pdf_pages` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `page_nr` int(10) UNSIGNED NOT NULL,
  `page_descr` varchar(50) CHARACTER SET utf8 NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='PDF relation pages for phpMyAdmin';

--
-- Схема на данните от таблица `pma__pdf_pages`
--

INSERT INTO `pma__pdf_pages` (`db_name`, `page_nr`, `page_descr`) VALUES
('dbi378522', 1, 'PropEvent');

-- --------------------------------------------------------

--
-- Структура на таблица `pma__recent`
--

CREATE TABLE `pma__recent` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `tables` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Recently accessed tables';

--
-- Схема на данните от таблица `pma__recent`
--

INSERT INTO `pma__recent` (`username`, `tables`) VALUES
('dbi378522', '[{"db":"dbi378522","table":"room"},{"db":"dbi378522","table":"roomreservation"},{"db":"dbi378522","table":"transactions"},{"db":"dbi378522","table":"material"},{"db":"dbi378522","table":"customer"},{"db":"dbi378522","table":"changesite"},{"db":"dbi378522","table":"product"},{"db":"dbi378522","table":"employee"},{"db":"dbi378522","table":"storageproducts"},{"db":"dbi378522","table":"storagematerials"}]');

-- --------------------------------------------------------

--
-- Структура на таблица `pma__relation`
--

CREATE TABLE `pma__relation` (
  `master_db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `master_table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `master_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_db` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_table` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `foreign_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Relation table';

-- --------------------------------------------------------

--
-- Структура на таблица `pma__savedsearches`
--

CREATE TABLE `pma__savedsearches` (
  `id` int(5) UNSIGNED NOT NULL,
  `username` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `search_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `search_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Saved searches';

-- --------------------------------------------------------

--
-- Структура на таблица `pma__table_coords`
--

CREATE TABLE `pma__table_coords` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `pdf_page_number` int(11) NOT NULL DEFAULT '0',
  `x` float UNSIGNED NOT NULL DEFAULT '0',
  `y` float UNSIGNED NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Table coordinates for phpMyAdmin PDF output';

--
-- Схема на данните от таблица `pma__table_coords`
--

INSERT INTO `pma__table_coords` (`db_name`, `table_name`, `pdf_page_number`, `x`, `y`) VALUES
('dbi378522', 'customer', 1, 852, 368),
('dbi378522', 'employee', 1, 654, 487),
('dbi378522', 'extrabed', 1, 1074, 373),
('dbi378522', 'loan', 1, 400, 508),
('dbi378522', 'material', 1, 133, 445),
('dbi378522', 'materialtype', 1, 61, 237),
('dbi378522', 'moneydeposit', 1, 595, 17),
('dbi378522', 'product', 1, 358, 88),
('dbi378522', 'productorder', 1, 351, 357),
('dbi378522', 'productorderlines', 1, 294, 221),
('dbi378522', 'room', 1, 1085, 150),
('dbi378522', 'roomreservation', 1, 846, 21),
('dbi378522', 'roomtype', 1, 873, 201),
('dbi378522', 'storagematerials', 1, 82, 33),
('dbi378522', 'storageproducts', 1, 347, 3),
('dbi378522', 'transactions', 1, 602, 233);

-- --------------------------------------------------------

--
-- Структура на таблица `pma__table_info`
--

CREATE TABLE `pma__table_info` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT '',
  `display_field` varchar(64) COLLATE utf8_bin NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Table information for phpMyAdmin';

-- --------------------------------------------------------

--
-- Структура на таблица `pma__table_uiprefs`
--

CREATE TABLE `pma__table_uiprefs` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `prefs` text COLLATE utf8_bin NOT NULL,
  `last_update` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Tables'' UI preferences';

--
-- Схема на данните от таблица `pma__table_uiprefs`
--

INSERT INTO `pma__table_uiprefs` (`username`, `db_name`, `table_name`, `prefs`, `last_update`) VALUES
('dbi378522', 'dbi378522', 'customer', '{"sorted_col":"`customer`.`TicketNumber`  DESC","CREATE_TIME":"2018-06-24 22:17:03","col_order":["0","1","2","3","4","5","6","8","7"],"col_visib":["1","1","1","1","1","1","1","1","1"]}', '2018-06-26 22:07:24'),
('dbi378522', 'dbi378522', 'extrabed', '{"sorted_col":"`extrabed`.`RoomNumber` ASC"}', '2018-06-04 08:48:58'),
('dbi378522', 'dbi378522', 'product', '{"CREATE_TIME":"2018-06-07 23:12:28","col_order":["0","1","2","3","4","5"],"col_visib":["1","1","1","1","1","1"]}', '2018-06-07 21:32:39'),
('dbi378522', 'dbi378522', 'room', '{"sorted_col":"`room`.`RoomNumber` ASC"}', '2018-06-03 16:00:00'),
('dbi378522', 'dbi378522', 'roomreservation', '{"sorted_col":"`roomreservation`.`TransactionId` ASC"}', '2018-06-03 19:40:15');

-- --------------------------------------------------------

--
-- Структура на таблица `pma__tracking`
--

CREATE TABLE `pma__tracking` (
  `db_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `table_name` varchar(64) COLLATE utf8_bin NOT NULL,
  `version` int(10) UNSIGNED NOT NULL,
  `date_created` datetime NOT NULL,
  `date_updated` datetime NOT NULL,
  `schema_snapshot` text COLLATE utf8_bin NOT NULL,
  `schema_sql` text COLLATE utf8_bin,
  `data_sql` longtext COLLATE utf8_bin,
  `tracking` set('UPDATE','REPLACE','INSERT','DELETE','TRUNCATE','CREATE DATABASE','ALTER DATABASE','DROP DATABASE','CREATE TABLE','ALTER TABLE','RENAME TABLE','DROP TABLE','CREATE INDEX','DROP INDEX','CREATE VIEW','ALTER VIEW','DROP VIEW') COLLATE utf8_bin DEFAULT NULL,
  `tracking_active` int(1) UNSIGNED NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Database changes tracking for phpMyAdmin';

-- --------------------------------------------------------

--
-- Структура на таблица `pma__userconfig`
--

CREATE TABLE `pma__userconfig` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `timevalue` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `config_data` text COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='User preferences storage for phpMyAdmin';

--
-- Схема на данните от таблица `pma__userconfig`
--

INSERT INTO `pma__userconfig` (`username`, `timevalue`, `config_data`) VALUES
('dbi378522', '2018-06-23 19:24:27', '{"collation_connection":"utf8mb4_unicode_ci","lang":"bg"}');

-- --------------------------------------------------------

--
-- Структура на таблица `pma__usergroups`
--

CREATE TABLE `pma__usergroups` (
  `usergroup` varchar(64) COLLATE utf8_bin NOT NULL,
  `tab` varchar(64) COLLATE utf8_bin NOT NULL,
  `allowed` enum('Y','N') COLLATE utf8_bin NOT NULL DEFAULT 'N'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='User groups with configured menu items';

-- --------------------------------------------------------

--
-- Структура на таблица `pma__users`
--

CREATE TABLE `pma__users` (
  `username` varchar(64) COLLATE utf8_bin NOT NULL,
  `usergroup` varchar(64) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin COMMENT='Users and their assignments to user groups';

-- --------------------------------------------------------

--
-- Структура на таблица `product`
--

CREATE TABLE `product` (
  `ProductId` int(11) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `Price` decimal(10,0) NOT NULL,
  `StorageProductId` int(11) DEFAULT NULL,
  `Type` varchar(22) NOT NULL,
  `Ingredients` varchar(123) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `product`
--

INSERT INTO `product` (`ProductId`, `Name`, `Price`, `StorageProductId`, `Type`, `Ingredients`) VALUES
(1, 'Avocado-Tuna-Tapas', '10', 1, 'Salad', 'Avocado, Tuna, Bell pepper, Vinegar, Onions'),
(2, 'Caprese-Salad', '13', 2, 'Salad', 'Tomatoes, Fresh mozarella, Olive oil, Basil'),
(3, 'Artichokes-Salad', '10', 3, 'Salad', 'Mixed Greens, Artichokes, Oil, Vinegar'),
(4, 'Ginger-Steak-Salad', '10', 4, 'Salad', 'Rib-eye steak, Greens, Ginger, Jalapeno, Onions'),
(5, 'Cherry-Pie', '12', 5, 'Dessert', 'Dough, Eggs, Demarara sugar, Butter, Lemon'),
(6, 'Black-bottom-pie', '13', 6, 'Dessert', 'Oreo biscuits, Milk, Chocolate, Vanilla, Sugar'),
(7, 'Hot-Cross-Kanelburall', '25', 7, 'Dessert', 'Milk, Eggs, Syrup, Sugar, Lemon, Orange'),
(8, 'Nutella-pancakes', '30', 8, 'Dessert', 'Milk, Nutella, Butter, Egg, Sugar, Cacao powder'),
(9, 'Pasta-with-Lambu-Ragu', '17', 9, 'Meal', 'Onion, Bell Pepper, Tomatoes, Romano cheese'),
(10, 'Cocnut-Aubergine-Curry', '13', 10, 'Meal', 'Onion, Ginger, Coconut, Curry sauce, Peanut butter'),
(11, 'Wild-rice-rissoto-with-garlic', '25', 11, 'Meal', 'Garlic, Shallots, Wild rice, Mushrooms, Olive oil'),
(12, 'Skillet-Tarragon-Chicken', '30', 12, 'Meal', 'Island duck, Broccoli, Sessame crumbs, Mustard'),
(13, 'Coffee', '2', 13, 'HotDrink', ''),
(14, 'Cappuccino', '2', 14, 'HotDrink', ''),
(15, 'Tea', '2', 15, 'HotDrink', ''),
(16, 'Hot-Chocolate', '4', 16, 'HotDrink', ''),
(17, 'Coca-Cola', '1', 17, 'Non-alcoholic', ''),
(18, 'Soda', '1', 18, 'Non-alcoholic', ''),
(19, 'Energy-Drink', '2', 19, 'Non-alcoholic', ''),
(20, 'Juice', '2', 20, 'Non-alcoholic', ''),
(21, 'Margarita', '6', 21, 'Alcoholic', ''),
(22, 'Cosmopolitan', '6', 22, 'Alcoholic', ''),
(23, 'Metropolitan', '5', 23, 'Alcoholic', ''),
(24, 'Martini', '4', 24, 'Alcoholic', ''),
(27, 'Tuna', '12', 28, 'Salad', 'Fish'),
(28, 'Kip', '4', 29, 'Meal', 'Meso'),
(29, 'Beer', '1213', 32, 'Drink', ''),
(30, 'vodka', '12', 33, 'drink', '');

-- --------------------------------------------------------

--
-- Структура на таблица `productorder`
--

CREATE TABLE `productorder` (
  `ProductOrderId` int(11) NOT NULL,
  `Date` datetime NOT NULL,
  `TransactionId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `productorder`
--

INSERT INTO `productorder` (`ProductOrderId`, `Date`, `TransactionId`) VALUES
(1, '2018-06-24 20:34:00', 122),
(2, '2018-06-24 20:37:06', 123),
(3, '2018-06-24 20:46:49', 124),
(4, '2018-06-24 21:21:01', 125),
(5, '2018-06-24 21:21:03', 126),
(6, '2018-06-24 21:21:04', 127),
(7, '2018-06-24 21:21:05', 128),
(8, '2018-06-25 11:38:43', 158),
(9, '2018-06-25 11:38:44', 159),
(10, '2018-06-27 08:31:03', 190),
(11, '2018-06-27 08:31:03', 190),
(12, '2018-06-27 08:31:03', 191),
(13, '2018-06-27 08:31:03', 191),
(14, '2018-06-27 08:38:10', 194),
(15, '2018-06-27 08:38:11', 195),
(16, '2018-06-27 10:38:28', 200),
(17, '2018-06-27 10:38:29', 201),
(18, '2018-06-27 10:38:34', 202),
(19, '2018-06-27 10:38:40', 203),
(20, '2018-06-27 10:53:31', 208),
(21, '2018-06-27 10:53:31', 208),
(22, '2018-06-27 10:53:31', 208),
(23, '2018-06-27 10:53:31', 209),
(24, '2018-06-27 10:53:31', 209),
(25, '2018-06-27 10:53:31', 209),
(26, '2018-06-27 10:53:31', 210),
(27, '2018-06-27 10:53:31', 210),
(28, '2018-06-27 10:53:31', 210),
(29, '2018-06-27 10:53:32', 211),
(30, '2018-06-27 10:53:32', 211),
(31, '2018-06-27 10:53:32', 212),
(32, '2018-06-27 10:53:32', 212);

-- --------------------------------------------------------

--
-- Структура на таблица `productorderlines`
--

CREATE TABLE `productorderlines` (
  `ProductOrderLineId` int(11) NOT NULL,
  `ProductOrderId` int(11) NOT NULL,
  `ProductId` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `productorderlines`
--

INSERT INTO `productorderlines` (`ProductOrderLineId`, `ProductOrderId`, `ProductId`, `Quantity`) VALUES
(5, 2, 12, 123),
(6, 3, 2, 1),
(7, 4, 4, 2),
(8, 5, 4, 2),
(9, 6, 4, 2),
(10, 7, 4, 2),
(11, 4, 6, 2),
(12, 5, 6, 2),
(13, 6, 6, 2),
(14, 7, 6, 2),
(15, 4, 17, 2),
(16, 5, 17, 2),
(17, 6, 17, 2),
(18, 7, 17, 2),
(19, 4, 14, 2),
(20, 5, 14, 2),
(21, 6, 14, 2),
(22, 7, 14, 2),
(23, 8, 1, 1),
(24, 9, 1, 1),
(25, 8, 2, 1),
(26, 9, 2, 1),
(27, 10, 9, 1),
(28, 10, 9, 1),
(29, 11, 9, 1),
(30, 11, 9, 1),
(31, 12, 9, 1),
(32, 12, 9, 1),
(33, 13, 9, 1),
(34, 13, 9, 1),
(35, 10, 9, 1),
(36, 10, 9, 1),
(37, 11, 9, 1),
(38, 11, 9, 1),
(39, 12, 9, 1),
(40, 12, 9, 1),
(41, 13, 9, 1),
(42, 13, 9, 1),
(43, 10, 9, 1),
(44, 10, 9, 1),
(45, 11, 9, 1),
(46, 11, 9, 1),
(47, 12, 9, 1),
(48, 12, 9, 1),
(49, 13, 9, 1),
(50, 13, 9, 1),
(51, 10, 9, 1),
(52, 10, 9, 1),
(53, 11, 9, 1),
(54, 11, 9, 1),
(55, 12, 9, 1),
(56, 12, 9, 1),
(57, 13, 9, 1),
(58, 13, 9, 1),
(59, 14, 9, 1),
(60, 15, 9, 1),
(61, 14, 9, 1),
(62, 15, 9, 1),
(63, 16, 1, 1),
(64, 17, 1, 1),
(65, 18, 1, 1),
(66, 19, 1, 1),
(67, 16, 4, 1),
(68, 17, 4, 1),
(69, 18, 4, 1),
(70, 19, 4, 1),
(71, 16, 9, 1),
(72, 17, 9, 1),
(73, 18, 9, 1),
(74, 19, 9, 1),
(75, 16, 9, 5),
(76, 17, 9, 5),
(77, 18, 9, 5),
(78, 19, 9, 5),
(79, 20, 9, 1),
(80, 20, 9, 1),
(81, 20, 9, 1),
(82, 21, 9, 1),
(83, 21, 9, 1),
(84, 21, 9, 1),
(85, 22, 9, 1),
(86, 22, 9, 1),
(87, 22, 9, 1),
(88, 23, 9, 1),
(89, 23, 9, 1),
(90, 23, 9, 1),
(91, 24, 9, 1),
(92, 24, 9, 1),
(93, 24, 9, 1),
(94, 25, 9, 1),
(95, 25, 9, 1),
(96, 25, 9, 1),
(97, 26, 9, 1),
(98, 26, 9, 1),
(99, 26, 9, 1),
(100, 27, 9, 1),
(101, 27, 9, 1),
(102, 27, 9, 1),
(103, 28, 9, 1),
(104, 28, 9, 1),
(105, 28, 9, 1),
(106, 29, 9, 1),
(107, 29, 9, 1),
(108, 30, 9, 1),
(109, 30, 9, 1),
(110, 31, 9, 1),
(111, 31, 9, 1),
(112, 32, 9, 1),
(113, 32, 9, 1),
(114, 20, 9, 1),
(115, 20, 9, 1),
(116, 20, 9, 1),
(117, 21, 9, 1),
(118, 21, 9, 1),
(119, 21, 9, 1),
(120, 22, 9, 1),
(121, 22, 9, 1),
(122, 22, 9, 1),
(123, 23, 9, 1),
(124, 23, 9, 1),
(125, 23, 9, 1),
(126, 24, 9, 1),
(127, 24, 9, 1),
(128, 24, 9, 1),
(129, 25, 9, 1),
(130, 25, 9, 1),
(131, 25, 9, 1),
(132, 26, 9, 1),
(133, 26, 9, 1),
(134, 26, 9, 1),
(135, 27, 9, 1),
(136, 27, 9, 1),
(137, 27, 9, 1),
(138, 28, 9, 1),
(139, 28, 9, 1),
(140, 28, 9, 1),
(141, 29, 9, 1),
(142, 29, 9, 1),
(143, 30, 9, 1),
(144, 30, 9, 1),
(145, 31, 9, 1),
(146, 31, 9, 1),
(147, 32, 9, 1),
(148, 32, 9, 1),
(149, 20, 9, 1),
(150, 20, 9, 1),
(151, 20, 9, 1),
(152, 21, 9, 1),
(153, 21, 9, 1),
(154, 21, 9, 1),
(155, 22, 9, 1),
(156, 22, 9, 1),
(157, 22, 9, 1),
(158, 23, 9, 1),
(159, 23, 9, 1),
(160, 23, 9, 1),
(161, 24, 9, 1),
(162, 24, 9, 1),
(163, 24, 9, 1),
(164, 25, 9, 1),
(165, 25, 9, 1),
(166, 25, 9, 1),
(167, 26, 9, 1),
(168, 26, 9, 1),
(169, 26, 9, 1),
(170, 27, 9, 1),
(171, 27, 9, 1),
(172, 27, 9, 1),
(173, 28, 9, 1),
(174, 28, 9, 1),
(175, 28, 9, 1),
(176, 29, 9, 1),
(177, 29, 9, 1),
(178, 30, 9, 1),
(179, 30, 9, 1),
(180, 31, 9, 1),
(181, 31, 9, 1),
(182, 32, 9, 1),
(183, 32, 9, 1),
(184, 20, 9, 1),
(185, 20, 9, 1),
(186, 20, 9, 1),
(187, 21, 9, 1),
(188, 21, 9, 1),
(189, 21, 9, 1),
(190, 22, 9, 1),
(191, 22, 9, 1),
(192, 22, 9, 1),
(193, 23, 9, 1),
(194, 23, 9, 1),
(195, 23, 9, 1),
(196, 24, 9, 1),
(197, 24, 9, 1),
(198, 24, 9, 1),
(199, 25, 9, 1),
(200, 25, 9, 1),
(201, 25, 9, 1),
(202, 26, 9, 1),
(203, 26, 9, 1),
(204, 26, 9, 1),
(205, 27, 9, 1),
(206, 27, 9, 1),
(207, 27, 9, 1),
(208, 28, 9, 1),
(209, 28, 9, 1),
(210, 28, 9, 1),
(211, 29, 9, 1),
(212, 29, 9, 1),
(213, 30, 9, 1),
(214, 30, 9, 1),
(215, 31, 9, 1),
(216, 31, 9, 1),
(217, 32, 9, 1),
(218, 32, 9, 1),
(219, 20, 9, 1),
(220, 20, 9, 1),
(221, 20, 9, 1),
(222, 21, 9, 1),
(223, 21, 9, 1),
(224, 21, 9, 1),
(225, 22, 9, 1),
(226, 22, 9, 1),
(227, 22, 9, 1),
(228, 23, 9, 1),
(229, 23, 9, 1),
(230, 23, 9, 1),
(231, 24, 9, 1),
(232, 24, 9, 1),
(233, 24, 9, 1),
(234, 25, 9, 1),
(235, 25, 9, 1),
(236, 25, 9, 1),
(237, 26, 9, 1),
(238, 26, 9, 1),
(239, 26, 9, 1),
(240, 27, 9, 1),
(241, 27, 9, 1),
(242, 27, 9, 1),
(243, 28, 9, 1),
(244, 28, 9, 1),
(245, 28, 9, 1),
(246, 29, 9, 1),
(247, 29, 9, 1),
(248, 30, 9, 1),
(249, 30, 9, 1),
(250, 31, 9, 1),
(251, 31, 9, 1),
(252, 32, 9, 1),
(253, 32, 9, 1),
(254, 20, 9, 1),
(255, 20, 9, 1),
(256, 20, 9, 1),
(257, 21, 9, 1),
(258, 21, 9, 1),
(259, 21, 9, 1),
(260, 22, 9, 1),
(261, 22, 9, 1),
(262, 22, 9, 1),
(263, 23, 9, 1),
(264, 23, 9, 1),
(265, 23, 9, 1),
(266, 24, 9, 1),
(267, 24, 9, 1),
(268, 24, 9, 1),
(269, 25, 9, 1),
(270, 25, 9, 1),
(271, 25, 9, 1),
(272, 26, 9, 1),
(273, 26, 9, 1),
(274, 26, 9, 1),
(275, 27, 9, 1),
(276, 27, 9, 1),
(277, 27, 9, 1),
(278, 28, 9, 1),
(279, 28, 9, 1),
(280, 28, 9, 1),
(281, 29, 9, 1),
(282, 29, 9, 1),
(283, 30, 9, 1),
(284, 30, 9, 1),
(285, 31, 9, 1),
(286, 31, 9, 1),
(287, 32, 9, 1),
(288, 32, 9, 1),
(289, 20, 9, 1),
(290, 20, 9, 1),
(291, 20, 9, 1),
(292, 21, 9, 1),
(293, 21, 9, 1),
(294, 21, 9, 1),
(295, 22, 9, 1),
(296, 22, 9, 1),
(297, 22, 9, 1),
(298, 23, 9, 1),
(299, 23, 9, 1),
(300, 23, 9, 1),
(301, 24, 9, 1),
(302, 24, 9, 1),
(303, 24, 9, 1),
(304, 25, 9, 1),
(305, 25, 9, 1),
(306, 25, 9, 1),
(307, 26, 9, 1),
(308, 26, 9, 1),
(309, 26, 9, 1),
(310, 27, 9, 1),
(311, 27, 9, 1),
(312, 27, 9, 1),
(313, 28, 9, 1),
(314, 28, 9, 1),
(315, 28, 9, 1),
(316, 29, 9, 1),
(317, 29, 9, 1),
(318, 30, 9, 1),
(319, 30, 9, 1),
(320, 31, 9, 1),
(321, 31, 9, 1),
(322, 32, 9, 1),
(323, 32, 9, 1),
(324, 20, 9, 1),
(325, 20, 9, 1),
(326, 20, 9, 1),
(327, 21, 9, 1),
(328, 21, 9, 1),
(329, 21, 9, 1),
(330, 22, 9, 1),
(331, 22, 9, 1),
(332, 22, 9, 1),
(333, 23, 9, 1),
(334, 23, 9, 1),
(335, 23, 9, 1),
(336, 24, 9, 1),
(337, 24, 9, 1),
(338, 24, 9, 1),
(339, 25, 9, 1),
(340, 25, 9, 1),
(341, 25, 9, 1),
(342, 26, 9, 1),
(343, 26, 9, 1),
(344, 26, 9, 1),
(345, 27, 9, 1),
(346, 27, 9, 1),
(347, 27, 9, 1),
(348, 28, 9, 1),
(349, 28, 9, 1),
(350, 28, 9, 1),
(351, 29, 9, 1),
(352, 29, 9, 1),
(353, 30, 9, 1),
(354, 30, 9, 1),
(355, 31, 9, 1),
(356, 31, 9, 1),
(357, 32, 9, 1),
(358, 32, 9, 1),
(359, 20, 9, 1),
(360, 20, 9, 1),
(361, 20, 9, 1),
(362, 21, 9, 1),
(363, 21, 9, 1),
(364, 21, 9, 1),
(365, 22, 9, 1),
(366, 22, 9, 1),
(367, 22, 9, 1),
(368, 23, 9, 1),
(369, 23, 9, 1),
(370, 23, 9, 1),
(371, 24, 9, 1),
(372, 24, 9, 1),
(373, 24, 9, 1),
(374, 25, 9, 1),
(375, 25, 9, 1),
(376, 25, 9, 1),
(377, 26, 9, 1),
(378, 26, 9, 1),
(379, 26, 9, 1),
(380, 27, 9, 1),
(381, 27, 9, 1),
(382, 27, 9, 1),
(383, 28, 9, 1),
(384, 28, 9, 1),
(385, 28, 9, 1),
(386, 29, 9, 1),
(387, 29, 9, 1),
(388, 30, 9, 1),
(389, 30, 9, 1),
(390, 31, 9, 1),
(391, 31, 9, 1),
(392, 32, 9, 1),
(393, 32, 9, 1),
(394, 20, 9, 1),
(395, 20, 9, 1),
(396, 20, 9, 1),
(397, 21, 9, 1),
(398, 21, 9, 1),
(399, 21, 9, 1),
(400, 22, 9, 1),
(401, 22, 9, 1),
(402, 22, 9, 1),
(403, 23, 9, 1),
(404, 23, 9, 1),
(405, 23, 9, 1),
(406, 24, 9, 1),
(407, 24, 9, 1),
(408, 24, 9, 1),
(409, 25, 9, 1),
(410, 25, 9, 1),
(411, 25, 9, 1),
(412, 26, 9, 1),
(413, 26, 9, 1),
(414, 26, 9, 1),
(415, 27, 9, 1),
(416, 27, 9, 1),
(417, 27, 9, 1),
(418, 28, 9, 1),
(419, 28, 9, 1),
(420, 28, 9, 1),
(421, 29, 9, 1),
(422, 29, 9, 1),
(423, 30, 9, 1),
(424, 30, 9, 1),
(425, 31, 9, 1),
(426, 31, 9, 1),
(427, 32, 9, 1),
(428, 32, 9, 1),
(429, 20, 9, 1),
(430, 20, 9, 1),
(431, 20, 9, 1),
(432, 21, 9, 1),
(433, 21, 9, 1),
(434, 21, 9, 1),
(435, 22, 9, 1),
(436, 22, 9, 1),
(437, 22, 9, 1),
(438, 23, 9, 1),
(439, 23, 9, 1),
(440, 23, 9, 1),
(441, 24, 9, 1),
(442, 24, 9, 1),
(443, 24, 9, 1),
(444, 25, 9, 1),
(445, 25, 9, 1),
(446, 25, 9, 1),
(447, 26, 9, 1),
(448, 26, 9, 1),
(449, 26, 9, 1),
(450, 27, 9, 1),
(451, 27, 9, 1),
(452, 27, 9, 1),
(453, 28, 9, 1),
(454, 28, 9, 1),
(455, 28, 9, 1),
(456, 29, 9, 1),
(457, 29, 9, 1),
(458, 30, 9, 1),
(459, 30, 9, 1),
(460, 31, 9, 1),
(461, 31, 9, 1),
(462, 32, 9, 1),
(463, 32, 9, 1),
(464, 20, 9, 1),
(465, 20, 9, 1),
(466, 20, 9, 1),
(467, 21, 9, 1),
(468, 21, 9, 1),
(469, 21, 9, 1),
(470, 22, 9, 1),
(471, 22, 9, 1),
(472, 22, 9, 1),
(473, 23, 9, 1),
(474, 23, 9, 1),
(475, 23, 9, 1),
(476, 24, 9, 1),
(477, 24, 9, 1),
(478, 24, 9, 1),
(479, 25, 9, 1),
(480, 25, 9, 1),
(481, 25, 9, 1),
(482, 26, 9, 1),
(483, 26, 9, 1),
(484, 26, 9, 1),
(485, 27, 9, 1),
(486, 27, 9, 1),
(487, 27, 9, 1),
(488, 28, 9, 1),
(489, 28, 9, 1),
(490, 28, 9, 1),
(491, 29, 9, 1),
(492, 29, 9, 1),
(493, 30, 9, 1),
(494, 30, 9, 1),
(495, 31, 9, 1),
(496, 31, 9, 1),
(497, 32, 9, 1),
(498, 32, 9, 1),
(499, 20, 9, 1),
(500, 20, 9, 1),
(501, 20, 9, 1),
(502, 21, 9, 1),
(503, 21, 9, 1),
(504, 21, 9, 1),
(505, 22, 9, 1),
(506, 22, 9, 1),
(507, 22, 9, 1),
(508, 23, 9, 1),
(509, 23, 9, 1),
(510, 23, 9, 1),
(511, 24, 9, 1),
(512, 24, 9, 1),
(513, 24, 9, 1),
(514, 25, 9, 1),
(515, 25, 9, 1),
(516, 25, 9, 1),
(517, 26, 9, 1),
(518, 26, 9, 1),
(519, 26, 9, 1),
(520, 27, 9, 1),
(521, 27, 9, 1),
(522, 27, 9, 1),
(523, 28, 9, 1),
(524, 28, 9, 1),
(525, 28, 9, 1),
(526, 29, 9, 1),
(527, 29, 9, 1),
(528, 30, 9, 1),
(529, 30, 9, 1),
(530, 31, 9, 1),
(531, 31, 9, 1),
(532, 32, 9, 1),
(533, 32, 9, 1);

-- --------------------------------------------------------

--
-- Структура на таблица `room`
--

CREATE TABLE `room` (
  `RoomNumber` int(11) NOT NULL,
  `RoomTypeId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `room`
--

INSERT INTO `room` (`RoomNumber`, `RoomTypeId`) VALUES
(1, 1),
(2, 1),
(3, 1),
(4, 1),
(7, 1),
(8, 1),
(9, 1),
(10, 1),
(5, 2),
(11, 2),
(12, 2),
(13, 2),
(14, 2),
(15, 2),
(24, 2),
(6, 3),
(21, 3),
(22, 3),
(23, 3),
(25, 3),
(26, 3),
(27, 3),
(28, 3),
(29, 3),
(30, 3);

-- --------------------------------------------------------

--
-- Структура на таблица `roomreservation`
--

CREATE TABLE `roomreservation` (
  `TransactionId` int(11) NOT NULL,
  `RoomNumber` int(11) NOT NULL,
  `Start` date DEFAULT NULL,
  `End` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `roomreservation`
--

INSERT INTO `roomreservation` (`TransactionId`, `RoomNumber`, `Start`, `End`) VALUES
(1, 2, '2018-06-12', '2018-06-12'),
(17, 6, NULL, NULL),
(21, 4, NULL, NULL),
(22, 3, NULL, NULL),
(23, 1, NULL, NULL),
(25, 10, NULL, NULL),
(26, 9, NULL, NULL),
(28, 11, NULL, NULL),
(31, 8, NULL, NULL),
(32, 7, NULL, NULL),
(33, 15, NULL, NULL),
(34, 14, NULL, NULL),
(35, 13, NULL, NULL),
(36, 22, NULL, NULL),
(37, 12, NULL, NULL),
(39, 21, NULL, NULL),
(40, 5, NULL, NULL),
(41, 24, NULL, NULL),
(164, 23, NULL, NULL),
(168, 25, NULL, NULL),
(183, 27, NULL, NULL),
(196, 30, NULL, NULL),
(197, 29, NULL, NULL),
(198, 28, NULL, NULL),
(199, 26, NULL, NULL);

-- --------------------------------------------------------

--
-- Структура на таблица `roomtype`
--

CREATE TABLE `roomtype` (
  `RoomTypeId` int(11) NOT NULL,
  `Name` int(11) NOT NULL,
  `Price` int(11) NOT NULL,
  `NrOfExtraBeds` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `roomtype`
--

INSERT INTO `roomtype` (`RoomTypeId`, `Name`, `Price`, `NrOfExtraBeds`) VALUES
(1, 1, 1, 1),
(2, 2, 2, 2),
(3, 3, 3, 3);

-- --------------------------------------------------------

--
-- Структура на таблица `storagematerials`
--

CREATE TABLE `storagematerials` (
  `StorageMaterialId` int(11) NOT NULL,
  `Quantity` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `storagematerials`
--

INSERT INTO `storagematerials` (`StorageMaterialId`, `Quantity`) VALUES
(1, 4),
(2, 6),
(3, 3),
(4, 6);

-- --------------------------------------------------------

--
-- Структура на таблица `storageproducts`
--

CREATE TABLE `storageproducts` (
  `StorageProductId` int(11) NOT NULL,
  `Quantity` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `storageproducts`
--

INSERT INTO `storageproducts` (`StorageProductId`, `Quantity`) VALUES
(1, -7),
(2, 6),
(3, 19),
(4, 21),
(5, 20),
(6, 25),
(7, 26),
(8, 27),
(9, 0),
(10, 24),
(11, 26),
(12, 26),
(13, 21),
(14, 25),
(15, 28),
(16, 29),
(17, 20),
(18, 28),
(19, 28),
(20, 27),
(21, 27),
(22, 27),
(23, 26),
(24, 26),
(25, 30),
(26, 30),
(27, 30),
(28, 30),
(29, 30),
(30, 30),
(31, 30),
(32, 30),
(33, 30);

-- --------------------------------------------------------

--
-- Структура на таблица `test`
--

CREATE TABLE `test` (
  `Balance` int(123) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `test`
--

INSERT INTO `test` (`Balance`) VALUES
(2),
(4),
(20),
(50);

-- --------------------------------------------------------

--
-- Структура на таблица `transactions`
--

CREATE TABLE `transactions` (
  `TransactionId` int(11) NOT NULL,
  `Date` datetime DEFAULT NULL,
  `Amount` int(11) DEFAULT NULL,
  `CustomerId` int(11) NOT NULL,
  `EmployeeId` int(11) DEFAULT NULL,
  `ProductId` int(11) DEFAULT NULL,
  `MaterialTypeId` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Схема на данните от таблица `transactions`
--

INSERT INTO `transactions` (`TransactionId`, `Date`, `Amount`, `CustomerId`, `EmployeeId`, `ProductId`, `MaterialTypeId`) VALUES
(1, '2018-06-23 18:01:14', 10, 9, 1, NULL, NULL),
(17, NULL, NULL, 58, NULL, NULL, NULL),
(18, NULL, NULL, 59, NULL, NULL, NULL),
(19, NULL, NULL, 60, NULL, NULL, NULL),
(20, NULL, NULL, 61, NULL, NULL, NULL),
(21, NULL, NULL, 62, NULL, NULL, NULL),
(22, NULL, NULL, 63, NULL, NULL, NULL),
(23, NULL, NULL, 64, NULL, NULL, NULL),
(24, NULL, NULL, 65, NULL, NULL, NULL),
(25, NULL, NULL, 66, NULL, NULL, NULL),
(26, NULL, NULL, 67, NULL, NULL, NULL),
(28, NULL, NULL, 69, NULL, NULL, NULL),
(29, NULL, NULL, 70, NULL, NULL, NULL),
(30, NULL, NULL, 71, NULL, NULL, NULL),
(31, NULL, NULL, 72, NULL, NULL, NULL),
(32, NULL, NULL, 73, NULL, NULL, NULL),
(33, NULL, NULL, 74, NULL, NULL, NULL),
(34, NULL, NULL, 75, NULL, NULL, NULL),
(35, NULL, NULL, 76, NULL, NULL, NULL),
(36, NULL, NULL, 77, NULL, NULL, NULL),
(37, NULL, NULL, 78, NULL, NULL, NULL),
(38, NULL, NULL, 79, NULL, NULL, NULL),
(39, NULL, NULL, 80, NULL, NULL, NULL),
(40, NULL, NULL, 81, NULL, NULL, NULL),
(41, NULL, NULL, 82, NULL, NULL, NULL),
(42, '2018-06-23 18:01:14', 10, 9, 1, NULL, NULL),
(47, '2018-06-23 18:34:36', 3, 9, 1, NULL, NULL),
(60, '2018-06-23 18:57:13', 12, 9, 1, NULL, NULL),
(61, '2018-06-23 18:57:16', 12, 9, 1, NULL, NULL),
(62, '2018-06-23 18:59:28', 12, 9, 1, NULL, NULL),
(63, '2018-06-24 12:48:08', 4, 9, 1, NULL, NULL),
(64, '2018-06-24 12:48:12', 12, 9, 1, NULL, NULL),
(65, '2018-06-24 12:51:28', 12, 9, 1, NULL, NULL),
(66, '2018-06-24 12:51:31', 12, 9, 1, NULL, NULL),
(67, '2018-06-24 12:52:42', 11, 9, 1, NULL, NULL),
(68, '2018-06-24 12:55:54', 12, 9, 1, NULL, NULL),
(69, '2012-08-12 00:00:00', 12, 9, 1, NULL, NULL),
(70, '2012-08-12 00:00:00', 12, 9, 1, NULL, NULL),
(71, '2018-06-24 12:59:42', 12, 9, 1, NULL, NULL),
(72, '2018-06-24 12:59:46', 12, 9, 1, NULL, NULL),
(73, '2018-06-24 13:01:45', 11, 9, 1, NULL, NULL),
(74, '2018-06-24 13:01:47', 11, 9, 1, NULL, NULL),
(75, '2018-06-24 13:02:21', 12, 9, 1, NULL, NULL),
(76, '2018-06-24 13:02:23', 12, 9, 1, NULL, NULL),
(77, '2018-06-24 13:06:50', 12, 9, 1, NULL, NULL),
(78, '2018-06-24 13:06:52', 12, 9, 1, NULL, NULL),
(79, '2018-06-24 13:08:32', 12, 9, 1, NULL, NULL),
(85, '2018-06-24 13:11:09', 12, 9, 1, NULL, NULL),
(86, '2018-06-24 13:11:11', 12, 9, 1, NULL, NULL),
(87, '2018-06-24 13:13:00', 12, 9, 1, NULL, NULL),
(88, '2018-06-24 13:13:02', 12, 9, 1, NULL, NULL),
(89, '2018-06-24 13:13:53', 11, 9, 1, NULL, NULL),
(90, '2018-06-24 13:13:56', 11, 9, 1, NULL, NULL),
(91, '2018-06-24 13:16:01', 12, 9, 1, NULL, NULL),
(92, '2018-06-24 13:16:04', 12, 9, 1, NULL, NULL),
(93, '2018-06-24 13:19:53', 123, 9, 1, NULL, NULL),
(94, '2018-06-24 13:22:55', 12, 9, 1, NULL, NULL),
(95, '2018-06-24 13:22:57', 12, 9, 1, NULL, NULL),
(96, '2018-06-24 13:24:30', 12, 9, 1, NULL, NULL),
(97, '2018-06-24 13:33:24', 12, 9, 1, NULL, NULL),
(98, '2018-06-24 13:33:27', 12, 9, 1, NULL, NULL),
(99, '2018-06-24 13:33:29', 12, 9, 1, NULL, NULL),
(100, '2018-06-24 13:36:59', 12, 9, 1, NULL, NULL),
(101, '2018-06-24 13:37:01', 12, 9, 1, NULL, NULL),
(102, '2018-06-24 13:37:21', 12, 9, 1, NULL, NULL),
(103, '2018-06-24 13:37:24', 12, 9, 1, NULL, NULL),
(107, '2018-06-24 13:43:42', 123, 9, 1, NULL, NULL),
(110, '2018-06-24 13:51:46', 12, 9, 1, NULL, NULL),
(111, '2018-06-24 17:14:46', 1, 9, 1, NULL, NULL),
(112, '2018-06-24 17:16:30', 1, 9, 1, NULL, NULL),
(113, '2018-06-24 17:17:38', 1, 9, 1, NULL, NULL),
(114, '2018-06-24 17:18:05', 1, 9, 1, NULL, NULL),
(115, '2018-06-24 17:19:31', 1, 9, 1, NULL, NULL),
(116, '2018-06-24 17:20:38', 1, 9, 1, NULL, NULL),
(117, '2018-06-24 17:20:39', 1, 9, 1, NULL, NULL),
(118, '2018-06-24 17:23:07', 1, 9, 1, NULL, NULL),
(119, '2018-06-24 17:23:08', 1, 9, 1, NULL, NULL),
(120, '2018-06-24 17:27:17', 1, 9, 1, NULL, NULL),
(121, '2018-06-24 17:27:17', 1, 9, 1, NULL, NULL),
(122, '2018-06-24 20:34:00', 1, 9, 1, 2, NULL),
(123, '2018-06-24 20:37:06', 1, 9, 1, 2, NULL),
(124, '2018-06-24 20:46:49', 1, 9, 1, 2, NULL),
(125, '2018-06-24 21:21:01', 2, 9, 1, 4, NULL),
(126, '2018-06-24 21:21:03', 2, 9, 1, 6, NULL),
(127, '2018-06-24 21:21:04', 2, 9, 1, 17, NULL),
(128, '2018-06-24 21:21:05', 2, 9, 1, 14, NULL),
(129, '2018-06-24 23:33:37', 1, 9, 1, NULL, NULL),
(130, '2018-06-24 23:43:28', 1, 9, 1, NULL, NULL),
(131, '2018-06-24 23:43:31', 1, 9, 1, NULL, NULL),
(132, '2018-06-24 23:43:32', 1, 9, 1, NULL, NULL),
(133, '2018-06-24 23:45:30', 1, 9, 1, NULL, NULL),
(134, '2018-06-24 23:45:32', 1, 9, 1, NULL, NULL),
(135, '2018-06-24 23:45:33', 1, 9, 1, NULL, NULL),
(136, '2018-06-24 23:53:30', 1, 9, 1, NULL, NULL),
(137, '2018-06-24 23:53:31', 1, 9, 1, NULL, NULL),
(138, '2018-06-24 23:53:33', 1, 9, 1, NULL, NULL),
(139, '2018-06-24 23:55:41', 1, 9, 1, NULL, NULL),
(140, '2018-06-24 23:55:42', 1, 9, 1, NULL, NULL),
(141, '2018-06-24 23:58:02', 1, 9, 1, NULL, NULL),
(142, '2018-06-24 23:58:03', 1, 9, 1, NULL, NULL),
(143, '2018-06-24 23:58:49', 1, 9, 1, NULL, NULL),
(144, '2018-06-25 00:00:33', 1, 9, 1, NULL, NULL),
(145, '2018-06-25 00:00:33', 1, 9, 1, NULL, NULL),
(146, '2018-06-25 00:01:05', 1, 9, 1, NULL, NULL),
(147, '2018-06-25 00:01:06', 1, 9, 1, NULL, NULL),
(148, '2018-06-25 00:02:44', 1, 9, 1, NULL, NULL),
(149, '2018-06-25 00:02:47', 1, 9, 1, NULL, NULL),
(150, '2018-06-25 00:03:25', 1, 9, 1, NULL, NULL),
(151, '2018-06-25 00:06:18', 1, 9, 1, NULL, NULL),
(152, '2018-06-25 00:06:52', 1, 9, 1, NULL, NULL),
(153, '2018-06-25 00:07:19', 1, 9, 1, NULL, NULL),
(154, '2018-06-25 00:09:36', 1, 9, 1, NULL, NULL),
(155, '2018-06-25 00:11:53', 1, 9, 1, NULL, NULL),
(156, '2018-06-25 00:12:23', 1, 9, 1, NULL, NULL),
(157, '2018-06-25 00:20:49', 1, 9, 1, NULL, 3),
(158, '2018-06-25 11:38:43', 1, 9, 1, 1, NULL),
(159, '2018-06-25 11:38:44', 1, 9, 1, 2, NULL),
(160, NULL, NULL, 83, NULL, NULL, NULL),
(161, NULL, NULL, 84, NULL, NULL, NULL),
(162, NULL, NULL, 85, NULL, NULL, NULL),
(163, NULL, NULL, 86, NULL, NULL, NULL),
(164, NULL, NULL, 87, NULL, NULL, NULL),
(165, NULL, NULL, 88, NULL, NULL, NULL),
(166, NULL, NULL, 89, NULL, NULL, NULL),
(167, NULL, NULL, 90, NULL, NULL, NULL),
(168, NULL, NULL, 91, NULL, NULL, NULL),
(169, NULL, NULL, 92, NULL, NULL, NULL),
(170, NULL, NULL, 93, NULL, NULL, NULL),
(171, '2018-06-26 23:58:53', 1, 9, 1, NULL, 1),
(172, '2018-06-26 23:59:32', 1, 9, 1, NULL, 3),
(173, '2018-06-27 00:05:11', 1, 9, 1, NULL, 1),
(174, '2018-06-27 00:06:45', 1, 9, 1, 1, NULL),
(175, '2018-06-27 00:08:22', 1, 9, 1, NULL, 1),
(176, '2018-06-27 00:10:12', 1, 9, 1, 1, NULL),
(177, '2018-06-27 00:10:12', 1, 9, 1, 1, NULL),
(178, '2018-06-27 00:17:57', 1, 9, 1, 1, NULL),
(179, '2018-06-27 00:17:57', 1, 9, 1, 1, NULL),
(180, '2018-06-27 00:20:20', 1, 9, 1, 1, NULL),
(181, '2018-06-27 00:25:14', 1, 9, 1, 1, NULL),
(182, '2018-06-27 00:26:15', 100, 9, 1, NULL, NULL),
(183, NULL, NULL, 94, NULL, NULL, NULL),
(184, '2018-06-27 08:25:36', 1, 9, 2, 2, NULL),
(185, '2018-06-27 08:25:36', 1, 9, 2, 2, NULL),
(186, '2018-06-27 08:26:25', 1, 9, 1, 10, NULL),
(187, '2018-06-27 08:26:26', 1, 9, 1, 9, NULL),
(188, '2018-06-27 08:28:24', 1, 9, 1, 5, NULL),
(189, '2018-06-27 08:28:24', 1, 9, 1, 5, NULL),
(190, '2018-06-27 08:31:03', 1, 9, 1, 9, NULL),
(191, '2018-06-27 08:31:03', 1, 9, 1, 9, NULL),
(192, '2018-06-27 08:31:13', 1, 9, 1, NULL, 2),
(193, '2018-06-27 08:31:14', 1, 9, 1, NULL, 2),
(194, '2018-06-27 08:38:10', 1, 9, 1, 9, NULL),
(195, '2018-06-27 08:38:11', 1, 9, 1, 9, NULL),
(196, NULL, NULL, 95, NULL, NULL, NULL),
(197, NULL, NULL, 96, NULL, NULL, NULL),
(198, NULL, NULL, 97, NULL, NULL, NULL),
(199, NULL, NULL, 98, NULL, NULL, NULL),
(200, '2018-06-27 10:38:28', 1, 9, 1, 1, NULL),
(201, '2018-06-27 10:38:29', 1, 9, 1, 4, NULL),
(202, '2018-06-27 10:38:34', 1, 9, 1, 9, NULL),
(203, '2018-06-27 10:38:40', 5, 9, 1, 9, NULL),
(204, '2018-06-27 10:40:16', 1, 9, 1, NULL, 1),
(205, '2018-06-27 10:45:47', 12, 9, 1, NULL, NULL),
(206, '2018-06-27 10:45:50', 12, 9, 1, NULL, NULL),
(207, '2018-06-27 10:45:54', 12, 9, 1, NULL, NULL),
(208, '2018-06-27 10:53:31', 1, 9, 1, 9, NULL),
(209, '2018-06-27 10:53:31', 1, 9, 1, 9, NULL),
(210, '2018-06-27 10:53:31', 1, 9, 1, 9, NULL),
(211, '2018-06-27 10:53:32', 1, 9, 1, 9, NULL),
(212, '2018-06-27 10:53:32', 1, 9, 1, 9, NULL),
(213, NULL, NULL, 99, NULL, NULL, NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `alert`
--
ALTER TABLE `alert`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`CustomerId`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`EmployeeId`);

--
-- Indexes for table `extrabed`
--
ALTER TABLE `extrabed`
  ADD PRIMARY KEY (`CustomerId`,`RoomNumber`),
  ADD KEY `CustomerId` (`CustomerId`),
  ADD KEY `RoomNumber` (`RoomNumber`);

--
-- Indexes for table `loan`
--
ALTER TABLE `loan`
  ADD PRIMARY KEY (`LoanId`,`Date`),
  ADD KEY `TransactionId` (`TransactionId`);

--
-- Indexes for table `material`
--
ALTER TABLE `material`
  ADD PRIMARY KEY (`MaterialID`),
  ADD KEY `LoanId` (`LoanId`),
  ADD KEY `MaterialTypeId` (`MaterialTypeId`),
  ADD KEY `StorageMaterialId` (`StorageMaterialId`);

--
-- Indexes for table `materialtype`
--
ALTER TABLE `materialtype`
  ADD PRIMARY KEY (`MaterialTypeId`);

--
-- Indexes for table `moneydeposit`
--
ALTER TABLE `moneydeposit`
  ADD PRIMARY KEY (`TransactionId`),
  ADD UNIQUE KEY `TransactionId_2` (`TransactionId`),
  ADD KEY `TransactionId` (`TransactionId`);

--
-- Indexes for table `pma__bookmark`
--
ALTER TABLE `pma__bookmark`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `pma__central_columns`
--
ALTER TABLE `pma__central_columns`
  ADD PRIMARY KEY (`db_name`,`col_name`);

--
-- Indexes for table `pma__column_info`
--
ALTER TABLE `pma__column_info`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `db_name` (`db_name`,`table_name`,`column_name`);

--
-- Indexes for table `pma__designer_settings`
--
ALTER TABLE `pma__designer_settings`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__export_templates`
--
ALTER TABLE `pma__export_templates`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `u_user_type_template` (`username`,`export_type`,`template_name`);

--
-- Indexes for table `pma__favorite`
--
ALTER TABLE `pma__favorite`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__history`
--
ALTER TABLE `pma__history`
  ADD PRIMARY KEY (`id`),
  ADD KEY `username` (`username`,`db`,`table`,`timevalue`);

--
-- Indexes for table `pma__navigationhiding`
--
ALTER TABLE `pma__navigationhiding`
  ADD PRIMARY KEY (`username`,`item_name`,`item_type`,`db_name`,`table_name`);

--
-- Indexes for table `pma__pdf_pages`
--
ALTER TABLE `pma__pdf_pages`
  ADD PRIMARY KEY (`page_nr`),
  ADD KEY `db_name` (`db_name`);

--
-- Indexes for table `pma__recent`
--
ALTER TABLE `pma__recent`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__relation`
--
ALTER TABLE `pma__relation`
  ADD PRIMARY KEY (`master_db`,`master_table`,`master_field`),
  ADD KEY `foreign_field` (`foreign_db`,`foreign_table`);

--
-- Indexes for table `pma__savedsearches`
--
ALTER TABLE `pma__savedsearches`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `u_savedsearches_username_dbname` (`username`,`db_name`,`search_name`);

--
-- Indexes for table `pma__table_coords`
--
ALTER TABLE `pma__table_coords`
  ADD PRIMARY KEY (`db_name`,`table_name`,`pdf_page_number`);

--
-- Indexes for table `pma__table_info`
--
ALTER TABLE `pma__table_info`
  ADD PRIMARY KEY (`db_name`,`table_name`);

--
-- Indexes for table `pma__table_uiprefs`
--
ALTER TABLE `pma__table_uiprefs`
  ADD PRIMARY KEY (`username`,`db_name`,`table_name`);

--
-- Indexes for table `pma__tracking`
--
ALTER TABLE `pma__tracking`
  ADD PRIMARY KEY (`db_name`,`table_name`,`version`);

--
-- Indexes for table `pma__userconfig`
--
ALTER TABLE `pma__userconfig`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `pma__usergroups`
--
ALTER TABLE `pma__usergroups`
  ADD PRIMARY KEY (`usergroup`,`tab`,`allowed`);

--
-- Indexes for table `pma__users`
--
ALTER TABLE `pma__users`
  ADD PRIMARY KEY (`username`,`usergroup`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductId`),
  ADD KEY `StorageId` (`StorageProductId`),
  ADD KEY `StorageProductId` (`StorageProductId`);

--
-- Indexes for table `productorder`
--
ALTER TABLE `productorder`
  ADD PRIMARY KEY (`ProductOrderId`),
  ADD KEY `TransactionId` (`TransactionId`);

--
-- Indexes for table `productorderlines`
--
ALTER TABLE `productorderlines`
  ADD PRIMARY KEY (`ProductOrderLineId`),
  ADD KEY `ProductOrderId` (`ProductOrderId`),
  ADD KEY `ProductId` (`ProductId`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`RoomNumber`),
  ADD KEY `RoomTypeId` (`RoomTypeId`);

--
-- Indexes for table `roomreservation`
--
ALTER TABLE `roomreservation`
  ADD PRIMARY KEY (`TransactionId`),
  ADD KEY `RoomNumber` (`RoomNumber`),
  ADD KEY `TransactionId` (`TransactionId`);

--
-- Indexes for table `roomtype`
--
ALTER TABLE `roomtype`
  ADD PRIMARY KEY (`RoomTypeId`);

--
-- Indexes for table `storagematerials`
--
ALTER TABLE `storagematerials`
  ADD PRIMARY KEY (`StorageMaterialId`);

--
-- Indexes for table `storageproducts`
--
ALTER TABLE `storageproducts`
  ADD PRIMARY KEY (`StorageProductId`);

--
-- Indexes for table `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`TransactionId`),
  ADD KEY `fk_Transactions_eventaccount1_idx` (`CustomerId`),
  ADD KEY `fk_Transactions_Employee1_idx` (`EmployeeId`),
  ADD KEY `eventaccount_EventAccountId` (`CustomerId`,`EmployeeId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `alert`
--
ALTER TABLE `alert`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `CustomerId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=100;
--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `EmployeeId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `material`
--
ALTER TABLE `material`
  MODIFY `MaterialID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `materialtype`
--
ALTER TABLE `materialtype`
  MODIFY `MaterialTypeId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `pma__bookmark`
--
ALTER TABLE `pma__bookmark`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pma__column_info`
--
ALTER TABLE `pma__column_info`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pma__export_templates`
--
ALTER TABLE `pma__export_templates`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `pma__history`
--
ALTER TABLE `pma__history`
  MODIFY `id` bigint(20) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `pma__pdf_pages`
--
ALTER TABLE `pma__pdf_pages`
  MODIFY `page_nr` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `pma__savedsearches`
--
ALTER TABLE `pma__savedsearches`
  MODIFY `id` int(5) UNSIGNED NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `ProductId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;
--
-- AUTO_INCREMENT for table `productorder`
--
ALTER TABLE `productorder`
  MODIFY `ProductOrderId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
--
-- AUTO_INCREMENT for table `productorderlines`
--
ALTER TABLE `productorderlines`
  MODIFY `ProductOrderLineId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=534;
--
-- AUTO_INCREMENT for table `room`
--
ALTER TABLE `room`
  MODIFY `RoomNumber` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;
--
-- AUTO_INCREMENT for table `roomtype`
--
ALTER TABLE `roomtype`
  MODIFY `RoomTypeId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `storagematerials`
--
ALTER TABLE `storagematerials`
  MODIFY `StorageMaterialId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `storageproducts`
--
ALTER TABLE `storageproducts`
  MODIFY `StorageProductId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;
--
-- AUTO_INCREMENT for table `transactions`
--
ALTER TABLE `transactions`
  MODIFY `TransactionId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=214;
--
-- Ограничения за дъмпнати таблици
--

--
-- Ограничения за таблица `extrabed`
--
ALTER TABLE `extrabed`
  ADD CONSTRAINT `extrabed_ibfk_2` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`CustomerId`),
  ADD CONSTRAINT `extrabed_ibfk_3` FOREIGN KEY (`RoomNumber`) REFERENCES `room` (`RoomNumber`);

--
-- Ограничения за таблица `loan`
--
ALTER TABLE `loan`
  ADD CONSTRAINT `loan_ibfk_1` FOREIGN KEY (`TransactionId`) REFERENCES `transactions` (`TransactionId`);

--
-- Ограничения за таблица `material`
--
ALTER TABLE `material`
  ADD CONSTRAINT `material_ibfk_2` FOREIGN KEY (`MaterialTypeId`) REFERENCES `materialtype` (`MaterialTypeId`),
  ADD CONSTRAINT `material_ibfk_3` FOREIGN KEY (`StorageMaterialId`) REFERENCES `storagematerials` (`StorageMaterialId`),
  ADD CONSTRAINT `material_ibfk_4` FOREIGN KEY (`LoanId`) REFERENCES `loan` (`LoanId`);

--
-- Ограничения за таблица `moneydeposit`
--
ALTER TABLE `moneydeposit`
  ADD CONSTRAINT `moneydeposit_ibfk_2` FOREIGN KEY (`TransactionId`) REFERENCES `transactions` (`TransactionId`);

--
-- Ограничения за таблица `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`StorageProductId`) REFERENCES `storageproducts` (`StorageProductId`);

--
-- Ограничения за таблица `productorder`
--
ALTER TABLE `productorder`
  ADD CONSTRAINT `productorder_ibfk_1` FOREIGN KEY (`TransactionId`) REFERENCES `transactions` (`TransactionId`);

--
-- Ограничения за таблица `productorderlines`
--
ALTER TABLE `productorderlines`
  ADD CONSTRAINT `productorderlines_ibfk_1` FOREIGN KEY (`ProductId`) REFERENCES `product` (`ProductId`),
  ADD CONSTRAINT `productorderlines_ibfk_2` FOREIGN KEY (`ProductOrderId`) REFERENCES `productorder` (`ProductOrderId`);

--
-- Ограничения за таблица `room`
--
ALTER TABLE `room`
  ADD CONSTRAINT `room_ibfk_1` FOREIGN KEY (`RoomTypeId`) REFERENCES `roomtype` (`RoomTypeId`);

--
-- Ограничения за таблица `roomreservation`
--
ALTER TABLE `roomreservation`
  ADD CONSTRAINT `roomreservation_ibfk_1` FOREIGN KEY (`TransactionId`) REFERENCES `transactions` (`TransactionId`),
  ADD CONSTRAINT `roomreservation_ibfk_2` FOREIGN KEY (`RoomNumber`) REFERENCES `room` (`RoomNumber`);

--
-- Ограничения за таблица `transactions`
--
ALTER TABLE `transactions`
  ADD CONSTRAINT `fk_Transactions_Employee1` FOREIGN KEY (`EmployeeId`) REFERENCES `employee` (`EmployeeId`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `transactions_ibfk_1` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`CustomerId`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
