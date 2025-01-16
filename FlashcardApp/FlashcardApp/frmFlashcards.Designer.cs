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
            this.btnFlashcardsExit = new System.Windows.Forms.Button();
            this.btnFlashcardsEdit = new System.Windows.Forms.Button();
            this.btnFlashcardsCreate = new System.Windows.Forms.Button();
            this.txtFlashcardsFlashcardID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFlashcardsExit
            // 
            this.btnFlashcardsExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnFlashcardsExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlashcardsExit.Location = new System.Drawing.Point(12, 508);
            this.btnFlashcardsExit.Name = "btnFlashcardsExit";
            this.btnFlashcardsExit.Size = new System.Drawing.Size(126, 41);
            this.btnFlashcardsExit.TabIndex = 9;
            this.btnFlashcardsExit.Text = "Exit";
            this.btnFlashcardsExit.UseVisualStyleBackColor = false;
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
            // 
            // txtFlashcardsFlashcardID
            // 
            this.txtFlashcardsFlashcardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlashcardsFlashcardID.Location = new System.Drawing.Point(607, 513);
            this.txtFlashcardsFlashcardID.Name = "txtFlashcardsFlashcardID";
            this.txtFlashcardsFlashcardID.Size = new System.Drawing.Size(100, 29);
            this.txtFlashcardsFlashcardID.TabIndex = 12;
            this.txtFlashcardsFlashcardID.Text = "none";
            this.txtFlashcardsFlashcardID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmFlashcards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.txtFlashcardsFlashcardID);
            this.Controls.Add(this.btnFlashcardsCreate);
            this.Controls.Add(this.btnFlashcardsEdit);
            this.Controls.Add(this.btnFlashcardsExit);
            this.Name = "frmFlashcards";
            this.Text = "Flashcards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlashcardsExit;
        private System.Windows.Forms.Button btnFlashcardsEdit;
        private System.Windows.Forms.Button btnFlashcardsCreate;
        private System.Windows.Forms.TextBox txtFlashcardsFlashcardID;
    }
}