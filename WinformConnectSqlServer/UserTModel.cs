using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformConnectSqlServer
{
    [Table("UserTForWinform")]
    public class UserTModel
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string NickName { get; set; }
        public string Sex { get; set; }

        [NotMapped]
        public string RealSex
        {
            get
            {
                if (Sex == "1")
                    return "男";
                else if (Sex == "2")
                    return "女";
                else
                    return "未知";
            }
        }
    }
}
