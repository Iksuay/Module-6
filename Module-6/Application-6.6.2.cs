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
                    Console.WriteLine("����� ������ ���� ������ �� 3 ��������");
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
                    Console.WriteLine("�������� ������ ������ ����������� �����");
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
                    Console.WriteLine("������� ������ ���� �� ������ 18");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}