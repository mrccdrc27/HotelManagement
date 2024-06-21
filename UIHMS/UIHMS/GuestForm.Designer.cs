namespace UIHMS
{
    partial class GuestForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            ReservationList = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            guestIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            guestTableBindingSource = new BindingSource(components);
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guestTableBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(36, 626);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(659, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(35, 626);
            panel3.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(ReservationList);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(36, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 31);
            panel1.TabIndex = 4;
            // 
            // ReservationList
            // 
            ReservationList.AutoSize = true;
            ReservationList.Dock = DockStyle.Bottom;
            ReservationList.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReservationList.Location = new Point(0, 11);
            ReservationList.Name = "ReservationList";
            ReservationList.Size = new Size(52, 20);
            ReservationList.TabIndex = 1;
            ReservationList.Text = "Guest";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(36, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(623, 150);
            panel4.TabIndex = 5;
            panel4.Paint += panel4_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(dataGridView1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(36, 222);
            panel6.Name = "panel6";
            panel6.Size = new Size(623, 404);
            panel6.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { guestIDDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn, roomIDDataGridViewTextBoxColumn });
            dataGridView1.DataSource = guestTableBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(621, 402);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            guestIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
            guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            // 
            // guestTableBindingSource
            // 
            guestTableBindingSource.DataSource = typeof(Guest_Table);
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(36, 181);
            panel5.Name = "panel5";
            panel5.Size = new Size(623, 41);
            panel5.TabIndex = 6;
            panel5.Paint += panel5_Paint;
            // 
            // GuestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "GuestForm";
            Size = new Size(694, 626);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guestTableBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Label ReservationList;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private BindingSource guestTableBindingSource;
    }
}
