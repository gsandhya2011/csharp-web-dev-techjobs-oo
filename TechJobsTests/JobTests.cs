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
    }
}
