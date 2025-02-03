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
        public frmCreateEdit()
        {
            InitializeComponent();
        }

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
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadfrmFlashcards));
            t.Start();
        }

        private void btnCreateEditSave_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadfrmFlashcards));
            t.Start();
        }
    }
}
