using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace W2022A6VO.Models
{
	public class ArtistWithDetailViewModel : ArtistBaseViewModel
	{

		[Required, StringLength(200)]
		public string Executive { get; set; }

		[StringLength(2000)]
		[DataType(DataType.MultilineText)]
		public string Portrayal { get; set; }
	}
}