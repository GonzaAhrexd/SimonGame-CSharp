using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;

namespace Simon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new RoundButton();
            button2 = new RoundButton();
            button3 = new RoundButton();
            button4 = new RoundButton();
            timer1 = new System.Windows.Forms.Timer(components);
            button6 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(233, 106);
            button1.Name = "button1";
            button1.Size = new Size(164, 99);
            button1.TabIndex = 0;
            button1.Text = " ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.Cursor = Cursors.Hand;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(55, 215);
            button2.Name = "button2";
            button2.Size = new Size(164, 99);
            button2.TabIndex = 1;
            button2.Text = " ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.Cursor = Cursors.Hand;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(233, 330);
            button3.Name = "button3";
            button3.Size = new Size(164, 99);
            button3.TabIndex = 2;
            button3.Text = " ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.Cursor = Cursors.Hand;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGreen;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(406, 215);
            button4.Name = "button4";
            button4.Size = new Size(164, 99);
            button4.TabIndex = 3;
            button4.Text = " ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            button4.Cursor = Cursors.Hand;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button6
            // 
            button6.BackColor = Color.LightGray;
            button6.Location = new Point(203, 452);
            button6.Name = "button6";
            button6.Size = new Size(230, 51);
            button6.TabIndex = 6;
            button6.Text = "Iniciar juego";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            button6.Cursor = Cursors.Hand;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 34);
            textBox1.TabIndex = 7;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(267, 239);
            label1.Name = "label1";
            label1.Size = new Size(102, 37);
            label1.TabIndex = 8;
            label1.Text = "SIMON";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(628, 515);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
          
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer timer1;
        private Button button6;
        private TextBox textBox1;
        private Label label1;
    }
}
