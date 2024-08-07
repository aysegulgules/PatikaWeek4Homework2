using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4Homework2
{
    public class Baby
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        //Default Constructor
        public Baby()
        {
            BirthDate = DateTime.Now;            
            Console.WriteLine("Ingaaaa ");
        }

        //ikinci Constructor
        public Baby(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;    
            BirthDate=DateTime.Now;
            Console.WriteLine("\nBebeğin Adı-Soyadı :" + FirstName + " " + LastName);
            Console.WriteLine("Bebeğin doğum tarihi..:" + BirthDate.ToShortDateString());
            Console.WriteLine("Ingaaaa ");
        }


        /// <summary>
        /// Default constructor new'leme anında çalıştığı için FirstName ve LastName property'leri null dır.
        /// Bundan dolayı bu metod default constructor ile newlenen nesneyi ekrana yazdırmak için oluşturuldu.
        /// </summary>
        public void BabyInfo()
        {
            Console.WriteLine("Bebeğin Adı-Soyadı :" + FirstName+" "+ LastName);
            Console.WriteLine("Bebeğin doğum tarihi..:" + BirthDate.ToShortDateString());
        }
    }
}
