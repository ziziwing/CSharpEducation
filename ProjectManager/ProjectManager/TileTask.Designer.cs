namespace ProjectManager
{
    partial class TileTask
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableTile = new System.Windows.Forms.TableLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.tableStatus = new System.Windows.Forms.TableLayoutPanel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.tablePriority = new System.Windows.Forms.TableLayoutPanel();
            this.labelPriority = new System.Windows.Forms.Label();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.tableResponsible = new System.Windows.Forms.TableLayoutPanel();
            this.labelResponsible = new System.Windows.Forms.Label();
            this.comboResponsible = new System.Windows.Forms.ComboBox();
            this.tableTile.SuspendLayout();
            this.tableStatus.SuspendLayout();
            this.tablePriority.SuspendLayout();
            this.tableResponsible.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableTile
            // 
            this.tableTile.ColumnCount = 1;
            this.tableTile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableTile.Controls.Add(this.labelName, 0, 0);
            this.tableTile.Controls.Add(this.tableStatus, 0, 1);
            this.tableTile.Controls.Add(this.tablePriority, 0, 2);
            this.tableTile.Controls.Add(this.tableResponsible, 0, 3);
            this.tableTile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableTile.Location = new System.Drawing.Point(0, 0);
            this.tableTile.Name = "tableTile";
            this.tableTile.RowCount = 4;
            this.tableTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableTile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableTile.Size = new System.Drawing.Size(235, 173);
            this.tableTile.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(3, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(93, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "labelName";
            // 
            // tableStatus
            // 
            this.tableStatus.ColumnCount = 2;
            this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.73799F));
            this.tableStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.26201F));
            this.tableStatus.Controls.Add(this.labelStatus, 0, 0);
            this.tableStatus.Controls.Add(this.comboStatus, 1, 0);
            this.tableStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableStatus.Location = new System.Drawing.Point(3, 41);
            this.tableStatus.Name = "tableStatus";
            this.tableStatus.RowCount = 1;
            this.tableStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableStatus.Size = new System.Drawing.Size(229, 33);
            this.tableStatus.TabIndex = 1;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.Location = new System.Drawing.Point(3, 8);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(53, 16);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Статус";
            // 
            // comboStatus
            // 
            this.comboStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Ожидание",
            "В работе",
            "Рецензирование",
            "Закрыто"});
            this.comboStatus.Location = new System.Drawing.Point(94, 6);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(132, 24);
            this.comboStatus.TabIndex = 1;
            // 
            // tablePriority
            // 
            this.tablePriority.ColumnCount = 2;
            this.tablePriority.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.30131F));
            this.tablePriority.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.69869F));
            this.tablePriority.Controls.Add(this.labelPriority, 0, 0);
            this.tablePriority.Controls.Add(this.comboPriority, 1, 0);
            this.tablePriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePriority.Location = new System.Drawing.Point(3, 80);
            this.tablePriority.Name = "tablePriority";
            this.tablePriority.RowCount = 1;
            this.tablePriority.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePriority.Size = new System.Drawing.Size(229, 33);
            this.tablePriority.TabIndex = 2;
            // 
            // labelPriority
            // 
            this.labelPriority.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriority.Location = new System.Drawing.Point(3, 8);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(79, 16);
            this.labelPriority.TabIndex = 0;
            this.labelPriority.Text = "Приоритет";
            // 
            // comboPriority
            // 
            this.comboPriority.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Items.AddRange(new object[] {
            "Критичный",
            "Высокий",
            "Средний",
            "Низкий"});
            this.comboPriority.Location = new System.Drawing.Point(93, 4);
            this.comboPriority.Name = "comboPriority";
            this.comboPriority.Size = new System.Drawing.Size(133, 24);
            this.comboPriority.TabIndex = 1;
            // 
            // tableResponsible
            // 
            this.tableResponsible.ColumnCount = 1;
            this.tableResponsible.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableResponsible.Controls.Add(this.labelResponsible, 0, 0);
            this.tableResponsible.Controls.Add(this.comboResponsible, 0, 1);
            this.tableResponsible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableResponsible.Location = new System.Drawing.Point(3, 119);
            this.tableResponsible.Name = "tableResponsible";
            this.tableResponsible.RowCount = 2;
            this.tableResponsible.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableResponsible.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableResponsible.Size = new System.Drawing.Size(229, 51);
            this.tableResponsible.TabIndex = 3;
            // 
            // labelResponsible
            // 
            this.labelResponsible.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResponsible.AutoSize = true;
            this.labelResponsible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResponsible.Location = new System.Drawing.Point(3, 2);
            this.labelResponsible.Name = "labelResponsible";
            this.labelResponsible.Size = new System.Drawing.Size(110, 16);
            this.labelResponsible.TabIndex = 0;
            this.labelResponsible.Text = "Ответственный";
            // 
            // comboResponsible
            // 
            this.comboResponsible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboResponsible.FormattingEnabled = true;
            this.comboResponsible.Location = new System.Drawing.Point(3, 23);
            this.comboResponsible.Name = "comboResponsible";
            this.comboResponsible.Size = new System.Drawing.Size(223, 21);
            this.comboResponsible.TabIndex = 1;
            // 
            // TileTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableTile);
            this.Name = "TileTask";
            this.Size = new System.Drawing.Size(235, 173);
            this.tableTile.ResumeLayout(false);
            this.tableTile.PerformLayout();
            this.tableStatus.ResumeLayout(false);
            this.tableStatus.PerformLayout();
            this.tablePriority.ResumeLayout(false);
            this.tablePriority.PerformLayout();
            this.tableResponsible.ResumeLayout(false);
            this.tableResponsible.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableTile;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TableLayoutPanel tableStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.TableLayoutPanel tablePriority;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.ComboBox comboPriority;
        private System.Windows.Forms.TableLayoutPanel tableResponsible;
        private System.Windows.Forms.Label labelResponsible;
        private System.Windows.Forms.ComboBox comboResponsible;
    }
}
