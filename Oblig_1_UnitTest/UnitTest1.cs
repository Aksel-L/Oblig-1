using NUnit.Framework;
using Oblig_1;

namespace Oblig_1_UnitTest
{
    public class Tests
    {
        [Test]
        public void TestAllFields()
        {
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                BirthYear = 2000,
                DeathYear = 3000,
                Father = new Person() { Id = 23, FirstName = "Per" },
                Mother = new Person() { Id = 29, FirstName = "Lise" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=17) Født: 2000 Død: 3000 Far: Per (Id=23) Mor: Lise (Id=29)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void TestNameFields()
        {
            var p = new Person
            {
                Id = 17,
                FirstName = "Ola",
                LastName = "Nordmann",
                
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "Ola Nordmann (Id=17)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
        [Test]
        public void TestDateFields()
        {
            var p = new Person
            {
                Id = 17,
                BirthYear = 2000,
                DeathYear = 3000,
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "(Id=17) Født: 2000 Død: 3000";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void TestParentsFields()
        {
            var p = new Person
            {
                Id = 17,
                Father = new Person() { Id = 23, FirstName = "Per" },
                Mother = new Person() { Id = 29, FirstName = "Lise" },
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "(Id=17) Far: Per (Id=23) Mor: Lise (Id=29)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }

        [Test]
        public void TestNoFields()
        {
            var p = new Person
            {
                Id = 1,
            };

            var actualDescription = p.GetDescription();
            var expectedDescription = "(Id=1)";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
    }
}