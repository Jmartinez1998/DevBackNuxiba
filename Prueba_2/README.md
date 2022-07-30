## Directorio para la prueba 1 ##


## Creando base de datos nombre nuxibatest - Mysql ##
#CREATE DATABASE nuxibatest ;

#USE nuxibatest;

#Creacion de tablas

CREATE TABLE usuarios(
   userid INT NOT NULL AUTO_INCREMENT,
   Login VARCHAR(100),
   Nombre VARCHAR(100),
   Paterno VARCHAR(100),
   Materno VARCHAR(100),
   PRIMARY KEY ( userid )
);

CREATE TABLE empleados (
    EmpleadoId INT NOT NULL AUTO_INCREMENT,
    Sueldo DOUBLE,
    FechaIngreso DATE,
	 userId int,
    PRIMARY KEY (EmpleadoId),
	 CONSTRAINT userId FOREIGN KEY (userId)
        REFERENCES usuarios (userId)
);

#Datos de excel DatosPracticaSQL Usuarios y empleados
## Agregando usuarios ##
INSERT INTO usuarios (Login,Nombre,Paterno, Materno)VALUES
    ('user01','BERE','NARANJO','GONZALEZ'),
    ('user02','ALEXIS','CAMPOS','NARANJO'),
    ('user03','SERGIO ALEJANDRO','CAMPOS','HERNANDEZ'),
    ('user04','DIEGO ISMAEL','BERUMEN','CEDILLO'),
    ('user05','AURORA','ESCALANTE','PALAFOX'),
    ('user06','JOYCELENE FABIOLA','ESTRADA','BARBA'),
    ('user07','FRANCISCO','ESTRADA','GOMEZ'),
    ('user08','LEONARDO DANIEL','FARIAS','ROSAS'),
    ('user09','RAMON ANDRES','FIERROS','ROBLES'),
    ('user10','EDGAR ANDRES','FLORES','OLIVARES'),
    ('user11','MARIA FERNANDA','FRANCO','ESQUIVEL'),
    ('user12','ALEJANDRO','GALVAN','MUÑIZ'),
    ('user13','MARTHA ALICIA','GUTIERREZ','ORTIZ'),
    ('user14','JOSAFAT GERARDO','HERNANDEZ','SAUCEDO'),
    ('user15','ROSALIA','JIMENEZ','GONZALEZ'),
    ('user16','LAURA CELENE','JIMENEZ','RIOS'),
    ('user17','ANGELICA','LOPEZ','CORTES'),
    ('user18','CRISTIAN IVAN','LOPEZ','GOMEZ'),
    ('user19','MARLENE GABRIELA','LOPEZ','MEZA'),
    ('user20','ALEJANDRA','MEDINA','IBARRA'),
    ('user21','CONSUELO YURIDIANA THALIA','MEJIA','ALVAREZ'),
    ('user22','JAVIER ADRIAN','MEJIA','ALVAREZ'),
    ('user23','JUAN CARLOS EVARISTO','PEÑA','GUTIERREZ'),
    ('user24','JAZMIN ALEJANDRA','PEREZ','VELEZ'),
    ('user25','GUSTAVO','RAMIREZ','RIVERA'),
    ('user26','CARLOS NIVARDO','RODRIGUEZ','ASCENCIO'),
    ('user27','KARLA JOHANA','ROMERO','LUEVANOS'),
    ('user28','YESSICA YOSELINNE','RUIZ','HERNANDEZ'),
    ('user29','CHRISTIAN EDUARDO','SALAS','SANCHEZ'),
    ('user30','LUIS ROBERTO','SALDAÑA','ESPINOZA'),
    ('user31','ADRIAN','SANCHEZ','ORTIZ'),
    ('user32','EDUARDO YAIR','SUAREZ','HERNANDEZ'),
    ('user33','JUAN FRANCISCO','TABAREZ','GARCIA'),
    ('user34','ZULEICA ELIZABETH','TERAN','TORRES'),
    ('user35','ADRIANA YUNUHEN','VARGAS','AYALA'),
    ('user36','OSCAR URIEL','VELAZQUEZ','ALVAREZ'),
    ('user37','ERICK DE JESUS','CORONA','DIAZ'),
    ('user38','MARIA GUADALUPE','RAMOS','HERNANDEZ'),
    ('user39','JESSICA NOEMI','JIMENEZ','VENTURA'),
    ('user40','FLOR MARGARITA','ROJAS','HERNANDEZ'),
    ('user41','LUIS ANTONIO','ALVARADO','VALENCIA'),
    ('user42','EDGAR IVAN','AGUILAR','PADILLA'),
    ('user43','LUIS ALFONSO','MICHEL','SANCHEZ'),
    ('user44','JOSE CARLOS','SILVA','ROCHA'),
    ('user45','JUDITH','RODRIGUEZ','REYES'),
    ('user46','BRENDA SORAYA','CHAVEZ','GARCIA'),
    ('user47','ALMA ROSA','MARQUEZ','AGUILA');
    
