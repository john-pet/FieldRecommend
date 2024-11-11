using Newtonsoft.Json; // Ensure to include Newtonsoft.Json for JSON deserialization

namespace FieldCompass_AcademicFieldRecommendationSystem
{
    internal class CourseDatabase
    {
        // Path to the JSON file containing course details 
        private const string FilePath = "C:\\Users\\Dell\\source\\repos\\FieldRecommend\\Project Proposal Modified\\FieldCompass_AcademicFieldRecommendationSystem\\CourseDatabase.json";

        // This method returns a list of Course objects read from a JSON file
        internal List<Course> InitializeCourseDatabase()
        {
            try
            {
                // Read the file content
                string jsonContent = File.ReadAllText(FilePath);

                // Deserialize JSON content to a list of Course objects
                List<Course> coursesDetails = JsonConvert.DeserializeObject<List<Course>>(jsonContent);

                if (coursesDetails == null)
                {
                    return new List<Course>();
                }
                else
                {
                    return coursesDetails;
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"The file '{FilePath}' was not found.");
                Console.ReadLine();
                return new List<Course>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the course database: {ex.Message}");
                Console.ReadLine();
                return new List<Course>();
            }
        }
    }
}