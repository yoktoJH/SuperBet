namespace SuperBet
{
    partial class RegisterScreen
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
            checkBox1 = new CheckBox();
            label1 = new Label();
            surnameBox = new TextBox();
            nameBox = new TextBox();
            emailBox = new TextBox();
            passwordBox = new TextBox();
            controlBox = new TextBox();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            dateTimePicker1 = new DateTimePicker();
            progressBar1 = new ProgressBar();
            label14 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(35, 463);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(440, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Súhlasím s všeobecnými pravidlami a podmienkami SuperBET";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(210, 24);
            label1.Name = "label1";
            label1.Size = new Size(265, 67);
            label1.TabIndex = 1;
            label1.Text = "Registrácia";
            label1.Click += label1_Click;
            // 
            // surnameBox
            // 
            surnameBox.Location = new Point(97, 191);
            surnameBox.Name = "surnameBox";
            surnameBox.Size = new Size(263, 27);
            surnameBox.TabIndex = 3;
            surnameBox.TextChanged += surnameBox_TextChanged;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(98, 138);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(263, 27);
            nameBox.TabIndex = 4;
            nameBox.TextChanged += nameBox_TextChanged;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(97, 244);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(263, 27);
            emailBox.TabIndex = 5;
            emailBox.TextChanged += emailBox_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(97, 350);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(263, 27);
            passwordBox.TabIndex = 6;
            passwordBox.UseSystemPasswordChar = true;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // controlBox
            // 
            controlBox.Location = new Point(97, 403);
            controlBox.Name = "controlBox";
            controlBox.Size = new Size(263, 27);
            controlBox.TabIndex = 7;
            controlBox.UseSystemPasswordChar = true;
            controlBox.TextChanged += controlBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 115);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 10;
            label2.Text = "Meno";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13F);
            button3.Location = new Point(435, 567);
            button3.Name = "button3";
            button3.Size = new Size(147, 54);
            button3.TabIndex = 11;
            button3.Text = "Prihlásenie";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 13F);
            button4.Location = new Point(71, 567);
            button4.Name = "button4";
            button4.Size = new Size(204, 54);
            button4.TabIndex = 12;
            button4.Text = "Zaregistrovať sa";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 168);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 13;
            label3.Text = "Priezvisko";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 221);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 14;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(97, 274);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 15;
            label5.Text = "Dátum narodenia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 327);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 16;
            label6.Text = "Heslo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(97, 380);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 17;
            label7.Text = "Kontrola hesla";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(368, 300);
            label8.Name = "label8";
            label8.Size = new Size(0, 20);
            label8.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(366, 247);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(366, 194);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 20;
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(367, 141);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(366, 353);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(366, 406);
            label13.Name = "label13";
            label13.Size = new Size(0, 20);
            label13.TabIndex = 23;
            label13.Click += label13_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(97, 300);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(263, 27);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(350, 516);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(232, 29);
            progressBar1.TabIndex = 25;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(118, 516);
            label14.Name = "label14";
            label14.Size = new Size(183, 28);
            label14.TabIndex = 26;
            label14.Text = "Prebieha registrácia";
            label14.Visible = false;
            label14.Click += label14_Click;
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 697);
            Controls.Add(label14);
            Controls.Add(progressBar1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(controlBox);
            Controls.Add(passwordBox);
            Controls.Add(emailBox);
            Controls.Add(nameBox);
            Controls.Add(surnameBox);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Name = "RegisterScreen";
            Text = "RegisterScreen";
            Load += RegisterScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private Label label1;
        private TextBox surnameBox;
        private TextBox nameBox;
        private TextBox emailBox;
        private TextBox passwordBox;
        private TextBox controlBox;
        private Label label2;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DateTimePicker dateTimePicker1;
        private ProgressBar progressBar1;
        private Label label14;
    }
}