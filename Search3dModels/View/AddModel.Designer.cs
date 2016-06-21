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
            this.assFromFolderButton = new System.Windows.Forms.Button();
            this.AddNodelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameGetModel = new System.Windows.Forms.TextBox();
            this.heighGetModel = new System.Windows.Forms.TextBox();
            this.lengthGetModel = new System.Windows.Forms.TextBox();
            this.widthGetModel = new System.Windows.Forms.TextBox();
            this.privateModelCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // assFromFolderButton
            // 
            this.assFromFolderButton.Location = new System.Drawing.Point(61, 337);
            this.assFromFolderButton.Name = "assFromFolderButton";
            this.assFromFolderButton.Size = new System.Drawing.Size(239, 23);
            this.assFromFolderButton.TabIndex = 0;
            this.assFromFolderButton.Text = "Add Models From Folder";
            this.assFromFolderButton.UseVisualStyleBackColor = true;
            this.assFromFolderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNodelButton
            // 
            this.AddNodelButton.Location = new System.Drawing.Point(61, 245);
            this.AddNodelButton.Name = "AddNodelButton";
            this.AddNodelButton.Size = new System.Drawing.Size(239, 39);
            this.AddNodelButton.TabIndex = 1;
            this.AddNodelButton.Text = "Add";
            this.AddNodelButton.UseVisualStyleBackColor = true;
            this.AddNodelButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Heigh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Length:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Or:";
            // 
            // nameGetModel
            // 
            this.nameGetModel.Location = new System.Drawing.Point(147, 35);
            this.nameGetModel.Name = "nameGetModel";
            this.nameGetModel.Size = new System.Drawing.Size(153, 20);
            this.nameGetModel.TabIndex = 7;
            // 
            // heighGetModel
            // 
            this.heighGetModel.Location = new System.Drawing.Point(147, 73);
            this.heighGetModel.Name = "heighGetModel";
            this.heighGetModel.Size = new System.Drawing.Size(153, 20);
            this.heighGetModel.TabIndex = 8;
            // 
            // lengthGetModel
            // 
            this.lengthGetModel.Location = new System.Drawing.Point(147, 113);
            this.lengthGetModel.Name = "lengthGetModel";
            this.lengthGetModel.Size = new System.Drawing.Size(153, 20);
            this.lengthGetModel.TabIndex = 9;
            // 
            // widthGetModel
            // 
            this.widthGetModel.Location = new System.Drawing.Point(147, 148);
            this.widthGetModel.Name = "widthGetModel";
            this.widthGetModel.Size = new System.Drawing.Size(153, 20);
            this.widthGetModel.TabIndex = 10;
            // 
            // privateModelCheckBox
            // 
            this.privateModelCheckBox.AutoSize = true;
            this.privateModelCheckBox.Location = new System.Drawing.Point(147, 201);
            this.privateModelCheckBox.Name = "privateModelCheckBox";
            this.privateModelCheckBox.Size = new System.Drawing.Size(91, 17);
            this.privateModelCheckBox.TabIndex = 11;
            this.privateModelCheckBox.Text = "Private Model";
            this.privateModelCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 387);
            this.Controls.Add(this.privateModelCheckBox);
            this.Controls.Add(this.widthGetModel);
            this.Controls.Add(this.lengthGetModel);
            this.Controls.Add(this.heighGetModel);
            this.Controls.Add(this.nameGetModel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddNodelButton);
            this.Controls.Add(this.assFromFolderButton);
            this.Name = "AddModel";
            this.Text = "Add Model";
            this.Load += new System.EventHandler(this.AddModel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button assFromFolderButton;
        private System.Windows.Forms.Button AddNodelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameGetModel;
        private System.Windows.Forms.TextBox heighGetModel;
        private System.Windows.Forms.TextBox lengthGetModel;
        private System.Windows.Forms.TextBox widthGetModel;
        private System.Windows.Forms.CheckBox privateModelCheckBox;
    }
}