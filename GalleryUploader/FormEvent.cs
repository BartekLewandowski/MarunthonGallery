using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalleryUploader
{
    public partial class FormEvent : Form
    {
        private Models.Event Evt;
        private string Login;
        private string PassHash;
        public FormEvent()
        {
            InitializeComponent();
        }

        public Models.Event GetEvent(string login, string passHash)
        {
            Login = login;
            PassHash = passHash;
            Evt = new Models.Event();
            this.ShowDialog();
            return Evt;
        }
        private void FormEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    int id;
                    Int32.TryParse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), out id);
                    Evt.Id = id;
                    Evt.Name = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    Evt.City = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    Evt.Country = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                }
                else
                {
                    MessageBox.Show("Please select event!");
                    e.Cancel = true;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ServiceMarunthon.ApiSoapClient soap = new ServiceMarunthon.ApiSoapClient(new BasicHttpBinding(), new EndpointAddress(Models.Globals.EndPointUrl));
            int flag;
            dataGridView1.DataSource = soap.GetTopEvents(Login, PassHash, txtSearchFor.Text, out flag);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 60;
        }
    }
}
