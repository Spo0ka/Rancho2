DROP DATABASE if EXISTS GM;
CREATE DATABASE GM;
USE GM;

-- TABLES -----------------------------------------------------------------------------------------------------------------

CREATE TABLE Usuarios( Id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
Nombre VARCHAR(100), Apellido VARCHAR(100), Usuario VARCHAR(100), pass VARCHAR(100), permisos VARCHAR(20));

INSERT INTO usuarios VALUES(NULL, 'Juan Carlos','Muñoz','Admin','1234','Administrador');
INSERT INTO usuarios VALUES(NULL, 'Leo','Wawis','Admin','1234','Administrador');

CREATE TABLE Vacas( Arete VARCHAR(100) NOT NULL PRIMARY KEY,
Raza VARCHAR(100), Fdn VARCHAR(100), Peso VARCHAR(100), Litros_Leche DOUBLE);

 CREATE TABLE Becerro(Arete VARCHAR(100) NOT NULL PRIMARY KEY,
Raza VARCHAR(100), Fdn VARCHAR(100), Peso VARCHAR(100), sexo VARCHAR(1));
 
 
CREATE TABLE AlmacenForraje(
id INT PRIMARY KEY NOT NULL auto_increment,
Nombre VARCHAR(100),
Cantidad INT);
 
CREATE TABLE AlmacenMedicamento(
id INT PRIMARY KEY NOT NULL auto_increment,
Nombre VARCHAR(100),
Cantidad INT);
 
DROP TABLE  if EXISTS MedicamentoVacas;
CREATE TABLE MedicamentoVacas(
id INT PRIMARY KEY NOT NULL auto_increment,
Fk_Vacas VARCHAR(100),
FK_Medicamentos INT,
Fecha VARCHAR(100),
FOREIGN KEY(Fk_Vacas) REFERENCES Vacas(Arete),
FOREIGN KEY(FK_Medicamentos) REFERENCES AlmacenMedicamento(id));
 
 
DROP TABLE  if EXISTS RegistroForraje;
CREATE TABLE RegistroForraje(
id INT PRIMARY KEY NOT NULL auto_increment,
Fk_Forraje INT,
cantidad INT,
FOREIGN KEY(FK_Forraje) REFERENCES AlmacenForraje(id));
 
CREATE TABLE MedicamentoBecerro(id INT PRIMARY KEY NOT NULL auto_increment, Fk_Becerro VARCHAR(100), Fk_Medicamento INT, Fecha VARCHAR(100),
FOREIGN KEY(Fk_Becerro) REFERENCEs Becerro(Arete),
FOREIGN KEY(FK_Medicamento) REFERENCES AlmacenMedicamento(id));

CREATE TABLE AgregarTareas(
id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
Tarea VARCHAR(500), fk_Usuarios INT,
FOREIGN KEY (fk_Usuarios) REFERENCES usuarios(Id));
 
 DROP TABLE if EXISTS tarear;
CREATE TABLE tarear(
id INT PRIMARY KEY AUTO_INCREMENT,
Tarea VARCHAR(100),
Cumplio VARCHAR(10),
usuario VARCHAR (100));


-- PROCEDURES -------------------------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------------------------------------


DELIMITER ;;
DROP PROCEDURE IF EXISTS insertUsuario;
CREATE PROCEDURE insertUsuario(
    IN _Id INT,
    IN _Nombre VARCHAR(100),
    IN _Apellido VARCHAR(100),
    IN _Usuario VARCHAR(100),
    IN _pass VARCHAR(100),
    IN _permisos VARCHAR(20)
)
BEGIN 
    DECLARE X INT;
    SELECT COUNT(*) FROM usuarios WHERE Id = _Id INTO X;
    IF X = 0 THEN
        INSERT INTO usuarios VALUES(NULL, _Nombre, _Apellido, _Usuario, _pass, _permisos);
    ELSE
        UPDATE usuarios SET Nombre = _Nombre, Apellido = _Apellido, Usuario = _Usuario,pass=_pass, permisos = _permisos WHERE Id = _Id;
    END IF;
