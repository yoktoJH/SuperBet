namespace SuperBet
{
    partial class ProfileScreen
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(26, 75);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(720, 717);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(135, 46);
            label1.TabIndex = 1;
            label1.Text = "História";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1162, 26);
            label2.Name = "label2";
            label2.Size = new Size(199, 46);
            label2.TabIndex = 2;
            label2.Text = "Celkový zisk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1197, 97);
            label3.Name = "label3";
            label3.Size = new Size(109, 46);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1441, 64);
            button2.Name = "button2";
            button2.Size = new Size(129, 46);
            button2.TabIndex = 12;
            button2.Text = "Späť";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoEllipsis = true;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(781, 97);
            label4.MaximumSize = new Size(200, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 38);
            label4.TabIndex = 14;
            label4.Text = "opis";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(781, 26);
            label5.Name = "label5";
            label5.Size = new Size(107, 46);
            label5.TabIndex = 13;
            label5.Text = "názov";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1441, 12);
            button1.Name = "button1";
            button1.Size = new Size(129, 46);
            button1.TabIndex = 15;
            button1.Text = "Odhlásiť sa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1.25F;
            formsPlot1.Location = new Point(799, 306);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(733, 486);
            formsPlot1.TabIndex = 16;
            // 
            // ProfileScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(formsPlot1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "ProfileScreen";
            Text = "ProfileScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private Label label5;
        private Button button1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}