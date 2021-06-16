
namespace NotebookClient
{
    partial class ChangeContact
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ContactType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(227, 113);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 41);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(29, 113);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(141, 41);
            this.btnOk.TabIndex = 36;
            this.btnOk.Text = "Изменить";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(172, 60);
            this.Value.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(193, 26);
            this.Value.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Значение";
            // 
            // ContactType
            // 
            this.ContactType.Location = new System.Drawing.Point(173, 18);
            this.ContactType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ContactType.Name = "ContactType";
            this.ContactType.Size = new System.Drawing.Size(193, 26);
            this.ContactType.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Тип контакта";
            // 
            // ChangeContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 179);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContactType);
            this.Controls.Add(this.label1);
            this.Name = "ChangeContact";
            this.Text = "ChangeContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ContactType;
        private System.Windows.Forms.Label label1;
    }
}