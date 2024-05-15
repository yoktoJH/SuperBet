namespace SuperBet
{
    partial class UserScreen
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
            button1 = new Button();
            betAmount = new TextBox();
            betName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(68, 54);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(274, 764);
            checkedListBox1.TabIndex = 2;
            checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;

            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1189, 181);
            button1.Name = "button1";
            button1.Size = new Size(142, 65);
            button1.TabIndex = 4;
            button1.Text = "Vsadiť";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // betAmount
            // 
            betAmount.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            betAmount.Location = new Point(1189, 107);
            betAmount.Name = "betAmount";
            betAmount.Size = new Size(142, 43);
            betAmount.TabIndex = 5;
            betAmount.TextChanged += betAmount_TextChanged;
            betAmount.KeyPress += betAmount_KeyPress;
            // 
            // betName
            // 
            betName.AutoSize = true;
            betName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            betName.Location = new Point(394, 35);
            betName.Name = "betName";
            betName.Size = new Size(100, 54);
            betName.TabIndex = 6;
            betName.Text = "TItle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(405, 107);
            label1.Name = "label1";
            label1.Size = new Size(129, 31);
            label1.TabIndex = 7;
            label1.Text = "description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(991, 35);
            label2.Name = "label2";
            label2.Size = new Size(86, 46);
            label2.TabIndex = 8;
            label2.Text = "Kurz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(991, 104);
            label3.Name = "label3";
            label3.Size = new Size(109, 46);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1208, 35);
            label4.Name = "label4";
            label4.Size = new Size(103, 46);
            label4.TabIndex = 10;
            label4.Text = "Vklad";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1441, 12);
            button2.Name = "button2";
            button2.Size = new Size(129, 46);
            button2.TabIndex = 11;
            button2.Text = "Odhlásiť sa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(405, 310);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1117, 500);
            listBox1.TabIndex = 12;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // UserScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(betName);
            Controls.Add(betAmount);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Name = "UserScreen";
            Text = "UserScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox checkedListBox1;
        private Button button1;
        private TextBox betAmount;
        private Label betName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private ListBox listBox1;
    }
}