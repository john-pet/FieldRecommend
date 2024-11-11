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
            string[] mainMenu = { "Interests", "Passion", "Skills and Strengths", "Exit" };
            int[] visited = { 0, 0, 0 }; //an array that tracks if the questios are answered

            while (running)
            {
                Console.Clear();
                int displayRecommend = 0;
                
                //this tests if all questions are answered
                for(int i=0; i<visited.Length; i++)
                {
                    if (visited[i] == 0)
                    {
                        displayRecommend = 0;
                        break; //break immediately because it means that at least one question is not answered
                    }
                    else
                    {
                        displayRecommend = 1;
                    }
                }

                if (displayRecommend == 1)
                {
                    Array.Resize(ref mainMenu, 6); // found this method on Microsoft Learn

                    mainMenu[3] = "Display Answers";
                    mainMenu[4] = "Recommend Courses";
                    mainMenu[5] = "Exit";
                }
                
                CenterTexts.TextCenterer("Use Up/Down arrows to navigate and Enter to select.\n");

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
                            mainMenu[selectedOption] = "Interests (Edit Answers)";
                            visited[selectedOption] = 1;
                            Interests interests = new Interests();
                            userProfile.InterestsAnswersOne = interests.AskQuestions(1);
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            userProfile.InterestsAnswersTwo = interests.AskQuestions(2);
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 1:
                            // Handling Passions
                            mainMenu[selectedOption] = "Passions (Edit Answers)";
                            visited[selectedOption] = 1;
                            Passions passions = new Passions();
                            userProfile.PassionsAnswersOne = passions.AskQuestions(1);
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            // Handling Skills and Strengths
                            mainMenu[selectedOption] = "Skills and Strengths (Edit Answers)";
                            visited[selectedOption] = 1;
                            SkillsStrengths skillsStrengths = new SkillsStrengths();
                            userProfile.SkillsAndStrengthsAnswersOne = skillsStrengths.AskQuestions(1);
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            userProfile.SkillsAndStrengthsAnswersTwo = skillsStrengths.AskQuestions(2);
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            userProfile.SkillsAndStrengthsAnswersThree = skillsStrengths.AskQuestions(3);
                            Console.WriteLine("\nPress any key to continue...");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3:
                            if (displayRecommend == 0)
                            {
                                running = false; // Exit the loop and end the program
                                try
                                {
                                    File.Delete($"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\InterestsAnswersOne.json");
                                    File.Delete($"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\InterestsAnswersTwo.json");
                                    File.Delete($"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\PassionsAnswersOne.json");
                                    File.Delete($"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\SkillsStrengthsAnswersOne.json");
                                    File.Delete($"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\SkillsStrengthsAnswersTwo.json");
                                    File.Delete($"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\SkillsStrengthsAnswersThree.json");
                                }
                                catch (FileNotFoundException ex)
                                {
                                    Console.WriteLine(ex + "Files not Found");
                                    Console.ReadLine();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"An error occurred while deleting the files: {ex.Message}");
                                    Console.ReadLine();
                                }

                                break;
                            }
                            else
                            {
                                string[] filePath =
                            {
                                $"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\InterestsAnswersOne.json",
                                $"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\InterestsAnswersTwo.json",
                                $"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\PassionsAnswersOne.json",
                                $"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\SkillsStrengthsAnswersOne.json",
                                $"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\SkillsStrengthsAnswersTwo.json",
                                $"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\SkillsStrengthsAnswersThree.json",
                            };

                                foreach (string fileLink in filePath)
                                {
                                    try
                                    {
                                        using (StreamReader reader = File.OpenText(fileLink))
                                        {
                                            string line;
                                            while ((line = reader.ReadLine()) != null)
                                            {
                                                Console.WriteLine(line);
                                            }
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Failed to read the file.");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine("\nPress any key to continue...");
                                Console.ReadKey();
                                break;
                            }
                        case 4:
                            // Instantiating an object of class CourseDatabase
                            CourseDatabase courseDatabase = new CourseDatabase();
                            // This will retrieve the information from the database that we made about the courses and their related information
                            List<Course> courses = courseDatabase.InitializeCourseDatabase();

                            // RecommendCourse() is a static method which can be called directly without creating an instance of the class CourseRecommender
                            // This will pass the userProfile (including skills and passions) and courses to the recommender
                            List<Course> recommendedCourses = CourseRecommender.RecommendCourses(userProfile, courses);

                            // Display recommendations
                            CourseRecommender.DisplayRecommendations(recommendedCourses);
                            break;
                        case 5:
                            running = false; // Exit the loop and end the program
                            try
                            {
                                File.Delete($"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\InterestsAnswersOne.json");
                                File.Delete($"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\InterestsAnswersTwo.json");
                                File.Delete($"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\PassionsAnswersOne.json");
                                File.Delete($"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\SkillsStrengthsAnswersOne.json");
                                File.Delete($"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\SkillsStrengthsAnswersTwo.json");
                                File.Delete($"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\SkillsStrengthsAnswersThree.json");
                            }
                            catch (FileNotFoundException ex)
                            {
                                Console.WriteLine(ex + "Files not Found");
                                Console.ReadLine();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"An error occurred while deleting the files: {ex.Message}");
                                Console.ReadLine();
                            }
                        
                            break;
                    }
                }
            }
        }
    }
}
