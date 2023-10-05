namespace ProjectManager
{
    partial class TileTaks
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
            this.panelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.labelId = new System.Windows.Forms.Label();
            this.boxStatus = new System.Windows.Forms.ListBox();
            this.boxPriority = new System.Windows.Forms.ListBox();
            this.panelTask = new System.Windows.Forms.TableLayoutPanel();
            this.textDiscription = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.boxResponcible = new System.Windows.Forms.ListBox();
            this.textDeadline = new System.Windows.Forms.TextBox();
            this.labelResponcible = new System.Windows.Forms.Label();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.labelDiscription = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            this.panelTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.ColumnCount = 1;
            this.panelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelInfo.Controls.Add(this.labelId, 0, 0);
            this.panelInfo.Controls.Add(this.boxStatus, 0, 1);
            this.panelInfo.Controls.Add(this.boxPriority, 0, 2);
            this.panelInfo.Location = new System.Drawing.Point(3, 3);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.RowCount = 3;
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.panelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.panelInfo.Size = new System.Drawing.Size(300, 90);
            this.panelInfo.TabIndex = 0;
            // 
            // labelId
            // 
            this.labelId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(4, 2);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 20);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "id";
            // 
            // boxStatus
            // 
            this.boxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxStatus.FormattingEnabled = true;
            this.boxStatus.ItemHeight = 14;
            this.boxStatus.Location = new System.Drawing.Point(4, 27);
            this.boxStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxStatus.Name = "boxStatus";
            this.boxStatus.Size = new System.Drawing.Size(292, 26);
            this.boxStatus.TabIndex = 1;
            // 
            // boxPriority
            // 
            this.boxPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxPriority.FormattingEnabled = true;
            this.boxPriority.ItemHeight = 14;
            this.boxPriority.Location = new System.Drawing.Point(4, 59);
            this.boxPriority.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.boxPriority.Name = "boxPriority";
            this.boxPriority.Size = new System.Drawing.Size(292, 28);
            this.boxPriority.TabIndex = 1;
            // 
            // panelTask
            // 
            this.panelTask.ColumnCount = 1;
            this.panelTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTask.Controls.Add(this.textDiscription, 0, 3);
            this.panelTask.Controls.Add(this.textName, 0, 1);
            this.panelTask.Controls.Add(this.boxResponcible, 0, 7);
            this.panelTask.Controls.Add(this.textDeadline, 0, 5);
            this.panelTask.Controls.Add(this.labelResponcible, 0, 6);
            this.panelTask.Controls.Add(this.labelDeadline, 0, 4);
            this.panelTask.Controls.Add(this.labelDiscription, 0, 2);
            this.panelTask.Controls.Add(this.labelName, 0, 0);
            this.panelTask.Location = new System.Drawing.Point(3, 99);
            this.panelTask.Name = "panelTask";
            this.panelTask.RowCount = 6;
            this.panelTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.panelTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.panelTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.panelTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panelTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.panelTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.panelTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.panelTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.panelTask.Size = new System.Drawing.Size(300, 300);
            this.panelTask.TabIndex = 1;
            // 
            // textDiscription
            // 
            this.textDiscription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDiscription.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDiscription.Location = new System.Drawing.Point(3, 96);
            this.textDiscription.Multiline = true;
            this.textDiscription.Name = "textDiscription";
            this.textDiscription.Size = new System.Drawing.Size(294, 69);
            this.textDiscription.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textName.Location = new System.Drawing.Point(3, 30);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(294, 21);
            this.textName.TabIndex = 2;
            // 
            // boxResponcible
            // 
            this.boxResponcible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxResponcible.FormattingEnabled = true;
            this.boxResponcible.ItemHeight = 14;
            this.boxResponcible.Location = new System.Drawing.Point(3, 264);
            this.boxResponcible.Name = "boxResponcible";
            this.boxResponcible.Size = new System.Drawing.Size(294, 33);
            this.boxResponcible.TabIndex = 3;
            // 
            // textDeadline
            // 
            this.textDeadline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textDeadline.Location = new System.Drawing.Point(3, 198);
            this.textDeadline.Name = "textDeadline";
            this.textDeadline.Size = new System.Drawing.Size(294, 20);
            this.textDeadline.TabIndex = 4;
            // 
            // labelResponcible
            // 
            this.labelResponcible.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelResponcible.AutoSize = true;
            this.labelResponcible.Location = new System.Drawing.Point(3, 240);
            this.labelResponcible.Name = "labelResponcible";
            this.labelResponcible.Size = new System.Drawing.Size(94, 14);
            this.labelResponcible.TabIndex = 5;
            this.labelResponcible.Text = "Ответственный";
            // 
            // labelDeadline
            // 
            this.labelDeadline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Location = new System.Drawing.Point(3, 174);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(84, 14);
            this.labelDeadline.TabIndex = 6;
            this.labelDeadline.Text = "Трудозатраты";
            // 
            // labelDiscription
            // 
            this.labelDiscription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelDiscription.AutoSize = true;
            this.labelDiscription.Location = new System.Drawing.Point(3, 72);
            this.labelDiscription.Name = "labelDiscription";
            this.labelDiscription.Size = new System.Drawing.Size(62, 14);
            this.labelDiscription.TabIndex = 7;
            this.labelDiscription.Text = "Описание";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(90, 14);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Наименование";
            // 
            // TileTaks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.panelInfo);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TileTaks";
            this.Size = new System.Drawing.Size(305, 408);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelTask.ResumeLayout(false);
            this.panelTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelInfo;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.ListBox boxStatus;
        private System.Windows.Forms.ListBox boxPriority;
        private System.Windows.Forms.TableLayoutPanel panelTask;
        private System.Windows.Forms.TextBox textDiscription;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ListBox boxResponcible;
        private System.Windows.Forms.TextBox textDeadline;
        private System.Windows.Forms.Label labelResponcible;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Label labelDiscription;
        private System.Windows.Forms.Label labelName;
    }
}
