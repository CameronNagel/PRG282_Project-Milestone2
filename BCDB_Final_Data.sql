USE [master]
GO
CREATE DATABASE BCDatabase
GO
USE [BCDatabase]
GO
CREATE TABLE students 
(
	student_number INT NOT NULL,
	student_name VARCHAR(100),
	student_image VARBINARY(MAX),
	student_dob DATE,
	student_gender VARCHAR(25),
	student_phone VARCHAR(12),
	student_city VARCHAR(100),
	student_province VARCHAR(100),
	student_street VARCHAR(100)
)
GO
CREATE TABLE modules
(
	module_code VARCHAR(20) NOT NULL,
	module_name VARCHAR(100),
	module_description VARCHAR(300),
	module_resources VARCHAR(200)
)
GO
CREATE TABLE students_modules
(
	mod_code VARCHAR(20),
	student_num INT
)
GO
--CREATE STORED PROCEDURES

--Procedure for deleting student :
------------------------------------------------------------------
Create Procedure spDeleteStudent
(
	@number INT
)
AS
Begin
	DELETE FROM [dbo].[students]
	WHERE [student_number] = @number

	DELETE FROM [dbo].[students_modules]
	WHERE [dbo].[students_modules].[student_num] = @number
End
GO

--PROCEDURE FOR DELETETING MODULE
CREATE PROC spDeleteModule
(
	@modcode VARCHAR(20)
)
AS
BEGIN
	DELETE FROM [dbo].[modules]
	WHERE [module_code] = @modcode

	DELETE FROM [dbo].[students_modules] 
	WHERE [mod_code] = @modcode
END

GO


--Procedure For Updating Student:
---------------------------------------------------------------
Create Procedure spUpdateStudent
(
	@number INT,
	@Name VARCHAR(20),
	@Image VARBINARY(MAX),
	@DOB Date,
	@Gender VARCHAR(25),
	@Phone VARCHAR(12),
	@City VARCHAR(100),
	@Province VARCHAR(100),
	@Street VARCHAR(100)

)
AS
Begin
	UPDATE Students
	SET student_number = @number,student_name = @Name, student_image = @Image, student_dob = @DOB, 
	    student_gender = @Gender, student_phone = @Phone, student_city= @City, student_province=@Province, student_street=@Street
	WHERE student_number = @number
End

GO
--PROCEDURE FOR UPDATING MODULE
CREATE PROC spUpdateModule
(
	@Code VARCHAR(20),
	@modname VARCHAR(100),
	@moddesc VARCHAR(300),
	@modreources VARCHAR(200)
)
AS
BEGIN
	UPDATE [dbo].[modules] 
	SET 
		[module_code] = @Code,
		[module_name] = @modname,
		[module_description] = @moddesc,
		[module_resources] = @modreources
	WHERE [module_code] = @Code
END
GO

--PROCEDURE FOR INSERTING NEW STUDENT
CREATE PROC spInsertStudent
(
	@number INT,
	@Name VARCHAR(20),
	@Image VARBINARY(MAX),
	@DOB Date,
	@Gender VARCHAR(25),
	@Phone VARCHAR(12),
	@City VARCHAR(100),
	@Province VARCHAR(100),
	@Street VARCHAR(100)
)
AS
BEGIN
	INSERT INTO [dbo].[students] ([student_number], [student_name], [student_image], [student_dob], [student_gender], [student_phone], [student_city], [student_province], [student_street])
	VALUES (@number, @Name, @Image, @DOB, @Gender, @Phone, @City,@Province,@Street)
END
GO
--PROCEDURE FOR INSERTING MODULE
CREATE PROC spInsertModule
(
	@Code VARCHAR(20),
	@modname VARCHAR(100),
	@moddesc VARCHAR(300),
	@modreources VARCHAR(200)
)
AS
BEGIN
	INSERT INTO [dbo].[modules] ([module_code], [module_name], [module_description], [module_resources])
	VALUES (@Code, @modname, @moddesc, @modreources)
END
GO

--PROCEDURE TO DISPLAY ALL STUDENTS
CREATE PROC spGetStudent 
AS
BEGIN
	SELECT * FROM [dbo].[students]
