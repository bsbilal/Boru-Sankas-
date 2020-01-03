using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoruSankasi
{
    public partial class frmPhotoUpload : MetroFramework.Forms.MetroForm
    {
        public frmPhotoUpload()
        {
            InitializeComponent();
        }

        private void frmPhotoUpload_Load(object sender, EventArgs e)
        {
            string address = "https://hizliresim.com/";
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowserNew.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }

        }
    }
}
