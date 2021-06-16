
namespace NotebookClient
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBirthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteContact = new System.Windows.Forms.Button();
            this.addContact = new System.Windows.Forms.Button();
            this.updateContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(581, 347);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 56);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(399, 347);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(162, 56);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Изменить...";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(204, 347);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 56);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 347);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(162, 56);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmLastName,
            this.clmBirthday});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(13, 14);
            this.listView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(730, 321);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // clmName
            // 
            this.clmName.Text = "Имя";
            this.clmName.Width = 182;
            // 
            // clmLastName
            // 
            this.clmLastName.Text = "Фамилия";
            this.clmLastName.Width = 224;
            // 
            // clmBirthday
            // 
            this.clmBirthday.Text = "День рождения";
            this.clmBirthday.Width = 258;
            // 
            // contactListView
            // 
            this.contactListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.contactListView.FullRowSelect = true;
            this.contactListView.GridLines = true;
            this.contactListView.HideSelection = false;
            this.contactListView.Location = new System.Drawing.Point(784, 14);
            this.contactListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.contactListView.Name = "contactListView";
            this.contactListView.Size = new System.Drawing.Size(368, 321);
            this.contactListView.TabIndex = 10;
            this.contactListView.UseCompatibleStateImageBehavior = false;
            this.contactListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Тип контакта";
            this.columnHeader1.Width = 182;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Контакт";
            this.columnHeader2.Width = 224;
            // 
            // deleteContact
            // 
            this.deleteContact.Location = new System.Drawing.Point(1052, 345);
            this.deleteContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteContact.Name = "deleteContact";
            this.deleteContact.Size = new System.Drawing.Size(100, 31);
            this.deleteContact.TabIndex = 13;
            this.deleteContact.Text = "Удалить";
            this.deleteContact.UseVisualStyleBackColor = true;
            this.deleteContact.Click += new System.EventHandler(this.deleteContact_Click);
            // 
            // addContact
            // 
            this.addContact.Location = new System.Drawing.Point(784, 345);
            this.addContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(100, 31);
            this.addContact.TabIndex = 12;
            this.addContact.Text = "Добавить";
            this.addContact.UseVisualStyleBackColor = true;
            this.addContact.Click += new System.EventHandler(this.addContact_Click);
            // 
            // updateContact
            // 
            this.updateContact.Location = new System.Drawing.Point(924, 345);
            this.updateContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateContact.Name = "updateContact";
            this.updateContact.Size = new System.Drawing.Size(100, 31);
            this.updateContact.TabIndex = 11;
            this.updateContact.Text = "Изменить";
            this.updateContact.UseVisualStyleBackColor = true;
            this.updateContact.Click += new System.EventHandler(this.updateContact_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 417);
            this.Controls.Add(this.deleteContact);
            this.Controls.Add(this.addContact);
            this.Controls.Add(this.updateContact);
            this.Controls.Add(this.contactListView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmLastName;
        private System.Windows.Forms.ColumnHeader clmBirthday;
        private System.Windows.Forms.ListView contactListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button deleteContact;
        private System.Windows.Forms.Button addContact;
        private System.Windows.Forms.Button updateContact;
    }
}

