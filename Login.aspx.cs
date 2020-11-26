using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace OperacionLaboratorios
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            LblFunciona.Visible = false;
        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-SS6114R\SQLEXPRESS;Initial Catalog=LaboratoriosFisica;Integrated Security=True"))
            {
                sqlCon.Open();
                string query = "SELECT COUNT(1) FROM Docentes WHERE id=@id AND contrasena=@contrasena";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@id", txtCuenta.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@contrasena", txtContrasena.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                
                if(count==1)
                {
                    Session["id"] = txtCuenta.Text.Trim();
                    
                    Response.Redirect("Objetivo.aspx");
                }
                else
                {
                    lblError.Visible = true;
                }
            }
        }
    }
}
