
namespace PHP_SRS_App
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
            this.components = new System.ComponentModel.Container();
            this.sale_btn = new System.Windows.Forms.Button();
            this.product_cbx = new System.Windows.Forms.ComboBox();
            this.productstableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sql6410796DataSet = new PHP_SRS_App.sql6410796DataSet();
            this.productstableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantity_msktxtbx = new System.Windows.Forms.MaskedTextBox();
            this.product__imgbx = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quantity_lbl = new System.Windows.Forms.Label();
            this.product_lbl = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.SalesOrder_pnl = new System.Windows.Forms.Panel();
            this.dgvSalesRecord = new System.Windows.Forms.DataGridView();
            this.rTextBox = new System.Windows.Forms.RichTextBox();
            this.products_tableTableAdapter = new PHP_SRS_App.sql6410796DataSetTableAdapters.products_tableTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql6410796DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product__imgbx)).BeginInit();
            this.panel1.SuspendLayout();
            this.SalesOrder_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // sale_btn
            // 
            this.sale_btn.Location = new System.Drawing.Point(638, 469);
            this.sale_btn.Name = "sale_btn";
            this.sale_btn.Size = new System.Drawing.Size(257, 58);
            this.sale_btn.TabIndex = 0;
            this.sale_btn.Text = "Finalise Sale";
            this.sale_btn.UseVisualStyleBackColor = true;
            this.sale_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // product_cbx
            // 
            this.product_cbx.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productstableBindingSource1, "Product_Name", true));
            this.product_cbx.DataSource = this.productstableBindingSource;
            this.product_cbx.DisplayMember = "Product_Name";
            this.product_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.product_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_cbx.FormattingEnabled = true;
            this.product_cbx.Location = new System.Drawing.Point(3, 63);
            this.product_cbx.Name = "product_cbx";
            this.product_cbx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.product_cbx.Size = new System.Drawing.Size(172, 24);
            this.product_cbx.TabIndex = 1;
            this.product_cbx.ValueMember = "Product_Name";
            this.product_cbx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // productstableBindingSource1
            // 
            this.productstableBindingSource1.DataMember = "products_table";
            this.productstableBindingSource1.DataSource = this.sql6410796DataSet;
            // 
            // sql6410796DataSet
            // 
            this.sql6410796DataSet.DataSetName = "sql6410796DataSet";
            this.sql6410796DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productstableBindingSource
            // 
            this.productstableBindingSource.DataMember = "products_table";
            this.productstableBindingSource.DataSource = this.sql6410796DataSet;
            // 
            // quantity_msktxtbx
            // 
            this.quantity_msktxtbx.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.quantity_msktxtbx.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.quantity_msktxtbx.Location = new System.Drawing.Point(201, 63);
            this.quantity_msktxtbx.Mask = "00000";
            this.quantity_msktxtbx.Name = "quantity_msktxtbx";
            this.quantity_msktxtbx.Size = new System.Drawing.Size(127, 20);
            this.quantity_msktxtbx.TabIndex = 0;
            this.quantity_msktxtbx.ValidatingType = typeof(int);
            this.quantity_msktxtbx.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // product__imgbx
            // 
            this.product__imgbx.Location = new System.Drawing.Point(474, 17);
            this.product__imgbx.Name = "product__imgbx";
            this.product__imgbx.Size = new System.Drawing.Size(207, 225);
            this.product__imgbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.product__imgbx.TabIndex = 4;
            this.product__imgbx.TabStop = false;
            this.product__imgbx.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.quantity_lbl);
            this.panel1.Controls.Add(this.product_lbl);
            this.panel1.Controls.Add(this.add_btn);
            this.panel1.Controls.Add(this.product_cbx);
            this.panel1.Controls.Add(this.quantity_msktxtbx);
            this.panel1.Location = new System.Drawing.Point(687, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 239);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // quantity_lbl
            // 
            this.quantity_lbl.AutoSize = true;
            this.quantity_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_lbl.Location = new System.Drawing.Point(221, 32);
            this.quantity_lbl.Name = "quantity_lbl";
            this.quantity_lbl.Size = new System.Drawing.Size(76, 20);
            this.quantity_lbl.TabIndex = 6;
            this.quantity_lbl.Text = "Quantity: ";
            // 
            // product_lbl
            // 
            this.product_lbl.AutoSize = true;
            this.product_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_lbl.Location = new System.Drawing.Point(34, 32);
            this.product_lbl.Name = "product_lbl";
            this.product_lbl.Size = new System.Drawing.Size(72, 20);
            this.product_lbl.TabIndex = 5;
            this.product_lbl.Text = "Product: ";
            this.product_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(3, 194);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(328, 29);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Add to Transaction";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // SalesOrder_pnl
            // 
            this.SalesOrder_pnl.Controls.Add(this.dgvSalesRecord);
            this.SalesOrder_pnl.Location = new System.Drawing.Point(12, 3);
            this.SalesOrder_pnl.Name = "SalesOrder_pnl";
            this.SalesOrder_pnl.Size = new System.Drawing.Size(456, 511);
            this.SalesOrder_pnl.TabIndex = 6;
            this.SalesOrder_pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dgvSalesRecord
            // 
            this.dgvSalesRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesRecord.Location = new System.Drawing.Point(0, 0);
            this.dgvSalesRecord.Name = "dgvSalesRecord";
            this.dgvSalesRecord.Size = new System.Drawing.Size(456, 511);
            this.dgvSalesRecord.TabIndex = 0;
            this.dgvSalesRecord.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // rTextBox
            // 
            this.rTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTextBox.Location = new System.Drawing.Point(474, 286);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(578, 177);
            this.rTextBox.TabIndex = 7;
            this.rTextBox.Text = "";
            this.rTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // products_tableTableAdapter
            // 
            this.products_tableTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(679, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Products To Buy:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1059, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTextBox);
            this.Controls.Add(this.SalesOrder_pnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.product__imgbx);
            this.Controls.Add(this.sale_btn);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql6410796DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productstableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product__imgbx)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SalesOrder_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sale_btn;
        private System.Windows.Forms.ComboBox product_cbx;
        private System.Windows.Forms.MaskedTextBox quantity_msktxtbx;
        private System.Windows.Forms.PictureBox product__imgbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label product_lbl;
        private System.Windows.Forms.Label quantity_lbl;
        private System.Windows.Forms.Panel SalesOrder_pnl;
        private System.Windows.Forms.RichTextBox rTextBox;
        private sql6410796DataSet sql6410796DataSet;
        private System.Windows.Forms.BindingSource productstableBindingSource;
        private sql6410796DataSetTableAdapters.products_tableTableAdapter products_tableTableAdapter;
        private System.Windows.Forms.BindingSource productstableBindingSource1;
        public System.Windows.Forms.DataGridView dgvSalesRecord;
        private System.Windows.Forms.Label label1;
    }
}

