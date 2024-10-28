namespace FieldCompass_AcademicFieldRecommendationSystem
{
    internal class CourseDatabase
    {
        //this will return a type List<Course>
        internal List<Course> InitializeCourseDatabase()
        {
            //this will make a list of Course objects
            //See the constructor for class Course for related information
            List<Course> CoursesDetails = new List<Course>
            {
                new Course("Engineering and Technology",
                    new[] { 1, 2, 3, 4 },
                    new[] { 1, 2, 3, 27 },
                    new[] { 1, 2, 3, 4 },
                    new[] { 1, 2, 3, 11, 12 },
                    new[] { 1, 2, 3 },
                    new[] { 1, 2, 3 }),

                new Course("Health and Medical Sciences",
                    new[] { 4, 5, 6, 7 },
                    new[] { 4, 5, 6 },
                    new[] { 5, 6, 7, 12, 19 },
                    new[] { 1, 2, 4, 12 },
                    new[] { 1, 5, 6},
                    new[] { 2, 5, 6}),

                new Course("Natural and Physical Sciences",
                    new[] { 2, 4, 5, 8, 17 },
                    new[] { 7, 8, 9 },
                    new[] { 7, 8, 9 },
                    new[] { 2, 5, 11, 12 },
                    new[] { 1, 2, 5 },
                    new[] { 1, 2, 6 }),

                new Course("Business and Management",
                    new[] { 1, 9, 10, 11 },
                    new[] { 10, 11, 12, 13 },
                    new[] { 10, 11, 19 },
                    new[] { 1, 4, 6 },
                    new[] { 4, 6 },
                    new[] { 1, 4, 7 }),

                new Course("Social Sciences",
                    new[] { 6, 9, 12, 13 },
                    new[] { 4, 12, 14, 15 },
                    new[] { 5, 15, 19 },
                    new[] { 1, 4, 7 },
                    new[] { 4, 6 },
                    new[] { 1, 6, 7 }),

                new Course("Arts and Humanities",
                    new[] { 13, 14, 15, 16 },
                    new[] { 16, 17, 18, 19 },
                    new[] { 14, 15, 16 },
                    new[] { 3, 4, 8 },
                    new[] { 2, 3 },
                    new[] { 7, 8 }),

                new Course("Education",
                    new[] { 1, 6, 14, 17 },
                    new[] { 4, 14, 20 },
                    new[] { 5, 12, 19 },
                    new[] { 4, 6, 7 },
                    new[] { 1, 4, 6 },
                    new[] { 1, 9 }),

                new Course("Law and Legal Studies",
                    new[] { 13, 15, 18, 19 },
                    new[] { 4, 21, 22 },
                    new[] { 5, 12, 13 },
                    new[] { 1, 4, 9 },
                    new[] { 1, 4, 6 },
                    new[] { 1, 4 }),

                new Course("Communication and Media",
                    new[] { 6, 12, 14, 16 },
                    new[] { 19, 23, 24 },
                    new[] { 8, 13, 15, 16 },
                    new[] { 3, 4, 10 },
                    new[] { 3, 4, 6 },
                    new[] { 7, 8 }),

                new Course("Agriculture and Environmental Studies",
                    new[] { 4, 5, 8, 20 },
                    new[] { 4, 7, 25 },
                    new[] { 8, 13, 15 },
                    new[] { 1, 2, 5 },
                    new[] { 1, 2, 3 },
                    new[] { 2, 3, 6 }),

                new Course("Architecture and Design",
                    new[] { 1, 2, 13, 16 },
                    new[] { 1, 16 },
                    new[] { 1, 4, 14, 19 },
                    new[] { 1, 2, 3, 12 },
                    new[] { 1, 2, 3 },
                    new[] { 1, 6, 8 }),

                new Course("Mathematics and Statistics",
                    new[] { 1, 3, 21, 22 },
                    new[] { 27, 28 },
                    new[] { 7, 18, 19 },
                    new[] { 1, 11, 12 },
                    new[] { 1, 3, 5 },
                    new[] { 1, 7, 10 }),

                new Course("Aviation and Maritime",
                    new[] { 1, 2, 23 },
                    new[] { 1, 3, 7 },
                    new[] { 3, 8, 20 },
                    new[] { 1, 2, 10 },
                    new[] { 1, 2, 4 },
                    new[] { 3, 4, 6 }),
            };
            return CoursesDetails;
        }
    }
}
