using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class EditForm : Form
    {
        private readonly DB db;
        private Human human;

        public EditForm(DB db)
        {
            InitializeComponent();
            this.db = db;
            human = new Human();
        }

        public EditForm(Human human)
        {
            InitializeComponent();
            this.human = human;
            textAddress.Text = human.Address;
            textFirstName.Text = human.FirstName;
            textLastName.Text = human.LastName;
            textPatronymic.Text = human.PatronymicName;
            if (File.Exists(human.ImagePath))
                pictureBox1.Load(human.ImagePath);
            ShowPhones();
        }

        //добавить телефон
        private void button1_Click(object sender, EventArgs e)
        {
            PhoneType phoneType = default;
            if (radioHouse.Checked)
                phoneType = PhoneType.Домашний;
            else if (radioMobile.Checked)
                phoneType = PhoneType.Мобильный;
            radioHouse.Checked = false;
            radioMobile.Checked = false;
            string number = textPhone.Text;
            textPhone.Text = string.Empty;
            Phone phone = new Phone
            {
                Number = number,
                Type = phoneType
            };
            human.Phones.Add(phone);
            ShowPhones();
        }

        private void ShowPhones()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = human.Phones;
            listBox1.DisplayMember = "Number";
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;
            var phone = listBox1.SelectedItem as Phone;
            human.Phones.Remove(phone);
            ShowPhones();
        }

        // выбор изображения
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image|*.png";
            openFileDialog.Title = "Выберите изображение";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                human.ImagePath = openFileDialog.FileName;
                pictureBox1.Load(openFileDialog.FileName);
            }
        }

        // сохранить и закрыть
        private void button3_Click(object sender, EventArgs e)
        {
            human.FirstName = textFirstName.Text;
            human.LastName = textLastName.Text;
            human.PatronymicName = textPatronymic.Text;
            human.Address = textAddress.Text;
            if (db != null)
                db.Add(human);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
