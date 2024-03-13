using System;
using System.Text;
using Microsoft.Extensions.Primitives;

namespace DoNotWasteYourTime.Helpers;

public class TextHelper
{
    [Obsolete]
    public static string WrapText(string text ,int wrapIndex)
    {
        if (string.IsNullOrEmpty(text))
            throw new Exception("text is Null or Empty");
			
        if (text.Length <= wrapIndex || wrapIndex == 0)
            return text;
			
        StringBuilder textBuilder = new();
        int length = default;

        for (int index = 0; index <= text.Length; index+=length)
        {
            length = (index + wrapIndex) > text.Length ? text.Length - index : wrapIndex;
				
            while (index + length < text.Length && !char.IsWhiteSpace(text[index + length - 1]))
            {
                length++;
            }

            StringSegment stringSegment = new(text, index, length);

            textBuilder.Append($"{stringSegment}\n");

            if((index+length) > text.Length)
                length= text.Length - length;
        }

        return textBuilder.ToString();
    }
    
}