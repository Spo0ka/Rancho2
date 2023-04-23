DROP DATABASE if EXISTS GM;
CREATE DATABASE GM;
USE GM;
 
 
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
 
 
DESCRIBE MedicamentoVacas;
 
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
Tarea VARCHAR(500));
 
CREATE TABLE TareaR(
id INT PRIMARY KEY AUTO_INCREMENT,
FK_Tarea INT,
Cumplio VARCHAR(10),
FOREIGN KEY(FK_Tarea) REFERENCES AgregarTareas(id));






delimiter ;;
CREATE PROCEDURE insertVacas(
IN _arete VARCHAR(20),
IN _raza VARCHAR(100),
IN _fdn VARCHAR(100),
IN _peso VARCHAR(100),
IN _litro_leche double
)
BEGIN
        INSERT INTO vacas VALUES(_arete, _raza, _fdn, _peso, _litro_leche);
END;;



delimiter ;;
DROP PROCEDURE if EXISTS borrarForraje;
CREATE PROCEDURE borrarForraje(_id INT)
BEGIN
DELETE FROM almacenForraje WHERE id = _id;
END;
 
 
CALL borrarForraje(1);
 
SELECT * FROM ver_forraje;


delimiter $$
DROP TRIGGER if EXISTS vacunasV;
CREATE TRIGGER vacunasV
BEFORE INSERT ON MedicamentoVacas
FOR EACH ROW
BEGIN
        UPDATE AlmacenMedicamento SET Cantidad = Cantidad - 1;
END; $$
 
delimiter $$
DROP TRIGGER if EXISTS vacunasB;
CREATE TRIGGER vacunasB
BEFORE INSERT ON MedicamentoBecerro
FOR EACH ROW
BEGIN
        UPDATE AlmacenMedicamento SET Cantidad = Cantidad - 1;
END; $$
/*------------------------------------------------------------------------------------------------------------*/

Vistas
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

DROP VIEW if EXISTS ver_registroForraje;
CREATE VIEW ver_registroForraje AS
SELECT rf.id, af.Nombre AS 'Forraje', rf.cantidad FROM registroforraje rf, almacenforraje af;
 
SELECT * FROM ver_registroforraje;

INSERT INTO registroforraje VALUES(1,6,'2');
 
DROP VIEW if EXISTS ver_medicamentoBecerro;
CREATE VIEW ver_medicamentoBecerro AS
SELECT mb.id, mb.Fk_Becerro, am.Nombre AS 'Medicamento', mb.Fecha
FROM medicamentobecerro mb, almacenmedicamento am;
 
SELECT * FROM ver_medicamentoBecerro;
delimiter ;;

DROP PROCEDURE if EXISTS insertAlmacenMedicamento;
CREATE PROCEDURE insertAlmacenMedicamento(
IN _id INT, IN _nombre VARCHAR(100),IN _cantidad INT)
   BEGIN  
   if _id < 0 then
      INSERT INTO AlmacenMedicamento VALUES(NULL, _nombre, _cantidad);
   ELSE if _id > 0 then
      UPDATE AlmacenMedicamento SET nombre = _nombre, cantidad = _cantidad WHERE id = _id;
   END if;
   END if;
END;;
CALL insertAlmacenMedicamento(-1, 'paracetamol', 123);
SELECT * FROM almacenmedicamento;
 
delimiter ;;
DROP PROCEDURE if EXISTS insertMedicamentoVacas;
CREATE PROCEDURE insertMedicamentoVacas(
IN _id INT, IN _vaca VARCHAR(100), _medicamento INT, _fecha VARCHAR(100))
   BEGIN  
   if _id < 0 then
      INSERT INTO MedicamentoVacas VALUES(NULL, _vaca, _medicamento, _fecha);
   ELSE if _id > 0 then
      UPDATE MedicamentoVacas SET Fk_Vacas = _vaca, FK_Medicamento = _medicamento, Fecha = _fecha WHERE id = _id;
   END if;
   END if;
END;;
 CALL insertMedicamentoVacas(-1,'123er',4,'2019-02-14');
delimiter ;;

DROP PROCEDURE if EXISTS insertRegistroForraje;
CREATE PROCEDURE insertRegistroForraje(
IN _id INT, IN _forraje INT,IN _cantidad INT)
   BEGIN  
   if _id < 0 then
      INSERT INTO RegistroForraje VALUES(NULL, _forraje, _cantidad);
   ELSE if _id > 0 then
      UPDATE RegistroForraje SET Fk_Forraje = _forraje, cantidad = _cantidad WHERE id = _id;
   END if;
   END if;
