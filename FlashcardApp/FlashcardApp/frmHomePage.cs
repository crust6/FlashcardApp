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
        public frmHomePage()
        {
            InitializeComponent();
        }

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
    }
}
