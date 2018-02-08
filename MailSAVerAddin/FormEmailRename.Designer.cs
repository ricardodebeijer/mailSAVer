namespace MailSAVerAddin
{
    partial class FormEmailRename
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmailRename));
            this.lblMelding = new System.Windows.Forms.Label();
            this.tbEmailNaam = new System.Windows.Forms.TextBox();
            this.lblExtensie = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkLabelDirectory = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblMelding
            // 
            this.lblMelding.AutoSize = true;
            this.lblMelding.Location = new System.Drawing.Point(12, 9);
            this.lblMelding.Name = "lblMelding";
            this.lblMelding.Size = new System.Drawing.Size(57, 17);
            this.lblMelding.TabIndex = 1;
            this.lblMelding.Text = "Melding";
            // 
            // tbEmailNaam
            // 
            this.tbEmailNaam.Location = new System.Drawing.Point(12, 66);
            this.tbEmailNaam.Name = "tbEmailNaam";
            this.tbEmailNaam.Size = new System.Drawing.Size(414, 22);
            this.tbEmailNaam.TabIndex = 0;
            // 
            // lblExtensie
            // 
            this.lblExtensie.AutoSize = true;
            this.lblExtensie.Location = new System.Drawing.Point(432, 69);
            this.lblExtensie.Name = "lblExtensie";
            this.lblExtensie.Size = new System.Drawing.Size(30, 17);
            this.lblExtensie.TabIndex = 3;
            this.lblExtensie.Text = ".ext";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(370, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Sla Op";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // linkLabelDirectory
            // 
            this.linkLabelDirectory.ActiveLinkColor = System.Drawing.Color.DarkOrchid;
            this.linkLabelDirectory.AutoSize = true;
            this.linkLabelDirectory.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelDirectory.Location = new System.Drawing.Point(12, 37);
            this.linkLabelDirectory.Name = "linkLabelDirectory";
            this.linkLabelDirectory.Size = new System.Drawing.Size(65, 17);
            this.linkLabelDirectory.TabIndex = 8;
            this.linkLabelDirectory.TabStop = true;
            this.linkLabelDirectory.Text = "Directory";
            this.linkLabelDirectory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDirectory_LinkClicked);
            // 
            // FormEmailRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 183);
            this.Controls.Add(this.linkLabelDirectory);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblExtensie);
            this.Controls.Add(this.tbEmailNaam);
            this.Controls.Add(this.lblMelding);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmailRename";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MailSAVer: Email aanpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMelding;
        private System.Windows.Forms.TextBox tbEmailNaam;
        private System.Windows.Forms.Label lblExtensie;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel linkLabelDirectory;
    }
}