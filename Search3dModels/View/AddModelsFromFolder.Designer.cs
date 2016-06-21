namespace Search3dModels
{
    partial class AddModelsFromFolder
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
            this.addSelectedButton = new System.Windows.Forms.Button();
            this.modelsFromFolderDataGridView = new System.Windows.Forms.DataGridView();
            this.selectButton = new System.Windows.Forms.Button();
            this.addAllutton = new System.Windows.Forms.Button();
            this.selectedPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.modelsFromFolderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addSelectedButton
            // 
            this.addSelectedButton.Location = new System.Drawing.Point(135, 363);
            this.addSelectedButton.Name = "addSelectedButton";
            this.addSelectedButton.Size = new System.Drawing.Size(102, 23);
            this.addSelectedButton.TabIndex = 0;
            this.addSelectedButton.Text = "Add Selected";
            this.addSelectedButton.UseVisualStyleBackColor = true;
            this.addSelectedButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // modelsFromFolderDataGridView
            // 
            this.modelsFromFolderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modelsFromFolderDataGridView.Location = new System.Drawing.Point(28, 66);
            this.modelsFromFolderDataGridView.Name = "modelsFromFolderDataGridView";
            this.modelsFromFolderDataGridView.Size = new System.Drawing.Size(574, 281);
            this.modelsFromFolderDataGridView.TabIndex = 1;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(527, 22);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 2;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addAllutton
            // 
            this.addAllutton.Location = new System.Drawing.Point(382, 363);
            this.addAllutton.Name = "addAllutton";
            this.addAllutton.Size = new System.Drawing.Size(75, 23);
            this.addAllutton.TabIndex = 3;
            this.addAllutton.Text = "Add All";
            this.addAllutton.UseVisualStyleBackColor = true;
            // 
            // selectedPath
            // 
            this.selectedPath.Location = new System.Drawing.Point(28, 22);
            this.selectedPath.Name = "selectedPath";
            this.selectedPath.Size = new System.Drawing.Size(481, 20);
            this.selectedPath.TabIndex = 4;
            // 
            // AddModelsFromFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 398);
            this.Controls.Add(this.selectedPath);
            this.Controls.Add(this.addAllutton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.modelsFromFolderDataGridView);
            this.Controls.Add(this.addSelectedButton);
            this.Name = "AddModelsFromFolder";
            this.Text = "Add Models From Folder";
            ((System.ComponentModel.ISupportInitialize)(this.modelsFromFolderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSelectedButton;
        private System.Windows.Forms.DataGridView modelsFromFolderDataGridView;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button addAllutton;
        private System.Windows.Forms.TextBox selectedPath;
    }
}