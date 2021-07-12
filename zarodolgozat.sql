-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2021. Ápr 20. 15:54
-- Kiszolgáló verziója: 10.4.17-MariaDB
-- PHP verzió: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `zarodolgozat`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `cart`
--

CREATE TABLE `cart` (
  `ID` int(11) NOT NULL,
  `Name` varchar(70) COLLATE utf8_hungarian_ci NOT NULL,
  `Role` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `Quantity` int(5) NOT NULL,
  `Price` int(7) NOT NULL,
  `Faction` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `Picture` varchar(50) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `cart`
--

INSERT INTO `cart` (`ID`, `Name`, `Role`, `Quantity`, `Price`, `Faction`, `Picture`) VALUES
(1, 'Land Raider\r\n', 'Heavy_Support', 4, 65, 'Space Marines', 'Land_Raider.jpg');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `orders`
--

CREATE TABLE `orders` (
  `OrderID` int(11) NOT NULL,
  `CustomerName` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `Email` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `PhoneNumber` bigint(20) NOT NULL,
  `Address` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `PaymentMethod` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `TimeOfOrder` date NOT NULL,
  `Content` varchar(200) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `orders`
--

INSERT INTO `orders` (`OrderID`, `CustomerName`, `Email`, `PhoneNumber`, `Address`, `PaymentMethod`, `TimeOfOrder`, `Content`) VALUES
(1, 'Nagy János', 'NJ@gmail.com', 6203004060, 'Szeged Teréz krt. 77.', 'Cash on Delivery', '2021-01-01', '2x C\'tan Shard of the Void Dragon;\r\n2x Stormraven Gunship'),
(2, 'Jill Bernard', 'JillBern@gmail.com', 6203004080, 'Szeged Teréz krt. 67.', 'Paid in Advance', '2021-01-07', '3x Doom Scythe; '),
(3, 'Tonicha Joyner', 'TonJoy@gmail.com', 6773002010, 'Nánási út 80.', 'Cash on Delivery', '2021-01-03', '1x Commander Farsight;4x Pathfinder Team'),
(4, 'Soós Vince', 'Vin@gmail.com', 6802004455, 'Erzsébet tér 90.', 'Paid in Advance', '2021-01-02', '1x Belisarius Cawl; 2x Skitarii Rangers'),
(5, 'Bernát Zágon', 'Bernat33@gmail.com', 6308003355, 'Erzsébet tér 44.', 'Cash on Delivery', '2020-12-30', '1x Space Marine Commander; 3x Primaris Intercessors\r\n'),
(6, 'Rác Endre', 'Endree78@gmail.com', 6703824460, 'Wesselényi u. 89.', 'Cash on Delivery', '2021-01-07', '4x Deathmarks;'),
(7, 'Ács Lukacs', 'AcsLukacs@jourrapide.com', 6994446655, 'Hegyalja út 50.', 'Cash on Delivery', '2021-01-01', '1x Kayvaan Shrike;2x Land Raider'),
(8, 'Csordás Sandor', 'CsordasSandor@rhyta.com', 6884005555, 'Izabella u. 91.', 'Paid in Advance', '2020-12-29', '1x Kayvaan Shrike;2x Land Raider'),
(9, 'Sinko Csilla', 'SinkCS@gmail.com', 6504000223, 'Erzsébet krt. 62.', 'Paid in Advance', '2021-01-12', '2x Stormraven Gunship;2x Trazyn the Infinite'),
(10, 'Benkó Gabriella', 'BenkoG@gmail.com', 6405552030, 'Apor Péter u. 6.', 'Cash on Delivery', '2021-01-11', '1x Skitarii Rangers;5xDoom Scythe'),
(11, 'Sallai Ádám', 'Sall@gmail.com', 6203504560, 'Wesselényi u. 8.', 'Cash on Delivery', '2021-01-10', '1x Vargard Obyron;2x Trazyn the Infinite'),
(12, 'Bakó Barnabás', 'BakoBarn@gmail.com', 6894246645, 'Nyár utca 98.', 'Cash on Delivery', '2021-01-02', '2x C\'tan Shard of the Void Dragon;'),
(13, 'Donko Lehel', 'Danko@gmail.com', 644433399, 'Dózsa György út 95.', 'Paid in Advance', '2021-01-11', '1x KV128 Stormsurge;'),
(14, 'Buday Károly', 'Buday@gmail.com', 6874435677, 'Kossuth Lajos u. 66.', 'Cash on Delivery', '2021-01-03', '3x Pathfinder Team;'),
(15, 'Solvar Solvarin', 'Solvar@gmail.com', 688999510, 'Király u. 13.', 'Paid in Advance', '2021-01-05', '2x Belisarius Cawl;2x Trazyn the Infinite');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `products`
--

CREATE TABLE `products` (
  `ID` int(11) NOT NULL,
  `Name` varchar(70) COLLATE utf8_hungarian_ci NOT NULL,
  `Role` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `Quantity` int(5) NOT NULL,
  `Price` int(7) NOT NULL,
  `Faction` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `Picture` varchar(50) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `products`
--

INSERT INTO `products` (`ID`, `Name`, `Role`, `Quantity`, `Price`, `Faction`, `Picture`) VALUES
(1, 'Land Raider\r\n', 'Heavy_Support', 4, 65, 'Space Marines', 'Land_Raider.jpg'),
(2, 'Stormraven Gunship', 'Flyer', 2, 83, 'Space Marines', 'Stormraven_Gunship.jpg'),
(3, 'Primaris Intercessors', 'Troops', 10, 25, 'Space Marines', 'Primaris_Intercessors.jpg'),
(4, 'Space Marine Commander', 'HQ', 7, 20, 'Space Marines', 'Space_Marine_Commander.jpg'),
(5, 'Kayvaan Shrike', 'HQ', 3, 33, 'Space Marines', 'Kayvaan.jpg'),
(6, 'C\'tan Shard of the Void Dragon', 'Elites', 7, 85, 'Necron', 'Shard_Of_VD.jpg'),
(7, 'Vargard Obyron', 'HQ', 2, 15, 'Necron', 'Vargard_Obyron.jpg'),
(8, 'Trazyn the Infinite', 'HQ', 11, 25, 'Necron', 'Trazyn.jpg'),
(9, 'Doom Scythe', 'Flyer', 4, 49, 'Necron', 'Doom_Scythe.jpg'),
(10, 'Deathmarks', 'Elites', 7, 23, 'Necron', 'Deathmarks.jpg'),
(11, 'KV128 Stormsurge', 'Lord_of_War', 1, 130, 'Tau', 'KV128_Stormsurge.jpg'),
(12, 'Commander Farsight', 'HQ', 6, 33, 'Tau', 'Farsight.jpg'),
(13, 'Pathfinder Team', 'Fast_Attack', 8, 33, 'Tau', 'Pathfinder_Team.jpg'),
(14, 'Belisarius Cawl', 'HQ', 9, 42, 'Adeptus Mechanicus', 'Belisarius.jpg'),
(15, 'Skitarii Rangers', 'Troops', 4, 35, 'Adeptus Mechanicus', 'Skitarii_Rangers.jpg'),
(16, 'Venerable Land Raider', 'Heavy_Support', 4, 80, 'Adeptus Custodes', 'VLR.jpg'),
(17, 'Custodian Wardens', 'Elites', 8, 60, 'Adeptus Custodes', 'Custodian_wardens.jpg'),
(18, 'Vexilus Praetor', 'Elites', 4, 60, 'Adeptus Custodes', 'Vexilus_Praetor.jpg'),
(19, 'Leman Russ Battle Tank', 'Heavy_Support', 11, 59, 'Imperial Guard', 'LRBTank.jpg'),
(20, 'Basilisk', 'Heavy_Support', 5, 55, 'Imperial Guard', 'Basilisk.jpg'),
(21, 'Cadians', 'Troops', 22, 10, 'Imperial Guard', 'Cadians.jpg'),
(22, 'Skorpius Disintegrator', 'Heavy_Support', 12, 75, 'Adeptus Mechanicus', 'SD.jpg'),
(23, 'Howling Banshees', 'Elites', 5, 40, 'Craftworld', 'Howling_Banshees.jpg'),
(24, 'Craftworlds Wraithlord', 'Heavy_Support', 8, 40, 'Craftworld', 'Wraithlord.jpg'),
(25, 'Black Guardian Windriders', 'Fast_Attack', 11, 30, 'Craftworld', 'BGWindriders.jpg'),
(26, 'Mandrakes', 'Elites', 12, 20, 'Drukhari', 'Mandrakes.jpg'),
(27, 'Incubi', 'Elites', 13, 38, 'Drukhari', 'Incubi.jpg'),
(28, 'Voidraven Bomber', 'Flyer', 3, 60, 'Drukhari', 'Voidraven_Bomber.jpg'),
(29, 'Ork Boyz', 'Troops', 23, 21, 'Ork', 'Boyz.jpg'),
(30, 'Gorkanaut', 'Heavy_Support', 7, 100, 'Ork', 'Gorkanaut.jpg'),
(31, 'Burna-Bommer', 'Flyer', 9, 60, 'Ork', 'BurnaBommer.jpg'),
(32, 'Broodlord', 'HQ', 4, 35, 'Tyranids', 'Broodlord.jpg'),
(33, 'Exocrine', 'Heavy_Support', 5, 55, 'Tyranids', 'Exocrine.jpg'),
(34, 'Hormagaunts', 'Troops', 18, 24, 'Tyranids', 'Hormagaunts.jpg'),
(35, 'Abaddon the Despoiler', 'HQ', 4, 50, 'Chaos Space Marines', 'AbaddonDP.jpg'),
(36, 'Dark Apostle', 'HQ', 5, 30, 'Chaos Space Marines', 'Dark_Apostle.jpg'),
(37, 'Chaos Rhino', 'Dedicated Transport', 4, 35, 'Chaos Space Marines', 'Chaos_Rhino.jpg'),
(38, 'Bloodletters', 'Troops', 18, 20, 'Daemons', 'Bloodletters.jpg'),
(39, 'Skulltaker', 'HQ', 10, 25, 'Daemons', 'Skulltaker.jpg'),
(40, 'The Changeling', 'HQ', 12, 28, 'Daemons', 'Changeling.jpg');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `users`
--

CREATE TABLE `users` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `Password` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `Email` varchar(40) COLLATE utf8_hungarian_ci NOT NULL,
  `Admin` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `users`
--

INSERT INTO `users` (`UserID`, `Username`, `Password`, `Email`, `Admin`) VALUES
(1, 'libranix', 'libx', 'Nix@gmail.com', 0),
(2, 'Weyr', 'Weyr222', 'Wey@gmail.com', 0),
(3, 'Solvar', 'Solvarin12', 'Solvar@gmail.com', 0),
(4, 'brodyr', 'brod56565', 'brody@gmail.com', 0),
(5, 'BaseAdmin', '1234567', '', 1),
(6, 'Lidan', 'Lidilan334412', 'Dan@gmail.com', 0),
(7, 'Gosa', 'Gosarin33', 'Gos@gmail.com', 0),
(8, 'Husvik', 'Husvik898989', 'Vik@gmail.com', 0),
(9, 'Godis', 'Gdis121211', 'GD@gmail.com', 0),
(10, 'Ramvik', 'Ram3R3R', 'Ramv@gmail.com', 0),
(11, 'Skaffa', 'SkaN4R', 'Sk4N3R', 0),
(12, 'Crex', 'Crexer34', 'Crx123@gmail.com', 0),
(14, 'Thorin', 'Thorienx32', 'Rin@gmail.com', 1);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `cart`
--
ALTER TABLE `cart`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`OrderID`);

--
-- A tábla indexei `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `Email` (`Email`),
  ADD UNIQUE KEY `Username` (`Username`),
  ADD UNIQUE KEY `Password` (`Password`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `orders`
--
ALTER TABLE `orders`
  MODIFY `OrderID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT a táblához `products`
--
ALTER TABLE `products`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT a táblához `users`
--
ALTER TABLE `users`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
