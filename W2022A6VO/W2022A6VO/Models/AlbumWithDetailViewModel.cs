using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace W2022A6VO.Models
{
	public class AlbumWithDetailViewModel : AlbumBaseViewModel
	{
		[Required, StringLength(200)]
		public string Coordinator { get; set; }

		[StringLength(2000)]
		[DataType(DataType.MultilineText)]
		public string Background { get; set; }

		public ICollection<ArtistBaseViewModel> Artists { get; set; }
	}
}