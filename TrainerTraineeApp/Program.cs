﻿namespace TrainerTraineeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {






            Console.WriteLine("Hello, World!");
            // get org name
            Training training = new Training();
            Trainer trainer = new Trainer();

            training.Trainer = trainer;

            Organization org = new Organization();
            org.Name = "edForce";
            trainer.TheOrganization = org;

            string name = training.GetOrgName();
            Console.WriteLine(name);


            Trainee t1 = new Trainee();
            Trainee t2 = new Trainee();
            Trainee t3 = new Trainee();

            training.Trainees.Add(t1);
            training.Trainees.Add(t2);
            training.Trainees.Add(t3);

            Console.WriteLine($"No. of Trainees : {training.GetNumberOfTrainees()}");

            Course c = new Course();
            training.Course = c;
            Module m1 = new();
            Module m2 = new();
            Module m3 = new();

            c.Modules.Add(m1);
            c.Modules.Add(m2);
            c.Modules.Add(m3);

            Unit u1 = new Unit();
            u1.Duration = 60;
            Unit u2 = new Unit { Duration = 40 };
            Unit u3 = new Unit { Duration = 40 };
            Unit u4 = new Unit { Duration = 40 };
            Unit u5 = new Unit { Duration = 40 };
            Unit u6 = new Unit { Duration = 40 };

            m1.Units.Add(u1);
            m1.Units.Add(u2);

            m2.Units.Add(u3);
            m2.Units.Add(u4);

            m3.Units.Add(u5);
            m3.Units.Add(u6);

            Console.WriteLine($"Total Duration: {training.GetDuration()}");
        }
    }
}
