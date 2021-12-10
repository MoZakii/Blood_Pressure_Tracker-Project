using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace Blood_Pressure_Tracker_Project
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        private string connectionString = "Data Source=DESKTOP-JM7LPJ2;Initial Catalog=Blood_Pressure_Tracker;Integrated Security=True";

        // User Table
        [WebMethod]
        public void insertData(string username, string password, int age, float weight, char gender)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand("insert into Users (Username,Password,Age,Weight,Gender) values(@a,@b,@c,@d,@e)", conn);
            comm.Parameters.Add(new SqlParameter("@a", username));
            comm.Parameters.Add(new SqlParameter("@b", password));
            comm.Parameters.Add(new SqlParameter("@c", age));
            comm.Parameters.Add(new SqlParameter("@d", weight));
            comm.Parameters.Add(new SqlParameter("@e", gender));
            comm.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        public UserInfo ViewUserInfo(int Id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand("select * from Users where ID = @x ", conn);
            comm.Parameters.Add(new SqlParameter("@x", Id));
            SqlDataReader Data = comm.ExecuteReader();

            if (!Data.HasRows)
            {
                throw new Exception("User Not Found");
            }
            Data.Read();

            UserInfo usrData = new UserInfo(int.Parse(Data[0].ToString()), Data[1].ToString(), int.Parse(Data[2].ToString())
                , float.Parse(Data[3].ToString()), Data[4].ToString()[0]);

            Data.Close();
            conn.Close();
            return usrData;
        }
        [WebMethod]
        public void UpdateUserInfo(int id, string username, int age, float weight)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand("update Users set Age=@a,Weight=@b where Username=@c", conn);
            comm.Parameters.Add(new SqlParameter("@a", age));
            comm.Parameters.Add(new SqlParameter("@b", weight));
            comm.Parameters.Add(new SqlParameter("@c", username));
            comm.ExecuteNonQuery();
            conn.Close();
        }
        [WebMethod]
        public int getID(string username)
        {
            
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand("select ID from Users where Username = @x ", conn);
            comm.Parameters.Add(new SqlParameter("@x", username));
            
            int id = -1;
            SqlDataReader IDReader = comm.ExecuteReader();
            if (!IDReader.HasRows)
                throw new Exception("User not Found");
            else
            {
                IDReader.Read();
                id = int.Parse(IDReader[0].ToString());
            }
            IDReader.Close();
            conn.Close();

            return id;
        }
        [WebMethod]
        public bool checkUsernameAvailability(string username)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand("select * from Users where Username = @x ", conn);
            comm.Parameters.Add(new SqlParameter("@x", username));

            SqlDataReader DataReader = comm.ExecuteReader();
            bool available = false;

            if (!DataReader.HasRows)
                available = true;
            else
                available = false;

            DataReader.Close();
            conn.Close();

            return available;
        }
        [WebMethod]
        public bool checkPassword(string username, string Password)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand("select Password from Users where Username = @x and Password = @y ", conn);
            comm.Parameters.Add(new SqlParameter("@x", username));
            comm.Parameters.Add(new SqlParameter("@y", Password));

            SqlDataReader DataReader = comm.ExecuteReader();
            bool correct = false;
            if (!DataReader.HasRows)
                correct = false;
            else
                correct = true;

            DataReader.Close();
            conn.Close();

            return correct;
        }
        // User Pressure Table
        [WebMethod]
        public List<PressureReading> GetUserPressureReadings(int id)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand getData = new SqlCommand("Select * from User_Pressure_Reading where id = @a", conn);
            getData.Parameters.Add("@a", id);

            SqlDataReader Data = getData.ExecuteReader();

            List<PressureReading> UserReadingPressures = new List<PressureReading>();

            while (Data.Read())
            {
                // 0 id    1 order  2 high  3 low   4 date
                UserReadingPressures.Add(new PressureReading(int.Parse(Data[1].ToString()), int.Parse(Data[2].ToString())
                    , int.Parse(Data[3].ToString()), Data[4].ToString()));
            }

            Data.Close();
            conn.Close();
            return UserReadingPressures;
        }
        [WebMethod]
        public void insertPressureData(int Id, int Order, int High, int Low, string Date)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand comm = new SqlCommand("insert into User_Pressure_Reading (ID , Reading_Order , High ,Low , Date) values(@a,@b,@c,@d,@e)", conn);
            comm.Parameters.Add(new SqlParameter("@a", Id));
            comm.Parameters.Add(new SqlParameter("@b", Order));
            comm.Parameters.Add(new SqlParameter("@c", High));
            comm.Parameters.Add(new SqlParameter("@d", Low));
            comm.Parameters.Add(new SqlParameter("@e", Date));
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
    public class PressureReading
    {
        int ReadingOrder { get; }
        int High { get; }
        int Low { get; }
        string Date { get; }

        public PressureReading(int readingOrder, int high, int low, string date)
        {
            ReadingOrder = readingOrder;
            High = high;
            Low = low;
            Date = date;
        }
        public PressureReading()
        {
            ReadingOrder = -1;
            High = -1;
            Low = -1;
            Date = "";
        }

    }
    public class UserInfo
    {
        int ID;
        string UserName;
        int Age;
        float Weight;
        char Gender;

        public UserInfo(int iD, string userName, int age, float weight, char gender)
        {
            ID = iD;
            UserName = userName;
            Age = age;
            Weight = weight;
            Gender = gender;
        }

        public UserInfo()
        {
            ID = 0;
            UserName = "";
            Age = 0;
            Weight = 0;
            Gender = '_';
        }
    }
}