using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Shopping.Repository;
using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class CategoryModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Yêu cầu nhập tên danh mục")] 
        public string Name { get; set; }
		[Required(ErrorMessage = "Yêu cầu nhập mô tả danh mục")]
		public String Description { get; set; }


        public string Slug { get; set; }

        public int Status { get; set; }
    }

    
}
