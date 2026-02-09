namespace sportGoods {
	partial class FormMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			panel1 = new Panel();
			label1 = new Label();
			btnLogout = new Button();
			dataGridView1 = new DataGridView();
			this.btnOrders = new Button();
			button2 = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(label1);
			panel1.Controls.Add(btnLogout);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(410, 60);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 6);
			label1.Name = "label1";
			label1.Size = new Size(53, 21);
			label1.TabIndex = 1;
			label1.Text = "label1";
			// 
			// btnLogout
			// 
			btnLogout.Location = new Point(294, 3);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(104, 50);
			btnLogout.TabIndex = 0;
			btnLogout.Text = "Выход";
			btnLogout.UseVisualStyleBackColor = true;
			btnLogout.Click += btnLogout_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = Color.White;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.GridColor = Color.White;
			dataGridView1.Location = new Point(0, 60);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(410, 281);
			dataGridView1.TabIndex = 1;
			// 
			// btnOrders
			// 
			this.btnOrders.Location = new Point(12, 145);
			this.btnOrders.Name = "btnOrders";
			this.btnOrders.Size = new Size(140, 84);
			this.btnOrders.TabIndex = 2;
			this.btnOrders.Text = "Заказы";
			this.btnOrders.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(258, 145);
			button2.Name = "button2";
			button2.Size = new Size(140, 84);
			button2.TabIndex = 3;
			button2.Text = "Продукты";
			button2.UseVisualStyleBackColor = true;
			// 
			// FormMain
			// 
			AutoScaleDimensions = new SizeF(10F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(410, 341);
			Controls.Add(button2);
			Controls.Add(this.btnOrders);
			Controls.Add(dataGridView1);
			Controls.Add(panel1);
			Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(4);
			Name = "FormMain";
			Text = "Main";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private DataGridView dataGridView1;
		private Button btnLogout;
		private Label label1;
		private Button button1;
		private Button button2;
	}
}