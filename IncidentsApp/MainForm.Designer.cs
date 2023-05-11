namespace IncidentsApp
{
    partial class MainForm
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.content = new System.Windows.Forms.Panel();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.Panel();
            this.clusterButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.highPriorityLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.middlePriorityLabel = new System.Windows.Forms.Label();
            this.lowPriorityLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            this.menu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadButton,
            this.saveButton,
            this.saveAsButton});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(224, 28);
            this.loadButton.Text = "Загрузить";
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(224, 28);
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(224, 28);
            this.saveAsButton.Text = "Сохранить как";
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // content
            // 
            this.content.Controls.Add(this.tableView);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(0, 31);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1074, 505);
            this.content.TabIndex = 1;
            // 
            // tableView
            // 
            this.tableView.AllowUserToAddRows = false;
            this.tableView.AllowUserToDeleteRows = false;
            this.tableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableView.Location = new System.Drawing.Point(0, 0);
            this.tableView.Name = "tableView";
            this.tableView.ReadOnly = true;
            this.tableView.RowHeadersWidth = 51;
            this.tableView.RowTemplate.Height = 24;
            this.tableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableView.Size = new System.Drawing.Size(1074, 505);
            this.tableView.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.Controls.Add(this.flowLayoutPanel2);
            this.menu.Controls.Add(this.flowLayoutPanel1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menu.Location = new System.Drawing.Point(0, 536);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1074, 90);
            this.menu.TabIndex = 2;
            // 
            // clusterButton
            // 
            this.clusterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clusterButton.Location = new System.Drawing.Point(83, 8);
            this.clusterButton.Name = "clusterButton";
            this.clusterButton.Size = new System.Drawing.Size(238, 75);
            this.clusterButton.TabIndex = 0;
            this.clusterButton.Text = "Выполнить кластеризацию";
            this.clusterButton.UseVisualStyleBackColor = true;
            this.clusterButton.Click += new System.EventHandler(this.clusterButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.clusterButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(669, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(80, 5, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(405, 90);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // highPriorityLabel
            // 
            this.highPriorityLabel.AutoSize = true;
            this.highPriorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.highPriorityLabel.Location = new System.Drawing.Point(5, 5);
            this.highPriorityLabel.Margin = new System.Windows.Forms.Padding(5);
            this.highPriorityLabel.Name = "highPriorityLabel";
            this.highPriorityLabel.Size = new System.Drawing.Size(46, 18);
            this.highPriorityLabel.TabIndex = 2;
            this.highPriorityLabel.Text = "label1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.highPriorityLabel);
            this.flowLayoutPanel2.Controls.Add(this.middlePriorityLabel);
            this.flowLayoutPanel2.Controls.Add(this.lowPriorityLabel);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(663, 90);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // middlePriorityLabel
            // 
            this.middlePriorityLabel.AutoSize = true;
            this.middlePriorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middlePriorityLabel.Location = new System.Drawing.Point(5, 33);
            this.middlePriorityLabel.Margin = new System.Windows.Forms.Padding(5);
            this.middlePriorityLabel.Name = "middlePriorityLabel";
            this.middlePriorityLabel.Size = new System.Drawing.Size(46, 18);
            this.middlePriorityLabel.TabIndex = 3;
            this.middlePriorityLabel.Text = "label2";
            // 
            // lowPriorityLabel
            // 
            this.lowPriorityLabel.AutoSize = true;
            this.lowPriorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lowPriorityLabel.Location = new System.Drawing.Point(5, 61);
            this.lowPriorityLabel.Margin = new System.Windows.Forms.Padding(5);
            this.lowPriorityLabel.Name = "lowPriorityLabel";
            this.lowPriorityLabel.Size = new System.Drawing.Size(46, 18);
            this.lowPriorityLabel.TabIndex = 4;
            this.lowPriorityLabel.Text = "label3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 626);
            this.Controls.Add(this.content);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "IncidentsApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            this.menu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.ToolStripMenuItem loadButton;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripMenuItem saveAsButton;
        private System.Windows.Forms.Button clusterButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label highPriorityLabel;
        private System.Windows.Forms.Label middlePriorityLabel;
        private System.Windows.Forms.Label lowPriorityLabel;
    }
}

