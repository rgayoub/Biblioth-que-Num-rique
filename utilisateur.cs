using MaterialSkin2DotNet.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFMbiblio
{
    public partial class utilisateurForm : MaterialForm
    {
        SqlDataReader reader;
        SqlCommand query;
        SqlConnection cnx;
        public utilisateurForm()
        {
            InitializeComponent();
        }

        private void utilisateur_Load(object sender, EventArgs e)
        {

        }

        private void Btnutilisateurconnecter_Click(object sender, EventArgs e)
        {
            cnx = Program.GetSqlConnection();
            cnx.Open();
            query = new SqlCommand("select role from utilisateur where username=@login and password=@pwd", cnx);
            query.Parameters.AddWithValue("login", textUtilisateur.Text);
            query.Parameters.AddWithValue("pwd", textModepasse.Text);
            reader = query.ExecuteReader();
            if (!reader.Read())
                MessageBox.Show("Login ou mot de passe incorrect", "Erreur ", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
            {
                string role = reader.GetString(0);
                Hide();
                if (role.ToUpper().Equals("ADMIN"))
                    new DashboardAdmin().Show();
                else
                    new DashboardGerant().Show();
            }
        }
    }
}
