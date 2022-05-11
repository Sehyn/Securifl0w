using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Securifl0w
{

    public partial class FrmFirstRun : Form
    {
        #region IP
        public class IpInfo
        {
            public string Country { get; set; }
            [JsonProperty("ip")]
            public string Ip { get; set; }

            [JsonProperty("hostname")]
            public string Hostname { get; set; }

            [JsonProperty("city")]
            public string City { get; set; }

            [JsonProperty("region")]
            public string Region { get; set; }

            //[JsonProperty("country")]
            //public string Country { get; set; }

            [JsonProperty("loc")]
            public string Loc { get; set; }

            [JsonProperty("org")]
            public string Org { get; set; }

            [JsonProperty("postal")]
            public string Postal { get; set; }
        }
        #endregion
        public string IP { get; private set; }

        public FrmFirstRun()
        {
            InitializeComponent();
            Checks();
        }

        private async void Checks()
        {
            try
            {
                await Task.Delay(1000);


                if (IsAdministrator())
                {
                    LblAdmin.ForeColor = Color.Green;
                    LblAdmin.Text = "-> OK";
                    await Task.Delay(1200);
                    LblRegistre.ForeColor = Color.Green;
                    LblRegistre.Text = "-> OK";
                }
                else
                {
                    LblAdmin.ForeColor = Color.Red;
                    LblAdmin.Text = "-> X";
                    await Task.Delay(1200);
                    LblRegistre.ForeColor = Color.Red;
                    LblRegistre.Text = "-> X";

                }
            }
            catch (Exception ex)
            {

            }



            try
            {
                if (CheckNet())
                {
                    await Task.Delay(500);

                    LblInternet.ForeColor = Color.Green;
                    LblInternet.Text = "-> OK";
                }
                else
                {
                    await Task.Delay(500);

                    LblInternet.ForeColor = Color.Red;
                    LblInternet.Text = "-> X";
                }

            }
            catch (Exception ex)
            {

            }

            try
            {
                IpInfo ipInfo = new IpInfo();
                string info = new WebClient().DownloadString("http://ipinfo.io");
                JavaScriptSerializer jsonObject = new JavaScriptSerializer();
                ipInfo = jsonObject.Deserialize<IpInfo>(info);
                IP = (ipInfo.Ip);

                Console.WriteLine(IP);
                LblIP.ForeColor = Color.Green;
                LblIP.Text = "-> " + IP;

            }
            catch (Exception ex)
            {
                LblIP.ForeColor = Color.Red;
                LblIP.Text = "-> X";
            }

            LblAccessDistant.ForeColor = Color.Yellow;
            LblAccessDistant.Text = "-> En maintenance";

            try
            {
                await Task.Delay(555);
                string Version = "1.0";
                //string NewVersion = "1.1";
                System.Net.WebClient request = new System.Net.WebClient();
                string Update = request.DownloadString("https://pastebin.com/raw/9yNCPLWq");
                if (Update.Contains(Version))
                {
                    LblVersion.ForeColor = Color.Green;
                    LblVersion.Text = "-> OK [1.0]";
                }
                else
                {
                    LblVersion.ForeColor = Color.Yellow;
                    LblVersion.Text = "-> MAJ [1.1]";
                    // Monter FORM de mise à jour -> Télécharge, et lance la nouvelle mise à jour et renome l'exe actuel pour le supprimer avec le nouveau !
                    //MessageBox.Show("Il est fortement recommandé d'installer les mises à jour afin de profiter de nouvelles fonctionalités et corriger les potentiels bugs étant présent lors de versions précedentes, de ce fait nous vous installons la nouvelle mise à jour.");
                    //Process.Start("your download link");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmFirstRun_Load(object sender, EventArgs e)
        {
            GunaAnimate.Start();
        }

        private void BtnDiscord_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/bgxnP2bKtX");
        }

  

        private  void BtnSuivant_Click(object sender, EventArgs e)
        {
            

        }


        public static bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        private bool CheckNet()
        {
            bool stats;
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {
                stats = true;
            }
            else
            {
                stats = false;
            }
            return stats;
        }

        private void FrmFirstRun_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
