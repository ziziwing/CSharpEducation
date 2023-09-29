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
            this.textResponcible = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.lebelResponcible = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelResponcible.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResponcible
            // 
            this.panelResponcible.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelResponcible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResponcible.Controls.Add(this.buttonSave);
            this.panelResponcible.Controls.Add(this.buttonClose);
            this.panelResponcible.Controls.Add(this.textResponcible);
            this.panelResponcible.Controls.Add(this.labelName);
            this.panelResponcible.Controls.Add(this.lebelResponcible);
            this.panelResponcible.Location = new System.Drawing.Point(0, 0);
            this.panelResponcible.Name = "panelResponcible";
            this.panelResponcible.Size = new System.Drawing.Size(475, 161);
            this.panelResponcible.TabIndex = 0;
            this.panelResponcible.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTask_MouseDown);
            this.panelResponcible.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTask_MouseMove);
            // 
            // textResponcible
            // 
            this.textResponcible.Location = new System.Drawing.Point(54, 68);
            this.textResponcible.Name = "textResponcible";
            this.textResponcible.Size = new System.Drawing.Size(410, 20);
            this.textResponcible.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 69);
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
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(350, 118);
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
            this.buttonSave.Location = new System.Drawing.Point(230, 118);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(114, 31);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelResponcible;
        private System.Windows.Forms.Label lebelResponcible;
        private System.Windows.Forms.TextBox textResponcible;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
    }
}