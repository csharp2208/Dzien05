using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StooqParser
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dtStop.Value = DateTime.Now;
            dtStart.Value = DateTime.Now.AddMonths(-1);
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            // https://stooq.pl/q/d/l/?s=cdr&d1=20191126&d2=20200911&i=d
            String ticker = tbTicker.Text.ToLower();
            String d1 = dtStart.Value.ToString("yyyyMMdd");
            String d2 = dtStop.Value.ToString("yyyyMMdd");
            String url = $"https://stooq.pl/q/d/l/?s={ticker}&d1={d1}&d2={d2}&i=d";
            try
            {
                WebClient webClient = new WebClient();
                String s = webClient.DownloadString(url);
            } catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
