namespace Lab2EF
{
    partial class OrderDetails
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
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.dataGridViewFines = new System.Windows.Forms.DataGridView();
            this.labelInfo = new System.Windows.Forms.Label();
            this.dataGridViewComments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewService.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewService.Location = new System.Drawing.Point(12, 369);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.Size = new System.Drawing.Size(776, 75);
            this.dataGridViewService.TabIndex = 7;
            // 
            // dataGridViewFines
            // 
            this.dataGridViewFines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFines.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFines.Location = new System.Drawing.Point(12, 268);
            this.dataGridViewFines.Name = "dataGridViewFines";
            this.dataGridViewFines.Size = new System.Drawing.Size(776, 75);
            this.dataGridViewFines.TabIndex = 6;
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInfo.Location = new System.Drawing.Point(315, 7);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(105, 25);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "ERROR?";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewComments
            // 
            this.dataGridViewComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComments.Location = new System.Drawing.Point(12, 91);
            this.dataGridViewComments.Name = "dataGridViewComments";
            this.dataGridViewComments.Size = new System.Drawing.Size(776, 152);
            this.dataGridViewComments.TabIndex = 4;
            // 
            // OrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lab2EF.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewService);
            this.Controls.Add(this.dataGridViewFines);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.dataGridViewComments);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.DataGridView dataGridViewFines;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DataGridView dataGridViewComments;
    }
}