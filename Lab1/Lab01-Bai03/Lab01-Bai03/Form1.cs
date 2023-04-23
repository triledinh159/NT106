namespace Lab01_Bai03
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> conversionRates;
        public Form1()
        {
            InitializeComponent();
            InitializeCurrencyComboBoxes();
            InitializeConversionRates();
        }
        private void InitializeCurrencyComboBoxes()
        {
            combo.Items.AddRange(new string[] { "USD", "EUR", "GBP", "SGD", "JPY", "VNĐ" });
            combo.SelectedIndex = 0;

            combo2.Items.AddRange(new string[] { "USD", "EUR", "GBP", "SGD", "JPY", "VNĐ" });
            combo2.SelectedIndex = 0;
        }
        private void InitializeConversionRates()
        {
            conversionRates = new Dictionary<string, double>();
            conversionRates.Add("USD", 22_772);
            conversionRates.Add("EUR", 28_132);
            conversionRates.Add("GBP", 31_538);
            conversionRates.Add("SGD", 17_286);
            conversionRates.Add("JPY", 214);
            conversionRates.Add("VNĐ", 1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mon_TextChanged(object sender, EventArgs e)
        {

        }

        private void cvmon_TextChanged(object sender, EventArgs e)
        {

        }

        private double GetExchangeRate(string fromCurrency, string toCurrency)
        {
            double rate = 1;
            switch (fromCurrency.ToUpper())
            {
                case "USD":
                    switch (toCurrency.ToUpper())
                    {
                        case "USD":
                            rate = 1;
                            break;
                        case "EUR":
                            rate = 0.88;
                            break;
                        case "GBP":
                            rate = 0.79;
                            break;
                        case "SGD":
                            rate = 1.37;
                            break;
                        case "JPY":
                            rate = 111.30;
                            break;
                        case "VNĐ":
                            rate = 22772;
                            break;
                    }
                    break;
                case "EUR":
                    switch (toCurrency.ToUpper())
                    {
                        case "USD":
                            rate = 1.14;
                            break;
                        case "EUR":
                            rate = 1;
                            break;
                        case "GBP":
                            rate = 0.89;
                            break;
                        case "SGD":
                            rate = 1.54;
                            break;
                        case "JPY":
                            rate = 126.70;
                            break;
                        case "VNĐ":
                            rate = 28132;
                            break;
                    }
                    break;
                case "GBP":
                    switch (toCurrency.ToUpper())
                    {
                        case "USD":
                            rate = 1.26;
                            break;
                        case "EUR":
                            rate = 1.12;
                            break;
                        case "GBP":
                            rate = 1;
                            break;
                        case "SGD":
                            rate = 1.73;
                            break;
                        case "JPY":
                            rate = 142.99;
                            break;
                        case "VNĐ":
                            rate = 31538;
                            break;
                    }
                    break;
                case "SGD":
                    switch (toCurrency.ToUpper())
                    {
                        case "USD":
                            rate = 0.73;
                            break;
                        case "EUR":
                            rate = 0.65;
                            break;
                        case "GBP":
                            rate = 0.58;
                            break;
                        case "SGD":
                            rate = 1;
                            break;
                        case "JPY":
                            rate = 82.22;
                            break;
                        case "VNĐ":
                            rate = 17286;
                            break;
                    }
                    break;
                case "JPY":
                    switch (toCurrency.ToUpper())
                    {
                        case "USD":
                            rate = 0.009;
                            break;
                        case "EUR":
                            rate = 0.008;
                            break;
                        case "GBP":
                            rate = 0.007;
                            break;
                        case "SGD":
                            rate = 0.012;
                            break;
                        case "JPY":
                            rate = 1;
                            break;
                        case "VNĐ":
                            rate = 214;
                            break;
                    }
                    break;
                case "VNĐ":
                    switch (toCurrency.ToUpper())
                    {
                        case "USD":
                            rate = 0.009;
                            break;
                        case "EUR":
                            rate = 0.008;
                            break;
                        case "GBP":
                            rate = 0.007;
                            break;
                        case "SGD":
                            rate = 0.012;
                            break;
                        case "JPY":
                            rate = 1;
                            break;
                        case "VNĐ":
                            rate = 1;
                            break;
                    }
                    break;
            }
            return rate;
        }



        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void combo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            quydoi.Text = "1 " + combo.SelectedItem.ToString() + " = " + GetExchangeRate(combo.SelectedItem.ToString(), combo2.SelectedItem.ToString()) + " " + combo2.SelectedItem.ToString();
        }
        private void ConvertCurrency()
        {
            double inputAmount;
            double.TryParse(mon.Text, out inputAmount);

            double fromRate = conversionRates[combo.SelectedItem.ToString()];
            double toRate = conversionRates[combo2.SelectedItem.ToString()];
            quydoi.Text = "1 " + combo.SelectedItem.ToString() + " = " + GetExchangeRate(combo.SelectedItem.ToString(), combo2.SelectedItem.ToString()) + " " + combo2.SelectedItem.ToString();

            double result = inputAmount * fromRate / toRate;
            cvmon.Text = result.ToString("N0");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void quydoi_Click(object sender, EventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {
            mon.Text = "";
            cvmon.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}