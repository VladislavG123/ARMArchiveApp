namespace ARMArchiveApp
{
    partial class AddDocumentForm
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
            this.cellTextBox = new System.Windows.Forms.TextBox();
            this.shelfTextBox = new System.Windows.Forms.TextBox();
            this.rackTextBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cellTextBox
            // 
            this.cellTextBox.Location = new System.Drawing.Point(12, 147);
            this.cellTextBox.Name = "cellTextBox";
            this.cellTextBox.Size = new System.Drawing.Size(127, 20);
            this.cellTextBox.TabIndex = 11;
            // 
            // shelfTextBox
            // 
            this.shelfTextBox.Location = new System.Drawing.Point(12, 85);
            this.shelfTextBox.Name = "shelfTextBox";
            this.shelfTextBox.Size = new System.Drawing.Size(127, 20);
            this.shelfTextBox.TabIndex = 10;
            // 
            // rackTextBox
            // 
            this.rackTextBox.Location = new System.Drawing.Point(12, 31);
            this.rackTextBox.Name = "rackTextBox";
            this.rackTextBox.Size = new System.Drawing.Size(132, 20);
            this.rackTextBox.TabIndex = 9;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(82, 237);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(114, 45);
            this.button.TabIndex = 8;
            this.button.Text = "Добавить";
            this.button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите номер ячейки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите номер стелажа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите номер полки";
            // 
            // AddDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 304);
            this.Controls.Add(this.cellTextBox);
            this.Controls.Add(this.shelfTextBox);
            this.Controls.Add(this.rackTextBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "AddDocumentForm";
            this.Text = "AddDocumentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cellTextBox;
        private System.Windows.Forms.TextBox shelfTextBox;
        private System.Windows.Forms.TextBox rackTextBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}