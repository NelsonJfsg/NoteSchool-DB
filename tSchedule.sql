CREATE DATABASE NOTESCHOOL
USE NOTESCHOOL

If object_id ('tSchedule') IS NULL CREATE TABLE tSchedule(
	idClass INT NOT NULL,
	dayOfWeek VARCHAR(15) NOT NULL,
	startHour VARCHAR(6) NOT NULL,
	finishHour VARCHAR(6) NOT NULL,
	linkClass VARCHAR(250) DEFAULT 'No existe Link',
	subject VARCHAR(50) NOT NULL,
	PRIMARY KEY (idClass),
	FOREIGN KEY(subject) REFERENCES tSubject(name)
	);

	IF object_id ('tSubject') IS NULL CREATE TABLE tSubject(

    name VARCHAR (50) PRIMARY KEY NOT NULL,  
    teacherName  VARCHAR (80), 
    qualificationScores  TEXT,  
    icon VARCHAR (100) NOT NULL 

);