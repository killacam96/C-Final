﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Final
{
    class SQLQueries
    {
        //CONNECTION STRING
        private SqlConnection con = new SqlConnection("server=localhost;database=AccountingTracker;UID=sa;password=123456789");


        public DataTable IdentifierUser(string userName, string password)
        {

            SqlCommand cmd2 = new SqlCommand("select * from UserInfo where UserName=@UserName AND Password=@Password", con);
            cmd2.Parameters.AddWithValue("@UserName", userName);
            cmd2.Parameters.AddWithValue("@Password", password);

            SqlDataAdapter sda = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            if (dt.Rows.Count > 0)
            {
                con.Close();

                return dt;
            }
            else
            {
                con.Close();
                return dt;
            }



        }

        public void DepositInsert(double amount,DateTime date, int userid)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Deposit (DeAmount, DeDate, UserId) VALUES (@amount, @date,@userid WHERE UserId = @userid2)", con);
            cmd.Parameters.AddWithValue("@amount", amount);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@userid", userid);
            cmd.Parameters.AddWithValue("@userid2", userid);
            con.Open();
            con.Close();
        }
    }
}
