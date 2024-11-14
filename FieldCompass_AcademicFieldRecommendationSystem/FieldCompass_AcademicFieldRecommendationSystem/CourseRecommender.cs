namespace FieldCompass_AcademicFieldRecommendationSystem
{
    internal class CourseRecommender
    {
        internal static List<Course> RecommendCourses(UserProfile userProfile, List<Course> courses)
        {
            List<Course> recommendedCourses = new List<Course>();

            foreach (var course in courses)
            {
                float count = 0;
                bool interestOneMatch = MatchesAny(course.InterestsOptionsOne, userProfile.InterestsAnswersOne);
                bool interestTwoMatch = MatchesAny(course.InterestsOptionsTwo, userProfile.InterestsAnswersTwo);
                bool passionOneMatch = MatchesAny(course.PassionsOptionsOne, userProfile.PassionsAnswersOne);
                bool skillstrengthOneMatch = MatchesAny(course.SkillsAndStrengthsOptionsOne, userProfile.SkillsAndStrengthsAnswersOne);
                bool skillstrengthTwoMatch = MatchesAny(course.SkillsAndStrengthsOptionsTwo, userProfile.SkillsAndStrengthsAnswersTwo);
                bool skillstrengthThreeMatch = MatchesAny(course.SkillsAndStrengthsOptionsThree, userProfile.SkillsAndStrengthsAnswersThree);

                if (interestOneMatch) count++;
                if (interestTwoMatch) count++;
                if (passionOneMatch) count++;
                if (skillstrengthOneMatch) count++;  
                if (skillstrengthTwoMatch) count++;
                if (skillstrengthThreeMatch) count++;
                
                if(count >= 3)
                {
                    course.MatchPercentage = (count / 6) * 100;
                    recommendedCourses.Add(course);
                }
                    
            }
            return recommendedCourses;
        }


        private static bool MatchesAny(int[] options, List<int> answers)
        {
            return answers.Any(answer => Array.Exists(options, option => option.Equals(answer)));
        }

        public static void DisplayRecommendations(List<Course> recommendedCourses)
        {
            if (recommendedCourses.Count == 0)
            {
                Console.WriteLine("No courses match both your skills and passions.");
            }
            else
            {
                bool swappedIndicator;
                do
                {
                    swappedIndicator = false;
                    for (int i = 0; i < recommendedCourses.Count - 1; i++)
                    {
                        if (recommendedCourses[i].MatchPercentage < recommendedCourses[i + 1].MatchPercentage)
                        {
                            Course temp = recommendedCourses[i];
                            recommendedCourses[i] = recommendedCourses[i + 1];
                            recommendedCourses[i + 1] = temp;
                            swappedIndicator = true;
                        }
                    }
                } while (swappedIndicator);

                Console.WriteLine("Recommended Fields / Academic Disciplines:");
                foreach (var course in recommendedCourses)
                {
                    Console.WriteLine($"    - {course.Name} ({course.MatchPercentage:F0}% Match)");   
                }
                Console.WriteLine("\nPress any key to view further information on each field/academic discipline...");
                Console.ReadKey();

                AdditionalInfo(recommendedCourses);
            }
        }

        public static void AdditionalInfo(List<Course> recommendedCourses)
        {
            Console.Clear();
            List<string> menu = new List<string>();
            foreach (var course in recommendedCourses)
            {
                menu.Add(course.Name);
            }
            menu.Add("Back");

            bool running = true;
            int selectedOption = 0;
            while (running)
            {
                Console.Clear();
                CenterTexts.TextCenterer("Use Up/Down arrows to navigate and Enter to select.\n");

                for (int i = 0; i < menu.Count; i++)
                {
                    string text = "==> " + menu[i];

                    if (i == selectedOption)
                    {
                        CenterTexts.TextCenterer(text);
                    }
                    else
                    {
                        CenterTexts.TextCenterer(menu[i]);
                    }
                }

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    selectedOption = (selectedOption == 0) ? menu.Count - 1 : selectedOption - 1;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    selectedOption = (selectedOption == menu.Count - 1) ? 0 : selectedOption + 1;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if(selectedOption != menu.Count - 1)
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n");
                        CenterTexts.TextCenterer(recommendedCourses[selectedOption].Name);
                        Console.WriteLine("\nSummary:");

                        // Wrap and justify the course details with an indent of 4 spaces
                        int consoleWidth = Console.WindowWidth - 4; // Subtracting for padding
                        int indent = 4; // Define the indent here
                        CenterTexts.PrintJustifiedText(recommendedCourses[selectedOption].CourseDetails, consoleWidth, indent);

                        Console.WriteLine("\nPossible Carrer Paths:");
                        CenterTexts.PrintJustifiedText(recommendedCourses[selectedOption].CareerPaths, consoleWidth, indent);

                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                    }
                    else
                    {
                        running = false; // Exit the loop and end the program
                    }
                }
            }
        }
    }
}
