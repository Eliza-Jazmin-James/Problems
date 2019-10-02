using System.Collections;

namespace SplitAndSort
{
	public static class ExecutionClass
	{
		public static void WithoutRegex(string text, string stringPattern, ArrayList finalList)
		{
			int textlength = text.Length;
			int patternLength = stringPattern.Length;
			if (patternLength > textlength)
			{
				return;
			}
			string emailId = string.Empty;
			string firstname = string.Empty;
			char[] characterArray = text.ToCharArray();
			for (int i = 0; i < text.Length; i++)
			{
				if (characterArray[i] >= 'a' && characterArray[i] <= 'z')
				{
					continue;
				}
				else if (characterArray[i] == ' ')
				{
					int spaceIndex = i;
					emailId = text.Substring(spaceIndex + 1);
					firstname = text.Substring(0, spaceIndex);
					if (firstname.Length > 20)
					{
						return;
					}
					if (emailId.Length > 50)
					{
						return;
					}
				}
				else if (characterArray[i] == '@')
				{
					if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(emailId))
					{
						return;
					}
					string subString = text.Substring(i);
					if (subString == stringPattern)
					{

						finalList.Add(firstname);
						return;

					}
					else
					{
						return;
					}
				}
				else
				{
					return;
				}
			}
		}
	}
}
