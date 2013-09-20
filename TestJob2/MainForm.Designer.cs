namespace TestJob2
{
    partial class MainForm
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
            this.calc_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.a_txtBox = new System.Windows.Forms.TextBox();
            this.res_txtBox = new System.Windows.Forms.TextBox();
            this.b_txtBox = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.infoLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calc_btn
            // 
            this.calc_btn.Location = new System.Drawing.Point(67, 198);
            this.calc_btn.Name = "calc_btn";
            this.calc_btn.Size = new System.Drawing.Size(75, 23);
            this.calc_btn.TabIndex = 0;
            this.calc_btn.Text = "Calculate";
            this.calc_btn.UseVisualStyleBackColor = true;
            this.calc_btn.Click += new System.EventHandler(this.calc_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(259, 198);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // a_txtBox
            // 
            this.a_txtBox.Location = new System.Drawing.Point(84, 39);
            this.a_txtBox.Name = "a_txtBox";
            this.a_txtBox.Size = new System.Drawing.Size(100, 20);
            this.a_txtBox.TabIndex = 3;
            // 
            // res_txtBox
            // 
            this.res_txtBox.Location = new System.Drawing.Point(155, 113);
            this.res_txtBox.Name = "res_txtBox";
            this.res_txtBox.ReadOnly = true;
            this.res_txtBox.Size = new System.Drawing.Size(100, 20);
            this.res_txtBox.TabIndex = 4;
            // 
            // b_txtBox
            // 
            this.b_txtBox.Location = new System.Drawing.Point(291, 39);
            this.b_txtBox.Name = "b_txtBox";
            this.b_txtBox.Size = new System.Drawing.Size(100, 20);
            this.b_txtBox.TabIndex = 5;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(22, 42);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(40, 13);
            this.labelA.TabIndex = 6;
            this.labelA.Text = "Input a";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(229, 42);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(40, 13);
            this.labelB.TabIndex = 7;
            this.labelB.Text = "Input b";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(180, 81);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(37, 13);
            this.labelRes.TabIndex = 8;
            this.labelRes.Text = "Result";
            // 
            // infoLb
            // 
            this.infoLb.AutoSize = true;
            this.infoLb.Location = new System.Drawing.Point(131, 157);
            this.infoLb.Name = "infoLb";
            this.infoLb.Size = new System.Drawing.Size(0, 13);
            this.infoLb.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 262);
            this.Controls.Add(this.infoLb);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.b_txtBox);
            this.Controls.Add(this.res_txtBox);
            this.Controls.Add(this.a_txtBox);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.calc_btn);
            this.Name = "MainForm";
            this.Text = "MultyTreading (Developed by Doluda S.V.)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calc_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.TextBox a_txtBox;
        private System.Windows.Forms.TextBox res_txtBox;
        private System.Windows.Forms.TextBox b_txtBox;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Label infoLb;
    }
}

