namespace ProjectManager
{
    partial class ResponcibleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelResponcible = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textResponcible = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.lebelResponcible = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textContact = new System.Windows.Forms.TextBox();
            this.panelResponcible.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResponcible
            // 
            this.panelResponcible.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelResponcible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResponcible.Controls.Add(this.flowLayoutPanel1);
            this.panelResponcible.Controls.Add(this.textContact);
            this.panelResponcible.Controls.Add(this.label1);
            this.panelResponcible.Controls.Add(this.textResponcible);
            this.panelResponcible.Controls.Add(this.labelName);
            this.panelResponcible.Controls.Add(this.lebelResponcible);
            this.panelResponcible.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResponcible.Location = new System.Drawing.Point(0, 0);
            this.panelResponcible.Name = "panelResponcible";
            this.panelResponcible.Size = new System.Drawing.Size(475, 161);
            this.panelResponcible.TabIndex = 0;
            this.panelResponcible.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTask_MouseDown);
            this.panelResponcible.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTask_MouseMove);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonClose);
            this.flowLayoutPanel1.Controls.Add(this.buttonSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 115);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(473, 44);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(356, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(114, 31);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(236, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(114, 31);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textResponcible
            // 
            this.textResponcible.Location = new System.Drawing.Point(74, 53);
            this.textResponcible.Name = "textResponcible";
            this.textResponcible.Size = new System.Drawing.Size(396, 20);
            this.textResponcible.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(11, 54);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(36, 15);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "ФИО";
            // 
            // lebelResponcible
            // 
            this.lebelResponcible.AutoSize = true;
            this.lebelResponcible.BackColor = System.Drawing.SystemColors.Info;
            this.lebelResponcible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lebelResponcible.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lebelResponcible.Location = new System.Drawing.Point(12, 9);
            this.lebelResponcible.Name = "lebelResponcible";
            this.lebelResponcible.Size = new System.Drawing.Size(260, 25);
            this.lebelResponcible.TabIndex = 0;
            this.lebelResponcible.Text = "Добавить ответственного";
            this.lebelResponcible.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Контакт";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textContact
            // 
            this.textContact.Location = new System.Drawing.Point(74, 79);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(396, 20);
            this.textContact.TabIndex = 2;
            // 
            // ResponcibleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 161);
            this.Controls.Add(this.panelResponcible);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResponcibleForm";
            this.Text = "ResponcibleForm";
            this.panelResponcible.ResumeLayout(false);
            this.panelResponcible.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelResponcible;
        private System.Windows.Forms.Label lebelResponcible;
        private System.Windows.Forms.TextBox textResponcible;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textContact;
        private System.Windows.Forms.Label label1;
    }
}