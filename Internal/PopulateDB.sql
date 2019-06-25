USE [SchoolDB]
GO

Declare @RandomStudentId int
Declare @RandomCourseId int


Declare @Id int
Set @Id = 1

While @Id <= 20
Begin 

Select @RandomStudentId = Round(((10 - 1) * Rand()) + 1, 0)
Select @RandomCourseId = Round(((6 - 1) * Rand()) + 1, 0)

INSERT INTO [dbo].[StudentCourse]
           ([StudentId]
           ,[CourseId])
     VALUES
           (@RandomStudentId
           ,@RandomCourseId)

   Print @Id
   Set @Id = @Id + 1
End

