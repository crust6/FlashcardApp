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
            this.btnFlashcardsView = new System.Windows.Forms.Button();
            this.txtFlashcardsEnterValidCategory = new System.Windows.Forms.TextBox();
            this.txtFlashcardsCategory = new System.Windows.Forms.TextBox();
            this.btnFlashcardsFilter = new System.Windows.Forms.Button();
            this.btnFlashcardsFlashcard = new System.Windows.Forms.Button();
            this.lblFlashcardsPromptAnswerTxt = new System.Windows.Forms.Label();
            this.lblFlashcardsID = new System.Windows.Forms.Label();
            this.lblFlashcardsCategory = new System.Windows.Forms.Label();
            this.lblFlashcardsPromptAnswer = new System.Windows.Forms.Label();
            this.btnFlashcardsBack = new System.Windows.Forms.Button();
            this.btnFlashcardsNext = new System.Windows.Forms.Button();
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
            this.btnFlashcardsCreate.Location = new System.Drawing.Point(692, 29);
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
            this.txtFlashcardsFlashcardID.Location = new System.Drawing.Point(512, 513);
            this.txtFlashcardsFlashcardID.Name = "txtFlashcardsFlashcardID";
            this.txtFlashcardsFlashcardID.Size = new System.Drawing.Size(78, 29);
            this.txtFlashcardsFlashcardID.TabIndex = 12;
            this.txtFlashcardsFlashcardID.Text = "none";
            this.txtFlashcardsFlashcardID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFlashcardsFlashcardID.TextChanged += new System.EventHandler(this.txtFlashcardsFlashcardID_TextChanged);
            // 
            // txtFlashcardsEnterValidID
            // 
            this.txtFlashcardsEnterValidID.Enabled = false;
            this.txtFlashcardsEnterValidID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlashcardsEnterValidID.Location = new System.Drawing.Point(366, 513);
            this.txtFlashcardsEnterValidID.Name = "txtFlashcardsEnterValidID";
            this.txtFlashcardsEnterValidID.Size = new System.Drawing.Size(149, 29);
            this.txtFlashcardsEnterValidID.TabIndex = 13;
            this.txtFlashcardsEnterValidID.Text = "Enter Valid ID:";
            this.txtFlashcardsEnterValidID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFlashcardsEnterValidID.TextChanged += new System.EventHandler(this.txtFlashcardsEnterValidID_TextChanged);
            // 
            // btnFlashcardsView
            // 
            this.btnFlashcardsView.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnFlashcardsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlashcardsView.Location = new System.Drawing.Point(614, 508);
            this.btnFlashcardsView.Name = "btnFlashcardsView";
            this.btnFlashcardsView.Size = new System.Drawing.Size(142, 41);
            this.btnFlashcardsView.TabIndex = 14;
            this.btnFlashcardsView.Text = "View Card";
            this.btnFlashcardsView.UseVisualStyleBackColor = false;
            this.btnFlashcardsView.Click += new System.EventHandler(this.btnFlashcardsView_Click);
            // 
            // txtFlashcardsEnterValidCategory
            // 
            this.txtFlashcardsEnterValidCategory.Enabled = false;
            this.txtFlashcardsEnterValidCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlashcardsEnterValidCategory.Location = new System.Drawing.Point(692, 214);
            this.txtFlashcardsEnterValidCategory.Name = "txtFlashcardsEnterValidCategory";
            this.txtFlashcardsEnterValidCategory.Size = new System.Drawing.Size(211, 29);
            this.txtFlashcardsEnterValidCategory.TabIndex = 21;
            this.txtFlashcardsEnterValidCategory.Text = "Enter Valid Category:";
            this.txtFlashcardsEnterValidCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFlashcardsCategory
            // 
            this.txtFlashcardsCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlashcardsCategory.Location = new System.Drawing.Point(692, 249);
            this.txtFlashcardsCategory.Name = "txtFlashcardsCategory";
            this.txtFlashcardsCategory.Size = new System.Drawing.Size(211, 29);
            this.txtFlashcardsCategory.TabIndex = 20;
            this.txtFlashcardsCategory.Text = "none";
            this.txtFlashcardsCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFlashcardsFilter
            // 
            this.btnFlashcardsFilter.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnFlashcardsFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlashcardsFilter.Location = new System.Drawing.Point(692, 299);
            this.btnFlashcardsFilter.Name = "btnFlashcardsFilter";
            this.btnFlashcardsFilter.Size = new System.Drawing.Size(95, 34);
            this.btnFlashcardsFilter.TabIndex = 22;
            this.btnFlashcardsFilter.Text = "Filter";
            this.btnFlashcardsFilter.UseVisualStyleBackColor = false;
            // 
            // btnFlashcardsFlashcard
            // 
            this.btnFlashcardsFlashcard.FlatAppearance.BorderSize = 10;
            this.btnFlashcardsFlashcard.Location = new System.Drawing.Point(30, 29);
            this.btnFlashcardsFlashcard.Name = "btnFlashcardsFlashcard";
            this.btnFlashcardsFlashcard.Size = new System.Drawing.Size(627, 425);
            this.btnFlashcardsFlashcard.TabIndex = 23;
            this.btnFlashcardsFlashcard.UseVisualStyleBackColor = true;
            this.btnFlashcardsFlashcard.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFlashcardsPromptAnswerTxt
            // 
            this.lblFlashcardsPromptAnswerTxt.AutoSize = true;
            this.lblFlashcardsPromptAnswerTxt.BackColor = System.Drawing.Color.White;
            this.lblFlashcardsPromptAnswerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlashcardsPromptAnswerTxt.Location = new System.Drawing.Point(104, 238);
            this.lblFlashcardsPromptAnswerTxt.Name = "lblFlashcardsPromptAnswerTxt";
            this.lblFlashcardsPromptAnswerTxt.Size = new System.Drawing.Size(58, 24);
            this.lblFlashcardsPromptAnswerTxt.TabIndex = 24;
            this.lblFlashcardsPromptAnswerTxt.Text = "none";
            // 
            // lblFlashcardsID
            // 
            this.lblFlashcardsID.AutoSize = true;
            this.lblFlashcardsID.BackColor = System.Drawing.Color.White;
            this.lblFlashcardsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlashcardsID.Location = new System.Drawing.Point(592, 50);
            this.lblFlashcardsID.Name = "lblFlashcardsID";
            this.lblFlashcardsID.Size = new System.Drawing.Size(48, 20);
            this.lblFlashcardsID.TabIndex = 25;
            this.lblFlashcardsID.Text = "ID: 0";
            // 
            // lblFlashcardsCategory
            // 
            this.lblFlashcardsCategory.AutoSize = true;
            this.lblFlashcardsCategory.BackColor = System.Drawing.Color.White;
            this.lblFlashcardsCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlashcardsCategory.Location = new System.Drawing.Point(46, 50);
            this.lblFlashcardsCategory.Name = "lblFlashcardsCategory";
            this.lblFlashcardsCategory.Size = new System.Drawing.Size(127, 20);
            this.lblFlashcardsCategory.TabIndex = 26;
            this.lblFlashcardsCategory.Text = "CategoryName";
            // 
            // lblFlashcardsPromptAnswer
            // 
            this.lblFlashcardsPromptAnswer.AutoSize = true;
            this.lblFlashcardsPromptAnswer.BackColor = System.Drawing.Color.White;
            this.lblFlashcardsPromptAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlashcardsPromptAnswer.Location = new System.Drawing.Point(46, 415);
            this.lblFlashcardsPromptAnswer.Name = "lblFlashcardsPromptAnswer";
            this.lblFlashcardsPromptAnswer.Size = new System.Drawing.Size(66, 20);
            this.lblFlashcardsPromptAnswer.TabIndex = 27;
            this.lblFlashcardsPromptAnswer.Text = "Prompt";
            // 
            // btnFlashcardsBack
            // 
            this.btnFlashcardsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlashcardsBack.Location = new System.Drawing.Point(30, 460);
            this.btnFlashcardsBack.Name = "btnFlashcardsBack";
            this.btnFlashcardsBack.Size = new System.Drawing.Size(75, 23);
            this.btnFlashcardsBack.TabIndex = 28;
            this.btnFlashcardsBack.Text = "Back";
            this.btnFlashcardsBack.UseVisualStyleBackColor = true;
            this.btnFlashcardsBack.Click += new System.EventHandler(this.btnFlashcardsBack_Click);
            // 
            // btnFlashcardsNext
            // 
            this.btnFlashcardsNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlashcardsNext.Location = new System.Drawing.Point(582, 460);
            this.btnFlashcardsNext.Name = "btnFlashcardsNext";
            this.btnFlashcardsNext.Size = new System.Drawing.Size(75, 23);
            this.btnFlashcardsNext.TabIndex = 29;
            this.btnFlashcardsNext.Text = "Next";
            this.btnFlashcardsNext.UseVisualStyleBackColor = true;
            this.btnFlashcardsNext.Click += new System.EventHandler(this.btnFlashcardsNext_Click);
            // 
            // frmFlashcards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.btnFlashcardsNext);
            this.Controls.Add(this.btnFlashcardsBack);
            this.Controls.Add(this.lblFlashcardsPromptAnswer);
            this.Controls.Add(this.lblFlashcardsCategory);
            this.Controls.Add(this.lblFlashcardsID);
            this.Controls.Add(this.lblFlashcardsPromptAnswerTxt);
            this.Controls.Add(this.btnFlashcardsFlashcard);
            this.Controls.Add(this.btnFlashcardsFilter);
            this.Controls.Add(this.txtFlashcardsEnterValidCategory);
            this.Controls.Add(this.txtFlashcardsCategory);
            this.Controls.Add(this.btnFlashcardsView);
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
        private System.Windows.Forms.Button btnFlashcardsView;
        private System.Windows.Forms.TextBox txtFlashcardsEnterValidCategory;
        private System.Windows.Forms.TextBox txtFlashcardsCategory;
        private System.Windows.Forms.Button btnFlashcardsFilter;
        private System.Windows.Forms.Button btnFlashcardsFlashcard;
        private System.Windows.Forms.Label lblFlashcardsPromptAnswerTxt;
        private System.Windows.Forms.Label lblFlashcardsID;
        private System.Windows.Forms.Label lblFlashcardsCategory;
        private System.Windows.Forms.Label lblFlashcardsPromptAnswer;
        private System.Windows.Forms.Button btnFlashcardsBack;
        private System.Windows.Forms.Button btnFlashcardsNext;
    }
}