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
            this.Newtask = new System.Windows.Forms.Button();
            this.AddResponsible = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.AutoScroll = true;
            this.flowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.flowPanel.Location = new System.Drawing.Point(15, 80);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(920, 410);
            this.flowPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1003, 507);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.AddResponsible);
            this.Controls.Add(this.Newtask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Project Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Newtask;
        private System.Windows.Forms.Button AddResponsible;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}

