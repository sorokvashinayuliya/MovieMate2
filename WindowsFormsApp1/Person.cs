using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2MovieMate
{
    public class Person
    {
        public int Id { get; set; }

        public string Nickname { get; set; }

        public string IdMovieLike { get; set; }

        public string IdBlackList { get; set; }

        public string IdFavorites { get; set; }

        public byte[] Picture { get; set; }
       
    }
    
}

