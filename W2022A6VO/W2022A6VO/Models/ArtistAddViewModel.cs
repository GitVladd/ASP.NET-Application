using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace W2022A6VO.Models
{
	public class ArtistAddViewModel
	{
		[Key]
		public int Id { get; set; }

		[Required, Display(Name = "Artist name or stage name")]
		public string Name { get; set; }

		[Display(Name = "If applicable, artist`s birth name")]
		public string BirthName { get; set; }

		[Display(Name = "Birth date, or start date")]
		[DataType(DataType.Date)]
		public DateTime BirthOrStartDate { get; set; }


		[Required, Display(Name = "Artist photo")]
		public string UrlArtist { get; set; }

		[Required, Display(Name = "Artist`s primary genre")]
		public string Genre { get; set; }

		[Required, StringLength(200)]
		public string Executive { get; set; }

		[StringLength(2000)]
		[DataType(DataType.MultilineText)]
		public string Portrayal { get; set; }
	}
}