using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
	public class UserModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage= "Xin hãy nhập UserName")]
		public string Username { get; set; }
		[Required(ErrorMessage = "Xin hãy nhập Email"), EmailAddress]
		public string Email { get; set; }
		[DataType(DataType.Password), Required(ErrorMessage = "Xin hãy nhập Password")]
		public string Password { get; set; }

	}
}