END
GO
--PROCEDURE TO DISPLAY ALL MODULES
CREATE PROC spGetModules
AS
BEGIN
	SELECT * FROM [dbo].[modules]
END
GO
--PROCEDURE TO SEARCH FOR STUDENT
CREATE PROC spSearchStudent
(
	@stunum INT
)
AS
BEGIN
	SELECT * FROM [dbo].[students]
	WHERE [student_number] = @stunum
END
GO
--PROCEDURE TO SEACH FOR MODULE
CREATE PROC spSearcModule
(
	@modcode VARCHAR(20)
)
AS
BEGIN
	SELECT * FROM [dbo].[modules]
	WHERE [module_code] = @modcode
END
GO
--PROCEDURE TO ASSIGN MODULE TO STUDENT
CREATE PROC spStudentModule
(	
	@modcode VARCHAR(20),
	@studentnum INT
)
AS
BEGIN
	INSERT INTO [dbo].[students_modules] ([mod_code], [student_num])
	VALUES (@studentnum, @modcode)
END
GO
--PROCEDURE TO DISPLAY ALL STUDENTS IN A MODULE
CREATE PROC spStudentsInModule
(
	@modcode VARCHAR(20)
)
AS
BEGIN
	SELECT * FROM [dbo].[students]
	WHERE [student_number] IN (SELECT [student_num] FROM [dbo].[students_modules] WHERE [mod_code] = @modcode)
END
GO
--PRODEDURE TO DISPLAY ALL MODULES FOR A STUDENT
CREATE PROC spModulesForStudent
(
	@stunum INT
)
AS
BEGIN
	SELECT * FROM [dbo].[modules]
	WHERE [module_code] IN (SELECT [mod_code] FROM [dbo].[students_modules] WHERE [student_num] = @stunum)
END
GO

--INSERTING DATA
EXEC [dbo].[spInsertStudent] @number = 578671, @Name = 'Albert Smith', @Image = NULL, @DOB = '2001/04/11', @Gender = 'Male', @Phone = '087481674', @City = 'Pretoria', @Province = 'Gauteng', @Street = '3d Street'
EXEC [dbo].[spInsertStudent] @number = 596854, @Name = 'Susan Botha', @Image = NULL, @DOB = '2001/06/21', @Gender = 'Female', @Phone = '0827385761', @City = 'Centurion', @Province = 'Gauteng', @Street = '5th Street'
EXEC [dbo].[spInsertStudent] @number = 556856, @Name = 'Roger McDen', @Image = NULL, @DOB = '2002/11/01', @Gender = 'Male', @Phone = '087481674', @City = 'Kemptonpark', @Province = 'Gauteng', @Street = '28th Street'
EXEC [dbo].[spInsertStudent] @number = 598574, @Name = 'Ivan Anderson', @Image = NULL, @DOB = '1999/07/11', @Gender = 'Male', @Phone = '0786988224', @City = 'Pretoria', @Province = 'Gauteng', @Street = '27th Street'

EXEC [dbo].[spInsertModule] @Code = 'PRG281', @modname = 'Progamming', @moddesc = 'C# Programming', @modreources = 'https://www.c#progamming.com'
EXEC [dbo].[spInsertModule] @Code = 'INL101', @modname = 'Innovation and Leadership', @moddesc = 'Innovation', @modreources = 'https://www.learninl.com'
EXEC [dbo].[spInsertModule] @Code = 'NWD181', @modname = 'Network Development', @moddesc = 'Basics of network development', @modreources = 'https://www.networkdevelopment.com'
EXEC [dbo].[spInsertModule] @Code = 'MAT2811', @modname = 'Mathematics', @moddesc = 'Foundation of calculus', @modreources = 'https://www.calculus.com'

EXEC [dbo].[spStudentModule] @modcode = 'Prg281', @studentnum = 578671
EXEC [dbo].[spStudentModule] @modcode = 'INL101', @studentnum = 578671
EXEC [dbo].[spStudentModule] @modcode = 'NWD181', @studentnum = 556856
EXEC [dbo].[spStudentModule] @modcode = 'NWD181', @studentnum = 598574

