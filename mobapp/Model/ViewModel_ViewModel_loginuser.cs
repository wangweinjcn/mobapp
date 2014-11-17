//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mobapp.Model.ViewModelCodeGen_ViewModel_loginuser {
  using System;
  using System.ComponentModel;
  using System.Collections.Generic;
  using System.CodeDom.Compiler;
  using Eco.Handles;
  using Eco.ObjectRepresentation;
  using Eco.ViewModel.Runtime;
  using Eco.UmlCodeAttributes;
  
  
  public partial class ViewModel_loginuser : Eco.ViewModel.Runtime.VMClass {
    
    /// <summary>
    /// This constructor creates an Offline ViewModel class
    /// </summary>
    public ViewModel_loginuser() {
      ViewModelHelper.InitTypedOfflineVMClass(this, new GetVMClassTypeDelegate(ViewModel_loginuser.GetVMClassType));
    }
    
    protected static System.Type GetVMClassType(Eco.ViewModel.Runtime.VMClassDescriptor desc) {
      if ((desc.Name == "ViewModel_loginuser")) {
        return typeof(ViewModel_loginuser);
      }
      if ((desc.Name == "VM_Validations")) {
        return typeof(VM_Validations);
      }
      if ((desc.Name == "VM_Status")) {
        return typeof(VM_Status);
      }
      if ((desc.Name == "VM_Variables")) {
        return typeof(VM_Variables);
      }
      throw new System.Exception("Generated ViewModel code out of data");
    }
    
    public static ViewModel_loginuser Create(Eco.Handles.EcoSpace es, App.Model.comm.user obj) {
      return ((ViewModel_loginuser)(ViewModelHelper.CreateFromViewModel("ViewModel_loginuser", es, obj, new GetVMClassTypeDelegate(ViewModel_loginuser.GetVMClassType))));
    }
    
    /// <summary>
    /// Setting this will make the ViewModel reset to Content=null, and become online
    /// </summary>
    public void SetEcoSpace(Eco.Handles.EcoSpace es) {
      this.SetEcoSpace("ViewModel_loginuser", es, new GetVMClassTypeDelegate(ViewModel_loginuser.GetVMClassType));
    }
    
    /// <summary>
    /// Constructor public for technical reasons, use static Create on ViewModel root to create online ViewModel
    /// </summary>
    public ViewModel_loginuser(Eco.ViewModel.Runtime.VMClassDescriptor vMClassDescriptor, Eco.ObjectRepresentation.IEcoServiceProvider sp, Eco.ViewModel.Runtime.VMClass ownedby, Eco.ObjectRepresentation.IElement content, Eco.ObjectRepresentation.IExternalVariableList variables) : 
        base(vMClassDescriptor, sp, ownedby, content, variables) {
    }
    
    [System.ComponentModel.DataAnnotations.StringLength(100,ErrorMessage="{0}必须至少包含{2}个字符",MinimumLength=1)]
    [Mobapp.Model.FieldAttribute.C_DisplayName(Name="Username")]
    [Mobapp.Model.FieldAttribute.Required(ErrorMessageID="It's wrong")]
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public string Username {
      get {
        return ((string)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("Username", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute)))).Value));
      }
      set {
        ((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("Username", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute)))).Value = value;
      }
    }
    
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public string Password {
      get {
        return ((string)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("Password", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute)))).Value));
      }
      set {
        ((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("Password", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute)))).Value = value;
      }
    }
    
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public bool RememberMe {
      get {
        return ((bool)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("RememberMe", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute), false))).Value));
      }
      set {
        ((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("RememberMe", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute)))).Value = value;
      }
    }
    
    public VM_Validations VM_Validations {
      get {
        return ((VM_Validations)(((Eco.ViewModel.Runtime.VMSingleAssociation)(this.GetMemberOfflineAware("VM_Validations", typeof(Eco.ViewModel.Runtime.VMSingleAssociation)))).Value));
      }
      set {
        ((Eco.ViewModel.Runtime.VMSingleAssociation)(this.GetMemberOfflineAware("VM_Validations", typeof(Eco.ViewModel.Runtime.VMSingleAssociation)))).Value = value;
      }
    }
    
    public VM_Status VM_Status {
      get {
        return ((VM_Status)(((Eco.ViewModel.Runtime.VMSingleAssociation)(this.GetMemberOfflineAware("VM_Status", typeof(Eco.ViewModel.Runtime.VMSingleAssociation)))).Value));
      }
      set {
        ((Eco.ViewModel.Runtime.VMSingleAssociation)(this.GetMemberOfflineAware("VM_Status", typeof(Eco.ViewModel.Runtime.VMSingleAssociation)))).Value = value;
      }
    }
    
    public VM_Variables VM_Variables {
      get {
        return ((VM_Variables)(((Eco.ViewModel.Runtime.VMSingleAssociation)(this.GetMemberOfflineAware("VM_Variables", typeof(Eco.ViewModel.Runtime.VMSingleAssociation)))).Value));
      }
      set {
        ((Eco.ViewModel.Runtime.VMSingleAssociation)(this.GetMemberOfflineAware("VM_Variables", typeof(Eco.ViewModel.Runtime.VMSingleAssociation)))).Value = value;
      }
    }
  }
  
  public class VM_Validations : Eco.ViewModel.Runtime.VMClass {
    
    /// <summary>
    /// This constructor creates an Offline ViewModel class
    /// </summary>
    public VM_Validations() {
    }
    
    /// <summary>
    /// Constructor public for technical reasons, use static Create on ViewModel root to create online ViewModel
    /// </summary>
    public VM_Validations(Eco.ViewModel.Runtime.VMClassDescriptor vMClassDescriptor, Eco.ObjectRepresentation.IEcoServiceProvider sp, Eco.ViewModel.Runtime.VMClass ownedby, Eco.ObjectRepresentation.IElement content, Eco.ObjectRepresentation.IExternalVariableList variables) : 
        base(vMClassDescriptor, sp, ownedby, content, variables) {
    }
    
    public bool Validation_Rule1 {
      get {
        return ((bool)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("Validation_Rule1", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute), false))).Value));
      }
    }
  }
  
  public class VM_Status : Eco.ViewModel.Runtime.VMClass {
    
    /// <summary>
    /// This constructor creates an Offline ViewModel class
    /// </summary>
    public VM_Status() {
    }
    
    /// <summary>
    /// Constructor public for technical reasons, use static Create on ViewModel root to create online ViewModel
    /// </summary>
    public VM_Status(Eco.ViewModel.Runtime.VMClassDescriptor vMClassDescriptor, Eco.ObjectRepresentation.IEcoServiceProvider sp, Eco.ViewModel.Runtime.VMClass ownedby, Eco.ObjectRepresentation.IElement content, Eco.ObjectRepresentation.IExternalVariableList variables) : 
        base(vMClassDescriptor, sp, ownedby, content, variables) {
    }
    
    public bool ViewModel_loginuser_Username_ReadOnly {
      get {
        return ((bool)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("ViewModel_loginuser_Username_ReadOnly", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute), false))).Value));
      }
    }
    
    public bool ViewModel_loginuser_Username_Enabled {
      get {
        return ((bool)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("ViewModel_loginuser_Username_Enabled", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute), false))).Value));
      }
    }
    
    public bool ViewModel_loginuser_Username_Visible {
      get {
        return ((bool)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("ViewModel_loginuser_Username_Visible", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute), false))).Value));
      }
    }
    
    public string ViewModel_loginuser_Username_Style {
      get {
        return ((string)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("ViewModel_loginuser_Username_Style", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute)))).Value));
      }
    }
    
    public bool ViewModel_loginuser_Password_ReadOnly {
      get {
        return ((bool)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("ViewModel_loginuser_Password_ReadOnly", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute), false))).Value));
      }
    }
    
    public bool ViewModel_loginuser_Password_Enabled {
      get {
        return ((bool)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("ViewModel_loginuser_Password_Enabled", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute), false))).Value));
      }
    }
    
    public bool ViewModel_loginuser_Password_Visible {
      get {
        return ((bool)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("ViewModel_loginuser_Password_Visible", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute), false))).Value));
      }
    }
    
    public string ViewModel_loginuser_Password_Style {
      get {
        return ((string)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("ViewModel_loginuser_Password_Style", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute)))).Value));
      }
    }
    
    public bool ViewModel_loginuser_RememberMe_ReadOnly {
      get {
        return ((bool)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("ViewModel_loginuser_RememberMe_ReadOnly", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute), false))).Value));
      }
    }
    
    public bool ViewModel_loginuser_RememberMe_Enabled {
      get {
        return ((bool)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("ViewModel_loginuser_RememberMe_Enabled", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute), false))).Value));
      }
    }
    
    public bool ViewModel_loginuser_RememberMe_Visible {
      get {
        return ((bool)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("ViewModel_loginuser_RememberMe_Visible", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute), false))).Value));
      }
    }
    
    public string ViewModel_loginuser_RememberMe_Style {
      get {
        return ((string)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("ViewModel_loginuser_RememberMe_Style", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute)))).Value));
      }
    }
    
    public bool CompleteVM_ReadOnly {
      get {
        return ((bool)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("CompleteVM_ReadOnly", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute), false))).Value));
      }
    }
  }
  
  public class VM_Variables : Eco.ViewModel.Runtime.VMClass {
    
    /// <summary>
    /// This constructor creates an Offline ViewModel class
    /// </summary>
    public VM_Variables() {
    }
    
    /// <summary>
    /// Constructor public for technical reasons, use static Create on ViewModel root to create online ViewModel
    /// </summary>
    public VM_Variables(Eco.ViewModel.Runtime.VMClassDescriptor vMClassDescriptor, Eco.ObjectRepresentation.IEcoServiceProvider sp, Eco.ViewModel.Runtime.VMClass ownedby, Eco.ObjectRepresentation.IElement content, Eco.ObjectRepresentation.IExternalVariableList variables) : 
        base(vMClassDescriptor, sp, ownedby, content, variables) {
    }
    
    public App.Model.comm.user vCurrent_ViewModel_loginuser {
      get {
        return ((App.Model.comm.user)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("vCurrent_ViewModel_loginuser", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute)))).Value));
      }
      set {
        ((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("vCurrent_ViewModel_loginuser", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute)))).Value = value;
      }
    }
    
    public string vGridActionArgument {
      get {
        return ((string)(((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("vGridActionArgument", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute)))).Value));
      }
      set {
        ((Eco.ViewModel.Runtime.VMNativeTypeAttribute)(this.GetMemberOfflineAware("vGridActionArgument", typeof(Eco.ViewModel.Runtime.VMNativeTypeAttribute)))).Value = value;
      }
    }
  }
}
