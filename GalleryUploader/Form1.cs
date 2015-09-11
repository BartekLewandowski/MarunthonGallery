using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.ServiceModel;
using System.Collections.Specialized;

namespace GalleryUploader
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            //txtLogin.Text = "bartek@leniwce.com";
            try
            {
                PulsarSystem.IniFiles ii = new PulsarSystem.IniFiles("settings.ini");
                txtLogin.Text = ii.GetValue("login");
            }
            catch { }            
            lbLog.Items.Clear();
            this.setControlsState(false);
        }

        private void setControlsState(bool enabled)
        {
            if (enabled == false)
            {
                lblCity.Text = "";
                lblName.Text = "";
                lblName.Tag = "0";
                pbUpload.Visible = false;
            }
            groupBoxEvent.Enabled = groupBoxGallery.Enabled = groupBoxImages.Enabled = btnUpload.Enabled = enabled;
        }

        private string GetEmail()
        {
            return txtLogin.Text.ToLower().Trim();
        }
        private string GetPasswordHash()
        {
            return SportEvents.Models.CryptHelper.GetMd5Hash(txtPass.Text + txtLogin.Text.Trim().ToLower());
        }
        private void btnSelFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lbLog.Items.Clear();
                txtImgPath.Text = folderBrowserDialog1.SelectedPath;
                string[] arrayD1 = Directory.GetFiles(txtImgPath.Text, "*.jpg");
                string[] arrayD2 = Directory.GetFiles(txtImgPath.Text, "*.jpeg");
                
                lbLog.Items.AddRange(arrayD1);
                lbLog.Items.AddRange(arrayD2);
                lbLog.Sorted = true;

                if (lbLog.Items.Count == 0)
                {
                    MessageBox.Show("No JPEG images in selected folder.");
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                PulsarSystem.IniFiles ii = new PulsarSystem.IniFiles("settings.ini",true);
                ii.SetValue("login", txtLogin.Text);
            }
            catch { }
            
            ServiceMarunthon.ApiSoapClient soap = new ServiceMarunthon.ApiSoapClient(new BasicHttpBinding(),new EndpointAddress(Models.Globals.EndPointUrl));
            this.setControlsState(false);
            try
            {
                int id = soap.Login(txtLogin.Text.Trim(), this.GetPasswordHash());
                if (id>0) 
                    this.setControlsState(true);
                else
                    MessageBox.Show("Incorrect login or password. Please try again.");
            }
            catch
            {
                MessageBox.Show("Can not connect to Marunthon.com. Check internet connection and try again");
            }                      
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormEvent f = new FormEvent();
            Models.Event evt = f.GetEvent(this.GetEmail(), this.GetPasswordHash());
            lblName.Text = evt.Name;
            lblCity.Text = evt.City + ", " + evt.Country;
            lblName.Tag = evt.Id.ToString();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (lbLog.Items.Count == 0)
            {
                MessageBox.Show("No images. Please add images.");
                return;
            }
            int eid = 0;
            Int32.TryParse(lblName.Tag.ToString(), out eid);
            if (eid < 1)
            {
                MessageBox.Show("Please select the event.");
                return;
            }
            ServiceMarunthon.ApiSoapClient soap = new ServiceMarunthon.ApiSoapClient(new BasicHttpBinding(), new EndpointAddress(Models.Globals.EndPointUrl));
            int flag = 0;
            int galId = soap.CreateGallery(this.GetEmail(), this.GetPasswordHash(), eid, txtGalName.Text, out flag);
            if (flag > 0)
            {
                String err="";
                if (flag == 1) err = "Incorrect login or password.";
                if (flag == 2) err = "Please enter new gallery name.";
                if (flag == 3) err = "Please select event.";
                MessageBox.Show(err);
                return;
            }
            btnUpload.Enabled = false;
            pbUpload.Visible = true;
            pbUpload.Value = pbUpload.Minimum;
            pbUpload.Maximum = lbLog.Items.Count;
            
            for (int i = 0; i < lbLog.Items.Count; i++)
            {
                string fname = lbLog.Items[i].ToString();
                try
                {
                    Leniwce.ImageHelper ih = new Leniwce.ImageHelper();
                    Image img = Image.FromFile(fname);
                    try
                    {
                        if (img.PropertyIdList.Contains(0x0112) && chkRotate.Checked)
                        {
                            int rotationValue = img.GetPropertyItem(0x0112).Value[0];
                            switch (rotationValue)
                            {
                                case 1: // landscape, do nothing
                                    break;

                                case 8: // rotated 90 right
                                    // de-rotate:
                                    img.RotateFlip(rotateFlipType: RotateFlipType.Rotate270FlipNone);
                                    break;

                                case 3: // bottoms up
                                    img.RotateFlip(rotateFlipType: RotateFlipType.Rotate180FlipNone);
                                    break;

                                case 6: // rotated 90 left
                                    img.RotateFlip(rotateFlipType: RotateFlipType.Rotate90FlipNone);
                                    break;
                            }
                        }
                        
                    }
                    catch { }
                    if (img.Width > 1600)
                    {
                        img = ih.ResizeToWidth(img, 1600);
                    }
                    if (img.Height > 1200)
                    {
                        img = ih.ResizeToHeight(img, 1200);
                    }

                    int err = soap.SaveImage(this.GetEmail(), this.GetPasswordHash(), galId, ih.ImageToByteArr(img));
                    if (err > 0) 
                        lbLog.Items[i] = "Error (" +err.ToString() + ") " + lbLog.Items[i].ToString();
                    else
                        lbLog.Items[i] = "OK : " + lbLog.Items[i].ToString();
                }
                catch
                {
                    lbLog.Items[i] = "Error : " + lbLog.Items[i].ToString();
                }
                Application.DoEvents();
                pbUpload.PerformStep();
            }
            pbUpload.Visible = false;
            btnUpload.Enabled = true;
            MessageBox.Show("Images sent. Go to Marunthon.com and check gallery.");
            lbLog.Items.Clear();
        }
    }
}
