namespace BuenaCalculator
{
    partial class frmCalculator
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
            this.btnadd = new System.Windows.Forms.Button();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtSecondNum = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.btnsubtract = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(12, 206);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(82, 50);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "+";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(12, 9);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(134, 20);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "Enter a number: ";
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNum.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtFirstNum.Location = new System.Drawing.Point(16, 32);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(405, 26);
            this.txtFirstNum.TabIndex = 3;
            this.txtFirstNum.TextChanged += new System.EventHandler(this.txtFirstNum_TextChanged);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(12, 77);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(181, 20);
            this.lblNum2.TabIndex = 4;
            this.lblNum2.Text = "Enter another number: ";
            // 
            // txtSecondNum
            // 
            this.txtSecondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondNum.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSecondNum.Location = new System.Drawing.Point(16, 100);
            this.txtSecondNum.Name = "txtSecondNum";
            this.txtSecondNum.Size = new System.Drawing.Size(405, 26);
            this.txtSecondNum.TabIndex = 5;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.Location = new System.Drawing.Point(12, 167);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(168, 20);
            this.lblOperator.TabIndex = 6;
            this.lblOperator.Text = "Choose an operation:";
            // 
            // btnsubtract
            // 
            this.btnsubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubtract.Location = new System.Drawing.Point(123, 206);
            this.btnsubtract.Name = "btnsubtract";
            this.btnsubtract.Size = new System.Drawing.Size(82, 50);
            this.btnsubtract.TabIndex = 7;
            this.btnsubtract.Text = "-";
            this.btnsubtract.UseVisualStyleBackColor = true;
            this.btnsubtract.Click += new System.EventHandler(this.btnsubtract_Click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiply.Location = new System.Drawing.Point(231, 206);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(82, 50);
            this.btnmultiply.TabIndex = 8;
            this.btnmultiply.Text = "x";
            this.btnmultiply.UseVisualStyleBackColor = true;
            this.btnmultiply.Click += new System.EventHandler(this.btnmultiply_Click);
            // 
            // btndivide
            // 
            this.btndivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivide.Location = new System.Drawing.Point(339, 206);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(82, 50);
            this.btndivide.TabIndex = 9;
            this.btndivide.Text = "÷";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 285);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 20);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Result:";
            this.lblResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtResult.Location = new System.Drawing.Point(12, 308);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(405, 45);
            this.txtResult.TabIndex = 11;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(433, 388);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnmultiply);
            this.Controls.Add(this.btnsubtract);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.txtSecondNum);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txtFirstNum);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.btnadd);
            this.Name = "frmCalculator";
            this.Text = "Basic Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtSecondNum;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Button btnsubtract;
        private System.Windows.Forms.Button btnmultiply;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
    }
}

