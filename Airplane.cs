using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public class Airplane
    {
        public string Name { get; set;}
        public string Producer { get; set;}
        public int Year { get; set;}
        public string Type { get; set;}



public Airplane(){
    Name = "";
    Producer = "";
    Year = 0;
    Type = "";
}

public Airplane(string name, string producer, int year, string type){
    Name = name;
    Producer = producer;
    Year = year;
    Type = type;
}



public void input(){
    Console.WriteLine("enter name: ");
     Name = Console.ReadLine();

       Console.WriteLine("enter producer: ");
     Producer = Console.ReadLine();

       Console.WriteLine("enter year: ");
       string year = Console.ReadLine();
       int res = int.Parse(year);
       Year = res;

       Console.WriteLine("enter type: ");
       Type = Console.ReadLine();
}

public void output(){
    Console.WriteLine("\nname: " + Name + "\nproducer: " + Producer + "\nyear: " + Year + "\ntype: " + Type + "\n");
}

    }
}