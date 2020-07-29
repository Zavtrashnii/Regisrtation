CREATE TABLE `Organizations` (
  `id_org` int PRIMARY KEY,
  `name_org` text,
  `INN` int,
  `date_registration_org` date,
  `commissioner` text,
  `mail` text,
  `phone` text,
  `id_region` int,
  `id_street` int,
  `street_number` text,
  `date_registration` date,
  `id_account` int
);

CREATE TABLE `Streets` (
  `id_street` int PRIMARY KEY,
  `id_region` int,
  `name_street` text
);

CREATE TABLE `Regions` (
  `id_reg` int PRIMARY KEY,
  `name_reg` text
);

CREATE TABLE `Accounts` (
  `id_account` int PRIMARY KEY,
  `id_role` int,
  `login` text,
  `password` text
);

CREATE TABLE `Roles` (
  `id_role` int PRIMARY KEY,
  `name_role` text
);

ALTER TABLE `Organizations` ADD FOREIGN KEY (`id_region`) REFERENCES `Regions` (`id_reg`);

ALTER TABLE `Organizations` ADD FOREIGN KEY (`id_street`) REFERENCES `Streets` (`id_street`);

ALTER TABLE `Streets` ADD FOREIGN KEY (`id_region`) REFERENCES `Regions` (`id_reg`);

ALTER TABLE `Accounts` ADD FOREIGN KEY (`id_role`) REFERENCES `Roles` (`id_role`);

insert into roles values (1, 'admin');

insert into accounts values (1, 1, 'admin', 'admin');