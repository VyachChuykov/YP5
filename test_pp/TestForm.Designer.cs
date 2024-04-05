namespace test_pp
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.ans_lb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ansVariant3_rb = new System.Windows.Forms.RadioButton();
            this.ansVariant2_rb = new System.Windows.Forms.RadioButton();
            this.ansVariant1_rb = new System.Windows.Forms.RadioButton();
            this.next_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ans_lb
            // 
            this.ans_lb.AutoSize = true;
            this.ans_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ans_lb.Location = new System.Drawing.Point(12, 23);
            this.ans_lb.Name = "ans_lb";
            this.ans_lb.Size = new System.Drawing.Size(0, 25);
            this.ans_lb.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ansVariant3_rb);
            this.panel1.Controls.Add(this.ansVariant2_rb);
            this.panel1.Controls.Add(this.ansVariant1_rb);
            this.panel1.Location = new System.Drawing.Point(90, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 250);
            this.panel1.TabIndex = 3;
            // 
            // ansVariant3_rb
            // 
            this.ansVariant3_rb.AutoSize = true;
            this.ansVariant3_rb.Location = new System.Drawing.Point(3, 163);
            this.ansVariant3_rb.Name = "ansVariant3_rb";
            this.ansVariant3_rb.Size = new System.Drawing.Size(14, 13);
            this.ansVariant3_rb.TabIndex = 2;
            this.ansVariant3_rb.TabStop = true;
            this.ansVariant3_rb.UseVisualStyleBackColor = true;
            // 
            // ansVariant2_rb
            // 
            this.ansVariant2_rb.AutoSize = true;
            this.ansVariant2_rb.Location = new System.Drawing.Point(3, 86);
            this.ansVariant2_rb.Name = "ansVariant2_rb";
            this.ansVariant2_rb.Size = new System.Drawing.Size(14, 13);
            this.ansVariant2_rb.TabIndex = 1;
            this.ansVariant2_rb.TabStop = true;
            this.ansVariant2_rb.UseVisualStyleBackColor = true;
            // 
            // ansVariant1_rb
            // 
            this.ansVariant1_rb.AutoSize = true;
            this.ansVariant1_rb.Location = new System.Drawing.Point(3, 3);
            this.ansVariant1_rb.Name = "ansVariant1_rb";
            this.ansVariant1_rb.Size = new System.Drawing.Size(14, 13);
            this.ansVariant1_rb.TabIndex = 0;
            this.ansVariant1_rb.TabStop = true;
            this.ansVariant1_rb.UseVisualStyleBackColor = true;
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(211)))), ((int)(((byte)(189)))));
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.next_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next_btn.Location = new System.Drawing.Point(324, 401);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(105, 37);
            this.next_btn.TabIndex = 4;
            this.next_btn.Text = "Далее";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.back_btn.Location = new System.Drawing.Point(12, 401);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(105, 37);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Назад";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ans_lb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "TestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ans_lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ansVariant3_rb;
        private System.Windows.Forms.RadioButton ansVariant2_rb;
        private System.Windows.Forms.RadioButton ansVariant1_rb;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button back_btn;
    }
}