END;;
 
delimiter ;;
DROP PROCEDURE if EXISTS insertBecerro;
CREATE PROCEDURE insertBecerro(
IN _arete VARCHAR(100), IN _raza VARCHAR(100), IN _fdn VARCHAR(100), IN _peso VARCHAR(100), IN _sexo VARCHAR(1))
   BEGIN  
      INSERT INTO Becerro VALUES(_arete, _raza, _fdn, _peso, _sexo);
END;;

delimiter ;;
DROP PROCEDURE if EXISTS updateBecerro;
CREATE PROCEDURE updateBecerro(
IN _arete VARCHAR(100), IN _raza VARCHAR(100), IN _fdn VARCHAR(100), IN _peso VARCHAR(100), IN _sexo VARCHAR(1))
   BEGIN  
      UPDATE Becerro SET Arete = _arete, Raza = _raza, Fdn = _fdn, Peso = _peso, sexo = _sexo WHERE Arete = _arete;
END;;
      
delimiter ;;
DROP PROCEDURE if EXISTS insertMedBecerro;
CREATE PROCEDURE insertMedBecerro(
IN _id INT, IN _becerro VARCHAR(100), IN _medicamento INT, IN _fecha VARCHAR(100))
   BEGIN 
	if _id < 0 then  
      INSERT INTO medicamentobecerro VALUES(NULL, _becerro, _medicamento, _fecha);
   ELSE if _id > 0 then
      UPDATE medicamentobecerro SET Fk_Becerro = _becerro, Fk_Medicamento = _medicamento, Fecha = _fecha WHERE id = _id;
   END if;
   END if;
END;;

delimiter ;;
DROP PROCEDURE if EXISTS agregarForraje;
CREATE PROCEDURE agregarForraje(
in _id INT,
in _nombre VARCHAR(50),
in _cantidad INT)
BEGIN
if _id <0 then
INSERT INTO almacenForraje VALUES(NULL,_nombre,_cantidad);
ELSE if _id >0 then
UPDATE almacenforraje SET nombre = _nombre, cantidad = _cantidad WHERE id = _id;
END if;
END if;
END;
 

delimiter ;;
DROP PROCEDURE if EXISTS InsertTareas;
CREATE PROCEDURE InsertTareas(
IN _id INT, IN _Tarea VARCHAR(500))
BEGIN
if _id<0 then
	INSERT INTO agregartareas VALUES (NULL, _Tarea);
ELSE if _id >0 then
	UPDATE agregartareas SET Tarea = _Tarea WHERE id = _id;
	END if;
	END if;
END;;

CALL InsertTareas(-1,'Dar forraje');

SELECT * FROM agregartareas;

delimiter ;;
DROP PROCEDURE if EXISTS InsertTareasR;
CREATE PROCEDURE InsertTareasR(
IN _id INT, IN _fkTarea INT, IN _cumplio VARCHAR(10))
BEGIN
if _id <0 then
	INSERT INTO tarear VALUES (NULL, _fkTarea, _cumplio);
ELSE if _id >0 then
	UPDATE tarear SET FK_Tarea = _fkTarea, Cumplio = _cumplio WHERE id = _id;
	END if;
	END if;
END;;

/*CALL InsertTareasR(-1,1,'En proceso');*/
SELECT * FROM tarear;
SELECT * FROM agregartareas;
/*vistas Tareas*/
DELETE FROM agregartareas WHERE id = 2;
DROP VIEW if EXISTS ver_ATareas;
CREATE VIEW ver_ATareas AS
SELECT af.id, af.Tarea AS 'Tarea'
FROM agregartareas af;

SELECT * FROM ver_ATareas;

/*DROP VIEW if EXISTS ver_TareasR;
CREATE VIEW ver_TareasR AS
SELECT af.id, f.Tarea AS 'Tareas', af.cumplio
FROM tarear af, agregartareas f;*/

SELECT * FROM ver_tareasr;

DROP view if EXISTS ver_tareasTra;
CREATE VIEW ver_tareasTra AS
SELECT u.id, a.Tarea AS'Tarea',u.cumplio FROM agregartareas a, tarear u;

SELECT * FROM ver_tareasTra;

DELETE  FROM becerro WHERE Arete = '123cvb';
