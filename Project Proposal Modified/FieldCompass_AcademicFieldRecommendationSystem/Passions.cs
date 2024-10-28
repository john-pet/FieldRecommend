namespace FieldCompass_AcademicFieldRecommendationSystem
{
    internal class Passions : IQuestion
    {
        private static List<string> PassionsAnswersOne = new List<string>
        {
            "Participating in hands-on projects", "Learning about new technologies", "Solving technical problems",
            "Creating or building things", "Volunteering in community events", "Engaging in physical activities",
            "Conducting experiments", "Exploring the outdoors", "Participating in science-related activities",
            "Engaging in business activities", "Engaging in stocks, cryptocurrencies, trading", "Helping others",
            "Participating in advocacies and change", "Creating art or literature",
            "Participating or attending cultural events", "Exploring various forms of media",
            "Solving puzzles and problems", "Engaging in collaborative discussions", "Traveling to other places"
        };

        public List<int> AskQuestions()
        {
            List<int> answers = new List<int>();

            Console.WriteLine("Which of these aligns with your long-term goals?");
            Display.DisplayOptions("Passions", PassionsAnswersOne);
            answers.AddRange(Select.GetSelectedOptions(PassionsAnswersOne));

            return answers;
        }
    }
}
