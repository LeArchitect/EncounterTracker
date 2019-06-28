using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.



// To do: 
//You can still add empty char to list//You can't delete empty objects or the first object from the list
//Extra features:
//Automatic effect calculator and adder Done
//Add coherently more characters mid encounter
namespace DnD_tracker
{
    public partial class Form1 : Form
    {
        public int chaCount = 0;
        public int effectCount = 0;
        public int turnCount = 1;
        public int listCount = 0;
        public int encounterTime = 0;
        public int i = 0;

        public Form1()
        {
            InitializeComponent();
            orderList.Sorted = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("https://i.ytimg.com/vi/2KqIjH6FFNM/maxresdefault.jpg");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.ResetText();
            if (iniBox.Text == " " || chaBox.Text == " " || iniBox.Text == null || chaBox.Text == null)
            {
                label7.Text = "One or both boxes are empty";
            }
            else
            {
                string init = iniBox.Text;

                orderList.Items.Add(init + "          " + chaBox.Text);
            }
            iniBox.ResetText();
            chaBox.ResetText();
        }

        public void OrderList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                chaCount = orderList.Items.Count;
                listCount = chaCount - 1;
                orderList.SetSelected(listCount, true);
                string selectedItem = orderList.SelectedItem.ToString();
                selectedItem = selectedItem.Trim(new Char[] { ' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
                label3.Text = selectedItem;
                label8.Text = encounterTime + "S";
                label7.ResetText();

                deleteButton.Hide();
                clearButton.Hide();
                startButton.Hide();
                addButton.Hide();
                stopButton.Show();
                nextButton.Show();
                calcButton.Show();
                addEffectButton.Show();

                label1.Hide();
                label2.Hide();
                iniBox.Hide();
                chaBox.Hide();
                effectBox.Show();
                durationBox.Show();
                hourBox.Show();
                minBox.Show();
                secBox.Show();
                totalBox.Show();
                effectList.Show();
                effectTimeList.Show();

                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label8.Show();
                label9.Show();
                label10.Show();
                label11.Show();
                label12.Show();
                label13.Show();
                label14.Show();
                label15.Show();
                label16.Show();
                label17.Show();

                label5.Text = turnCount.ToString();

            }
            catch (Exception)
            {
                label7.Text = "There are irrelevant number of characters! Add more!";
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }


        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            orderList.Items.Clear();
            label7.ResetText();
            encounterTime = 0;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (listCount > 0)
            {
                orderList.SetSelected(listCount, false);
                listCount--;
                encounterTime += 6;
                orderList.SetSelected(listCount, true);
                string selectedItem = orderList.SelectedItem.ToString();
                selectedItem = selectedItem.Trim(new Char[] { ' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
                label3.Text = selectedItem;
                label8.Text = encounterTime + "S".ToString();
            }
            else
            {
                orderList.SetSelected(listCount, false);
                listCount = chaCount - 1;
                encounterTime += 6;
                orderList.SetSelected(listCount, true);
                string selectedItem = orderList.SelectedItem.ToString();
                selectedItem = selectedItem.Trim(new Char[] { ' ', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
                label3.Text = selectedItem;
                turnCount++;
                label8.Text = encounterTime + "S".ToString();
                label5.Text = turnCount.ToString();
            }
            i = effectCount; 
            while (i != 0)
            {
                try
                {
                    effectTimeList.SetSelected(i - 1, true);
                    int selectedItem = Convert.ToInt32(effectTimeList.SelectedItem) - 6;
                    if (selectedItem <= 0)
                    {
                        int SelectedIndex = effectTimeList.SelectedIndex;
                        effectTimeList.Items.RemoveAt(SelectedIndex);
                        effectList.Items.RemoveAt(SelectedIndex);
                    }
                    else
                    {
                        int SelectedIndex = effectTimeList.SelectedIndex;
                        effectTimeList.Items.RemoveAt(SelectedIndex);
                        effectTimeList.Items.Insert(SelectedIndex, selectedItem);
                    }
                    effectCount = effectTimeList.Items.Count;
                    i--;
                }
                catch (Exception)
                {

                }
            }

            label7.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            stopButton.Hide();
            nextButton.Hide();
            addEffectButton.Hide();
            calcButton.Hide();
            startButton.Show();
            addButton.Show();
            clearButton.Show();
            deleteButton.Show();

            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            label15.Hide();
            label16.Hide();
            label17.Hide();

            label7.ResetText();
            label5.ResetText();

            label1.Show();
            label2.Show();
            iniBox.Show();
            chaBox.Show();
            effectBox.Hide();
            durationBox.Hide();
            hourBox.Hide();
            minBox.Hide();
            secBox.Hide();
            totalBox.Hide();
            effectList.Hide();
            effectTimeList.Hide();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            label7.ResetText();
            try
            {
                int SelectedIndex = orderList.SelectedIndex;
                orderList.Items.RemoveAt(orderList.Items.IndexOf(orderList.SelectedIndex));
            }
            catch (Exception)
            {
                label7.Text = "No Character has been selected";
            }
        }

        private void ChaBox_MouseDown(object sender, MouseEventArgs e)
        {
            label7.ResetText();
        }

        private void IniBox_Click(object sender, EventArgs e)
        {
            label7.ResetText();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void AddEffectButton_Click(object sender, EventArgs e)
        {
            effectList.Items.Add(effectBox.Text);
            effectTimeList.Items.Add(durationBox.Text);
            effectCount = effectTimeList.Items.Count;
            effectBox.ResetText();
            durationBox.ResetText();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            totalBox.ResetText();
            totalBox.Text = (Convert.ToInt32(hourBox.Text) * 360 + Convert.ToInt32(minBox.Text) * 60 + Convert.ToInt32(secBox.Text)).ToString(); ;



            hourBox.ResetText();
            minBox.ResetText();
            secBox.ResetText();
        }
    }




}
