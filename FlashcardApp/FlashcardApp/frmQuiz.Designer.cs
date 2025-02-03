namespace FlashcardApp
{
    partial class frmQuiz
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
            this.btnQuizSubmit = new System.Windows.Forms.Button();
            this.btnQuizCancel = new System.Windows.Forms.Button();
            this.lblQuizCategoryName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuizSubmit
            // 
            this.btnQuizSubmit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnQuizSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizSubmit.Location = new System.Drawing.Point(771, 508);
            this.btnQuizSubmit.Name = "btnQuizSubmit";
            this.btnQuizSubmit.Size = new System.Drawing.Size(142, 41);
            this.btnQuizSubmit.TabIndex = 11;
            this.btnQuizSubmit.Text = "Submit";
            this.btnQuizSubmit.UseVisualStyleBackColor = false;
            this.btnQuizSubmit.Click += new System.EventHandler(this.btnQuizSubmit_Click);
            // 
            // btnQuizCancel
            // 
            this.btnQuizCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnQuizCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizCancel.Location = new System.Drawing.Point(25, 508);
            this.btnQuizCancel.Name = "btnQuizCancel";
            this.btnQuizCancel.Size = new System.Drawing.Size(126, 41);
            this.btnQuizCancel.TabIndex = 12;
            this.btnQuizCancel.Text = "Cancel";
            this.btnQuizCancel.UseVisualStyleBackColor = false;
            this.btnQuizCancel.Click += new System.EventHandler(this.btnQuizCancel_Click);
            // 
            // lblQuizCategoryName
            // 
            this.lblQuizCategoryName.AutoSize = true;
            this.lblQuizCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizCategoryName.ForeColor = System.Drawing.Color.Black;
            this.lblQuizCategoryName.Location = new System.Drawing.Point(18, 19);
            this.lblQuizCategoryName.Name = "lblQuizCategoryName";
            this.lblQuizCategoryName.Size = new System.Drawing.Size(232, 37);
            this.lblQuizCategoryName.TabIndex = 14;
            this.lblQuizCategoryName.Text = "CategoryName";
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.lblQuizCategoryName);
            this.Controls.Add(this.btnQuizCancel);
            this.Controls.Add(this.btnQuizSubmit);
            this.Name = "frmQuiz";
            this.Text = "Practice Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuizSubmit;
        private System.Windows.Forms.Button btnQuizCancel;
        private System.Windows.Forms.Label lblQuizCategoryName;
    }
}