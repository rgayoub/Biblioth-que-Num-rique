namespace EFMbiblio
{
    partial class DashboardAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            DataGridViewCellStyle dataGridViewCellStyle49 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle50 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle51 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle52 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle53 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle54 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle55 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle56 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle57 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle58 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle59 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle60 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle61 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle62 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle63 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle64 = new DataGridViewCellStyle();
            IconsListe = new ImageList(components);
            tabPage4 = new TabPage();
            btnNouveau = new MaterialSkin2DotNet.Controls.MaterialButton();
            btnFermer = new MaterialSkin2DotNet.Controls.MaterialButton();
            btnSupprimer = new MaterialSkin2DotNet.Controls.MaterialButton();
            btnModifier = new MaterialSkin2DotNet.Controls.MaterialButton();
            btnEnregistrer = new MaterialSkin2DotNet.Controls.MaterialButton();
            dgvResponsable = new MaterialSkin2DotNet.Controls.MaterialDataTable();
            txtUsername = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            txtPasswordResponsable = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            txtEmailResponsable = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            txtPrenomResponsable = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            idRespo = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            txtNomResponsable = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            tabPage3 = new TabPage();
            dgvReservationListeA = new MaterialSkin2DotNet.Controls.MaterialDataTable();
            tabPage2 = new TabPage();
            btnNouveauL = new MaterialSkin2DotNet.Controls.MaterialButton();
            btnFermerL = new MaterialSkin2DotNet.Controls.MaterialButton();
            btnSupprimerL = new MaterialSkin2DotNet.Controls.MaterialButton();
            btnModifierL = new MaterialSkin2DotNet.Controls.MaterialButton();
            btnAjouterL = new MaterialSkin2DotNet.Controls.MaterialButton();
            dgvLivre = new MaterialSkin2DotNet.Controls.MaterialDataTable();
            txtCategorie = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            txtEtat = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            txtAuteur = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            txtQte = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            txtTitre = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            txtIdLivre = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            tabPage1 = new TabPage();
            Btn2NouveauE = new MaterialSkin2DotNet.Controls.MaterialButton();
            Btn2Fermer = new MaterialSkin2DotNet.Controls.MaterialButton();
            Btn2SupprimerE = new MaterialSkin2DotNet.Controls.MaterialButton();
            Btn2ModifierE = new MaterialSkin2DotNet.Controls.MaterialButton();
            Btn2EnregistrerE = new MaterialSkin2DotNet.Controls.MaterialButton();
            dgvEtudiant = new MaterialSkin2DotNet.Controls.MaterialDataTable();
            txt2Email = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            txt2Prenom = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            txt2Nom = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            txt2IdEtudiant = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            txtIdEtudiant = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            materialTabControl1 = new MaterialSkin2DotNet.Controls.MaterialTabControl();
            tabPage5 = new TabPage();
            materialButton1 = new MaterialSkin2DotNet.Controls.MaterialButton();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResponsable).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservationListeA).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLivre).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtudiant).BeginInit();
            materialTabControl1.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // IconsListe
            // 
            IconsListe.ColorDepth = ColorDepth.Depth8Bit;
            IconsListe.ImageStream = (ImageListStreamer)resources.GetObject("IconsListe.ImageStream");
            IconsListe.TransparentColor = Color.Transparent;
            IconsListe.Images.SetKeyName(0, "icons8-reservation-64.png");
            IconsListe.Images.SetKeyName(1, "icons8-student-48.png");
            IconsListe.Images.SetKeyName(2, "icons8-book-94.png");
            IconsListe.Images.SetKeyName(3, "icons8-admin-48.png");
            IconsListe.Images.SetKeyName(4, "icons8-quit-50.png");
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.White;
            tabPage4.Controls.Add(btnNouveau);
            tabPage4.Controls.Add(btnFermer);
            tabPage4.Controls.Add(btnSupprimer);
            tabPage4.Controls.Add(btnModifier);
            tabPage4.Controls.Add(btnEnregistrer);
            tabPage4.Controls.Add(dgvResponsable);
            tabPage4.Controls.Add(txtUsername);
            tabPage4.Controls.Add(txtPasswordResponsable);
            tabPage4.Controls.Add(txtEmailResponsable);
            tabPage4.Controls.Add(txtPrenomResponsable);
            tabPage4.Controls.Add(idRespo);
            tabPage4.Controls.Add(txtNomResponsable);
            tabPage4.ImageKey = "icons8-admin-48.png";
            tabPage4.Location = new Point(4, 39);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1372, 585);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Responsable";
            // 
            // btnNouveau
            // 
            btnNouveau.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNouveau.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNouveau.Depth = 0;
            btnNouveau.HighEmphasis = true;
            btnNouveau.Icon = null;
            btnNouveau.Location = new Point(268, 451);
            btnNouveau.Margin = new Padding(4, 6, 4, 6);
            btnNouveau.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnNouveau.Name = "btnNouveau";
            btnNouveau.NoAccentTextColor = Color.Empty;
            btnNouveau.Size = new Size(89, 36);
            btnNouveau.TabIndex = 31;
            btnNouveau.Text = "Nouveau";
            btnNouveau.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNouveau.UseAccentColor = false;
            btnNouveau.UseVisualStyleBackColor = true;
            btnNouveau.Click += btnNouveau_Click;
            // 
            // btnFermer
            // 
            btnFermer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFermer.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFermer.Depth = 0;
            btnFermer.HighEmphasis = true;
            btnFermer.Icon = null;
            btnFermer.Location = new Point(811, 451);
            btnFermer.Margin = new Padding(4, 6, 4, 6);
            btnFermer.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnFermer.Name = "btnFermer";
            btnFermer.NoAccentTextColor = Color.Empty;
            btnFermer.Size = new Size(78, 36);
            btnFermer.TabIndex = 30;
            btnFermer.Text = "Fermer";
            btnFermer.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFermer.UseAccentColor = false;
            btnFermer.UseVisualStyleBackColor = true;
            btnFermer.Click += btnFermer_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSupprimer.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSupprimer.Depth = 0;
            btnSupprimer.HighEmphasis = true;
            btnSupprimer.Icon = null;
            btnSupprimer.Location = new Point(621, 451);
            btnSupprimer.Margin = new Padding(4, 6, 4, 6);
            btnSupprimer.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.NoAccentTextColor = Color.Empty;
            btnSupprimer.Size = new Size(102, 36);
            btnSupprimer.TabIndex = 29;
            btnSupprimer.Text = "supprimer";
            btnSupprimer.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSupprimer.UseAccentColor = false;
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModifier.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModifier.Depth = 0;
            btnModifier.HighEmphasis = true;
            btnModifier.Icon = null;
            btnModifier.Location = new Point(451, 451);
            btnModifier.Margin = new Padding(4, 6, 4, 6);
            btnModifier.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnModifier.Name = "btnModifier";
            btnModifier.NoAccentTextColor = Color.Empty;
            btnModifier.Size = new Size(88, 36);
            btnModifier.TabIndex = 28;
            btnModifier.Text = "Modifier";
            btnModifier.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModifier.UseAccentColor = false;
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEnregistrer.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEnregistrer.Depth = 0;
            btnEnregistrer.HighEmphasis = true;
            btnEnregistrer.Icon = null;
            btnEnregistrer.Location = new Point(68, 451);
            btnEnregistrer.Margin = new Padding(4, 6, 4, 6);
            btnEnregistrer.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.NoAccentTextColor = Color.Empty;
            btnEnregistrer.Size = new Size(117, 36);
            btnEnregistrer.TabIndex = 27;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEnregistrer.UseAccentColor = false;
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // dgvResponsable
            // 
            dgvResponsable.AllowUserToDeleteRows = false;
            dgvResponsable.AllowUserToResizeRows = false;
            dgvResponsable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResponsable.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvResponsable.BorderStyle = BorderStyle.None;
            dgvResponsable.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvResponsable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle49.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle49.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle49.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            dataGridViewCellStyle49.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle49.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle49.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle49.WrapMode = DataGridViewTriState.True;
            dgvResponsable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
            dgvResponsable.ColumnHeadersHeight = 56;
            dgvResponsable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle50.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle50.BackColor = SystemColors.Window;
            dataGridViewCellStyle50.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle50.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle50.SelectionBackColor = Color.FromArgb(63, 81, 181);
            dataGridViewCellStyle50.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = DataGridViewTriState.False;
            dgvResponsable.DefaultCellStyle = dataGridViewCellStyle50;
            dgvResponsable.Depth = 0;
            dgvResponsable.EnableHeadersVisualStyles = false;
            dgvResponsable.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvResponsable.GridColor = Color.FromArgb(239, 239, 239);
            dgvResponsable.Location = new Point(317, 22);
            dgvResponsable.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            dgvResponsable.Name = "dgvResponsable";
            dataGridViewCellStyle51.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = SystemColors.Control;
            dataGridViewCellStyle51.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle51.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle51.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle51.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle51.WrapMode = DataGridViewTriState.True;
            dgvResponsable.RowHeadersDefaultCellStyle = dataGridViewCellStyle51;
            dgvResponsable.RowHeadersVisible = false;
            dataGridViewCellStyle52.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle52.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dgvResponsable.RowsDefaultCellStyle = dataGridViewCellStyle52;
            dgvResponsable.RowTemplate.Height = 52;
            dgvResponsable.ScrollBars = ScrollBars.None;
            dgvResponsable.ShowVerticalScroll = false;
            dgvResponsable.Size = new Size(1052, 355);
            dgvResponsable.TabIndex = 3;
            dgvResponsable.CellContentClick += dgvResponsable_CellContentClick;
            // 
            // txtUsername
            // 
            txtUsername.AllowPromptAsInput = true;
            txtUsername.AnimateReadOnly = false;
            txtUsername.AsciiOnly = false;
            txtUsername.BackgroundImageLayout = ImageLayout.None;
            txtUsername.BeepOnError = false;
            txtUsername.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtUsername.Depth = 0;
            txtUsername.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtUsername.HidePromptOnLeave = false;
            txtUsername.HideSelection = true;
            txtUsername.Hint = "Nom d'utilisateur";
            txtUsername.InsertKeyMode = InsertKeyMode.Default;
            txtUsername.LeadingIcon = null;
            txtUsername.Location = new Point(31, 249);
            txtUsername.Mask = "";
            txtUsername.MaxLength = 32767;
            txtUsername.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PrefixSuffixText = null;
            txtUsername.PromptChar = '_';
            txtUsername.ReadOnly = false;
            txtUsername.RejectInputOnFirstFailure = false;
            txtUsername.ResetOnPrompt = true;
            txtUsername.ResetOnSpace = true;
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.SelectedText = "";
            txtUsername.SelectionLength = 0;
            txtUsername.SelectionStart = 0;
            txtUsername.ShortcutsEnabled = true;
            txtUsername.Size = new Size(250, 48);
            txtUsername.SkipLiterals = true;
            txtUsername.TabIndex = 2;
            txtUsername.TabStop = false;
            txtUsername.TextAlign = HorizontalAlignment.Left;
            txtUsername.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtUsername.TrailingIcon = null;
            txtUsername.UseSystemPasswordChar = false;
            txtUsername.ValidatingType = null;
            // 
            // txtPasswordResponsable
            // 
            txtPasswordResponsable.AllowPromptAsInput = true;
            txtPasswordResponsable.AnimateReadOnly = false;
            txtPasswordResponsable.AsciiOnly = false;
            txtPasswordResponsable.BackgroundImageLayout = ImageLayout.None;
            txtPasswordResponsable.BeepOnError = false;
            txtPasswordResponsable.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPasswordResponsable.Depth = 0;
            txtPasswordResponsable.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPasswordResponsable.HidePromptOnLeave = false;
            txtPasswordResponsable.HideSelection = true;
            txtPasswordResponsable.Hint = "Mode passe";
            txtPasswordResponsable.InsertKeyMode = InsertKeyMode.Default;
            txtPasswordResponsable.LeadingIcon = null;
            txtPasswordResponsable.Location = new Point(31, 312);
            txtPasswordResponsable.Mask = "";
            txtPasswordResponsable.MaxLength = 32767;
            txtPasswordResponsable.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtPasswordResponsable.Name = "txtPasswordResponsable";
            txtPasswordResponsable.PasswordChar = '\0';
            txtPasswordResponsable.PrefixSuffixText = null;
            txtPasswordResponsable.PromptChar = '_';
            txtPasswordResponsable.ReadOnly = false;
            txtPasswordResponsable.RejectInputOnFirstFailure = false;
            txtPasswordResponsable.ResetOnPrompt = true;
            txtPasswordResponsable.ResetOnSpace = true;
            txtPasswordResponsable.RightToLeft = RightToLeft.No;
            txtPasswordResponsable.SelectedText = "";
            txtPasswordResponsable.SelectionLength = 0;
            txtPasswordResponsable.SelectionStart = 0;
            txtPasswordResponsable.ShortcutsEnabled = true;
            txtPasswordResponsable.Size = new Size(250, 48);
            txtPasswordResponsable.SkipLiterals = true;
            txtPasswordResponsable.TabIndex = 2;
            txtPasswordResponsable.TabStop = false;
            txtPasswordResponsable.TextAlign = HorizontalAlignment.Left;
            txtPasswordResponsable.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPasswordResponsable.TrailingIcon = null;
            txtPasswordResponsable.UseSystemPasswordChar = false;
            txtPasswordResponsable.ValidatingType = null;
            // 
            // txtEmailResponsable
            // 
            txtEmailResponsable.AllowPromptAsInput = true;
            txtEmailResponsable.AnimateReadOnly = false;
            txtEmailResponsable.AsciiOnly = false;
            txtEmailResponsable.BackgroundImageLayout = ImageLayout.None;
            txtEmailResponsable.BeepOnError = false;
            txtEmailResponsable.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtEmailResponsable.Depth = 0;
            txtEmailResponsable.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmailResponsable.HidePromptOnLeave = false;
            txtEmailResponsable.HideSelection = true;
            txtEmailResponsable.Hint = "Email";
            txtEmailResponsable.InsertKeyMode = InsertKeyMode.Default;
            txtEmailResponsable.LeadingIcon = null;
            txtEmailResponsable.Location = new Point(35, 195);
            txtEmailResponsable.Mask = "";
            txtEmailResponsable.MaxLength = 32767;
            txtEmailResponsable.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtEmailResponsable.Name = "txtEmailResponsable";
            txtEmailResponsable.PasswordChar = '\0';
            txtEmailResponsable.PrefixSuffixText = null;
            txtEmailResponsable.PromptChar = '_';
            txtEmailResponsable.ReadOnly = false;
            txtEmailResponsable.RejectInputOnFirstFailure = false;
            txtEmailResponsable.ResetOnPrompt = true;
            txtEmailResponsable.ResetOnSpace = true;
            txtEmailResponsable.RightToLeft = RightToLeft.No;
            txtEmailResponsable.SelectedText = "";
            txtEmailResponsable.SelectionLength = 0;
            txtEmailResponsable.SelectionStart = 0;
            txtEmailResponsable.ShortcutsEnabled = true;
            txtEmailResponsable.Size = new Size(250, 48);
            txtEmailResponsable.SkipLiterals = true;
            txtEmailResponsable.TabIndex = 2;
            txtEmailResponsable.TabStop = false;
            txtEmailResponsable.TextAlign = HorizontalAlignment.Left;
            txtEmailResponsable.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEmailResponsable.TrailingIcon = null;
            txtEmailResponsable.UseSystemPasswordChar = false;
            txtEmailResponsable.ValidatingType = null;
            // 
            // txtPrenomResponsable
            // 
            txtPrenomResponsable.AllowPromptAsInput = true;
            txtPrenomResponsable.AnimateReadOnly = false;
            txtPrenomResponsable.AsciiOnly = false;
            txtPrenomResponsable.BackgroundImageLayout = ImageLayout.None;
            txtPrenomResponsable.BeepOnError = false;
            txtPrenomResponsable.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPrenomResponsable.Depth = 0;
            txtPrenomResponsable.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrenomResponsable.HidePromptOnLeave = false;
            txtPrenomResponsable.HideSelection = true;
            txtPrenomResponsable.Hint = "Prenom ";
            txtPrenomResponsable.InsertKeyMode = InsertKeyMode.Default;
            txtPrenomResponsable.LeadingIcon = null;
            txtPrenomResponsable.Location = new Point(35, 141);
            txtPrenomResponsable.Mask = "";
            txtPrenomResponsable.MaxLength = 32767;
            txtPrenomResponsable.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtPrenomResponsable.Name = "txtPrenomResponsable";
            txtPrenomResponsable.PasswordChar = '\0';
            txtPrenomResponsable.PrefixSuffixText = null;
            txtPrenomResponsable.PromptChar = '_';
            txtPrenomResponsable.ReadOnly = false;
            txtPrenomResponsable.RejectInputOnFirstFailure = false;
            txtPrenomResponsable.ResetOnPrompt = true;
            txtPrenomResponsable.ResetOnSpace = true;
            txtPrenomResponsable.RightToLeft = RightToLeft.No;
            txtPrenomResponsable.SelectedText = "";
            txtPrenomResponsable.SelectionLength = 0;
            txtPrenomResponsable.SelectionStart = 0;
            txtPrenomResponsable.ShortcutsEnabled = true;
            txtPrenomResponsable.Size = new Size(250, 48);
            txtPrenomResponsable.SkipLiterals = true;
            txtPrenomResponsable.TabIndex = 1;
            txtPrenomResponsable.TabStop = false;
            txtPrenomResponsable.TextAlign = HorizontalAlignment.Left;
            txtPrenomResponsable.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPrenomResponsable.TrailingIcon = null;
            txtPrenomResponsable.UseSystemPasswordChar = false;
            txtPrenomResponsable.ValidatingType = null;
            // 
            // idRespo
            // 
            idRespo.AllowPromptAsInput = true;
            idRespo.AnimateReadOnly = false;
            idRespo.AsciiOnly = false;
            idRespo.BackgroundImageLayout = ImageLayout.None;
            idRespo.BeepOnError = false;
            idRespo.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            idRespo.Depth = 0;
            idRespo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            idRespo.HidePromptOnLeave = false;
            idRespo.HideSelection = true;
            idRespo.Hint = "Id Responsable";
            idRespo.InsertKeyMode = InsertKeyMode.Default;
            idRespo.LeadingIcon = null;
            idRespo.Location = new Point(31, 22);
            idRespo.Mask = "";
            idRespo.MaxLength = 32767;
            idRespo.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            idRespo.Name = "idRespo";
            idRespo.PasswordChar = '\0';
            idRespo.PrefixSuffixText = null;
            idRespo.PromptChar = '_';
            idRespo.ReadOnly = true;
            idRespo.RejectInputOnFirstFailure = false;
            idRespo.ResetOnPrompt = true;
            idRespo.ResetOnSpace = true;
            idRespo.RightToLeft = RightToLeft.No;
            idRespo.SelectedText = "";
            idRespo.SelectionLength = 0;
            idRespo.SelectionStart = 0;
            idRespo.ShortcutsEnabled = true;
            idRespo.Size = new Size(250, 48);
            idRespo.SkipLiterals = true;
            idRespo.TabIndex = 0;
            idRespo.TabStop = false;
            idRespo.TextAlign = HorizontalAlignment.Left;
            idRespo.TextMaskFormat = MaskFormat.IncludeLiterals;
            idRespo.TrailingIcon = null;
            idRespo.UseSystemPasswordChar = false;
            idRespo.ValidatingType = null;
            // 
            // txtNomResponsable
            // 
            txtNomResponsable.AllowPromptAsInput = true;
            txtNomResponsable.AnimateReadOnly = false;
            txtNomResponsable.AsciiOnly = false;
            txtNomResponsable.BackgroundImageLayout = ImageLayout.None;
            txtNomResponsable.BeepOnError = false;
            txtNomResponsable.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtNomResponsable.Depth = 0;
            txtNomResponsable.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomResponsable.HidePromptOnLeave = false;
            txtNomResponsable.HideSelection = true;
            txtNomResponsable.Hint = "Nom";
            txtNomResponsable.InsertKeyMode = InsertKeyMode.Default;
            txtNomResponsable.LeadingIcon = null;
            txtNomResponsable.Location = new Point(35, 87);
            txtNomResponsable.Mask = "";
            txtNomResponsable.MaxLength = 32767;
            txtNomResponsable.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtNomResponsable.Name = "txtNomResponsable";
            txtNomResponsable.PasswordChar = '\0';
            txtNomResponsable.PrefixSuffixText = null;
            txtNomResponsable.PromptChar = '_';
            txtNomResponsable.ReadOnly = false;
            txtNomResponsable.RejectInputOnFirstFailure = false;
            txtNomResponsable.ResetOnPrompt = true;
            txtNomResponsable.ResetOnSpace = true;
            txtNomResponsable.RightToLeft = RightToLeft.No;
            txtNomResponsable.SelectedText = "";
            txtNomResponsable.SelectionLength = 0;
            txtNomResponsable.SelectionStart = 0;
            txtNomResponsable.ShortcutsEnabled = true;
            txtNomResponsable.Size = new Size(250, 48);
            txtNomResponsable.SkipLiterals = true;
            txtNomResponsable.TabIndex = 0;
            txtNomResponsable.TabStop = false;
            txtNomResponsable.TextAlign = HorizontalAlignment.Left;
            txtNomResponsable.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtNomResponsable.TrailingIcon = null;
            txtNomResponsable.UseSystemPasswordChar = false;
            txtNomResponsable.ValidatingType = null;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.White;
            tabPage3.Controls.Add(dgvReservationListeA);
            tabPage3.ImageKey = "icons8-reservation-64.png";
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1372, 585);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Reservation";
            // 
            // dgvReservationListeA
            // 
            dgvReservationListeA.AllowUserToDeleteRows = false;
            dgvReservationListeA.AllowUserToResizeRows = false;
            dgvReservationListeA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservationListeA.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvReservationListeA.BorderStyle = BorderStyle.None;
            dgvReservationListeA.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvReservationListeA.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle53.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle53.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle53.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            dataGridViewCellStyle53.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle53.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle53.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle53.WrapMode = DataGridViewTriState.True;
            dgvReservationListeA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle53;
            dgvReservationListeA.ColumnHeadersHeight = 56;
            dgvReservationListeA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle54.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle54.BackColor = SystemColors.Window;
            dataGridViewCellStyle54.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle54.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle54.SelectionBackColor = Color.FromArgb(63, 81, 181);
            dataGridViewCellStyle54.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle54.WrapMode = DataGridViewTriState.False;
            dgvReservationListeA.DefaultCellStyle = dataGridViewCellStyle54;
            dgvReservationListeA.Depth = 0;
            dgvReservationListeA.EnableHeadersVisualStyles = false;
            dgvReservationListeA.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvReservationListeA.GridColor = Color.AliceBlue;
            dgvReservationListeA.Location = new Point(25, 25);
            dgvReservationListeA.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            dgvReservationListeA.Name = "dgvReservationListeA";
            dataGridViewCellStyle55.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle55.BackColor = SystemColors.Control;
            dataGridViewCellStyle55.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle55.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle55.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle55.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle55.WrapMode = DataGridViewTriState.True;
            dgvReservationListeA.RowHeadersDefaultCellStyle = dataGridViewCellStyle55;
            dgvReservationListeA.RowHeadersVisible = false;
            dataGridViewCellStyle56.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle56.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dgvReservationListeA.RowsDefaultCellStyle = dataGridViewCellStyle56;
            dgvReservationListeA.RowTemplate.Height = 52;
            dgvReservationListeA.ScrollBars = ScrollBars.None;
            dgvReservationListeA.ShowVerticalScroll = false;
            dgvReservationListeA.Size = new Size(1327, 430);
            dgvReservationListeA.TabIndex = 14;
            dgvReservationListeA.CellContentClick += dgvReservationListeA_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(btnNouveauL);
            tabPage2.Controls.Add(btnFermerL);
            tabPage2.Controls.Add(btnSupprimerL);
            tabPage2.Controls.Add(btnModifierL);
            tabPage2.Controls.Add(btnAjouterL);
            tabPage2.Controls.Add(dgvLivre);
            tabPage2.Controls.Add(txtCategorie);
            tabPage2.Controls.Add(txtEtat);
            tabPage2.Controls.Add(txtAuteur);
            tabPage2.Controls.Add(txtQte);
            tabPage2.Controls.Add(txtTitre);
            tabPage2.Controls.Add(txtIdLivre);
            tabPage2.ImageKey = "icons8-book-94.png";
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1372, 585);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Livre";
            // 
            // btnNouveauL
            // 
            btnNouveauL.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNouveauL.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNouveauL.Depth = 0;
            btnNouveauL.HighEmphasis = true;
            btnNouveauL.Icon = null;
            btnNouveauL.Location = new Point(274, 524);
            btnNouveauL.Margin = new Padding(4, 6, 4, 6);
            btnNouveauL.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnNouveauL.Name = "btnNouveauL";
            btnNouveauL.NoAccentTextColor = Color.Empty;
            btnNouveauL.Size = new Size(89, 36);
            btnNouveauL.TabIndex = 23;
            btnNouveauL.Text = "Nouveau";
            btnNouveauL.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNouveauL.UseAccentColor = false;
            btnNouveauL.UseVisualStyleBackColor = true;
            btnNouveauL.Click += btnNouveauL_Click;
            // 
            // btnFermerL
            // 
            btnFermerL.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFermerL.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFermerL.Depth = 0;
            btnFermerL.HighEmphasis = true;
            btnFermerL.Icon = null;
            btnFermerL.Location = new Point(838, 524);
            btnFermerL.Margin = new Padding(4, 6, 4, 6);
            btnFermerL.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnFermerL.Name = "btnFermerL";
            btnFermerL.NoAccentTextColor = Color.Empty;
            btnFermerL.Size = new Size(78, 36);
            btnFermerL.TabIndex = 15;
            btnFermerL.Text = "FERMER";
            btnFermerL.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFermerL.UseAccentColor = false;
            btnFermerL.UseVisualStyleBackColor = true;
            btnFermerL.Click += btnFermerL_Click;
            // 
            // btnSupprimerL
            // 
            btnSupprimerL.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSupprimerL.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSupprimerL.Depth = 0;
            btnSupprimerL.HighEmphasis = true;
            btnSupprimerL.Icon = null;
            btnSupprimerL.Location = new Point(641, 524);
            btnSupprimerL.Margin = new Padding(4, 6, 4, 6);
            btnSupprimerL.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnSupprimerL.Name = "btnSupprimerL";
            btnSupprimerL.NoAccentTextColor = Color.Empty;
            btnSupprimerL.Size = new Size(102, 36);
            btnSupprimerL.TabIndex = 14;
            btnSupprimerL.Text = "SUPPRIMER";
            btnSupprimerL.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSupprimerL.UseAccentColor = false;
            btnSupprimerL.UseVisualStyleBackColor = true;
            btnSupprimerL.Click += btnSupprimerL_Click;
            // 
            // btnModifierL
            // 
            btnModifierL.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModifierL.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModifierL.Depth = 0;
            btnModifierL.HighEmphasis = true;
            btnModifierL.Icon = null;
            btnModifierL.Location = new Point(458, 524);
            btnModifierL.Margin = new Padding(4, 6, 4, 6);
            btnModifierL.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnModifierL.Name = "btnModifierL";
            btnModifierL.NoAccentTextColor = Color.Empty;
            btnModifierL.Size = new Size(88, 36);
            btnModifierL.TabIndex = 13;
            btnModifierL.Text = "MODIFIER";
            btnModifierL.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModifierL.UseAccentColor = false;
            btnModifierL.UseVisualStyleBackColor = true;
            btnModifierL.Click += btnModifierL_Click;
            // 
            // btnAjouterL
            // 
            btnAjouterL.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAjouterL.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAjouterL.Depth = 0;
            btnAjouterL.HighEmphasis = true;
            btnAjouterL.Icon = null;
            btnAjouterL.Location = new Point(94, 524);
            btnAjouterL.Margin = new Padding(4, 6, 4, 6);
            btnAjouterL.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnAjouterL.Name = "btnAjouterL";
            btnAjouterL.NoAccentTextColor = Color.Empty;
            btnAjouterL.Size = new Size(85, 36);
            btnAjouterL.TabIndex = 12;
            btnAjouterL.Text = "Ajouter";
            btnAjouterL.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAjouterL.UseAccentColor = false;
            btnAjouterL.UseVisualStyleBackColor = true;
            btnAjouterL.Click += btnAjouterL_Click;
            // 
            // dgvLivre
            // 
            dgvLivre.AllowUserToDeleteRows = false;
            dgvLivre.AllowUserToResizeRows = false;
            dgvLivre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLivre.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvLivre.BorderStyle = BorderStyle.None;
            dgvLivre.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvLivre.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle57.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle57.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle57.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            dataGridViewCellStyle57.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle57.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle57.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = DataGridViewTriState.True;
            dgvLivre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
            dgvLivre.ColumnHeadersHeight = 56;
            dgvLivre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle58.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.BackColor = SystemColors.Window;
            dataGridViewCellStyle58.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle58.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle58.SelectionBackColor = Color.FromArgb(63, 81, 181);
            dataGridViewCellStyle58.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle58.WrapMode = DataGridViewTriState.False;
            dgvLivre.DefaultCellStyle = dataGridViewCellStyle58;
            dgvLivre.Depth = 0;
            dgvLivre.EnableHeadersVisualStyles = false;
            dgvLivre.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvLivre.GridColor = Color.FromArgb(255, 192, 192);
            dgvLivre.Location = new Point(411, 24);
            dgvLivre.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            dgvLivre.Name = "dgvLivre";
            dataGridViewCellStyle59.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = SystemColors.Control;
            dataGridViewCellStyle59.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle59.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle59.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle59.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle59.WrapMode = DataGridViewTriState.True;
            dgvLivre.RowHeadersDefaultCellStyle = dataGridViewCellStyle59;
            dgvLivre.RowHeadersVisible = false;
            dataGridViewCellStyle60.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle60.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dgvLivre.RowsDefaultCellStyle = dataGridViewCellStyle60;
            dgvLivre.RowTemplate.Height = 52;
            dgvLivre.ScrollBars = ScrollBars.None;
            dgvLivre.ShowVerticalScroll = false;
            dgvLivre.Size = new Size(781, 453);
            dgvLivre.TabIndex = 22;
            dgvLivre.CellContentClick += dgvLivre_CellContentClick;
            // 
            // txtCategorie
            // 
            txtCategorie.AllowPromptAsInput = true;
            txtCategorie.AnimateReadOnly = false;
            txtCategorie.AsciiOnly = false;
            txtCategorie.BackgroundImageLayout = ImageLayout.None;
            txtCategorie.BeepOnError = false;
            txtCategorie.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCategorie.Depth = 0;
            txtCategorie.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCategorie.HidePromptOnLeave = false;
            txtCategorie.HideSelection = true;
            txtCategorie.Hint = "Catégorie";
            txtCategorie.InsertKeyMode = InsertKeyMode.Default;
            txtCategorie.LeadingIcon = null;
            txtCategorie.Location = new Point(28, 429);
            txtCategorie.Mask = "";
            txtCategorie.MaxLength = 32767;
            txtCategorie.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtCategorie.Name = "txtCategorie";
            txtCategorie.PasswordChar = '\0';
            txtCategorie.PrefixSuffixText = null;
            txtCategorie.PromptChar = '_';
            txtCategorie.ReadOnly = false;
            txtCategorie.RejectInputOnFirstFailure = false;
            txtCategorie.ResetOnPrompt = true;
            txtCategorie.ResetOnSpace = true;
            txtCategorie.RightToLeft = RightToLeft.No;
            txtCategorie.SelectedText = "";
            txtCategorie.SelectionLength = 0;
            txtCategorie.SelectionStart = 0;
            txtCategorie.ShortcutsEnabled = true;
            txtCategorie.Size = new Size(331, 48);
            txtCategorie.SkipLiterals = true;
            txtCategorie.TabIndex = 21;
            txtCategorie.TabStop = false;
            txtCategorie.TextAlign = HorizontalAlignment.Left;
            txtCategorie.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCategorie.TrailingIcon = null;
            txtCategorie.UseSystemPasswordChar = false;
            txtCategorie.ValidatingType = null;
            // 
            // txtEtat
            // 
            txtEtat.AllowPromptAsInput = true;
            txtEtat.AnimateReadOnly = false;
            txtEtat.AsciiOnly = false;
            txtEtat.BackgroundImageLayout = ImageLayout.None;
            txtEtat.BeepOnError = false;
            txtEtat.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtEtat.Depth = 0;
            txtEtat.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEtat.HidePromptOnLeave = false;
            txtEtat.HideSelection = true;
            txtEtat.Hint = "Etat Livre";
            txtEtat.InsertKeyMode = InsertKeyMode.Default;
            txtEtat.LeadingIcon = null;
            txtEtat.Location = new Point(28, 348);
            txtEtat.Mask = "";
            txtEtat.MaxLength = 32767;
            txtEtat.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtEtat.Name = "txtEtat";
            txtEtat.PasswordChar = '\0';
            txtEtat.PrefixSuffixText = null;
            txtEtat.PromptChar = '_';
            txtEtat.ReadOnly = false;
            txtEtat.RejectInputOnFirstFailure = false;
            txtEtat.ResetOnPrompt = true;
            txtEtat.ResetOnSpace = true;
            txtEtat.RightToLeft = RightToLeft.No;
            txtEtat.SelectedText = "";
            txtEtat.SelectionLength = 0;
            txtEtat.SelectionStart = 0;
            txtEtat.ShortcutsEnabled = true;
            txtEtat.Size = new Size(331, 48);
            txtEtat.SkipLiterals = true;
            txtEtat.TabIndex = 20;
            txtEtat.TabStop = false;
            txtEtat.TextAlign = HorizontalAlignment.Left;
            txtEtat.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEtat.TrailingIcon = null;
            txtEtat.UseSystemPasswordChar = false;
            txtEtat.ValidatingType = null;
            // 
            // txtAuteur
            // 
            txtAuteur.AllowPromptAsInput = true;
            txtAuteur.AnimateReadOnly = false;
            txtAuteur.AsciiOnly = false;
            txtAuteur.BackgroundImageLayout = ImageLayout.None;
            txtAuteur.BeepOnError = false;
            txtAuteur.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtAuteur.Depth = 0;
            txtAuteur.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAuteur.HidePromptOnLeave = false;
            txtAuteur.HideSelection = true;
            txtAuteur.Hint = "Nom Auteur";
            txtAuteur.InsertKeyMode = InsertKeyMode.Default;
            txtAuteur.LeadingIcon = null;
            txtAuteur.Location = new Point(28, 267);
            txtAuteur.Mask = "";
            txtAuteur.MaxLength = 32767;
            txtAuteur.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtAuteur.Name = "txtAuteur";
            txtAuteur.PasswordChar = '\0';
            txtAuteur.PrefixSuffixText = null;
            txtAuteur.PromptChar = '_';
            txtAuteur.ReadOnly = false;
            txtAuteur.RejectInputOnFirstFailure = false;
            txtAuteur.ResetOnPrompt = true;
            txtAuteur.ResetOnSpace = true;
            txtAuteur.RightToLeft = RightToLeft.No;
            txtAuteur.SelectedText = "";
            txtAuteur.SelectionLength = 0;
            txtAuteur.SelectionStart = 0;
            txtAuteur.ShortcutsEnabled = true;
            txtAuteur.Size = new Size(331, 48);
            txtAuteur.SkipLiterals = true;
            txtAuteur.TabIndex = 19;
            txtAuteur.TabStop = false;
            txtAuteur.TextAlign = HorizontalAlignment.Left;
            txtAuteur.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtAuteur.TrailingIcon = null;
            txtAuteur.UseSystemPasswordChar = false;
            txtAuteur.ValidatingType = null;
            // 
            // txtQte
            // 
            txtQte.AllowPromptAsInput = true;
            txtQte.AnimateReadOnly = false;
            txtQte.AsciiOnly = false;
            txtQte.BackgroundImageLayout = ImageLayout.None;
            txtQte.BeepOnError = false;
            txtQte.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtQte.Depth = 0;
            txtQte.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQte.HidePromptOnLeave = false;
            txtQte.HideSelection = true;
            txtQte.Hint = "Quantité Livre";
            txtQte.InsertKeyMode = InsertKeyMode.Default;
            txtQte.LeadingIcon = null;
            txtQte.Location = new Point(28, 186);
            txtQte.Mask = "";
            txtQte.MaxLength = 32767;
            txtQte.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtQte.Name = "txtQte";
            txtQte.PasswordChar = '\0';
            txtQte.PrefixSuffixText = null;
            txtQte.PromptChar = '_';
            txtQte.ReadOnly = false;
            txtQte.RejectInputOnFirstFailure = false;
            txtQte.ResetOnPrompt = true;
            txtQte.ResetOnSpace = true;
            txtQte.RightToLeft = RightToLeft.No;
            txtQte.SelectedText = "";
            txtQte.SelectionLength = 0;
            txtQte.SelectionStart = 0;
            txtQte.ShortcutsEnabled = true;
            txtQte.Size = new Size(331, 48);
            txtQte.SkipLiterals = true;
            txtQte.TabIndex = 18;
            txtQte.TabStop = false;
            txtQte.TextAlign = HorizontalAlignment.Left;
            txtQte.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtQte.TrailingIcon = null;
            txtQte.UseSystemPasswordChar = false;
            txtQte.ValidatingType = null;
            // 
            // txtTitre
            // 
            txtTitre.AllowPromptAsInput = true;
            txtTitre.AnimateReadOnly = false;
            txtTitre.AsciiOnly = false;
            txtTitre.BackgroundImageLayout = ImageLayout.None;
            txtTitre.BeepOnError = false;
            txtTitre.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTitre.Depth = 0;
            txtTitre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTitre.HidePromptOnLeave = false;
            txtTitre.HideSelection = true;
            txtTitre.Hint = "Titre Livre";
            txtTitre.InsertKeyMode = InsertKeyMode.Default;
            txtTitre.LeadingIcon = null;
            txtTitre.Location = new Point(28, 105);
            txtTitre.Mask = "";
            txtTitre.MaxLength = 32767;
            txtTitre.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtTitre.Name = "txtTitre";
            txtTitre.PasswordChar = '\0';
            txtTitre.PrefixSuffixText = null;
            txtTitre.PromptChar = '_';
            txtTitre.ReadOnly = false;
            txtTitre.RejectInputOnFirstFailure = false;
            txtTitre.ResetOnPrompt = true;
            txtTitre.ResetOnSpace = true;
            txtTitre.RightToLeft = RightToLeft.No;
            txtTitre.SelectedText = "";
            txtTitre.SelectionLength = 0;
            txtTitre.SelectionStart = 0;
            txtTitre.ShortcutsEnabled = true;
            txtTitre.Size = new Size(331, 48);
            txtTitre.SkipLiterals = true;
            txtTitre.TabIndex = 17;
            txtTitre.TabStop = false;
            txtTitre.TextAlign = HorizontalAlignment.Left;
            txtTitre.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTitre.TrailingIcon = null;
            txtTitre.UseSystemPasswordChar = false;
            txtTitre.ValidatingType = null;
            // 
            // txtIdLivre
            // 
            txtIdLivre.AllowPromptAsInput = true;
            txtIdLivre.AnimateReadOnly = false;
            txtIdLivre.AsciiOnly = false;
            txtIdLivre.BackgroundImageLayout = ImageLayout.None;
            txtIdLivre.BeepOnError = false;
            txtIdLivre.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtIdLivre.Depth = 0;
            txtIdLivre.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIdLivre.HidePromptOnLeave = false;
            txtIdLivre.HideSelection = true;
            txtIdLivre.Hint = "ID Livre";
            txtIdLivre.InsertKeyMode = InsertKeyMode.Default;
            txtIdLivre.LeadingIcon = null;
            txtIdLivre.Location = new Point(28, 24);
            txtIdLivre.Mask = "";
            txtIdLivre.MaxLength = 32767;
            txtIdLivre.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtIdLivre.Name = "txtIdLivre";
            txtIdLivre.PasswordChar = '\0';
            txtIdLivre.PrefixSuffixText = null;
            txtIdLivre.PromptChar = '_';
            txtIdLivre.ReadOnly = false;
            txtIdLivre.RejectInputOnFirstFailure = false;
            txtIdLivre.ResetOnPrompt = true;
            txtIdLivre.ResetOnSpace = true;
            txtIdLivre.RightToLeft = RightToLeft.No;
            txtIdLivre.SelectedText = "";
            txtIdLivre.SelectionLength = 0;
            txtIdLivre.SelectionStart = 0;
            txtIdLivre.ShortcutsEnabled = true;
            txtIdLivre.Size = new Size(331, 48);
            txtIdLivre.SkipLiterals = true;
            txtIdLivre.TabIndex = 16;
            txtIdLivre.TabStop = false;
            txtIdLivre.TextAlign = HorizontalAlignment.Left;
            txtIdLivre.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtIdLivre.TrailingIcon = null;
            txtIdLivre.UseSystemPasswordChar = false;
            txtIdLivre.ValidatingType = null;
            txtIdLivre.Click += txtIdLivre_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(Btn2NouveauE);
            tabPage1.Controls.Add(Btn2Fermer);
            tabPage1.Controls.Add(Btn2SupprimerE);
            tabPage1.Controls.Add(Btn2ModifierE);
            tabPage1.Controls.Add(Btn2EnregistrerE);
            tabPage1.Controls.Add(dgvEtudiant);
            tabPage1.Controls.Add(txt2Email);
            tabPage1.Controls.Add(txt2Prenom);
            tabPage1.Controls.Add(txt2Nom);
            tabPage1.Controls.Add(txt2IdEtudiant);
            tabPage1.Controls.Add(txtIdEtudiant);
            tabPage1.ImageKey = "icons8-student-48.png";
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1372, 585);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Etudiant";
            tabPage1.Click += tabPage1_Click;
            // 
            // Btn2NouveauE
            // 
            Btn2NouveauE.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn2NouveauE.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            Btn2NouveauE.Depth = 0;
            Btn2NouveauE.HighEmphasis = true;
            Btn2NouveauE.Icon = null;
            Btn2NouveauE.Location = new Point(219, 480);
            Btn2NouveauE.Margin = new Padding(4, 6, 4, 6);
            Btn2NouveauE.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            Btn2NouveauE.Name = "Btn2NouveauE";
            Btn2NouveauE.NoAccentTextColor = Color.Empty;
            Btn2NouveauE.Size = new Size(89, 36);
            Btn2NouveauE.TabIndex = 22;
            Btn2NouveauE.Text = "Nouveau";
            Btn2NouveauE.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            Btn2NouveauE.UseAccentColor = false;
            Btn2NouveauE.UseVisualStyleBackColor = true;
            Btn2NouveauE.Click += Btn2NouveauE_Click_1;
            // 
            // Btn2Fermer
            // 
            Btn2Fermer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn2Fermer.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            Btn2Fermer.Depth = 0;
            Btn2Fermer.HighEmphasis = true;
            Btn2Fermer.Icon = null;
            Btn2Fermer.Location = new Point(762, 480);
            Btn2Fermer.Margin = new Padding(4, 6, 4, 6);
            Btn2Fermer.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            Btn2Fermer.Name = "Btn2Fermer";
            Btn2Fermer.NoAccentTextColor = Color.Empty;
            Btn2Fermer.Size = new Size(78, 36);
            Btn2Fermer.TabIndex = 21;
            Btn2Fermer.Text = "Fermer";
            Btn2Fermer.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            Btn2Fermer.UseAccentColor = false;
            Btn2Fermer.UseVisualStyleBackColor = true;
            Btn2Fermer.Click += Btn2FermerE_Click;
            // 
            // Btn2SupprimerE
            // 
            Btn2SupprimerE.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn2SupprimerE.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            Btn2SupprimerE.Depth = 0;
            Btn2SupprimerE.HighEmphasis = true;
            Btn2SupprimerE.Icon = null;
            Btn2SupprimerE.Location = new Point(572, 480);
            Btn2SupprimerE.Margin = new Padding(4, 6, 4, 6);
            Btn2SupprimerE.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            Btn2SupprimerE.Name = "Btn2SupprimerE";
            Btn2SupprimerE.NoAccentTextColor = Color.Empty;
            Btn2SupprimerE.Size = new Size(102, 36);
            Btn2SupprimerE.TabIndex = 20;
            Btn2SupprimerE.Text = "supprimer";
            Btn2SupprimerE.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            Btn2SupprimerE.UseAccentColor = false;
            Btn2SupprimerE.UseVisualStyleBackColor = true;
            Btn2SupprimerE.Click += Btn2SupprimerE_Click;
            // 
            // Btn2ModifierE
            // 
            Btn2ModifierE.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn2ModifierE.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            Btn2ModifierE.Depth = 0;
            Btn2ModifierE.HighEmphasis = true;
            Btn2ModifierE.Icon = null;
            Btn2ModifierE.Location = new Point(402, 480);
            Btn2ModifierE.Margin = new Padding(4, 6, 4, 6);
            Btn2ModifierE.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            Btn2ModifierE.Name = "Btn2ModifierE";
            Btn2ModifierE.NoAccentTextColor = Color.Empty;
            Btn2ModifierE.Size = new Size(88, 36);
            Btn2ModifierE.TabIndex = 18;
            Btn2ModifierE.Text = "Modifier";
            Btn2ModifierE.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            Btn2ModifierE.UseAccentColor = false;
            Btn2ModifierE.UseVisualStyleBackColor = true;
            Btn2ModifierE.Click += Btn2ModifierE_Click;
            // 
            // Btn2EnregistrerE
            // 
            Btn2EnregistrerE.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btn2EnregistrerE.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            Btn2EnregistrerE.Depth = 0;
            Btn2EnregistrerE.HighEmphasis = true;
            Btn2EnregistrerE.Icon = null;
            Btn2EnregistrerE.Location = new Point(19, 480);
            Btn2EnregistrerE.Margin = new Padding(4, 6, 4, 6);
            Btn2EnregistrerE.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            Btn2EnregistrerE.Name = "Btn2EnregistrerE";
            Btn2EnregistrerE.NoAccentTextColor = Color.Empty;
            Btn2EnregistrerE.Size = new Size(117, 36);
            Btn2EnregistrerE.TabIndex = 17;
            Btn2EnregistrerE.Text = "Enregistrer";
            Btn2EnregistrerE.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            Btn2EnregistrerE.UseAccentColor = false;
            Btn2EnregistrerE.UseVisualStyleBackColor = true;
            Btn2EnregistrerE.Click += Btn2EnregistrerE_Click;
            // 
            // dgvEtudiant
            // 
            dgvEtudiant.AllowUserToDeleteRows = false;
            dgvEtudiant.AllowUserToResizeRows = false;
            dgvEtudiant.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEtudiant.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvEtudiant.BorderStyle = BorderStyle.None;
            dgvEtudiant.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal;
            dgvEtudiant.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle61.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle61.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle61.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            dataGridViewCellStyle61.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle61.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle61.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle61.WrapMode = DataGridViewTriState.True;
            dgvEtudiant.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle61;
            dgvEtudiant.ColumnHeadersHeight = 56;
            dgvEtudiant.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle62.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle62.BackColor = SystemColors.Window;
            dataGridViewCellStyle62.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle62.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dataGridViewCellStyle62.SelectionBackColor = Color.FromArgb(63, 81, 181);
            dataGridViewCellStyle62.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle62.WrapMode = DataGridViewTriState.False;
            dgvEtudiant.DefaultCellStyle = dataGridViewCellStyle62;
            dgvEtudiant.Depth = 0;
            dgvEtudiant.EnableHeadersVisualStyles = false;
            dgvEtudiant.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvEtudiant.GridColor = Color.AliceBlue;
            dgvEtudiant.Location = new Point(375, 54);
            dgvEtudiant.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            dgvEtudiant.Name = "dgvEtudiant";
            dataGridViewCellStyle63.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = SystemColors.Control;
            dataGridViewCellStyle63.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle63.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle63.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle63.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle63.WrapMode = DataGridViewTriState.True;
            dgvEtudiant.RowHeadersDefaultCellStyle = dataGridViewCellStyle63;
            dgvEtudiant.RowHeadersVisible = false;
            dataGridViewCellStyle64.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle64.ForeColor = Color.FromArgb(222, 0, 0, 0);
            dgvEtudiant.RowsDefaultCellStyle = dataGridViewCellStyle64;
            dgvEtudiant.RowTemplate.Height = 52;
            dgvEtudiant.ScrollBars = ScrollBars.None;
            dgvEtudiant.ShowVerticalScroll = false;
            dgvEtudiant.Size = new Size(806, 353);
            dgvEtudiant.TabIndex = 19;
            dgvEtudiant.CellContentClick += dgvEtudiant_CellContentClick;
            // 
            // txt2Email
            // 
            txt2Email.AllowPromptAsInput = true;
            txt2Email.AnimateReadOnly = false;
            txt2Email.AsciiOnly = false;
            txt2Email.BackgroundImageLayout = ImageLayout.None;
            txt2Email.BeepOnError = false;
            txt2Email.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txt2Email.Depth = 0;
            txt2Email.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt2Email.HidePromptOnLeave = false;
            txt2Email.HideSelection = true;
            txt2Email.Hint = "Email";
            txt2Email.InsertKeyMode = InsertKeyMode.Default;
            txt2Email.LeadingIcon = null;
            txt2Email.Location = new Point(19, 283);
            txt2Email.Mask = "";
            txt2Email.MaxLength = 32767;
            txt2Email.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txt2Email.Name = "txt2Email";
            txt2Email.PasswordChar = '\0';
            txt2Email.PrefixSuffixText = null;
            txt2Email.PromptChar = '_';
            txt2Email.ReadOnly = false;
            txt2Email.RejectInputOnFirstFailure = false;
            txt2Email.ResetOnPrompt = true;
            txt2Email.ResetOnSpace = true;
            txt2Email.RightToLeft = RightToLeft.No;
            txt2Email.SelectedText = "";
            txt2Email.SelectionLength = 0;
            txt2Email.SelectionStart = 0;
            txt2Email.ShortcutsEnabled = true;
            txt2Email.Size = new Size(250, 48);
            txt2Email.SkipLiterals = true;
            txt2Email.TabIndex = 16;
            txt2Email.TabStop = false;
            txt2Email.TextAlign = HorizontalAlignment.Left;
            txt2Email.TextMaskFormat = MaskFormat.IncludeLiterals;
            txt2Email.TrailingIcon = null;
            txt2Email.UseSystemPasswordChar = false;
            txt2Email.ValidatingType = null;
            // 
            // txt2Prenom
            // 
            txt2Prenom.AllowPromptAsInput = true;
            txt2Prenom.AnimateReadOnly = false;
            txt2Prenom.AsciiOnly = false;
            txt2Prenom.BackgroundImageLayout = ImageLayout.None;
            txt2Prenom.BeepOnError = false;
            txt2Prenom.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txt2Prenom.Depth = 0;
            txt2Prenom.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt2Prenom.HidePromptOnLeave = false;
            txt2Prenom.HideSelection = true;
            txt2Prenom.Hint = "prénom d'étudiant";
            txt2Prenom.InsertKeyMode = InsertKeyMode.Default;
            txt2Prenom.LeadingIcon = null;
            txt2Prenom.Location = new Point(19, 205);
            txt2Prenom.Mask = "";
            txt2Prenom.MaxLength = 32767;
            txt2Prenom.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txt2Prenom.Name = "txt2Prenom";
            txt2Prenom.PasswordChar = '\0';
            txt2Prenom.PrefixSuffixText = null;
            txt2Prenom.PromptChar = '_';
            txt2Prenom.ReadOnly = false;
            txt2Prenom.RejectInputOnFirstFailure = false;
            txt2Prenom.ResetOnPrompt = true;
            txt2Prenom.ResetOnSpace = true;
            txt2Prenom.RightToLeft = RightToLeft.No;
            txt2Prenom.SelectedText = "";
            txt2Prenom.SelectionLength = 0;
            txt2Prenom.SelectionStart = 0;
            txt2Prenom.ShortcutsEnabled = true;
            txt2Prenom.Size = new Size(250, 48);
            txt2Prenom.SkipLiterals = true;
            txt2Prenom.TabIndex = 15;
            txt2Prenom.TabStop = false;
            txt2Prenom.TextAlign = HorizontalAlignment.Left;
            txt2Prenom.TextMaskFormat = MaskFormat.IncludeLiterals;
            txt2Prenom.TrailingIcon = null;
            txt2Prenom.UseSystemPasswordChar = false;
            txt2Prenom.ValidatingType = null;
            // 
            // txt2Nom
            // 
            txt2Nom.AllowPromptAsInput = true;
            txt2Nom.AnimateReadOnly = false;
            txt2Nom.AsciiOnly = false;
            txt2Nom.BackgroundImageLayout = ImageLayout.None;
            txt2Nom.BeepOnError = false;
            txt2Nom.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txt2Nom.Depth = 0;
            txt2Nom.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt2Nom.HidePromptOnLeave = false;
            txt2Nom.HideSelection = true;
            txt2Nom.Hint = "Nom d'étudiant";
            txt2Nom.InsertKeyMode = InsertKeyMode.Default;
            txt2Nom.LeadingIcon = null;
            txt2Nom.Location = new Point(19, 132);
            txt2Nom.Mask = "";
            txt2Nom.MaxLength = 32767;
            txt2Nom.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txt2Nom.Name = "txt2Nom";
            txt2Nom.PasswordChar = '\0';
            txt2Nom.PrefixSuffixText = null;
            txt2Nom.PromptChar = '_';
            txt2Nom.ReadOnly = false;
            txt2Nom.RejectInputOnFirstFailure = false;
            txt2Nom.ResetOnPrompt = true;
            txt2Nom.ResetOnSpace = true;
            txt2Nom.RightToLeft = RightToLeft.No;
            txt2Nom.SelectedText = "";
            txt2Nom.SelectionLength = 0;
            txt2Nom.SelectionStart = 0;
            txt2Nom.ShortcutsEnabled = true;
            txt2Nom.Size = new Size(250, 48);
            txt2Nom.SkipLiterals = true;
            txt2Nom.TabIndex = 14;
            txt2Nom.TabStop = false;
            txt2Nom.TextAlign = HorizontalAlignment.Left;
            txt2Nom.TextMaskFormat = MaskFormat.IncludeLiterals;
            txt2Nom.TrailingIcon = null;
            txt2Nom.UseSystemPasswordChar = false;
            txt2Nom.ValidatingType = null;
            // 
            // txt2IdEtudiant
            // 
            txt2IdEtudiant.AllowPromptAsInput = true;
            txt2IdEtudiant.AnimateReadOnly = false;
            txt2IdEtudiant.AsciiOnly = false;
            txt2IdEtudiant.BackgroundImageLayout = ImageLayout.None;
            txt2IdEtudiant.BeepOnError = false;
            txt2IdEtudiant.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txt2IdEtudiant.Depth = 0;
            txt2IdEtudiant.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt2IdEtudiant.HidePromptOnLeave = false;
            txt2IdEtudiant.HideSelection = true;
            txt2IdEtudiant.Hint = "id";
            txt2IdEtudiant.InsertKeyMode = InsertKeyMode.Default;
            txt2IdEtudiant.LeadingIcon = null;
            txt2IdEtudiant.Location = new Point(19, 54);
            txt2IdEtudiant.Mask = "";
            txt2IdEtudiant.MaxLength = 32767;
            txt2IdEtudiant.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txt2IdEtudiant.Name = "txt2IdEtudiant";
            txt2IdEtudiant.PasswordChar = '\0';
            txt2IdEtudiant.PrefixSuffixText = null;
            txt2IdEtudiant.PromptChar = '_';
            txt2IdEtudiant.ReadOnly = true;
            txt2IdEtudiant.RejectInputOnFirstFailure = false;
            txt2IdEtudiant.ResetOnPrompt = true;
            txt2IdEtudiant.ResetOnSpace = true;
            txt2IdEtudiant.RightToLeft = RightToLeft.No;
            txt2IdEtudiant.SelectedText = "";
            txt2IdEtudiant.SelectionLength = 0;
            txt2IdEtudiant.SelectionStart = 0;
            txt2IdEtudiant.ShortcutsEnabled = true;
            txt2IdEtudiant.Size = new Size(250, 48);
            txt2IdEtudiant.SkipLiterals = true;
            txt2IdEtudiant.TabIndex = 13;
            txt2IdEtudiant.TabStop = false;
            txt2IdEtudiant.TextAlign = HorizontalAlignment.Left;
            txt2IdEtudiant.TextMaskFormat = MaskFormat.IncludeLiterals;
            txt2IdEtudiant.TrailingIcon = null;
            txt2IdEtudiant.UseSystemPasswordChar = false;
            txt2IdEtudiant.ValidatingType = null;
            txt2IdEtudiant.Click += txt2IdEtudiant_Click;
            // 
            // txtIdEtudiant
            // 
            txtIdEtudiant.AllowPromptAsInput = true;
            txtIdEtudiant.AnimateReadOnly = false;
            txtIdEtudiant.AsciiOnly = false;
            txtIdEtudiant.BackgroundImageLayout = ImageLayout.None;
            txtIdEtudiant.BeepOnError = false;
            txtIdEtudiant.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtIdEtudiant.Depth = 0;
            txtIdEtudiant.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtIdEtudiant.HidePromptOnLeave = false;
            txtIdEtudiant.HideSelection = true;
            txtIdEtudiant.Hint = "id";
            txtIdEtudiant.InsertKeyMode = InsertKeyMode.Default;
            txtIdEtudiant.LeadingIcon = null;
            txtIdEtudiant.Location = new Point(-75, -79);
            txtIdEtudiant.Mask = "";
            txtIdEtudiant.MaxLength = 32767;
            txtIdEtudiant.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            txtIdEtudiant.Name = "txtIdEtudiant";
            txtIdEtudiant.PasswordChar = '\0';
            txtIdEtudiant.PrefixSuffixText = null;
            txtIdEtudiant.PromptChar = '_';
            txtIdEtudiant.ReadOnly = false;
            txtIdEtudiant.RejectInputOnFirstFailure = false;
            txtIdEtudiant.ResetOnPrompt = true;
            txtIdEtudiant.ResetOnSpace = true;
            txtIdEtudiant.RightToLeft = RightToLeft.No;
            txtIdEtudiant.SelectedText = "";
            txtIdEtudiant.SelectionLength = 0;
            txtIdEtudiant.SelectionStart = 0;
            txtIdEtudiant.ShortcutsEnabled = true;
            txtIdEtudiant.Size = new Size(250, 48);
            txtIdEtudiant.SkipLiterals = true;
            txtIdEtudiant.TabIndex = 12;
            txtIdEtudiant.TabStop = false;
            txtIdEtudiant.TextAlign = HorizontalAlignment.Left;
            txtIdEtudiant.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtIdEtudiant.TrailingIcon = null;
            txtIdEtudiant.UseSystemPasswordChar = false;
            txtIdEtudiant.ValidatingType = null;
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPage1);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Controls.Add(tabPage5);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = IconsListe;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1380, 628);
            materialTabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.White;
            tabPage5.Controls.Add(materialButton1);
            tabPage5.ImageKey = "icons8-quit-50.png";
            tabPage5.Location = new Point(4, 39);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(1372, 585);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(351, 82);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(146, 36);
            materialButton1.TabIndex = 1;
            materialButton1.Text = "Se déconnecter";
            materialButton1.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 695);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "DashboardAdmin";
            Text = "DashboardAdmin";
            Load += DashboardAdmin_Load;
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResponsable).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservationListeA).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLivre).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtudiant).EndInit();
            materialTabControl1.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ImageList IconsListe;
        private TabPage tabPage4;
        private MaterialSkin2DotNet.Controls.MaterialDataTable dgvResponsable;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtEmailResponsable;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtPrenomResponsable;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtNomResponsable;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private MaterialSkin2DotNet.Controls.MaterialButton btnNouveauL;
        private MaterialSkin2DotNet.Controls.MaterialButton btnFermerL;
        private MaterialSkin2DotNet.Controls.MaterialButton btnSupprimerL;
        private MaterialSkin2DotNet.Controls.MaterialButton btnModifierL;
        private MaterialSkin2DotNet.Controls.MaterialButton btnAjouterL;
        private MaterialSkin2DotNet.Controls.MaterialDataTable dgvLivre;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtCategorie;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtEtat;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtAuteur;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtQte;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtTitre;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtIdLivre;
        private TabPage tabPage1;
        private MaterialSkin2DotNet.Controls.MaterialButton Btn2NouveauE;
        private MaterialSkin2DotNet.Controls.MaterialButton Btn2Fermer;
        private MaterialSkin2DotNet.Controls.MaterialButton Btn2SupprimerE;
        private MaterialSkin2DotNet.Controls.MaterialButton Btn2ModifierE;
        private MaterialSkin2DotNet.Controls.MaterialButton Btn2EnregistrerE;
        private MaterialSkin2DotNet.Controls.MaterialDataTable dgvEtudiant;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txt2Email;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txt2Prenom;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txt2Nom;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txt2IdEtudiant;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtIdEtudiant;
        private MaterialSkin2DotNet.Controls.MaterialTabControl materialTabControl1;
        private MaterialSkin2DotNet.Controls.MaterialButton btnNouveau;
        private MaterialSkin2DotNet.Controls.MaterialButton btnFermer;
        private MaterialSkin2DotNet.Controls.MaterialButton btnSupprimer;
        private MaterialSkin2DotNet.Controls.MaterialButton btnModifier;
        private MaterialSkin2DotNet.Controls.MaterialButton btnEnregistrer;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtPasswordResponsable;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox txtUsername;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox idRespo;
        private MaterialSkin2DotNet.Controls.MaterialDataTable dgvReservationListeA;
        private TabPage tabPage5;
        private MaterialSkin2DotNet.Controls.MaterialButton materialButton1;
    }
}