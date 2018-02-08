namespace MailSAVerAddin
{
    partial class FormProjectKiezen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjectKiezen));
            this.lbProjecten = new System.Windows.Forms.ListBox();
            this.btnKies = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMelding = new System.Windows.Forms.Label();
            this.cbLocaties = new System.Windows.Forms.ComboBox();
            this.tbZoekbalk = new System.Windows.Forms.TextBox();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.spContainerTop = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.Panel2.SuspendLayout();
            this.spContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainerTop)).BeginInit();
            this.spContainerTop.Panel1.SuspendLayout();
            this.spContainerTop.Panel2.SuspendLayout();
            this.spContainerTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProjecten
            // 
            this.lbProjecten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbProjecten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProjecten.FormattingEnabled = true;
            this.lbProjecten.ItemHeight = 20;
            this.lbProjecten.Location = new System.Drawing.Point(0, 0);
            this.lbProjecten.Name = "lbProjecten";
            this.lbProjecten.Size = new System.Drawing.Size(682, 654);
            this.lbProjecten.TabIndex = 0;
            // 
            // btnKies
            // 
            this.btnKies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKies.Location = new System.Drawing.Point(570, 11);
            this.btnKies.Name = "btnKies";
            this.btnKies.Size = new System.Drawing.Size(100, 30);
            this.btnKies.TabIndex = 3;
            this.btnKies.Text = "Kies Folder";
            this.btnKies.UseVisualStyleBackColor = true;
            this.btnKies.Click += new System.EventHandler(this.btnKies_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(12, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMelding
            // 
            this.lblMelding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMelding.AutoSize = true;
            this.lblMelding.Location = new System.Drawing.Point(128, 18);
            this.lblMelding.Name = "lblMelding";
            this.lblMelding.Size = new System.Drawing.Size(57, 17);
            this.lblMelding.TabIndex = 3;
            this.lblMelding.Text = "Melding";
            // 
            // cbLocaties
            // 
            this.cbLocaties.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbLocaties.FormattingEnabled = true;
            this.cbLocaties.Location = new System.Drawing.Point(0, 18);
            this.cbLocaties.Name = "cbLocaties";
            this.cbLocaties.Size = new System.Drawing.Size(682, 24);
            this.cbLocaties.TabIndex = 1;
            this.cbLocaties.SelectedIndexChanged += new System.EventHandler(this.cbLocaties_SelectedIndexChanged);
            // 
            // tbZoekbalk
            // 
            this.tbZoekbalk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbZoekbalk.Location = new System.Drawing.Point(223, 15);
            this.tbZoekbalk.Name = "tbZoekbalk";
            this.tbZoekbalk.Size = new System.Drawing.Size(250, 22);
            this.tbZoekbalk.TabIndex = 2;
            this.tbZoekbalk.Text = "zoeken...";
            this.tbZoekbalk.TextChanged += new System.EventHandler(this.tbZoekbalk_TextChanged);
            // 
            // spContainer
            // 
            this.spContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainer.Location = new System.Drawing.Point(0, 0);
            this.spContainer.Name = "spContainer";
            this.spContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.spContainerTop);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.Controls.Add(this.btnCancel);
            this.spContainer.Panel2.Controls.Add(this.btnKies);
            this.spContainer.Panel2.Controls.Add(this.tbZoekbalk);
            this.spContainer.Panel2.Controls.Add(this.lblMelding);
            this.spContainer.Size = new System.Drawing.Size(682, 753);
            this.spContainer.SplitterDistance = 700;
            this.spContainer.TabIndex = 5;
            // 
            // spContainerTop
            // 
            this.spContainerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainerTop.Location = new System.Drawing.Point(0, 0);
            this.spContainerTop.Name = "spContainerTop";
            this.spContainerTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spContainerTop.Panel1
            // 
            this.spContainerTop.Panel1.Controls.Add(this.cbLocaties);
            // 
            // spContainerTop.Panel2
            // 
            this.spContainerTop.Panel2.Controls.Add(this.lbProjecten);
            this.spContainerTop.Size = new System.Drawing.Size(682, 700);
            this.spContainerTop.SplitterDistance = 42;
            this.spContainerTop.TabIndex = 2;
            // 
            // FormProjectKiezen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 753);
            this.Controls.Add(this.spContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 600);
            this.Name = "FormProjectKiezen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MailSAVer: Folder Kiezen";
            this.Resize += new System.EventHandler(this.FormProjectKiezen_Resize);
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel2.ResumeLayout(false);
            this.spContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.spContainerTop.Panel1.ResumeLayout(false);
            this.spContainerTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainerTop)).EndInit();
            this.spContainerTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbProjecten;
        private System.Windows.Forms.Button btnKies;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMelding;
        private System.Windows.Forms.ComboBox cbLocaties;
        private System.Windows.Forms.TextBox tbZoekbalk;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.SplitContainer spContainerTop;
    }
}