using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketV2;

public class Worker
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Mail { get; set; }
    public string? Phone { get; set; }

    public DateTime Date { get; set; }

    public Worker()
    {
    }

    public Worker(string ? name , string ? surname , string ? mail,string ? phone , DateTime dateTime)
    {
        Name = name;
        Surname = surname;
        Mail = mail;
        Phone = phone;
        Date = dateTime;
    }

    public override string ToString()
    {
        return $"{Surname} {Name} - {Mail}";
    }
}
