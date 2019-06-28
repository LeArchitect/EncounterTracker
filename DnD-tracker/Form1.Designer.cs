namespace DnD_tracker
{
    partial class Form1
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.addButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.chaBox = new System.Windows.Forms.TextBox();
            this.iniBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderList = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.effectList = new System.Windows.Forms.ListBox();
            this.effectTimeList = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.durationBox = new System.Windows.Forms.TextBox();
            this.effectBox = new System.Windows.Forms.TextBox();
            this.addEffectButton = new System.Windows.Forms.Button();
            this.hourBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.secBox = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.durButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(295, 449);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(186, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here to Find Emergency Kitsune!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(246, 392);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 28);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add Character";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(430, 392);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(97, 28);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start Encounter";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // chaBox
            // 
            this.chaBox.Location = new System.Drawing.Point(242, 356);
            this.chaBox.Name = "chaBox";
            this.chaBox.Size = new System.Drawing.Size(100, 20);
            this.chaBox.TabIndex = 6;
            this.chaBox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.chaBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChaBox_MouseDown);
            // 
            // iniBox
            // 
            this.iniBox.Location = new System.Drawing.Point(430, 356);
            this.iniBox.Name = "iniBox";
            this.iniBox.Size = new System.Drawing.Size(100, 20);
            this.iniBox.TabIndex = 7;
            this.iniBox.Click += new System.EventHandler(this.IniBox_Click);
            this.iniBox.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 323);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Character";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Initiative";
            // 
            // orderList
            // 
            this.orderList.FormattingEnabled = true;
            this.orderList.Location = new System.Drawing.Point(308, 115);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(164, 147);
            this.orderList.TabIndex = 10;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(759, 449);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(57, 21);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 22;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "It is this character\'s turn:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(687, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "0";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(660, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Round Nr:";
            this.label6.Visible = false;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(477, 392);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(97, 28);
            this.stopButton.TabIndex = 26;
            this.stopButton.Text = "Stop Encounter";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(347, 392);
            this.nextButton.Margin = new System.Windows.Forms.Padding(2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(97, 28);
            this.nextButton.TabIndex = 25;
            this.nextButton.Text = "Next Turn";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.Button5_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(650, 449);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 21);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete Selected";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(285, 294);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 18);
            this.label7.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(687, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "0 S";
            this.label8.Visible = false;
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(617, 233);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "Encounter has lasted:";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 36);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "Effects in play:";
            this.label10.Visible = false;
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // effectList
            // 
            this.effectList.FormattingEnabled = true;
            this.effectList.Location = new System.Drawing.Point(27, 112);
            this.effectList.Name = "effectList";
            this.effectList.Size = new System.Drawing.Size(110, 147);
            this.effectList.TabIndex = 32;
            this.effectList.Visible = false;
            // 
            // effectTimeList
            // 
            this.effectTimeList.FormattingEnabled = true;
            this.effectTimeList.Location = new System.Drawing.Point(152, 112);
            this.effectTimeList.Name = "effectTimeList";
            this.effectTimeList.Size = new System.Drawing.Size(40, 147);
            this.effectTimeList.TabIndex = 33;
            this.effectTimeList.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(451, 323);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 18);
            this.label11.TabIndex = 35;
            this.label11.Text = "Duration";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(267, 323);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 18);
            this.label12.TabIndex = 34;
            this.label12.Text = "Effect";
            this.label12.Visible = false;
            // 
            // durationBox
            // 
            this.durationBox.Location = new System.Drawing.Point(430, 356);
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(100, 20);
            this.durationBox.TabIndex = 37;
            this.durationBox.Visible = false;
            // 
            // effectBox
            // 
            this.effectBox.Location = new System.Drawing.Point(242, 356);
            this.effectBox.Name = "effectBox";
            this.effectBox.Size = new System.Drawing.Size(100, 20);
            this.effectBox.TabIndex = 36;
            this.effectBox.Visible = false;
            // 
            // addEffectButton
            // 
            this.addEffectButton.Location = new System.Drawing.Point(216, 392);
            this.addEffectButton.Margin = new System.Windows.Forms.Padding(2);
            this.addEffectButton.Name = "addEffectButton";
            this.addEffectButton.Size = new System.Drawing.Size(97, 28);
            this.addEffectButton.TabIndex = 38;
            this.addEffectButton.Text = "Add Effect";
            this.addEffectButton.UseVisualStyleBackColor = true;
            this.addEffectButton.Visible = false;
            this.addEffectButton.Click += new System.EventHandler(this.AddEffectButton_Click);
            // 
            // hourBox
            // 
            this.hourBox.Location = new System.Drawing.Point(107, 349);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(56, 20);
            this.hourBox.TabIndex = 39;
            this.hourBox.Visible = false;
            // 
            // minBox
            // 
            this.minBox.Location = new System.Drawing.Point(107, 375);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(56, 20);
            this.minBox.TabIndex = 40;
            this.minBox.Visible = false;
            // 
            // secBox
            // 
            this.secBox.Location = new System.Drawing.Point(107, 401);
            this.secBox.Name = "secBox";
            this.secBox.Size = new System.Drawing.Size(56, 20);
            this.secBox.TabIndex = 41;
            this.secBox.Visible = false;
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(107, 427);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(85, 20);
            this.totalBox.TabIndex = 42;
            this.totalBox.Visible = false;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(27, 450);
            this.calcButton.Margin = new System.Windows.Forms.Padding(2);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(61, 20);
            this.calcButton.TabIndex = 43;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Visible = false;
            this.calcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 303);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 18);
            this.label13.TabIndex = 44;
            this.label13.Text = "Duration Converter:";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 348);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 18);
            this.label14.TabIndex = 45;
            this.label14.Text = "Hours:";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 377);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 18);
            this.label15.TabIndex = 46;
            this.label15.Text = "Minutes:";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(24, 401);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 18);
            this.label16.TabIndex = 47;
            this.label16.Text = "Seconds:";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 427);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 18);
            this.label17.TabIndex = 48;
            this.label17.Text = "Total:";
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(272, 38);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(255, 33);
            this.label18.TabIndex = 49;
            this.label18.Text = "Encounter Tracker";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(295, 265);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(187, 15);
            this.label19.TabIndex = 50;
            this.label19.Text = "Tips: Write Natural 20 as \"Nat 20\"";
            // 
            // durButton
            // 
            this.durButton.Location = new System.Drawing.Point(107, 450);
            this.durButton.Margin = new System.Windows.Forms.Padding(2);
            this.durButton.Name = "durButton";
            this.durButton.Size = new System.Drawing.Size(61, 20);
            this.durButton.TabIndex = 51;
            this.durButton.Text = "Duration";
            this.durButton.UseVisualStyleBackColor = true;
            this.durButton.Visible = false;
            this.durButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 481);
            this.Controls.Add(this.durButton);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.secBox);
            this.Controls.Add(this.minBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.addEffectButton);
            this.Controls.Add(this.durationBox);
            this.Controls.Add(this.effectBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.effectTimeList);
            this.Controls.Add(this.effectList);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.orderList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iniBox);
            this.Controls.Add(this.chaBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.linkLabel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.Button addButton;
        public System.Windows.Forms.Button startButton;
        public System.Windows.Forms.TextBox chaBox;
        public System.Windows.Forms.TextBox iniBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox orderList;
        public System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button nextButton;
        public System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ListBox effectList;
        public System.Windows.Forms.ListBox effectTimeList;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox durationBox;
        public System.Windows.Forms.TextBox effectBox;
        public System.Windows.Forms.Button addEffectButton;
        public System.Windows.Forms.TextBox hourBox;
        public System.Windows.Forms.TextBox minBox;
        public System.Windows.Forms.TextBox secBox;
        public System.Windows.Forms.TextBox totalBox;
        public System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Button durButton;
    }
}

