string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string myString in myStrings)
{
    int periodLocation = myString.IndexOf(".");
    int sentenceStart = 0;

    do
    {
        int sentenceEnd = myString.IndexOf(".", sentenceStart);
        if (sentenceEnd == -1)
        {
            sentenceEnd = myString.Length;
        }

        string sentence = myString.Substring(sentenceStart, sentenceEnd - sentenceStart).TrimStart();
        Console.WriteLine(sentence);

        sentenceStart = sentenceEnd + 1;
    } while (sentenceStart < myString.Length);
}
