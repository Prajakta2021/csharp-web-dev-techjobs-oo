using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsFalse(job1.Id.CompareTo(job2.Id) > 1);
            //Testing Rational Comparisons
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            string test_Name = "Product tester";
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality Control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");

            Job job3 = new Job(test_Name, employer, location, positionType, coreCompetency);

            Assert.AreEqual(test_Name, job3.Name);
            Assert.AreEqual(employer, job3.EmployerName);
            Assert.AreEqual(location, job3.EmployerLocation);
            Assert.AreEqual(positionType, job3.JobType);
            Assert.AreEqual(coreCompetency, job3.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            string test_Name = "Product tester";
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("Quality Control");
            CoreCompetency coreCompetency = new CoreCompetency("Persistence");

            Job job4 = new Job(test_Name, employer, location, positionType, coreCompetency);
            Job job5 = new Job(test_Name, employer, location, positionType, coreCompetency);

            Assert.IsFalse(job4.Equals(job5));
        }


        }
    }
