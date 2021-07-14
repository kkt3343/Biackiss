
namespace 비아키스
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.R1 = new System.Windows.Forms.RadioButton();
            this.R2 = new System.Windows.Forms.RadioButton();
            this.R3 = new System.Windows.Forms.RadioButton();
            this.redbutton = new System.Windows.Forms.Button();
            this.blackbutton = new System.Windows.Forms.Button();
            this.mytext = new System.Windows.Forms.Label();
            this.copy = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.fin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.a1 = new System.Windows.Forms.RadioButton();
            this.a2 = new System.Windows.Forms.RadioButton();
            this.a3 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.at = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // R1
            // 
            this.R1.AutoSize = true;
            this.R1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R1.Location = new System.Drawing.Point(16, 17);
            this.R1.Name = "R1";
            this.R1.Size = new System.Drawing.Size(62, 25);
            this.R1.TabIndex = 0;
            this.R1.TabStop = true;
            this.R1.Text = "11시";
            this.R1.UseVisualStyleBackColor = true;
            this.R1.CheckedChanged += new System.EventHandler(this.R1_CheckedChanged);
            // 
            // R2
            // 
            this.R2.AutoSize = true;
            this.R2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R2.Location = new System.Drawing.Point(117, 17);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(53, 25);
            this.R2.TabIndex = 1;
            this.R2.TabStop = true;
            this.R2.Text = "5시";
            this.R2.UseVisualStyleBackColor = true;
            this.R2.CheckedChanged += new System.EventHandler(this.R2_CheckedChanged);
            // 
            // R3
            // 
            this.R3.AutoSize = true;
            this.R3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.R3.Location = new System.Drawing.Point(218, 17);
            this.R3.Name = "R3";
            this.R3.Size = new System.Drawing.Size(53, 25);
            this.R3.TabIndex = 2;
            this.R3.TabStop = true;
            this.R3.Text = "7시";
            this.R3.UseVisualStyleBackColor = true;
            this.R3.CheckedChanged += new System.EventHandler(this.R3_CheckedChanged);
            // 
            // redbutton
            // 
            this.redbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.redbutton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.redbutton.ForeColor = System.Drawing.Color.Black;
            this.redbutton.Location = new System.Drawing.Point(16, 60);
            this.redbutton.Name = "redbutton";
            this.redbutton.Size = new System.Drawing.Size(111, 48);
            this.redbutton.TabIndex = 3;
            this.redbutton.Text = "빨강(안먹는 것)";
            this.redbutton.UseVisualStyleBackColor = false;
            this.redbutton.Click += new System.EventHandler(this.redbutton_Click);
            // 
            // blackbutton
            // 
            this.blackbutton.BackColor = System.Drawing.Color.Black;
            this.blackbutton.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.blackbutton.ForeColor = System.Drawing.Color.White;
            this.blackbutton.Location = new System.Drawing.Point(155, 60);
            this.blackbutton.Name = "blackbutton";
            this.blackbutton.Size = new System.Drawing.Size(107, 48);
            this.blackbutton.TabIndex = 4;
            this.blackbutton.Text = "검정(먹는 것)";
            this.blackbutton.UseVisualStyleBackColor = false;
            this.blackbutton.Click += new System.EventHandler(this.blackbutton_Click);
            // 
            // mytext
            // 
            this.mytext.AutoSize = true;
            this.mytext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mytext.Font = new System.Drawing.Font("함초롬돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mytext.Location = new System.Drawing.Point(19, 127);
            this.mytext.Name = "mytext";
            this.mytext.Size = new System.Drawing.Size(67, 35);
            this.mytext.TabIndex = 5;
            this.mytext.Text = "없음";
            // 
            // copy
            // 
            this.copy.Font = new System.Drawing.Font("210 어른동화 R", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copy.Location = new System.Drawing.Point(16, 176);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(246, 47);
            this.copy.TabIndex = 6;
            this.copy.Text = "복사하기";
            this.copy.UseVisualStyleBackColor = true;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("210 어른동화 R", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reset.Location = new System.Drawing.Point(16, 238);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(246, 47);
            this.reset.TabIndex = 7;
            this.reset.Text = "초기화";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // fin
            // 
            this.fin.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fin.Location = new System.Drawing.Point(16, 302);
            this.fin.Name = "fin";
            this.fin.Size = new System.Drawing.Size(246, 47);
            this.fin.TabIndex = 8;
            this.fin.Text = "끝내기";
            this.fin.UseVisualStyleBackColor = true;
            this.fin.Click += new System.EventHandler(this.fin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(277, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 454);
            this.panel1.TabIndex = 9;
            // 
            // a1
            // 
            this.a1.AutoSize = true;
            this.a1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a1.Location = new System.Drawing.Point(12, 12);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(62, 25);
            this.a1.TabIndex = 10;
            this.a1.TabStop = true;
            this.a1.Text = "11시";
            this.a1.UseVisualStyleBackColor = true;
            this.a1.CheckedChanged += new System.EventHandler(this.a1_CheckedChanged);
            // 
            // a2
            // 
            this.a2.AutoSize = true;
            this.a2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a2.Location = new System.Drawing.Point(103, 12);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(53, 25);
            this.a2.TabIndex = 11;
            this.a2.TabStop = true;
            this.a2.Text = "3시";
            this.a2.UseVisualStyleBackColor = true;
            this.a2.CheckedChanged += new System.EventHandler(this.a2_CheckedChanged);
            // 
            // a3
            // 
            this.a3.AutoSize = true;
            this.a3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.a3.Location = new System.Drawing.Point(179, 12);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(53, 25);
            this.a3.TabIndex = 12;
            this.a3.TabStop = true;
            this.a3.Text = "7시";
            this.a3.UseVisualStyleBackColor = true;
            this.a3.CheckedChanged += new System.EventHandler(this.a3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::비아키스.Properties.Resources.반접;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(5, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 72);
            this.button1.TabIndex = 13;
            this.button1.Text = "반접";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::비아키스.Properties.Resources.접;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(88, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 72);
            this.button2.TabIndex = 14;
            this.button2.Text = "접";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::비아키스.Properties.Resources.폄;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(174, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 72);
            this.button3.TabIndex = 15;
            this.button3.Text = "핌";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // at
            // 
            this.at.AutoSize = true;
            this.at.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.at.Font = new System.Drawing.Font("함초롬돋움", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.at.Location = new System.Drawing.Point(5, 139);
            this.at.Name = "at";
            this.at.Size = new System.Drawing.Size(67, 35);
            this.at.TabIndex = 16;
            this.at.Text = "없음";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("210 어른동화 R", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(5, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 47);
            this.button4.TabIndex = 17;
            this.button4.Text = "복사하기";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.at);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.a3);
            this.panel2.Controls.Add(this.a2);
            this.panel2.Controls.Add(this.a1);
            this.panel2.Location = new System.Drawing.Point(293, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 439);
            this.panel2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(72, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 30);
            this.label9.TabIndex = 23;
            this.label9.Text = "검";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(20, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 30);
            this.label8.TabIndex = 22;
            this.label8.Text = "흰";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(126, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "빨 핀";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(72, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "보 접";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "빨간색 많으면 핀곳으로";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "보라색 많으면 접힌곳으로";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(155, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "빨";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(211, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "파";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(263, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 30);
            this.label7.TabIndex = 21;
            this.label7.Text = "초";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fin);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.mytext);
            this.Controls.Add(this.blackbutton);
            this.Controls.Add(this.redbutton);
            this.Controls.Add(this.R3);
            this.Controls.Add(this.R2);
            this.Controls.Add(this.R1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "비아키스도우미";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton R1;
        private System.Windows.Forms.RadioButton R2;
        private System.Windows.Forms.RadioButton R3;
        private System.Windows.Forms.Button redbutton;
        private System.Windows.Forms.Button blackbutton;
        private System.Windows.Forms.Label mytext;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button fin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton a1;
        private System.Windows.Forms.RadioButton a2;
        private System.Windows.Forms.RadioButton a3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label at;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

