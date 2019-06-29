namespace DnD_tracker
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chaList = new System.Windows.Forms.ListBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.dmgBox = new System.Windows.Forms.TextBox();
            this.dmgLabel = new System.Windows.Forms.Label();
            this.maxHpList = new System.Windows.Forms.ListBox();
            this.hpLeftList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chaList
            // 
            this.chaList.FormattingEnabled = true;
            this.chaList.Location = new System.Drawing.Point(628, 38);
            this.chaList.Name = "chaList";
            this.chaList.Size = new System.Drawing.Size(160, 394);
            this.chaList.TabIndex = 0;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(32, 79);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(75, 23);
            this.acceptButton.TabIndex = 2;
            this.acceptButton.Text = "Hit/Heal";
            this.acceptButton.UseCompatibleTextRendering = true;
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // dmgBox
            // 
            this.dmgBox.Location = new System.Drawing.Point(22, 53);
            this.dmgBox.Name = "dmgBox";
            this.dmgBox.Size = new System.Drawing.Size(100, 20);
            this.dmgBox.TabIndex = 3;
            // 
            // dmgLabel
            // 
            this.dmgLabel.AutoSize = true;
            this.dmgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dmgLabel.Location = new System.Drawing.Point(24, 20);
            this.dmgLabel.Name = "dmgLabel";
            this.dmgLabel.Size = new System.Drawing.Size(98, 18);
            this.dmgLabel.TabIndex = 7;
            this.dmgLabel.Text = "Damage/Heal";
            // 
            // maxHpList
            // 
            this.maxHpList.FormattingEnabled = true;
            this.maxHpList.Location = new System.Drawing.Point(745, 38);
            this.maxHpList.Name = "maxHpList";
            this.maxHpList.Size = new System.Drawing.Size(29, 394);
            this.maxHpList.TabIndex = 8;
            this.maxHpList.Visible = false;
            // 
            // hpLeftList
            // 
            this.hpLeftList.FormattingEnabled = true;
            this.hpLeftList.Location = new System.Drawing.Point(724, 38);
            this.hpLeftList.Name = "hpLeftList";
            this.hpLeftList.Size = new System.Drawing.Size(29, 394);
            this.hpLeftList.TabIndex = 9;
            this.hpLeftList.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "-5 to Dmg. 5 to Heal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(670, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Character";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Success";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Condition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Fail";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hpLeftList);
            this.Controls.Add(this.maxHpList);
            this.Controls.Add(this.dmgLabel);
            this.Controls.Add(this.dmgBox);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.chaList);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.TextBox dmgBox;
        private System.Windows.Forms.Label dmgLabel;
        public System.Windows.Forms.ListBox chaList;
        public System.Windows.Forms.ListBox maxHpList;
        public System.Windows.Forms.ListBox hpLeftList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}