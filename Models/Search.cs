using MessagePack;

namespace uwierzytelnianieClaimsIdentity.Models
{
	public class Search
	{
		public int id { get; set; }
		public string? name { get; set; }
		public int year { get; set; }
		public DateTime date { get; set; }
		public int? userNumber { get; set; }

		public Search() { }
		public Search(string Name, int Year)
		{
			name = Name;
			year = Year;
			date = DateTime.Now;
		}

		public string sentence()
        {
			if ( (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0 )) 
			{
				return name + " urodzil sie w roku " + year + ". Był to rok przestepny.";
			}
			else
			{
				return name + " urodzil sie w roku " + year + ". Był to rok nieprzestepny.";
			}
		}

	}
}
