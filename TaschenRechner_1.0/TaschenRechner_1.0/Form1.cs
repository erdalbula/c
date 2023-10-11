using Microsoft.VisualBasic.Logging;
using System;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using Taschenrechner_Library;



namespace TaschenRechner_1._0
{
    public partial class Form1 : Form
    {
        char _operation;
        bool _wirdBildschirmGereinigt;
        double _ersteZahl;



        private Calculator calculator;
        private CalculatorHistory history;

        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
            history = new CalculatorHistory();


        }


        private void zahl0Button_Click(object sender, EventArgs e)
        {
            if (_wirdBildschirmGereinigt)
            {
                Bildschirmlabel.Text = "";
                _wirdBildschirmGereinigt = false;
            }

            if (Bildschirmlabel.Text == "0") Bildschirmlabel.Text = "";
            Bildschirmlabel.Text += "0";
        }

        private void zahl1Button_Click(object sender, EventArgs e)
        {
            if (_wirdBildschirmGereinigt)
            {
                Bildschirmlabel.Text = "";
                _wirdBildschirmGereinigt = false;
            }

            if (Bildschirmlabel.Text == "0") Bildschirmlabel.Text = "";
            Bildschirmlabel.Text += "1";
        }

        private void zahl2Button_Click(object sender, EventArgs e)
        {
            if (_wirdBildschirmGereinigt)
            {
                Bildschirmlabel.Text = "";
                _wirdBildschirmGereinigt = false;
            }

            if (Bildschirmlabel.Text == "0") Bildschirmlabel.Text = "";
            Bildschirmlabel.Text += "2";
        }

        private void zahl3Button_Click(object sender, EventArgs e)
        {
            if (_wirdBildschirmGereinigt)
            {
                Bildschirmlabel.Text = "";
                _wirdBildschirmGereinigt = false;
            }

            if (Bildschirmlabel.Text == "0") Bildschirmlabel.Text = "";
            Bildschirmlabel.Text += "3";
        }

        private void zahl4Button_Click(object sender, EventArgs e)
        {
            if (_wirdBildschirmGereinigt)
            {
                Bildschirmlabel.Text = "";
                _wirdBildschirmGereinigt = false;
            }

            if (Bildschirmlabel.Text == "0") Bildschirmlabel.Text = "";
            Bildschirmlabel.Text += "4";
        }

        private void zahl5Button_Click(object sender, EventArgs e)
        {
            if (_wirdBildschirmGereinigt)
            {
                Bildschirmlabel.Text = "";
                _wirdBildschirmGereinigt = false;
            }

            if (Bildschirmlabel.Text == "0") Bildschirmlabel.Text = "";
            Bildschirmlabel.Text += "5";
        }

        private void zahl6Button_Click(object sender, EventArgs e)
        {
            if (_wirdBildschirmGereinigt)
            {
                Bildschirmlabel.Text = "";
                _wirdBildschirmGereinigt = false;
            }

            if (Bildschirmlabel.Text == "0") Bildschirmlabel.Text = "";
            Bildschirmlabel.Text += "6";
        }

        private void zahl7Button_Click(object sender, EventArgs e)
        {
            if (_wirdBildschirmGereinigt)
            {
                Bildschirmlabel.Text = "";
                _wirdBildschirmGereinigt = false;
            }

            if (Bildschirmlabel.Text == "0") Bildschirmlabel.Text = "";
            Bildschirmlabel.Text += "7";
        }

        private void zahl8Button_Click(object sender, EventArgs e)
        {
            if (_wirdBildschirmGereinigt)
            {
                Bildschirmlabel.Text = "";
                _wirdBildschirmGereinigt = false;
            }

            if (Bildschirmlabel.Text == "0") Bildschirmlabel.Text = "";
            Bildschirmlabel.Text += "8";
        }

        private void zahl9Button_Click(object sender, EventArgs e)
        {
            if (_wirdBildschirmGereinigt)
            {
                Bildschirmlabel.Text = "";
                _wirdBildschirmGereinigt = false;
            }

            if (Bildschirmlabel.Text == "0") Bildschirmlabel.Text = "";
            Bildschirmlabel.Text += "9";
        }

