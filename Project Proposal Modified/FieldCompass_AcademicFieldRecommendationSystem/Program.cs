namespace FieldCompass_AcademicFieldRecommendationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage welcomeMessage = new WelcomeMessage();

            Console.Clear();
            UserProfile userProfile = new UserProfile();
            Console.WriteLine("Enter your name:");
            userProfile.Name = Console.ReadLine();

            bool running = true;
            int selectedOption = 0;
            string[] mainMenu = { "Interests", "Passion", "Skills and Strengths", "Recommend Courses", "Exit" };

            while (running)
            {
                Console.Clear();

                for (int i = 0; i < mainMenu.Length; i++)
                {
                    string text = "==> " + mainMenu[i];

                    if (i == selectedOption)
                    {
                        CenterTexts.TextCenterer(text);
                    }
                    else
                    {
                        CenterTexts.TextCenterer(mainMenu[i]);
                    }
                }

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    selectedOption = (selectedOption == 0) ? mainMenu.Length - 1 : selectedOption - 1;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    selectedOption = (selectedOption == mainMenu.Length - 1) ? 0 : selectedOption + 1;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    switch (selectedOption)
                    {
                        case 0:
                            // Handling Interests
                            Interests interests = new Interests();
                            userProfile.InterestsAnswersOne = interests.AskQuestions();
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            userProfile.InterestsAnswersTwo = interests.AskQuestions();
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 1:
                            // Handling Passions
                            Passions passions = new Passions();
                            userProfile.PassionsAnswersOne = passions.AskQuestions();
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            // Handling Skills and Strengths
                            SkillsStrengths skillsStrengths = new SkillsStrengths();
                            userProfile.SkillsAndStrengthsAnswersOne = skillsStrengths.AskQuestions();
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            userProfile.SkillsAndStrengthsAnswersTwo = skillsStrengths.AskQuestions();
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            userProfile.SkillsAndStrengthsAnswersThree = skillsStrengths.AskQuestions();
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            // Instantiating an object of class CourseDatabase
                            CourseDatabase courseDatabase = new CourseDatabase();
                            // This will retrieve the information from the database that we made about the courses and their related information
                            List<Course> courses = courseDatabase.InitializeCourseDatabase();

                            // RecommendCourse() is a static method which can be called directly without creating an instance of the class CourseRecommender
                            // This will pass the userProfile (including skills and passions) and courses to the recommender
                            List<Course> recommendedCourses = CourseRecommender.RecommendCourses(userProfile, courses);

                            // Display recommendations
                            CourseRecommender.DisplayRecommendations(recommendedCourses);
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            break;
                        case 4:
                            running = false; // Exit the loop and end the program
                            break;
                    }
                }
            }
        }
    }
}
