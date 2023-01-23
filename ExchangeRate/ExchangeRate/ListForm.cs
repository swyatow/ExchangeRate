using ExchangeRate.Entity;
using ExchangeRate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExchangeRate
{
    public partial class ListForm : Form
    {
        private List<CurrencyItem> currencies;
        private FavouritesRepository favRep;
        private int basey;
        private bool isInFavList;

        public ListForm(bool isFav)
        {
            InitializeComponent();
            isInFavList = isFav;
            favRep = new FavouritesRepository();
            currencies = CurrencyList.List;
            ListPanel.BackColor = Color.FromArgb(51, 54, 118);
            if (currencies.Count > 0)
            {
                basey = 10;
                if (isFav)
                {
                    UpdateFavList();
                }
                else
                {
                    foreach (CurrencyItem item in currencies)
                    {
                        ShowCurrencyInfo(item);
                    }
                }
            }
            else
            {
                infoLabel.Visible = true;
            }
        }
        private void UpdateFavList()
        {
            for(int i = ListPanel.Controls.Count-1; i > 0; i--)
            {
                ListPanel.Controls.RemoveAt(i);
            }
            basey = 10;
            foreach (CurrencyItem item in currencies)
            {
                Favourite fav = favRep.GetFavourite(item.LetterCode);
                if (fav != null) ShowCurrencyInfo(item);
            }
            infoLabel.Visible = ListPanel.Controls.Count == 1;
        }

        private void ShowCurrencyInfo(CurrencyItem item)
        {
            Panel layout = new Panel();
            layout.Name = item.LetterCode;
            layout.Size = new Size(640, 70);
            layout.BackColor = Color.FromArgb(212, 166, 106);

            // Название валюты
            Label label = new Label();
            label = new Label();
            label.Text = item.Name;
            label.Font = new Font("Segoe UI", 12.0f);
            label.AutoSize = true;
            label.Top = 5;
            label.Left = 10;
            label.ForeColor = Color.FromArgb(51, 54, 118);
            label.Parent = layout;

            // Цена
            label = new Label();
            label.Text = $"{item.Nominal}{item.LetterCode}={Math.Round(item.Price,2)}RUB";
            label.Font = new Font("Segoe UI", 12.0f);
            label.AutoSize = true;
            label.Top = 35;
            label.Left = 10;
            label.ForeColor = Color.FromArgb(51, 54, 118);
            label.Parent = layout;
            if (item.NA)
            {
                label = new Label();
                label.Text = "Нет данных о динамике";
                label.Font = new Font("Segoe UI", 12.0f, FontStyle.Bold);
                label.AutoSize = true;
                label.Top = 30;
                label.Left = 230;
                label.ForeColor = Color.Red;
                label.Parent = layout;
            } else
            {
                // Разница в валюте 
                label = new Label();
                label.Text = Math.Round(item.DifInCurrency, 2).ToString();
                label.Font = new Font("Segoe UI", 12.0f);
                label.AutoSize = true;
                label.Top = 30;
                label.Left = 230;
                label.ForeColor = item.DifInCurrency < 0 ? Color.DarkGreen : Color.Red;
                label.Parent = layout;

                // Разница в процентах
                label = new Label();
                label.Text = $"{Math.Abs(Math.Round(item.DifInPercent, 2))}%";
                label.Font = new Font("Segoe UI", 12.0f);
                label.AutoSize = true;
                label.Top = 30;
                label.Left = 320;
                label.ForeColor = Color.FromArgb(128, 81, 21);
                label.Parent = layout;
            }

            // Кнопка "В Избранное"
            Button addToFav = new Button()
            {
                //Name = "addToFav",
                BackColor = Color.FromArgb(50, 53, 118),
                ForeColor = Color.FromArgb(170, 158, 56),
                Text =  favRep.GetFavourite(item.LetterCode) != null ? "Удалить\nиз избранного" : "В избранное",
                Top = 12,
                Left = 500,
                Height = 50,
                Width = 125,
                FlatStyle = FlatStyle.Popup,
                Parent = layout
            };
            addToFav.Click += addToFav_Click;

            layout.Anchor = AnchorStyles.Top;
            layout.Top = basey;
            basey += (layout.Size.Height + 10);
            layout.Parent = ListPanel;
        }
        public void addToFav_Click(object? sender, EventArgs e)
        {
            string id = (sender as Button).Parent.Name;
            
            if(favRep.GetFavourite(id) != null)
            {
                favRep.DeleteFav(id);
                (sender as Button).Text = "В избранное";
            }
            else
            {
                favRep.AddFav(id);
                (sender as Button).Text = "Удалить\nиз избранного";

            }
            
            if (isInFavList) 
            {
                ListPanel.Dock = DockStyle.None;
                UpdateFavList();
                ListPanel.Dock = DockStyle.Fill;
            }
            
        }

        private void ListForm_SizeChanged(object sender, EventArgs e)
        {
            ListPanel.Left = ActiveForm.Width / 2 - ListPanel.Width / 2 - 10;
        }

        private void ListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        public Panel GetPanel() => ListPanel;
    }
}
