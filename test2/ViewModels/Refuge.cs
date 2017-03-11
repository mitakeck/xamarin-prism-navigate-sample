using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace test2.ViewModels
{
	//[System.Xml.Serialization.XmlRoot("refuge")]
	public class Refuge
	{
		[System.Xml.Serialization.XmlElement("no")]
		public string No { get; set; }

		[System.Xml.Serialization.XmlElement("areano")]
		public string Areano { get; set; }

		[System.Xml.Serialization.XmlElement("area")]
		public string Area { get; set; }

		[System.Xml.Serialization.XmlElement("name")]
		public string Name { get; set; }

		[System.Xml.Serialization.XmlElement("address")]
		public string Address { get; set; }
	}
}
