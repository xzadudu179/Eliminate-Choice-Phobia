using System.IO;
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
        /// 生成
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
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //询问保存位置
            if (ToDoList.Items.Count <= 0) return;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "保存ToDoList";
            saveFileDialog.Filter = "待办事项|*.tdlist";
            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;
            if (path == "") return;
            WriteTextToFile(path);
        }

        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="text">文本</param>
        /// <param name="path">路径</param>
        /// <param name="openOrCreate">是否启用替换</param>
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
            }
        }

        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "待办事项|*.tdlist";
            openFileDialog.Title = "选择待办事项列表";
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;
            //读取
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
            generate.Enabled = true;
        }

        /// <summary>
        /// 添加新项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            if (addToListText.Text == null || addToListText.Text == "") return;
            ToDoList.Items.Add(addToListText.Text);
            generate.Enabled = true;
            //清空文本框
            addToListText.Clear();
            clearButton.Enabled = true;
        }

        private void ToDoList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;
            //clearButton.Enabled = true;
        }

        //删除按钮
        private void deleteButton_Click(object sender, EventArgs e)
        {
            ToDoList.Items.RemoveAt(ToDoList.SelectedIndex);
            if (ToDoList.Items.Count <= 0) generate.Enabled = false;
            deleteButton.Enabled = false;
            clearButton.Enabled = false;
        }

        //清空按钮
        private void button1_Click(object sender, EventArgs e)
        {
            ToDoList.Items.Clear();
            clearButton.Enabled = false;
        }
    }
}