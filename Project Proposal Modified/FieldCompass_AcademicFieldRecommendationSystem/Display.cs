namespace FieldCompass_AcademicFieldRecommendationSystem
{
    public static class Display
    {
        public static void DisplayOptions(string category, List<string> options)
        {
            Console.WriteLine("Choose from the list of options (choose multiple by entering numbers, e.g., 1,3,5):");
            Console.WriteLine();
            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {options[i]}");
            }
            Console.WriteLine();
        }
    }

}
