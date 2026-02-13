namespace POS
{
    partial class FrmInvoice
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtInvoiceNumber = new TextBox();
            dtInvoiceDate = new DateTimePicker();
            cmbCustomer = new ComboBox();
            cmbItems = new ComboBox();
            txtQuantity = new TextBox();
            btnAddItem = new Button();
            dgvItems = new DataGridView();
            colItemId = new DataGridViewTextBoxColumn();
            colItemName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colLineTotal = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label5 = new Label();
            lblTotal = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(664, 51);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = " رقم الفاتوره ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(486, 51);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "التاريخ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 51);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "العميل";
            // 
            // txtInvoiceNumber
            // 
            txtInvoiceNumber.Location = new Point(585, 75);
            txtInvoiceNumber.Name = "txtInvoiceNumber";
            txtInvoiceNumber.Size = new Size(154, 23);
            txtInvoiceNumber.TabIndex = 3;
            // 
            // dtInvoiceDate
            // 
            dtInvoiceDate.Location = new Point(324, 75);
            dtInvoiceDate.Name = "dtInvoiceDate";
            dtInvoiceDate.Size = new Size(200, 23);
            dtInvoiceDate.TabIndex = 4;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(73, 75);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(191, 23);
            cmbCustomer.TabIndex = 5;
            // 
            // cmbItems
            // 
            cmbItems.FormattingEnabled = true;
            cmbItems.Location = new Point(585, 139);
            cmbItems.Name = "cmbItems";
            cmbItems.Size = new Size(154, 23);
            cmbItems.TabIndex = 6;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(324, 139);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(200, 23);
            txtQuantity.TabIndex = 7;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(189, 139);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 8;
            btnAddItem.Text = "Add";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colItemId, colItemName, colQuantity, colPrice, colLineTotal });
            dgvItems.Location = new Point(12, 201);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(776, 147);
            dgvItems.TabIndex = 9;
            // 
            // colItemId
            // 
            colItemId.HeaderText = "ItemId";
            colItemId.Name = "colItemId";
            colItemId.ReadOnly = true;
            // 
            // colItemName
            // 
            colItemName.HeaderText = "Item";
            colItemName.Name = "colItemName";
            colItemName.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colLineTotal
            // 
            colLineTotal.HeaderText = "Total";
            colLineTotal.Name = "colLineTotal";
            colLineTotal.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(701, 112);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 10;
            label4.Text = "المنتج";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 112);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 11;
            label5.Text = "الكمية";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(673, 379);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(51, 15);
            lblTotal.TabIndex = 12;
            lblTotal.Text = "الاجمالي ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(448, 375);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(324, 375);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // FrmInvoice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(lblTotal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvItems);
            Controls.Add(btnAddItem);
            Controls.Add(txtQuantity);
            Controls.Add(cmbItems);
            Controls.Add(cmbCustomer);
            Controls.Add(dtInvoiceDate);
            Controls.Add(txtInvoiceNumber);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmInvoice";
            Text = "FrmInvoice";
            Load += FrmInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtInvoiceNumber;
        private DateTimePicker dtInvoiceDate;
        private ComboBox cmbCustomer;
        private ComboBox cmbItems;
        private TextBox txtQuantity;
        private Button btnAddItem;
        private DataGridView dgvItems;
        private Label label4;
        private Label label5;
        private Label lblTotal;
        private Button btnSave;
        private Button btnDelete;
        private DataGridViewTextBoxColumn colItemId;
        private DataGridViewTextBoxColumn colItemName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colLineTotal;
    }
}