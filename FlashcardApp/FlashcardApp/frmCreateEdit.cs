using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashcardApp
{
    public partial class frmCreateEdit : Form
    {
        private void ThreadfrmFlashcards()
        {
            Application.Run(new frmFlashcards());
        }

        private void ThreadfrmFlashcards(int a, int b)
        {
            Application.Run(new frmFlashcards(a, b));
        }
// form constructor

        public frmCreateEdit()
        {
            InitializeComponent();
        }
        public frmCreateEdit(int flashcardID, bool create)
        {
            InitializeComponent();
            lblCreateEditID.Text = "ID: " + flashcardID.ToString();

        }

        // METHODS



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadfrmFlashcards));
            t.Start();
        }

        private void btnCreateEditDelete_Click(object sender, EventArgs e)
        {
            int flashcardID = Convert.ToInt32(lblCreateEditID.Text.Replace("ID: ", ""));

            Database.DeleteFlashcard(flashcardID);
            MessageBox.Show($"❌ Flashcard {flashcardID} Deleted!");

            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadfrmFlashcards));
            t.Start();
        }

        private void btnCreateEditSave_Click(object sender, EventArgs e)
        {



            Database.AddFlashcard(txtCreateEditPrompt.Text, txtCreateEditAnswer.Text, "Default");
            MessageBox.Show("Flashcard Saved!");

            AppData appData = AppData.Load();
            appData.FlashcardsCreated += 1;
            appData.Save();

            this.Close();
            Thread t = new Thread(() => ThreadfrmFlashcards(1, 1));
            t.Start();
        }

        private void txtCreateEditPrompt_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCreateEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
