namespace WindowsFormsGrade
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
            this.label1 = new System.Windows.Forms.Label();
            this.lashow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.oOK = new System.Windows.Forms.Button();
            this.tScore = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(247, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "โปรเเกรมคำนวณผลการเรียน";
            // 
            // lashow
            // 
            this.lashow.AutoSize = true;
            this.lashow.BackColor = System.Drawing.Color.Transparent;
            this.lashow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lashow.ForeColor = System.Drawing.Color.Black;
            this.lashow.Location = new System.Drawing.Point(247, 215);
            this.lashow.Name = "lashow";
            this.lashow.Size = new System.Drawing.Size(319, 38);
            this.lashow.TabIndex = 1;
            this.lashow.Text = "คุณมีผลการเรียนเป็น : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(247, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "คะแนน :";
            // 
            // oOK
            // 
            this.oOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oOK.Location = new System.Drawing.Point(677, 95);
            this.oOK.Name = "oOK";
            this.oOK.Size = new System.Drawing.Size(75, 45);
            this.oOK.TabIndex = 3;
            this.oOK.Text = "OK";
            this.oOK.UseVisualStyleBackColor = true;
            this.oOK.Click += new System.EventHandler(this.oOK_Click);
            // 
            // tScore
            // 
            this.tScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tScore.Location = new System.Drawing.Point(388, 95);
            this.tScore.Name = "tScore";
            this.tScore.Size = new System.Drawing.Size(258, 45);
            this.tScore.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsGrade.Properties.Resources._321;
            this.ClientSize = new System.Drawing.Size(846, 483);
            this.Controls.Add(this.tScore);
            this.Controls.Add(this.oOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lashow);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lashow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button oOK;
        private System.Windows.Forms.TextBox tScore;
    }
}

