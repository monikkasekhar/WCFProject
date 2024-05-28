using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


/// <summary>
/// Summary description for Connectionclass
/// </summary>
public class Connectionclass
{
    SqlConnection con;
    SqlCommand cmd;
    public Connectionclass()
    {
        con = new SqlConnection(@"server=MSI\SQLEXPRESS;database=DB_Project;Integrated security=true");
    }

    public SqlDataReader Fn_ExeReader(string s)
    {
        if(con.State==ConnectionState.Open)
        {
            con.Close();
        }
        cmd = new SqlCommand(s,con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        return dr;
    }
}