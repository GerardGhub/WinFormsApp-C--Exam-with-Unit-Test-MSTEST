namespace WinFormsAppSource
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            label1 = new Label();
            cmbStrategy = new ComboBox();
            label2 = new Label();
            btnSort = new Button();
            lblSortedString = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(196, 101);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(121, 23);
            txtInput.TabIndex = 0;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 101);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "User Input:";
            // 
            // cmbStrategy
            // 
            cmbStrategy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStrategy.FormattingEnabled = true;
            cmbStrategy.Location = new Point(196, 143);
            cmbStrategy.Name = "cmbStrategy";
            cmbStrategy.Size = new Size(121, 23);
            cmbStrategy.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 146);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Sorting:";
            // 
            // btnSort
            // 
            btnSort.Location = new Point(220, 213);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 4;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lblSortedString
            // 
            lblSortedString.AutoSize = true;
            lblSortedString.Location = new Point(239, 178);
            lblSortedString.Name = "lblSortedString";
            lblSortedString.Size = new Size(38, 15);
            lblSortedString.TabIndex = 5;
            lblSortedString.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 178);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 6;
            label3.Text = "Expected Output:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
            Controls.Add(label3);
            Controls.Add(lblSortedString);
            Controls.Add(btnSort);
            Controls.Add(label2);
            Controls.Add(cmbStrategy);
            Controls.Add(label1);
            Controls.Add(txtInput);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Label label1;
        private Label label2;
        private Label lblSortedString;
        private ComboBox cmbStrategy;
        public Button btnSort;
        private Label label3;
    }
}
