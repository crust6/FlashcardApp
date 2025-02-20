using System;
using System.CodeDom.Compiler;
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
    public partial class frmHomePage : Form
    {
        private void ThreadfrmFlashcards()
        {
            Application.Run(new frmFlashcards());
        }
        private void ThreadfrmQuiz()
        {
            Application.Run(new frmQuiz());
        }
        private void ThreadfrmQuizResults()
        {
            Application.Run(new frmQuizResults());
        }
// form constructor
        public frmHomePage()
        {
            InitializeComponent();
            AppData appData = AppData.Load();

            lblHomePageFlashcardsCreated.Text = appData.FlashcardsCreated.ToString();
            lblHomePageQuizzesTaken.Text = appData.QuizzesTaken.ToString();
        } 

// METHODS


    private void frmHomePage_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnHomePageToFlashcards_Click(object sender, EventArgs e)
        {

            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadfrmFlashcards));
            t.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHomePageTakeQuiz_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadfrmQuiz));
            t.Start();
        }

        private void btnHomePageQuizResults_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadfrmQuizResults));
            t.Start();
        }

        private void btnHomePageExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHomePageClearAll(object sender, EventArgs e)
        {
            
        }

        private void btnHomePageClearAllData_Click(object sender, EventArgs e)
        {
            AppData appData = AppData.Load();
            appData.FlashcardsCreated = 0;
            appData.QuizzesTaken = 0;
            appData.Save();

            int TotalFlashcards = 0;
            var flashcards = Database.GetAllFlashcards();
            foreach (var card in flashcards)
            {
                TotalFlashcards += 1;
            }
            for (int i = 1; i < TotalFlashcards+1; i++)
            {
                Database.DeleteFlashcard(i);
            }
            MessageBox.Show($"❌ All Data Deleted!");
            lblHomePageFlashcardsCreated.Text = appData.FlashcardsCreated.ToString();
            lblHomePageQuizzesTaken.Text = appData.QuizzesTaken.ToString();

        }
    }
}
