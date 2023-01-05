namespace IncercareDeProiectBD
{
    partial class clientForm
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
            this.titluClient = new System.Windows.Forms.Label();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.buttonVerificare = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titluClient
            // 
            this.titluClient.AutoSize = true;
            this.titluClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titluClient.Location = new System.Drawing.Point(213, 9);
            this.titluClient.Name = "titluClient";
            this.titluClient.Size = new System.Drawing.Size(388, 25);
            this.titluClient.TabIndex = 0;
            this.titluClient.Text = "Bine ai venit! Cu ce te putem ajuta?";
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.AccessibleDescription = "buttonCloseApp";
            this.buttonCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseApp.Location = new System.Drawing.Point(349, 392);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(118, 46);
            this.buttonCloseApp.TabIndex = 2;
            this.buttonCloseApp.Text = "Inchide Aplicatia";
            this.buttonCloseApp.UseVisualStyleBackColor = true;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            // 
            // buttonVerificare
            // 
            this.buttonVerificare.AccessibleDescription = "buttonVerificare";
            this.buttonVerificare.Location = new System.Drawing.Point(119, 159);
            this.buttonVerificare.Name = "buttonVerificare";
            this.buttonVerificare.Size = new System.Drawing.Size(106, 23);
            this.buttonVerificare.TabIndex = 3;
            this.buttonVerificare.Text = "Verifica o comanda";
            this.buttonVerificare.UseVisualStyleBackColor = true;
            this.buttonVerificare.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Lanseaza o comanda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(593, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Anuleaza o comanda";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonVerificare);
            this.Controls.Add(this.buttonCloseApp);
            this.Controls.Add(this.titluClient);
            this.Name = "clientForm";
            this.Text = "clientForm";
            this.Load += new System.EventHandler(this.clientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titluClient;
        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.Button buttonVerificare;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}