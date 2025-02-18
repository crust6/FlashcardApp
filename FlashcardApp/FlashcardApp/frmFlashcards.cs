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
            // Retrieve all flashcards from the database
            List<(int, string, string, string)> flashcards = Database.GetAllFlashcards();

            // Print each flashcard to the console for debugging
            foreach (var card in flashcards)
            {
                Console.WriteLine($"ID: {card.Item1}, Prompt: {card.Item2}, Answer: {card.Item3}, Category: {card.Item4}");
            }
        }

        private void btnFlashcardsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedFlashcardID = Convert.ToInt32(txtFlashcardsFlashcardID.Text);

                // Check if the flashcard exists before opening edit mode
                var flashcards = Database.GetAllFlashcards();
                bool exists = flashcards.Any(f => f.Item1 == selectedFlashcardID);

                if (!exists)
                {
                    MessageBox.Show("⚠️ This Flashcard ID does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.Close();
                Thread t = new Thread(() => ThreadfrmCreateEdit(selectedFlashcardID, false));
                t.Start();
            }
            catch
            {
                MessageBox.Show("Invalid Flashcard ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFlashcardsEnterValidID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
