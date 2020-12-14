/**
 * Author: Rishit Patel
 * Student ID: A00089000
 * Date: December 14, 2020
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;


namespace Gyaani
{
    public partial class Form2 : Form
    {
        public string zsign, zodSign;
        public string xdate;
        public string xcompatibility, xlucky_time, xlucky_number, xcolor, xdate_range, xmood;
        public string result1, result2;

        public Form2(string zsign)
        {
            InitializeComponent();
            this.Text = "Daily Horoscope App";
            zodSign = zsign;


            result1 = call(zsign).Result.Trim();
            result2 = call2(zsign).Result.Trim();
            string finalResult = "Aztro: " + result2 + Environment.NewLine + "Ohmanda: " + result1;
            results.AppendText(finalResult);

            setAllLables();




            byte[] newBytes = new Byte[] { 169 };


            if (zsign == "aries") { aries.BackgroundImage = Properties.Resources.aries; }
            if (zsign == "taurus") { aries.BackgroundImage = Properties.Resources.taurus; }
            if (zsign == "gemini") { aries.BackgroundImage = Properties.Resources.gemini; }
            if (zsign == "cancer") { aries.BackgroundImage = Properties.Resources.cancer; }
            if (zsign == "leo") { aries.BackgroundImage = Properties.Resources.leo; }
            if (zsign == "virgo") { aries.BackgroundImage = Properties.Resources.virgo; }
            if (zsign == "scorpio") { aries.BackgroundImage = Properties.Resources.scorpio; }
            if (zsign == "sagittarius") { aries.BackgroundImage = Properties.Resources.sagittarius; }
            if (zsign == "capricorn") { aries.BackgroundImage = Properties.Resources.capricorn; }
            if (zsign == "aquarius") { aries.BackgroundImage = Properties.Resources.aquarius; }
            if (zsign == "pisces") { aries.BackgroundImage = Properties.Resources.pisces; }
            if (zsign == "libra") { aries.BackgroundImage = Properties.Resources.libra; }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool menuClicked = true;
                if (menuClicked)
                {
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        async Task<string> call(string zsign)
        {
            HttpClient httpClient = new HttpClient();
            using var client = httpClient;
            var response = await client.GetStringAsync("http://ohmanda.com/api/horoscope/" + zsign).ConfigureAwait(false);
            var o = JObject.Parse(response);
            var sign = (string)o["sign"];
            //xdate = (string)o["date"];
            var horoscope = (string)o["horoscope"];
            return horoscope;
        }

        async Task<string> call2(string zsign, string day = "today")
        {
            ///
            var uri = String.Format("https://aztro.sameerkumar.website/?sign={0}&day={1}", zsign, day);
            var xdata = new Dictionary<string, string> { { "sign", zsign }, { "day", day } };
            var json = JsonConvert.SerializeObject(xdata);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                //Console.WriteLine("Posting...");
                var response = client.PostAsync(uri, httpContent).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    // Debug.WriteLine(responseBody);
                    var o = JObject.Parse(responseBody);
                    xdate = (string)o["current_date"];
                    xcompatibility = (string)o["compatibility"];
                    xlucky_time = (string)o["lucky_time"];
                    xlucky_number = (string)o["lucky_number"];
                    xcolor = (string)o["color"];
                    xdate_range = (string)o["date_range"];
                    xmood = (string)o["mood"];
                    var xdescription = (string)o["description"];
                    return xdescription;
                }
                else
                {
                    return response.StatusCode.ToString();
                }
            }
        }

        private void setAllLables()
        {
            // setting lables
            lbl_date.Text = "Date: " + xdate;
            lbl_compatibility.Text = "Compatibility: " + xcompatibility;
            lbl_date_range.Text = "Date Range: " + xdate_range;
            lbl_lucky_number.Text = "Lucky Number: " + xlucky_number;
            lbl_lucky_time.Text = "Lucky Time: " + xlucky_time;
            lbl_mood.Text = "Mood: " + xmood;
            lbl_color.Text = "Color: " + xcolor;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void aries_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            result2 = call2(zodSign).Result.Trim();
            string finalResult = "Aztro: " + result2 + Environment.NewLine + "Ohmanda: " + result1;
            results.Text = finalResult;
            setAllLables();
        }

        private void btn_get_tomorrow_Click(object sender, EventArgs e)
        {
            result2 = call2(zodSign, "tomorrow").Result.Trim();
            string finalResult = "Aztro: " + result2 + Environment.NewLine + "Ohmanda API only returns Today's results.";
            results.Text = finalResult;
            setAllLables();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://rishitpatel.com/");
        }

        private void btn_get_yesterday_Click(object sender, EventArgs e)
        {
            result2 = call2(zodSign, "yesterday").Result.Trim();
            string finalResult = "Aztro: " + result2 + Environment.NewLine + "Ohmanda API only returns Today's results.";
            results.Text = finalResult;
            setAllLables();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_date_range_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }
    }
}
