namespace App.Model.comm
{
  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.CodeDom.Compiler;
  using Eco.ObjectImplementation;
  using Eco.ObjectRepresentation;
  using Eco.Services;
  using Eco.Subscription;
  using Eco.UmlCodeAttributes;
  using Eco.UmlRt;
    using App.Model.comm;
    using System.ComponentModel.DataAnnotations;
using System.Web;
    using System.Web.Mvc;

 [MetadataType(typeof(userMetadata))] 

  public partial class user {
      [UmlElement(Id = "37c4be59-03f2-4b7f-b39c-fe9b3467d597")]
      public void setcurrentuser()
      {
          if (sys_function.getclienttype() == 0)
          {
              HttpContext.Current.Session["CURR_USER"] = this;
          }
          if (sys_function.getclienttype() == 1)
          {
              sys_function sf = sys_function.getsysfunction(this.AsIObject().ServiceProvider);
              
              IExternalIdService ids = this.AsIObject().ServiceProvider.GetEcoService<IExternalIdService>();
              sf.current_userID = ids.IdForObject(this);
          }
      }
      private class userMetadata
      {
          [HiddenInput(DisplayValue = false)]


          [Required]
          [Display(Name = "”√ªß√˚")]
          public string Username { get; set; }

          [Required]
          [DataType(DataType.EmailAddress)]
          [Display(Name = "Email address")]
          public string email { get; set; }

          [Required]
          [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
       //   [DataType(DataType.Password)]
          [Display(Name = "√‹¬Î")]
          public string Password { get; set; }

         // [DataType(DataType.Password)]
          [Display(Name = "Confirm password")]
          [System.Web.Mvc.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
          public string ConfirmPassword { get; set; }

          // Also add any other properties for which you want to supply metadata 
      }

      [Obsolete("This method has been removed from the model"), UmlElement(Id = "20f8eac2-317a-4899-be6a-acef286c321b")]
      public void setasdeptowner(dept owndept)
      {

      }

      [Obsolete("This method has been removed from the model"), UmlElement(Id = "73b4de64-c423-4c86-ad9a-483ff4c2c7ef")]
      public void setasdeptowner(string deptid)
      {

      }


 
  }
}