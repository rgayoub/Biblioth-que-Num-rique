using MaterialSkin2DotNet.Controls;
using Microsoft.VisualBasic.Devices;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace EFMbiblio
{
    public partial class DashboardGerant : MaterialForm
    {

        SqlConnection cnx;
        SqlCommand query;
        SqlDataReader reader;



        public DashboardGerant()
        {
            InitializeComponent();

        }

        private void Dashboard_Gerant_Load(object sender, EventArgs e)
        {
            cnx = Program.GetSqlConnection();

            LoadLivre();
            LoadEtudiant();
            LoadReservation();
            LoadReservation2();

        }
        private void tabPage2_Load(object sender, EventArgs e)
        {



        }

        private void LoadEtudiant()
        {
            DataTable table = new DataTable();
            query = new SqlCommand("SELECT * FROM ETUDIANT", cnx);
            cnx.Open();
            reader = query.ExecuteReader();
            // while (reader.Read())
            // IdEtudiantRes.Items.Add(reader.GetInt32(0));
            // reader.Close();
            //reader = query.ExecuteReader();
            table.Load(reader);
            cnx.Close();
            reader.Close();
            dgvEtudiant.DataSource = table;
            IdEtudiantRes.DataSource = table;
            IdEtudiantRes.ValueMember = "IDEtudiant";
        }

        private void LoadLivre()
        {
            DataTable table = new DataTable();
            query = new SqlCommand("SELECT * FROM LIVRE", cnx);
            cnx.Open();
            reader = query.ExecuteReader();
            //while (reader.Read())

            //    idlivre.Items.Add(reader.GetInt32(0));
            //reader.Close();
            //reader = query.ExecuteReader();
            table.Load(reader);
            cnx.Close();
            reader.Close();
            dgvLivre.DataSource = table;
            idlivre.DataSource = table;
            idlivre.DisplayMember = "TitreLivre";
            idlivre.ValueMember = "IDLivre";
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
            dgvReservationListe.DataSource = table;
        }

        private void LoadReservation2()
        {
            DataTable table = new DataTable();
            query = new SqlCommand("SELECT  ID_RESERVATION, DATEDELAIS,DATEREMUE,STAUTRESERVATION FROM RESERVATION", cnx);
            cnx.Open();
            reader = query.ExecuteReader();
            table.Load(reader);
            cnx.Close();
            reader.Close();

            dgvReservationMis.DataSource = table;
        }


        private void BtnAjouterL_Click(object sender, EventArgs e)
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
            query = new SqlCommand("INSERT INTO LIVRE VALUES(@titre, @qte, @auteur, @etat, @categorie)", cnx);

            query.Parameters.Add("titre", SqlDbType.VarChar).Value = txtTitre.Text;
            query.Parameters.Add("qte", SqlDbType.Int).Value = txtQte.Text;
            query.Parameters.Add("auteur", SqlDbType.VarChar).Value = txtAuteur.Text;
            query.Parameters.Add("etat", SqlDbType.VarChar).Value = txtEtat.Text;
            query.Parameters.Add("categorie", SqlDbType.VarChar).Value = txtCategorie.Text;


            query.ExecuteNonQuery();
            cnx.Close();
            LoadLivre();
            MessageBox.Show("Livre enregistrée avec succès ", "Livre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEnregistrerE_Click(object sender, EventArgs e)
        {
            query = new SqlCommand("SELECT IDEtudiant FROM ETUDIANT WHERE IDEtudiant=@num", cnx);
            query.Parameters.AddWithValue("num", txtIdEtudiant.Text);
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

            query.Parameters.Add("nom", SqlDbType.VarChar).Value = txtNom.Text;
            query.Parameters.Add("prenom", SqlDbType.VarChar).Value = txtPrenom.Text;
            query.Parameters.Add("email", SqlDbType.VarChar).Value = txtEmail.Text;


            query.ExecuteNonQuery();
            cnx.Close();
            LoadEtudiant();
            MessageBox.Show("Etudiant enregistrée avec succès ", "Etudiant", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void BtnFermerE_Click(object sender, EventArgs e)
        {

        }
        private void BtnSupprimerE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur?", "suppresion", MessageBoxButtons.YesNo,
               MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                query = new SqlCommand();
                cnx.Open();
                query = new SqlCommand("Delete from ETUDIANT where  ncom=@num", cnx);
                query.Parameters.Add("num", SqlDbType.VarChar).Value = txtIdEtudiant.Text;
                query.Connection = cnx;
                query.ExecuteNonQuery();
                cnx.Close();
                LoadEtudiant();
                MessageBox.Show("Etudiant supprimer avce succès");
            }

        }

        private void dgvEtudiant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnModifierE_Click(object sender, EventArgs e)
        {

        }

        private void txtDateReservation_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            // Vérifier si la réservation existe déjà
            using (SqlCommand checkReservation = new SqlCommand("SELECT ID_RESERVATION FROM RESERVATION WHERE ID_RESERVATION=@num", cnx))
            {
                checkReservation.Parameters.AddWithValue("num", IdReservation.Text);
                cnx.Open();
                using (SqlDataReader reader = checkReservation.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("La réservation existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Insérer dans la vue reservationn
            using (SqlCommand insertReservation = new SqlCommand("INSERT INTO RESERVATION(ID_ETUDIANT,DATERESERVATION,DATEDELAIS,DATEREMUE,STAUTRESERVATION,ID_LIVRE)" +
                                                                " VALUES (@IdEtudiant, @DateReservation, @DateDelais, @DateRemue, 'En cours', @IdLivre )", cnx))
            {
                // Ajoutez d'autres paramètres nécessaires ici

                insertReservation.Parameters.Add("IdEtudiant", SqlDbType.Int).Value = int.Parse(IdEtudiantRes.Text);
                insertReservation.Parameters.Add("DateReservation", SqlDbType.DateTime).Value = DateTime.Now; // ou utilisez la date que vous avez besoin

                // Si DATEDELAIS et DATEREMUE sont facultatifs, vous pouvez les laisser null
                insertReservation.Parameters.Add("DateDelais", SqlDbType.DateTime).Value = datedelais.Value;
                insertReservation.Parameters.Add("DateRemue", SqlDbType.DateTime).Value = DBNull.Value;

                insertReservation.Parameters.Add("IdLivre", SqlDbType.VarChar).Value = idlivre.SelectedValue;

                insertReservation.ExecuteNonQuery();


                cnx.Close();

                LoadReservation();
                MessageBox.Show("Réservation enregistrée avec succès", "Réservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cnx.Close();
            LoadReservation2();
        }


        private void dgvEtudiant_Click(object sender, EventArgs e)
        {
            txtIdEtudiant.Enabled = false;
            txtIdEtudiant.Text = dgvEtudiant.CurrentRow.Cells[0].Value.ToString();
            txtNom.Text = dgvEtudiant.CurrentRow.Cells[1].Value.ToString();
            txtPrenom.Text = dgvEtudiant.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvEtudiant.CurrentRow.Cells[3].Value.ToString();
        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnNouveauE_Click(object sender, EventArgs e)
        {
            txtIdEtudiant.Clear();
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtEmail.Text = string.Empty;

        }

        private void BtnModifierE_Click_1(object sender, EventArgs e)
        {


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

        private void IdResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            query = new SqlCommand();
            cnx.Open();

            // Assuming IdReservationMis.Text is a valid integer
            int idReservation = int.Parse(IdReservationMis.Text);

            query = new SqlCommand("UPDATE RESERVATION SET DATEREMUE = @dateremue, DATEDELAIS = @datedelais, STAUTRESERVATION = @statut WHERE ID_RESERVATION = @numR", cnx);



            query.Parameters.Add("@numR", SqlDbType.Int).Value = idReservation;
            query.Parameters.Add("@dateremue", SqlDbType.Date).Value = dateremue.Value;
            query.Parameters.Add("@datedelais", SqlDbType.Date).Value = datedelaisMis.Value;

            // Check the condition and set the status accordingly
            if (dateremue.Value > datedelaisMis.Value)
            {
                query.Parameters.Add("@statut", SqlDbType.VarChar).Value = "En retard";
            }
            else
            {
                query.Parameters.Add("@statut", SqlDbType.VarChar).Value = "Terminée";
            }

            query.Connection = cnx;
            query.ExecuteNonQuery();

            cnx.Close();
            LoadReservation2();
            MessageBox.Show("Réservation modifiée avec succès");
        }


        private void btnEnregistrerdate_Click(object sender, EventArgs e)
        {


        }

        private void dateremue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvReservationMis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdReservationMis.Enabled = false;
            IdReservationMis.Text = dgvReservationMis.CurrentRow.Cells[0].Value.ToString();
            datedelaisMis.Text = dgvReservationMis.CurrentRow.Cells[1].Value.ToString();
            dateremue.Text = dgvReservationMis.CurrentRow.Cells[2].Value.ToString();
            statut.Text = dgvReservationMis.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {


        }

        private void SuprimerReservation_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur?", "suppresion", MessageBoxButtons.YesNo,
             MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                query = new SqlCommand();
                cnx.Open();
                query = new SqlCommand("Delete from RESERVATION where  ID_RESERVATION=@numR", cnx);
                query.Parameters.Add("numR", SqlDbType.VarChar).Value = txtIdLivre.Text;
                query.Connection = cnx;
                query.ExecuteNonQuery();
                cnx.Close();
                LoadLivre();
                MessageBox.Show("Livre supprimer avce succès");
            }
        }

        private void btnFermerReservation_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void BtnSupprimerR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes vous sur?", "suppresion", MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                query = new SqlCommand();
                cnx.Open();
                query = new SqlCommand("Delete from RESERVATION where  ID_RESERVATION=@numR", cnx);
                query.Parameters.Add("numR", SqlDbType.VarChar).Value = IdReservationMis.Text;
                query.Connection = cnx;
                query.ExecuteNonQuery();
                cnx.Close();
                LoadReservation2();
                MessageBox.Show("Réservation supprimer avce succès");
            }
        }

        private void btnFeremer_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnFermerL_Click(object sender, EventArgs e)
        {
            this.Close();
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
