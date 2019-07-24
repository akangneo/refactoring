using System;
using System.Collections.Generic;

namespace ExtractMethod
{
    class TextUtils
    {
        string[] FindEqualWords(string firstText, string secondText)
        {
            List<string> firstWordsList = new List<string>();
            int textLength = firstText.Length;
            int idx = 0;
            string activeWord = string.Empty;
            while (idx < textLength)
            {
                char ch = firstText[idx];
                if (Char.IsLetter(ch))
                    activeWord += ch;
                else if (!string.IsNullOrEmpty(activeWord))
                {
                    firstWordsList.Add(activeWord);
                    activeWord = string.Empty;
                }
            }
            List<string> secondWordsList = new List<string>();
            idx = 0;
            activeWord = string.Empty;
            textLength = secondText.Length;
            while (idx < textLength)
            {
                char ch = secondText[idx];
                if (Char.IsLetter(ch))
                    activeWord += ch;
                else if (!string.IsNullOrEmpty(activeWord))
                {
                    secondWordsList.Add(activeWord);
                    activeWord = string.Empty;
                }
            }
            List<string> result = new List<string>();
            foreach (string word in firstWordsList)
                if (secondWordsList.Contains(word))
                    result.Add(word);
            return result.ToArray();
        }
    }
}
