
namespace Calculadora
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
            this.panelResult = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butNum0 = new System.Windows.Forms.Button();
            this.butNum1 = new System.Windows.Forms.Button();
            this.butNum2 = new System.Windows.Forms.Button();
            this.butNum3 = new System.Windows.Forms.Button();
            this.butNum4 = new System.Windows.Forms.Button();
            this.butNum5 = new System.Windows.Forms.Button();
            this.butNum6 = new System.Windows.Forms.Button();
            this.butNum9 = new System.Windows.Forms.Button();
            this.butNum8 = new System.Windows.Forms.Button();
            this.butNum7 = new System.Windows.Forms.Button();
            this.butValueDot = new System.Windows.Forms.Button();
            this.butValueEqual = new System.Windows.Forms.Button();
            this.butValuePlus = new System.Windows.Forms.Button();
            this.butValueMult = new System.Windows.Forms.Button();
            this.butValueMinus = new System.Windows.Forms.Button();
            this.butQuit = new System.Windows.Forms.Button();
            this.butValueDel = new System.Windows.Forms.Button();
            this.butValueDiv = new System.Windows.Forms.Button();
            this.panelResult.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResult.Controls.Add(this.panel2);
            this.panelResult.Controls.Add(this.panel1);
            this.panelResult.Location = new System.Drawing.Point(-2, -2);
            this.panelResult.Margin = new System.Windows.Forms.Padding(2);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(293, 66);
            this.panelResult.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.labelResult);
            this.panel2.Location = new System.Drawing.Point(10, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 40);
            this.panel2.TabIndex = 2;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(2, 8);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 30);
            this.labelResult.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 375);
            this.panel1.TabIndex = 1;
            // 
            // butNum0
            // 
            this.butNum0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNum0.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butNum0.FlatAppearance.BorderSize = 3;
            this.butNum0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNum0.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.butNum0.ForeColor = System.Drawing.Color.White;
            this.butNum0.Location = new System.Drawing.Point(38, 379);
            this.butNum0.Margin = new System.Windows.Forms.Padding(2);
            this.butNum0.Name = "butNum0";
            this.butNum0.Size = new System.Drawing.Size(56, 32);
            this.butNum0.TabIndex = 1;
            this.butNum0.Text = "0";
            this.butNum0.UseVisualStyleBackColor = true;
            this.butNum0.Click += new System.EventHandler(this.butNum0_Click);
            // 
            // butNum1
            // 
            this.butNum1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNum1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butNum1.FlatAppearance.BorderSize = 3;
            this.butNum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNum1.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.butNum1.ForeColor = System.Drawing.Color.White;
            this.butNum1.Location = new System.Drawing.Point(38, 318);
            this.butNum1.Margin = new System.Windows.Forms.Padding(2);
            this.butNum1.Name = "butNum1";
            this.butNum1.Size = new System.Drawing.Size(56, 32);
            this.butNum1.TabIndex = 2;
            this.butNum1.Text = "1";
            this.butNum1.UseVisualStyleBackColor = true;
            this.butNum1.Click += new System.EventHandler(this.butNum1_Click);
            // 
            // butNum2
            // 
            this.butNum2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNum2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butNum2.FlatAppearance.BorderSize = 3;
            this.butNum2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNum2.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.butNum2.ForeColor = System.Drawing.Color.White;
            this.butNum2.Location = new System.Drawing.Point(120, 318);
            this.butNum2.Margin = new System.Windows.Forms.Padding(2);
            this.butNum2.Name = "butNum2";
            this.butNum2.Size = new System.Drawing.Size(56, 32);
            this.butNum2.TabIndex = 3;
            this.butNum2.Text = "2";
            this.butNum2.UseVisualStyleBackColor = true;
            this.butNum2.Click += new System.EventHandler(this.butNum2_Click);
            // 
            // butNum3
            // 
            this.butNum3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNum3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butNum3.FlatAppearance.BorderSize = 3;
            this.butNum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNum3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNum3.ForeColor = System.Drawing.Color.White;
            this.butNum3.Location = new System.Drawing.Point(202, 318);
            this.butNum3.Margin = new System.Windows.Forms.Padding(2);
            this.butNum3.Name = "butNum3";
            this.butNum3.Size = new System.Drawing.Size(56, 32);
            this.butNum3.TabIndex = 4;
            this.butNum3.Text = "3";
            this.butNum3.UseVisualStyleBackColor = true;
            this.butNum3.Click += new System.EventHandler(this.butNum3_Click);
            // 
            // butNum4
            // 
            this.butNum4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNum4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butNum4.FlatAppearance.BorderSize = 3;
            this.butNum4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNum4.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.butNum4.ForeColor = System.Drawing.Color.White;
            this.butNum4.Location = new System.Drawing.Point(38, 257);
            this.butNum4.Margin = new System.Windows.Forms.Padding(2);
            this.butNum4.Name = "butNum4";
            this.butNum4.Size = new System.Drawing.Size(56, 32);
            this.butNum4.TabIndex = 5;
            this.butNum4.Text = "4";
            this.butNum4.UseVisualStyleBackColor = true;
            this.butNum4.Click += new System.EventHandler(this.butNum4_Click);
            // 
            // butNum5
            // 
            this.butNum5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNum5.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butNum5.FlatAppearance.BorderSize = 3;
            this.butNum5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNum5.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.butNum5.ForeColor = System.Drawing.Color.White;
            this.butNum5.Location = new System.Drawing.Point(120, 257);
            this.butNum5.Margin = new System.Windows.Forms.Padding(2);
            this.butNum5.Name = "butNum5";
            this.butNum5.Size = new System.Drawing.Size(56, 32);
            this.butNum5.TabIndex = 6;
            this.butNum5.Text = "5";
            this.butNum5.UseVisualStyleBackColor = true;
            this.butNum5.Click += new System.EventHandler(this.butNum5_Click);
            // 
            // butNum6
            // 
            this.butNum6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNum6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butNum6.FlatAppearance.BorderSize = 3;
            this.butNum6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNum6.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.butNum6.ForeColor = System.Drawing.Color.White;
            this.butNum6.Location = new System.Drawing.Point(202, 257);
            this.butNum6.Margin = new System.Windows.Forms.Padding(2);
            this.butNum6.Name = "butNum6";
            this.butNum6.Size = new System.Drawing.Size(56, 32);
            this.butNum6.TabIndex = 7;
            this.butNum6.Text = "6";
            this.butNum6.UseVisualStyleBackColor = true;
            this.butNum6.Click += new System.EventHandler(this.butNum6_Click);
            // 
            // butNum9
            // 
            this.butNum9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNum9.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butNum9.FlatAppearance.BorderSize = 3;
            this.butNum9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNum9.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.butNum9.ForeColor = System.Drawing.Color.White;
            this.butNum9.Location = new System.Drawing.Point(202, 196);
            this.butNum9.Margin = new System.Windows.Forms.Padding(2);
            this.butNum9.Name = "butNum9";
            this.butNum9.Size = new System.Drawing.Size(56, 32);
            this.butNum9.TabIndex = 8;
            this.butNum9.Text = "9";
            this.butNum9.UseVisualStyleBackColor = true;
            this.butNum9.Click += new System.EventHandler(this.butNum9_Click);
            // 
            // butNum8
            // 
            this.butNum8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNum8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butNum8.FlatAppearance.BorderSize = 3;
            this.butNum8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNum8.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.butNum8.ForeColor = System.Drawing.Color.White;
            this.butNum8.Location = new System.Drawing.Point(120, 196);
            this.butNum8.Margin = new System.Windows.Forms.Padding(2);
            this.butNum8.Name = "butNum8";
            this.butNum8.Size = new System.Drawing.Size(56, 32);
            this.butNum8.TabIndex = 9;
            this.butNum8.Text = "8";
            this.butNum8.UseVisualStyleBackColor = true;
            this.butNum8.Click += new System.EventHandler(this.butNum8_Click);
            // 
            // butNum7
            // 
            this.butNum7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNum7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butNum7.FlatAppearance.BorderSize = 3;
            this.butNum7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNum7.Font = new System.Drawing.Font("Berlin Sans FB", 12F);
            this.butNum7.ForeColor = System.Drawing.Color.White;
            this.butNum7.Location = new System.Drawing.Point(38, 196);
            this.butNum7.Margin = new System.Windows.Forms.Padding(2);
            this.butNum7.Name = "butNum7";
            this.butNum7.Size = new System.Drawing.Size(56, 32);
            this.butNum7.TabIndex = 10;
            this.butNum7.Text = "7";
            this.butNum7.UseVisualStyleBackColor = true;
            this.butNum7.Click += new System.EventHandler(this.butNum7_Click);
            // 
            // butValueDot
            // 
            this.butValueDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butValueDot.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butValueDot.FlatAppearance.BorderSize = 3;
            this.butValueDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butValueDot.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butValueDot.ForeColor = System.Drawing.Color.White;
            this.butValueDot.Location = new System.Drawing.Point(120, 379);
            this.butValueDot.Margin = new System.Windows.Forms.Padding(2);
            this.butValueDot.Name = "butValueDot";
            this.butValueDot.Size = new System.Drawing.Size(56, 32);
            this.butValueDot.TabIndex = 11;
            this.butValueDot.Text = ".";
            this.butValueDot.UseVisualStyleBackColor = true;
            this.butValueDot.Click += new System.EventHandler(this.butValueDot_Click);
            // 
            // butValueEqual
            // 
            this.butValueEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butValueEqual.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butValueEqual.FlatAppearance.BorderSize = 3;
            this.butValueEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butValueEqual.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butValueEqual.ForeColor = System.Drawing.Color.White;
            this.butValueEqual.Location = new System.Drawing.Point(202, 75);
            this.butValueEqual.Margin = new System.Windows.Forms.Padding(2);
            this.butValueEqual.Name = "butValueEqual";
            this.butValueEqual.Size = new System.Drawing.Size(56, 37);
            this.butValueEqual.TabIndex = 12;
            this.butValueEqual.Text = "=";
            this.butValueEqual.UseVisualStyleBackColor = true;
            // 
            // butValuePlus
            // 
            this.butValuePlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butValuePlus.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butValuePlus.FlatAppearance.BorderSize = 3;
            this.butValuePlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butValuePlus.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butValuePlus.ForeColor = System.Drawing.Color.White;
            this.butValuePlus.Location = new System.Drawing.Point(38, 74);
            this.butValuePlus.Margin = new System.Windows.Forms.Padding(2);
            this.butValuePlus.Name = "butValuePlus";
            this.butValuePlus.Size = new System.Drawing.Size(56, 37);
            this.butValuePlus.TabIndex = 13;
            this.butValuePlus.Text = "+";
            this.butValuePlus.UseVisualStyleBackColor = true;
            this.butValuePlus.Click += new System.EventHandler(this.butValuePlus_Click);
            // 
            // butValueMult
            // 
            this.butValueMult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butValueMult.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butValueMult.FlatAppearance.BorderSize = 3;
            this.butValueMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butValueMult.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butValueMult.ForeColor = System.Drawing.Color.White;
            this.butValueMult.Location = new System.Drawing.Point(120, 75);
            this.butValueMult.Margin = new System.Windows.Forms.Padding(2);
            this.butValueMult.Name = "butValueMult";
            this.butValueMult.Size = new System.Drawing.Size(56, 37);
            this.butValueMult.TabIndex = 14;
            this.butValueMult.Text = "×";
            this.butValueMult.UseVisualStyleBackColor = true;
            this.butValueMult.Click += new System.EventHandler(this.butValueMult_Click);
            // 
            // butValueMinus
            // 
            this.butValueMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butValueMinus.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butValueMinus.FlatAppearance.BorderSize = 3;
            this.butValueMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butValueMinus.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butValueMinus.ForeColor = System.Drawing.Color.White;
            this.butValueMinus.Location = new System.Drawing.Point(38, 135);
            this.butValueMinus.Margin = new System.Windows.Forms.Padding(2);
            this.butValueMinus.Name = "butValueMinus";
            this.butValueMinus.Size = new System.Drawing.Size(56, 37);
            this.butValueMinus.TabIndex = 15;
            this.butValueMinus.Text = "-";
            this.butValueMinus.UseVisualStyleBackColor = true;
            this.butValueMinus.Click += new System.EventHandler(this.butValueMinus_Click);
            // 
            // butQuit
            // 
            this.butQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butQuit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butQuit.FlatAppearance.BorderSize = 3;
            this.butQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butQuit.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butQuit.ForeColor = System.Drawing.Color.White;
            this.butQuit.Location = new System.Drawing.Point(208, 413);
            this.butQuit.Margin = new System.Windows.Forms.Padding(2);
            this.butQuit.Name = "butQuit";
            this.butQuit.Size = new System.Drawing.Size(76, 37);
            this.butQuit.TabIndex = 16;
            this.butQuit.Text = "Quit";
            this.butQuit.UseVisualStyleBackColor = true;
            this.butQuit.Click += new System.EventHandler(this.butQuit_Click);
            // 
            // butValueDel
            // 
            this.butValueDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butValueDel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butValueDel.FlatAppearance.BorderSize = 3;
            this.butValueDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butValueDel.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butValueDel.ForeColor = System.Drawing.Color.White;
            this.butValueDel.Location = new System.Drawing.Point(202, 135);
            this.butValueDel.Margin = new System.Windows.Forms.Padding(2);
            this.butValueDel.Name = "butValueDel";
            this.butValueDel.Size = new System.Drawing.Size(56, 37);
            this.butValueDel.TabIndex = 17;
            this.butValueDel.Text = "C";
            this.butValueDel.UseVisualStyleBackColor = true;
            this.butValueDel.Click += new System.EventHandler(this.butValueDel_Click);
            // 
            // butValueDiv
            // 
            this.butValueDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butValueDiv.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.butValueDiv.FlatAppearance.BorderSize = 3;
            this.butValueDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butValueDiv.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butValueDiv.ForeColor = System.Drawing.Color.White;
            this.butValueDiv.Location = new System.Drawing.Point(120, 135);
            this.butValueDiv.Margin = new System.Windows.Forms.Padding(2);
            this.butValueDiv.Name = "butValueDiv";
            this.butValueDiv.Size = new System.Drawing.Size(56, 37);
            this.butValueDiv.TabIndex = 18;
            this.butValueDiv.Text = "÷";
            this.butValueDiv.UseVisualStyleBackColor = true;
            this.butValueDiv.Click += new System.EventHandler(this.butValueDiv_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(288, 456);
            this.Controls.Add(this.butValueDiv);
            this.Controls.Add(this.butValueDel);
            this.Controls.Add(this.butValueEqual);
            this.Controls.Add(this.butQuit);
            this.Controls.Add(this.butValueMinus);
            this.Controls.Add(this.butValueMult);
            this.Controls.Add(this.butValuePlus);
            this.Controls.Add(this.butValueDot);
            this.Controls.Add(this.butNum7);
            this.Controls.Add(this.butNum8);
            this.Controls.Add(this.butNum9);
            this.Controls.Add(this.butNum6);
            this.Controls.Add(this.butNum5);
            this.Controls.Add(this.butNum4);
            this.Controls.Add(this.butNum3);
            this.Controls.Add(this.butNum2);
            this.Controls.Add(this.butNum1);
            this.Controls.Add(this.butNum0);
            this.Controls.Add(this.panelResult);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(304, 495);
            this.MinimumSize = new System.Drawing.Size(304, 495);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panelResult.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button butNum0;
        private System.Windows.Forms.Button butNum1;
        private System.Windows.Forms.Button butNum2;
        private System.Windows.Forms.Button butNum3;
        private System.Windows.Forms.Button butNum4;
        private System.Windows.Forms.Button butNum5;
        private System.Windows.Forms.Button butNum6;
        private System.Windows.Forms.Button butNum9;
        private System.Windows.Forms.Button butNum8;
        private System.Windows.Forms.Button butNum7;
        private System.Windows.Forms.Button butValueDot;
        private System.Windows.Forms.Button butValueEqual;
        private System.Windows.Forms.Button butValuePlus;
        private System.Windows.Forms.Button butValueMult;
        private System.Windows.Forms.Button butValueMinus;
        private System.Windows.Forms.Button butQuit;
        private System.Windows.Forms.Button butValueDel;
        private System.Windows.Forms.Button butValueDiv;
        private System.Windows.Forms.Panel panel2;
    }
}

