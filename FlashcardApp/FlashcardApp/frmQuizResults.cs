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
    public partial class frmQuizResults : Form
    {
        private void ThreadfrmHomePage()
        {
            Application.Run(new frmHomePage());
        }
        public frmQuizResults()
        {
            InitializeComponent();
        }

        private void btnQuizResultsToHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadfrmHomePage));
            t.Start();
        }

        private void btnQuizResultsCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnQuizResultsMostRecent_Click(object sender, EventArgs e)
        {

        }

        private void btnQuizResultsOldest_Click(object sender, EventArgs e)
        {

        }
    }
}
