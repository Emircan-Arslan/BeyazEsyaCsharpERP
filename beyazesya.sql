-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 04 May 2018, 08:30:23
-- Sunucu sürümü: 5.7.19
-- PHP Sürümü: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `beyazesya`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `admin`
--

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ad` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `soyad` varchar(40) COLLATE utf8_turkish_ci NOT NULL,
  `k` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `sifre` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `eposta` varchar(300) COLLATE utf8_turkish_ci NOT NULL,
  `tel` varchar(20) COLLATE utf8_turkish_ci NOT NULL,
  `ıl` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `ılce` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `sempt` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `admin`
--

INSERT INTO `admin` (`id`, `ad`, `soyad`, `k`, `sifre`, `eposta`, `tel`, `ıl`, `ılce`, `sempt`) VALUES
(1, 'emir', 'arslan', 'yetkili', '123456', 'admin@hotmail.com', '555555555', 'istanbul', 'esenler', 'esenler');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteri`
--

DROP TABLE IF EXISTS `musteri`;
CREATE TABLE IF NOT EXISTS `musteri` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `mad` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `msoyad` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `mtel` varchar(15) COLLATE utf8_turkish_ci NOT NULL,
  `mil` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `milce` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `msemt` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `musteri`
--

INSERT INTO `musteri` (`id`, `mad`, `msoyad`, `mtel`, `mil`, `milce`, `msemt`) VALUES
(4, 'emre', 'ak', '12545245654', 'istanbul', 'esenler', 'esenler');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `satis`
--

DROP TABLE IF EXISTS `satis`;
CREATE TABLE IF NOT EXISTS `satis` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `umodel` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  `adet` int(11) NOT NULL,
  `ufiyat` int(11) NOT NULL,
  `mtel` varchar(20) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `satis`
--

INSERT INTO `satis` (`id`, `umodel`, `adet`, `ufiyat`, `mtel`) VALUES
(1, 'camasira3443', 1, 2000, '5'),
(2, 'setustubekoa', 5, 10000, '12545245654');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `urun`
--

DROP TABLE IF EXISTS `urun`;
CREATE TABLE IF NOT EXISTS `urun` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `utur` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `marka` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `esinif` varchar(10) COLLATE utf8_turkish_ci NOT NULL,
  `ureng` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `model` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `fiyat` int(100) NOT NULL,
  `yukseklik` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `derinlik` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `genislik` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `hacim` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `adet` int(11) NOT NULL,
  `resim` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  `date` varchar(150) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=50 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `urun`
--

INSERT INTO `urun` (`id`, `utur`, `marka`, `esinif`, `ureng`, `model`, `fiyat`, `yukseklik`, `derinlik`, `genislik`, `hacim`, `adet`, `resim`, `date`) VALUES
(22, 'BUZDOLABI', 'Vestel', 'A', 'Beyaz', 'BuVesABeyaz', 3800, '170', '72', '70', '450', 2, 'resimler2/buzdolabi1.jpg', '2018-05-04 11:19:51.876111'),
(32, 'bulasikmakinesi', 'Arçelik', 'A+', 'Beyaz', 'bulasikbeyaz', 1000, '55', '55', '55', '60', 3, 'resimler2/bulasikmak3.jpg', '2018-05-04 11:19:51.876111'),
(33, 'setustuocak', 'Beko', 'A', 'SIYAH', 'setustu', 500, '20', '20', '20', '20', 21, 'resimler2/setustu3.jpg', '2018-05-04 11:19:51.876111'),
(36, 'solofirin', 'vestel', 'B', 'Beyaz', 'solo', 2000, '50', '50', '50', '50', 51, 'resimler2/solofirin3.jpg', '2018-05-04 11:19:51.876111'),
(38, 'Buz Dolaplari', 'Beko', 'B', 'BEYAZ', 'dasdasd', 3000, '656', '5656', '56', '565', 65, 'resimler2/camasirmak1.jpg', '2018-05-04 11:19:51.876111'),
(47, 'Buz Dolaplari', 'Beko', 'A+', 'BEYAZ', 'beyaza', 2500, '170', '70', '70', '250', 1, 'resimler2/buzdolai4.jpg', '2018-05-04 11:19:51.876111'),
(49, 'Set Üstü Ocak', 'Beko', 'A+', 'GRI', 'setustubekoa', 2050, '30', '', '70', '', 101, 'setustuu1.jpg', '2018-05-04 11:19:51.876111');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `uye`
--

DROP TABLE IF EXISTS `uye`;
CREATE TABLE IF NOT EXISTS `uye` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ad` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `soyad` varchar(40) COLLATE utf8_turkish_ci NOT NULL,
  `k` varchar(50) COLLATE utf8_turkish_ci NOT NULL,
  `sifre` varchar(30) COLLATE utf8_turkish_ci NOT NULL,
  `eposta` varchar(100) COLLATE utf8_turkish_ci NOT NULL,
  `telno` varchar(20) COLLATE utf8_turkish_ci NOT NULL,
  `adres` varchar(300) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `uye`
--

INSERT INTO `uye` (`id`, `ad`, `soyad`, `k`, `sifre`, `eposta`, `telno`, `adres`) VALUES
(1, 'Emircan', 'Arslan', 'emircanarslan', '123456', 'emir@hotmail.com', '12313', 'qweqwe'),
(2, 'asa', 'asda', 'emircanarslan', 'asd', 'ada@hotmail.com', '34', 'sdfsdf'),
(6, 'resuk', 'tuna', 'r', '123', 'r@hotmail.com', '05345215452', 'asdasd'),
(7, 'emir', 'arslan', 'ea', '123', 'ea@hotmail.com', '05345201265', ''),
(8, 'jhjh', 'JHJH', 'erer', 'kjjj', 'wrwr@hotmail.com', '6565656', '');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
