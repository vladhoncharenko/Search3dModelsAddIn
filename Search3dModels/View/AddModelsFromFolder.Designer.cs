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
            addSelectedButton = new System.Windows.Forms.Button();
            selectButton = new System.Windows.Forms.Button();
            addAllutton = new System.Windows.Forms.Button();
            selectedPath = new System.Windows.Forms.TextBox();
            modelsFromFolderLB = new System.Windows.Forms.ListBox();
            privateModelCheckBox = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // addSelectedButton
            // 
            addSelectedButton.Location = new System.Drawing.Point(135, 363);
            addSelectedButton.Name = "addSelectedButton";
            addSelectedButton.Size = new System.Drawing.Size(102, 23);
            addSelectedButton.TabIndex = 0;
            addSelectedButton.Text = "Add Selected";
            addSelectedButton.UseVisualStyleBackColor = true;
            addSelectedButton.Click += new System.EventHandler(button1_Click);
            // 
            // selectButton
            // 
            selectButton.Location = new System.Drawing.Point(527, 20);
            selectButton.Name = "selectButton";
            selectButton.Size = new System.Drawing.Size(75, 23);
            selectButton.TabIndex = 2;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += new System.EventHandler(button2_Click);
            // 
            // addAllutton
            // 
            addAllutton.Location = new System.Drawing.Point(382, 363);
            addAllutton.Name = "addAllutton";
            addAllutton.Size = new System.Drawing.Size(75, 23);
            addAllutton.TabIndex = 3;
            addAllutton.Text = "Add All";
            addAllutton.UseVisualStyleBackColor = true;
            addAllutton.Click += new System.EventHandler(addAllutton_Click);
            // 
            // selectedPath
            // 
            selectedPath.Location = new System.Drawing.Point(28, 22);
            selectedPath.Name = "selectedPath";
            selectedPath.Size = new System.Drawing.Size(481, 20);
            selectedPath.TabIndex = 4;
            // 
            // modelsFromFolderLB
            // 
            modelsFromFolderLB.FormattingEnabled = true;
            modelsFromFolderLB.Location = new System.Drawing.Point(28, 85);
            modelsFromFolderLB.Name = "modelsFromFolderLB";
            modelsFromFolderLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            modelsFromFolderLB.Size = new System.Drawing.Size(574, 251);
            modelsFromFolderLB.TabIndex = 5;
            // 
            // privateModelCheckBox
            // 
            privateModelCheckBox.AutoSize = true;
            privateModelCheckBox.Location = new System.Drawing.Point(28, 56);
            privateModelCheckBox.Name = "privateModelCheckBox";
            privateModelCheckBox.Size = new System.Drawing.Size(96, 17);
            privateModelCheckBox.TabIndex = 6;
            privateModelCheckBox.Text = "Private Models";
            privateModelCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddModelsFromFolder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(633, 398);
            Controls.Add(privateModelCheckBox);
            Controls.Add(modelsFromFolderLB);
            Controls.Add(selectedPath);
            Controls.Add(addAllutton);
            Controls.Add(selectButton);
            Controls.Add(addSelectedButton);
            Name = "AddModelsFromFolder";
            Text = "Add Models From Folder";
            Load += new System.EventHandler(AddModelsFromFolder_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public static System.Windows.Forms.Button addSelectedButton;
        public static System.Windows.Forms.Button selectButton;
        public static System.Windows.Forms.Button addAllutton;
        public static System.Windows.Forms.TextBox selectedPath;
        public static System.Windows.Forms.ListBox modelsFromFolderLB;
        public static System.Windows.Forms.CheckBox privateModelCheckBox;




    }
}