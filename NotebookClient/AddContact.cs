using NotebookAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookClient
{
    public partial class AddContact : Form
    {
        public bool save;
        const string _baseAddress = "https://localhost:44360";
        public string pContact
        {
            get { return Value.Text; }
        }
        public int pContactType
        {
            get 
            {
                return ContactType.SelectedIndex+1;
            }
        }
       
        public AddContact()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            save = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            save = false;
            this.Close();
        }

        private void AddContact_Load(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response;

                response = client.GetAsync("api/ContactTypes").Result;
                if (response.IsSuccessStatusCode)
                {
                    ContactType[] reports = response.Content.ReadAsAsync<ContactType[]>().Result;
                    foreach (var p in reports)
                    {
                        ContactType.Items.Add(p.Title);
                    }
                }

            }
        }
    }
}
