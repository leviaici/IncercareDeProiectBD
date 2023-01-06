namespace IncercareDeProiectBD
{
    partial class Form1
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
            this.titlu = new System.Windows.Forms.Label();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlu
            // 
            this.titlu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlu.AutoSize = true;
            this.titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.Location = new System.Drawing.Point(244, 150);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(414, 37);
            this.titlu.TabIndex = 0;
            this.titlu.Text = "Baza de date - Restaurant";
            this.titlu.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.AccessibleName = "buttonClient";
            this.buttonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.Location = new System.Drawing.Point(287, 251);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(131, 67);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "Client";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonManager
            // 
            this.buttonManager.AccessibleName = "buttonManager";
            this.buttonManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManager.Location = new System.Drawing.Point(465, 251);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(131, 67);
            this.buttonManager.TabIndex = 2;
            this.buttonManager.Text = "Manager";
            this.buttonManager.UseVisualStyleBackColor = true;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(876, 561);
            this.Controls.Add(this.buttonManager);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.titlu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonManager;
    }
}

