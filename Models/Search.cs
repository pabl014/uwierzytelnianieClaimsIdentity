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

		public Search(string Name, int Year)
		{
			name = Name;
			year = Year;
			date = DateTime.Now;
		}


	}
}
