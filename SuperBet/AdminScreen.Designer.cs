namespace SuperBet
{
    partial class AdminScreen
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
            fontDialog1 = new FontDialog();
            button3 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            label2 = new Label();
            oddRateTB = new TextBox();
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(1236, 63);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(113, 34);
            button3.TabIndex = 23;
            button3.Text = "Štatistika";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(329, 247);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(978, 354);
            listBox1.TabIndex = 22;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1236, 24);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(113, 34);
            button2.TabIndex = 21;
            button2.Text = "Odhlásiť sa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(424, 36);
            label2.Name = "label2";
            label2.Size = new Size(82, 45);
            label2.TabIndex = 19;
            label2.Text = "Kurz";
            // 
            // oddRateTB
            // 
            oddRateTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            oddRateTB.Location = new Point(424, 92);
            oddRateTB.Margin = new Padding(3, 2, 3, 2);
            oddRateTB.Name = "oddRateTB";
            oddRateTB.Size = new Size(112, 33);
            oddRateTB.TabIndex = 16;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1023, 76);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(124, 49);
            button1.TabIndex = 15;
            button1.Text = "Vytvoriť";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(35, 241);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(240, 376);
            checkedListBox1.TabIndex = 14;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(21, 37);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Názov";
            textBox2.Size = new Size(245, 46);
            textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(21, 92);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Popis";
            textBox3.Size = new Size(369, 33);
            textBox3.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(574, 38);
            label3.Name = "label3";
            label3.Size = new Size(115, 45);
            label3.TabIndex = 26;
            label3.Text = "Dátum";
            label3.Click += label3_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(574, 92);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 33);
            dateTimePicker1.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(808, 36);
            label4.Name = "label4";
            label4.Size = new Size(156, 45);
            label4.TabIndex = 28;
            label4.Text = "Kategória";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(808, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 33);
            comboBox1.TabIndex = 29;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(1023, 194);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(124, 49);
            button4.TabIndex = 30;
            button4.Text = "Výhra";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(1172, 194);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(124, 49);
            button5.TabIndex = 31;
            button5.Text = "Prehra";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 640);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(oddRateTB);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminScreen";
            Text = "AdminScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontDialog fontDialog1;
        private Label label4;
        private TextBox textBox1;
        private Button button3;
        private ListBox listBox1;
        private Button button2;
        private Label label2;
        private TextBox oddRateTB;
        private Button button1;
        private CheckedListBox checkedListBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button button4;
        private Button button5;
        public ComboBox comboBox1;
    }
}