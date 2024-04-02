-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th10 02, 2021 lúc 04:52 PM
-- Phiên bản máy phục vụ: 10.4.18-MariaDB
-- Phiên bản PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `dbxoso`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `savexoso`
--

CREATE TABLE `savexoso` (
  `idXoso` int(13) NOT NULL,
  `daiXoso` varchar(255) NOT NULL,
  `ngayXoso` varchar(255) NOT NULL,
  `giaveXoso` varchar(255) NOT NULL,
  `ketquaXoso` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `savexoso`
--

INSERT INTO `savexoso` (`idXoso`, `daiXoso`, `ngayXoso`, `giaveXoso`, `ketquaXoso`) VALUES
(5, 'Khánh Hòa', 'Saturday, October 2, 2021', '3.000 VNĐ', '68,180,6879,2834,2537,7502,25772,85422,82456,32106,82855,42504,49539,99288,59937,09687,06611,562614,'),
(6, 'Kon Tum', 'Saturday, October 2, 2021', '3.000 VNĐ', '63,221,7019,2819,2917,7716,35171,83166,84145,42141,90137,48134,49112,97108,55105,13102,14080,620771,'),
(7, 'Đắc Lắc', 'Saturday, October 2, 2021', '5.000 VNĐ', '56,168,6651,6354,5043,5746,07115,67864,17513,14548,64297,24847,74596,71521,31270,81929,31678,386036,'),
(8, 'Quảng Ngãi', 'Saturday, October 2, 2021', '10.000 VNĐ', '60,192,6720,6818,5847,5945,17453,65449,23446,24424,72420,30417,78412,79391,37387,85383,43380,443592,');

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `savexoso`
--
ALTER TABLE `savexoso`
  ADD PRIMARY KEY (`idXoso`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `savexoso`
--
ALTER TABLE `savexoso`
  MODIFY `idXoso` int(13) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
