namespace _10._1._25_forms_
{
    partial class MainWindow
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
            this.InputDataGridView = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.run_btn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InputDataGridView)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputDataGridView
            // 
            this.InputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Sex,
            this.Course,
            this.Marks});
            this.InputDataGridView.Location = new System.Drawing.Point(12, 33);
            this.InputDataGridView.Name = "InputDataGridView";
            this.InputDataGridView.Size = new System.Drawing.Size(563, 205);
            this.InputDataGridView.TabIndex = 0;
            this.InputDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InputDataGridView_CellContentClick);
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Ф.И.О.";
            this.FullName.Name = "FullName";
            this.FullName.Width = 220;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Пол";
            this.Sex.Name = "Sex";
            // 
            // Course
            // 
            this.Course.HeaderText = "Курс";
            this.Course.Name = "Course";
            // 
            // Marks
            // 
            this.Marks.HeaderText = "Баллы";
            this.Marks.Name = "Marks";
            // 
            // run_btn
            // 
            this.run_btn.Location = new System.Drawing.Point(12, 244);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(143, 54);
            this.run_btn.TabIndex = 1;
            this.run_btn.Text = "Sort";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(769, 24);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile_btn,
            this.saveFile_btn});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openFile_btn
            // 
            this.openFile_btn.Name = "openFile_btn";
            this.openFile_btn.Size = new System.Drawing.Size(132, 22);
            this.openFile_btn.Text = "Открыть";
            this.openFile_btn.Click += new System.EventHandler(this.openFile_btn_Click);
            // 
            // saveFile_btn
            // 
            this.saveFile_btn.Name = "saveFile_btn";
            this.saveFile_btn.Size = new System.Drawing.Size(132, 22);
            this.saveFile_btn.Text = "Сохранить";
            this.saveFile_btn.Click += new System.EventHandler(this.saveFile_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список пар:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(162, 265);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 374);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.run_btn);
            this.Controls.Add(this.InputDataGridView);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainWindow";
            this.Text = "StudentsSorter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputDataGridView)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InputDataGridView;
        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFile_btn;
        private System.Windows.Forms.ToolStripMenuItem saveFile_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLabel;
    }
}

