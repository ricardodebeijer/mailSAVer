namespace MailSAVerAddin
{
    partial class FormInstellingen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstellingen));
            this.lbNamen = new System.Windows.Forms.ListBox();
            this.lblNamenLijst = new System.Windows.Forms.Label();
            this.lblNaamVerwijderen = new System.Windows.Forms.Label();
            this.btnNaamVerwijder = new System.Windows.Forms.Button();
            this.lblNaamToevoegen = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.btnNaamToevoegen = new System.Windows.Forms.Button();
            this.gbNamenUitgaand = new System.Windows.Forms.GroupBox();
            this.gbLocaties = new System.Windows.Forms.GroupBox();
            this.btnZetOplopend = new System.Windows.Forms.Button();
            this.lblOplopend = new System.Windows.Forms.Label();
            this.btnZetAflopend = new System.Windows.Forms.Button();
            this.lblAflopendeLocatie = new System.Windows.Forms.Label();
            this.lblLocatiesLijst = new System.Windows.Forms.Label();
            this.btnLocatieZetAnders = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocatieZetStandaard = new System.Windows.Forms.Button();
            this.btnFolderBrowser = new System.Windows.Forms.Button();
            this.lblLocatieVerwijderen = new System.Windows.Forms.Label();
            this.btnLocatieVerwijder = new System.Windows.Forms.Button();
            this.lbLocaties = new System.Windows.Forms.ListBox();
            this.gbNamenUitgaand.SuspendLayout();
            this.gbLocaties.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNamen
            // 
            this.lbNamen.FormattingEnabled = true;
            this.lbNamen.ItemHeight = 16;
            this.lbNamen.Location = new System.Drawing.Point(9, 38);
            this.lbNamen.Name = "lbNamen";
            this.lbNamen.Size = new System.Drawing.Size(220, 212);
            this.lbNamen.TabIndex = 0;
            // 
            // lblNamenLijst
            // 
            this.lblNamenLijst.AutoSize = true;
            this.lblNamenLijst.Location = new System.Drawing.Point(6, 18);
            this.lblNamenLijst.Name = "lblNamenLijst";
            this.lblNamenLijst.Size = new System.Drawing.Size(194, 17);
            this.lblNamenLijst.TabIndex = 1;
            this.lblNamenLijst.Text = "Namen voor uitgaande Email:";
            // 
            // lblNaamVerwijderen
            // 
            this.lblNaamVerwijderen.AutoSize = true;
            this.lblNaamVerwijderen.Location = new System.Drawing.Point(6, 253);
            this.lblNaamVerwijderen.Name = "lblNaamVerwijderen";
            this.lblNaamVerwijderen.Size = new System.Drawing.Size(199, 17);
            this.lblNaamVerwijderen.TabIndex = 2;
            this.lblNaamVerwijderen.Text = "Verwijder geselecteerde naam";
            // 
            // btnNaamVerwijder
            // 
            this.btnNaamVerwijder.Location = new System.Drawing.Point(129, 273);
            this.btnNaamVerwijder.Name = "btnNaamVerwijder";
            this.btnNaamVerwijder.Size = new System.Drawing.Size(100, 30);
            this.btnNaamVerwijder.TabIndex = 5;
            this.btnNaamVerwijder.Text = "Verwijder";
            this.btnNaamVerwijder.UseVisualStyleBackColor = true;
            this.btnNaamVerwijder.Click += new System.EventHandler(this.btnNaamVerwijder_Click);
            // 
            // lblNaamToevoegen
            // 
            this.lblNaamToevoegen.AutoSize = true;
            this.lblNaamToevoegen.Location = new System.Drawing.Point(6, 345);
            this.lblNaamToevoegen.Name = "lblNaamToevoegen";
            this.lblNaamToevoegen.Size = new System.Drawing.Size(167, 17);
            this.lblNaamToevoegen.TabIndex = 4;
            this.lblNaamToevoegen.Text = "Toevoegen nieuwe naam";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(6, 365);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(223, 22);
            this.tbNaam.TabIndex = 2;
            // 
            // btnNaamToevoegen
            // 
            this.btnNaamToevoegen.Location = new System.Drawing.Point(129, 393);
            this.btnNaamToevoegen.Name = "btnNaamToevoegen";
            this.btnNaamToevoegen.Size = new System.Drawing.Size(100, 30);
            this.btnNaamToevoegen.TabIndex = 3;
            this.btnNaamToevoegen.Text = "Voeg Toe";
            this.btnNaamToevoegen.UseVisualStyleBackColor = true;
            this.btnNaamToevoegen.Click += new System.EventHandler(this.btnNaamToevoegen_Click);
            // 
            // gbNamenUitgaand
            // 
            this.gbNamenUitgaand.Controls.Add(this.lbNamen);
            this.gbNamenUitgaand.Controls.Add(this.btnNaamToevoegen);
            this.gbNamenUitgaand.Controls.Add(this.lblNamenLijst);
            this.gbNamenUitgaand.Controls.Add(this.tbNaam);
            this.gbNamenUitgaand.Controls.Add(this.lblNaamVerwijderen);
            this.gbNamenUitgaand.Controls.Add(this.lblNaamToevoegen);
            this.gbNamenUitgaand.Controls.Add(this.btnNaamVerwijder);
            this.gbNamenUitgaand.Location = new System.Drawing.Point(535, 12);
            this.gbNamenUitgaand.Name = "gbNamenUitgaand";
            this.gbNamenUitgaand.Size = new System.Drawing.Size(235, 429);
            this.gbNamenUitgaand.TabIndex = 7;
            this.gbNamenUitgaand.TabStop = false;
            this.gbNamenUitgaand.Text = "Uitgaande Email";
            // 
            // gbLocaties
            // 
            this.gbLocaties.Controls.Add(this.btnZetOplopend);
            this.gbLocaties.Controls.Add(this.lblOplopend);
            this.gbLocaties.Controls.Add(this.btnZetAflopend);
            this.gbLocaties.Controls.Add(this.lblAflopendeLocatie);
            this.gbLocaties.Controls.Add(this.lblLocatiesLijst);
            this.gbLocaties.Controls.Add(this.btnLocatieZetAnders);
            this.gbLocaties.Controls.Add(this.label2);
            this.gbLocaties.Controls.Add(this.label1);
            this.gbLocaties.Controls.Add(this.btnLocatieZetStandaard);
            this.gbLocaties.Controls.Add(this.btnFolderBrowser);
            this.gbLocaties.Controls.Add(this.lblLocatieVerwijderen);
            this.gbLocaties.Controls.Add(this.btnLocatieVerwijder);
            this.gbLocaties.Controls.Add(this.lbLocaties);
            this.gbLocaties.Location = new System.Drawing.Point(12, 12);
            this.gbLocaties.Name = "gbLocaties";
            this.gbLocaties.Size = new System.Drawing.Size(517, 429);
            this.gbLocaties.TabIndex = 8;
            this.gbLocaties.TabStop = false;
            this.gbLocaties.Text = "Opslaglocaties";
            // 
            // btnZetOplopend
            // 
            this.btnZetOplopend.Location = new System.Drawing.Point(121, 385);
            this.btnZetOplopend.Name = "btnZetOplopend";
            this.btnZetOplopend.Size = new System.Drawing.Size(108, 30);
            this.btnZetOplopend.TabIndex = 18;
            this.btnZetOplopend.Text = "Zet Oplopend";
            this.btnZetOplopend.UseVisualStyleBackColor = true;
            this.btnZetOplopend.Click += new System.EventHandler(this.btnZetOplopend_Click);
            // 
            // lblOplopend
            // 
            this.lblOplopend.AutoSize = true;
            this.lblOplopend.Location = new System.Drawing.Point(6, 365);
            this.lblOplopend.Name = "lblOplopend";
            this.lblOplopend.Size = new System.Drawing.Size(209, 17);
            this.lblOplopend.TabIndex = 17;
            this.lblOplopend.Text = "Zet geselecteerde op Oplopend";
            // 
            // btnZetAflopend
            // 
            this.btnZetAflopend.Location = new System.Drawing.Point(121, 326);
            this.btnZetAflopend.Name = "btnZetAflopend";
            this.btnZetAflopend.Size = new System.Drawing.Size(108, 30);
            this.btnZetAflopend.TabIndex = 16;
            this.btnZetAflopend.Text = "Zet Aflopend";
            this.btnZetAflopend.UseVisualStyleBackColor = true;
            this.btnZetAflopend.Click += new System.EventHandler(this.btnZetAflopend_Click);
            // 
            // lblAflopendeLocatie
            // 
            this.lblAflopendeLocatie.AutoSize = true;
            this.lblAflopendeLocatie.Location = new System.Drawing.Point(6, 306);
            this.lblAflopendeLocatie.Name = "lblAflopendeLocatie";
            this.lblAflopendeLocatie.Size = new System.Drawing.Size(207, 17);
            this.lblAflopendeLocatie.TabIndex = 15;
            this.lblAflopendeLocatie.Text = "Zet geselecteerde op Aflopend ";
            // 
            // lblLocatiesLijst
            // 
            this.lblLocatiesLijst.AutoSize = true;
            this.lblLocatiesLijst.Location = new System.Drawing.Point(3, 18);
            this.lblLocatiesLijst.Name = "lblLocatiesLijst";
            this.lblLocatiesLijst.Size = new System.Drawing.Size(398, 17);
            this.lblLocatiesLijst.TabIndex = 14;
            this.lblLocatiesLijst.Text = "Locaties voor opslaan email: Standaard, [Favorieten,] Anders.";
            // 
            // btnLocatieZetAnders
            // 
            this.btnLocatieZetAnders.Location = new System.Drawing.Point(392, 326);
            this.btnLocatieZetAnders.Name = "btnLocatieZetAnders";
            this.btnLocatieZetAnders.Size = new System.Drawing.Size(119, 30);
            this.btnLocatieZetAnders.TabIndex = 13;
            this.btnLocatieZetAnders.Text = "Zet Anders";
            this.btnLocatieZetAnders.UseVisualStyleBackColor = true;
            this.btnLocatieZetAnders.Click += new System.EventHandler(this.btnLocatieZetAnders_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Zet geselecteerde als Anders";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Zet geselecteerde als Standaard";
            // 
            // btnLocatieZetStandaard
            // 
            this.btnLocatieZetStandaard.Location = new System.Drawing.Point(392, 273);
            this.btnLocatieZetStandaard.Name = "btnLocatieZetStandaard";
            this.btnLocatieZetStandaard.Size = new System.Drawing.Size(119, 30);
            this.btnLocatieZetStandaard.TabIndex = 10;
            this.btnLocatieZetStandaard.Text = "Zet Standaard";
            this.btnLocatieZetStandaard.UseVisualStyleBackColor = true;
            this.btnLocatieZetStandaard.Click += new System.EventHandler(this.btnLocatieZetStandaard_Click);
            // 
            // btnFolderBrowser
            // 
            this.btnFolderBrowser.Location = new System.Drawing.Point(307, 378);
            this.btnFolderBrowser.Name = "btnFolderBrowser";
            this.btnFolderBrowser.Size = new System.Drawing.Size(204, 45);
            this.btnFolderBrowser.TabIndex = 8;
            this.btnFolderBrowser.Text = "Voeg Toe met FolderBrowser";
            this.btnFolderBrowser.UseVisualStyleBackColor = true;
            this.btnFolderBrowser.Click += new System.EventHandler(this.btnFolderBrowser_Click);
            // 
            // lblLocatieVerwijderen
            // 
            this.lblLocatieVerwijderen.AutoSize = true;
            this.lblLocatieVerwijderen.Location = new System.Drawing.Point(6, 253);
            this.lblLocatieVerwijderen.Name = "lblLocatieVerwijderen";
            this.lblLocatieVerwijderen.Size = new System.Drawing.Size(247, 17);
            this.lblLocatieVerwijderen.TabIndex = 7;
            this.lblLocatieVerwijderen.Text = "Verwijder geselecteerde opslaglocatie";
            // 
            // btnLocatieVerwijder
            // 
            this.btnLocatieVerwijder.Location = new System.Drawing.Point(121, 273);
            this.btnLocatieVerwijder.Name = "btnLocatieVerwijder";
            this.btnLocatieVerwijder.Size = new System.Drawing.Size(108, 30);
            this.btnLocatieVerwijder.TabIndex = 4;
            this.btnLocatieVerwijder.Text = "Verwijder";
            this.btnLocatieVerwijder.UseVisualStyleBackColor = true;
            this.btnLocatieVerwijder.Click += new System.EventHandler(this.btnLocatieVerwijder_Click);
            // 
            // lbLocaties
            // 
            this.lbLocaties.FormattingEnabled = true;
            this.lbLocaties.ItemHeight = 16;
            this.lbLocaties.Location = new System.Drawing.Point(6, 38);
            this.lbLocaties.Name = "lbLocaties";
            this.lbLocaties.Size = new System.Drawing.Size(505, 212);
            this.lbLocaties.TabIndex = 0;
            // 
            // FormInstellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.gbLocaties);
            this.Controls.Add(this.gbNamenUitgaand);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInstellingen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MailSAVer: Instellingen";
            this.Load += new System.EventHandler(this.FormInstellingen_Load);
            this.gbNamenUitgaand.ResumeLayout(false);
            this.gbNamenUitgaand.PerformLayout();
            this.gbLocaties.ResumeLayout(false);
            this.gbLocaties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNamen;
        private System.Windows.Forms.Label lblNamenLijst;
        private System.Windows.Forms.Label lblNaamVerwijderen;
        private System.Windows.Forms.Button btnNaamVerwijder;
        private System.Windows.Forms.Label lblNaamToevoegen;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Button btnNaamToevoegen;
        private System.Windows.Forms.GroupBox gbNamenUitgaand;
        private System.Windows.Forms.GroupBox gbLocaties;
        private System.Windows.Forms.Label lblLocatieVerwijderen;
        private System.Windows.Forms.Button btnLocatieVerwijder;
        private System.Windows.Forms.ListBox lbLocaties;
        private System.Windows.Forms.Button btnFolderBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLocatieZetStandaard;
        private System.Windows.Forms.Button btnLocatieZetAnders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLocatiesLijst;
        private System.Windows.Forms.Label lblAflopendeLocatie;
        private System.Windows.Forms.Button btnZetOplopend;
        private System.Windows.Forms.Label lblOplopend;
        private System.Windows.Forms.Button btnZetAflopend;
    }
}