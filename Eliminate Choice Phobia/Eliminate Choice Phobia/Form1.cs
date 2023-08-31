using System.IO;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;

namespace Eliminate_Choice_Phobia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generate_Click(object sender, EventArgs e)
        {
            if (ToDoList.Items == null) return;
            Random random = new Random();
            int r = random.Next(0, ToDoList.Items.Count);
            outPutLabel.Text = ToDoList.Items[r].ToString();
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ѯ�ʱ���λ��
            if (ToDoList.Items.Count <= 0) return;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "����ToDoList";
            saveFileDialog.Filter = "��������|*.tdlist";
            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;
            if (path == "") return;
            WriteTextToFile(path);
        }

        /// <summary>
        /// д���ļ�
        /// </summary>
        /// <param name="text">�ı�</param>
        /// <param name="path">·��</param>
        /// <param name="openOrCreate">�Ƿ������滻</param>
        private void WriteTextToFile(string path, bool openOrCreate = true)
        {
            using (FileStream fileWrite = new FileStream(path, openOrCreate == true ? FileMode.OpenOrCreate : FileMode.Open))
            {
                string texts = "";
                foreach (var item in ToDoList.Items)
                {
                    texts += item.ToString() + "\n";
                }
                byte[] buffer = Encoding.UTF8.GetBytes(texts);
                fileWrite.Write(buffer, 0, buffer.Length);
                clearButton.Enabled = true;
            }
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "��������|*.tdlist";
            openFileDialog.Title = "ѡ����������б�";
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;
            if (path == "") return;
            //��ȡ
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                ToDoList.Items.Clear();
                string line = sr.ReadLine() ?? "*null*\a";
                while (line != "*null*\a")
                {
                    ToDoList.Items.Add(line);
                    line = sr.ReadLine() ?? "*null*\a";
                }
            }
            clearButton.Enabled = true;
            generate.Enabled = true;
        }

        /// <summary>
        /// �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            if (addToListText.Text == null || addToListText.Text == "") return;
            ToDoList.Items.Add(addToListText.Text);
            generate.Enabled = true;
            //����ı���
            addToListText.Clear();
            clearButton.Enabled = true;
        }
        private void ToDoList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;
            //clearButton.Enabled = true;
        }

        //ɾ����ť
        private void deleteButton_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            if(ToDoList.Items.Count <= 0 || ToDoList.SelectedItem == null) return;
            ToDoList.Items.RemoveAt(ToDoList.SelectedIndex);
            if (ToDoList.Items.Count <= 0)
            {
                clearButton.Enabled = false;
                generate.Enabled = false;
            }          
            deleteButton.Enabled = false;
            
        }
        //��հ�ť
        private void button1_Click(object sender, EventArgs e)
        {
            ToDoList.Items.Clear();
            clearButton.Enabled = false;
        }

        //����enter(�����)
        private void addToListText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                //���
                Add();
            }
        }

        //����Delete(ɾ����)
        private void ToListText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                Delete();
            }
        }
    }
}