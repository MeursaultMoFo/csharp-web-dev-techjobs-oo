using System;
using System.Collections.Generic;

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
        /*public Job(string name, string employerName, string employerLocation, string jobType, string jobCoreCompetency) : this()*/
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        
        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id &&
                   Name == job.Name &&
                   EqualityComparer<Employer>.Default.Equals(EmployerName, job.EmployerName) &&
                   EqualityComparer<Location>.Default.Equals(EmployerLocation, job.EmployerLocation) &&
                   EqualityComparer<PositionType>.Default.Equals(JobType, job.JobType) &&
                   EqualityComparer<CoreCompetency>.Default.Equals(JobCoreCompetency, job.JobCoreCompetency);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }

        public override string ToString()
        {
            string line = "\n";
            line += "ID: " + Id;
            line += "\nName: ";
            if (Name != "")
                line += Name;
            else
                line += "Data Unavailable";

            line += "\nEmployer: ";
            if (EmployerName.Value != "")
                line += EmployerName;
            else
                line += "Data Unavailable";

            line += "\nLocation: ";
            if (EmployerLocation.Value != "")
                line += EmployerLocation;
            else
                line += "Data Unavailable";

            line += "\nPosition Type: ";
            if (JobType.Value != "")
                line += JobType;
            else
                line += "Data Unavailable";

            line += "\nCore Competency: ";
            if (JobCoreCompetency.Value != "")
                line += JobCoreCompetency;
            else
                line += "Data Unavailable";

            line += "\n";
            return line;

            

            //return line + Name + line;
            //return line + "Employer: " + EmployerName  + "Location: " + EmployerLocation  + "Position Type: " + JobType  + "Core Competency: " + JobCoreCompetency;

        }

    }
}