END;;

delimiter ;;
DROP PROCEDURE if EXISTS insertAlmacenMedicamento;
CREATE PROCEDURE insertAlmacenMedicamento(
IN _id INT, IN _nombre VARCHAR(100),IN _cantidad INT)
   BEGIN  
   DECLARE X INT;
   SELECT COUNT(*) FROM almacenmedicamento WHERE id=_id INTO X;
   if X = 0 then
      INSERT INTO AlmacenMedicamento VALUES(NULL, _nombre, _cantidad);
   ELSEif X > 0 then
      UPDATE AlmacenMedicamento SET nombre = _nombre, cantidad = _cantidad WHERE id = _id;
   END if;
END;;

 
delimiter ;;
DROP PROCEDURE if EXISTS insertMedicamentoVacas;
CREATE PROCEDURE insertMedicamentoVacas(
IN _id INT, IN _vaca VARCHAR(100), _medicamento INT, _fecha VARCHAR(100))
   BEGIN  
   DECLARE X INT;
   SELECT COUNT(*) FROM medicamentovacas WHERE id=_id INTO x;
   if X = 0 then
      INSERT INTO MedicamentoVacas VALUES(NULL, _vaca, _medicamento, _fecha);
   ELSEif X >0 then
      UPDATE medicamentovacas SET Fk_Vacas = _vaca, FK_Medicamentos = _medicamento, Fecha = _fecha WHERE id = _id;
   END if;
END;;

delimiter ;;
DROP PROCEDURE if EXISTS insertRegistroForraje;
CREATE PROCEDURE insertRegistroForraje(
IN _id INT, IN _forraje INT,IN _cantidad INT)
   BEGIN  
   DECLARE X INT;
   SELECT COUNT(*) FROM registroforraje WHERE id=_id INTO X;
   if X = 0 then
      INSERT INTO RegistroForraje VALUES(NULL, _forraje, _cantidad);
   ELSEif X > 0 then
      UPDATE RegistroForraje SET Fk_Forraje = _forraje, cantidad = _cantidad WHERE id = _id;
   END if;
END;;
      
delimiter ;;
DROP PROCEDURE if EXISTS insertMedBecerro;
CREATE PROCEDURE insertMedBecerro(
IN _id INT, IN _becerro VARCHAR(100), IN _medicamento INT, IN _fecha VARCHAR(100))
   BEGIN 
   DECLARE X INT;
   SELECT COUNT(*) FROM medicamentobecerro WHERE id=_id INTO X;
	if X = 0 then  
      INSERT INTO medicamentobecerro VALUES(NULL, _becerro, _medicamento, _fecha);
   ELSEif X > 0 then
      UPDATE medicamentobecerro SET Fk_Becerro = _becerro, Fk_Medicamento = _medicamento, Fecha = _fecha WHERE id = _id;
   END if;
END;;

delimiter ;;
DROP PROCEDURE if EXISTS agregarForraje;
CREATE PROCEDURE agregarForraje(
in _id INT,
in _nombre VARCHAR(50),
in _cantidad INT)
BEGIN
DECLARE X INT;
   SELECT COUNT(*) FROM almacenforraje WHERE id=_id INTO X;
if X=0 then
INSERT INTO almacenForraje VALUES(NULL,_nombre,_cantidad);
ELSE if X >0 then
UPDATE almacenforraje SET nombre = _nombre, cantidad = _cantidad WHERE id = _id;
END if;
END if;
END;;

delimiter ;;
DROP PROCEDURE if EXISTS InsertTareas;
CREATE PROCEDURE InsertTareas(
IN _id INT, IN _Tarea VARCHAR(500), IN _Usuario INT)
BEGIN
DECLARE X INT;
   SELECT COUNT(*) FROM agregartareas WHERE id=_id INTO X;
if X=0 then
	INSERT INTO agregartareas VALUES (NULL, _Tarea,_Usuario);
