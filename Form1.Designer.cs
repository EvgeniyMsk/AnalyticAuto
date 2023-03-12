namespace TasLight2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.экспортВWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.учтенныеСправкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.найтройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокБанковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПерсонуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЧеловекаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьПроверкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.весьДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.толькоКонтекстToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найтройкиToolStripMenuItem,
            this.добавитьПерсонуToolStripMenuItem,
            this.экспортВWordToolStripMenuItem,
            this.toolStripMenuItem1,
            this.информацияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // экспортВWordToolStripMenuItem
            // 
            this.экспортВWordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.весьДокументToolStripMenuItem,
            this.толькоКонтекстToolStripMenuItem});
            this.экспортВWordToolStripMenuItem.Name = "экспортВWordToolStripMenuItem";
            this.экспортВWordToolStripMenuItem.Size = new System.Drawing.Size(129, 23);
            this.экспортВWordToolStripMenuItem.Text = "Экспорт в Word";
            this.экспортВWordToolStripMenuItem.Click += new System.EventHandler(this.экспортВWordToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 23);
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учтенныеСправкиToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(108, 23);
            this.информацияToolStripMenuItem.Text = "Информация";
            // 
            // учтенныеСправкиToolStripMenuItem
            // 
            this.учтенныеСправкиToolStripMenuItem.Name = "учтенныеСправкиToolStripMenuItem";
            this.учтенныеСправкиToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.учтенныеСправкиToolStripMenuItem.Text = "Учтенные справки";
            this.учтенныеСправкиToolStripMenuItem.Click += new System.EventHandler(this.учтенныеСправкиToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Size = new System.Drawing.Size(971, 534);
            this.splitContainer1.SplitterDistance = 485;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer2.Size = new System.Drawing.Size(971, 485);
            this.splitContainer2.SplitterDistance = 289;
            this.splitContainer2.SplitterWidth = 7;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.LemonChiffon;
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Location = new System.Drawing.Point(-19, -16);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(303, 494);
            this.treeView1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(663, 475);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(295, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Прошло времени:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(3, 11);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(288, 17);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // найтройкиToolStripMenuItem
            // 
            this.найтройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокБанковToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.найтройкиToolStripMenuItem.Image = global::TasLight2.Properties.Resources.Settings_16x;
            this.найтройкиToolStripMenuItem.Name = "найтройкиToolStripMenuItem";
            this.найтройкиToolStripMenuItem.Size = new System.Drawing.Size(110, 23);
            this.найтройкиToolStripMenuItem.Text = "Настройки";
            // 
            // списокБанковToolStripMenuItem
            // 
            this.списокБанковToolStripMenuItem.Image = global::TasLight2.Properties.Resources.DatabaseGroup_16x;
            this.списокБанковToolStripMenuItem.Name = "списокБанковToolStripMenuItem";
            this.списокБанковToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.списокБанковToolStripMenuItem.Text = "Список банков";
            this.списокБанковToolStripMenuItem.Click += new System.EventHandler(this.списокБанковToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(179, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // добавитьПерсонуToolStripMenuItem
            // 
            this.добавитьПерсонуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЧеловекаToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.начатьПроверкуToolStripMenuItem});
            this.добавитьПерсонуToolStripMenuItem.Image = global::TasLight2.Properties.Resources.Action_16x;
            this.добавитьПерсонуToolStripMenuItem.Name = "добавитьПерсонуToolStripMenuItem";
            this.добавитьПерсонуToolStripMenuItem.Size = new System.Drawing.Size(102, 23);
            this.добавитьПерсонуToolStripMenuItem.Text = "Действия";
            // 
            // добавитьЧеловекаToolStripMenuItem
            // 
            this.добавитьЧеловекаToolStripMenuItem.Image = global::TasLight2.Properties.Resources.Actor_16x;
            this.добавитьЧеловекаToolStripMenuItem.Name = "добавитьЧеловекаToolStripMenuItem";
            this.добавитьЧеловекаToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.добавитьЧеловекаToolStripMenuItem.Text = "Добавить человека";
            this.добавитьЧеловекаToolStripMenuItem.Click += new System.EventHandler(this.добавитьЧеловекаToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Image = global::TasLight2.Properties.Resources.CleanData_16x;
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // начатьПроверкуToolStripMenuItem
            // 
            this.начатьПроверкуToolStripMenuItem.Image = global::TasLight2.Properties.Resources.StartWithoutDebug_16x1;
            this.начатьПроверкуToolStripMenuItem.Name = "начатьПроверкуToolStripMenuItem";
            this.начатьПроверкуToolStripMenuItem.Size = new System.Drawing.Size(207, 24);
            this.начатьПроверкуToolStripMenuItem.Text = "Начать проверку";
            this.начатьПроверкуToolStripMenuItem.Click += new System.EventHandler(this.начатьПроверкуToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выделить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // весьДокументToolStripMenuItem
            // 
            this.весьДокументToolStripMenuItem.Name = "весьДокументToolStripMenuItem";
            this.весьДокументToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.весьДокументToolStripMenuItem.Text = "Весь документ";
            this.весьДокументToolStripMenuItem.Click += new System.EventHandler(this.весьДокументToolStripMenuItem_Click);
            // 
            // толькоКонтекстToolStripMenuItem
            // 
            this.толькоКонтекстToolStripMenuItem.Name = "толькоКонтекстToolStripMenuItem";
            this.толькоКонтекстToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.толькоКонтекстToolStripMenuItem.Text = "Только контекст";
            this.толькоКонтекстToolStripMenuItem.Click += new System.EventHandler(this.толькоКонтекстToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "Form1";
            this.Text = "АналитикАвто";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьПерсонуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЧеловекаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьПроверкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортВWordToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem найтройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокБанковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem учтенныеСправкиToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem весьДокументToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem толькоКонтекстToolStripMenuItem;
    }
}

