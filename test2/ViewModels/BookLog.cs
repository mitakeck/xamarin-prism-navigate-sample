using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace test2.ViewModels
{
	public class BookLog
	{
		[JsonProperty("books")]
		public List<Book> Books { get; set; }

		[JsonProperty("category_id")]
		public string CategoryID { get; set; }

		[JsonProperty("keyword")]
		public Boolean Keyword { get; set; }

		[JsonProperty("rank")]
		public string Rank { get; set; }

		[JsonProperty("sort")]
		public string Sort { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }
	}
}
