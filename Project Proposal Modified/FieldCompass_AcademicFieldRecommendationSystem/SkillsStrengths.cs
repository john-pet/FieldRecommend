namespace FieldCompass_AcademicFieldRecommendationSystem
{
    internal class SkillsStrengths : IQuestion
    {
        private int count = 1;
        private static List<string> SkillsStrengthsAnswersOne = new List<string>
        {
            "Analytical Skills (e.g., Critical Thinking, Problem-Solving)", "Practical Skills (e.g., Hands-on Projects, Lab Works, Experiments)",
            "Creative Skills (e.g., Designing, Art)", "Communication Skills (e.g., Negotiation, Explaining Concepts)",
            "Curiosity in Science or Nature (e.g., Exploring Natural Phenomena)", "Leadership Skills (e.g., Organizing, Decision-Making)",
            "Empathy and Awareness (e.g., Understanding Social Issues)", "Interpretative Skills (e.g., Analyzing Literature, History)",
            "Ethical Awareness (e.g., Fairness, Understanding Rights)", "Adaptability (e.g., Learning New Things)",
            "Logical Reasoning (e.g., Making Connections, Patterns)", "Attention to Detail (e.g., Accuracy, Precision)"
        };

        private static List<string> SkillsStrengthsAnswersTwo = new List<string>
        {
            "Problem-Solving", "Practical and Hands-On Skills", "Innovation and Creativity",
            "Leadership and Management", "Research and Analysis", "Public Speaking and Communication"
        };

        private static List<string> SkillsStrengthsAnswersThree = new List<string>
        {
            "Office-Based", "Lab-Based (scientific research)", "Hands-On Workshop",
            "Collaborative Team Spaces", "Clinical Settings (e.g., hospitals, clinics)",
            "Field-Based (community or outdoor work)", "Flexible/Remote Work",
            "Creative Studio", "Classroom-Based", "Community-Based Settings"
        };

        public List<int> AskQuestions()
        {
            List<int> answers = new List<int>();
            if (count == 1)
            {
                Console.WriteLine("What are your strengths in school subjects?");
                Display.DisplayOptions("Skills and Strengths", SkillsStrengthsAnswersOne);
                answers.AddRange(Select.GetSelectedOptions(SkillsStrengthsAnswersOne));
            }

            if (count == 2)
            {
                Console.WriteLine("Which skills would you like to develop further?");
                Display.DisplayOptions("Skills and Strengths", SkillsStrengthsAnswersTwo);
                answers.AddRange(Select.GetSelectedOptions(SkillsStrengthsAnswersTwo));
            }
            
            if(count == 3)
            {
                Console.WriteLine("What types of work environments interest you?");
                Display.DisplayOptions("Skills and Strengths", SkillsStrengthsAnswersThree);
                answers.AddRange(Select.GetSelectedOptions(SkillsStrengthsAnswersThree));
                count = 0;
            }
            count++;
            return answers;
        }
    }
}
