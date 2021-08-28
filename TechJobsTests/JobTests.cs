using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job job1;
        Job job2;
        Job job3;
        Job job4;

        Employer ACME;
        Location desert;
        PositionType qualityControl;
        CoreCompetency persistence;

        [TestInitialize]
        public void CreateObjects()
        {
            job1 = new Job();
            job2 = new Job();

            ACME = new Employer("ACME");
            desert = new Location("Desert");
            qualityControl = new PositionType("Quality Control");
            persistence = new CoreCompetency("Persistence");

            job3 = new Job("Product tester", ACME, desert, qualityControl, persistence);
            job4 = new Job("Product tester", ACME, desert, qualityControl, persistence);
        }


        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestSettingJobId()
        {

            Assert.IsFalse(job1.Id.CompareTo(job2.Id) > 1);
            //Testing Rational Comparisons
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual(ACME, job3.EmployerName);
            Assert.AreEqual(desert, job3.EmployerLocation);
            Assert.AreEqual(qualityControl, job3.JobType);
            Assert.AreEqual(persistence, job3.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }
        [TestMethod]
        public void TestToStringBlankLines()
        {
            String toString = job1.ToString();
            Assert.IsTrue(toString.StartsWith("\n"));
        }

        [TestMethod]
        public void ShouldAddLabel()
        {
            Assert.AreEqual("\n" + "ID:  " + job1.Id + "\n" + "Name:  " + job1.Name + "\n" + "Employer:  " + job1.EmployerName + "\n" + "Location:  " + job1.EmployerLocation + "\n" + "Position Type:  " + job1.JobType + "\n" + "Core Competency:  " + job1.JobCoreCompetency, job1.ToString());
        }

        [TestMethod]
        public void EmptyField()
        {
            //string notAvailable = "Data not available";
            
            Employer EmployerInfoEmpty = new Employer("");
            Location LocationInfoEmpty = new Location("");
            PositionType PositionInfoEmpty = new PositionType("");
            CoreCompetency CompetencyInfoEmpty = new CoreCompetency("");

            Job job5 = new Job("", EmployerInfoEmpty, LocationInfoEmpty, PositionInfoEmpty, CompetencyInfoEmpty);

           // Assert.AreEqual("\n" + "ID:  " + job5.Id + "\n" + "Name:  " + job5.Name + "\n" + "Employer:  " + notAvailable + "\n" + "Location:  " + notAvailable + "\n" + "Position Type:  " + notAvailable + "\n" + "Core Competency:  " + notAvailable, job5.ToString());
            Assert.AreEqual("Data not available", job5.ToString());

        }
       
    }
}
