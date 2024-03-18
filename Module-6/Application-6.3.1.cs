using System;

namespace Module_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
        }

        static Department GetCurrentDepartment()
        {
            if (department?.Company?.Type == "����" && department?.City?.Name == "�����-���������")
            {
                Console.WriteLine("� ����� {0} ���� ��������� � �����-����������", department?.Company?.Name ?? "����������� ��������");
            }
        }
    }

    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }
}