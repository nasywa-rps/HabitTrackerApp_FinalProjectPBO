namespace TestForm
{
    partial class DisplayTracker
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
            this.dgvProgress = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProgress
            // 
            this.dgvProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgress.Location = new System.Drawing.Point(487, 219);
            this.dgvProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProgress.Name = "dgvProgress";
            this.dgvProgress.RowHeadersWidth = 62;
            this.dgvProgress.Size = new System.Drawing.Size(936, 757);
            this.dgvProgress.TabIndex = 0;
            this.dgvProgress.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProgress_CellContentClick);
            // 
            // DisplayTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TestForm.Properties.Resources.displayBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.dgvProgress);
            this.Name = "DisplayTracker";
            this.Text = "DisplayTracker";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProgress;
    }
}