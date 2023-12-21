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
					return a;
					//I am unable to add System.Configuration in my Macbook for some reason. We can replace this step by following to read from app.config
					//return Configuration.AppSetting["A"];
					//Have placed the app.config in solution.
				}
				set
				{
					a = value;
				}
			}

			public string GenerateRandomString()
			{
				char[] arrInputString = S.ToCharArray();
				string OutputString = string.Empty;

				for (int i = 0; i < A; i++)
				{
					if (i == 0)
						OutputString = arrInputString[i].ToString();

					char LastLetterInOutput = OutputString.ToCharArray().Last();

					for (int j = 0; j < arrInputString.Length - 1; j++)
					{
						if (arrInputString[j] == LastLetterInOutput)
							continue;
						else if (arrInputString[j] != LastLetterInOutput)
						{
							if(i==0)
								OutputString = arrInputString[j].ToString();
							else
								OutputString = OutputString + arrInputString[j].ToString();

                        break;
						}
					}
					
				}

				return OutputString;

			}
	}
}


