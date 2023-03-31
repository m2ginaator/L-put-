using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lõputöö
{
    public class HumanList
    {
        public static readonly List<Humans> people = new List<Humans>
        {
            new Humans()
            {
                Id = 1,
                Name = "Mihkel",
                Age = 16,
                GenderId = Guid.Parse("ad8b1be0-f710-4976-bfda-16d18a868f61")
            },

            new Humans()
            {
                Id = 2,
                Name = "Dagmar",
                Age = 20,
                GenderId = Guid.Parse("a76b8508-0e64-4fa2-b841-416318724f52")
            },

            new Humans()
            {
                Id = 3,
                Name = "Anton",
                Age = 33,
                GenderId = Guid.Parse("ad8b1be0-f710-4976-bfda-16d18a868f61")
            },

            new Humans()
            {
                Id = 4,
                Name = "Emilia",
                Age = 18,
                GenderId = Guid.Parse("a76b8508-0e64-4fa2-b841-416318724f52")
            },

            new Humans()
            {
                Id = 5,
                Name = "Hannes",
                Age = 17,
                GenderId = Guid.Parse("ad8b1be0-f710-4976-bfda-16d18a868f61")
            }
        };
    }
}
