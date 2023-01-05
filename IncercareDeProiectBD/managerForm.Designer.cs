namespace IncercareDeProiectBD
{
    partial class managerForm
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
            this.titluManager = new System.Windows.Forms.Label();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titluManager
            // 
            this.titluManager.AutoSize = true;
            this.titluManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titluManager.Location = new System.Drawing.Point(127, 9);
            this.titluManager.Name = "titluManager";
            this.titluManager.Size = new System.Drawing.Size(567, 25);
            this.titluManager.TabIndex = 0;
            this.titluManager.Text = "Accesul persoanelor neautorizate este strict interzis!";
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.AccessibleDescription = "buttonCloseApp";
            this.buttonCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseApp.Location = new System.Drawing.Point(343, 392);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(118, 46);
            this.buttonCloseApp.TabIndex = 1;
            this.buttonCloseApp.Text = "Inchide Aplicatia";
            this.buttonCloseApp.UseVisualStyleBackColor = true;
            this.buttonCloseApp.Click += new System.EventHandler(this.button1_Click);
            // 
            // managerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCloseApp);
            this.Controls.Add(this.titluManager);
            this.Name = "managerForm";
            this.Text = "managerForm";
            this.Load += new System.EventHandler(this.managerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titluManager;
        private System.Windows.Forms.Button buttonCloseApp;
    }
}