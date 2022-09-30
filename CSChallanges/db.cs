using System.Data.SqlClient;

class db {

    public void Connect() {
    string sql = "Select id,name from test ";


        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-C4DH0VP\SQLEXPRESS;Initial Dialog=test;User ID=DESKTOP-C4DH0VP\serin");
        conn.Open();
        SqlCommand asd = new SqlCommand(sql, conn);

        SqlDataReader datareader = asd.ExecuteReader();

        if (datareader.Read()) {
            Console.WriteLine(datareader["name"].ToString());
        } else {
            throw new ArgumentException("error");
        }
    }
}