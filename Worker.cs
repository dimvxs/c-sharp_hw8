using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace hw
{
    public class Worker
    {
        
      public string Name { get; set; }
      public string Patronymic { get; set; }
       public string Surname { get; set; }
        public string Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string JobTitle { get; set; }
        public string Requirements { get; set; }
   
      
     
 public Worker(){
    Name = "";
    Patronymic = "";
    Surname = "";
    Birthday = "";
    Phone = "";
    Email = "";
    JobTitle = "";
    Requirements = "";
 }

 public Worker(string name, string patronymic, string surname, string birthday, string phone, string email, string jobTitle, string requirements){

Name = name;
Patronymic = patronymic;
Surname = surname;
Birthday = birthday;
Phone = phone;
Email = email;
JobTitle = jobTitle;
Requirements = requirements;

 }



public void input(){
    Console.WriteLine("enter name: ");
     Name = Console.ReadLine();

    Console.WriteLine("enter patronymic: ");
      Patronymic = Console.ReadLine();

    Console.WriteLine("enter surname: ");
       Surname = Console.ReadLine();

    Console.WriteLine("enter birthday: ");
           Birthday = Console.ReadLine();

    Console.WriteLine("enter phone: ");
       Phone = Console.ReadLine();

    Console.WriteLine("enter email: ");
       Email = Console.ReadLine();

    Console.WriteLine("enter job title: ");
       JobTitle = Console.ReadLine();

    Console.WriteLine("enter requirements: ");
       Requirements = Console.ReadLine();
}

public void print(){
  Console.Write("name: " + Name + "\npatronymic: " + Patronymic + "\nsurname: " + Surname + "\nbirthday: " + Birthday + "\nphone: " + Phone + "\nemail: " + Email + "\njob title:" + JobTitle + "\nrequirements: " + Requirements + "\n");
}

    }
}