USE [IdeaForSelDB]
GO
/****** Object:  StoredProcedure [dbo].[Create_New_User]    Script Date: 3/10/2017 11:48:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE Create_New_User @user_Name nvarchar(50), @password nvarchar(50)

AS
--begin transaction, because we can got some exceptionon database side than we need to delete data if insert some
	BEGIN TRY
		BEGIN TRANSACTION

			Insert into Users(Login, Password, UserRoleId) values (@user_Name, @password, 1);
			
			--save user id after insert into Users Table new record
			declare @user_id int = @@IDENTITY;

			Insert into DateOfRegistration (UserId) values (@user_id);

			Insert into Persons (UserId, FirstName,LastName, MidleName) values 
				(@user_id, N'Enter your FirstName',N'Enter your LastName', N'Enter your MiddelName');

			Insert into PersonInfo (AboutData, LocationData, UserId) values 
				(N'Please, add data about your self', N'Where did you from?', @user_id);

			--after that we are select our User
			select  *  from UserInfoData as u where u.UserId = @user_id 

			COMMIT TRANSACTION
		END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
