﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalesManagementPortal
{
    public partial class Comments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Userid"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            LibraryDb.SelectCommand = "SELECT Id,Message,convert(nvarchar, Datetime, 121) as Datetime,CreatedUserId FROM [Announcement_table] Where  [CreatedUserId]='" + Session["UserId"].ToString() + "'";

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SalePortalConnectionString"].ConnectionString);
                SqlCommand cmd = new SqlCommand("insert into Announcement_table (Message,datetime,CreatedUserId) values (@name,@datetime,@lUserid)", conn);
                cmd.Parameters.AddWithValue("@name", txtStudentId.Text);
                cmd.Parameters.AddWithValue("@datetime", txtStudentName.Text);
                cmd.Parameters.AddWithValue("@lUserid", Session["UserId"].ToString());

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    GridView1.DataBind();
                    txtStudentId.Text = "";
                    txtStudentName.Text = "";
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    conn.Close();
                }


            }
            catch (Exception ex)
            {

            }

        }
    }
    }