ELSE if X >0 then
	UPDATE agregartareas SET Tarea = _Tarea, Usuario=_Usuario WHERE id = _id;
	END if;
	END if;
END;;

delimiter ;;
DROP PROCEDURE if EXISTS InsertTareasR;
CREATE PROCEDURE InsertTareasR(
in _id INT,
in _Tarea VARCHAR(100),
in _Cumplio VARCHAR(10),
in _usuario VARCHAR (100))
BEGIN
DECLARE X INT;
   SELECT COUNT(*) FROM Tarear WHERE id=_id INTO X;
if X=0 then
	INSERT INTO tarear VALUES (NULL, _Tarea, _Cumplio,_usuario);
ELSEif X>0 then
	UPDATE tarear SET Tarea = _Tarea, Cumplio = _Cumplio, usuario=_usuario WHERE id = _id;
	END if;
END;;

delimiter ;;
DROP PROCEDURE if EXISTS insertBecerro;
CREATE PROCEDURE insertBecerro(
IN _arete VARCHAR(100), IN _raza VARCHAR(100), IN _fdn VARCHAR(100), IN _peso VARCHAR(100), IN _sexo VARCHAR(1))
   BEGIN  
   DECLARE x INT;
   SELECT COUNT(*) FROM becerro WHERE arete=_arete INTO x;
   if X=0 then 
      INSERT INTO Becerro VALUES(_arete, _raza, _fdn, _peso, _sexo);
      ELSEIF X>0 then
      UPDATE becerro SET raza=_raza, fdn=_fdn, peso=_peso, sexo=_sexo WHERE arete=_arete;
   END if;
END;;

##SELECT * FROM vacas
##CALL insertVacas('frm11111','Pitbull','1111','11',111)
delimiter ;;
DROP PROCEDURE if EXISTS insertVacas;
CREATE PROCEDURE insertVacas(
IN _arete VARCHAR(100),
IN _raza VARCHAR(100),
IN _fdn VARCHAR(100),
IN _peso VARCHAR(100),
IN _litro_leche DOUBLE
)
BEGIN
DECLARE X INT;
SELECT COUNT(*) FROM vacas WHERE Arete=_arete INTO X;
if X=0 then
        INSERT INTO vacas VALUES(_arete, _raza, _fdn, _peso, _litro_leche);
ELSEIF X>0 then 
UPDATE vacas SET raza=_raza,fdn= _fdn,  peso=_peso, Litros_Leche=_litro_leche WHERE Arete=_arete;
END if;
END;;

delimiter ;;
DROP PROCEDURE if EXISTS insertUsuario;
CREATE PROCEDURE insertUsuario( in _Id INT,
in _Nombre VARCHAR(100),IN  _Apellido VARCHAR(100), in _Usuario VARCHAR(100), in _contraseña VARCHAR(100), in _permisos VARCHAR(20))
BEGIN 
DECLARE X int;
SELECT COUNT(*) FROM usuarios WHERE  Id = _Id INTO X;
if X=0 then
INSERT INTO usuarios VALUES(NULL,_Nombre,_Apellido,_Usuario,_contraseña,_permisos);
ELSEIF X>0 then
UPDATE usuarios SET Nombre= _Nombre, Apellido= _Apellido, Usuario= _Usuario, permisos=_permisos WHERE Id=_Id;
END if;
END;;

/* Procedures para mostrar -----------------------------------------------------------------------------------------------*/

delimiter ;; ##Medicamento vacas
DROP PROCEDURE if EXISTS Show_MedicamentoVaca; 
CREATE PROCEDURE Show_MedicamentoVaca(IN filtro VARCHAR(100))
BEGIN
    SELECT MedicamentoVacas.id, Vacas.Arete, AlmacenMedicamento.Nombre, MedicamentoVacas.Fecha
    FROM MedicamentoVacas
    INNER JOIN AlmacenMedicamento ON MedicamentoVacas.FK_Medicamentos = AlmacenMedicamento.id
    INNER JOIN Vacas ON MedicamentoVacas.Fk_Vacas = Vacas.Arete
    WHERE AlmacenMedicamento.Nombre LIKE CONCAT('%', filtro, '%')
    OR Vacas.Arete LIKE CONCAT('%', filtro, '%')
    OR MedicamentoVacas.Fecha LIKE CONCAT('%', filtro, '%');
