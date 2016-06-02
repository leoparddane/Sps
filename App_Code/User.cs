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

    public string encryption(string password)
    {
        //加密
       // System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5");
        return password;
    }

    public bool isPasswordCorrectByUserID(int id, string password)
    {
        bool result=false;
       // if (encryption(password) == getUserPasswordByID(id))
        if (password == getUserPasswordByID(id))
            result = true;
        return result;
    }

    public bool isPasswordCorrectByUsername(string username, string password)
    {
        bool result = false;
        // if (encryption(password) == getUserPasswordByID(id))
        if (password == getUserPasswordByUsername(username))
            result = true;
        return result;
    }

    public bool insertUser(string username,string realname,string passsword,int department,int power)
    {
        //password加密
        passsword = encryption(passsword);
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con= new MySqlConnection(strCon);
        string strCmd = "insert into user (username,realname,password,department,power) values(@username,@realname,@password,@department,@power)";
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

        bool retu=false;
        if (cmd.ExecuteNonQuery() > 0)
            retu = true;

        con.Close();//关闭连接
        return retu;   
    }

    public bool hasUserByUsername(string username)
    {
        //password加密
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "select count(*) from user where username='" + username + "'";
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

    public bool hasUserByRealname(string realname)
    {
        //password加密
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "select count(*) from user where realname='" + realname + "'";
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

    public string getUserRealnameByID(int id)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "select realname from user where id=" + id ;
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);
        MySqlDataReader r = cmd.ExecuteReader();
        if (r.Read())
        {
            string realname = r[0].ToString();
            con.Close();
            return realname;
        }
        con.Close();
        return "";
    }

    public string getUserRealnameByUsername(string username)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "select realname from user where username='" + username + "'";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);
        MySqlDataReader r = cmd.ExecuteReader();
        if (r.Read())
        {
            string realname = r[0].ToString();
            con.Close();
            return realname;
        }
        con.Close();
        return "";
    }

    public string getUserPasswordByID(int id)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "select password from user where id=" + id;
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);
        MySqlDataReader r = cmd.ExecuteReader();
        if (r.Read())
        {
            string password = r[0].ToString();
            con.Close();
            return password;
        }
        con.Close();
        return "";
    }

    public string getUserPasswordByUsername(string username)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "select password from user where username='" + username + "'";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);
        MySqlDataReader r = cmd.ExecuteReader();
       
        if (r.Read())
        {
            string password = r[0].ToString();
            con.Close();
            return password;
        }
        con.Close();
        return "";
    }

    public int getUserDepartmentIDByUserID(int id)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "select department from user where id=" + id;
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);
        MySqlDataReader r = cmd.ExecuteReader();
        if (r.Read())
        {
            string department = r[0].ToString();
            con.Close();
            return Convert.ToInt32(department);
        }
        con.Close();
        return -1;
    }

    public int getUserDepartmentIDByUsername(string username)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "select department from user where username='" + username+"'";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);
        MySqlDataReader r = cmd.ExecuteReader();
        if (r.Read())
        {
            string department = r[0].ToString();
            con.Close();
            return Convert.ToInt32(department);
        }
        con.Close();
        return -1;
    }

    public int getUserDepartmentIDByUserrealname(string realname)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "select department from user where realname='" + realname + "'";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);
        MySqlDataReader r = cmd.ExecuteReader();
        if (r.Read())
        {
            string department = r[0].ToString();
            con.Close();
            return Convert.ToInt32(department);
        }
        con.Close();
        return -1;
    }

    public int getUserPowerByUserID(int id)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "select power from user where id=" + id;
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);
        MySqlDataReader r = cmd.ExecuteReader();
        if (r.Read())
        {
            string department = r[0].ToString();
            con.Close();
            return Convert.ToInt32(department);
        }
        con.Close();
        return -1;
    }

    public int getUserPowerByUsername(string username)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "select power from user where username='" + username + "'";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);
        MySqlDataReader r = cmd.ExecuteReader();
        if (r.Read())
        {
            string department = r[0].ToString();
            con.Close();
            return Convert.ToInt32(department);
        }
        con.Close();
        return -1;
    }

    public int getUserPowerByUserrealname(string realname)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "select power from user where realname='" + realname + "'";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);
        MySqlDataReader r = cmd.ExecuteReader();
        if (r.Read())
        {
            string department = r[0].ToString();
            con.Close();
            return Convert.ToInt32(department);
        }
        con.Close();
        return -1;
    }

    public bool updateRealnameByID(int id, string realname)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "update user set realname=@realname where id=" + id;
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);

        MySqlParameter valuerealname = new MySqlParameter("@realname", MySqlDbType.VarChar);
        valuerealname.Value = realname;
        cmd.Parameters.Add(valuerealname);

        bool retu = false;
        if (cmd.ExecuteNonQuery() > 0)
            retu = true;

        con.Close();//关闭连接
        return retu;
    }

    public bool updateRealnameByUsername(string username, string realname)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "update user set realname=@realname where username='" + username + "'";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);

        MySqlParameter valuerealname = new MySqlParameter("@realname", MySqlDbType.VarChar);
        valuerealname.Value = realname;
        cmd.Parameters.Add(valuerealname);

        bool retu = false;
        if (cmd.ExecuteNonQuery() > 0)
            retu = true;

        con.Close();//关闭连接
        return retu;
    }

    public bool updatePasswordByID(int id,string password)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "update user set password=@password where id=" + id ;
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);

        MySqlParameter valuepassword = new MySqlParameter("@password", MySqlDbType.VarChar);
        valuepassword.Value = password;
        cmd.Parameters.Add(valuepassword);

        bool retu = false;
        if (cmd.ExecuteNonQuery() > 0)
            retu = true;

        con.Close();//关闭连接
        return retu;   
    }

    public bool updatePasswordByUsername(string username, string password)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "update user set password=@password where username='" + username + "'";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);

        MySqlParameter valuepassword = new MySqlParameter("@password", MySqlDbType.VarChar);
        valuepassword.Value = password;
        cmd.Parameters.Add(valuepassword);

        bool retu = false;
        if (cmd.ExecuteNonQuery() > 0)
            retu = true;

        con.Close();//关闭连接
        return retu;
    }

    public bool updateDepartmentByID(int id, string department)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "update user set department=@department where id=" + id;
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);

        MySqlParameter valueDepartment = new MySqlParameter("@department", MySqlDbType.VarChar);
        valueDepartment.Value = department;
        cmd.Parameters.Add(valueDepartment);

        bool retu = false;
        if (cmd.ExecuteNonQuery() > 0)
            retu = true;

        con.Close();//关闭连接
        return retu;
    }

    public bool updateDepartmentByUsername(string username, string department)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "update user set department=@department where username='" + username + "'";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);

        MySqlParameter valueDepartment = new MySqlParameter("@department", MySqlDbType.VarChar);
        valueDepartment.Value = department;
        cmd.Parameters.Add(valueDepartment);

        bool retu = false;
        if (cmd.ExecuteNonQuery() > 0)
            retu = true;

        con.Close();//关闭连接
        return retu;
    }

    public bool updatePowerByID(int id, int power)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "update user set power=@power where id=" + id;
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);

        MySqlParameter valuePower = new MySqlParameter("@power", MySqlDbType.Int16);
        valuePower.Value = power;
        cmd.Parameters.Add(valuePower);

        bool retu = false;
        if (cmd.ExecuteNonQuery() > 0)
            retu = true;

        con.Close();//关闭连接
        return retu;
    }

    public bool updatePowerByUsername(string username, int power)
    {
        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "update user set power=@power where username='" + username + "'";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);

        MySqlParameter valuePower = new MySqlParameter("@power", MySqlDbType.Int16);
        valuePower.Value = power;
        cmd.Parameters.Add(valuePower);

        bool retu = false;
        if (cmd.ExecuteNonQuery() > 0)
            retu = true;

        con.Close();//关闭连接
        return retu;
    }
   
    public bool removeUserByID(int id)
    {

        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "delete from user where id=@id"  ;
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);

        MySqlParameter valueIDr = new MySqlParameter("@id", MySqlDbType.Int16);
        valueIDr.Value = id;
        cmd.Parameters.Add(valueIDr);

        bool retu = false;
        if (cmd.ExecuteNonQuery() > 0)
            retu = true;

        con.Close();//关闭连接
        return retu;
    }

    public bool removeUserByUsername(string username)
    {

        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "delete from user where username=@idusername";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);

        MySqlParameter valueusername = new MySqlParameter("@username", MySqlDbType.Int16);
        valueusername.Value = username;
        cmd.Parameters.Add(valueusername);

        bool retu = false;
        if (cmd.ExecuteNonQuery() > 0)
            retu = true;

        con.Close();//关闭连接
        return retu;
    }

    public bool removeUserByUserrealname(string realname)
    {

        String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "delete from user where realname=@realname";
        con.Open();
        MySqlCommand cmd = new MySqlCommand(strCmd, con);

        MySqlParameter valuerealname = new MySqlParameter("@realname", MySqlDbType.Int16);
        valuerealname.Value = realname;
        cmd.Parameters.Add(valuerealname);

        bool retu = false;
        if (cmd.ExecuteNonQuery() > 0)
            retu = true;

        con.Close();//关闭连接
        return retu;
    }
}