## Agregando empleados ##
    INSERT INTO empleados(userId,Sueldo,FechaIngreso)VALUES
    (1, 8837,'2000-01-11 00:00:00'),
    (2, 8837,'2000-01-11 00:00:00'),
    (3, 15000,'2000-01-11 00:00:00'),
    (4, 15000,'2000-01-11 00:00:00'),
    (5, 7812,'2000-01-18 00:00:00'),
    (6, 7812,'2000-01-18 00:00:00'),
    (7, 10200,'2000-01-18 00:00:00'),
    (8, 10200,'2000-01-18 00:00:00'),
    (9, 13800,'2001-05-20 00:00:00'),
    (10, 13800,'2001-05-20 00:00:00'),
    (11, 18880,'2001-05-20 00:00:00'),
    (12, 18880,'2001-05-20 00:00:00'),
    (13, 8000,'2001-07-13 00:00:00'),
    (14, 8000,'2001-07-13 00:00:00'),
    (15, 6000,'2001-07-13 00:00:00'),
    (16 ,19470,'2001-07-13 00:00:00'),
    (17, 19470,'2001-07-13 00:00:00'),
    (18, 10200,'2001-07-16 00:00:00'),
    (19, 10200,'2001-07-16 00:00:00'),
    (20, 25000,'2001-07-16 00:00:00'),
    (21, 7812,'2001-07-16 00:00:00'),
    (22, 7812,'2001-07-16 00:00:00'),
    (23, 12210,'2001-11-24 00:00:00'),
    (24, 12210,'2001-11-24 00:00:00'),
    (25, 7500,'2001-11-24 00:00:00'),
    (26,	15020,'2001-11-24 00:00:00'),
    (27, 15020,'2001-11-24 00:00:00'),
    (28, 25000,'2001-11-24 00:00:00'),
    (29, 7812,'2001-11-24 00:00:00'),
    (30, 15020,'2001-12-12 00:00:00'),
    (31, 15020,'2001-12-12 00:00:00'),
    (32,	12210,'2001-12-12 00:00:00'),
    (33, 12210,'2001-12-12 00:00:00'),
    (34,	19470,'2008-08-17 00:00:00'),
    (35, 19470,'2008-08-17 00:00:00'),
    (36, 8000,'2008-08-17 00:00:00'),
    (37, 8000,'2008-08-17 00:00:00'),
    (38,	18880,'2009-06-11 00:00:00'),
    (39, 18880,'2009-06-11 00:00:00'),
    (40,	14000,'2009-06-11 00:00:00'),
    (41,	13800,'2009-06-11 00:00:00'),
    (42, 13800,'2009-06-11 00:00:00'),
    (43, 15000,'2009-10-06 00:00:00'),
    (44, 15000,'2009-10-06 00:00:00'),
    (45, 13000,'2009-10-06 00:00:00'),
    (46,8837,'2009-10-06 00:00:00');
   
#---Depurar solo los ID diferentes de 6,7,9 y 10 de la tabla usuarios
/*OBSERVACION -> No elimino los registros solo filtro para que no sean mostrados*/
SELECT * FROM usuarios WHERE userid <> 6 AND userid<> 7 AND userid <> 9 AND userid <> 10;
    
#---Actualizar el dato Sueldo en un 10 porciento a los empleados que tienen fechas entre el año 2000 y 2001
/*OBSERVACION -> se actualiza en base a el 10% del valor anterior*/
UPDATE empleados
SET Sueldo = Sueldo*0.10 WHERE YEAR(FechaIngreso) BETWEEN '2000' AND '2001';

#SELECT * FROM empleados WHERE YEAR(FechaIngreso) BETWEEN '2000' AND '2001';

/* ---Realiza una consulta para traer el nombre de usuario y fecha de ingreso de los usuarios que
gananen mas de 10000 y su apellido comience con T ordernado del mas reciente al mas antiguo*/

SELECT nombre, FechaIngreso 
FROM usuarios
INNER JOIN empleados
ON usuarios.userid = empleados.userId
AND empleados.Sueldo >10000 AND usuarios.Paterno LIKE 'T%'
ORDER BY FechaIngreso DESC;

/*
Realiza una consulta donde agrupes a los empleados por sueldo, un grupo con los que ganan
menos de 1200 y uno mayor o igual a 1200, cuantos hay en cada grupo
*/

##Se agrupan los que ganan menos de 1200##
SELECT COUNT(*) AS 'Menor 1200'  FROM usuarios INNER JOIN empleados ON usuarios.userId= empleados.userId WHERE Sueldo < 1200;
##Se agrupan los que ganan más de 1200##
SELECT COUNT(*) AS 'Mayor 1200'  FROM usuarios INNER JOIN empleados ON usuarios.userId= empleados.userId WHERE Sueldo >= 1200;