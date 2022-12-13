namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void powerButton_Select(object sender, EventArgs e)
        {
            goldvalue.Text = "700";
            materialsValue.Text = "700";
            humanValue.Text = "400";
            foodValue.Text = "400";
        }

        private void militaryButton_Select(object sender, EventArgs e)
        {
            goldvalue.Text = "700";
            materialsValue.Text = "400";
            humanValue.Text = "700";
            foodValue.Text = "400";

        }

        private void religionButton_Select(object sender, EventArgs e)
        {
            goldvalue.Text = "400";
            materialsValue.Text = "400";
            humanValue.Text = "700";
            foodValue.Text = "700";
        }

        private void tradeButton_Select(object sender, EventArgs e)
        {
            goldvalue.Text = "400";
            materialsValue.Text = "700";
            humanValue.Text = "400";
            foodValue.Text = "700";
        }
        private void button_Leave(object sender, EventArgs e)
        {
            goldvalue.Text = "0";
            materialsValue.Text = "0";
            humanValue.Text = "0";
            foodValue.Text = "0";
        }

        private async void powerButton_Click(object sender, EventArgs e)
        {
            var form = new Form2("Power");
            Hide();
            await Task.Run(() => form.ShowDialog());
            this.Close();
        }

        private async void militaryButton_Click(object sender, EventArgs e)
        {
            var form = new Form2("Military");
            Hide();
            await Task.Run(() => form.ShowDialog());
            this.Close();
        }

        private async void religionButton_Click(object sender, EventArgs e)
        {
            var form = new Form2("Religion");
            Hide();
            await Task.Run(() => form.ShowDialog());
            this.Close();
        }

        private async void tradeButton_Click(object sender, EventArgs e)
        {
            var form = new Form2("Trade");
            Hide();
            await Task.Run(() => form.ShowDialog());
            this.Close();
        }
    }
}