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
        public int i,j = 0;

        Form2 newForm = null;

        public Form1()
        {
            InitializeComponent();
            orderList.Sorted = true;
            newForm = new Form2();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("https://i.ytimg.com/vi/2KqIjH6FFNM/maxresdefault.jpg");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.ResetText();
            if (iniBox.Text.Length <= 0  || chaBox.Text.Length <= 0 || hpBox.Text.Length <= 0 || iniBox.Text == null || chaBox.Text == null || hpBox.Text == null)
            {
                label7.Text = "One or both boxes are empty";
            }
            else
            {
                orderList.Items.Add(iniBox.Text + "          " + chaBox.Text);
                newForm.chaList.Items.Add(chaBox.Text);
                newForm.maxHpList.Items.Add(hpBox.Text);
                newForm.hpLeftList.Items.Add(hpBox.Text);

                ComboBox comboBox = new ComboBox();
                comboBox.Location = new Point(210, 38 + j * 21);
                comboBox.Size = new Size(121, 21);
                comboBox.Items.Add(" ");
                comboBox.Items.Add("Blinded");
                comboBox.Items.Add("Charmed");
                comboBox.Items.Add("Deafened");
                comboBox.Items.Add("Fatigued");
                comboBox.Items.Add("Frightened");
                comboBox.Items.Add("Grappled");
                comboBox.Items.Add("Incapacitated");
                comboBox.Items.Add("Invisible");
                comboBox.Items.Add("Paralysed");
                comboBox.Items.Add("Petrified");
                comboBox.Items.Add("Prone");
                comboBox.Items.Add("Restrained");
                comboBox.Items.Add("Stunned");
                comboBox.Items.Add("Unconcious");
                comboBox.Items.Add("Exhausted");
                comboBox.Items.Add("Dead");

                CheckBox deadCheck1 = new CheckBox();
                deadCheck1.Location = new Point(350, 39 + j * 15);
                deadCheck1.Size = new Size(15, 15);

                CheckBox deadCheck2 = new CheckBox();
                deadCheck2.Location = new Point(365, 39 + j * 15);
                deadCheck2.Size = new Size(15, 15);

                CheckBox deadCheck3 = new CheckBox();
                deadCheck3.Location = new Point(380, 39 + j * 15);
                deadCheck3.Size = new Size(15, 15);

                CheckBox deadCheck4 = new CheckBox();
                deadCheck4.Location = new Point(415, 39 + j * 15);
                deadCheck4.Size = new Size(15, 15);

                CheckBox deadCheck5 = new CheckBox();
                deadCheck5.Location = new Point(430, 39 + j * 15);
                deadCheck5.Size = new Size(15, 15);

                CheckBox deadCheck6 = new CheckBox();
                deadCheck6.Location = new Point(445, 39 + j * 15);
                deadCheck6.Size = new Size(15, 15);

                Label hpLabel = new Label();
                hpLabel.Name = ("hpLabel" + j).ToString();
                hpLabel.Location = new Point(480, 39 + j * 15);
                hpLabel.Size = new Size(44, 15);
                hpLabel.Text = hpBox.Text + "/" + hpBox.Text;

                ProgressBar hpProgress = new ProgressBar();
                hpProgress.Name = ("hpProgress" + j).ToString();
                hpProgress.Location = new Point(525, 39 + j * 15);
                hpProgress.Size = new Size(97, 15);
                hpProgress.Minimum = 0;
                hpProgress.Maximum = Convert.ToInt32(hpBox.Text);
                hpProgress.Value = Convert.ToInt32(hpBox.Text);

                newForm.Controls.Add(hpLabel);
                newForm.Controls.Add(hpProgress);
                newForm.Controls.Add(deadCheck6);
                newForm.Controls.Add(deadCheck5);
                newForm.Controls.Add(deadCheck4);
                newForm.Controls.Add(deadCheck3);
                newForm.Controls.Add(deadCheck2);
                newForm.Controls.Add(deadCheck1);
                newForm.Controls.Add(comboBox);
            }
            j++;
            iniBox.ResetText();
            chaBox.ResetText();
            hpBox.ResetText();
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
                durButton.Show();
                addEffectButton.Show();

                label1.Hide();
                label2.Hide();
                label18.Hide();
                maxHpLabel.Hide();
                iniBox.Hide();
                chaBox.Hide();
                hpBox.Hide();
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

                hourBox.Text = "0";
                minBox.Text = "0";
                secBox.Text = "0";
                if(newForm.Visible == true)
                    newForm = new Form2();
                else
                    newForm.Show();
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
            newForm.chaList.Items.Clear();
            newForm.maxHpList.Items.Clear();
            newForm.hpLeftList.Items.Clear();
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
            durButton.Hide();
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
            label18.Show();
            maxHpLabel.Show();
            iniBox.Show();
            chaBox.Show();
            hpBox.Show();
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
                orderList.Items.RemoveAt(orderList.SelectedIndex);
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
            try
            {
                totalBox.Text = (Convert.ToInt32(hourBox.Text) * 360 + Convert.ToInt32(minBox.Text) * 60 + Convert.ToInt32(secBox.Text)).ToString(); ;

                hourBox.Text = "0";
                minBox.Text = "0";
                secBox.Text = "0";
            }
            catch (Exception)
            {

            }
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (newForm.IsDisposed)
                    newForm = new Form2();
                if (newForm.Visible == true)
                {
                    newForm.Hide();
                    showButton.Text = "Show";
                }
                else
                {
                    newForm.Show();
                    showButton.Text = "Hide";
                }
            }
            catch
            {

            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            durationBox.Text = totalBox.Text;
        }
    }




}
