using System.Data;
using System.Data.SqlClient;

namespace Final_Project_2022
{
    internal class DatabaseOperating
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CA3ARHV;Initial Catalog=Hotel Management Final 2022;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True;");

        // get the connection for whole the project
        public SqlConnection GetConnection
        {
            get { return con; }
        }

        //open the connection

        public void openConnection()
        {
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
        }

        //close the connection
        public void closeConnection()
        {
            if ((con.State == ConnectionState.Open))
            {
                con.Close();
            }
        }
    }
}
/*
 Create table employee
CREATE TABLE [dbo].[employee] (
    [id]              INT           NOT NULL,
    [name]            NVARCHAR (50) NOT NULL,
    [position]        NVARCHAR (50) NOT NULL,
    [birthDate]       DATETIME      NOT NULL,
    [gender]          NVARCHAR (50) NOT NULL,
    [phoneNum]        NVARCHAR (50) NOT NULL,
    [email]           NVARCHAR (50) NOT NULL,
    [image]           IMAGE         NULL,
    [salary_per_hour] REAL          NOT NULL,
    [username]        NVARCHAR (50) NOT NULL,
    [password]        NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [U_employee] UNIQUE NONCLUSTERED ([id] ASC, [username] ASC)
);


 
 */