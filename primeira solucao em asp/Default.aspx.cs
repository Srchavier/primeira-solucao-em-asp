using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace primeira_solucao_em_asp
{
    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            con.Open();
            disp_data();
        }

   
        public void disp_data()
        {
            try
            {

                {
                    using (SqlCommand cCommand = new SqlCommand())
                    {
                        cCommand.Connection = con;
                        cCommand.CommandType = CommandType.Text;

                        cCommand.CommandText = "select * from table1";

                        DataTable dtRetorno = new DataTable();

                        using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(cCommand))
                        {
                            sqlAdapter.Fill(dtRetorno);
                            GridView1.DataSource = dtRetorno;
                            GridView1.DataBind();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into table1 values ('teste', 'teste' )";
            cmd.ExecuteReader();
            con.Close();

            disp_data();
        }
    }
}