﻿namespace ProjectManager
{
    partial class TaskForm
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
            this.panelTask = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textComment = new System.Windows.Forms.TextBox();
            this.textResponsible = new System.Windows.Forms.TextBox();
            this.textPriority = new System.Windows.Forms.TextBox();
            this.textDeadline = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTask
            // 
            this.panelTask.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTask.Controls.Add(this.label8);
            this.panelTask.Controls.Add(this.label7);
            this.panelTask.Controls.Add(this.label6);
            this.panelTask.Controls.Add(this.label5);
            this.panelTask.Controls.Add(this.textComment);
            this.panelTask.Controls.Add(this.textResponsible);
            this.panelTask.Controls.Add(this.textPriority);
            this.panelTask.Controls.Add(this.textDeadline);
            this.panelTask.Controls.Add(this.label4);
            this.panelTask.Controls.Add(this.textStatus);
            this.panelTask.Controls.Add(this.label3);
            this.panelTask.Controls.Add(this.textDescription);
            this.panelTask.Controls.Add(this.label2);
            this.panelTask.Controls.Add(this.textName);
            this.panelTask.Controls.Add(this.labelTask);
            this.panelTask.Controls.Add(this.buttonClose);
            this.panelTask.Controls.Add(this.button2);
            this.panelTask.Controls.Add(this.buttonSave);
            this.panelTask.Controls.Add(this.button3);
            this.panelTask.Controls.Add(this.button1);
            this.panelTask.Location = new System.Drawing.Point(-2, 0);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(381, 546);
            this.panelTask.TabIndex = 0;
            this.panelTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTask_MouseDown);
            this.panelTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTask_MouseMove);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Комментарий";
            this.label8.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ответственный";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Приоритет";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Трудозатраты";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textComment
            // 
            this.textComment.Location = new System.Drawing.Point(106, 228);
            this.textComment.Multiline = true;
            this.textComment.Name = "textComment";
            this.textComment.Size = new System.Drawing.Size(257, 89);
            this.textComment.TabIndex = 8;
            // 
            // textResponsible
            // 
            this.textResponsible.Location = new System.Drawing.Point(106, 202);
            this.textResponsible.Name = "textResponsible";
            this.textResponsible.Size = new System.Drawing.Size(257, 20);
            this.textResponsible.TabIndex = 8;
            // 
            // textPriority
            // 
            this.textPriority.Location = new System.Drawing.Point(106, 176);
            this.textPriority.Name = "textPriority";
            this.textPriority.Size = new System.Drawing.Size(257, 20);
            this.textPriority.TabIndex = 8;
            // 
            // textDeadline
            // 
            this.textDeadline.Location = new System.Drawing.Point(106, 150);
            this.textDeadline.Name = "textDeadline";
            this.textDeadline.Size = new System.Drawing.Size(257, 20);
            this.textDeadline.TabIndex = 8;
            this.textDeadline.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDeadline_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Статус";
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(106, 124);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(257, 20);
            this.textStatus.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Описание";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(106, 98);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(257, 20);
            this.textDescription.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наименование";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(106, 72);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(257, 20);
            this.textName.TabIndex = 2;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.BackColor = System.Drawing.SystemColors.Info;
            this.labelTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask.Location = new System.Drawing.Point(15, 13);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(78, 25);
            this.labelTask.TabIndex = 1;
            this.labelTask.Text = "Задача";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(208, 500);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(155, 34);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(208, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(14, 500);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(155, 34);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(14, 500);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(14, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 546);
            this.Controls.Add(this.panelTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.panelTask.ResumeLayout(false);
            this.panelTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDeadline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textComment;
        private System.Windows.Forms.TextBox textResponsible;
        private System.Windows.Forms.TextBox textPriority;
    }
}