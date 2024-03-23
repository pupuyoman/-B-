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

namespace Stegano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 创建 OpenFileDialog 对象
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 设置文件类型过滤
            openFileDialog.Filter = "图像文件|*.jpg;*.jpeg;*.png;*.gif;*.bmp|所有文件|*.*";

            // 显示 OpenFileDialog 对话框并检查用户是否点击了“确定”按钮
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 获取用户选择的文件路径
                    string selectedImagePath = openFileDialog.FileName;

                    // 使用 Image.FromFile 方法加载图像文件
                    Image selectedImage = Image.FromFile(selectedImagePath);

                    // 根据 PictureBox 控件的大小进行缩放
                    int pictureBoxWidth = pictureBox1.Width;
                    int pictureBoxHeight = pictureBox1.Height;
                    Image resizedImage = selectedImage.GetThumbnailImage(pictureBoxWidth, pictureBoxHeight, null, IntPtr.Zero);

                    // 将缩放后的图像显示在 PictureBox 控件中
                    pictureBox1.Image = resizedImage;

                    // 显示文件名
                    string fileName = Path.GetFileName(selectedImagePath);
                    label3.Text = fileName; // 将 Label 控件的文本更改为文件名
                }
                catch (Exception ex)
                {
                    MessageBox.Show("加载图像失败: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 创建 OpenFileDialog 对象
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 设置文件类型过滤
            openFileDialog.Filter = "图像文件|*.jpg;*.jpeg;*.png;*.gif;*.bmp|所有文件|*.*";

            // 显示 OpenFileDialog 对话框并检查用户是否点击了“确定”按钮
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 获取用户选择的文件路径
                    string selectedImagePath = openFileDialog.FileName;

                    // 使用 Image.FromFile 方法加载图像文件
                    Image selectedImage = Image.FromFile(selectedImagePath);

                    // 根据 PictureBox 控件的大小进行缩放
                    int pictureBoxWidth = pictureBox2.Width;
                    int pictureBoxHeight = pictureBox2.Height;
                    Image resizedImage = selectedImage.GetThumbnailImage(pictureBoxWidth, pictureBoxHeight, null, IntPtr.Zero);

                    // 将缩放后的图像显示在 PictureBox 控件中
                    pictureBox2.Image = resizedImage;

                    // 显示文件名
                    string fileName = Path.GetFileName(selectedImagePath);
                    label4.Text = fileName; // 将 Label 控件的文本更改为文件名
                }
                catch (Exception ex)
                {
                    MessageBox.Show("加载图像失败: " + ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 创建 OpenFileDialog 对象
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 设置文件类型过滤
            openFileDialog.Filter = "图像文件|*.jpg;*.jpeg;*.png;*.gif;*.bmp|所有文件|*.*";

            // 显示 OpenFileDialog 对话框并检查用户是否点击了“确定”按钮
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 获取用户选择的文件路径
                    string selectedImagePath = openFileDialog.FileName;

                    // 使用 Image.FromFile 方法加载图像文件
                    Image selectedImage = Image.FromFile(selectedImagePath);

                    // 根据 PictureBox 控件的大小进行缩放
                    int pictureBoxWidth = pictureBox3.Width;
                    int pictureBoxHeight = pictureBox3.Height;
                    Image resizedImage = selectedImage.GetThumbnailImage(pictureBoxWidth, pictureBoxHeight, null, IntPtr.Zero);

                    // 将缩放后的图像显示在 PictureBox 控件中
                    pictureBox3.Image = resizedImage;

                    // 显示文件名
                    string fileName = Path.GetFileName(selectedImagePath);
                    label5.Text = fileName; // 将 Label 控件的文本更改为文件名
                }
                catch (Exception ex)
                {
                    MessageBox.Show("加载图像失败: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 检查 textBox1 是否有输入密码
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                // 显示提示消息
                MessageBox.Show("請輸入密碼在進行此操作！");
            }
            else
            {
                // 检查 pictureBox1 和 pictureBox2 是否都有图像
                if (pictureBox1.Image != null && pictureBox2.Image != null)
                {
                    // 当两个 pictureBox 中都有图像时，执行你的逻辑
                    // 例如：合并两个图像
                }
                else
                {
                    // 提示用户需要先放入两张图像才能执行操作
                    MessageBox.Show("請放入圖片在進行此操作!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 检查 textBox1 是否有输入密码
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                // 显示提示消息
                MessageBox.Show("請輸入密碼在進行此操作！");
            }
            else
            {
                if (pictureBox3.Image != null)
                {
                    // 当 pictureBox3 中有图像时，执行你的逻辑
                    // 例如：处理 pictureBox3 中的图像
                }
                else
                {
                    // 提示用户需要先放入图像才能执行操作
                    MessageBox.Show("請放入圖片在進行此操作!");
                }
            }
        }
    }
}