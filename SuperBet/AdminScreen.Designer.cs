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
            checkedListBox1 = new CheckedListBox();
            fontDialog1 = new FontDialog();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            betName = new Label();
            addOddBtn = new Button();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(82, 52);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(274, 764);
            checkedListBox1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1094, 37);
            label3.Name = "label3";
            label3.Size = new Size(206, 46);
            label3.TabIndex = 18;
            label3.Text = "Dátum akcie";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1391, 35);
            label2.Name = "label2";
            label2.Size = new Size(86, 46);
            label2.TabIndex = 17;
            label2.Text = "Kurz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(377, 105);
            label1.Name = "label1";
            label1.Size = new Size(69, 31);
            label1.TabIndex = 16;
            label1.Text = "Popis";
            label1.Click += label1_Click;
            // 
            // betName
            // 
            betName.AutoSize = true;
            betName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            betName.Location = new Point(377, 37);
            betName.Name = "betName";
            betName.Size = new Size(100, 54);
            betName.TabIndex = 15;
            betName.Text = "TItle";
            // 
            // addOddBtn
            // 
            addOddBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addOddBtn.Location = new Point(1367, 189);
            addOddBtn.Name = "addOddBtn";
            addOddBtn.Size = new Size(142, 65);
            addOddBtn.TabIndex = 13;
            addOddBtn.Text = "Vytvoriť";
            addOddBtn.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(377, 260);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1132, 562);
            listBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(512, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 27);
            textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(377, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(446, 27);
            textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1367, 111);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(142, 27);
            textBox4.TabIndex = 22;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1068, 109);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(betName);
            Controls.Add(addOddBtn);
            Controls.Add(listBox1);
            Name = "AdminScreen";
            Text = "AdminScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private FontDialog fontDialog1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label betName;
        private TextBox textBox1;
        private Button addOddBtn;
        private ListBox listBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
    }
}