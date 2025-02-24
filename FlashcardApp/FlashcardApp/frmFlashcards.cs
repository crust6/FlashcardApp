using System;
using System.Collections;
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
        private int currentFlashcardID = 1;
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
            // retrieve list of all flashcards
            if (Database.GetNextFlashcardID() > 1)
            {
                ArrayList flashcardList = new ArrayList();
                for (int i = 1; i < Database.GetNextFlashcardID(); i++)
                {
                    flashcardList.Add(i);
                }
                Console.WriteLine(flashcardList.ToString());
                lblFlashcardsPromptAnswerTxt.Text = Database.GetFlashcardByID(Convert.ToInt32(flashcardList[0])).Value.Item2;
                lblFlashcardsID.Text = "ID: " + Database.GetFlashcardByID(Convert.ToInt32(flashcardList[0])).Value.Item1;
                lblFlashcardsCategory.Text = Database.GetFlashcardByID(Convert.ToInt32(flashcardList[0])).Value.Item4;
                lblFlashcardsPromptAnswer.Text = "Prompt";
            }
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
            int newFlashcardID = Database.GetNextFlashcardID();
            this.Close();
            Thread t = new Thread(() => ThreadfrmCreateEdit(newFlashcardID, true));
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

                // Open the edit page for this flashcard
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

        private void lblFlashcardsPromptAnswerTxt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Database.GetNextFlashcardID() > 1)
            {
                if (lblFlashcardsPromptAnswer.Text == "Prompt")
                {
                    lblFlashcardsPromptAnswerTxt.Text = Database.GetFlashcardByID(currentFlashcardID).Value.Item3;
                    lblFlashcardsID.Text = "ID: " + Database.GetFlashcardByID(currentFlashcardID).Value.Item1;
                    lblFlashcardsCategory.Text = Database.GetFlashcardByID(currentFlashcardID).Value.Item4;
                    lblFlashcardsPromptAnswer.Text = "Answer";
                }
                else
                {
                    lblFlashcardsPromptAnswerTxt.Text = Database.GetFlashcardByID(currentFlashcardID).Value.Item2;
                    lblFlashcardsID.Text = "ID: " + Database.GetFlashcardByID(currentFlashcardID).Value.Item1;
                    lblFlashcardsCategory.Text = Database.GetFlashcardByID(currentFlashcardID).Value.Item4;
                    lblFlashcardsPromptAnswer.Text = "Prompt";
                }
            }
        }
    }
}
