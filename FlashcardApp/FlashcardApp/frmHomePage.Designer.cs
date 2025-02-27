﻿namespace FlashcardApp
{
    partial class frmHomePage
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblHomePageWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHomePageTakeQuiz = new System.Windows.Forms.Button();
            this.btnHomePageQuizResults = new System.Windows.Forms.Button();
            this.btnHomePageToFlashcards = new System.Windows.Forms.Button();
            this.btnHomePageExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHomePageFlashcardsCreated = new System.Windows.Forms.Label();
            this.lblHomePageQuizzesTaken = new System.Windows.Forms.Label();
            this.btnHomePageClearAllData = new System.Windows.Forms.Button();
            this.txtHomePageCategory = new System.Windows.Forms.TextBox();
            this.lblHomePageCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblHomePageWelcome
            // 
            this.lblHomePageWelcome.AutoSize = true;
            this.lblHomePageWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePageWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblHomePageWelcome.Location = new System.Drawing.Point(22, 40);
            this.lblHomePageWelcome.Name = "lblHomePageWelcome";
            this.lblHomePageWelcome.Size = new System.Drawing.Size(198, 44);
            this.lblHomePageWelcome.TabIndex = 3;
            this.lblHomePageWelcome.Text = "Welcome!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Take a Practice Quiz: ";
            // 
            // btnHomePageTakeQuiz
            // 
            this.btnHomePageTakeQuiz.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHomePageTakeQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePageTakeQuiz.Location = new System.Drawing.Point(662, 142);
            this.btnHomePageTakeQuiz.Name = "btnHomePageTakeQuiz";
            this.btnHomePageTakeQuiz.Size = new System.Drawing.Size(146, 47);
            this.btnHomePageTakeQuiz.TabIndex = 5;
            this.btnHomePageTakeQuiz.Text = "Take Quiz";
            this.btnHomePageTakeQuiz.UseVisualStyleBackColor = false;
            this.btnHomePageTakeQuiz.Click += new System.EventHandler(this.btnHomePageTakeQuiz_Click);
            // 
            // btnHomePageQuizResults
            // 
            this.btnHomePageQuizResults.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHomePageQuizResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePageQuizResults.Location = new System.Drawing.Point(30, 327);
            this.btnHomePageQuizResults.Name = "btnHomePageQuizResults";
            this.btnHomePageQuizResults.Size = new System.Drawing.Size(212, 47);
            this.btnHomePageQuizResults.TabIndex = 6;
            this.btnHomePageQuizResults.Text = "Quiz Results";
            this.btnHomePageQuizResults.UseVisualStyleBackColor = false;
            this.btnHomePageQuizResults.Click += new System.EventHandler(this.btnHomePageQuizResults_Click);
            // 
            // btnHomePageToFlashcards
            // 
            this.btnHomePageToFlashcards.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHomePageToFlashcards.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePageToFlashcards.Location = new System.Drawing.Point(30, 243);
            this.btnHomePageToFlashcards.Name = "btnHomePageToFlashcards";
            this.btnHomePageToFlashcards.Size = new System.Drawing.Size(212, 47);
            this.btnHomePageToFlashcards.TabIndex = 7;
            this.btnHomePageToFlashcards.Text = "To Flashcards";
            this.btnHomePageToFlashcards.UseVisualStyleBackColor = false;
            this.btnHomePageToFlashcards.Click += new System.EventHandler(this.btnHomePageToFlashcards_Click);
            // 
            // btnHomePageExit
            // 
            this.btnHomePageExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnHomePageExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePageExit.Location = new System.Drawing.Point(12, 436);
            this.btnHomePageExit.Name = "btnHomePageExit";
            this.btnHomePageExit.Size = new System.Drawing.Size(85, 33);
            this.btnHomePageExit.TabIndex = 8;
            this.btnHomePageExit.Text = "Exit";
            this.btnHomePageExit.UseVisualStyleBackColor = false;
            this.btnHomePageExit.Click += new System.EventHandler(this.btnHomePageExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(280, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Flashcards Created:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(280, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Quizzes Taken:";
            // 
            // lblHomePageFlashcardsCreated
            // 
            this.lblHomePageFlashcardsCreated.AutoSize = true;
            this.lblHomePageFlashcardsCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePageFlashcardsCreated.ForeColor = System.Drawing.Color.Black;
            this.lblHomePageFlashcardsCreated.Location = new System.Drawing.Point(654, 243);
            this.lblHomePageFlashcardsCreated.Name = "lblHomePageFlashcardsCreated";
            this.lblHomePageFlashcardsCreated.Size = new System.Drawing.Size(85, 44);
            this.lblHomePageFlashcardsCreated.TabIndex = 11;
            this.lblHomePageFlashcardsCreated.Text = "N/A";
            this.lblHomePageFlashcardsCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHomePageFlashcardsCreated.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblHomePageQuizzesTaken
            // 
            this.lblHomePageQuizzesTaken.AutoSize = true;
            this.lblHomePageQuizzesTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePageQuizzesTaken.ForeColor = System.Drawing.Color.Black;
            this.lblHomePageQuizzesTaken.Location = new System.Drawing.Point(654, 330);
            this.lblHomePageQuizzesTaken.Name = "lblHomePageQuizzesTaken";
            this.lblHomePageQuizzesTaken.Size = new System.Drawing.Size(85, 44);
            this.lblHomePageQuizzesTaken.TabIndex = 12;
            this.lblHomePageQuizzesTaken.Text = "N/A";
            this.lblHomePageQuizzesTaken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHomePageClearAllData
            // 
            this.btnHomePageClearAllData.BackColor = System.Drawing.Color.Tomato;
            this.btnHomePageClearAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePageClearAllData.Location = new System.Drawing.Point(641, 436);
            this.btnHomePageClearAllData.Name = "btnHomePageClearAllData";
            this.btnHomePageClearAllData.Size = new System.Drawing.Size(167, 33);
            this.btnHomePageClearAllData.TabIndex = 13;
            this.btnHomePageClearAllData.Text = "Clear All Data";
            this.btnHomePageClearAllData.UseVisualStyleBackColor = false;
            this.btnHomePageClearAllData.Click += new System.EventHandler(this.btnHomePageClearAllData_Click);
            // 
            // txtHomePageCategory
            // 
            this.txtHomePageCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHomePageCategory.Location = new System.Drawing.Point(377, 150);
            this.txtHomePageCategory.Name = "txtHomePageCategory";
            this.txtHomePageCategory.Size = new System.Drawing.Size(258, 29);
            this.txtHomePageCategory.TabIndex = 21;
            this.txtHomePageCategory.Text = "none";
            // 
            // lblHomePageCategory
            // 
            this.lblHomePageCategory.AutoSize = true;
            this.lblHomePageCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePageCategory.ForeColor = System.Drawing.Color.Black;
            this.lblHomePageCategory.Location = new System.Drawing.Point(281, 155);
            this.lblHomePageCategory.Name = "lblHomePageCategory";
            this.lblHomePageCategory.Size = new System.Drawing.Size(90, 24);
            this.lblHomePageCategory.TabIndex = 20;
            this.lblHomePageCategory.Text = "Category:";
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(834, 481);
            this.Controls.Add(this.txtHomePageCategory);
            this.Controls.Add(this.lblHomePageCategory);
            this.Controls.Add(this.btnHomePageClearAllData);
            this.Controls.Add(this.lblHomePageQuizzesTaken);
            this.Controls.Add(this.lblHomePageFlashcardsCreated);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHomePageExit);
            this.Controls.Add(this.btnHomePageToFlashcards);
            this.Controls.Add(this.btnHomePageQuizResults);
            this.Controls.Add(this.btnHomePageTakeQuiz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHomePageWelcome);
            this.Name = "frmHomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.frmHomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblHomePageWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHomePageTakeQuiz;
        private System.Windows.Forms.Button btnHomePageQuizResults;
        private System.Windows.Forms.Button btnHomePageToFlashcards;
        private System.Windows.Forms.Button btnHomePageExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHomePageFlashcardsCreated;
        private System.Windows.Forms.Label lblHomePageQuizzesTaken;
        private System.Windows.Forms.Button btnHomePageClearAllData;
        private System.Windows.Forms.TextBox txtHomePageCategory;
        private System.Windows.Forms.Label lblHomePageCategory;
    }
}

