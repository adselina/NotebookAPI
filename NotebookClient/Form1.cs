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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const string _baseAddress = "https://localhost:44360";
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void Add()
        {
            AddPerson add = new AddPerson();

            add.ShowDialog();

            if (add.save == true)
            {
                Person newReport = new Person() 
                { 
                    Firstname = add.pFirstName, 
                    Secondname = add.pSecondName, 
                    BirthDay = DateTime.Parse(add.pBirthday) 
                };


                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_baseAddress);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = client.PostAsJsonAsync("api/People", newReport).Result;

                    ListViewItem item = new ListViewItem();

                    for (int i = 0; i < 1000; i++)
                    {
                        if ((int)listView.Items[listView.Items.Count - 1].Tag >= listView.Items.Count + i)
                            item.Tag = listView.Items.Count + i;
                        else
                        {
                            item.Tag = listView.Items.Count + i;
                            break;
                        }
                    }

                    item.Text = add.pFirstName;
                    item.SubItems.Add(add.pSecondName);
                    item.SubItems.Add(add.pBirthday);
                    listView.Items.Add(item);
                }
                add.save = false;
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void Update()
        {
            listView.Items.Clear();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response;
             
                response = client.GetAsync("api/People").Result;
                if (response.IsSuccessStatusCode)
                {
                    Person[] reports = response.Content.ReadAsAsync<Person[]>().Result;
                    foreach (var p in reports)
                    {
                        var item = new ListViewItem(new[] { p.Firstname, p.Secondname, p.BirthDay.ToShortDateString() });
                        item.Tag = p.Id;
                        listView.Items.Add(item);
                    }
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void Change()
        {
            ChangePerson update = new ChangePerson();
            if (listView.SelectedItems.Count != 0)
            {
                update.pFirstName = listView.SelectedItems[0].SubItems[0].Text;
                update.pSecondName = listView.SelectedItems[0].SubItems[1].Text;
                update.pBirthday = listView.SelectedItems[0].SubItems[2].Text;
                update.ShowDialog();

                if (update.save == true)
                {
                    Person newReport = new Person() 
                    { 
                        Firstname = update.pFirstName, 
                        Secondname = update.pSecondName, 
                        BirthDay = DateTime.Parse(update.pBirthday) };

                    listView.SelectedItems[0].SubItems[0].Text = update.pFirstName;
                    listView.SelectedItems[0].SubItems[1].Text = update.pSecondName;
                    listView.SelectedItems[0].SubItems[2].Text = update.pBirthday;

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                int id = (int)listView.SelectedItems[0].Tag;

                Delete(id);

                Update();
            }
        }
        private void Delete(int delete)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:2728/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.DeleteAsync("api/People/" + delete).Result;

            }
        }

        private void updateContact_Click(object sender, EventArgs e)
        {

        }

        private void addContact_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            AddContact form = new AddContact();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
            {
                AddContact((int)listView.SelectedItems[0].Tag, form.pContactType, form.pContact);

            }
        }

        private void deleteContact_Click(object sender, EventArgs e)
        {
            if (contactListView.SelectedItems.Count != 0)
            {
                int id = (int)contactListView.SelectedItems[0].Tag;

                DeleteContact(id);
            }
        }

        private void DeleteContact(int delete)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.DeleteAsync("api/contacts/" + delete).Result;
            }
        }

        private void AddContact(int person, int contactType, string value)
        {
            Contact contact = new Contact() { PersonId = person, ContactTypeId = contactType, Value = value };

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync("api/contacts/", contact).Result;
            }
        }

        private void UpdateContact(int id, int person, int contactType, string value)
        {
            Contact contact = new Contact() { Id = id, PersonId = person, ContactTypeId = contactType, Value = value };

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PutAsJsonAsync($"api/contacts/{id}", contact).Result;
                //MessageBox.Show(response.StatusCode.ToString());
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            int id = (int)listView.SelectedItems[0].Tag;
            Person person = GetPerson(id);

            contactListView.Items.Clear();
            foreach (var contact in person.Contacts)
            {
                ListViewItem item = new ListViewItem(new[] { contact.ContactType.Title, contact.Value, contact.ContactType.Id.ToString() });
                item.Tag = contact.Id;
                contactListView.Items.Add(item);
            }
        }

        private Person GetPerson(int id)
        {
            Person person = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response;

                response = client.GetAsync($"api/people/{id}").Result;
                if (response.IsSuccessStatusCode)
                {
                    person = response.Content.ReadAsAsync<Person>().Result;
                }
            }

            return person;
        }
    }
}
