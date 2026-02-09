namespace sportGoods {
	partial class FormLogin {
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
			panel2 = new Panel();
			txtPass = new TextBox();
			txtLog = new TextBox();
			label2 = new Label();
			label1 = new Label();
			btn_log_guest = new Button();
			btn_log = new Button();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.Window;
			panel1.Controls.Add(panel2);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(455, 383);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Controls.Add(txtPass);
			panel2.Controls.Add(txtLog);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(label1);
			panel2.Controls.Add(btn_log_guest);
			panel2.Controls.Add(btn_log);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(455, 383);
			panel2.TabIndex = 1;
			// 
			// txtPass
			// 
			txtPass.Location = new Point(54, 190);
			txtPass.Name = "txtPass";
			txtPass.Size = new Size(340, 29);
			txtPass.TabIndex = 6;
			txtPass.UseSystemPasswordChar = true;
			// 
			// txtLog
			// 
			txtLog.Location = new Point(54, 120);
			txtLog.Name = "txtLog";
			txtLog.Size = new Size(340, 29);
			txtLog.TabIndex = 5;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(190, 159);
			label2.Name = "label2";
			label2.Size = new Size(69, 21);
			label2.TabIndex = 3;
			label2.Text = "Пароль";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(194, 89);
			label1.Name = "label1";
			label1.Size = new Size(61, 21);
			label1.TabIndex = 2;
			label1.Text = "Логин";
			// 
			// btn_log_guest
			// 
			btn_log_guest.AutoSize = true;
			btn_log_guest.Location = new Point(127, 270);
			btn_log_guest.Name = "btn_log_guest";
			btn_log_guest.Size = new Size(194, 31);
			btn_log_guest.TabIndex = 1;
			btn_log_guest.Text = "ВОЙТИ КАК ГОСТЬ";
			btn_log_guest.UseVisualStyleBackColor = true;
			// 
			// btn_log
			// 
			btn_log.AutoSize = true;
			btn_log.Location = new Point(182, 229);
			btn_log.Name = "btn_log";
			btn_log.Size = new Size(84, 31);
			btn_log.TabIndex = 0;
			btn_log.Text = "ВОЙТИ";
			btn_log.UseVisualStyleBackColor = true;
			// 
			// FormLogin
			// 
			AutoScaleDimensions = new SizeF(10F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(455, 383);
			Controls.Add(panel1);
			Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			Margin = new Padding(4);
			Name = "FormLogin";
			Text = "FormLogin";
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private TextBox txtPass;
		private TextBox txtLog;
		private Label label2;
		private Label label1;
		private Button btn_log_guest;
		private Button btn_log;
	}
}