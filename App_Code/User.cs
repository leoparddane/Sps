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
        string strCmd = "insert into User (username,realname,password,department,power) values(@username,@realname,@password,@department,@power)";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);

        MySqlParameter valueusername = new MySqlParameter("@username", MySqlDbType.VarChar);
        valueusername.Value = username;
        cmd.Parameters.Add(valueusername);

        MySqlParameter valuerealname = new MySqlParameter("@realname", MySqlDbType.VarChar);
        valuerealname.Value = realname;
        cmd.Parameters.Add(valuerealname);

        MySqlParameter valuepassword = new MySqlParameter("@password", MySqlDbType.VarChar);
        valuepassword.Value = passsword;
        cmd.Parameters.Add(valuepassword);

        MySqlParameter valuedepartment = new MySqlParameter("@department", MySqlDbType.Int16);
        valuedepartment.Value = department;
        cmd.Parameters.Add(valuedepartment);

        MySqlParameter valuepower = new MySqlParameter("@power", MySqlDbType.Int16);
        valuepower.Value = power;
        cmd.Parameters.Add(valuepower);


        MySqlDataReader r = cmd.ExecuteReader();
        bool result = r.Read();
        con.Close();
        if (result)
            return true;
        else
            return false;     
    }

    public bool hasUser(string username)
    {
        //password加密
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "select count(*) from User where username='"+username+"'";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);
        MySqlDataReader r = cmd.ExecuteReader();
        r.Read();
        string count = r[0].ToString();
        con.Close();
        if (Convert.ToInt32(count) == 0)
            return false;
        else
            return true;
    }

}