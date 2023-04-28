-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Ápr 28. 11:19
-- Kiszolgáló verziója: 10.4.27-MariaDB
-- PHP verzió: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `munkaidonyilvantarto`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `alkalmazottak_adatai`
--

CREATE TABLE `alkalmazottak_adatai` (
  `Id` int(11) NOT NULL,
  `Nev` varchar(30) NOT NULL,
  `Cim` varchar(255) NOT NULL,
  `Nem` varchar(255) NOT NULL,
  `Pozicio` varchar(255) NOT NULL,
  `Szuletesidatum` date NOT NULL,
  `Telefonszam` varchar(255) NOT NULL,
  `Napifizetese` int(255) NOT NULL,
  `aktiv` enum('true','false') NOT NULL DEFAULT 'true'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `alkalmazottak_adatai`
--

INSERT INTO `alkalmazottak_adatai` (`Id`, `Nev`, `Cim`, `Nem`, `Pozicio`, `Szuletesidatum`, `Telefonszam`, `Napifizetese`, `aktiv`) VALUES
(44, 'Nagy Gábor', 'Debrecen Domonkos Lajos u. 45', 'Férfi', 'Segédmunkás', '2023-03-16', '06543234432', 11000, 'true'),
(46, 'Budai Gergő', 'Debrecen Kossuth 33', '', 'Szakmunkás', '1989-12-28', '06306746487', 10000, 'false'),
(47, 'Kiss Jenő', 'BudapestSzéchenyi 44', 'Férfi', 'Szakmunkás', '2001-12-28', '0675742758', 30000, 'true'),
(48, 'Rácz Lili', 'Debrecen', 'Nő', 'Főnök', '2006-11-24', '06407846746', 40000, 'false'),
(49, 'Somogyi Csongor', 'Román', 'Nő', 'Segédmunkás', '2004-08-14', '413245324', 13000, 'false'),
(50, 'Kovács Jenő', 'Budapest József Attila u. 26', 'Férfi', 'főnök', '2001-12-28', '06757427587', 30000, 'true'),
(73, 'Kovács Jenő', 'BudapestSzéchenyi 44', 'Nő', 'főnök', '2001-12-28', '0675742758', 30000, 'false'),
(74, 'Somogyi Csongor', 'Románia', 'Nő', 'Segédmunkás', '2004-08-14', '413245324', 13000, 'false'),
(75, 'Kovács Róbert', 'BudapestSzéchenyi 44', 'Férfi', 'Szakmunkás', '1998-12-28', '06757427587', 30000, 'true'),
(76, 'Varga Mate', 'Mateszalka', 'Férfi', 'Raktáros', '2005-03-20', '05952455525', 10000, 'false'),
(79, 'Kovács Gabi', 'Budapest', 'Nő', 'Portás', '1989-12-28', '06733473482', 30000, 'false'),
(80, 'Nagy Sándor', 'Debrecen Vámospércsi út 43', 'Férfi', 'Portás', '1999-02-23', '065433456', 11000, 'true'),
(81, 'Kovács Jenő', 'BudapestSzéchenyi 44', 'Nő', 'főnök', '2001-12-28', '06757427587', 30000, 'false');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jelenletiiv`
--

CREATE TABLE `jelenletiiv` (
  `Id` int(55) NOT NULL,
  `datum` date NOT NULL,
  `jelenlet` varchar(55) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `jelenletiiv`
--

INSERT INTO `jelenletiiv` (`Id`, `datum`, `jelenlet`) VALUES
(44, '2023-03-28', 'Megjelent'),
(44, '2023-03-31', 'Megjelent'),
(44, '2023-04-28', 'Megjelent'),
(44, '2023-04-30', 'Megjelent'),
(47, '2023-01-11', 'Megjelent'),
(47, '2023-01-12', 'Megjelent'),
(47, '2023-01-14', 'Megjelent'),
(47, '2023-01-15', 'Táppénz'),
(47, '2023-01-16', 'Megjelent'),
(47, '2023-03-28', 'Megjelent'),
(47, '2023-03-31', 'Megjelent'),
(47, '2023-04-11', 'Megjelent'),
(47, '2023-04-15', 'Megjelent'),
(47, '2023-04-16', 'Megjelent'),
(47, '2023-04-17', 'Megjelent'),
(47, '2023-04-28', 'Megjelent'),
(49, '2023-03-28', 'Megjelent'),
(49, '2023-03-31', 'Megjelent'),
(50, '2021-04-30', 'Táppénz'),
(50, '2023-01-15', 'Táppénz'),
(50, '2023-03-27', 'Megjelent'),
(50, '2023-03-28', 'Megjelent'),
(50, '2023-03-31', 'Megjelent'),
(50, '2023-04-02', 'Megjelent'),
(50, '2023-04-28', 'Igazolatlan távollét'),
(50, '2023-04-30', 'Megjelent'),
(50, '2025-03-31', 'Megjelent'),
(75, '2023-03-28', 'Megjelent'),
(75, '2023-03-31', 'Megjelent'),
(75, '2023-04-28', 'Igazolatlan távollét'),
(75, '2023-04-29', 'Megjelent'),
(75, '2023-04-30', 'Megjelent'),
(80, '2023-04-28', 'Igazolatlan távollét');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `login`
--

CREATE TABLE `login` (
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `login`
--

INSERT INTO `login` (`username`, `password`) VALUES
('user', 'user');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `alkalmazottak_adatai`
--
ALTER TABLE `alkalmazottak_adatai`
  ADD PRIMARY KEY (`Id`);

--
-- A tábla indexei `jelenletiiv`
--
ALTER TABLE `jelenletiiv`
  ADD UNIQUE KEY `Id` (`Id`,`datum`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `alkalmazottak_adatai`
--
ALTER TABLE `alkalmazottak_adatai`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=83;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `jelenletiiv`
--
ALTER TABLE `jelenletiiv`
  ADD CONSTRAINT `fk_alkalmazott_jelenlet` FOREIGN KEY (`Id`) REFERENCES `alkalmazottak_adatai` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
