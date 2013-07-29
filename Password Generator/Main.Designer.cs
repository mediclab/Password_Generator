namespace Password_Generator
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TPasswLenght = new System.Windows.Forms.NumericUpDown();
            this.TPasswCount = new System.Windows.Forms.NumericUpDown();
            this.TGenerate = new System.Windows.Forms.Button();
            this.TPaswords = new System.Windows.Forms.TextBox();
            this.Context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьСлучайныйПарольToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSymbolsEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.THelp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TPasswLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TPasswCount)).BeginInit();
            this.Context.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длинна пароля:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество паролей:";
            // 
            // TPasswLenght
            // 
            this.TPasswLenght.Location = new System.Drawing.Point(139, 7);
            this.TPasswLenght.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TPasswLenght.Name = "TPasswLenght";
            this.TPasswLenght.Size = new System.Drawing.Size(106, 22);
            this.TPasswLenght.TabIndex = 2;
            this.TPasswLenght.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TPasswCount
            // 
            this.TPasswCount.Location = new System.Drawing.Point(139, 35);
            this.TPasswCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TPasswCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TPasswCount.Name = "TPasswCount";
            this.TPasswCount.Size = new System.Drawing.Size(106, 22);
            this.TPasswCount.TabIndex = 3;
            this.TPasswCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // TGenerate
            // 
            this.TGenerate.Location = new System.Drawing.Point(265, 22);
            this.TGenerate.Name = "TGenerate";
            this.TGenerate.Size = new System.Drawing.Size(109, 23);
            this.TGenerate.TabIndex = 4;
            this.TGenerate.Text = "Сгенерировать";
            this.TGenerate.UseVisualStyleBackColor = true;
            this.TGenerate.Click += new System.EventHandler(this.TGenerate_Click);
            // 
            // TPaswords
            // 
            this.TPaswords.BackColor = System.Drawing.SystemColors.Window;
            this.TPaswords.ContextMenuStrip = this.Context;
            this.TPaswords.Location = new System.Drawing.Point(12, 91);
            this.TPaswords.Multiline = true;
            this.TPaswords.Name = "TPaswords";
            this.TPaswords.ReadOnly = true;
            this.TPaswords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TPaswords.Size = new System.Drawing.Size(362, 131);
            this.TPaswords.TabIndex = 5;
            this.TPaswords.WordWrap = false;
            // 
            // Context
            // 
            this.Context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.копироватьСлучайныйПарольToolStripMenuItem});
            this.Context.Name = "Context";
            this.Context.Size = new System.Drawing.Size(248, 48);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Image = global::Password_Generator.Properties.Resources.page_white_copy;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // копироватьСлучайныйПарольToolStripMenuItem
            // 
            this.копироватьСлучайныйПарольToolStripMenuItem.Image = global::Password_Generator.Properties.Resources.page_copy;
            this.копироватьСлучайныйПарольToolStripMenuItem.Name = "копироватьСлучайныйПарольToolStripMenuItem";
            this.копироватьСлучайныйПарольToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.копироватьСлучайныйПарольToolStripMenuItem.Text = "Копировать случайный пароль";
            this.копироватьСлучайныйПарольToolStripMenuItem.Click += new System.EventHandler(this.копироватьСлучайныйПарольToolStripMenuItem_Click);
            // 
            // TSymbolsEdit
            // 
            this.TSymbolsEdit.Location = new System.Drawing.Point(139, 63);
            this.TSymbolsEdit.Name = "TSymbolsEdit";
            this.TSymbolsEdit.Size = new System.Drawing.Size(235, 22);
            this.TSymbolsEdit.TabIndex = 6;
            this.TSymbolsEdit.Text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0987654321";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(55, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Из символов:";
            // 
            // THelp
            // 
            this.THelp.AutoSize = true;
            this.THelp.BackColor = System.Drawing.Color.Transparent;
            this.THelp.Location = new System.Drawing.Point(0, 0);
            this.THelp.Name = "THelp";
            this.THelp.Size = new System.Drawing.Size(12, 13);
            this.THelp.TabIndex = 8;
            this.THelp.TabStop = true;
            this.THelp.Text = "?";
            this.THelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.THelp_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Password_Generator.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 228);
            this.Controls.Add(this.THelp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TSymbolsEdit);
            this.Controls.Add(this.TPaswords);
            this.Controls.Add(this.TGenerate);
            this.Controls.Add(this.TPasswCount);
            this.Controls.Add(this.TPasswLenght);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.TPasswLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TPasswCount)).EndInit();
            this.Context.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TPasswLenght;
        private System.Windows.Forms.NumericUpDown TPasswCount;
        private System.Windows.Forms.Button TGenerate;
        private System.Windows.Forms.TextBox TPaswords;
        private System.Windows.Forms.TextBox TSymbolsEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip Context;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьСлучайныйПарольToolStripMenuItem;
        private System.Windows.Forms.LinkLabel THelp;
    }
}

