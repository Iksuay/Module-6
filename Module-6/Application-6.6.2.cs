using System;

namespace Module_6
{
    class Application_6_3_1
    {

    }

    class User
    {
        private string login;

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                if (login.Length < 3)
                {
                    Console.WriteLine("Логин должен быть длиной от 3 символов");
                }
                else
                {
                    login = value;
                }
            }
        }

        private string email;

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (!value.Contains('@'))
                {
                    Console.WriteLine("Неверный формат адреса электронной почты");
                }

                else
                {
                    email = value;
                }
            }
        }

        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}