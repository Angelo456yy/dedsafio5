namespace CUOTAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double PS = double.Parse(Pts.Text);
            double ts = double.Parse(Ts.Text);
            double Pgs = double.Parse(Pg.Text);

            double Total = (PS * ts) / (1 - Math.Pow(1 + ts, -Pgs));

            MessageBox.Show("resultado es " + Total);

        }

        private void Ts_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pts_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pg_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
