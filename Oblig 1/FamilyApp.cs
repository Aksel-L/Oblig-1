using System;
using System.Collections.Generic;

namespace Oblig_1
{
    public class FamilyApp
    {
        public string CommandPrompt = "\n: ";
        public string WelcomeMessage = "Hei på deg!!";
        private List<Person> _people;

        public FamilyApp(params Person[] people)
        {
            _people = new List<Person>(people);
        }

        public string HandleCommand(string comand)
        {
            if (comand.ToLower() == "hjelp")
            {
                string HelpMenu = "skriv: 'hjelp' for liste over kommandoer. \n" +
                    "skriv: 'list' for å se slektninger som er registrert. \n" +
                    "skriv: 'vis <id>' for å se personen med denne id.";
                return HelpMenu;
            }

            if (comand.ToLower() == "list")
            {
                string lister = null;
                foreach (var person in _people)
                {
                    lister += person.GetDescription() + "\n";
                }
                return lister;
            }

            if (comand.Substring(0, 3).ToLower() == "vis")
            {
                string desc = null;
                int visId = Int32.Parse(comand.Substring(4));
                foreach (var person in _people)
                {
                    if (visId == person.Id)
                    {
                        desc += person.GetDescription() + "\n";
                        GetKidDescription(visId);
                        if (GetKidDescription(visId) != null)
                        {
                            desc += "  Barn:\n" + GetKidDescription(visId);
                        }
                        return desc;
                    }

                }

            }
            return "";
        }

        public string GetKidDescription(int visId)
        {
            string children = null;
            foreach (var t in _people)
            {
                if (t.Father != null && t.Father.Id == visId)
                {
                    children += $"    {t.FirstName} (Id={t.Id}) Født: {t.BirthYear}\n";
                }
                else if (t.Mother != null && t.Mother.Id == visId)
                {
                    children += $"   {t.FirstName} (Id={t.Id}) Født: {t.BirthYear}\n";
                }
            }

            return children;
        }
    }
}