using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolgui
{
   public class Person
    {
        private int id;
        private string name;
        private string lastname;
        private string email;
        private string password;
        private string create_at;
        private string update_at;

        public Person(int id, string name, string lastname, string email, string password, string create_at, string update_at)
        {
            this.Id = id;
            this.Name = name;
            this.Lastname = lastname;
            this.Email = email;
            this.Password = password;
            this.Create_at = create_at;
            this.Update_at = update_at;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Create_at { get => create_at; set => create_at = value; }
        public string Update_at { get => update_at; set => update_at = value; }

        public override String ToString()
        {
            return this.name + ", " + this.lastname + ", " + this.email;
        }
    }
}
