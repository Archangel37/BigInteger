using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;


namespace BigInteger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(richTextBoxNum.Text) && !String.IsNullOrWhiteSpace(richTextBoxPow.Text) )
            {

                try
                {
                    System.Numerics.BigInteger Number = System.Numerics.BigInteger.Parse(richTextBoxNum.Text);
                    int Power = Convert.ToInt32(richTextBoxPow.Text);
                    System.Numerics.BigInteger Result = System.Numerics.BigInteger.Pow(Number, Power);
                    richTextBoxResult.Text = Convert.ToString(Result);
                }
                catch (FormatException)
                {
                    richTextBoxResult.Text = "Incorrect data entry, FormatException";
                }
                catch (System.ArgumentOutOfRangeException)
                {
                    richTextBoxResult.Text = "Incorrect data entry, ArgumentOutOfRangeException";
                }
               catch (System.OverflowException)
                {
                    richTextBoxResult.Text = "Incorrect data entry, OverflowException";
                }

            
            
            }

        }
    }
}
