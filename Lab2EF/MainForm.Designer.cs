namespace Lab2EF
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelCount = new System.Windows.Forms.Label();
            this.labelDish = new System.Windows.Forms.Label();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.LableTable = new System.Windows.Forms.Label();
            this.textBoxTableID = new System.Windows.Forms.TextBox();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOrderDetails = new System.Windows.Forms.ComboBox();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxOrder = new System.Windows.Forms.ComboBox();
            this.comboBoxDish = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dishesWCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dishesOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishesOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.BackColor = System.Drawing.Color.Transparent;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCount.Location = new System.Drawing.Point(287, 99);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(62, 24);
            this.labelCount.TabIndex = 33;
            this.labelCount.Text = "count:";
            // 
            // labelDish
            // 
            this.labelDish.AutoSize = true;
            this.labelDish.BackColor = System.Drawing.Color.Transparent;
            this.labelDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDish.Location = new System.Drawing.Point(182, 98);
            this.labelDish.Name = "labelDish";
            this.labelDish.Size = new System.Drawing.Size(50, 24);
            this.labelDish.TabIndex = 32;
            this.labelDish.Text = "dish:";
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.BackColor = System.Drawing.Color.Transparent;
            this.labelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelOrder.Location = new System.Drawing.Point(71, 98);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(60, 24);
            this.labelOrder.TabIndex = 31;
            this.labelOrder.Text = "order:";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.BackColor = System.Drawing.Color.Transparent;
            this.labelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDetails.Location = new System.Drawing.Point(12, 21);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(211, 24);
            this.labelDetails.TabIndex = 30;
            this.labelDetails.Text = "Show details of order №";
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.BackColor = System.Drawing.Color.Transparent;
            this.labelOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderDate.ForeColor = System.Drawing.Color.White;
            this.labelOrderDate.Location = new System.Drawing.Point(443, 94);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(112, 24);
            this.labelOrderDate.TabIndex = 29;
            this.labelOrderDate.Text = "OrderDate:";
            // 
            // LableTable
            // 
            this.LableTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LableTable.AutoSize = true;
            this.LableTable.BackColor = System.Drawing.Color.Transparent;
            this.LableTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LableTable.ForeColor = System.Drawing.Color.White;
            this.LableTable.Location = new System.Drawing.Point(501, 65);
            this.LableTable.Name = "LableTable";
            this.LableTable.Size = new System.Drawing.Size(96, 24);
            this.LableTable.TabIndex = 28;
            this.LableTable.Text = "Table №:";
            // 
            // textBoxTableID
            // 
            this.textBoxTableID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTableID.Location = new System.Drawing.Point(611, 70);
            this.textBoxTableID.Name = "textBoxTableID";
            this.textBoxTableID.Size = new System.Drawing.Size(100, 20);
            this.textBoxTableID.TabIndex = 27;
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddOrder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddOrder.Location = new System.Drawing.Point(624, 122);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOrder.TabIndex = 26;
            this.buttonAddOrder.Text = "Add order";
            this.buttonAddOrder.UseVisualStyleBackColor = false;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerOrder.Location = new System.Drawing.Point(561, 96);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerOrder.TabIndex = 25;
            // 
            // comboBoxOrderDetails
            // 
            this.comboBoxOrderDetails.FormattingEnabled = true;
            this.comboBoxOrderDetails.Location = new System.Drawing.Point(46, 48);
            this.comboBoxOrderDetails.Name = "comboBoxOrderDetails";
            this.comboBoxOrderDetails.Size = new System.Drawing.Size(110, 21);
            this.comboBoxOrderDetails.TabIndex = 24;
            // 
            // buttonDetail
            // 
            this.buttonDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDetail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDetail.Location = new System.Drawing.Point(46, 75);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(110, 23);
            this.buttonDetail.TabIndex = 23;
            this.buttonDetail.Text = "Show details!";
            this.buttonDetail.UseVisualStyleBackColor = false;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAdd.Location = new System.Drawing.Point(387, 124);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(72, 23);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Add!";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxOrder
            // 
            this.comboBoxOrder.FormattingEnabled = true;
            this.comboBoxOrder.Location = new System.Drawing.Point(46, 125);
            this.comboBoxOrder.Name = "comboBoxOrder";
            this.comboBoxOrder.Size = new System.Drawing.Size(110, 21);
            this.comboBoxOrder.TabIndex = 21;
            // 
            // comboBoxDish
            // 
            this.comboBoxDish.FormattingEnabled = true;
            this.comboBoxDish.Location = new System.Drawing.Point(160, 125);
            this.comboBoxDish.Name = "comboBoxDish";
            this.comboBoxDish.Size = new System.Drawing.Size(101, 21);
            this.comboBoxDish.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 277);
            this.dataGridView1.TabIndex = 19;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(267, 125);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount.TabIndex = 34;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dishesWCategoriesToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.staffToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripSplitButton1.Text = "Show";
            // 
            // dishesWCategoriesToolStripMenuItem
            // 
            this.dishesWCategoriesToolStripMenuItem.Name = "dishesWCategoriesToolStripMenuItem";
            this.dishesWCategoriesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dishesWCategoriesToolStripMenuItem.Text = "Dishes w/ categories";
            this.dishesWCategoriesToolStripMenuItem.Click += new System.EventHandler(this.dishesWCategoriesToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ordersToolStripMenuItem.Text = "Orders";
            this.ordersToolStripMenuItem.Click += new System.EventHandler(this.ordersToolStripMenuItem_Click);
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // dishesOrderBindingSource
            // 
            this.dishesOrderBindingSource.DataSource = typeof(RestModel.DishesOrder);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelDish);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelOrderDate);
            this.Controls.Add(this.LableTable);
            this.Controls.Add(this.textBoxTableID);
            this.Controls.Add(this.buttonAddOrder);
            this.Controls.Add(this.dateTimePickerOrder);
            this.Controls.Add(this.comboBoxOrderDetails);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxOrder);
            this.Controls.Add(this.comboBoxDish);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishesOrderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelDish;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label LableTable;
        private System.Windows.Forms.TextBox textBoxTableID;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.ComboBox comboBoxOrderDetails;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxOrder;
        private System.Windows.Forms.ComboBox comboBoxDish;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem dishesWCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.BindingSource dishesOrderBindingSource;
    }
}

