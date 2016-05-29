using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
/// <summary>
/// User 的摘要说明
/// </summary>
public class User
{
	public User()
	{

	}
    public bool insertUser(string username,string realname,string passsword,int department,int power)
    {
        //password加密
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con= new MySqlConnection(strCon);
        string strCmd = "insert into User (username,realname,password,department,power) values(@username)";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);

        MySqlParameter valueusername = new MySqlParameter("@username", MySqlDbType.VarChar);
        valueusername.Value = username;
        cmd.Parameters.Add(valueusername);


        MySqlDataReader r = cmd.ExecuteReader();
        bool result = r.Read();
        con.Close();
        if (result)
            return true;
        else
            return false;     
    }
}