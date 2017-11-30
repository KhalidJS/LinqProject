using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProjectExercise15
{
  public class Program
  {
    static void Main(string[] args)
    {
      // task 1
      Console.WriteLine("Indtast venligst et beløb");
      int indtastBeløb = Convert.ToInt32(Console.ReadLine());
      ShowPersonWSalaryHigherThan(indtastBeløb);
      // task 2
      MovePeopleToArrayWSalaryHigherThan(200000);
    }
    private static void ShowPersonWSalaryHigherThan(int salary)
    {
      eksempeldbEntities db = new eksempeldbEntities();
      Console.WriteLine("Returner løninger der er højere end " + salary);
      Console.WriteLine();
      var t = from l in db.people
              where l.loen > salary
              select l;
      foreach (var loen in t)
      {
        Console.WriteLine(loen.loen);
      }
      Console.ReadLine();
    }
    private static void MovePeopleToArrayWSalaryHigherThan(int salary)
    {
      eksempeldbEntities db = new eksempeldbEntities();
      IEnumerable<person> arrayperson = null;


      var t = from l in db.people
              where l.loen > salary
              select l;

      arrayperson = t.ToArray();

      foreach (var loninger in arrayperson)
      {
        Console.WriteLine(loninger.loen);
      }
      Console.ReadLine();
    }
    private static void ShowPeopleInACompany()
    {
      eksempeldbEntities db = new eksempeldbEntities();
      var peopleincompany = from person in db.people
                            where person.firmas.Count > 0
                            select person;
    }
  }
}