namespace Search3dModels
{
    partial class AddModel
    {
        
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

   
        private void InitializeComponent()
        {
            assFromFolderButton = new System.Windows.Forms.Button();
            AddModelButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            nameGetModel = new System.Windows.Forms.TextBox();
            heighGetModel = new System.Windows.Forms.TextBox();
            lengthGetModel = new System.Windows.Forms.TextBox();
            widthGetModel = new System.Windows.Forms.TextBox();
            privateModelCheckBox = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // assFromFolderButton
            // 
            assFromFolderButton.Location = new System.Drawing.Point(61, 337);
            assFromFolderButton.Name = "assFromFolderButton";
            assFromFolderButton.Size = new System.Drawing.Size(239, 23);
            assFromFolderButton.TabIndex = 0;
            assFromFolderButton.Text = "Add Models From Folder";
            assFromFolderButton.UseVisualStyleBackColor = true;
            assFromFolderButton.Click += new System.EventHandler(button1_Click);
            // 
            // AddModelButton
            // 
            AddModelButton.Location = new System.Drawing.Point(61, 245);
            AddModelButton.Name = "AddModelButton";
            AddModelButton.Size = new System.Drawing.Size(239, 39);
            AddModelButton.TabIndex = 1;
            AddModelButton.Text = "Add";
            AddModelButton.UseVisualStyleBackColor = true;
            AddModelButton.Click += new System.EventHandler(button1_Click_1);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(61, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(61, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 13);
            label2.TabIndex = 3;
            label2.Text = "Heigh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(61, 113);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 13);
            label3.TabIndex = 4;
            label3.Text = "Length:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(61, 151);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 13);
            label4.TabIndex = 5;
            label4.Text = "Width:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(167, 304);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(21, 13);
            label5.TabIndex = 6;
            label5.Text = "Or:";
            // 
            // nameGetModel
            // 
            nameGetModel.Location = new System.Drawing.Point(147, 35);
            nameGetModel.Name = "nameGetModel";
            nameGetModel.Size = new System.Drawing.Size(153, 20);
            nameGetModel.TabIndex = 7;
            nameGetModel.TextChanged += new System.EventHandler(nameGetModel_TextChanged);
            // 
            // heighGetModel
            // 
            heighGetModel.Location = new System.Drawing.Point(147, 73);
            heighGetModel.Name = "heighGetModel";
            heighGetModel.Size = new System.Drawing.Size(153, 20);
            heighGetModel.TabIndex = 8;
            heighGetModel.TextChanged += new System.EventHandler(heighGetModel_TextChanged);
            // 
            // lengthGetModel
            // 
            lengthGetModel.Location = new System.Drawing.Point(147, 113);
            lengthGetModel.Name = "lengthGetModel";
            lengthGetModel.Size = new System.Drawing.Size(153, 20);
            lengthGetModel.TabIndex = 9;
            lengthGetModel.TextChanged += new System.EventHandler(lengthGetModel_TextChanged);
            // 
            // widthGetModel
            // 
            widthGetModel.Location = new System.Drawing.Point(147, 148);
            widthGetModel.Name = "widthGetModel";
            widthGetModel.Size = new System.Drawing.Size(153, 20);
            widthGetModel.TabIndex = 10;
            widthGetModel.TextChanged += new System.EventHandler(widthGetModel_TextChanged);
            // 
            // privateModelCheckBox
            // 
            privateModelCheckBox.AutoSize = true;
            privateModelCheckBox.Location = new System.Drawing.Point(147, 201);
            privateModelCheckBox.Name = "privateModelCheckBox";
            privateModelCheckBox.Size = new System.Drawing.Size(91, 17);
            privateModelCheckBox.TabIndex = 11;
            privateModelCheckBox.Text = "Private Model";
            privateModelCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddModel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(373, 387);
            Controls.Add(privateModelCheckBox);
            Controls.Add(widthGetModel);
            Controls.Add(lengthGetModel);
            Controls.Add(heighGetModel);
            Controls.Add(nameGetModel);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AddModelButton);
            Controls.Add(assFromFolderButton);
            Name = "AddModel";
            Text = "Add Model";
            Load += new System.EventHandler(AddModel_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public static System.Windows.Forms.Button assFromFolderButton;
        public static System.Windows.Forms.Button AddModelButton;
        public static System.Windows.Forms.Label label1;
        public static System.Windows.Forms.Label label2;
        public static System.Windows.Forms.Label label3;
        public static System.Windows.Forms.Label label4;
        public static System.Windows.Forms.Label label5;
        public static System.Windows.Forms.TextBox nameGetModel;
        public static System.Windows.Forms.TextBox heighGetModel;
        public static System.Windows.Forms.TextBox lengthGetModel;
        public static System.Windows.Forms.TextBox widthGetModel;
        public static System.Windows.Forms.CheckBox privateModelCheckBox;


    }
}