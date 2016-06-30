namespace Search3dModels
{
    partial class GetModels
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            scaleCheckBox = new System.Windows.Forms.CheckBox();
            allModelsCheckBox = new System.Windows.Forms.CheckBox();
            searchButton = new System.Windows.Forms.Button();
            openSelectedButton = new System.Windows.Forms.Button();
            heightInput = new System.Windows.Forms.TextBox();
            lengthInput = new System.Windows.Forms.TextBox();
            widthInput = new System.Windows.Forms.TextBox();
            scaleFactorInput = new System.Windows.Forms.TextBox();
            resultsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(resultsDataGridView)).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(72, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 13);
            label1.TabIndex = 1;
            label1.Text = "Specify:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(203, 26);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 13);
            label2.TabIndex = 2;
            label2.Text = "Results:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 54);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 13);
            label4.TabIndex = 4;
            label4.Text = "Height:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(17, 90);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 13);
            label5.TabIndex = 5;
            label5.Text = "Length:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(17, 131);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(38, 13);
            label6.TabIndex = 6;
            label6.Text = "Width:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(17, 194);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(84, 13);
            label11.TabIndex = 12;
            label11.Text = "Scale Factor(%):";
            // 
            // scaleCheckBox
            // 
            scaleCheckBox.AutoSize = true;
            scaleCheckBox.Checked = true;
            scaleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            scaleCheckBox.Location = new System.Drawing.Point(20, 230);
            scaleCheckBox.Name = "scaleCheckBox";
            scaleCheckBox.Size = new System.Drawing.Size(53, 17);
            scaleCheckBox.TabIndex = 13;
            scaleCheckBox.Text = "Scale";
            scaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // allModelsCheckBox
            // 
            allModelsCheckBox.AutoSize = true;
            allModelsCheckBox.Checked = true;
            allModelsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            allModelsCheckBox.Location = new System.Drawing.Point(20, 267);
            allModelsCheckBox.Name = "allModelsCheckBox";
            allModelsCheckBox.Size = new System.Drawing.Size(74, 17);
            allModelsCheckBox.TabIndex = 14;
            allModelsCheckBox.Text = "All Models";
            allModelsCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.Location = new System.Drawing.Point(20, 337);
            searchButton.Name = "searchButton";
            searchButton.Size = new System.Drawing.Size(168, 23);
            searchButton.TabIndex = 15;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += new System.EventHandler(searchButton_Click);
            // 
            // openSelectedButton
            // 
            openSelectedButton.Location = new System.Drawing.Point(402, 375);
            openSelectedButton.Name = "openSelectedButton";
            openSelectedButton.Size = new System.Drawing.Size(136, 23);
            openSelectedButton.TabIndex = 16;
            openSelectedButton.Text = "Open Selected";
            openSelectedButton.UseVisualStyleBackColor = true;
            openSelectedButton.Click += new System.EventHandler(openSelectedButton_Click);
            // 
            // heightInput
            // 
            heightInput.Location = new System.Drawing.Point(88, 51);
            heightInput.Name = "heightInput";
            heightInput.Size = new System.Drawing.Size(100, 20);
            heightInput.TabIndex = 18;
            // 
            // lengthInput
            // 
            lengthInput.Location = new System.Drawing.Point(88, 87);
            lengthInput.Name = "lengthInput";
            lengthInput.Size = new System.Drawing.Size(100, 20);
            lengthInput.TabIndex = 19;
            // 
            // widthInput
            // 
            widthInput.Location = new System.Drawing.Point(88, 128);
            widthInput.Name = "widthInput";
            widthInput.Size = new System.Drawing.Size(100, 20);
            widthInput.TabIndex = 20;
            // 
            // scaleFactorInput
            // 
            scaleFactorInput.Location = new System.Drawing.Point(107, 191);
            scaleFactorInput.Name = "scaleFactorInput";
            scaleFactorInput.Size = new System.Drawing.Size(81, 20);
            scaleFactorInput.TabIndex = 21;
            scaleFactorInput.Text = "15";
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            resultsDataGridView.Location = new System.Drawing.Point(206, 51);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            resultsDataGridView.Size = new System.Drawing.Size(545, 309);
            resultsDataGridView.TabIndex = 22;
            // 
            // GetModels
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(777, 410);
            Controls.Add(resultsDataGridView);
            Controls.Add(scaleFactorInput);
            Controls.Add(widthInput);
            Controls.Add(lengthInput);
            Controls.Add(heightInput);
            Controls.Add(openSelectedButton);
            Controls.Add(searchButton);
            Controls.Add(allModelsCheckBox);
            Controls.Add(scaleCheckBox);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "GetModels";
            Text = "Get Models";
            ((System.ComponentModel.ISupportInitialize)(resultsDataGridView)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public static System.Windows.Forms.Label label1;
        public static System.Windows.Forms.Label label2;
        public static System.Windows.Forms.Label label4;
        public static System.Windows.Forms.Label label5;
        public static System.Windows.Forms.Label label6;
        public static System.Windows.Forms.Label label11;
        public static System.Windows.Forms.CheckBox scaleCheckBox;
        public static System.Windows.Forms.CheckBox allModelsCheckBox;
        public static System.Windows.Forms.Button searchButton;
        public static System.Windows.Forms.Button openSelectedButton;
        public static System.Windows.Forms.TextBox heightInput;
        public static System.Windows.Forms.TextBox lengthInput;
        public static System.Windows.Forms.TextBox widthInput;
        public static System.Windows.Forms.TextBox scaleFactorInput;
        public static System.Windows.Forms.DataGridView resultsDataGridView;










    }
}