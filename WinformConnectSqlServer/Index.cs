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
    public partial class Index : Form
    {
        public Index(UserTModel model)
        {
            InitializeComponent();
            label1.Text = $"欢迎您：{model.NickName} 登录系统";
        }

        /// <summary>
        /// 窗口关闭后触发
        /// </summary>
        private void Index_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 页面加载完成调用
        /// </summary>
        private void Index_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;

            this.InitUsers();
        }

        /// <summary>
        /// 加载所有用户数据
        /// </summary>
        public void InitUsers()
        {
            List<UserTModel> userList = new List<UserTModel>();
            using (MyDBContext context = new MyDBContext())
            {
                userList = context.UserTForWinform.ToList();
            }

            dataGridView1.DataSource = userList;
        }

        /// <summary>
        /// 表格单元格被点击
        /// </summary>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 点击编辑按钮
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                string userName = dataGridView1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();

                // 弹出编辑窗口
                EditForm editForm = new EditForm(userName, this);
                editForm.ShowDialog();
            }
        }
    }
}
