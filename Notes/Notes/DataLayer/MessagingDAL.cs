using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Notes.BusinessLayel;

namespace Notes.DataLayer
{
    public class MessagingDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConn"].ToString());
        SqlCommand cmd;

        public int UserLogin(clsUser user)
        {
            int UserID = -1;           
            cmd = new SqlCommand("sp_UserLogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pUserName", user.UserName);
            cmd.Parameters.AddWithValue("@pPassword", user.Password);
            cmd.Parameters.AddWithValue("@oResult", SqlDbType.Int);
            cmd.Parameters["@oResult"].Direction = ParameterDirection.Output;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            UserID = Convert.ToInt32(cmd.Parameters["@oResult"].Value);
            return UserID;
        }
        public bool InsertNotes(clsNotes notes)
        {
            bool status = false;
            cmd = new SqlCommand("sp_InsertNotes", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pMode", notes.Mode);
            cmd.Parameters.AddWithValue("@pUserId", notes.Userid);
            cmd.Parameters.AddWithValue("@pTitle", notes.Title);
            cmd.Parameters.AddWithValue("@pBody", notes.Body);
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            if (res > 0)
            {
                status = true;
            }
            return status;
        }
        public DataTable GetNotesData()
        {
            cmd = new SqlCommand("sp_GetNotes", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}