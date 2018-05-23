using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolator
{
    public partial class Int_Calculator : Form
    {
        Calcolator.Servizio.CalculatorSoap service = new Calcolator.Servizio.CalculatorSoapClient();
        public Int_Calculator()
        {
            InitializeComponent();
          


        }

        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void lo(object sender, EventArgs e)
        {
            if (valore1.Text == "0")
                valore1.Clear();
            Button button =  (Button) sender;
        
            valore1.Text += button.Text;

        }

        private void primo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            primo.Text = "";
            secondo.Text = "";
            operazione.Text = "";
            valore1.Clear();
            valore1.Text = "0";

        }

        private void operation(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            operazione.Text = button.Text;
            if (primo.Text == "")
            {
                primo.Text = valore1.Text;
               
                valore1.Text = "0";
            }
            else if(primo.Text!="")
            {
                secondo.Text = valore1.Text;
            }
        }

        public void uguale_Click(object sender, EventArgs e)
        {
            int a, b, c;

            if (primo.Text!="")
            {
                secondo.Text = valore1.Text;
                valore1.Clear();
                if (primo.Text != "" && secondo.Text != "")
                {
                     a = Int32.Parse(primo.Text);
                     b = Int32.Parse(secondo.Text);
                     c = 0;
                    switch (operazione.Text)
                    {
                        case "+":
                            c = service.Add(a, b);
                            valore1.Text = c.ToString();
                            break;
                        case "-":
                            c = service.Subtract(a, b);
                            valore1.Text = c.ToString();

                            break;
                        case "*":
                            c = service.Multiply(a, b);
                            valore1.Text = c.ToString();
                            break;
                        case "/":
                            c = service.Divide(a, b);
                            valore1.Text = c.ToString();
                            break;
                        default:
                            valore1.Text = "error";
                            break;
                    }
                }
            }
           
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(primo.Text!=""&&secondo.Text=="")
            {
                primo.Text = "";
                valore1.Text = "";
            }
            else if(secondo.Text!=""&&primo.Text!="")
            {
               
            }
        }
    }
}
