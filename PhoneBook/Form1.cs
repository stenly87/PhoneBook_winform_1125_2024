namespace PhoneBook
{
    public partial class Form1 : Form
    {
        DB db;

        public Form1()
        {
            InitializeComponent();
            db = new DB();
        }

        // �����
        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox1.Text;
            List<Human> result = db.Search(search);
            listView1.Items.Clear();
            foreach (Human item in result)
            {
                foreach (Phone phone in item.Phones)
                {
                    ListViewItem row = new ListViewItem();
                    row.Text = item.LastName;
                    row.Tag = item;
                    row.SubItems.Add(item.FirstName);
                    row.SubItems.Add(item.PatronymicName);
                    row.SubItems.Add(phone.Number);
                    row.SubItems.Add(item.Address);
                    listView1.Items.Add(row);
                }
            }
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(db);
            editForm.Show();
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Human human = listView1.SelectedItems[0].Tag
                    as Human;
                EditForm editForm = new EditForm(human);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // ���������� ��
                }
            }
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Human human = listView1.SelectedItems[0].Tag as Human;
                if (MessageBox.Show("�� ����� ����������� ������� ������ �� ��?",
                    "�������� ��������������", MessageBoxButtons.YesNo) ==
                     DialogResult.Yes)
                {
                    db.Remove(human);
                    button1_Click(this, null); // ��������� �����
                }
            }
        }
    }
}
