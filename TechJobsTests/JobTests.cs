using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    

    [TestClass]
    public class JobTests
    {
        Job testJob1;
        Employer acme;
        Location desert;
        PositionType qa;
        CoreCompetency persistence;

        [TestInitialize]
        public void createTestJobAndFields()
        {
            acme = new Employer("ACME");
            desert = new Location("Desert");
            qa = new PositionType("Quality Control");
            persistence = new CoreCompetency("Persistence");

            testJob1 = new Job("Product tester", acme, desert, qa, persistence);

        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job2.Id - job1.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.IsTrue(testJob1.Name == "Product tester");
            Assert.IsTrue(testJob1.EmployerName.Value == "ACME");
            Assert.IsTrue(testJob1.EmployerLocation.Value == "Desert");
            Assert.IsTrue(testJob1.JobType.Value == "Quality Control");
            Assert.IsTrue(testJob1.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJob1 = new Job("Sandhya", new Employer("emp"), new Location("loc"), new PositionType("pos"), new CoreCompetency("smart"));
            Job testJob2 = new Job("Sandhya", new Employer("emp"), new Location("loc"), new PositionType("pos"), new CoreCompetency("smart"));
            Assert.AreNotEqual(testJob1, testJob2);
        }

        [TestMethod]
        public void TestJobsToString()
        {
            Assert.IsTrue(testJob1.ToString().Contains($"ID: " + testJob1.Id));
            Assert.IsTrue(testJob1.ToString().Contains($"Name: " + testJob1.Name));
            Assert.IsTrue(testJob1.ToString().Contains($"Employer: " + testJob1.EmployerName.Value));
            Assert.IsTrue(testJob1.ToString().Contains($"Location: " + testJob1.EmployerLocation.Value));
            Assert.IsTrue(testJob1.ToString().Contains($"Position Type: " + testJob1.JobType.Value));
            Assert.IsTrue(testJob1.ToString().Contains($"Core Competency: " + testJob1.JobCoreCompetency.Value));

            Job jobToStringTest2 = new Job("", acme, desert, qa, persistence);
            Assert.IsTrue(jobToStringTest2.ToString().Contains($"Name: Data not avaliable"));

            Job jobToStringTest3 = new Job();
            Assert.AreEqual(jobToStringTest3.ToString(), "OOPS! This job does not seem to exist.");
        }
    }
}
