﻿namespace FieldCompass_AcademicFieldRecommendationSystem
{
    public class Interests : IQuestion
    {
        private int count = 1;
        private static List<string> InterestsAnswersOne = new List<string>
        {
            "Mathematics", "Physics", "Computer Education", "Chemistry", "Biology", "Psychology",
            "Anatomy", "Earth Science", "Economics", "Accounting", "Management", "Sociology",
            "History", "Literature", "Philosophy", "Art", "General Science", "Politics",
            "Ethics", "Environmental science", "Statistics", "Economics", "Geography"
        };

        private static List<string> InterestsAnswersTwo = new List<string>
        {
            "Building or fixing things (DIY projects)", "Coding or programming",
            "Playing with gadgets (exploring electronics)", "Helping others or Volunteering (community service)",
            "Exercising (going for walks or workouts)", "Reading or watching health-related content",
            "Exploring nature (hiking, camping, or visiting parks)", "Conducting simple experiments (at home or in school)",
            "Reading or watching science-related content", "Participating in school clubs",
            "Reading books or watching videos on entrepreneurship", "Engaging in group activities",
            "Managing personal finances (budgeting)", "Engaging in community discussions or public speaking",
            "Reading books on history or culture", "Creating art (drawing, painting, or crafting)",
            "Reading literature (novels or poetry)", "Attending cultural events (theater, music concerts)",
            "Writing stories or keeping a journal", "Reading educational materials (books or articles)",
            "Debating topics (in school or community)", "Reading about current events (news articles)",
            "Taking photos or videos", "Engaging on social media", "Gardening", "Visiting architectural sites",
            "Solving puzzles (math or logic puzzles)", "Playing strategy games (like chess or board games)"
        };

        public List<int> AskQuestions()
        {
            List<int> answers = new List<int>();

            if(count == 1)
            {
                Console.WriteLine("What subjects do you enjoy the most?");
                Display.DisplayOptions("Interests", InterestsAnswersOne);
                answers.AddRange(Select.GetSelectedOptions(InterestsAnswersOne));
            }
            
            if(count == 2)
            {
                Console.WriteLine("Which activities do you enjoy outside school?");
                Display.DisplayOptions("Interests", InterestsAnswersTwo);
                answers.AddRange(Select.GetSelectedOptions(InterestsAnswersTwo));
                count = 0;
            }
            count++;
            

            return answers;
        }
    }
}
