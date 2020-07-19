use DBMS_ProjectManagement
go
CREATE FUNCTION fn_listProject(@ID nvarchar(10)) 
RETURNS TABLE AS RETURN 
( 
select * from Project WHERE PID in ( SELECT Project_PID FROM StudentProjects WHERE Student_ID = @ID)
); 
go

CREATE FUNCTION Func_Tongsv(@PID VARCHAR(10))
RETURNS @statisticsTable TABLE
     (
            PID VARCHAR(10),
            PName NVARCHAR(100),
            totalStudent    INT
      ) 
AS
      BEGIN
            IF @PID=0
                    INSERT INTO @statisticsTable
                    SELECT StudentProject.Project_ID,Project.PName,COUNT(StudentProject.Student_ID) 
                    FROM (Student INNER JOIN StudentProject
                    ON Student.ID =StudentProject.Student_ID)
                    inner join Project
                    on StudentProjects.Project_PID = Project.PID
                    GROUP BY StudentProjects.Project_PID,Project.PName
            ELSE
                INSERT INTO @statisticsTable
                SELECT StudentProject.Project_ID,Project.PName,COUNT(StudentProject.Student_ID) 
                FROM (Student INNER JOIN StudentProject
                ON Student.ID =StudentProject.Student_ID)
                inner join Project
                on StudentProjects.Project_PID = Project.PID
                where StudentProject.Project_ID = @PID
                GROUP BY StudentProjects.Project_PID,Project.PName
                    RETURN 
      END


--drop function fn_listProject
--go
--select * from dbo.fn_listProject('18110010')
--go