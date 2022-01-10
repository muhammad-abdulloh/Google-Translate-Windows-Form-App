﻿using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Google_Translate_Windows_Form_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient webClient  = new WebClient();
            webClient.Encoding = Encoding.UTF8;

            try
            {
                var queryParams = new Dictionary<string, string>()
                {
                    {"password", "001" },
                    {"text", textBox1.Text.Trim()},
                    {"trTo", comboBox1.Text.Trim()},
                    {"trIn", comboBox2.Text.Trim() }
                };

                var url = QueryHelpers.AddQueryString("https://dxost.ru/translate/index.php?", queryParams);

                HttpClient client = new HttpClient();
                
                string res = client.GetStringAsync(url).Result;
                textBox2.Text = res;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
