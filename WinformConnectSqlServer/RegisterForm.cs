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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击注册按钮
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            string confirmPassword = tbConfirmPwd.Text;
            string nickName = tbNickName.Text;
            string sex = null;
            if (rbMale.Checked)
                sex = "1";
            else
                sex = "2";
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(nickName) || string.IsNullOrEmpty(sex))
            {
                MessageBox.Show("输入不能为空！");
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("两次输入的密码不一致！");
                return;
            }

            UserTModel user = new UserTModel();
            user.UserName = userName;
            user.Password = password;
            user.NickName = nickName;
            user.Sex = sex;

            int i = 0;
            using (MyDBContext context = new MyDBContext())
            {
                // 校验用户名是否重复注册
                int count = context.UserTForWinform.Count(u => u.UserName == userName);
                if (count > 0)
                {
                    MessageBox.Show("用户名已经被注册！");
                    return;
                }

                // 保存数据
                context.UserTForWinform.Attach(user);
                context.Entry(user).State = System.Data.Entity.EntityState.Added;
                i = context.SaveChanges();
            }
            if (i > 0)
            {
                MessageBox.Show("注册成功！");
                this.Close(); // 关闭当前窗口
            }
            else
                MessageBox.Show("注册失败！");
        }
    }
}
