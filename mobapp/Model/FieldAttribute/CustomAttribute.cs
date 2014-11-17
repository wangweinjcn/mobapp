using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace Mobapp.Model.FieldAttribute
{
  
    [AttributeUsage(AttributeTargets.Property)]
    public class C_DisplayName : Attribute, IMetadataAware
    {
        public string Name { get; set; } //默认显示名称
        public void OnMetadataCreated(ModelMetadata metadata)
        {
        //    metadata.DisplayName = string.Format("{0}/{1}",
        //         string.IsNullOrEmpty(this.Name) ? metadata.DisplayName : this.Name, metadata.PropertyName);
            metadata.DisplayName = MessageManager.Current.GetMessage(this.Name);
        }
    }

    public class MessageManager
    {

   //     static Dictionary<string, string> messages = new Dictionary<string, string>();

        static MessageManager()
        {

        }

        public string GetMessage(string messageId)
        {

          //  return string.Format(CultureInfo.CurrentCulture, messages[messageId], args);
            return messageId;
        }

        public static MessageManager Current = new MessageManager();

    }
    public class ExtendedValidationAttribute : ValidationAttribute
    {

        public string ErrorMessageID { get; set; }
        public ExtendedValidationAttribute(string ErrorMessageID)
            : base(() => MessageManager.Current.GetMessage(ErrorMessageID))
        {

        }
        public ExtendedValidationAttribute(): base()
        {
          }
    }

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public class RequiredAttribute : ExtendedValidationAttribute
    {

        public bool AllowEmptyStrings { get; set; }

        public RequiredAttribute() :  base()
        { }
        public override string FormatErrorMessage(string name)
        {
            return string.Format("{0} "+MessageManager.Current.GetMessage(ErrorMessageID), name);
        }
        public override bool IsValid(object value)
        {
            
            return new System.ComponentModel.DataAnnotations.RequiredAttribute { AllowEmptyStrings = this.AllowEmptyStrings }.IsValid(value);

        }

    }
    
}