END ;;  

DELIMITER ;; ## Medicamento Becerros
DROP PROCEDURE IF EXISTS Show_MedicamentoBecerro; 
CREATE PROCEDURE Show_MedicamentoBecerro(IN filtro VARCHAR(100))
BEGIN
    SELECT mb.id, b.Arete, m.Nombre, mb.Fecha
    FROM medicamentobecerro mb
    JOIN AlmacenMedicamento m ON mb.FK_Medicamento = m.id
    JOIN becerro b ON mb.Fk_Becerro = b.Arete
    WHERE b.Arete LIKE CONCAT('%', filtro, '%') OR m.Nombre LIKE CONCAT('%', filtro, '%');
END ;;

DELIMITER ;; ##Realizar Tareas
DROP PROCEDURE if EXISTS MostrarTareasR;
CREATE PROCEDURE MostrarTareasR(IN filtro VARCHAR(500))
BEGIN
SELECT * FROM tarear WHERE tarear.Tarea LIKE CONCAT('%',filtro,'%');
END ;;

DELIMITER ;; ## Registro Forraje
DROP PROCEDURE if EXISTS MostrarRegistroForraje;
CREATE PROCEDURE MostrarRegistroForraje(IN filtro VARCHAR(100))
BEGIN
    SELECT rf.id, af.Nombre AS 'Forraje', rf.cantidad
    FROM RegistroForraje rf
    JOIN AlmacenForraje af ON rf.Fk_Forraje = af.id
    WHERE af.Nombre LIKE CONCAT('%', filtro, '%');
END ;;

DELIMITER ;;
DROP PROCEDURE if EXISTS MostrarTareasUsuarios;
CREATE PROCEDURE MostrarTareasUsuarios(IN filtro VARCHAR(100))
BEGIN
    SELECT t.id, t.Tarea, u.Nombre AS 'Usuario'
    FROM AgregarTareas t
    JOIN Usuarios u ON t.fk_Usuarios = u.Id
    WHERE t.Tarea LIKE CONCAT('%', filtro, '%') OR u.Nombre LIKE CONCAT('%', filtro, '%');
END ;;


/*-- VISTAS----------------------------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------------------------------------


DROP VIEW if EXISTS ver_forraje;
CREATE VIEW ver_forraje AS
SELECT af.id, af.nombre AS 'Nombre', af.cantidad AS 'Cantidad'
FROM almacenForraje af;
 
SELECT * FROM ver_forraje;
 
DROP VIEW if EXISTS ver_vacas;
CREATE VIEW ver_vacas AS
SELECT vacas.Arete, vacas.Raza, vacas.Fdn AS 'Fecha de nacimiento', vacas.Peso, vacas.Litros_Leche AS 'Litros de leche'
FROM vacas;
 
SELECT * FROM ver_vacas;
 
DROP VIEW if EXISTS ver_becerros;
CREATE VIEW ver_becerros AS
SELECT b.Arete, b.Raza, b.Fdn AS 'Fecha de nacimiento', b.Peso, b.sexo AS 'Sexo'
 FROM becerro b;
 
 SELECT * FROM ver_becerros;
 
DROP VIEW if EXISTS ver_medicamento;
CREATE VIEW ver_medicamento AS
SELECT * FROM almacenmedicamento;
 
SELECT * FROM ver_medicamento;
 
DROP VIEW if EXISTS ver_medicamentoVacas;
CREATE VIEW ver_medicamentoVacas AS
SELECT mv.id, mv.Fk_Vacas,am.Nombre AS 'Medicamento', mv.Fecha
FROM medicamentovacas mv, almacenmedicamento am;
 
SELECT * FROM ver_medicamentoVacas;


/*
DROP VIEW if EXISTS ver_registroForraje;
CREATE VIEW ver_registroForraje AS
SELECT rf.id, af.Nombre, rf.cantidad FROM registroforraje rf, almacenforraje af;
*/


