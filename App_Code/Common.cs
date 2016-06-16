using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

/// <summary>
/// 常用功能，添加记录、删除记录等
/// </summary>
public class Common
{
    String strCon = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ToString();
 
	public Common()
	{
	}

    public bool createRecord(string username)
    {
        bool result=false;
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "insert into smsapply(username,class,time,info,state,weeek,day,timeDuring,number) values(@username,@class,@time,@info,@state,@weeek,@day,@timeDuring,@number)";
        MySqlCommand cmd = new MySqlCommand(strCmd, con);
        MySqlParameter valueusername = new MySqlParameter("@username", MySqlDbType.VarChar);
        valueusername.Value = username;
        cmd.Parameters.Add(valueusername);

        if (cmd.ExecuteNonQuery()>0)
            result = true;
        con.Open();
        con.Close();
        return result;
    }

    public bool deleteRecordByID(int idValue)
    {
        bool result = false;
        MySqlConnection con = new MySqlConnection(strCon);
        string strCmd = "delete from smsapply where id=@id";
        MySqlCommand cmd = new MySqlCommand(strCmd, con);
        MySqlParameter id = new MySqlParameter("@id", MySqlDbType.Int32);
        id.Value = idValue;
        cmd.Parameters.Add(id);

        if (cmd.ExecuteNonQuery() > 0)
            result = true;
        con.Open();
        con.Close();
        return result;
    }
}