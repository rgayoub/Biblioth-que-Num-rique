namespace EFMbiblio
{
    partial class utilisateurForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(utilisateurForm));
            textUtilisateur = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            textModepasse = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            Btnutilisateurconnecter = new MaterialSkin2DotNet.Controls.MaterialButton();
            BtnutilisateurQuitter = new MaterialSkin2DotNet.Controls.MaterialButton();
            materialDrawer1 = new MaterialSkin2DotNet.Controls.MaterialDrawer();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textUtilisateur
            // 
            textUtilisateur.AllowPromptAsInput = true;
            textUtilisateur.AnimateReadOnly = false;
            textUtilisateur.AsciiOnly = false;
            textUtilisateur.BackgroundImageLayout = ImageLayout.None;
            textUtilisateur.BeepOnError = false;
            textUtilisateur.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            textUtilisateur.Depth = 0;
            textUtilisateur.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textUtilisateur.HidePromptOnLeave = false;
            textUtilisateur.HideSelection = true;
            textUtilisateur.Hint = "Nom d'utilisateur";
            textUtilisateur.InsertKeyMode = InsertKeyMode.Default;
            textUtilisateur.LeadingIcon = null;
            textUtilisateur.Location = new Point(58, 187);
            textUtilisateur.Mask = "";
            textUtilisateur.MaxLength = 32767;
            textUtilisateur.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            textUtilisateur.Name = "textUtilisateur";
            textUtilisateur.PasswordChar = '\0';
            textUtilisateur.PrefixSuffixText = null;
            textUtilisateur.PromptChar = '_';
            textUtilisateur.ReadOnly = false;
            textUtilisateur.RejectInputOnFirstFailure = false;
            textUtilisateur.ResetOnPrompt = true;
            textUtilisateur.ResetOnSpace = true;
            textUtilisateur.RightToLeft = RightToLeft.No;
            textUtilisateur.SelectedText = "";
            textUtilisateur.SelectionLength = 0;
            textUtilisateur.SelectionStart = 0;
            textUtilisateur.ShortcutsEnabled = true;
            textUtilisateur.Size = new Size(430, 48);
            textUtilisateur.SkipLiterals = true;
            textUtilisateur.TabIndex = 0;
            textUtilisateur.TabStop = false;
            textUtilisateur.TextAlign = HorizontalAlignment.Left;
            textUtilisateur.TextMaskFormat = MaskFormat.IncludeLiterals;
            textUtilisateur.TrailingIcon = null;
            textUtilisateur.UseSystemPasswordChar = false;
            textUtilisateur.ValidatingType = null;
            // 
            // textModepasse
            // 
            textModepasse.AllowPromptAsInput = true;
            textModepasse.AnimateReadOnly = false;
            textModepasse.AsciiOnly = false;
            textModepasse.BackgroundImageLayout = ImageLayout.None;
            textModepasse.BeepOnError = false;
            textModepasse.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            textModepasse.Depth = 0;
            textModepasse.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textModepasse.HidePromptOnLeave = false;
            textModepasse.HideSelection = true;
            textModepasse.Hint = "Mode passe";
            textModepasse.InsertKeyMode = InsertKeyMode.Default;
            textModepasse.LeadingIcon = null;
            textModepasse.Location = new Point(58, 254);
            textModepasse.Mask = "";
            textModepasse.MaxLength = 32767;
            textModepasse.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            textModepasse.Name = "textModepasse";
            textModepasse.PasswordChar = '●';
            textModepasse.PrefixSuffixText = null;
            textModepasse.PromptChar = '_';
            textModepasse.ReadOnly = false;
            textModepasse.RejectInputOnFirstFailure = false;
            textModepasse.ResetOnPrompt = true;
            textModepasse.ResetOnSpace = true;
            textModepasse.RightToLeft = RightToLeft.No;
            textModepasse.SelectedText = "";
            textModepasse.SelectionLength = 0;
            textModepasse.SelectionStart = 0;
            textModepasse.ShortcutsEnabled = true;
            textModepasse.Size = new Size(430, 48);
            textModepasse.SkipLiterals = true;
            textModepasse.TabIndex = 0;
            textModepasse.TabStop = false;
            textModepasse.TextAlign = HorizontalAlignment.Left;
            textModepasse.TextMaskFormat = MaskFormat.IncludeLiterals;
            textModepasse.TrailingIcon = null;
            textModepasse.UseSystemPasswordChar = true;
            textModepasse.ValidatingType = null;
            // 
            // Btnutilisateurconnecter
            // 
            Btnutilisateurconnecter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Btnutilisateurconnecter.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            Btnutilisateurconnecter.Depth = 0;
            Btnutilisateurconnecter.HighEmphasis = true;
            Btnutilisateurconnecter.Icon = null;
            Btnutilisateurconnecter.Location = new Point(193, 326);
            Btnutilisateurconnecter.Margin = new Padding(4, 6, 4, 6);
            Btnutilisateurconnecter.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            Btnutilisateurconnecter.Name = "Btnutilisateurconnecter";
            Btnutilisateurconnecter.NoAccentTextColor = Color.Empty;
            Btnutilisateurconnecter.Size = new Size(128, 36);
            Btnutilisateurconnecter.TabIndex = 1;
            Btnutilisateurconnecter.Text = "Se Connecter";
            Btnutilisateurconnecter.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            Btnutilisateurconnecter.UseAccentColor = false;
            Btnutilisateurconnecter.UseVisualStyleBackColor = true;
            Btnutilisateurconnecter.Click += Btnutilisateurconnecter_Click;
            // 
            // BtnutilisateurQuitter
            // 
            BtnutilisateurQuitter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnutilisateurQuitter.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnutilisateurQuitter.Depth = 0;
            BtnutilisateurQuitter.HighEmphasis = true;
            BtnutilisateurQuitter.Icon = null;
            BtnutilisateurQuitter.Location = new Point(216, 374);
            BtnutilisateurQuitter.Margin = new Padding(4, 6, 4, 6);
            BtnutilisateurQuitter.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnutilisateurQuitter.Name = "BtnutilisateurQuitter";
            BtnutilisateurQuitter.NoAccentTextColor = Color.Empty;
            BtnutilisateurQuitter.Size = new Size(81, 36);
            BtnutilisateurQuitter.TabIndex = 1;
            BtnutilisateurQuitter.Text = "Quitter";
            BtnutilisateurQuitter.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnutilisateurQuitter.UseAccentColor = false;
            BtnutilisateurQuitter.UseVisualStyleBackColor = true;
            // 
            // materialDrawer1
            // 
            materialDrawer1.AutoHide = false;
            materialDrawer1.AutoShow = false;
            materialDrawer1.BackgroundWithAccent = false;
            materialDrawer1.BaseTabControl = null;
            materialDrawer1.Depth = 0;
            materialDrawer1.HighlightWithAccent = true;
            materialDrawer1.IndicatorWidth = 0;
            materialDrawer1.IsOpen = false;
            materialDrawer1.Location = new Point(-62, 89);
            materialDrawer1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialDrawer1.Name = "materialDrawer1";
            materialDrawer1.ShowIconsWhenHidden = false;
            materialDrawer1.Size = new Size(62, 216);
            materialDrawer1.TabIndex = 2;
            materialDrawer1.Text = "materialDrawer1";
            materialDrawer1.UseColors = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(114, 68);
            label1.Name = "label1";
            label1.Size = new Size(292, 30);
            label1.TabIndex = 5;
            label1.Text = "BIBLIOTHEQUE NUMERIQUE";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(564, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 383);
            panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(193, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // utilisateurForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(materialDrawer1);
            Controls.Add(BtnutilisateurQuitter);
            Controls.Add(Btnutilisateurconnecter);
            Controls.Add(textModepasse);
            Controls.Add(textUtilisateur);
            Name = "utilisateurForm";
            Text = "utilisateur";
            Load += utilisateur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox textUtilisateur;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox textModepasse;
        private MaterialSkin2DotNet.Controls.MaterialButton Btnutilisateurconnecter;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnutilisateurQuitter;
        private MaterialSkin2DotNet.Controls.MaterialDrawer materialDrawer1;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}