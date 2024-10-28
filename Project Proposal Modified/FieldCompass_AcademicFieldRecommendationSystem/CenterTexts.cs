namespace FieldCompass_AcademicFieldRecommendationSystem
{
    internal class CenterTexts
    {
        //this is a class that helps center texts or paragraphs
        internal static void TextCenterer(string text)
        {
            int consoleWidth = Console.WindowWidth;
            int textWidth = text.Length;

            int numberOfSpaces = (consoleWidth - textWidth) / 2;

            Console.WriteLine(new string(' ', numberOfSpaces) + text);
        }
    }
}
