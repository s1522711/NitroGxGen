using System.Net.Http.Headers;
using System.Net.Http;
using System.Windows.Forms;
using System.Text.Json.Nodes;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace NitroGxGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Datasend
        {
            public string partnerUserId { get; set; }
        }

        public class jsonDeserializeToken
        {
            public string token { get; set; }
        }

        static class generatedLink
        {
            public static string gennedLink = "";
        }

        private async void genLink()
        {
            saveIndicatorLabel.Visible = false;
            copyLabel.Text = "";
            OutputBox.Text = "LOADING... PLEASE WAIT!";
            OutputBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            OutputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            OutputBox.ScrollBars = ScrollBars.None;
            HttpClient client = new HttpClient();
            HttpRequestMessage request;
            HttpResponseMessage response;

            string responseBody;

            client = new HttpClient();

            request = new HttpRequestMessage(HttpMethod.Post, "https://api.discord.gx.games/v1/direct-fulfillment");
            Random rnd = new Random();
            const string src = "abcdefghijklmnopqrstuvwxyz0123456789";
            int length = 64;
            var sb = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                var c = src[rnd.Next(0, src.Length)];
                sb.Append(c);
            }
            debugLabel.Text = sb.ToString();
            var stringdata = JsonConvert.SerializeObject(new Datasend() { partnerUserId = sb.ToString() });
            //var stringdata = JsonConvert.SerializeObject(new Datasend() { partnerUserId = "b8625d7a36fc7f5420be3a4fc81a5fe2ad4421d07f91518ccb45069f2e3689a5" });
            var stringContent = new StringContent(stringdata, Encoding.UTF8, "application/json");

            request.Content = stringContent;

            List<NameValueHeaderValue> listHeaders = new List<NameValueHeaderValue>();
            listHeaders.Add(new NameValueHeaderValue("authority", "api.discord.gx.games"));
            listHeaders.Add(new NameValueHeaderValue("accept", "*/*"));
            listHeaders.Add(new NameValueHeaderValue("accept-language", "en-US,en;q=0.9"));
            //listHeaders.Add(new NameValueHeaderValue("content-type", "application/json"));
            listHeaders.Add(new NameValueHeaderValue("origin", "https://www.opera.com"));
            listHeaders.Add(new NameValueHeaderValue("referer", "https://www.opera.com/"));
            //listHeaders.Add(new NameValueHeaderValue("sec-ch-ua, ","Opera GX\";v=\"105\", \"Chromium\";v=\"119\", \"Not?A_Brand\";v=\"24\""));
            listHeaders.Add(new NameValueHeaderValue("sec-ch-ua-mobile", "?0"));
            listHeaders.Add(new NameValueHeaderValue("sec-ch-ua-platform", "\"Windows\""));
            listHeaders.Add(new NameValueHeaderValue("sec-fetch-dest", "empty"));
            listHeaders.Add(new NameValueHeaderValue("sec-fetch-mode", "cors"));
            listHeaders.Add(new NameValueHeaderValue("sec-fetch-site", "cross-site"));
            listHeaders.Add(new NameValueHeaderValue("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/119.0.0.0 Safari/537.36 OPR/105.0.0.0"));

            foreach (var header in listHeaders)
            {
                request.Headers.Add(header.Name, header.Value);
            }

            response = await client.SendAsync(request);
            try
            {
                responseBody = response.Content.ReadAsStringAsync().Result;

                jsonDeserializeToken token = JsonConvert.DeserializeObject<jsonDeserializeToken>(responseBody);

                 OutputBox.Text = $"https://discord.com/billing/partner-promotions/1180231712274387115/{token.token}";

                if (fileLocation.saveToFile && saveTimerToFile.Checked)
                {
                    using (StreamWriter stream = File.AppendText(fileLocation.path))
                    {
                        stream.WriteLine(OutputBox.Text);
                    }
                    saveIndicatorLabel.Text = "Saved Successfully!";
                    saveIndicatorLabel.ForeColor = Color.PaleGreen;
                    saveIndicatorLabel.Visible = true;
                }

            }
            catch (System.NullReferenceException)
            {
                OutputBox.Text = "ERROR! PLEASE TRY AGAIN!\r\n" + response.ToString();
                OutputBox.ScrollBars = ScrollBars.Vertical;
                if (fileLocation.saveToFile && saveTimerToFile.Checked)
                {
                    using (StreamWriter stream = File.AppendText(fileLocation.path))
                    {
                        stream.WriteLine("ERROR!");
                    }
                    saveIndicatorLabel.Text = "Failure in generation!";
                    saveIndicatorLabel.ForeColor = Color.DarkRed;
                    saveIndicatorLabel.Visible = true;
                }
            }
        }

        private void GenBtn_Click(object sender, EventArgs e)
        {
            genLink();
        }



        private void copyBtn_Click(object sender, EventArgs e)
        {

            if (OutputBox.Text != "\r\n\r\nPRESS THE GENERATE BUTTON TO GENERATE A KEY!" && OutputBox.Text != "LOADING... PLEASE WAIT!")
            {
                Clipboard.SetText(OutputBox.Text);
                copyLabel.ForeColor = Color.DarkGreen;
                copyLabel.Text = "COPIED SUCCESSFULLY!";
            }
            else if (OutputBox.Text == "LOADING... PLEASE WAIT!")
            {
                copyLabel.ForeColor = Color.DarkRed;
                copyLabel.Text = "PLEASE WAIT, GENERATING LINK!";
            }
            else
            {
                copyLabel.ForeColor = Color.DarkRed;
                copyLabel.Text = "PLEASE GENERATE A LINK!";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            copyLabel.Text = "";
            OutputBox.Text = "\r\n\r\nPRESS THE GENERATE BUTTON TO GENERATE A KEY!";
        }

        private void debugCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (debugCheckbox.Checked)
            {
                debugLabel.Visible = true;
            }
            else
            {
                debugLabel.Visible = false;
            }
        }

        static class timerTime
        {
            public static double timeLeft = 0.0;
        }

        static class fileLocation
        {
            public static string path = @"NOTSET";
            public static bool saveToFile = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerTime.timeLeft > 0.0)
            {
                timerTime.timeLeft = timerTime.timeLeft - 0.1;
                timerLabel.Text = string.Format("{0:F1}", timerTime.timeLeft);
                timerLabel.Invoke(new Action(() => timerLabel.Text = string.Format("{0:F1}", timerTime.timeLeft)));
            }
            else
            {
                genLink();
                timerTime.timeLeft = (double)timerInput.Value;
            }
        }

        private void timerBox_CheckedChanged(object sender, EventArgs e)
        {
            if (timerBox.Checked)
            {
                timerTime.timeLeft = (double)timerInput.Value;
                GenBtn.Enabled = false;
                timer1.Enabled = true;
                timerLabel.Text = string.Format("{0:F1}", timerTime.timeLeft);
                timerLabel.Visible = true;
                infoTimerLabel.Visible = true;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                timerTime.timeLeft = 0.0;
                timerLabel.Text = "0.0";
                GenBtn.Enabled = true;
                timer1.Enabled = false;
                infoTimerLabel.Visible = false;
                timerLabel.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            fileLocation.path = saveFileDialog1.FileName;
            saveTimerToFile.Checked = true;
            selectedFileLabel.Text = Path.GetFileName(fileLocation.path);
            if (!File.Exists(fileLocation.path))
            {
                File.Create(fileLocation.path).Close();
            }
            
        }

        private void saveTimerToFile_CheckedChanged(object sender, EventArgs e)
        {
            if (saveTimerToFile.Checked && fileLocation.path != "NOTSET")
            {
                fileLocation.saveToFile = true;
            }else if (saveTimerToFile.Checked && fileLocation.path == "NOTSET")
            {
                saveTimerToFile.Checked = false;
                fileLocation.saveToFile = false;
                MessageBox.Show("Please select a file to save to!");
            }
            else
            {
                fileLocation.saveToFile = false;
            }
        }
    }
}
