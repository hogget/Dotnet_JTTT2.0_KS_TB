using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Task
    {
        public string Adres_strony;
        public string Klucz;
        public string Email;
        public Task(string Adres, string klucz, string email)
        {
            Adres_strony = Adres;
            Klucz = klucz;
            Email = email;
        }
        public Task() { }
    }
}
