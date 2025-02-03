namespace FlashcardApp
{
    partial class frmFlashcards
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
            this.btnFlashcardsToHome = new System.Windows.Forms.Button();
            this.btnFlashcardsEdit = new System.Windows.Forms.Button();
            this.btnFlashcardsCreate = new System.Windows.Forms.Button();
            this.txtFlashcardsFlashcardID = new System.Windows.Forms.TextBox();
            this.txtFlashcardsEnterValidID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFlashcardsToHome
            // 
            this.btnFlashcardsToHome.BackColor = System.Drawing.Color.LightCoral;
            this.btnFlashcardsToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlashcardsToHome.Location = new System.Drawing.Point(12, 508);
            this.btnFlashcardsToHome.Name = "btnFlashcardsToHome";
            this.btnFlashcardsToHome.Size = new System.Drawing.Size(126, 41);
            this.btnFlashcardsToHome.TabIndex = 9;
            this.btnFlashcardsToHome.Text = "To Home";
            this.btnFlashcardsToHome.UseVisualStyleBackColor = false;
            this.btnFlashcardsToHome.Click += new System.EventHandler(this.btnFlashcardsToHome_Click);
            // 
            // btnFlashcardsEdit
            // 
            this.btnFlashcardsEdit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnFlashcardsEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlashcardsEdit.Location = new System.Drawing.Point(780, 508);
            this.btnFlashcardsEdit.Name = "btnFlashcardsEdit";
            this.btnFlashcardsEdit.Size = new System.Drawing.Size(142, 41);
            this.btnFlashcardsEdit.TabIndex = 10;
            this.btnFlashcardsEdit.Text = "Edit";
            this.btnFlashcardsEdit.UseVisualStyleBackColor = false;
            this.btnFlashcardsEdit.Click += new System.EventHandler(this.btnFlashcardsEdit_Click);
            // 
            // btnFlashcardsCreate
            // 
            this.btnFlashcardsCreate.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnFlashcardsCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlashcardsCreate.Location = new System.Drawing.Point(662, 22);
            this.btnFlashcardsCreate.Name = "btnFlashcardsCreate";
            this.btnFlashcardsCreate.Size = new System.Drawing.Size(217, 41);
            this.btnFlashcardsCreate.TabIndex = 11;
            this.btnFlashcardsCreate.Text = "Create a Flashcard";
            this.btnFlashcardsCreate.UseVisualStyleBackColor = false;
            this.btnFlashcardsCreate.Click += new System.EventHandler(this.btnFlashcardsCreate_Click);
            // 
            // txtFlashcardsFlashcardID
            // 
            this.txtFlashcardsFlashcardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlashcardsFlashcardID.Location = new System.Drawing.Point(676, 513);
            this.txtFlashcardsFlashcardID.Name = "txtFlashcardsFlashcardID";
            this.txtFlashcardsFlashcardID.Size = new System.Drawing.Size(78, 29);
            this.txtFlashcardsFlashcardID.TabIndex = 12;
            this.txtFlashcardsFlashcardID.Text = "none";
            this.txtFlashcardsFlashcardID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFlashcardsFlashcardID.TextChanged += new System.EventHandler(this.txtFlashcardsFlashcardID_TextChanged);
            // 
            // txtFlashcardsEnterValidID
            // 
            this.txtFlashcardsEnterValidID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlashcardsEnterValidID.Location = new System.Drawing.Point(530, 513);
            this.txtFlashcardsEnterValidID.Name = "txtFlashcardsEnterValidID";
            this.txtFlashcardsEnterValidID.Size = new System.Drawing.Size(149, 29);
            this.txtFlashcardsEnterValidID.TabIndex = 13;
            this.txtFlashcardsEnterValidID.Text = "Enter Valid ID:";
            this.txtFlashcardsEnterValidID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmFlashcards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.txtFlashcardsEnterValidID);
            this.Controls.Add(this.txtFlashcardsFlashcardID);
            this.Controls.Add(this.btnFlashcardsCreate);
            this.Controls.Add(this.btnFlashcardsEdit);
            this.Controls.Add(this.btnFlashcardsToHome);
            this.Name = "frmFlashcards";
            this.Text = "Flashcards";
            this.Load += new System.EventHandler(this.frmFlashcards_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlashcardsToHome;
        private System.Windows.Forms.Button btnFlashcardsEdit;
        private System.Windows.Forms.Button btnFlashcardsCreate;
        private System.Windows.Forms.TextBox txtFlashcardsFlashcardID;
        private System.Windows.Forms.TextBox txtFlashcardsEnterValidID;
    }
}