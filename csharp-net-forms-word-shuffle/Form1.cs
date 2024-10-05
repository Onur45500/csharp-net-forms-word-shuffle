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
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KeyIsPressed(object sender, KeyPressEventArgs e)
        {

        }

        private void Setup()
        {
            words = File.ReadLines("words.txt").ToList();
            newText = Scramble(words[i]);
            lblWord.Text = newText;
            lblInfo.Text = "Words:" + (i + 1) + " of " + words.Count;
        }

        private string Scramble(string text)
        {

        }
    }
}
