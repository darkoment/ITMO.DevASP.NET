using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для group
/// </summary>
public class Group
{
    public Group()
    {
        //
        // TODO: добавьте логику конструктора
        //
    }

    public int GroupID { get; set; }
    public string Name { get; set; }
    public virtual List<Student> Students { get; set; }
}