namespace TestForm
{
    partial class AddHabit
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHabit = new System.Windows.Forms.TextBox();
            this.optUnit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(298, 198);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 25);
            this.btnSubmit.TabIndex = 38;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "Activity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "What Habit Do You Want To Do?";
            // 
            // txtHabit
            // 
            this.txtHabit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.txtHabit.Location = new System.Drawing.Point(139, 70);
            this.txtHabit.Margin = new System.Windows.Forms.Padding(2);
            this.txtHabit.Name = "txtHabit";
            this.txtHabit.Size = new System.Drawing.Size(253, 29);
            this.txtHabit.TabIndex = 35;
            // 
            // optUnit
            // 
            this.optUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optUnit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optUnit.FormattingEnabled = true;
            this.optUnit.Items.AddRange(new object[] {
            "Minutes",
            "Laps",
            "Times",
            "Add a new unit"});
            this.optUnit.Location = new System.Drawing.Point(139, 113);
            this.optUnit.Margin = new System.Windows.Forms.Padding(2);
            this.optUnit.Name = "optUnit";
            this.optUnit.Size = new System.Drawing.Size(253, 30);
            this.optUnit.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Target";
            // 
            // txtTarget
            // 
            this.txtTarget.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.txtTarget.Location = new System.Drawing.Point(139, 161);
            this.txtTarget.Margin = new System.Windows.Forms.Padding(2);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(253, 29);
            this.txtTarget.TabIndex = 39;
            // 
            // AddHabit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.optUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHabit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddHabit";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHabit;
        private System.Windows.Forms.ComboBox optUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarget;
    }
}