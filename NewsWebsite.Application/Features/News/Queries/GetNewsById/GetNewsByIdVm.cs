
using System.ComponentModel.DataAnnotations;

namespace NewsWebsite.Application.Features.News.Queries
{
    public class GetNewsByIdVm
    {

        public int NewsId { get; set; }


        [Display(Name = "عنوان")]
        [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد. ")]
        [Required(ErrorMessageResourceType =)]
        public string Title { get; set; }


        [Display(Name = "توضیحات اصلی")]
        [Required(ErrorMessage = " لطفا {0} را وارد کنید")]
        public string Description { get; set; }


        [Display(Name = "توضیح کوتاه")]
        [MaxLength(500, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد. ")]
        [Required(ErrorMessage = " لطفا {0} را وارد کنید")]
        public string ShortDescription { get; set; }


        [Display(Name = "فعال / غیرفعال")]
        public bool IsActive { get; set; }



        [Display(Name = "نام تصویر")]
        [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد. ")]
        [Required(ErrorMessage = " لطفا {0} را وارد کنید")]
        public string ImageName { get; set; }

    }
}
