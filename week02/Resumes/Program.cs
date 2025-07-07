using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._jobTitle = "Sofware Engineer";
        job._company = "Apple";
        job._startYear = 2010;
        job._endYear = 2015;
        

        Job job1 = new Job();
        job1._jobTitle = "Business Manager";
        job1._company = "Google";
        job1._startYear = 2015;
        job1._endYear = 2018;
        

        Resume resume = new Resume();
        resume._name = "Ana";
        resume._jobs.Add(job);
        resume._jobs.Add(job1);

        resume.ResumeDisplay();
        
    }
}