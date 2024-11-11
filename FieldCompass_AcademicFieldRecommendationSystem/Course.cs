using Newtonsoft.Json;

namespace FieldCompass_AcademicFieldRecommendationSystem
{
    internal class Course
    {
        public string Name { get; set; }
        public float MatchPercentage { get; set; }
        public int[] InterestsOptionsOne { get; set; }
        public int[] InterestsOptionsTwo { get; set; }
        public int[] PassionsOptionsOne { get; set; }
        public int[] SkillsAndStrengthsOptionsOne { get; set; }
        public int[] SkillsAndStrengthsOptionsTwo { get; set; }
        public int[] SkillsAndStrengthsOptionsThree { get; set; }
        public string CourseDetails { get; set; }
        public string CareerPaths { get; set; }

        public Course(string name, string courseDetails, string careerPaths, int[] interestsOptionsOne, int[] interestsOptionsTwo,
                  int[] passionsOptionsOne, int[] skillsAndStrengthsOptionsOne, int[] skillsAndStrengthsOptionsTwo,
                  int[] skillsAndStrengthsOptionsThree)
        {
            Name = name;
            CourseDetails = courseDetails;
            CareerPaths = careerPaths;
            InterestsOptionsOne = interestsOptionsOne;
            InterestsOptionsTwo = interestsOptionsTwo;
            PassionsOptionsOne = passionsOptionsOne;
            SkillsAndStrengthsOptionsOne = skillsAndStrengthsOptionsOne;
            SkillsAndStrengthsOptionsTwo = skillsAndStrengthsOptionsTwo;
            SkillsAndStrengthsOptionsThree = skillsAndStrengthsOptionsThree;
        }
    }
}
