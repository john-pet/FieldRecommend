using System.Text;

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

        internal static void PrintJustifiedText(string text, int width, int indent)
        {
            // Split the text into words
            var words = text.Split(' ');
            var currentLine = new List<string>();
            int currentLineLength = 0;

            foreach (var word in words)
            {
                // Check if adding the next word would exceed the line width
                if (currentLineLength + word.Length + currentLine.Count > width - indent)
                {
                    // If it's the last line, we print it left aligned
                    if (currentLine.Count == 1)
                    {
                        Console.WriteLine($"{new string(' ', indent)}{currentLine[0]}");
                    }
                    else
                    {
                        // Calculate total spaces needed for justification
                        int totalSpaces = width - indent - currentLineLength;
                        int spaceBetweenWords = totalSpaces / (currentLine.Count - 1);
                        int extraSpaces = totalSpaces % (currentLine.Count - 1);

                        // Create justified line
                        var justifiedLine = new StringBuilder($"{new string(' ', indent)}");

                        for (int i = 0; i < currentLine.Count; i++)
                        {
                            justifiedLine.Append(currentLine[i]);

                            // Append spaces
                            if (i < currentLine.Count - 1)
                            {
                                justifiedLine.Append(new string(' ', spaceBetweenWords + (i < extraSpaces ? 1 : 0)));
                            }
                        }

                        Console.WriteLine(justifiedLine.ToString());
                    }

                    // Clear the current line for the next line
                    currentLine.Clear();
                    currentLineLength = 0;
                }

                // Add the word to the current line
                currentLine.Add(word);
                currentLineLength += word.Length;
            }

            // Print the last line if it exists
            if (currentLine.Count > 0)
            {
                Console.WriteLine($"{new string(' ', indent)}{string.Join(" ", currentLine)}");
            }
        }


    }
}
