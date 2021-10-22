using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        private Job job;

        [TestInitialize]

        public void CreateJobObject()
        {
            job = new Job("Product test",
                new Employer("Acme"),
                new Location("Desert"),
                new PositionType("Quality Control"),
                new CoreCompetency("Persistence")
            );
        }

        [TestMethod]
        public void TestSettingJobID()
        {
            Job job1 = new();
            Job job2 = new();
            Assert.IsTrue(job2.Id == job1.Id + 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.IsTrue(job.EmployerName.Value == "Acme");
            Assert.IsTrue(job.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job.JobType.Value == "Quality Control");
            Assert.IsTrue(job.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new("Product tester",
                new Employer("Acme"),
                new Location("Desert"),
                new PositionType("Quality Control"),
                new CoreCompetency("Persistence")
            );

            Assert.IsFalse(job.Equals(job1));
        }

        [TestMethod]
        public void TestToStringBlankLine()
        {
            string String = job.ToString();
            Assert.IsTrue(String.Substring(0, 1) == "\n");
            Assert.IsTrue(String.Substring(String.Length - 1, 1) == "\n");
        }

        public void TestToStringDataWithBlankLine()
        {
            Assert.IsTrue(job.ToString() == "ID: 1" +
                "Name: Product test" +
                "Employer: Acme" +
                "Location: Desert" +
                "Position Type: Quality Control" +
                "Core Competency: Persistence");
        }

        [TestMethod]
        public void TestDataNotAvailable()
        {
            Job job2 = new("Animator",
                new Employer(""),
                new Location(""),
                new PositionType(""),
                new CoreCompetency("")
            );

            Assert.IsTrue(job2.ToString() == "\n" +
                $"ID: {job2.Id}\n" +
                "Name: Animator\n" +
                "Employer: Data not available\n" +
                "Location: Data not available\n" +
                "Position Type: Data not available\n" +
                "Core Competency: Data not available\n" +
                $"\n");
        }

    }
}
