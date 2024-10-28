namespace FieldCompass_AcademicFieldRecommendationSystem
{
    internal class CourseRecommender
    {
        internal static List<Course> RecommendCourses(UserProfile userProfile, List<Course> courses)
        {
            List<Course> recommendedCourses = new List<Course>();

            foreach (var course in courses)
            {
                bool interestOneMatch = MatchesAny(course.InterestsOptionsOne, userProfile.InterestsAnswersOne);
                bool interestTwoMatch = MatchesAny(course.InterestsOptionsTwo, userProfile.InterestsAnswersTwo);
                bool passionOneMatch = MatchesAny(course.PassionsOptionsOne, userProfile.PassionsAnswersOne);
                bool skillstrngthOneMatch = MatchesAny(course.SkillsAndStrengthsOptionsOne, userProfile.SkillsAndStrengthsAnswersOne);
                bool skillstrngthTwoMatch = MatchesAny(course.SkillsAndStrengthsOptionsTwo, userProfile.SkillsAndStrengthsAnswersTwo);
                bool skillstrngthThreeMatch = MatchesAny(course.SkillsAndStrengthsOptionsThree, userProfile.SkillsAndStrengthsAnswersThree);

                if (interestOneMatch && interestTwoMatch && passionOneMatch && skillstrngthOneMatch && skillstrngthTwoMatch && skillstrngthThreeMatch)
                {
                    recommendedCourses.Add(course);
                }
            }

            if (recommendedCourses.Count == 0)
            {
                Console.WriteLine("No courses in the database match the user's preferences.");
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
                Console.WriteLine("Recommended Courses:");
                foreach (var course in recommendedCourses)
                {
                    Console.WriteLine($"- {course.Name}");
                    Console.WriteLine("  Potential Careers: " + string.Join(", ") + "\n");
                }
            }
        }
    }
}
