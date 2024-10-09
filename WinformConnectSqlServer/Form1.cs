using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformConnectSqlServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击登录按钮
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("账号或密码为空!");
                return;
            }

            UserTModel user = null;
            // 构建查询对象
            using (MyDBContext context = new MyDBContext())
            {
                user = context.UserTForWinform.FirstOrDefault(u => u.UserName == userName && u.Password == password);
            }

            if (user == null)
            {
                MessageBox.Show("登录失败，用户名或密码错误！");
                return;
            }

            // 弹出首页
            Index index = new Index(user);
            index.Show();

            // 隐藏当前登录界面
            this.Hide();

        }

        /// <summary>
        /// 点击注册按钮
        /// </summary>
        private void label3_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
