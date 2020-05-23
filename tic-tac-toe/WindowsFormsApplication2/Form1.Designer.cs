namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.игратьЗановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.играНаВремяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьТаймерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьВремяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помошьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стратегииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.помошьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.игратьЗановоToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.играНаВремяToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // игратьЗановоToolStripMenuItem
            // 
            this.игратьЗановоToolStripMenuItem.Name = "игратьЗановоToolStripMenuItem";
            this.игратьЗановоToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.игратьЗановоToolStripMenuItem.Text = "Играть заново";
            this.игратьЗановоToolStripMenuItem.Click += new System.EventHandler(this.игратьЗановоToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // играНаВремяToolStripMenuItem
            // 
            this.играНаВремяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.включитьТаймерToolStripMenuItem,
            this.остановитьВремяToolStripMenuItem});
            this.играНаВремяToolStripMenuItem.Name = "играНаВремяToolStripMenuItem";
            this.играНаВремяToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.играНаВремяToolStripMenuItem.Text = "Игра на время";
            // 
            // включитьТаймерToolStripMenuItem
            // 
            this.включитьТаймерToolStripMenuItem.Name = "включитьТаймерToolStripMenuItem";
            this.включитьТаймерToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.включитьТаймерToolStripMenuItem.Text = "Включить таймер";
            this.включитьТаймерToolStripMenuItem.Click += new System.EventHandler(this.включитьТаймерToolStripMenuItem_Click_1);
            // 
            // остановитьВремяToolStripMenuItem
            // 
            this.остановитьВремяToolStripMenuItem.Name = "остановитьВремяToolStripMenuItem";
            this.остановитьВремяToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.остановитьВремяToolStripMenuItem.Text = "Остановить время";
            this.остановитьВремяToolStripMenuItem.Click += new System.EventHandler(this.остановитьВремяToolStripMenuItem_Click);
            // 
            // помошьToolStripMenuItem
            // 
            this.помошьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаИгрыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.стратегииToolStripMenuItem});
            this.помошьToolStripMenuItem.Name = "помошьToolStripMenuItem";
            this.помошьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.помошьToolStripMenuItem.Text = "Помощь ";
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.правилаИгрыToolStripMenuItem.Text = "Правила игры";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // стратегииToolStripMenuItem
            // 
            this.стратегииToolStripMenuItem.Name = "стратегииToolStripMenuItem";
            this.стратегииToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.стратегииToolStripMenuItem.Text = "Стратегии";
            this.стратегииToolStripMenuItem.Click += new System.EventHandler(this.стратегииToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(691, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "00:00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(628, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Таймер";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 786);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Крестики-нолики";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem игратьЗановоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помошьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem играНаВремяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьТаймерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьВремяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стратегииToolStripMenuItem;
    }
}

