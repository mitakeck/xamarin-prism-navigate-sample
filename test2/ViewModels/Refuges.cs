using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace test2.ViewModels
{
	//[System.Xml.Serialization.XmlRoot("dataroot")]
	public class Refuges : BindableBase
	{
		[System.Xml.Serialization.XmlElement("refuge")]
		public List<test2.ViewModels.Refuge> Refuge { get; set; }
	}
}
