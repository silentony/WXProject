using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Enums
    {
        /// <summary>
        /// 会员类别
        /// </summary>
        public enum MemberLevelId
        {
            普通会员 = 1,
            银牌会员,
            金牌会员,
            超级会员
        }
        /// <summary>
        /// 会员状态
        /// </summary>
        public enum MemberStatus
        {
            注册 = 0,
            激活,
            注销,
            删除
        }
    }
}
