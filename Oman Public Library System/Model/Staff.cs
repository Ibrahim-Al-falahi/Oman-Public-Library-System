using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oman_Public_Library_System.Model
{
    internal class Staff
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string[] Member { get; set; }

        List<Member> members;

        public Staff(int id, string name)
        {
            Id = id;
            Name = name;
            members = new List<Member>();
        }

        public void AddMember(Member member)
        {

            members.Add(member);



        }
        



    }
}
