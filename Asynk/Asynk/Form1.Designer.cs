namespace Asynk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOnePage = new System.Windows.Forms.Button();
            this.btnManyPages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOnePage
            // 
            this.btnOnePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOnePage.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnePage.Location = new System.Drawing.Point(128, 269);
            this.btnOnePage.Name = "btnOnePage";
            this.btnOnePage.Size = new System.Drawing.Size(431, 144);
            this.btnOnePage.TabIndex = 0;
            this.btnOnePage.Text = "Load One Page";
            this.btnOnePage.UseVisualStyleBackColor = false;
            this.btnOnePage.Click += new System.EventHandler(this.btnOnePage_Click);
            // 
            // btnManyPages
            // 
            this.btnManyPages.BackColor = System.Drawing.Color.Red;
            this.btnManyPages.Font = new System.Drawing.Font("Consolas", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManyPages.Location = new System.Drawing.Point(128, 429);
            this.btnManyPages.Name = "btnManyPages";
            this.btnManyPages.Size = new System.Drawing.Size(431, 136);
            this.btnManyPages.TabIndex = 1;
            this.btnManyPages.Text = "Load Many Pages";
            this.btnManyPages.UseVisualStyleBackColor = false;
            this.btnManyPages.Click += new System.EventHandler(this.btnManyPages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(708, 773);
            this.Controls.Add(this.btnManyPages);
            this.Controls.Add(this.btnOnePage);
            this.Name = "Form1";
            this.Text = "Hejhej";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOnePage;
        private System.Windows.Forms.Button btnManyPages;
    }
}

