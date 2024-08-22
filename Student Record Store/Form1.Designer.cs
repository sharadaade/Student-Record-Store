
namespace Student_Record_Store
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
            if (disposing && (components != null))
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            div = new TextBox();
            name = new TextBox();
            mobno = new TextBox();
            email = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(107, 89);
            label2.Name = "label2";
            label2.Size = new Size(194, 26);
            label2.TabIndex = 1;
            label2.Text = "Student Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 139);
            label3.Name = "label3";
            label3.Size = new Size(77, 26);
            label3.TabIndex = 2;
            label3.Text = "Div :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("JetBrains Mono Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(107, 189);
            label4.Name = "label4";
            label4.Size = new Size(142, 26);
            label4.TabIndex = 3;
            label4.Text = "Mob. No. :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(107, 239);
            label5.Name = "label5";
            label5.Size = new Size(103, 26);
            label5.TabIndex = 4;
            label5.Text = "Email :";
            // 
            // div
            // 
            div.Location = new Point(319, 138);
            div.Name = "div";
            div.Size = new Size(319, 27);
            div.TabIndex = 6;
            div.TextChanged += textBox2_TextChanged;
            // 
            // name
            // 
            name.Location = new Point(319, 88);
            name.Name = "name";
            name.Size = new Size(319, 27);
            name.TabIndex = 7;
            name.TextChanged += textBox3_TextChanged;
            // 
            // mobno
            // 
            mobno.Location = new Point(319, 190);
            mobno.Name = "mobno";
            mobno.Size = new Size(319, 27);
            mobno.TabIndex = 8;
            mobno.TextChanged += textBox4_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(319, 238);
            email.Name = "email";
            email.Size = new Size(319, 27);
            email.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.OliveDrab;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(262, 307);
            button1.Name = "button1";
            button1.Size = new Size(119, 54);
            button1.TabIndex = 10;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(498, 307);
            button2.Name = "button2";
            button2.Size = new Size(119, 54);
            button2.TabIndex = 11;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 504);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(email);
            Controls.Add(mobno);
            Controls.Add(name);
            Controls.Add(div);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

#endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox div;
        private TextBox name;
        private TextBox mobno;
        private TextBox email;
        private Button button1;
        private Button button2;
    }
}
