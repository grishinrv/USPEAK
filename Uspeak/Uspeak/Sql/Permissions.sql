﻿USE [master]
GO
CREATE LOGIN [UspeakTech] WITH PASSWORD=N'UspeakTech', 
                 DEFAULT_DATABASE=[Uspeak], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
USE [Uspeak]
GO
CREATE USER [UspeakTech] FOR LOGIN [UspeakTech] WITH DEFAULT_SCHEMA=[dbo]
GO


Use [Uspeak];
GRANT SELECT ON "dbo"."Tags" TO [UspeakTech];
GRANT SELECT ON "dbo"."User" TO [UspeakTech];
GRANT SELECT ON "dbo"."TestSettings" TO [UspeakTech];
GRANT SELECT ON "dbo"."QuestionSettings" TO [UspeakTech];
GRANT SELECT ON "dbo"."Images" TO [UspeakTech];
GRANT SELECT ON "dbo"."EntitiesTags" TO [UspeakTech];
GRANT SELECT ON "dbo"."Entities" TO [UspeakTech];
GRANT SELECT ON "dbo"."Courses" TO [UspeakTech];
GRANT SELECT ON "dbo"."Entities" TO [UspeakTech];
GRANT SELECT ON "dbo"."Config" TO [UspeakTech];
GRANT SELECT ON "dbo"."AnswerOption" TO [UspeakTech];
GRANT CREATE TABLE TO [UspeakTech];



ALTER LOGIN UspeakTech ENABLE ;
GO
ALTER LOGIN UspeakTech WITH PASSWORD = 'UspeakTech' ;
GO


USE [Uspeak]
GO
EXEC xp_instance_regwrite N'HKEY_LOCAL_MACHINE',
     N'Software\Microsoft\MSSQLServer\MSSQLServer',
     N'LoginMode', REG_DWORD, 1
GO