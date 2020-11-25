using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
            // or use .IsTrue ( != )
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
            //or can use Assert.IsFalse(job1.Equals(job2));
            Assert.AreNotEqual(job1, job2);
        }

        [TestMethod]
        public void TestforLine()
        {
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            
            string test = job2.ToString();
            
            char first = test[0];
            char second = test[test.Length - 1];
            Assert.IsTrue(first == '\n');
            Assert.IsTrue(second == '\n'); // or first = sec
            //is this enough?
            Assert.AreEqual(first + test + second, "\n" + test + "\n");
        }

        [TestMethod]
        public void TestforLabel()
        {
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            string test = job2.ToString();
            //is this enough?
            Assert.AreEqual(test, "\nID: 1\nName: Web Developer\nEmployer: LaunchCode\nLocation: St. Louis\nPosition Type: Front-end developer\nCore Competency: JavaScript\n");

        }

        //if a field empty add data not available after label
        [TestMethod]
        public void TestforEmpty()
        {
            Job empty = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
            string nothing = "Data Unavailable";
            string test = empty.ToString();
            //Assert.AreEqual(empty.Name, nothing);
            //is this enough?
            Assert.AreEqual(test, "\nID: 1" + "\nName: " + nothing + "\nEmployer: " + nothing + "\nLocation: " + nothing + "\nPosition Type: " + nothing + "\nCore Competency: " + nothing + "\n");
            

        }

        /*[TestMethod]
        public void TestforEmpty()
        {

        }*/

    }

}
