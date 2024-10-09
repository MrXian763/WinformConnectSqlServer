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
    }
}
