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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.receiptDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.themesDataGridView = new System.Windows.Forms.DataGridView();
            this.themeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.themesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cellTextBox
            // 
            this.cellTextBox.Location = new System.Drawing.Point(12, 147);
            this.cellTextBox.Name = "cellTextBox";
            this.cellTextBox.Size = new System.Drawing.Size(127, 20);
            this.cellTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(127, 20);
            this.nameTextBox.TabIndex = 10;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(12, 31);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(132, 20);
            this.numberTextBox.TabIndex = 9;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(373, 247);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(114, 45);
            this.button.TabIndex = 8;
            this.button.Text = "Добавить";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.ButtonClick);
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
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите номер документа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите название документа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите количество документов";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(266, 31);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(127, 20);
            this.amountTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Введите дату поступления";
            // 
            // receiptDatePicker
            // 
            this.receiptDatePicker.Location = new System.Drawing.Point(266, 84);
            this.receiptDatePicker.Name = "receiptDatePicker";
            this.receiptDatePicker.Size = new System.Drawing.Size(170, 20);
            this.receiptDatePicker.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Введите темы документа";
            // 
            // themesDataGridView
            // 
            this.themesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.themesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.themeColumn});
            this.themesDataGridView.Location = new System.Drawing.Point(12, 207);
            this.themesDataGridView.Name = "themesDataGridView";
            this.themesDataGridView.Size = new System.Drawing.Size(330, 95);
            this.themesDataGridView.TabIndex = 13;
            // 
            // themeColumn
            // 
            this.themeColumn.HeaderText = "Темы";
            this.themeColumn.Name = "themeColumn";
            // 
            // AddDocumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 304);
            this.Controls.Add(this.themesDataGridView);
            this.Controls.Add(this.receiptDatePicker);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.cellTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "AddDocumentForm";
            this.Text = "AddDocumentForm";
            ((System.ComponentModel.ISupportInitialize)(this.themesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cellTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker receiptDatePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView themesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn themeColumn;
    }
}