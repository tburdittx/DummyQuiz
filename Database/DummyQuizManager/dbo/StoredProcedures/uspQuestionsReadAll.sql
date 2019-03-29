-- =============================================
-- Author:		Tara Burditt
-- Create date: 3/29/2019
-- Description:	Reads all questions 
-- =============================================
CREATE PROCEDURE uspQuestionsReadAll

AS
BEGIN
	SET NOCOUNT ON;
SELECT [Id]
      ,[Question]
      ,[OptionA]
      ,[OpitonB]
      ,[OptionC]
      ,[OptionD]
      ,[Answer]
      ,[Explanation]
  FROM [DummyQuizManager].[dbo].[Questions]

END
GO