﻿using System;
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

            dgvData.Columns.Clear();
            dgvData.Columns.Add("DATE", "Data notowania");
            dgvData.Columns.Add("CLOSE", "Kurs zamknięcia");
            dgvData.Columns.Add("VOLUME", "Wolumen akcji");

            dgvData.Columns[0].Width = 200;
            dgvData.Columns[1].Width = 300;
            dgvData.Columns[2].Width = 350;

        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            dgvData.Rows.Clear(); //usuwa stare wiersze
            chart.Series[0].Points.Clear();

            // https://stooq.pl/q/d/l/?s=cdr&d1=20191126&d2=20200911&i=d
            String ticker = tbTicker.Text.ToLower();
            String d1 = dtStart.Value.ToString("yyyyMMdd");
            String d2 = dtStop.Value.ToString("yyyyMMdd");
            String url = $"https://stooq.pl/q/d/l/?s={ticker}&d1={d1}&d2={d2}&i=d";
            try
            {
                WebClient webClient = new WebClient();
                String s = webClient.DownloadString(url);
                string[] lines = s.Split('\n');
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] items = lines[i].Trim().Split(',');
                    if (items.Length == 6)
                    {
                        dgvData.Rows.Add(new string[] { items[0], items[4], items[5] });
                        chart.Series[0].Points.AddXY(i, Convert.ToDouble(items[4].Replace(".", ",")));
                    }
                }
            } catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