        private void gleichButton_Click(object sender, EventArgs e)
        {
            double _zweiteZahl = Convert.ToDouble(Bildschirmlabel.Text);
            double ergebnis = 0;

            try
            {
                ergebnis = calculator.Calculate(_ersteZahl, _operation, _zweiteZahl);

                string expression = $"{_ersteZahl} {_operation} {_zweiteZahl}";
                CalculatorHistory.Log(expression, ergebnis);
                Bildschirmlabel.Text = Convert.ToString((decimal)ergebnis);
            }
            catch (Exception ex)
            {
                Bildschirmlabel.Text = "Err: " + ex.Message;
            }
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            _operation = '/';
            _wirdBildschirmGereinigt = true;
            _ersteZahl = Convert.ToDouble(Bildschirmlabel.Text);
        }

        private void multiplikationButton_Click(object sender, EventArgs e)
        {
            _operation = '*';
            _wirdBildschirmGereinigt = true;
            _ersteZahl = Convert.ToDouble(Bildschirmlabel.Text);
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            _operation = '+';
            _wirdBildschirmGereinigt = true;
            _ersteZahl = Convert.ToDouble(Bildschirmlabel.Text);
        }

        private void subtraktionButton_Click(object sender, EventArgs e)
        {
            _operation = '-';
            _wirdBildschirmGereinigt = true;
            _ersteZahl = Convert.ToDouble(Bildschirmlabel.Text);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Bildschirmlabel.Text = "0";

        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (!Bildschirmlabel.Text.Contains(","))
            {
                Bildschirmlabel.Text += ",";
            }
        }




        private void kammernButton_Click(object sender, EventArgs e)
        {
            double zahlen = double.Parse(Bildschirmlabel.Text);
            Bildschirmlabel.Text = Math.Sqrt(zahlen).ToString();
        }

        private void vorzeichenButton_Click(object sender, EventArgs e)
        {
            double zahlen = double.Parse(Bildschirmlabel.Text);
            Bildschirmlabel.Text = (-zahlen).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double zahlen = double.Parse(Bildschirmlabel.Text);
            Bildschirmlabel.Text = Math.Pow(zahlen, 3).ToString();
            //button1.Text = $"{zahlen}³";

        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Bildschirmlabel.Text, out double aciDerece))
            {
                // Dereceyi radyana çevirin.
                double aciRadyan = aciDerece * (Math.PI / 180);

                // Sin, Cos, Tan ve Cot değerlerini hesaplayın.
                double sinSonuc = Math.Sin(aciRadyan);
                Bildschirmlabel.Text = $"{sinSonuc}";
            }
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Bildschirmlabel.Text, out double aciDerece))
            {

                double aciRadyan = aciDerece * (Math.PI / 180);


                double cosSonuc = Math.Cos(aciRadyan);
                Bildschirmlabel.Text = $"{cosSonuc}";
            }
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Bildschirmlabel.Text, out double aciDerece))
            {

                double aciRadyan = aciDerece * (Math.PI / 180);


                double tanSonuc = Math.Tan(aciRadyan);
                Bildschirmlabel.Text = $"{tanSonuc}";
            }

        }

        private void buttonCot_Click(object sender, EventArgs e)
        {
            if (double.TryParse(Bildschirmlabel.Text, out double aciDerece))
            {

                double aciRadyan = aciDerece * (Math.PI / 180);


                double tanSonuc = Math.Tan(aciRadyan);
                double cotSonuc = 1.0 / tanSonuc;
                Bildschirmlabel.Text = $"{cotSonuc}";
            }
        }




        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string ifade = Bildschirmlabel.Text;
        //    double sonuc = Hesapla(ifade);
        //    Bildschirmlabel.Text = "Sonuç: " + sonuc.ToString();
        //}

        //private double Hesapla(string ifade)
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        return Convert.ToDouble(dt.Compute(ifade, ""));
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Geçersiz bir ifade girdiniz.");
        //        return double.NaN;
        //    }
        //}
    }
}