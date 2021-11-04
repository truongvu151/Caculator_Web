using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace BTH1_WEB.Models
{
    public class Expression
    {
        [Required(ErrorMessage ="Input number!")]
        [Display(Name ="Số thứ 1")]
        public double Number1 { get; set; }
        [Required(ErrorMessage = "Input number!")]
        [Display(Name = "Số thứ 2")]
        public double Number2 { get; set; }
        public double Result
        {
            get; set;
        }
        public string Operator { get; set; }
        public string Error { get; set; } // thông báo lỗi
        public Expression()
        {
            Error = "";
        }
    }
}