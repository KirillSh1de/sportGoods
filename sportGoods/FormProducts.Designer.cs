namespace sportGoods {
	partial class FormProducts {
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			panelTop = new Panel();
			lblUserName = new Label();
			btn_log = new Button();
			dgvProducts = new DataGridView();
			panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
			SuspendLayout();
			// 
			// panelTop
			// 
			panelTop.Controls.Add(lblUserName);
			panelTop.Controls.Add(btn_log);
			panelTop.Dock = DockStyle.Top;
			panelTop.Location = new Point(0, 0);
			panelTop.Margin = new Padding(4);
			panelTop.Name = "panelTop";
			panelTop.Padding = new Padding(14);
			panelTop.Size = new Size(702, 70);
			panelTop.TabIndex = 2;
			// 
			// lblUserName
			// 
			lblUserName.AutoSize = true;
			lblUserName.Dock = DockStyle.Right;
			lblUserName.Location = new Point(515, 14);
			lblUserName.Margin = new Padding(4, 0, 4, 0);
			lblUserName.Name = "lblUserName";
			lblUserName.Size = new Size(53, 21);
			lblUserName.TabIndex = 2;
			lblUserName.Text = "label1";
			lblUserName.TextAlign = ContentAlignment.MiddleRight;
			// 
			// btn_log
			// 
			btn_log.AutoSize = true;
			btn_log.Dock = DockStyle.Right;
			btn_log.Location = new Point(568, 14);
			btn_log.Margin = new Padding(4);
			btn_log.Name = "btn_log";
			btn_log.Size = new Size(120, 42);
			btn_log.TabIndex = 1;
			btn_log.Text = "Выход";
			btn_log.UseVisualStyleBackColor = true;
			btn_log.Click += btn_log_Click_1;
			// 
			// dgvProducts
			// 
			dgvProducts.AllowUserToAddRows = false;
			dgvProducts.AllowUserToDeleteRows = false;
			dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dgvProducts.BackgroundColor = Color.White;
			dgvProducts.BorderStyle = BorderStyle.None;
			dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProducts.ColumnHeadersVisible = false;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Window;
			dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dgvProducts.DefaultCellStyle = dataGridViewCellStyle1;
			dgvProducts.Dock = DockStyle.Fill;
			dgvProducts.Location = new Point(0, 0);
			dgvProducts.Margin = new Padding(4);
			dgvProducts.MultiSelect = false;
			dgvProducts.Name = "dgvProducts";
			dgvProducts.ReadOnly = true;
			dgvProducts.RowHeadersVisible = false;
			dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvProducts.Size = new Size(702, 454);
			dgvProducts.TabIndex = 3;
			// 
			// FormProducts
			// 
			AutoScaleDimensions = new SizeF(10F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(702, 454);
			Controls.Add(panelTop);
			Controls.Add(dgvProducts);
			Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(4);
			Name = "FormProducts";
			Text = "FormProduct";
			panelTop.ResumeLayout(false);
			panelTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelTop;
		private Label lblUserName;
		private Button btn_log;
		private DataGridView dgvProducts;
	}
}