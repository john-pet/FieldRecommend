namespace FieldCompass_AcademicFieldRecommendationSystem
{
    internal class Course
    {
        internal string Name;
        internal int[] InterestsOptionsOne;
        internal int[] InterestsOptionsTwo;
        internal int[] PassionsOptionsOne;
        internal int[] SkillsAndStrengthsOptionsOne;
        internal int[] SkillsAndStrengthsOptionsTwo;
        internal int[] SkillsAndStrengthsOptionsThree;


        internal Course(string name, int[] interestOptionsOne, int[] interestOptionsTwo, int[] passionsOptionsOne, int[] skillsAndStrengthsOptionsOne, int[] skillsAndStrengthsOptionsTwo, int[] skillsAndStrengthsOptionsThree)
        {
            Name = name;
            InterestsOptionsOne = interestOptionsOne;
            InterestsOptionsTwo = interestOptionsTwo;
            PassionsOptionsOne = passionsOptionsOne;
            SkillsAndStrengthsOptionsOne = skillsAndStrengthsOptionsOne;
            SkillsAndStrengthsOptionsTwo = interestOptionsTwo;
            SkillsAndStrengthsOptionsThree = skillsAndStrengthsOptionsThree;
        }
    }
}
