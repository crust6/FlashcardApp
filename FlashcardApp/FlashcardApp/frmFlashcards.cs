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
    public partial class frmFlashcards : Form
    {
        private void ThreadfrmHomePage()
        {
            Application.Run(new frmHomePage());
        }

        private void ThreadfrmCreateEdit()
        {
            Application.Run(new frmCreateEdit());
        }
        public frmFlashcards()
        {
            InitializeComponent();
        }

        private void txtFlashcardsFlashcardID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFlashcardsToHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadfrmHomePage));
            t.Start(); 
        }

        private void btnFlashcardsCreate_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadfrmCreateEdit));
            t.Start();
        }

        private void frmFlashcards_Load(object sender, EventArgs e)
        {

        }

        private void btnFlashcardsEdit_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadfrmCreateEdit));
            t.Start();
        }
    }
}
