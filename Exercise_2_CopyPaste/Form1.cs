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

namespace Exercise_2_CopyPaste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.SmallImageList = imageList1;
            listView2.SmallImageList = imageList2;
        }

        private ViewLoading viewLoading = new ViewLoading();

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            string path = textBox1.Text;
            // получаем все файлы
            string[] files = Directory.GetFiles(path);
            // перебор полученных файлов
            for (int i = 0; i < files.Length; i++)
            {
                ListViewItem lvi = new ListViewItem();
                // установка названия файла
                lvi.Text = files[i].Remove(0, files[i].LastIndexOf('\\') + 1);
                imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(files[i]));
                lvi.ImageIndex = i;
                // установка картинки для файла
                // добавляем элемент в ListView
                listView1.Items.Add(lvi);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                richTextBox1.SelectedText = item.Text.ToString() + "\n";
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!viewLoading.loading.Created || viewLoading.loading == null || viewLoading.loading.IsDisposed)
            {
                viewLoading.loading = new Loading();
                viewLoading.loading.Show();
            }

            string path = textBox1.Text + "\\";
            string newPath = textBox2.Text + "\\";
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                viewLoading.AddWoker(path + item.Text.ToString(), newPath + item.Text.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Clear();
            string path = textBox2.Text;
            // получаем все файлы
            string[] files = Directory.GetFiles(path);
            // перебор полученных файлов
            for (int i = 0; i < files.Length; i++)
            {
                ListViewItem lvi = new ListViewItem();
                // установка названия файла
                lvi.Text = files[i].Remove(0, files[i].LastIndexOf('\\') + 1);
                imageList2.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(files[i]));
                lvi.ImageIndex = i;
                // установка картинки для файла
                // добавляем элемент в ListView
                listView2.Items.Add(lvi);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = fbd.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Для копирования нажмите на кнопку отобразить, Выделите файлы которые отображаются на листе и нажмите на кнопку копировать";
        }
    }
}