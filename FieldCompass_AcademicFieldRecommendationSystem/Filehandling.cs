namespace FieldCompass_AcademicFieldRecommendationSystem
{
    public class FileHandling
    {
        // Set the base directory to the project root, and specify the "Answers" folder
        static readonly string baseDirectory = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\Answers"));
        static readonly List<string> fileNames = new List<string>
        {
            "InterestsAnswersOne.txt",
            "InterestsAnswersTwo.txt",
            "PassionsAnswersOne.txt",
            "SkillsStrengthsAnswersOne.txt",
            "SkillsStrengthsAnswersTwo.txt",
            "SkillsStrengthsAnswersThree.txt",
        };

        internal static void CreateFile(string category, List<int> selectedOptions, List<string> options)
        {
            string filePath = Path.Combine(baseDirectory, $"{category}.txt");

            // Ensure the "Answers" folder exists
            Directory.CreateDirectory(baseDirectory);

            Console.WriteLine("\nChoices: ");
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (int num in selectedOptions)
                    {
                        string optionText = $"{num} - {options[num - 1]}";
                        Console.WriteLine(optionText);
                        writer.WriteLine(optionText);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to create the file: " + ex.Message);
            }
        }

        internal static void ReadFile()
        {
            foreach (string fileName in fileNames)
            {
                Console.WriteLine(fileName);
                string filePath = Path.Combine(baseDirectory, fileName);
                try
                {
                    using (StreamReader reader = File.OpenText(filePath))
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
                    Console.WriteLine($"Failed to read the file {fileName}: {ex.Message}");
                }
                Console.WriteLine();
            }
        }

        internal static void UpdateFile(string category, List<int> selectedOptions, List<string> options)
        {
            string filePath = Path.Combine(baseDirectory, $"{category}.txt");

            // Ensure the "Answers" folder exists
            Directory.CreateDirectory(baseDirectory);

            Console.WriteLine("\nChoices: ");
            try
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    foreach (int num in selectedOptions)
                    {
                        string optionText = $"{num} - {options[num - 1]}";
                        Console.WriteLine(optionText);
                        writer.WriteLine(optionText);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to update the file: " + ex.Message);
            }
        }

        internal static void DeleteFile()
        {
            foreach (string fileName in fileNames)
            {
                string filePath = Path.Combine(baseDirectory, fileName);
                try
                {
                    File.Delete(filePath);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine($"File not found: {fileName}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred while deleting the file {fileName}: {ex.Message}");
                }
            }
        }
    }
}
