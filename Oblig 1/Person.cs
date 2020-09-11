using System;

namespace Oblig_1
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int BirthYear;
        public int DeathYear;
        public Person Father;
        public Person Mother;


        public string GetDescription()
        {
            string desc = null;

            if (FirstName != null) { desc += $"{FirstName} "; }
            if (LastName != null) { desc += $"{LastName} "; }
            if (Id != 0) { desc += $"(Id={Id})"; }
            if (BirthYear != 0) { desc += $" Født: {BirthYear}"; }
            if (DeathYear != 0) { desc += $" Død: {DeathYear}"; }
            if (Father != null)
            {
                desc += " Far:";
                if (Father.FirstName != null) { desc += $" {Father.FirstName}"; }
                desc += $" (Id={Father.Id})";
            }
            if (Mother != null)
            {
                desc += " Mor:";
                if (Mother.FirstName != null) { desc += $" {Mother.FirstName}"; }
                desc += $" (Id={Mother.Id})" ;
            }

           
            return desc;
        }
    }
}