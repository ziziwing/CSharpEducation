namespace ProjectManager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("lvGroupTODO", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("lvGroupInWork", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("lvGroupReview", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("lvGroupClosed", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("TODO");
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("lvGroupTODO", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "InWork"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, null);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("lvGroupInWork", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Review");
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("lvGroupReview", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Closed");
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("lvGroupClosed", System.Windows.Forms.HorizontalAlignment.Center);
            this.Newtask = new System.Windows.Forms.Button();
            this.AddResponsible = new System.Windows.Forms.Button();
            this.listTasks = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // Newtask
            // 
            this.Newtask.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Newtask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Newtask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Newtask.Location = new System.Drawing.Point(12, 12);
            this.Newtask.Name = "Newtask";
            this.Newtask.Size = new System.Drawing.Size(143, 50);
            this.Newtask.TabIndex = 0;
            this.Newtask.Text = "Создать задачу";
            this.Newtask.UseVisualStyleBackColor = false;
            this.Newtask.Click += new System.EventHandler(this.Newtask_Click);
            // 
            // AddResponsible
            // 
            this.AddResponsible.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddResponsible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddResponsible.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddResponsible.Location = new System.Drawing.Point(161, 12);
            this.AddResponsible.Name = "AddResponsible";
            this.AddResponsible.Size = new System.Drawing.Size(143, 50);
            this.AddResponsible.TabIndex = 0;
            this.AddResponsible.Text = "Добавить ответственного";
            this.AddResponsible.UseVisualStyleBackColor = false;
            this.AddResponsible.Click += new System.EventHandler(this.AddResponsible_Click);
            // 
            // listTasks
            // 
            this.listTasks.GridLines = true;
            listViewGroup1.Header = "lvGroupTODO";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "lvGroupTODO";
            listViewGroup1.Tag = "TODO";
            listViewGroup2.Header = "lvGroupInWork";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "lvGroupInWork";
            listViewGroup2.Tag = "InWork";
            listViewGroup3.Header = "lvGroupReview";
            listViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup3.Name = "lvGroupReview";
            listViewGroup3.Tag = "Review";
            listViewGroup4.Header = "lvGroupClosed";
            listViewGroup4.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup4.Name = "lvGroupClosed";
            listViewGroup4.Tag = "Closed";
            this.listTasks.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.listTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listTasks.HideSelection = false;
            listViewGroup5.Header = "lvGroupTODO";
            listViewGroup5.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup5.Name = "lvGroupTODO";
            listViewGroup5.Tag = "TODO";
            listViewItem1.Group = listViewGroup5;
            listViewItem1.Tag = "TODO";
            listViewGroup6.Header = "lvGroupInWork";
            listViewGroup6.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup6.Name = "lvGroupInWork";
            listViewGroup6.Tag = "InWork";
            listViewItem2.Group = listViewGroup6;
            listViewItem2.Tag = "InWork";
            listViewGroup7.Header = "lvGroupReview";
            listViewGroup7.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup7.Name = "lvGroupReview";
            listViewGroup7.Tag = "Review";
            listViewItem3.Group = listViewGroup7;
            listViewItem3.Tag = "Review";
            listViewGroup8.Header = "lvGroupClosed";
            listViewGroup8.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup8.Name = "lvGroupClosed";
            listViewGroup8.Tag = "Closed";
            listViewItem4.Group = listViewGroup8;
            listViewItem4.Tag = "Closed";
            this.listTasks.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.listTasks.Location = new System.Drawing.Point(12, 73);
            this.listTasks.Name = "listTasks";
            this.listTasks.Size = new System.Drawing.Size(611, 370);
            this.listTasks.TabIndex = 1;
            this.listTasks.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listTasks);
            this.Controls.Add(this.AddResponsible);
            this.Controls.Add(this.Newtask);
            this.Name = "MainForm";
            this.Text = "Project Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Newtask;
        private System.Windows.Forms.Button AddResponsible;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView listTasks;
    }
}

