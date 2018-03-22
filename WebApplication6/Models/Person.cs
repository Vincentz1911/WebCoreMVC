using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    //Skal have en primary key der hedder Id
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }

        public List<Order> Orders { get; set; } // dette er en FK (1 til mange)
    }

    // Nu skal man migrate til databasen
    //Der skal man oprette en ContextKlasse der arver fra DBContext klassen
    //Der skal osse oprettes et DBSet<Person>, som er vores "virtuelle tabel" her i c#

    //Opretter en Controller med navnet PersonController
}
