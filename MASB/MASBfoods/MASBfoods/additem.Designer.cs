namespace MASBfoods
{
    partial class additem
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
            this.itemtxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addbt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemtxt
            // 
            this.itemtxt.Location = new System.Drawing.Point(70, 44);
            this.itemtxt.Name = "itemtxt";
            this.itemtxt.Size = new System.Drawing.Size(100, 20);
            this.itemtxt.TabIndex = 0;
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(70, 70);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(100, 20);
            this.pricetxt.TabIndex = 1;
            this.pricetxt.TextChanged += new System.EventHandler(this.pricetxt_TextChanged);
            this.pricetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pricetxt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // addbt
            // 
            this.addbt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addbt.Location = new System.Drawing.Point(70, 96);
            this.addbt.Name = "addbt";
            this.addbt.Size = new System.Drawing.Size(100, 23);
            this.addbt.TabIndex = 2;
            this.addbt.Text = "Add";
            this.addbt.UseVisualStyleBackColor = false;
            this.addbt.Click += new System.EventHandler(this.addbt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // additem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(199, 193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addbt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.itemtxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(650, 0);
            this.Name = "additem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "additem";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.additem_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemtxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addbt;
        private System.Windows.Forms.Button button1;
    }
}