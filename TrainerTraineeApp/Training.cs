namespace TrainerTraineeApp
{
    class Training
    {
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public Trainer Trainer { get; set; }
        public Course Course { get; set; }

        public int GetNumberOfTrainees()
        {
            return Trainees.Count;
        }

        public string GetOrgName()
        {
            return Trainer.TheOrganization.Name;
        }

        public int GetDuration()
        {
            int duration = 0;
            // for each module of course
            foreach (Module module in Course.Modules)
            {
                // for each unit of a module
                foreach (Unit unit in module.Units)
                {
                    duration += unit.Duration;
                }
            }
            return duration;

        }

    }
}
