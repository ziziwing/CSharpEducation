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
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.Newtask = new System.Windows.Forms.Button();
            this.AddResponsible = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Newtask
            // 
            this.Newtask.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Newtask.Location = new System.Drawing.Point(12, 12);
            this.Newtask.Name = "Newtask";
            this.Newtask.Size = new System.Drawing.Size(143, 50);
            this.Newtask.TabIndex = 0;
            this.Newtask.Text = "Создать задачу";
            this.Newtask.UseVisualStyleBackColor = true;
            // 
            // AddResponsible
            // 
            this.AddResponsible.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddResponsible.Location = new System.Drawing.Point(161, 12);
            this.AddResponsible.Name = "AddResponsible";
            this.AddResponsible.Size = new System.Drawing.Size(143, 50);
            this.AddResponsible.TabIndex = 0;
            this.AddResponsible.Text = "Добавить ответственного";
            this.AddResponsible.UseVisualStyleBackColor = true;
            this.AddResponsible.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listView1
            // 
            listViewGroup5.Header = "ListViewGroup";
            listViewGroup5.Name = "TODO";
            listViewGroup6.Header = "ListViewGroup";
            listViewGroup6.Name = "InWork";
            listViewGroup7.Header = "ListViewGroup";
            listViewGroup7.Name = "Review";
            listViewGroup8.Header = "ListViewGroup";
            listViewGroup8.Name = "Closed";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(611, 370);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.AddResponsible);
            this.Controls.Add(this.Newtask);
            this.Name = "MainForm";
            this.Text = "Project Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Newtask;
        private System.Windows.Forms.Button AddResponsible;
        private System.Windows.Forms.ListView listView1;
    }
}

