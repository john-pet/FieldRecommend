namespace FieldCompass_AcademicFieldRecommendationSystem
{
    internal class Select
    {
        internal static List<int> GetSelectedOptions(List<string> options)
        {
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

            Console.WriteLine("\nChoices: ");
            foreach (int num in selectedOptions)
            {
                Console.WriteLine(num + " - " + options[num - 1]);
            }
            return selectedOptions;
        }
    }
}
