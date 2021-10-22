using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name) == true)
            {
                Name = "Data not available";
            }

            if (String.IsNullOrEmpty(EmployerName.Value) == true)
            {
                EmployerName.Value = "Data not available";
            }

            if (String.IsNullOrEmpty(EmployerLocation.Value) == true)
            {
                EmployerLocation.Value = "Data not available";
            }

            if (String.IsNullOrEmpty(JobType.Value) == true)
            {
                JobType.Value = "Data not available";
            }

            if (String.IsNullOrEmpty(JobCoreCompetency.Value) == true)
            {
                JobCoreCompetency.Value = "Data not available";
            }

            if (String.IsNullOrEmpty(Name) == true && String.IsNullOrEmpty(EmployerName.Value) == true && String.IsNullOrEmpty(EmployerLocation.Value) == true && String.IsNullOrEmpty(JobType.Value) == true && String.IsNullOrEmpty(JobCoreCompetency.Value) == true)
            {
                return "OOPS! This job does not seem to exist.";
            }

            return $"\n" +
                $"ID: {Id}\n" +
                $"Name: {Name}\n" +
                $"Employer: {EmployerName}\n" +
                $"Location: {EmployerLocation}\n" +
                $"Position Type: {JobType}\n" +
                $"Core Competency: {JobCoreCompetency}\n" +
                $"\n";
        }
    }
}
