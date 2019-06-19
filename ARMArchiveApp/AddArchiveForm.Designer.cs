namespace ARMArchiveApp
{
    partial class AddArchiveForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.rackTextBox = new System.Windows.Forms.TextBox();
            this.shelfTextBox = new System.Windows.Forms.TextBox();
            this.cellTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите номер ячейки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введите номер полки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите номер стелажа";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(80, 232);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(114, 45);
            this.button.TabIndex = 1;
            this.button.Text = "Добавить";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.ButtonClick);
            // 
            // rackTextBox
            // 
            this.rackTextBox.Location = new System.Drawing.Point(10, 26);
            this.rackTextBox.Name = "rackTextBox";
            this.rackTextBox.Size = new System.Drawing.Size(132, 20);
            this.rackTextBox.TabIndex = 2;
            // 
            // shelfTextBox
            // 
            this.shelfTextBox.Location = new System.Drawing.Point(10, 80);
            this.shelfTextBox.Name = "shelfTextBox";
            this.shelfTextBox.Size = new System.Drawing.Size(127, 20);
            this.shelfTextBox.TabIndex = 3;
            // 
            // cellTextBox
            // 
            this.cellTextBox.Location = new System.Drawing.Point(10, 142);
            this.cellTextBox.Name = "cellTextBox";
            this.cellTextBox.Size = new System.Drawing.Size(127, 20);
            this.cellTextBox.TabIndex = 4;
            // 
            // AddArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 311);
            this.Controls.Add(this.cellTextBox);
            this.Controls.Add(this.shelfTextBox);
            this.Controls.Add(this.rackTextBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "AddArchiveForm";
            this.Text = "AddArchiveForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox rackTextBox;
        private System.Windows.Forms.TextBox shelfTextBox;
        private System.Windows.Forms.TextBox cellTextBox;
    }
}