using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace test2.ViewModels
{
	public class Book
	{
		[JsonProperty("book_id")]
		public string BookID { get; set; }

		[JsonProperty("category_id")]
		public string CategoryID { get; set; }

		[JsonProperty("category_name")]
		public Boolean CategoryName { get; set; }

		[JsonProperty("create_on")]
		public string CreateOn { get; set; }

		[JsonProperty("height")]
		public int Height { get; set; }

		[JsonProperty("width")]
		public int Width { get; set; }

		[JsonProperty("id")]
		public string ID { get; set; }

		[JsonProperty("image")]
		public string Image { get; set; }

		[JsonProperty("image_2x")]
		public string Image2x { get; set; }

		[JsonProperty("public")]
		public int Public { get; set; }

		[JsonProperty("rank")]
		public int Rank { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }
	}
}
