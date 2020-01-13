using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mustafabukulmez_com_dersler._000_Classlar
{
    class Misafirler
    {
        private string FirstName;
        private string LastName;
        private int Age;

        public Misafirler(string fName, string lName, int age)
        {
            FirstName = fName;
            LastName = lName;
            if (age > 50)
                throw new IndexOutOfRangeException("Yaş;" + Environment.NewLine + "Değer: " + age + Environment.NewLine + "Tüm misafirler 50 yaşında ya da daha küçük olmalıdır.");
            if (age < 21)
                throw new ArgumentOutOfRangeException("Yaş;" + Environment.NewLine + "Değer: " + age, "Tüm misafirler 21 yaşında ya da daha büyük olmalıdır.");
            else
                Age = age;
        }

        public string MisafirBilgi()
        {
            string gInfo = FirstName + " " + LastName + ", " + Age.ToString();
            return (gInfo);
        }
    }
}
