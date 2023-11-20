namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.operations = new System.Windows.Forms.ComboBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.TotalOutput = new System.Windows.Forms.ListView();
            this.btnCompute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(47, 74);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(236, 31);
            this.input1.TabIndex = 1;
            // 
            // operations
            // 
            this.operations.FormattingEnabled = true;
            this.operations.Location = new System.Drawing.Point(119, 121);
            this.operations.Name = "operations";
            this.operations.Size = new System.Drawing.Size(82, 21);
            this.operations.TabIndex = 2;
            this.operations.SelectedIndexChanged += new System.EventHandler(this.operations_SelectedIndexChanged);
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(47, 153);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(236, 31);
            this.input2.TabIndex = 3;
            // 
            // TotalOutput
            // 
            this.TotalOutput.BackColor = System.Drawing.SystemColors.MenuText;
            this.TotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TotalOutput.HideSelection = false;
            this.TotalOutput.Location = new System.Drawing.Point(26, 207);
            this.TotalOutput.Name = "TotalOutput";
            this.TotalOutput.Size = new System.Drawing.Size(278, 75);
            this.TotalOutput.TabIndex = 4;
            this.TotalOutput.UseCompatibleStateImageBehavior = false;
            this.TotalOutput.View = System.Windows.Forms.View.List;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(126, 301);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 336);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.TotalOutput);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.operations);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.label1);
            this.Name = "FrmBasicCalculator";
            this.Text = "FrmBasicCalculator";
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.ComboBox operations;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.ListView TotalOutput;
        private System.Windows.Forms.Button btnCompute;
    }
}

