using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;   

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Assert.IsFalse(job1.Id == job2.Id);
            //why doesn't Assert.AreNotEqual(job1.Id, job2.Id, 1) pass???
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(1, job1.Id);
            Assert.IsTrue("Product tester" == job1.Name);
            Assert.IsTrue(job1.EmployerName.Value == "ACME");
            Assert.IsTrue("Desert" == job1.EmployerLocation.Value);
            Assert.IsTrue("Quality control" == job1.JobType.Value);
            Assert.IsTrue("Persistence" == job1.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            //is this what is wanted??
            Assert.Equals(job1, job2);
            //Assert.AreNotEqual(job1, job2);
        }
    }
    
}
