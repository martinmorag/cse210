using System;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._jobTitle = "Customer Support Agent";
        job1._company = "Claro";
        job1._startYear = 2012;
        job1._endYear = 2014;

        Job job2 = new Job();
        job2._jobTitle = "Sales Agent";
        job2._company = "Accenture";
        job2._startYear = 2014;
        job2._endYear = 2016;

        Resume resume = new Resume();
        resume._name = "Martin Moraga";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        
        resume.Display();

    }  
    
}
