CREATE DATABASE turnos

CREATE TABLE `horas` (
  `horasID` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`horasID`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

CREATE TABLE `turnoslab` (
  `turnoID` int(11) NOT NULL AUTO_INCREMENT,
  `nombrePaciente` varchar(75) CHARACTER SET latin1 COLLATE latin1_spanish_ci DEFAULT NULL,
  `estado` varchar(15) CHARACTER SET latin1 COLLATE latin1_spanish_ci DEFAULT 'En curso',
  `eritro` int(11) DEFAULT NULL,
  `cito` int(11) DEFAULT NULL,
  `actoBioq` int(11) DEFAULT '1',
  `retis` int(11) DEFAULT NULL,
  `dni` int(11) NOT NULL,
  `horaID` smallint(6) NOT NULL,
  `fecha` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`turnoID`),
  UNIQUE KEY `dni_Unique` (`dni`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

SELECT `horas`.`horasID`,
    `horas`.`descripcion`
FROM `turnos`.`horas`;
ALTER TABLE turnoslab ADD FOREIGN KEY(horaID) REFERENCES horas(horaID);

INSERT INTO `turnos`.`horas`
(`descripcion`)
VALUES
('10:00'),
('11:00'),
('12:00'),
('13:00'),
('14:00')
