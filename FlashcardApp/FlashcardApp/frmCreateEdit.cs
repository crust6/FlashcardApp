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

        bool create = false;

        private void ThreadfrmFlashcards()
        {
            Application.Run(new frmFlashcards());
        }

        private void ThreadfrmFlashcards(int a, int b)
        {
            Application.Run(new frmFlashcards(a, b));
        }
// form constructor

        public frmCreateEdit()
        {
            InitializeComponent();
        }

        public frmCreateEdit(int flashcardID, bool create)
        {
            this.create = create;
            InitializeComponent();
            lblCreateEditID.Text = "ID: " + flashcardID.ToString();

            if (!create)
            {
                // Load flashcard data for editing
                var flashcard = Database.GetFlashcardByID(flashcardID);
                if (flashcard.HasValue)  // or if (flashcard != null)
                {
                    txtCreateEditPrompt.Text = flashcard.Value.Item2;  // Prompt
                    txtCreateEditAnswer.Text = flashcard.Value.Item3;  // Answer
                    txtCreateEditCategory.Text = flashcard.Value.Item4; // Category
                }
            }
        }

        // METHODS


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
            int flashcardID = Convert.ToInt32(lblCreateEditID.Text.Replace("ID: ", ""));

            Database.DeleteFlashcard(flashcardID);
            MessageBox.Show($"❌ Flashcard {flashcardID} Deleted!");

            this.Close();
            Thread t = new Thread(new ThreadStart(ThreadfrmFlashcards));
            t.Start();
        }
        private void btnCreateEditSave_Click(object sender, EventArgs e)
        {
            int flashcardID = Convert.ToInt32(lblCreateEditID.Text.Replace("ID: ", ""));

            if (this.create)
            {
                Database.AddFlashcard(txtCreateEditPrompt.Text, txtCreateEditAnswer.Text, txtCreateEditCategory.Text);
                AppData appData = AppData.Load();
                appData.FlashcardsCreated += 1;
                appData.Save();
            }
            else
            {
                Database.UpdateFlashcard(flashcardID, txtCreateEditPrompt.Text, txtCreateEditAnswer.Text, txtCreateEditCategory.Text);

            }

            MessageBox.Show("✅ Flashcard Updated!");
            
            var card = Database.GetFlashcardByID(flashcardID);
            if (card.HasValue)
            {
                Console.WriteLine($"ID: {card.Value.Item1}, Q: {card.Value.Item2}, A: {card.Value.Item3}, Category: {card.Value.Item4}");
            }
            else
            {
                Console.WriteLine("Card not found after update!");  // Optional error handling
            }



            this.Close();
            Thread t = new Thread(() => ThreadfrmFlashcards());
            t.Start();
        }

        private void txtCreateEditPrompt_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCreateEdit_Load(object sender, EventArgs e)
        {
            if (lblCreateEditID.Text == "ID: ")
            {
                // Display the ID of the new flashcard that will be created
                int nextID = Database.GetNextFlashcardID();
                lblCreateEditID.Text = "ID: " + nextID.ToString();
            }
        }

        private void txtCreateEditCategory_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
