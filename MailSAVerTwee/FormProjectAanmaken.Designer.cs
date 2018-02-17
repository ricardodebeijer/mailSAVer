namespace MailSAVerAddin
{
    partial class FormProjectAanmaken
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjectAanmaken));
            this.lblProjectNummer = new System.Windows.Forms.Label();
            this.lblKlant = new System.Windows.Forms.Label();
            this.tbProjectnummer = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbOmschrijving = new System.Windows.Forms.TextBox();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.lblMelding = new System.Windows.Forms.Label();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.lblLocatieWaarde = new System.Windows.Forms.Label();
            this.tbKlant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProjectNummer
            // 
            this.lblProjectNummer.AutoSize = true;
            this.lblProjectNummer.Location = new System.Drawing.Point(12, 49);
            this.lblProjectNummer.Name = "lblProjectNummer";
            this.lblProjectNummer.Size = new System.Drawing.Size(107, 17);
            this.lblProjectNummer.TabIndex = 10;
            this.lblProjectNummer.Text = "Projectnummer:";
            // 
            // lblKlant
            // 
            this.lblKlant.AutoSize = true;
            this.lblKlant.Location = new System.Drawing.Point(12, 82);
            this.lblKlant.Name = "lblKlant";
            this.lblKlant.Size = new System.Drawing.Size(40, 17);
            this.lblKlant.TabIndex = 11;
            this.lblKlant.Text = "Klant";
            // 
            // tbProjectnummer
            // 
            this.tbProjectnummer.Location = new System.Drawing.Point(267, 46);
            this.tbProjectnummer.MaxLength = 10;
            this.tbProjectnummer.Name = "tbProjectnummer";
            this.tbProjectnummer.Size = new System.Drawing.Size(153, 22);
            this.tbProjectnummer.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(320, 141);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 30);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(15, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbOmschrijving
            // 
            this.tbOmschrijving.Location = new System.Drawing.Point(146, 113);
            this.tbOmschrijving.Name = "tbOmschrijving";
            this.tbOmschrijving.Size = new System.Drawing.Size(274, 22);
            this.tbOmschrijving.TabIndex = 3;
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Location = new System.Drawing.Point(12, 116);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(84, 17);
            this.lblOmschrijving.TabIndex = 12;
            this.lblOmschrijving.Text = "Beschrijving";
            // 
            // lblMelding
            // 
            this.lblMelding.AutoSize = true;
            this.lblMelding.Location = new System.Drawing.Point(143, 148);
            this.lblMelding.Name = "lblMelding";
            this.lblMelding.Size = new System.Drawing.Size(57, 17);
            this.lblMelding.TabIndex = 5;
            this.lblMelding.Text = "Melding";
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.Location = new System.Drawing.Point(12, 13);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(58, 17);
            this.lblLocatie.TabIndex = 13;
            this.lblLocatie.Text = "Locatie:";
            // 
            // lblLocatieWaarde
            // 
            this.lblLocatieWaarde.AutoSize = true;
            this.lblLocatieWaarde.Location = new System.Drawing.Point(76, 13);
            this.lblLocatieWaarde.Name = "lblLocatieWaarde";
            this.lblLocatieWaarde.Size = new System.Drawing.Size(39, 17);
            this.lblLocatieWaarde.TabIndex = 14;
            this.lblLocatieWaarde.Text = "temp";
            // 
            // tbKlant
            // 
            this.tbKlant.Location = new System.Drawing.Point(146, 79);
            this.tbKlant.Name = "tbKlant";
            this.tbKlant.Size = new System.Drawing.Size(274, 22);
            this.tbKlant.TabIndex = 15;
            // 
            // FormProjectAanmaken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 183);
            this.Controls.Add(this.tbKlant);
            this.Controls.Add(this.lblLocatieWaarde);
            this.Controls.Add(this.lblLocatie);
            this.Controls.Add(this.lblMelding);
            this.Controls.Add(this.lblOmschrijving);
            this.Controls.Add(this.tbOmschrijving);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbProjectnummer);
            this.Controls.Add(this.lblKlant);
            this.Controls.Add(this.lblProjectNummer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProjectAanmaken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MailSAVer: Project Aanmaken";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectNummer;
        private System.Windows.Forms.Label lblKlant;
        private System.Windows.Forms.TextBox tbProjectnummer;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbOmschrijving;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.Label lblMelding;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.Label lblLocatieWaarde;
        private System.Windows.Forms.TextBox tbKlant;
    }
}