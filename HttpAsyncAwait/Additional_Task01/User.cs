using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task01
{
    public class User
    {
        private string login = "Ronery";
        private string lastName ="Borodavka";
        private string firstName ="Roman";
        private int age = 25;
        private readonly DateTime dateOfFillingTheAncet;

        public User()
        {
            dateOfFillingTheAncet = DateTime.Now;
        }

        public User(string login, string lastName, string firstName, int age)
        {
            this.Login = login;
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Age = age;
            this.dateOfFillingTheAncet = DateTime.Now;
        }

        public string Login
        {
            set
            {
                if (value != "fool")
                {
                    login = value;
                }
            }
            get { return login ?? $"no data in the field{nameof(login)}"; }
        }

        public string LastName
        {
            set
            {
                if (value != "fool")
                {
                    lastName = value;
                }
            }
            get { return lastName ?? $"no data in the field{nameof(lastName)}"; }
        }

        public string FirstName
        {
            set
            {
                if (value != "fool")
                {
                    firstName = value;
                }
            }
            get { return firstName ?? $"no data in the field{nameof(firstName)}"; }
        }

        public int Age
        {
            set
            {
                if (value >0)
                {
                    age = value;
                }
            }
            get
            {
                if (age <= 0)
                    return 25;
                return age;
            }
        }

        public DateTime DateOfFillingTheAncet => dateOfFillingTheAncet;
    }
}
