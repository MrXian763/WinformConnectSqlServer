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
    public partial class EditForm : Form
    {
        string currentUserName = null;
        Index currentIndexForm = null;

        public EditForm(string userName, Index indexForm)
        {
            InitializeComponent();

            label1.Text = $"编辑用户：{userName}";
            currentUserName = userName;
            currentIndexForm = indexForm;
        }

        UserTModel editUser = new UserTModel();

        /// <summary>
        /// 页面加载完成触发
        /// </summary>
        private void EditForm_Load(object sender, EventArgs e)
        {
            using (MyDBContext context = new MyDBContext())
            {
                editUser = context.UserTForWinform.FirstOrDefault(u => u.UserName == currentUserName);
            }

            tbNickName.Text = editUser.NickName;

        }

        /// <summary>
        /// 点击编辑按钮
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            using (MyDBContext context = new MyDBContext())
            {
                editUser.NickName = tbNickName.Text;
                context.UserTForWinform.Attach(editUser);
                context.Entry(editUser).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            this.Close(); // 关闭当前页面

            // 重新加载数据
            currentIndexForm.InitUsers();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
