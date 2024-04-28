namespace calcuC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Mi = double.Parse(MI.Text);
            double TIa = double.Parse(TIA.Text);
            int pi = int.Parse(PI.Text);


            double calcular = Mi * 1 + TIa * pi / 100;

            MessageBox.Show("HOLA tu capital es " + calcular);
        }

        private void MI_TextChanged(object sender, EventArgs e)
        {

        }

        private void TIA_TextChanged(object sender, EventArgs e)
        {

        }

        private void PI_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lim_Click(object sender, EventArgs e)
        {
            MI.Clear();
            TIA.Clear();
            PI.Clear();
        }
    }
}
