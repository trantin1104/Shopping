using System.ComponentModel.DataAnnotations;

namespace Shopping.Models.ViewModels
{
	public class LoginViewModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Xin hãy nhập UserName")]
		public string Username { get; set; }

		[DataType(DataType.Password), Required(ErrorMessage = "Xin hãy nhập Password")]
		public string Password { get; set; }
		public string ReturnUrl { get; set; }

	}
}
