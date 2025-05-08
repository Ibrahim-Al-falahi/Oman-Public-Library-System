using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oman_Public_Library_System.Model
{
    internal class Member
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public DateOnly Joined { get; set; }
        public Member(string name, int id, DateOnly joined)
        {
            Name = name;
            Id = id;
            Joined = joined;
        }

    }
}
