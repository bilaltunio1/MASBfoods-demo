namespace MASBfoods
{
    partial class customerPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.locbox = new System.Windows.Forms.ComboBox();
            this.restbox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.addcartbt = new System.Windows.Forms.Button();
            this.mASBfoodsDataSet = new MASBfoods.MASBfoodsDataSet();
            this.mASBfoodsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkoutbt = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.orderbox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.logoutbt = new System.Windows.Forms.Button();
            this.reloadbt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASBfoodsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASBfoodsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome customer";
            // 
            // locbox
            // 
            this.locbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locbox.FormattingEnabled = true;
            this.locbox.Items.AddRange(new object[] {
            "Malir Cantt",
            "DHA",
            "Gulshan"});
            this.locbox.Location = new System.Drawing.Point(14, 12);
            this.locbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.locbox.Name = "locbox";
            this.locbox.Size = new System.Drawing.Size(140, 25);
            this.locbox.TabIndex = 0;
            this.locbox.SelectedIndexChanged += new System.EventHandler(this.locbox_SelectedIndexChanged);
            // 
            // restbox
            // 
            this.restbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.restbox.FormattingEnabled = true;
            this.restbox.Location = new System.Drawing.Point(14, 47);
            this.restbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.restbox.Name = "restbox";
            this.restbox.Size = new System.Drawing.Size(140, 25);
            this.restbox.TabIndex = 1;
            this.restbox.SelectedIndexChanged += new System.EventHandler(this.restbox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(14, 102);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 174);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Selected Item";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(550, 99);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(140, 177);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // addcartbt
            // 
            this.addcartbt.BackColor = System.Drawing.Color.GreenYellow;
            this.addcartbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcartbt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addcartbt.Location = new System.Drawing.Point(26, 300);
            this.addcartbt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addcartbt.Name = "addcartbt";
            this.addcartbt.Size = new System.Drawing.Size(87, 30);
            this.addcartbt.TabIndex = 3;
            this.addcartbt.Text = "Add to cart";
            this.addcartbt.UseVisualStyleBackColor = false;
            this.addcartbt.Click += new System.EventHandler(this.addcartbt_Click);
            // 
            // mASBfoodsDataSet
            // 
            this.mASBfoodsDataSet.DataSetName = "MASBfoodsDataSet";
            this.mASBfoodsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mASBfoodsDataSetBindingSource
            // 
            this.mASBfoodsDataSetBindingSource.DataSource = this.mASBfoodsDataSet;
            this.mASBfoodsDataSetBindingSource.Position = 0;
            // 
            // checkoutbt
            // 
            this.checkoutbt.BackColor = System.Drawing.Color.Red;
            this.checkoutbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutbt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkoutbt.Location = new System.Drawing.Point(429, 300);
            this.checkoutbt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkoutbt.Name = "checkoutbt";
            this.checkoutbt.Size = new System.Drawing.Size(87, 30);
            this.checkoutbt.TabIndex = 4;
            this.checkoutbt.Text = "Checkout";
            this.checkoutbt.UseVisualStyleBackColor = false;
            this.checkoutbt.Click += new System.EventHandler(this.checkoutbt_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(550, 352);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(140, 169);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // orderbox
            // 
            this.orderbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderbox.FormattingEnabled = true;
            this.orderbox.Location = new System.Drawing.Point(249, 352);
            this.orderbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.orderbox.Name = "orderbox";
            this.orderbox.Size = new System.Drawing.Size(140, 25);
            this.orderbox.TabIndex = 5;
            this.orderbox.SelectedIndexChanged += new System.EventHandler(this.orderbox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(249, 409);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Food is here!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(164, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(164, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Restaurant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(246, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Item list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(556, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Invoice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(126, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Pending orders";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(426, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Pending List";
            // 
            // logoutbt
            // 
            this.logoutbt.Location = new System.Drawing.Point(726, 5);
            this.logoutbt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoutbt.Name = "logoutbt";
            this.logoutbt.Size = new System.Drawing.Size(87, 30);
            this.logoutbt.TabIndex = 17;
            this.logoutbt.Text = "Logout!";
            this.logoutbt.UseVisualStyleBackColor = true;
            this.logoutbt.Click += new System.EventHandler(this.logoutbt_Click);
            // 
            // reloadbt
            // 
            this.reloadbt.Location = new System.Drawing.Point(147, 300);
            this.reloadbt.Name = "reloadbt";
            this.reloadbt.Size = new System.Drawing.Size(95, 30);
            this.reloadbt.TabIndex = 18;
            this.reloadbt.Text = "Reload";
            this.reloadbt.UseVisualStyleBackColor = true;
            this.reloadbt.Click += new System.EventHandler(this.reloadbt_Click);
            // 
            // customerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(834, 531);
            this.Controls.Add(this.reloadbt);
            this.Controls.Add(this.logoutbt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderbox);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.checkoutbt);
            this.Controls.Add(this.addcartbt);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.restbox);
            this.Controls.Add(this.locbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "customerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.customerPanel_FormClosed);
            this.Load += new System.EventHandler(this.customerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASBfoodsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASBfoodsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox locbox;
        private System.Windows.Forms.ComboBox restbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button addcartbt;
        private System.Windows.Forms.BindingSource mASBfoodsDataSetBindingSource;
        private MASBfoodsDataSet mASBfoodsDataSet;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button checkoutbt;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox orderbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button logoutbt;
        private System.Windows.Forms.Button reloadbt;
    }
}