using System;
namespace RandomString
{
	public class Core
	{
			private string s;
			private int a;

			//Random input string
			public string S {
				get{
					return s;
				}
				set{
					s = value;
				}
			}

			//Length of characters for output
			public int A
			{
				get
				{
					return ConfigurationManager.AppSettings["A"]; //Replace this by reading from app.config
				}
				set
				{
					a = value;
				}
			}

			public string GenerateRandomString()
			{
				char[] arr = S.ToCharArray();
				string OutputString = string.Empty;

				for (int i = 0; i < A; i++)
				{
					if (i == 0)
						OutputString = arr[i].ToString();

					char LastLetterInOutput = OutputString.ToCharArray().Last();

					for (int j = 0; j < arr.Length - 1; j++)
					{
						if (arr[j] == LastLetterInOutput)
							continue;
						else if (arr[j] != LastLetterInOutput)
						{
							OutputString = OutputString + arr[i].ToString();
							break;
						}
					}
					
				}

				return OutputString;

			}
	}
}