-- TRIGGERS ---------------------------------------------------------------------------------------------------------------
-- ------------------------------------------------------------------------------------------------------------------------


delimiter $$
DROP TRIGGER if EXISTS generar_username;
CREATE TRIGGER generar_username
BEFORE INSERT ON usuarios
FOR EACH ROW
BEGIN
    SET NEW.usuario = CONCAT(NEW.nombre, SUBSTR(NEW.apellido, 1, 2), LAST_INSERT_ID());
END; $$

delimiter $$
DROP TRIGGER if EXISTS vacunasV;
CREATE TRIGGER vacunasV
BEFORE INSERT ON MedicamentoVacas
FOR EACH ROW
BEGIN
    DECLARE cantidad_actual INT;
    SELECT Cantidad INTO cantidad_actual FROM AlmacenMedicamento WHERE id = NEW.FK_Medicamentos;
    IF cantidad_actual < 1 THEN
        SIGNAL SQLSTATE '45000' 
            SET MESSAGE_TEXT = 'No hay suficiente cantidad de medicamentos en el almacen.';
    ELSE
        UPDATE AlmacenMedicamento SET Cantidad = Cantidad - 1 WHERE id = NEW.FK_Medicamentos;
    END IF;
END; $$

delimiter $$
DROP TRIGGER if EXISTS vacunasB;
CREATE TRIGGER vacunasB
BEFORE INSERT ON medicamentobecerro
FOR EACH ROW
BEGIN
    DECLARE cantidad_actual INT;
    SELECT Cantidad INTO cantidad_actual FROM AlmacenMedicamento WHERE id = NEW.Fk_Medicamento;
    IF cantidad_actual < 1 THEN
        SIGNAL SQLSTATE '45000' 
            SET MESSAGE_TEXT = 'No hay suficiente cantidad de medicamentos en el almacen.';
    ELSE
        UPDATE AlmacenMedicamento SET Cantidad = Cantidad - 1 WHERE id = NEW.Fk_Medicamento;
    END IF;
END; $$

delimiter $$
DROP TRIGGER if EXISTS El_trigger_chido_para_las_tareas_Jared_no_le_sabe_al_2048;
CREATE TRIGGER El_trigger_chido_para_las_tareas_Jared_no_le_sabe_al_2048
AFTER INSERT ON agregartareas
FOR EACH ROW
BEGIN
	DECLARE usuario VARCHAR(100);
	SELECT u.Nombre AS 'Usuario' FROM agregartareas t 
		JOIN Usuarios u ON t.fk_Usuarios = u.Id WHERE t.id = NEW.id INTO usuario;
	INSERT INTO tarear VALUES(NULL, NEW.Tarea, 'no', usuario);
END; $$


-- PRUEBAS ----------------------------------------------------------------------------------------------------------------


SHOW TABLES;
DESCRIBE medicamentovacas;
DESCRIBE medicamentobecerro;
DESCRIBE almacenmedicamento;
DESCRIBE vacas;
DESCRIBE tarear;
DESCRIBE agregartareas;

INSERT INTO vacas VALUES('1a', 'cambalachera', 'qw', '1 kilo', 12); 
INSERT INTO almacenmedicamento VALUES(NULL, 'cocaina', 1);
INSERT INTO medicamentovacas VALUES(NULL, '1a', 1, 'hoy');
INSERT INTO agregartareas VALUES(NULL, 'wawis2', 1);
INSERT INTO agregartareas VALUES(NULL, 'Noonoo2', 2);

SELECT * FROM vacas;
SELECT * FROM almacenmedicamento;
SELECT * FROM medicamentovacas;
SELECT * FROM usuarios;
SELECT * FROM agregartareas;
SELECT * FROM tarear;


