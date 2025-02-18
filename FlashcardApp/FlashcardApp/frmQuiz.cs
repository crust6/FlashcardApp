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
    public partial class frmQuiz : Form
    {
        private void ThreadfrmHomePage()
        {
            Application.Run(new frmHomePage());
        }
        public frmQuiz()
        {
            InitializeComponent();
        }

        private void btnQuizCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadfrmHomePage));
            t.Start();
        }

        private void btnQuizSubmit_Click(object sender, EventArgs e)
        {
            AppData appData = AppData.Load();
            appData.QuizzesTaken += 1;
            appData.Save();
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadfrmHomePage));
            t.Start();
        }

        private void frmQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
