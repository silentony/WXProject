using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Member
    {
        public int MemberId { set; get; }
        public string MemberName { set; get; }
        public string MemberPassword { set; get; }
        public int MemberLevelId { set; get; }
        public DateTime CreateTime { set; get; }
        public int MemberStatus { set; get; }
    }
}
