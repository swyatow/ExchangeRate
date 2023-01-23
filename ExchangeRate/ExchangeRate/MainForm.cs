using BankService;
using ExchangeRate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static BankService.DailyInfoSoapClient;

namespace ExchangeRate
{
    public partial class MainForm : Form
    {
        private Control oldParent;
        private Panel oldPanel;

        public MainForm()
        {
            InitializeComponent();
            GetCbInfo();
            BackColor = Color.FromArgb(52, 52, 119);
        }

        public void ShowFav()
        {
            favCurrencyButton.PerformClick();
        }

        public void UnlockExchangeRate(bool value)
        {
            logInButton.Enabled = !value;
            logOutButton.Enabled = value;
            currencyDropDown.Enabled = value;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            SetContent(loginForm.GetPanel());
        }

        private void fileCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void currencyListButton_Click(object sender, EventArgs e)
        {
            ListForm listForm = new ListForm(false);
            SetContent(listForm.GetPanel());
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            SetContent(aboutForm.GetPanel());
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(Controls["ListPanel"]);
            UnlockExchangeRate(false);
        }

        private void favCurrencyButton_Click(object sender, EventArgs e)
        {
            ListForm listForm = new ListForm(true);
            SetContent(listForm.GetPanel());
        }

        private void SetContent(Panel targetPanel)
        {
            if (oldParent != null)
            {
                oldPanel.Parent = oldParent;
                if (oldParent is Form oldParentForm)
                {
                    oldParentForm.Close();
                }
            }
            oldParent = targetPanel.Parent;
            oldPanel = targetPanel;
            oldPanel.Parent = this;
            Controls.SetChildIndex(oldPanel, 0);
            oldPanel.Dock = DockStyle.Fill;
        }

        private void GetCbInfo()
        {
            using var client = new DailyInfoSoapClient(EndpointConfiguration.DailyInfoSoap);
            DateTime actDate = client.GetLatestDateTime();
            //Внутренние коды валют для поиска динамики
            var enumXML = client.EnumValutes(false);
            var enumTable = ToDataSet(enumXML);
            // Ежедневный курс
            var currencyXML = client.GetCursOnDate(actDate);
            var currencyTable = ToDataSet(currencyXML);
            dateTimeString.Text = "Курс валют актуален на " 
                + actDate.ToShortDateString();
            for(int i = 0; i< currencyTable.Tables[0].Rows.Count;i++)
            {
                //[Vname, vnom, vcurs, vcode, vchcode]
                DataRow item = currencyTable.Tables[0].Rows[i];
                DataRow itemCode = enumTable.Tables[0]
                    .Select()
                    .Where(x => x.ItemArray[6].ToString() == item.ItemArray[4].ToString())
                    .FirstOrDefault();
                CurrencyItem currency = new CurrencyItem()
                {
                    Name = item.ItemArray[0].ToString().TrimEnd(),
                    Nominal = int.Parse(item.ItemArray[1].ToString()),
                    Price = double.Parse(item.ItemArray[2].ToString()),
                    LetterCode = item.ItemArray[4].ToString(),                    
                };
                if(itemCode != null)
                {
                    var dynamicXML = client.GetCursDynamic(
                        actDate.AddDays(-1),
                        actDate, 
                        itemCode.ItemArray[0].ToString()
                    );
                    var dynamicTable = ToDataSet(dynamicXML);
                    double ystdayPrice = 
                        double.Parse(dynamicTable.Tables[0].Rows[0].ItemArray[3].ToString())
                        / double.Parse(dynamicTable.Tables[0].Rows[0].ItemArray[2].ToString())
                        * currency.Nominal;
                    currency.DifInCurrency = currency.Price - ystdayPrice;
                    currency.DifInPercent = currency.DifInCurrency / currency.Price * 100;
                }
                else
                {
                    currency.NA = true;
                }
                CurrencyList.List.Add(currency);
            }
        }

        private DataSet ToDataSet(ArrayOfXElement data)
        {
            DataSet result = new DataSet();
            string rawXml = new XElement("Root", data.Nodes).ToString();
            using (StringReader reader = new StringReader(rawXml))
            {
                result.ReadXml(reader);
            }
            return result;
        }
    }
}
