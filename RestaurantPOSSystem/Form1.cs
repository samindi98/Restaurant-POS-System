using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantPOSSystem
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if(BurgerCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            if(BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if(FriesCb.Checked == true)
            {
                FriesTb.Enabled = true;
            }
            if (FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void NugetsCb_CheckedChanged(object sender, EventArgs e)
        {
            if (NugetsCb.Checked == true)
            {
                NugetsTb.Enabled = true;
            }
            if (NugetsCb.Checked ==false)
            {
                NugetsTb.Enabled = false;
                NugetsTb.Text = "0";
            }
        }

        private void SandwitchCb_CheckedChanged(object sender, EventArgs e)
        {

            if (SandwitchCb.Checked == true)
            {
                SandwitchTb.Enabled = true;
            }
            if (SandwitchCb.Checked == false)
            {
                SandwitchTb.Enabled = false;
                SandwitchTb.Text = "0";
            }
        }

        private void ShawarmaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwitchCb.Checked == true)
            {
                ShawarmaTb.Enabled = true;
            }
            if (ShawarmaCb.Checked == false)
            {
                ShawarmaTb.Enabled = false;
                ShawarmaTb.Text = "0";
            }
        }

        private void PizzaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PizzaCb.Checked == true)
            {
                PizzaTb.Enabled = true;
            }
            if (PizzaCb.Checked == false)
            {
                PizzaTb.Enabled = false;
                PizzaTb.Text = "0";
            }
        }

        private void DrumstickCb_CheckedChanged(object sender, EventArgs e)
        {
            if (DrumstickCb.Checked == true)
            {
                DrumstickTb.Enabled = true;
            }
            if (DrumstickCb.Checked == false)
            {
                DrumstickTb.Enabled = false;
                DrumstickTb.Text = "0";
            }
        }
        private void CheeseCakeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CheeseCakeCb.Checked == true)
            {
                CheeseCakeTb.Enabled = true;
            }
            if (CheeseCakeCb.Checked == false)
            {
                CheeseCakeTb.Enabled = false;
                CheeseCakeTb.Text = "0";
            }
        }

        private void LatteMacchiatoCb_CheckedChanged(object sender, EventArgs e)
        {
            if (LatteMacchiatoCb.Checked == true)
            {
                LatteMacchiatoTb.Enabled = true;
            }
            if (LatteMacchiatoCb.Checked == false)
            {
                LatteMacchiatoTb.Enabled = false;
                LatteMacchiatoTb.Text = "0";
            }
        }

        private void IceCreamCb_CheckedChanged(object sender, EventArgs e)
        {
            if (IceCreamCb.Checked == true)
            {
                IceCreamTb.Enabled = true;
            }
            if (IceCreamCb.Checked == false)
            {
                IceCreamTb.Enabled = false;
                IceCreamTb.Text = "0";
            }
        }

        private void FaludaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FaludaCb.Checked == true)
            {
                FaludaTb.Enabled = true;
            }
            if (FaludaCb.Checked == false)
            {
                FaludaTb.Enabled = false;
                FaludaTb.Text = "0";
            }
        }
        private void MilkshakeCb_CheckedChanged(object sender, EventArgs e)
        {

            if (MilkshakeCb.Checked == true)
            {
                MilkshakeTb.Enabled = true;
            }
            if (MilkshakeCb.Checked == false)
            {
                MilkshakeTb.Enabled = false;
                MilkshakeTb.Text = "0";
            }
        }


        private void closePb_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //declare unit price to different meal and drinks

        double burgerup = 200, sandwithup = 150, friesup = 100, shawarmaup = 300, nugetsup = 100, drumstickup = 400, pizzaup = 500;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(RecieptTb.Text + " Subtotal " + Subtotallbl.Text + "\tTax: " + Taxlbl.Text + "\tGrand Total: " + Gradtotallbl.Text, new Font("\tCentury Gothic", 12, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK) ;
            {
                printDocument1.Print();
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            BurgerCb.Checked = false;
            SandwitchCb.Checked = false;
            FriesCb.Checked = false;
            ShawarmaCb.Checked = false;
            NugetsCb.Checked = false;
            DrumstickCb.Checked = false;
            PizzaCb.Checked = false;
            CheeseCakeCb.Checked = false;
            IceCreamCb.Checked = false;
            LatteMacchiatoCb.Checked = false;   
            FaludaCb.Checked = false;
            CreamCakeCb.Checked = false;
            MilkshakeCb.Checked = false;
        }

        double milkshakeup = 350, cheesecakeup = 250, icecreamup = 200, chocolatemooseup = 350, lattemacchiatoup = 350, faludaup = 200, creamcakeup = 400;

        //declare variable to hold total price for each drinks and meals
        double burgertp, sandwithtp, friestp, shawarmatp, nugetstp, drumsticktp, pizzatp, milkshaketp, cheesecaketp, icecreamtp, chocolatemoosetp, lattemacchiatotp, faludatp, creamcaketp;
        double Subtotal = 0, tax,gradtotal;

        private void button2_Click(object sender, EventArgs e)
        {
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            sandwithtp = sandwithup * Convert.ToDouble(SandwitchTb.Text);
            friestp = friesup * Convert.ToDouble(FriesTb.Text);
            shawarmatp = shawarmaup * Convert.ToDouble(ShawarmaTb.Text);
            nugetstp = nugetsup * Convert.ToDouble(NugetsTb.Text);
            drumsticktp = drumstickup * Convert.ToDouble(DrumstickTb.Text);
            pizzatp = pizzaup * Convert.ToDouble(PizzaTb.Text);

            milkshaketp = milkshakeup * Convert.ToDouble(MilkshakeTb.Text);
            cheesecaketp = cheesecakeup * Convert.ToDouble(CheeseCakeTb.Text);
            icecreamtp = icecreamup * Convert.ToDouble(IceCreamTb.Text);
            //chocolatemoosetp = chocolatemooseup * Convert.ToDouble(Cho.Text);
            lattemacchiatotp = lattemacchiatoup * Convert.ToDouble(LatteMacchiatoTb.Text);
            faludatp = faludaup * Convert.ToDouble(FaludaTb.Text);
            creamcaketp = creamcakeup * Convert.ToDouble(CreamCakeTb.Text);

            //add drinks


            //add products on the receipt
            RecieptTb.Clear();
           Subtotal = 0;
            RecieptTb.AppendText(Environment.NewLine);
            RecieptTb.AppendText("\t\t\tNEXTGEN RESTAURANT"+Environment.NewLine);
            RecieptTb.AppendText("\t\t\t******************************\t\t"+Datelbl.Text+Environment.NewLine);
            if(BurgerCb.Checked==true)
            {
                RecieptTb.AppendText("\tBurger:\t" + "Rs. " + burgertp + ".00" + Environment.NewLine);
                Subtotal = Subtotal + burgertp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (FriesCb.Checked == true)
            {
                RecieptTb.AppendText("\tFries:\t" + "Rs. " + friestp + ".00" + Environment.NewLine);
                Subtotal = Subtotal + friestp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (NugetsCb.Checked == true)
            {
                RecieptTb.AppendText("\tNuggets:\t" + "Rs. " + nugetstp + ".00" + Environment.NewLine);
                Subtotal = Subtotal + nugetstp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (SandwitchCb.Checked == true)
            {
                RecieptTb.AppendText("\tSandwitches:\t" + "Rs. " + sandwithtp + ".00" + Environment.NewLine);
                Subtotal = Subtotal + sandwithtp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (ShawarmaCb.Checked == true)
            {
                RecieptTb.AppendText("\tShawarma:\t" + "Rs. " + shawarmatp + ".00" + Environment.NewLine);
                Subtotal = Subtotal + shawarmatp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (DrumstickCb.Checked == true)
            {
                RecieptTb.AppendText("\tDrumstick:\t" + "Rs. " + drumsticktp + ".00" + Environment.NewLine);
                Subtotal = Subtotal + drumsticktp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (PizzaCb.Checked == true)
            {
                RecieptTb.AppendText("\tPizza:\t" + "Rs. " + pizzatp + ".00" + Environment.NewLine);
                Subtotal = Subtotal + pizzatp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (MilkshakeCb.Checked == true)
            {
                RecieptTb.AppendText("\tMilkshake:\t" + "Rs. " + milkshaketp + ".00" + Environment.NewLine);
                Subtotal = Subtotal + milkshaketp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (CheeseCakeCb.Checked == true)
            {
                RecieptTb.AppendText("\tCheesecake:\t" + "Rs. " + cheesecaketp + ".00" + Environment.NewLine);
                Subtotal = Subtotal + cheesecaketp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (IceCreamCb.Checked == true)
            {
                RecieptTb.AppendText("\tIcecream:\t" + "Rs. " + icecreamtp + ".00" + Environment.NewLine);
                Subtotal = Subtotal + icecreamtp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (LatteMacchiatoCb.Checked == true)
            {
                RecieptTb.AppendText("\tLattemacchiato:\t" + "Rs. " + lattemacchiatotp + ".00" + Environment.NewLine);
                Subtotal = Subtotal + lattemacchiatotp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (FaludaCb.Checked == true)
            {
                RecieptTb.AppendText("\tFaluda:\t" + "Rs. " + faludatp + ".00" + Environment.NewLine);
                Subtotal = Subtotal + faludatp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }
            if (CreamCakeCb.Checked == true)
            {
                RecieptTb.AppendText("\tCream Cake:\t" + "Rs. " + creamcaketp + ".00" + Environment.NewLine);
                Subtotal = Subtotal + creamcaketp;
                Subtotallbl.Text = "Rs:" + Subtotal;
            }




            tax = Subtotal * 0.16; //16% tax calculation
            gradtotal = Subtotal + tax;
            Taxlbl.Text = "Rs:" + tax;
            Gradtotallbl.Text = "Rs:" + gradtotal;


        }

        

        private void RecieptTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
