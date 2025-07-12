using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Programmer";
        job1._company = "BizCat Company";
        job1._startYear = 2001;
        job1._endYear = 2005;

        Job job2 = new Job();
        job2._jobTitle = "Programmer";
        job2._company = "Power Well Automatic";
        job2._startYear = 2006;
        job2._endYear = 2010;

        Resume myResume = new Resume();
        myResume._name = "Japhet Gan";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

 
    }
}