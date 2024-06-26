using MaterialSkin2DotNet.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFMbiblio
{
    public partial class DashboardAdmin : MaterialForm
    {
        SqlConnection cnx;
        SqlCommand query;
        SqlDataReader reader;

        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            cnx = Program.GetSqlConnection();

            LoadEtudiant();
            LoadLivre();
            LoadResponsable();
            LoadReservation();
        }
        private void LoadEtudiant()
        {
            DataTable table = new DataTable();
            query = new SqlCommand("SELECT * FROM ETUDIANT", cnx);
            cnx.Open();
            reader = query.ExecuteReader();
            table.Load(reader);
            cnx.Close();
            reader.Close();
            dgvEtudiant.DataSource = table;
        }
        private void LoadLivre()
        {
            DataTable table = new DataTable();
            query = new SqlCommand("SELECT * FROM LIVRE", cnx);
            cnx.Open();
            reader = query.ExecuteReader();
            table.Load(reader);
            cnx.Close();
            reader.Close();
            dgvLivre.DataSource = table;
        }
        private void LoadResponsable()
        {
            DataTable table = new DataTable();
            query = new SqlCommand("SELECT * FROM RESPONSABLE", cnx);
            cnx.Open();
            reader = query.ExecuteReader();
            table.Load(reader);
            cnx.Close();
            reader.Close();
            dgvResponsable.DataSource = table;
        }
        private void LoadReservation()
        {
            DataTable table = new DataTable();
            query = new SqlCommand("SELECT * FROM RESERVATION", cnx);
            cnx.Open();
            reader = query.ExecuteReader();
            table.Load(reader);
            cnx.Close();
            reader.Close();
            dgvReservationListeA.DataSource = table;
        }

        private void Btn2FermerE_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txt2IdEtudiant_Click(object sender, EventArgs e)
        {

        }

        private void Btn2SupprimerE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur?", "suppresion", MessageBoxButtons.YesNo,
               MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                query = new SqlCommand();
                cnx.Open();
                query = new SqlCommand("Delete from ETUDIANT where  IDEtudiant=@num", cnx);
                query.Parameters.Add("num", SqlDbType.VarChar).Value = txt2IdEtudiant.Text;
                query.Connection = cnx;
                query.ExecuteNonQuery();
                cnx.Close();
                LoadEtudiant();
                MessageBox.Show("Etudiant supprimer avce succès");
            }
        }

        private void Btn2EnregistrerE_Click(object sender, EventArgs e)
        {
            query = new SqlCommand("SELECT IDEtudiant FROM ETUDIANT WHERE IDEtudiant=@num", cnx);
            query.Parameters.AddWithValue("num", txt2IdEtudiant.Text);
            cnx.Open();
            reader = query.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Etudiant Existe dejà ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Close();
                cnx.Close();
                return;
            }
            reader.Close();
            query = new SqlCommand("INSERT INTO ETUDIANT VALUES( @nom, @prenom, @email)", cnx);

            query.Parameters.Add("nom", SqlDbType.VarChar).Value = txt2Nom.Text;
            query.Parameters.Add("prenom", SqlDbType.VarChar).Value = txt2Prenom.Text;
            query.Parameters.Add("email", SqlDbType.VarChar).Value = txt2Email.Text;


            query.ExecuteNonQuery();
            cnx.Close();
            LoadEtudiant();
            MessageBox.Show("Etudiant enregistrée avec succès ", "Etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAjouterL_Click(object sender, EventArgs e)
        {
            query = new SqlCommand("SELECT IDLivre FROM LIVRE WHERE IDLivre=@num", cnx);
            query.Parameters.AddWithValue("num", txtIdLivre.Text);
            cnx.Open();
            reader = query.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Livre Existe dejà ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reader.Close();
                cnx.Close();
                return;
            }

            reader.Close();
            query = new SqlCommand("INSERT INTO LIVRE VALUES( @titre, @qte, @auteur, @etat, @categorie)", cnx);
            query.Parameters.Add("titre", SqlDbType.VarChar).Value = txtTitre.Text;
            query.Parameters.Add("qte", SqlDbType.Int).Value = txtQte.Text;
            query.Parameters.Add("auteur", SqlDbType.VarChar).Value = txtAuteur.Text;
            query.Parameters.Add("etat", SqlDbType.VarChar).Value = txtEtat.Text;
            query.Parameters.Add("categorie", SqlDbType.VarChar).Value = txtCategorie.Text;


            query.ExecuteNonQuery();
            cnx.Close();
            LoadEtudiant();
            MessageBox.Show("Livre enregistrée avec succès ", "Livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Btn2NouveauE_Click(object sender, EventArgs e)
        {

        }

        private void dgvEtudiant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt2IdEtudiant.Enabled = false;
            txt2IdEtudiant.Text = dgvEtudiant.CurrentRow.Cells[0].Value.ToString();
            txt2Nom.Text = dgvEtudiant.CurrentRow.Cells[1].Value.ToString();
            txt2Prenom.Text = dgvEtudiant.CurrentRow.Cells[2].Value.ToString();
            txt2Email.Text = dgvEtudiant.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvResponsable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idRespo.Enabled = false;
            idRespo.Text = dgvResponsable.CurrentRow.Cells[0].Value.ToString();
            txtNomResponsable.Text = dgvResponsable.CurrentRow.Cells[1].Value.ToString();
            txtPrenomResponsable.Text = dgvResponsable.CurrentRow.Cells[2].Value.ToString();
            txtEmailResponsable.Text = dgvResponsable.CurrentRow.Cells[3].Value.ToString();
            txtPasswordResponsable.Text = dgvResponsable.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

            query = new SqlCommand("INSERT INTO utilisateur(username, password, role) VALUES(@user, @pwd,'GERANT')", cnx);
            query.Parameters.Add("user", SqlDbType.VarChar).Value = txtUsername.Text;
            query.Parameters.Add("pwd", SqlDbType.VarChar).Value = txtPasswordResponsable.Text;
            cnx.Open();
            query.ExecuteNonQuery();
            query = new SqlCommand("SELECT MAX(ID) from utilisateur", cnx);
            int userID = Convert.ToInt32(query.ExecuteScalar().ToString());
            query = new SqlCommand("INSERT INTO RESPONSABLE VALUES(@nom, @prenom, @email,@pwd)", cnx);

            query.Parameters.Add("nom", SqlDbType.VarChar).Value = txtNomResponsable.Text;
            query.Parameters.Add("prenom", SqlDbType.VarChar).Value = txtPrenomResponsable.Text;
            query.Parameters.Add("email", SqlDbType.VarChar).Value = txtEmailResponsable.Text;
            query.Parameters.Add("pwd", SqlDbType.VarChar).Value = txtPasswordResponsable.Text;



            query.ExecuteNonQuery();
            cnx.Close();
            LoadResponsable();
            MessageBox.Show("Responsable enregistrée avec succès ", "Responsable", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtIdLivre_Click(object sender, EventArgs e)
        {

        }

        private void Btn2NouveauE_Click_1(object sender, EventArgs e)
        {
            txt2IdEtudiant.Clear();
            txt2Nom.Text = string.Empty;
            txt2Prenom.Text = string.Empty;
            txt2Email.Text = string.Empty;
        }

        private void Btn2ModifierE_Click(object sender, EventArgs e)
        {
            query = new SqlCommand();
            cnx.Open();
            query = new SqlCommand("update ETUDIANT set NomEtudiant=@nom, PrenomEtudiant=@prenom ,EmailEtudiant=@email where IDEtudiant=@num", cnx);
            query.Parameters.Add("num", SqlDbType.Int).Value = txt2IdEtudiant.Text;
            query.Parameters.Add("nom", SqlDbType.VarChar).Value = txt2Nom.Text;
            query.Parameters.Add("prenom", SqlDbType.VarChar).Value = txt2Prenom.Text;
            query.Parameters.Add("email", SqlDbType.VarChar).Value = txt2Email.Text;
            query.Connection = cnx;
            query.ExecuteNonQuery();
            cnx.Close();
            LoadEtudiant();
            MessageBox.Show("Etudiant modifier avce succès");
        }

        private void btnNouveauL_Click(object sender, EventArgs e)
        {
            txtIdLivre.Clear();
            txtTitre.Text = string.Empty;
            txtQte.Text = string.Empty;
            txtAuteur.Text = string.Empty;
            txtEtat.Text = string.Empty;
            txtCategorie.Text = string.Empty;

        }

        private void btnModifierL_Click(object sender, EventArgs e)
        {

            query = new SqlCommand();
            cnx.Open();
            query = new SqlCommand("update LIVRE set TitreLivre=@titrel, QteLivre=@qtel ,NomAuteur=@nomauteur,EtatLivre=@etatl,Categorie=@categoriel where IDLivre=@numl", cnx);
            query.Parameters.Add("numl", SqlDbType.Int).Value = txtIdLivre.Text;
            query.Parameters.Add("titrel", SqlDbType.VarChar).Value = txtTitre.Text;
            query.Parameters.Add("qte", SqlDbType.Int).Value = txtQte.Text;
            query.Parameters.Add("nomauteur", SqlDbType.VarChar).Value = txtAuteur.Text;
            query.Parameters.Add("etatl", SqlDbType.VarChar).Value = txtEtat.Text;
            query.Parameters.Add("categoriel", SqlDbType.VarChar).Value = txtCategorie.Text;
            query.Connection = cnx;
            query.ExecuteNonQuery();
            cnx.Close();
            LoadLivre();
            MessageBox.Show("Livre modifier avce succès");
        }

        private void dgvLivre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSupprimerL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur?", "suppresion", MessageBoxButtons.YesNo,
             MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                query = new SqlCommand();
                cnx.Open();
                query = new SqlCommand("Delete from LIVRE where  IDLivre=@numl", cnx);
                query.Parameters.Add("numl", SqlDbType.VarChar).Value = txtIdLivre.Text;
                query.Connection = cnx;
                query.ExecuteNonQuery();
                cnx.Close();
                LoadLivre();
                MessageBox.Show("Livre supprimer avce succès");
            }
        }

        private void btnFermerL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            idRespo.Clear();
            txtNomResponsable.Text = string.Empty;
            txtPrenomResponsable.Text = string.Empty;
            txtEmailResponsable.Text = string.Empty;
            txtUsername.Text = string.Empty;
            txtPasswordResponsable.Text = string.Empty;
        }

        private void dgvReservationListeA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            query = new SqlCommand();
            cnx.Open();
            query = new SqlCommand("update RESPONSABLE set NOMRESPONSABLE=@NomR, PRENOMRESPONSABLE=@prenomR ,EMAIL=@emailR,MODEPASSERESPONSABLE=@pwdR where ID_RESPONSABLE=@numR", cnx);
            query.Parameters.Add("numR", SqlDbType.Int).Value = idRespo.Text;
            query.Parameters.Add("NomR", SqlDbType.VarChar).Value = txtNomResponsable.Text;
            query.Parameters.Add("prenomR", SqlDbType.VarChar).Value = txtPrenomResponsable.Text;
            query.Parameters.Add("emailR", SqlDbType.VarChar).Value = txtEmailResponsable.Text;
            query.Parameters.Add("pwdR", SqlDbType.VarChar).Value = txtPasswordResponsable.Text;
            query.Connection = cnx;
            query.ExecuteNonQuery();
            cnx.Close();
            LoadResponsable();
            MessageBox.Show("Responsable modifier avce succès");
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Etes vous sur?", "suppresion", MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                query = new SqlCommand();
                cnx.Open();
                query = new SqlCommand("Delete from RESPONSABLE where  ID_RESPONSABLE=@numR", cnx);
                query.Parameters.Add("numR", SqlDbType.VarChar).Value = idRespo.Text;
                query.Connection = cnx;
                query.ExecuteNonQuery();
                cnx.Close();
                LoadResponsable();
                MessageBox.Show("Responsable supprimer avce succès");
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Etes vous sur?", "Quitter", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                utilisateurForm utilisateurform = new utilisateurForm();
                this.Hide();
                utilisateurform.Show();
            }
        }
    }



}
