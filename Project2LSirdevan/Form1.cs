using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Logan Sirdevan
//COP 2010 - Project 2
//Creating a simple POS system
//Oct. 18, 2016

namespace Project2LSirdevan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//end method
        
        double dblFood1 = 12, dblFood2 = 15, dblFood3 = 10, dblFood4 = 7, dblFood5 = 6, dblFood6 = 5, dblCoke=0, dblSprite=0, dblTea=0, dblWater=0;
        double dblSubTotal = 0, dblTotal = 0, dblTaxTotal = 0;
        const double dblTAX = 0.07;

        private void ResetVars() //reset all of our vars to their default numbers so that the discount isn't taken over and over
        {
            dblFood1 = 12;
            dblFood2 = 15;
            dblFood3 = 10;
            dblFood4 = 7;
            dblFood5 = 6;
            dblFood6 = 5;
        }

        private void CheckDiscount() //this method checks if a discount is selected and applies it
        {
            if (rBtnStudent.Checked)
            {
                dblFood1 = dblFood1 - (dblFood1 * 0.05);
                dblFood2 = dblFood2 - (dblFood2 * 0.05);
                dblFood3 = dblFood3 - (dblFood3 * 0.05);
                dblFood4 = dblFood4 - (dblFood4 * 0.05);
                dblFood5 = dblFood5 - (dblFood5 * 0.05);
                dblFood6 = dblFood6 - (dblFood6 * 0.05);
            }
            else if (rBtnMilitary.Checked)
            {
                dblFood1 = dblFood1 - (dblFood1 * 0.15);
                dblFood2 = dblFood2 - (dblFood2 * 0.15);
                dblFood3 = dblFood3 - (dblFood3 * 0.15);
                dblFood4 = dblFood4 - (dblFood4 * 0.15);
                dblFood5 = dblFood5 - (dblFood5 * 0.15);
                dblFood6 = dblFood6 - (dblFood6 * 0.15);
            }
            else if (rBtnSenior.Checked)
            {
                dblFood1 = dblFood1 - (dblFood1 * 0.10);
                dblFood2 = dblFood2 - (dblFood2 * 0.10);
                dblFood3 = dblFood3 - (dblFood3 * 0.10);
                dblFood4 = dblFood4 - (dblFood4 * 0.10);
                dblFood5 = dblFood5 - (dblFood5 * 0.10);
                dblFood6 = dblFood6 - (dblFood6 * 0.10);
            }
        }//end method

        private void btnFood1_Click(object sender, EventArgs e)
        {
            CheckDiscount();
            lstOutput.Items.Add("Green Curry        " + dblFood1.ToString("c"));
            dblSubTotal = dblSubTotal + dblFood1;
            CalculateSubTotal();
            CalculateTax();
            CalculateTotal();
            ResetVars();
        }//end method
 
        private void btnFood2_Click(object sender, EventArgs e)
        {
            CheckDiscount();
            lstOutput.Items.Add("Panang Curry     " + dblFood2.ToString("c"));
            dblSubTotal = dblSubTotal + dblFood2;
            CalculateSubTotal();
            CalculateTax();
            CalculateTotal();
            ResetVars();
        }//end method

        private void btnFood3_Click(object sender, EventArgs e)
        {
            CheckDiscount();
            lstOutput.Items.Add("Red Curry           " + dblFood3.ToString("c"));
            dblSubTotal = dblSubTotal + dblFood3;
            CalculateSubTotal();
            CalculateTax();
            CalculateTotal();
            ResetVars();
        }//end method

        private void btnFood4_Click(object sender, EventArgs e)
        {
            CheckDiscount();
            lstOutput.Items.Add("Pad Thai              " + dblFood4.ToString("c"));
            dblSubTotal = dblSubTotal + dblFood4;
            CalculateSubTotal();
            CalculateTax();
            CalculateTotal();
            ResetVars();
        }//end method

        private void btnFood5_Click(object sender, EventArgs e)
        {
            CheckDiscount();
            lstOutput.Items.Add("Spring Rolls          " + dblFood5.ToString("c"));
            dblSubTotal = dblSubTotal + dblFood5;
            CalculateSubTotal();
            CalculateTax();
            CalculateTotal();
            ResetVars();
        }//end method

        private void btnFood6_Click(object sender, EventArgs e)
        {
            CheckDiscount();
            lstOutput.Items.Add("Rice                     " + dblFood6.ToString("c"));
            dblSubTotal = dblSubTotal + dblFood6;
            CalculateSubTotal();
            CalculateTax();
            CalculateTotal();
            ResetVars();
        }//end method

        private void ddlDrinks_SelectedIndexChanged(object sender, EventArgs e)//switch statement to select drinks and output them to list
        {
            switch(ddlDrinks.SelectedIndex)
            {   case 0:
                    lstOutput.Items.Add("Coke                    " + dblCoke.ToString("c"));
                    break;

                case 1:
                    lstOutput.Items.Add("Sprite                   " + dblSprite.ToString("c"));
                    break;

                case 2:
                    lstOutput.Items.Add("Tea                      " + dblTea.ToString("c"));
                    break;

                default:
                    lstOutput.Items.Add("Water                   " + dblWater.ToString("c"));
                    break;
            }//end switch
        }//end method

        private void CalculateSubTotal() //this method calculates the subtotal of all the items selected when run
        {
            txtSub.Text = dblSubTotal.ToString("c");
        }//end method

        private void CalculateTax()//this method calculates the tax of all the items selected when run
        {
            dblTaxTotal = dblTAX * dblSubTotal;
            txtTax.Text = dblTaxTotal.ToString("c");
        }//end method

        private void CalculateTotal()//this method calculates the actual total of all the items selected when run (plus tax)
        {
            dblTotal = dblTaxTotal + dblSubTotal;
            txtTotal.Text = dblTotal.ToString("c");
        }//end method
               
        private void btnClear_Click(object sender, EventArgs e)//when Clear is clicked, reset all vars 
        {
            dblSubTotal = 0;
            dblTotal = 0;
            dblTaxTotal = 0;
            txtSub.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            lstOutput.Items.Clear();
        }//end method
   
        private void btnExit_Click(object sender, EventArgs e)//this kills the app
        {
            this.Close();
        }//end method
    }//end class
}//end namespace
