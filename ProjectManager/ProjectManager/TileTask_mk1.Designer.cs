namespace ProjectManager
{
    partial class TileTask_mk1
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
            this.tableUC = new System.Windows.Forms.TableLayoutPanel();
            this.labelID = new System.Windows.Forms.Label();
            this.listStatus = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDiscription = new System.Windows.Forms.Label();
            this.labelResponsible = new System.Windows.Forms.Label();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.listPriority = new System.Windows.Forms.ListBox();
            this.listResponsible = new System.Windows.Forms.ListBox();
            this.tableUC.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableUC
            // 
            this.tableUC.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableUC.ColumnCount = 2;
            this.tableUC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableUC.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableUC.Controls.Add(this.labelID, 0, 0);
            this.tableUC.Controls.Add(this.listStatus, 1, 0);
            this.tableUC.Controls.Add(this.labelName, 0, 1);
            this.tableUC.Controls.Add(this.labelDiscription, 0, 2);
            this.tableUC.Controls.Add(this.labelResponsible, 0, 3);
            this.tableUC.Controls.Add(this.labelDeadline, 0, 4);
            this.tableUC.Controls.Add(this.listPriority, 1, 4);
            this.tableUC.Controls.Add(this.listResponsible, 1, 3);
            this.tableUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableUC.Location = new System.Drawing.Point(0, 0);
            this.tableUC.Name = "tableUC";
            this.tableUC.RowCount = 5;
            this.tableUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableUC.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableUC.Size = new System.Drawing.Size(234, 262);
            this.tableUC.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(5, 20);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(15, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "id";
            // 
            // listStatus
            // 
            this.listStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listStatus.BackColor = System.Drawing.SystemColors.Control;
            this.listStatus.FormattingEnabled = true;
            this.listStatus.Location = new System.Drawing.Point(121, 18);
            this.listStatus.Name = "listStatus";
            this.listStatus.Size = new System.Drawing.Size(108, 17);
            this.listStatus.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(5, 72);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "name";
            // 
            // labelDiscription
            // 
            this.labelDiscription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDiscription.AutoSize = true;
            this.labelDiscription.Location = new System.Drawing.Point(5, 124);
            this.labelDiscription.Name = "labelDiscription";
            this.labelDiscription.Size = new System.Drawing.Size(54, 13);
            this.labelDiscription.TabIndex = 0;
            this.labelDiscription.Text = "discription";
            // 
            // labelResponsible
            // 
            this.labelResponsible.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResponsible.AutoSize = true;
            this.labelResponsible.Location = new System.Drawing.Point(5, 176);
            this.labelResponsible.Name = "labelResponsible";
            this.labelResponsible.Size = new System.Drawing.Size(61, 13);
            this.labelResponsible.TabIndex = 0;
            this.labelResponsible.Text = "responcible";
            // 
            // labelDeadline
            // 
            this.labelDeadline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDeadline.Location = new System.Drawing.Point(5, 228);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(47, 13);
            this.labelDeadline.TabIndex = 0;
            this.labelDeadline.Text = "deadline";
            this.labelDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listPriority
            // 
            this.listPriority.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listPriority.BackColor = System.Drawing.SystemColors.Control;
            this.listPriority.FormattingEnabled = true;
            this.listPriority.Location = new System.Drawing.Point(121, 226);
            this.listPriority.Name = "listPriority";
            this.listPriority.Size = new System.Drawing.Size(108, 17);
            this.listPriority.TabIndex = 2;
            // 
            // listResponsible
            // 
            this.listResponsible.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.listResponsible.BackColor = System.Drawing.SystemColors.Control;
            this.listResponsible.FormattingEnabled = true;
            this.listResponsible.Location = new System.Drawing.Point(121, 174);
            this.listResponsible.Name = "listResponsible";
            this.listResponsible.Size = new System.Drawing.Size(108, 17);
            this.listResponsible.TabIndex = 3;
            // 
            // TileTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableUC);
            this.Name = "TileTask";
            this.Size = new System.Drawing.Size(234, 262);
            this.tableUC.ResumeLayout(false);
            this.tableUC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDiscription;
        private System.Windows.Forms.Label labelResponsible;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.ListBox listStatus;
        private System.Windows.Forms.ListBox listPriority;
        private System.Windows.Forms.ListBox listResponsible;
        public System.Windows.Forms.TableLayoutPanel tableUC;
    }
}
