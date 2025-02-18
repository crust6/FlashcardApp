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
// threads
        private void ThreadfrmHomePage()
        {
            Application.Run(new frmHomePage());
        }

        private void ThreadfrmCreateEdit()
        {
            Application.Run(new frmCreateEdit());
        }
        private void ThreadfrmCreateEdit(int flashcardID, bool create)
        {
            Application.Run(new frmCreateEdit(flashcardID, create));
        }

        //form constructors
        public frmFlashcards()
        {
            InitializeComponent();
        }

        public frmFlashcards(int a, int b)
            {
                InitializeComponent();
                txtFlashcardsFlashcardID.Text = a.ToString();
            }

        private void txtFlashcardsFlashcardID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFlashcardsToHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(() => ThreadfrmHomePage());
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
            string err = "Invalid FlashcardID";
            try
            {
                int selectedFlashcardID = Convert.ToInt32(txtFlashcardsFlashcardID.Text);
                this.Close();
                Thread t = new Thread(() => ThreadfrmCreateEdit(selectedFlashcardID, false));
                t.Start();
            }
            catch
            {
                MessageBox.Show(err, "Flashcards", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFlashcardsEnterValidID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
