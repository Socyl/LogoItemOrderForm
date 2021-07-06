using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoItemOrderForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                LogoOrderItem order = new LogoOrderItem(logoCheckBox.Checked, textToEngraveTextBox.Text);

                //check and set itemType
                //NOTE TO GLENN:  left in the original code in these if statements, as i like them better, but they led
                //to strange behavior in the summary results string.  This way works better all around


                if (usbRadioButton.Checked)
                {
                    // order.ItemType = usbRadioButton.Text;
                    order.ItemType = "USB stick";
                }
                else if (mugRadioButton.Checked)
                {
                    //order.ItemType = mugRadioButton.Text;
                    order.ItemType = "mug";
                }
                else if (penRadioButton.Checked)
                {
                    //order.ItemType = penRadioButton.Text;
                    order.ItemType = "pen";
                }

                //set NumColors
                if (logoCheckBox.Checked)  //if logo is checked
                {
                    order.NumColors = Convert.ToInt32(numberOfColorsTextBox.Text);  //set colors
                }
                else
                {
                    order.NumColors = 0;  //no logo means no colors
                }

                //set NumItems
                order.NumItems = Convert.ToInt32(numberOfItemsTextBox.Text);

                //set ItemID
                order.ItemID = 1;  //was this supposed to be used somewhere?  set and forget

                //set OrderID
                order.OrderID = Convert.ToInt32(orderNumberTextBox.Text);

                //Set Results
                resultTextBox.Text = order.GetOrderSummary();
            }
            catch (Exception exc)
            {
                resultTextBox.Text = "ERROR!!!!\r\n"+exc.Message;
               
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            numberOfColorsTextBox.Text = "";
            logoCheckBox.Checked = false;
            textToEngraveTextBox.Text = "";
            mugRadioButton.Checked = true;
            numberOfItemsTextBox.Text = "";
            orderNumberTextBox.Text = "";
        }

        private void logoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            numberOfColorsLabel.Visible = logoCheckBox.Checked;
            numberOfColorsTextBox.Visible = logoCheckBox.Checked;
            if (logoCheckBox.Checked)  //if there is a logo it must have at least one color
            {
                numberOfColorsTextBox.Text = "1";
            }
        }
    }
}
