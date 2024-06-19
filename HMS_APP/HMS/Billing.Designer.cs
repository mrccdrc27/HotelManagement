namespace HMS
{
    partial class Billing
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
            billingID = new Label();
            billingIDText = new TextBox();
            totalAmount = new Label();
            totalAmountText = new TextBox();
            insert = new Button();
            update = new Button();
            list = new Button();
            delete = new Button();
            backToHome = new Button();
            dataGridView1 = new DataGridView();
            billingIDCol = new DataGridViewTextBoxColumn();
            totalAmountCol = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 26);
            label1.Name = "label1";
            label1.Size = new Size(99, 37);
            label1.TabIndex = 0;
            label1.Text = "Billing";
            label1.Click += label1_Click;
            // 
            // billingID
            // 
            billingID.AutoSize = true;
            billingID.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billingID.Location = new Point(38, 111);
            billingID.Name = "billingID";
            billingID.Size = new Size(89, 28);
            billingID.TabIndex = 1;
            billingID.Text = "BillingID:";
            // 
            // billingIDText
            // 
            billingIDText.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            billingIDText.Location = new Point(182, 111);
            billingIDText.Name = "billingIDText";
            billingIDText.Size = new Size(460, 34);
            billingIDText.TabIndex = 2;
            billingIDText.TextChanged += billingIDText_TextChanged;
            // 
            // totalAmount
            // 
            totalAmount.AutoSize = true;
            totalAmount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalAmount.Location = new Point(38, 158);
            totalAmount.Name = "totalAmount";
            totalAmount.Size = new Size(134, 28);
            totalAmount.TabIndex = 3;
            totalAmount.Text = "Total Amount:";
            // 
            // totalAmountText
            // 
            totalAmountText.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalAmountText.Location = new Point(182, 158);
            totalAmountText.Name = "totalAmountText";
            totalAmountText.Size = new Size(460, 34);
            totalAmountText.TabIndex = 4;
            totalAmountText.TextChanged += textBox2_TextChanged;
            // 
            // insert
            // 
            insert.Location = new Point(44, 235);
            insert.Name = "insert";
            insert.Size = new Size(96, 38);
            insert.TabIndex = 5;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += button1_Click;
            // 
            // update
            // 
            update.Location = new Point(169, 235);
            update.Name = "update";
            update.Size = new Size(96, 38);
            update.TabIndex = 6;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += edit_Click;
            // 
            // list
            // 
            list.Location = new Point(287, 235);
            list.Name = "list";
            list.Size = new Size(96, 38);
            list.TabIndex = 7;
            list.Text = "List";
            list.UseVisualStyleBackColor = true;
            list.Click += list_Click;
            // 
            // delete
            // 
            delete.Location = new Point(410, 235);
            delete.Name = "delete";
            delete.Size = new Size(96, 38);
            delete.TabIndex = 8;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // backToHome
            // 
            backToHome.Location = new Point(546, 235);
            backToHome.Name = "backToHome";
            backToHome.Size = new Size(96, 38);
            backToHome.TabIndex = 9;
            backToHome.Text = "Back to home page";
            backToHome.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { billingIDCol, totalAmountCol });
            dataGridView1.Location = new Point(44, 302);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(598, 224);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // billingIDCol
            // 
            billingIDCol.HeaderText = "Billing ID";
            billingIDCol.Name = "billingIDCol";
            billingIDCol.Width = 200;
            // 
            // totalAmountCol
            // 
            totalAmountCol.HeaderText = "Total Amount";
            totalAmountCol.Name = "totalAmountCol";
            totalAmountCol.Width = 200;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 552);
            Controls.Add(dataGridView1);
            Controls.Add(backToHome);
            Controls.Add(delete);
            Controls.Add(list);
            Controls.Add(update);
            Controls.Add(insert);
            Controls.Add(totalAmountText);
            Controls.Add(totalAmount);
            Controls.Add(billingIDText);
            Controls.Add(billingID);
            Controls.Add(label1);
            Name = "Billing";
            Text = "Billing";
            Load += Billing_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label billingID;
        private TextBox billingIDText;
        private Label totalAmount;
        private TextBox totalAmountText;
        private Button insert;
        private Button update;
        private Button list;
        private Button delete;
        private Button backToHome;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn billingIDCol;
        private DataGridViewTextBoxColumn totalAmountCol;
    }
}