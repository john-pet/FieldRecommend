namespace FieldCompass_AcademicFieldRecommendationSystem
{
    public abstract class Question
    {
        public List<int> AskQuestions(int count)
        {
            List<int> answers = new List<int>();
            bool confirmChoices;
            do
            {
                answers.Clear();
                answers.AddRange(SpecificQuestions(count));
                confirmChoices = ConfirmSelections();
                
            } while (!confirmChoices);
            return answers;
        }
        
        public static bool ConfirmSelections()
        {
            Console.WriteLine("\nConfirm Choices? [Yes/No]");
            string confirmation = Console.ReadLine();

            if (confirmation.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                return true;
            else if (confirmation.Equals("No", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Input. Please only answer Yes or No");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                return false;
            }
                

        }
        public abstract List<int> SpecificQuestions(int count);

        public static void DisplayOptions(List<string> options)
        {
            Console.WriteLine("Choose from the list of options (choose multiple by entering numbers, e.g., 1,3,5):");
            Console.WriteLine();
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {options[i]}");
            }
            Console.WriteLine();
        }

        internal static List<int> SelectedOptions(string category, List<string> options)
        {
            char confirmation;
            string input = Console.ReadLine(); //this is where your input like 1,2,3 gets stored as a string
            List<int> selectedOptions = new List<int>();

            /*
                With input.Split(',') i will split the the previous inputted string like 1,2,3 to an array of substrings containing like ["1", " 2", " 3"]
                Then it will loop to each substring and store each of them to the variable number
            */
            foreach (var number in input.Split(','))
            {
                //this will convert each of the substring into an integer
                //I've really haven't considered wrong inputs because it gets too complicated for me and I already have trouble with all the connections of each fields and methods
                /*
                    The only thing i can do is situations where there are spaces in the input for ex. 1 ,2 , 3
                    through number.Trim(), it will remove spaces or other whitespace characters
                */
                if (int.TryParse(number.Trim(), out int index) && index >= 1 && index <= options.Count)
                {
                    selectedOptions.Add(index);
                }
            }

            string filePath = $"C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\{category}.json";

            Console.WriteLine("\nChoices: ");
            try
            {
                /* I like the using statement because it ensures that the files are closed and the resources properly disposed, 
                   after the execution is done
                */
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (int num in selectedOptions)
                    {
                        string optionText = $"{num} - {options[num - 1]}";
                        Console.WriteLine(optionText);

                        // Write each option to the file
                        writer.WriteLine(optionText);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to create the file" + ex);
            }
            
            
            return selectedOptions;
        }
    }
}
