namespace csharp_net_forms_word_shuffle
{
    public partial class GuessTheWord : Form
    {

        List<string> words = new List<string>();
        string newText;
        int i = 0;
        int guessed = 0;

        public GuessTheWord()
        {
            InitializeComponent();
            KeyPreview = true; // Ensures the form handles key events before the control
            //this.KeyPress += new KeyPressEventHandler(KeyIsPressed); // Attaches the event handler
            Setup();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KeyIsPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (words[i].ToLower() == textBox1.Text.ToLower())
                {
                    if (i < words.Count - 1)
                    {
                        MessageBox.Show("Correct !", "Message:");
                        textBox1.Text = "";
                        i += 1;
                        newText = Scramble(words[i]);
                        lblWord.Text = newText;
                        lblInfo.Text = "Words :" + (i + 1) + " of " + words.Count;
                        guessed = 0;
                        lblGuessed.Text = "Guessed times : " + guessed;
                    }
                }
                else
                {
                    guessed += 1;
                    lblGuessed.Text = "Guessed times : " + guessed;
                }
            }
        }

        private void Setup()
        {
            words = File.ReadLines("words.txt").ToList();
            newText = Scramble(words[i]);
            lblWord.Text = newText;
            lblInfo.Text = "Words:" + (i + 1) + " of " + words.Count;
            guessed = 0;
            lblGuessed.Text = "Guessed times : " + guessed;
        }

        private string Scramble(string text)
        {
            return new string(text.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());
        }

        
    }
}
