namespace FieldCompass_AcademicFieldRecommendationSystem
{
    internal class WelcomeMessage
    {
        internal WelcomeMessage()
        {
            Console.WriteLine("\n\n\n");

            //calculates for padding in order to center the title
            string text = "Welcome to Field Compass: Your Guide to Finding the Perfect Academic Path!!!";
            CenterTexts.TextCenterer(text);

            Console.WriteLine();
            text = "Welcome to Field Compass, a personalized recommendation system designed to help you navigate the vast landscape of academic disciplines and fields of ";
            CenterTexts.TextCenterer(text);
            text = "study. Whether you’re a student exploring potential majors or a lifelong learner curious about new areas of knowledge, Field Compass is here to guide you.";
            CenterTexts.TextCenterer(text);

            Console.WriteLine();
            text = "With Field Compass, you’ll gain insights into fields that align with your interests, strengths, and goals.";
            CenterTexts.TextCenterer(text);
            text = "By answering a few simple questions, you’ll unlock tailored recommendations, discover emerging fields, and explore traditional and innovative career";
            CenterTexts.TextCenterer(text);
            text = "paths suited to your unique profile. Set your course with confidence and let Field Compass lead you to a field that truly fits your aspirations.";
            CenterTexts.TextCenterer(text);

            Console.WriteLine();
            text = "Let Field Compass be your starting point on the journey to a rewarding and fulfilling future!";
            CenterTexts.TextCenterer(text);

            Console.WriteLine("\n\n\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
