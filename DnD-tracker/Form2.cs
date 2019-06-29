using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_tracker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                int SelectedIndex = chaList.SelectedIndex;
                maxHpList.SetSelected(SelectedIndex, true);
                hpLeftList.SetSelected(SelectedIndex, true);
                int hpLeft = Convert.ToInt32(hpLeftList.SelectedItem) + Convert.ToInt32(dmgBox.Text);
                hpLeftList.Items.RemoveAt(SelectedIndex);
                hpLeftList.Items.Insert(SelectedIndex, hpLeft);
                int maxHp = Convert.ToInt32(maxHpList.SelectedItem);
                string nameLabel = ("hpLabel" + SelectedIndex).ToString();
                string nameBar = ("hpProgress" + SelectedIndex).ToString();
                foreach (Control ctrl in this.Controls)
                {
                    // Check if control is of type label
                    if (ctrl.GetType() == typeof(Label))
                    {
                        // check the name of the label
                        if (ctrl.Name == nameLabel)
                        {
                            ctrl.Text = (hpLeft + "/" + maxHp).ToString();
                        }
                    }
                }
                foreach (Control ctrl in this.Controls)
                {
                    // Check if control is of type bar
                    if (ctrl.GetType() == typeof(ProgressBar))
                    {
                        // check the name of the bar
                        if (ctrl.Name == nameBar)
                        {
                            string name = ctrl.Name;
                            ProgressBar hpProgress = new ProgressBar();
                            hpProgress.Location = new Point(525, 39 + SelectedIndex * 15);
                            hpProgress.Size = new Size(97, 15);
                            hpProgress.Minimum = 0;
                            hpProgress.Maximum = maxHp;
                            hpProgress.Name = name;
                            if (hpLeft >= maxHp)
                            {
                                hpProgress.Value = maxHp;
                            }
                            else if (hpLeft <= 0)
                            {
                                hpProgress.Value = 0;
                            }
                            else
                            {
                                hpProgress.Value = hpLeft;
                            }
                            Controls.Add(hpProgress);
                            ctrl.Hide();
                        }
                    }
                }
                maxHpList.SetSelected(SelectedIndex, false);
                hpLeftList.SetSelected(SelectedIndex, false);

                dmgBox.ResetText();
            }
            catch (Exception)
            {

            }
        }

        private void DomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
