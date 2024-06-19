namespace HMS
{
    partial class Home
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
            billing = new Button();
            bookingRecord = new Button();
            category = new Button();
            guest = new Button();
            room = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 35);
            label1.Name = "label1";
            label1.Size = new Size(322, 28);
            label1.TabIndex = 0;
            label1.Text = "What table do you want to modify?";
            // 
            // billing
            // 
            billing.Location = new Point(88, 108);
            billing.Name = "billing";
            billing.Size = new Size(115, 37);
            billing.TabIndex = 1;
            billing.Text = "Billing";
            billing.UseVisualStyleBackColor = true;
            billing.Click += button1_Click;
            // 
            // bookingRecord
            // 
            bookingRecord.Location = new Point(209, 108);
            bookingRecord.Name = "bookingRecord";
            bookingRecord.Size = new Size(115, 37);
            bookingRecord.TabIndex = 2;
            bookingRecord.Text = "Booking Record";
            bookingRecord.UseVisualStyleBackColor = true;
            // 
            // category
            // 
            category.Location = new Point(330, 108);
            category.Name = "category";
            category.Size = new Size(115, 37);
            category.TabIndex = 3;
            category.Text = "Category";
            category.UseVisualStyleBackColor = true;
            // 
            // guest
            // 
            guest.Location = new Point(451, 108);
            guest.Name = "guest";
            guest.Size = new Size(115, 37);
            guest.TabIndex = 4;
            guest.Text = "Guest";
            guest.UseVisualStyleBackColor = true;
            // 
            // room
            // 
            room.Location = new Point(572, 108);
            room.Name = "room";
            room.Size = new Size(115, 37);
            room.TabIndex = 5;
            room.Text = "Room";
            room.UseVisualStyleBackColor = true;
            room.Click += button5_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 219);
            Controls.Add(room);
            Controls.Add(guest);
            Controls.Add(category);
            Controls.Add(bookingRecord);
            Controls.Add(billing);
            Controls.Add(label1);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button billing;
        private Button bookingRecord;
        private Button category;
        private Button guest;
        private Button room;
    }
}