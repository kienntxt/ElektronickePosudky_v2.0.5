/*
  This script uses SQLCMD variable substitution.
  Variables: $(DB_NAME), $(DB_USER), $(DB_PASSWORD)
*/

USE master
GO

-- 1. Create the Database
-- We check sys.databases to ensure that we don't try to recreate an existing DB
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = N'$(DB_NAME)')
BEGIN
    PRINT 'Creating database $(DB_NAME)...';
    CREATE DATABASE [$(DB_NAME)];
END
ELSE
BEGIN
    PRINT 'Database $(DB_NAME) already exists.';
END
GO

-- 2. Create the Server Login
-- Logins are server-wide objects. Use the master context or specify scope.
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = N'$(DB_USER)')
BEGIN
    PRINT 'Creating login $(DB_USER)...';
    CREATE LOGIN [$(DB_USER)] WITH PASSWORD = N'$(DB_PASSWORD)', 
           DEFAULT_DATABASE = [$(DB_NAME)], 
           CHECK_EXPIRATION = OFF, 
           CHECK_POLICY = OFF;
END
ELSE
BEGIN
    PRINT 'Login $(DB_USER) already exists.';
END
GO

-- 3. Create the Database User
-- Switch context to the target database to create the user and assign roles
USE [$(DB_NAME)];
GO

IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'$(DB_USER)')
BEGIN
    PRINT 'Creating user $(DB_USER) in database $(DB_NAME)...';
    CREATE USER [$(DB_USER)] FOR LOGIN [$(DB_USER)];
    
    -- Grant db_owner permissions so the API can manage its own schema (migrations)
    ALTER ROLE [db_owner] ADD MEMBER [$(DB_USER)];
END
ELSE
BEGIN
    PRINT 'User $(DB_USER) already exists in database $(DB_NAME).';
END
GO