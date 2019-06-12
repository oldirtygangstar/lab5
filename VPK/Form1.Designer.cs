namespace Cities
{
    partial class Form_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.пошукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStriptextBoxSearchData = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBoxSearcType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.шукатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.скасуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пошукToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // пошукToolStripMenuItem
            // 
            this.пошукToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStriptextBoxSearchData,
            this.toolStripSeparator2,
            this.toolStripComboBoxSearcType,
            this.toolStripSeparator1,
            this.шукатиToolStripMenuItem,
            this.toolStripSeparator4,
            this.скасуватиToolStripMenuItem,
            this.toolStripSeparator3});
            this.пошукToolStripMenuItem.Name = "пошукToolStripMenuItem";
            this.пошукToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.пошукToolStripMenuItem.Text = "Пошук";
            // 
            // toolStriptextBoxSearchData
            // 
            this.toolStriptextBoxSearchData.Name = "toolStriptextBoxSearchData";
            this.toolStriptextBoxSearchData.Size = new System.Drawing.Size(100, 27);
            this.toolStriptextBoxSearchData.ToolTipText = "Назва виробництва або продукту";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // toolStripComboBoxSearcType
            // 
            this.toolStripComboBoxSearcType.Items.AddRange(new object[] {
            "Назва",
            "Продукт"});
            this.toolStripComboBoxSearcType.Name = "toolStripComboBoxSearcType";
            this.toolStripComboBoxSearcType.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBoxSearcType.ToolTipText = "Пошук по назві чи продукту";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // шукатиToolStripMenuItem
            // 
            this.шукатиToolStripMenuItem.Name = "шукатиToolStripMenuItem";
            this.шукатиToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.шукатиToolStripMenuItem.Text = "Шукати";
            this.шукатиToolStripMenuItem.Click += new System.EventHandler(this.шукатиToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // скасуватиToolStripMenuItem
            // 
            this.скасуватиToolStripMenuItem.Name = "скасуватиToolStripMenuItem";
            this.скасуватиToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.скасуватиToolStripMenuItem.Text = "Скасувати";
            this.скасуватиToolStripMenuItem.Click += new System.EventHandler(this.скасуватиToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.AllowUserToAddRows = false;
            this.dataGridViewCities.AllowUserToDeleteRows = false;
            this.dataGridViewCities.AllowUserToResizeColumns = false;
            this.dataGridViewCities.AllowUserToResizeRows = false;
            this.dataGridViewCities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCities.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCities.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCities.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.ReadOnly = true;
            this.dataGridViewCities.RowTemplate.Height = 24;
            this.dataGridViewCities.Size = new System.Drawing.Size(866, 456);
            this.dataGridViewCities.TabIndex = 1;
            this.dataGridViewCities.TabStop = false;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 484);
            this.Controls.Add(this.dataGridViewCities);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Виробництва ВПК";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewCities;
        private System.Windows.Forms.ToolStripMenuItem пошукToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStriptextBoxSearchData;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSearcType;
        private System.Windows.Forms.ToolStripMenuItem шукатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скасуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

