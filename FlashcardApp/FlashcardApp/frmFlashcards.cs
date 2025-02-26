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
        //instance variables

        private int currentFlashcardID = 0;
        private int flashcardListIndex = 0;
        private bool promptAnswerState = false;
        private ArrayList flashcardList = new ArrayList();


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
            List<(int, string, string, string)> temp = Database.GetAllFlashcards();
            if (Database.GetAllFlashcards().Count > 0)
            {
                for (int i = 0; i < temp.Count; i++)
                {
                    flashcardList.Add(Convert.ToInt32(temp[i].Item1));
                }

                currentFlashcardID = Convert.ToInt32(flashcardList[0]);

                Console.WriteLine(flashcardList.ToString());
                this.updateFlashcard(Convert.ToInt32(flashcardList[0]), false);
            }
            else
            {
                MessageBox.Show("⚠️ You currently have Zero Flashcards!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // methods

        private void updateFlashcard(int flashcardID, bool promptAnswer)
        {
            lblFlashcardsID.Text = "ID: " + Database.GetFlashcardByID(flashcardID).Value.Item1;
            lblFlashcardsCategory.Text = Database.GetFlashcardByID(flashcardID).Value.Item4;
            if (promptAnswer)
            {
                lblFlashcardsPromptAnswer.Text = "Answer";
                lblFlashcardsPromptAnswerTxt.Text = Database.GetFlashcardByID(flashcardID).Value.Item3;
            }
            else
            {
                lblFlashcardsPromptAnswer.Text = "Prompt";
                lblFlashcardsPromptAnswerTxt.Text = Database.GetFlashcardByID(flashcardID).Value.Item2;
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
            try
            {
                promptAnswerState = !promptAnswerState;
                this.updateFlashcard(currentFlashcardID, promptAnswerState);
            }
            catch
            {

            }
        }

        private void btnFlashcardsView_Click(object sender, EventArgs e)
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
                else
                {
                    currentFlashcardID = selectedFlashcardID;
                    this.updateFlashcard(selectedFlashcardID, promptAnswerState);
                    List<(int, string, string, string)> temp = Database.GetAllFlashcards();
                    flashcardList.Clear();
                    if (Database.GetAllFlashcards().Count > 0)
                    {
                        for (int i = 0; i < temp.Count; i++)
                        {
                            flashcardList.Add(Convert.ToInt32(temp[i].Item1));
                        }
                    }
                    for (int i = 0; i < flashcardList.Count; i++)
                    {
                        if (currentFlashcardID == Convert.ToInt32(flashcardList[i]))
                        {
                            flashcardListIndex = i;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Flashcard ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFlashcardsNext_Click(object sender, EventArgs e)
        {
            try
            {
                this.updateFlashcard(Convert.ToInt32(flashcardList[flashcardListIndex + 1]), promptAnswerState);
                currentFlashcardID = Convert.ToInt32(flashcardList[flashcardListIndex + 1]);
                flashcardListIndex = flashcardListIndex + 1;
            }
            catch
            {
                MessageBox.Show("You have reached the end of the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentFlashcardID = Convert.ToInt32(flashcardList[flashcardList.Count - 1]);
                flashcardListIndex = Convert.ToInt32(flashcardList.Count - 1);
            }
        }

        private void btnFlashcardsBack_Click(object sender, EventArgs e)
        {
            try
            {
                this.updateFlashcard(Convert.ToInt32(flashcardList[flashcardListIndex - 1]), promptAnswerState);
                currentFlashcardID = Convert.ToInt32(flashcardList[flashcardListIndex - 1]);
                flashcardListIndex = flashcardListIndex - 1;
            }
            catch
            {
                MessageBox.Show("You have reached the end of the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentFlashcardID = Convert.ToInt32(flashcardList[0]);
                flashcardListIndex = Convert.ToInt32(0);
            }
        }
    }
}
