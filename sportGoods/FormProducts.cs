using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using sportGoods.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace sportGoods {
	public partial class FormProducts : Form {
		public User CurrentUser { get; private set; }

		public bool IsGuest { get; private set; }

		public FormProducts(User user, bool guest) {
			InitializeComponent();

			var colPhoto = new DataGridViewImageColumn();
			colPhoto.Name = "colPhoto";
			colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
			colPhoto.Width = 200;
			colPhoto.FillWeight = 30;

			var colInfo = new DataGridViewTextBoxColumn();
			colInfo.Name = "colInfo";
			colInfo.FillWeight = 60;
			colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

			var colDiscount = new DataGridViewTextBoxColumn();
			colDiscount.Name = "colDiscount";
			colDiscount.FillWeight = 10;
			colDiscount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			dgvProducts.Columns.AddRange(
			[
				colPhoto,colInfo,colDiscount
			]);

			CurrentUser = user;
			IsGuest = guest;

			lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;

			LoadProducts();
		}

		private void LoadProducts() {
			try {
				using (var db = new Pr3Context()) {
					var products = db.Products
						.Include(i => i.FkIdCategoriesNavigation)
						.Include(i => i.FkIdManufacturersNavigation)
						.Include(i => i.FkIdSuppliersNavigation)
						.Include(i => i.FkIdProductNamesNavigation)
						.ToList();

					dgvProducts.SuspendLayout();
					dgvProducts.Rows.Clear();

					foreach (var product in products) {
						int rowIndex = dgvProducts.Rows.Add();
						var row = dgvProducts.Rows[rowIndex];

						row.Cells["colPhoto"].Value = null;

						row.Cells["colInfo"].Value = FormatProductInfo(product);

						row.Cells["colDiscount"].Value = product.Discount.HasValue ? $"{product.Discount.Value}%" : "0%";
						row.Cells["colDiscount"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

						ApplyRowStyles(row, product);
					}

					dgvProducts.ResumeLayout();
					dgvProducts.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
				}
			} catch (Exception ex) {
				MessageBox.Show(
					$"Ошибка загрузки : {ex.Message}",
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void ApplyRowStyles(DataGridViewRow row, Product product) {
			row.DefaultCellStyle.BackColor = Color.White;
			row.DefaultCellStyle.ForeColor = Color.Black;

			if (product.Discount > 15) {
				row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");
				row.DefaultCellStyle.ForeColor = Color.White;
			}

			if (product.CountOnWarehouse <= 0) {
				row.DefaultCellStyle.BackColor = Color.LightBlue;
				if (product.Discount <= 15) {
					row.DefaultCellStyle.ForeColor = Color.Black;
				}
			}

			if (product.Discount > 0) {
				row.Cells["colDiscount"].Style.ForeColor = Color.Red;
				row.Cells["colDiscount"].Style.Font = new Font(
					"Times New Roman",
					12,
					FontStyle.Bold);
			}
		}

		private string FormatProductInfo(Product product) {
			string priceText;
			decimal price = product.Price;

			if (product.Discount.HasValue && product.Discount.Value > 0) {
				decimal discountValue = product.Discount.Value;
				decimal finalPrice = price * (100 - discountValue) / 100;
				priceText = $"Цена: {price:C} -> {finalPrice:C}";
			} else {
				priceText = $"Цена: {price:C}";
			}

			return
				$"Артикул: {product.Article}" + Environment.NewLine +
				$"Название: {product.FkIdProductNamesNavigation?.Name ?? "Нет названия"}" + Environment.NewLine +
				$"Категория: {product.FkIdCategoriesNavigation?.Name ?? "Нет категории"}" + Environment.NewLine +
				$"Описание: {product.Description}" + Environment.NewLine +
				$"Производитель: {product.FkIdManufacturersNavigation?.Name ?? "Нет производителя"}" + Environment.NewLine +
				$"Поставщик: {product.FkIdSuppliersNavigation?.Name ?? "Нет поставщика"}" + Environment.NewLine +
				priceText + Environment.NewLine +
				$"Единица измерения: {product.UnitOfMeasurement}" + Environment.NewLine +
				$"Количество на складе: {product.CountOnWarehouse}";
		}

		private void btn_log_Click_1(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		protected override void OnFormClosing(FormClosingEventArgs e) {
			base.OnFormClosing(e);
		}
	}
}