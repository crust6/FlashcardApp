namespace FlashcardApp
{
    partial class frmQuizResults
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
            this.btnQuizResultsToHome = new System.Windows.Forms.Button();
            this.btnQuizResultsCategory = new System.Windows.Forms.Button();
            this.btnQuizResultsMostRecent = new System.Windows.Forms.Button();
            this.btnQuizResultsOldest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuizResultsToHome
            // 
            this.btnQuizResultsToHome.BackColor = System.Drawing.Color.LightCoral;
            this.btnQuizResultsToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizResultsToHome.Location = new System.Drawing.Point(25, 508);
            this.btnQuizResultsToHome.Name = "btnQuizResultsToHome";
            this.btnQuizResultsToHome.Size = new System.Drawing.Size(126, 41);
            this.btnQuizResultsToHome.TabIndex = 10;
            this.btnQuizResultsToHome.Text = "To Home";
            this.btnQuizResultsToHome.UseVisualStyleBackColor = false;
            this.btnQuizResultsToHome.Click += new System.EventHandler(this.btnQuizResultsToHome_Click);
            // 
            // btnQuizResultsCategory
            // 
            this.btnQuizResultsCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizResultsCategory.Location = new System.Drawing.Point(25, 23);
            this.btnQuizResultsCategory.Name = "btnQuizResultsCategory";
            this.btnQuizResultsCategory.Size = new System.Drawing.Size(276, 42);
            this.btnQuizResultsCategory.TabIndex = 11;
            this.btnQuizResultsCategory.Text = "Category";
            this.btnQuizResultsCategory.UseVisualStyleBackColor = true;
            this.btnQuizResultsCategory.Click += new System.EventHandler(this.btnQuizResultsCategory_Click);
            // 
            // btnQuizResultsMostRecent
            // 
            this.btnQuizResultsMostRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizResultsMostRecent.Location = new System.Drawing.Point(325, 23);
            this.btnQuizResultsMostRecent.Name = "btnQuizResultsMostRecent";
            this.btnQuizResultsMostRecent.Size = new System.Drawing.Size(276, 42);
            this.btnQuizResultsMostRecent.TabIndex = 12;
            this.btnQuizResultsMostRecent.Text = "Most Recent";
            this.btnQuizResultsMostRecent.UseVisualStyleBackColor = true;
            this.btnQuizResultsMostRecent.Click += new System.EventHandler(this.btnQuizResultsMostRecent_Click);
            // 
            // btnQuizResultsOldest
            // 
            this.btnQuizResultsOldest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizResultsOldest.Location = new System.Drawing.Point(630, 23);
            this.btnQuizResultsOldest.Name = "btnQuizResultsOldest";
            this.btnQuizResultsOldest.Size = new System.Drawing.Size(276, 42);
            this.btnQuizResultsOldest.TabIndex = 13;
            this.btnQuizResultsOldest.Text = "Oldest";
            this.btnQuizResultsOldest.UseVisualStyleBackColor = true;
            this.btnQuizResultsOldest.Click += new System.EventHandler(this.btnQuizResultsOldest_Click);
            // 
            // frmQuizResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.btnQuizResultsOldest);
            this.Controls.Add(this.btnQuizResultsMostRecent);
            this.Controls.Add(this.btnQuizResultsCategory);
            this.Controls.Add(this.btnQuizResultsToHome);
            this.Name = "frmQuizResults";
            this.Text = "Quiz Results";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuizResultsToHome;
        private System.Windows.Forms.Button btnQuizResultsCategory;
        private System.Windows.Forms.Button btnQuizResultsMostRecent;
        private System.Windows.Forms.Button btnQuizResultsOldest;
    }
}