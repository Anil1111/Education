namespace _001_XML_Serialization
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SerializationButton = new System.Windows.Forms.Button();
            this.DeSerializationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 507);
            this.textBox1.TabIndex = 0;
            // 
            // SerializationButton
            // 
            this.SerializationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SerializationButton.Location = new System.Drawing.Point(23, 398);
            this.SerializationButton.Name = "SerializationButton";
            this.SerializationButton.Size = new System.Drawing.Size(130, 40);
            this.SerializationButton.TabIndex = 1;
            this.SerializationButton.Text = "Serialization";
            this.SerializationButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SerializationButton.UseVisualStyleBackColor = true;
            this.SerializationButton.Click += new System.EventHandler(this.Serialization_Click);
            // 
            // DeSerializationButton
            // 
            this.DeSerializationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DeSerializationButton.Location = new System.Drawing.Point(23, 467);
            this.DeSerializationButton.Name = "DeSerializationButton";
            this.DeSerializationButton.Size = new System.Drawing.Size(130, 40);
            this.DeSerializationButton.TabIndex = 2;
            this.DeSerializationButton.Text = " DeSerialization";
            this.DeSerializationButton.UseVisualStyleBackColor = true;
            this.DeSerializationButton.Click += new System.EventHandler(this.DeSerialization_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 547);
            this.Controls.Add(this.DeSerializationButton);
            this.Controls.Add(this.SerializationButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "XML Serializer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SerializationButton;
        private System.Windows.Forms.Button DeSerializationButton;
    }
}

