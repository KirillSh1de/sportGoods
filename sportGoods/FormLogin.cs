using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using sportGoods.Models;

namespace sportGoods {
	public partial class FormLogin : Form {
		public User CurrentUser { get; private set; }
		public bool IsGuest { get; private set; }
		public FormLogin() {
			InitializeComponent();
		}

		private void btn_log_guest_Click_1(object sender, EventArgs e) {
			CurrentUser = null;
			IsGuest = true;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btn_log_Click_1(object sender, EventArgs e) {
			if (String.IsNullOrWhiteSpace(txtLog.Text) || String.IsNullOrWhiteSpace(txtPass.Text)) {
				MessageBox.Show(
					"Введите логин и пароль",
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}

			using (var db = new Pr3Context()) {
				var user = db.Users
					.Where(w => w.FullName == txtLog.Text && w.Password == txtPass.Text)
					.FirstOrDefault();

				if (user != null) {
					CurrentUser = user;
					IsGuest = false;
					this.DialogResult = DialogResult.OK;
					this.Close();
				} else {
					MessageBox.Show(
						"Введите логин и пароль",
						"Ошибка",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
			}

		}
	}
}
