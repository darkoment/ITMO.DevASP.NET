using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

/// <summary>
/// Сводное описание для Person
/// </summary>
public class Person
{
    public Person()
    {

    }
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Patronymic { get; set; }
    public DateTime Birthday { get; set; }

}