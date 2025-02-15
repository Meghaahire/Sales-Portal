﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SalesManagementPortal
{
    public partial class OppType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Userid"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            LibraryDb.SelectCommand = "SELECT * FROM [OppType_Table] Where [CreatedByUserId]='" + Session["UserId"].ToString() + "'";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SalePortalConnectionString"].ConnectionString);
                SqlCommand cmd = new SqlCommand("insert into OppType_Table (Name,CreatedByUserId) values (@name,@Userid)", conn);
                cmd.Parameters.AddWithValue("@name", txtStudentId.Text);
                cmd.Parameters.AddWithValue("@Userid", Session["Userid"].ToString());
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    GridView1.DataBind();
                    txtStudentId.Text = "";
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
