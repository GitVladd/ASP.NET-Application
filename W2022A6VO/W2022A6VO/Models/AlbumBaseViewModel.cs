using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace W2022A6VO.Models
{
	public class AlbumBaseViewModel
	{
		public AlbumBaseViewModel()
		{
			ReleaseDate = DateTime.Now.Date.AddYears(-100);
		}
		[Key]
		public int Id { get; set; }

		[Required, Display(Name = "Album name")]
		public string Name { get; set; }

		[Display(Name = "Release date")]
		[DataType(DataType.Date)]
		public DateTime ReleaseDate { get; set; }

		[Required, Display(Name = "Album cover art")]
		public string UrlAlbum { get; set; }

		[Required, Display(Name = "Album`s primary genre")]
		public string Genre { get; set; }
	}
}