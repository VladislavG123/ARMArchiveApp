namespace ARMArchiveApp
{
    partial class AddDeliveryForm
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
            this.gettingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.subscribersComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gettingDateTimePicker
            // 
            this.gettingDateTimePicker.Location = new System.Drawing.Point(12, 65);
            this.gettingDateTimePicker.Name = "gettingDateTimePicker";
            this.gettingDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.gettingDateTimePicker.TabIndex = 0;
            // 
            // subscribersComboBox
            // 
            this.subscribersComboBox.FormattingEnabled = true;
            this.subscribersComboBox.Location = new System.Drawing.Point(12, 163);
            this.subscribersComboBox.Name = "subscribersComboBox";
            this.subscribersComboBox.Size = new System.Drawing.Size(200, 21);
            this.subscribersComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите абонента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите дату выдачи";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(207, 253);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(109, 47);
            this.button.TabIndex = 4;
            this.button.Text = "Добавить";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.ButtonClick);
            // 
            // AddDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 312);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subscribersComboBox);
            this.Controls.Add(this.gettingDateTimePicker);
            this.Name = "AddDeliveryForm";
            this.Text = "AddDeliveryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker gettingDateTimePicker;
        private System.Windows.Forms.ComboBox subscribersComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button;
    }
}