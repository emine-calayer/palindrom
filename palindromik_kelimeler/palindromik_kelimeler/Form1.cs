namespace palindromik_kelimeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = textKelime.Text.ToLower();
            if (kelime.Contains(sonuc.Text.ToLower()) == true);
            string kelimeninTersi = "";

            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                kelimeninTersi += kelime[i];
            }
            if (kelime == kelimeninTersi)
            {
                sonuc.Text = "Palindromik Kelimedir.";
            }
            else
            {
                sonuc.Text = "Polindromik Kelime Deðildir.";
            }
        }
    }
}