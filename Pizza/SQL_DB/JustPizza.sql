-- Adminer 4.8.1 MySQL 8.0.30 dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

SET NAMES utf8mb4;

CREATE DATABASE `JustPizza`;
USE `JustPizza`;

CREATE TABLE `cart` (
  `user_id` varchar(100) NOT NULL,
  `product_id` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `cart` (`user_id`, `product_id`) VALUES
('1',	'1'),
('1',	'2'),
('1',	'3');

CREATE TABLE `Products` (
  `ProductID` int NOT NULL AUTO_INCREMENT,
  `ProductName` varchar(100) DEFAULT NULL,
  `ProductPrice` varchar(100) DEFAULT NULL,
  `ProductImage` varchar(255) DEFAULT NULL,
  `ProductIType` int DEFAULT NULL,
  PRIMARY KEY (`ProductID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `Products` (`ProductID`, `ProductName`, `ProductPrice`, `ProductImage`, `ProductIType`) VALUES
(3,	'Товар 3',	'39.99',	'1.png',	1000),
(4,	'Товар 1',	'19.99',	'3.png',	1000),
(5,	'Товар 2',	'29.99',	'4.png',	1000),
(6,	'Товар 3',	'39.99',	'5.png',	1000),
(7,	'Товар 1',	'19.99',	'6.png',	1000),
(8,	'Товар 2',	'29.99',	'7.png',	1000),
(9,	'Товар 3',	'39.99',	'8.png',	1000),
(26,	'Яблочный коктель',	'12.44',	'k3.png',	1200),
(27,	'Банановый коктель',	'15.44',	'k1.png',	1200),
(28,	'Клубничный коктель',	'16.44',	'k2.png',	1200);

CREATE TABLE `users` (
  `id` int unsigned NOT NULL AUTO_INCREMENT,
  `login` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `email` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '',
  `phone` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '',
  `password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `isAdmin` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `users` (`id`, `login`, `email`, `phone`, `password`, `isAdmin`) VALUES
(1,	'just',	'',	'',	'211212',	1),
(2,	'qeqw',	'qeqw',	'qweq',	'qwe',	0),
(3,	'123123',	'123123',	'123123',	'123123',	0),
(4,	'sdsfsd',	'assdas',	'dsdf',	'dasd',	0),
(5,	'12312',	'12312',	'12312',	'1231',	0),
(6,	'sdasd',	'DASDAS',	'sdasdas',	'dasdasda',	0),
(7,	'2342',	'234',	'qq',	'1231',	0),
(8,	'2342',	'234das',	'qq',	'211212',	0),
(9,	'morv',	'qweqw@gmail.com',	'772312123',	'211212',	0),
(11,	'',	'',	'',	'',	0);

-- 2024-01-04 04:57:04
