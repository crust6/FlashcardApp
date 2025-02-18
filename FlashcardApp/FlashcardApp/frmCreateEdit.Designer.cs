namespace FlashcardApp
{
    partial class frmCreateEdit
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
            this.btnCreateEditCancel = new System.Windows.Forms.Button();
            this.btnCreateEditDelete = new System.Windows.Forms.Button();
            this.btnCreateEditSave = new System.Windows.Forms.Button();
            this.lblCreateEditPrompt = new System.Windows.Forms.Label();
            this.lblCreateEditAnswer = new System.Windows.Forms.Label();
            this.txtCreateEditPrompt = new System.Windows.Forms.TextBox();
            this.txtCreateEditAnswer = new System.Windows.Forms.TextBox();
            this.lblCreateEditID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateEditCancel
            // 
            this.btnCreateEditCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCreateEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEditCancel.Location = new System.Drawing.Point(22, 768);
            this.btnCreateEditCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCreateEditCancel.Name = "btnCreateEditCancel";
            this.btnCreateEditCancel.Size = new System.Drawing.Size(213, 61);
            this.btnCreateEditCancel.TabIndex = 10;
            this.btnCreateEditCancel.Text = "Cancel";
            this.btnCreateEditCancel.UseVisualStyleBackColor = false;
            this.btnCreateEditCancel.Click += new System.EventHandler(this.btnCreateEditCancel_Click);
            // 
            // btnCreateEditDelete
            // 
            this.btnCreateEditDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCreateEditDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEditDelete.Location = new System.Drawing.Point(968, 768);
            this.btnCreateEditDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCreateEditDelete.Name = "btnCreateEditDelete";
            this.btnCreateEditDelete.Size = new System.Drawing.Size(213, 61);
            this.btnCreateEditDelete.TabIndex = 11;
            this.btnCreateEditDelete.Text = "Delete";
            this.btnCreateEditDelete.UseVisualStyleBackColor = false;
            this.btnCreateEditDelete.Click += new System.EventHandler(this.btnCreateEditDelete_Click);
            // 
            // btnCreateEditSave
            // 
            this.btnCreateEditSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCreateEditSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateEditSave.Location = new System.Drawing.Point(1203, 768);
            this.btnCreateEditSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCreateEditSave.Name = "btnCreateEditSave";
            this.btnCreateEditSave.Size = new System.Drawing.Size(213, 61);
            this.btnCreateEditSave.TabIndex = 12;
            this.btnCreateEditSave.Text = "Save";
            this.btnCreateEditSave.UseVisualStyleBackColor = false;
            this.btnCreateEditSave.Click += new System.EventHandler(this.btnCreateEditSave_Click);
            // 
            // lblCreateEditPrompt
            // 
            this.lblCreateEditPrompt.AutoSize = true;
            this.lblCreateEditPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateEditPrompt.ForeColor = System.Drawing.Color.Black;
            this.lblCreateEditPrompt.Location = new System.Drawing.Point(104, 264);
            this.lblCreateEditPrompt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCreateEditPrompt.Name = "lblCreateEditPrompt";
            this.lblCreateEditPrompt.Size = new System.Drawing.Size(167, 48);
            this.lblCreateEditPrompt.TabIndex = 13;
            this.lblCreateEditPrompt.Text = "Prompt:";
            // 
            // lblCreateEditAnswer
            // 
            this.lblCreateEditAnswer.AutoSize = true;
            this.lblCreateEditAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateEditAnswer.ForeColor = System.Drawing.Color.Black;
            this.lblCreateEditAnswer.Location = new System.Drawing.Point(104, 462);
            this.lblCreateEditAnswer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCreateEditAnswer.Name = "lblCreateEditAnswer";
            this.lblCreateEditAnswer.Size = new System.Drawing.Size(171, 48);
            this.lblCreateEditAnswer.TabIndex = 14;
            this.lblCreateEditAnswer.Text = "Answer:";
            // 
            // txtCreateEditPrompt
            // 
            this.txtCreateEditPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateEditPrompt.Location = new System.Drawing.Point(293, 264);
            this.txtCreateEditPrompt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCreateEditPrompt.Name = "txtCreateEditPrompt";
            this.txtCreateEditPrompt.Size = new System.Drawing.Size(988, 44);
            this.txtCreateEditPrompt.TabIndex = 15;
            this.txtCreateEditPrompt.Text = "none";
            this.txtCreateEditPrompt.TextChanged += new System.EventHandler(this.txtCreateEditPrompt_TextChanged);
            // 
            // txtCreateEditAnswer
            // 
            this.txtCreateEditAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateEditAnswer.Location = new System.Drawing.Point(297, 463);
            this.txtCreateEditAnswer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCreateEditAnswer.Name = "txtCreateEditAnswer";
            this.txtCreateEditAnswer.Size = new System.Drawing.Size(985, 44);
            this.txtCreateEditAnswer.TabIndex = 16;
            this.txtCreateEditAnswer.Text = "none";
            // 
            // lblCreateEditID
            // 
            this.lblCreateEditID.AutoSize = true;
            this.lblCreateEditID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateEditID.ForeColor = System.Drawing.Color.Black;
            this.lblCreateEditID.Location = new System.Drawing.Point(1236, 17);
            this.lblCreateEditID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCreateEditID.Name = "lblCreateEditID";
            this.lblCreateEditID.Size = new System.Drawing.Size(74, 48);
            this.lblCreateEditID.TabIndex = 17;
            this.lblCreateEditID.Text = "ID:";
            this.lblCreateEditID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCreateEditID.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmCreateEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 851);
            this.Controls.Add(this.lblCreateEditID);
            this.Controls.Add(this.txtCreateEditAnswer);
            this.Controls.Add(this.txtCreateEditPrompt);
            this.Controls.Add(this.lblCreateEditAnswer);
            this.Controls.Add(this.lblCreateEditPrompt);
            this.Controls.Add(this.btnCreateEditSave);
            this.Controls.Add(this.btnCreateEditDelete);
            this.Controls.Add(this.btnCreateEditCancel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmCreateEdit";
            this.Text = "Create/Edit Flashcard";
            this.Load += new System.EventHandler(this.frmCreateEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEditCancel;
        private System.Windows.Forms.Button btnCreateEditDelete;
        private System.Windows.Forms.Button btnCreateEditSave;
        private System.Windows.Forms.Label lblCreateEditPrompt;
        private System.Windows.Forms.Label lblCreateEditAnswer;
        private System.Windows.Forms.TextBox txtCreateEditPrompt;
        private System.Windows.Forms.TextBox txtCreateEditAnswer;
        private System.Windows.Forms.Label lblCreateEditID;
    }
}