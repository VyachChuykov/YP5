namespace test_pp
{
    partial class startForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startForm));
            this.info_btn = new System.Windows.Forms.Button();
            this.startTest_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info_btn
            // 
            this.info_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(211)))), ((int)(((byte)(189)))));
            this.info_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.info_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_btn.ForeColor = System.Drawing.Color.Black;
            this.info_btn.Location = new System.Drawing.Point(292, 209);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(159, 73);
            this.info_btn.TabIndex = 1;
            this.info_btn.Text = "Справка по вопросам";
            this.info_btn.UseVisualStyleBackColor = false;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // startTest_btn
            // 
            this.startTest_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(211)))), ((int)(((byte)(189)))));
            this.startTest_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startTest_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTest_btn.ForeColor = System.Drawing.Color.Black;
            this.startTest_btn.Location = new System.Drawing.Point(292, 130);
            this.startTest_btn.Name = "startTest_btn";
            this.startTest_btn.Size = new System.Drawing.Size(159, 73);
            this.startTest_btn.TabIndex = 0;
            this.startTest_btn.Text = "Начать тестирование";
            this.startTest_btn.UseVisualStyleBackColor = false;
            this.startTest_btn.Click += new System.EventHandler(this.startTest_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(292, 288);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(159, 73);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(241)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.info_btn);
            this.Controls.Add(this.startTest_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "startForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование сотрудников";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Button startTest_btn;
        private System.Windows.Forms.Button exit_btn;
    }
}

