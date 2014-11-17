//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Model.comm {
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
  
  
  [UmlElement(Id="8f488c5c-ea34-48d5-b4c3-ea16b3ef850e")]
  [UmlTaggedValue("Eco.IsSingleton", "False")]
  public partial class sys_param : App.Model.comm.base_class {
    
    #region *** Constructors ***
    
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public sys_param(Eco.ObjectRepresentation.IEcoServiceProvider serviceProvider) : 
        base(serviceProvider) {
      try {
        this.ObjectCreated();
      }
      catch (System.Exception ) {
        this.Deinitialize(serviceProvider);
        throw;
      }
    }
    
    /// <summary>
    /// For framework internal use only
    /// Constructor public for one reason only; to avoid need for ReflectionPermission in reduced trust
    /// </summary>
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public sys_param(Eco.ObjectImplementation.IContent content) : 
        base(content) {
      this.ObjectFetched();
    }
    
    /// <summary>
    /// Creates an Offline object. Can for example be used by MVC runtime to pass values
    /// This is type equivalent to the eco object in everyway - but has none of the eco services
    /// It does however implement INotifyPropertyChanged and INotifyCollectionChanged
    /// </summary>
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public sys_param() {
      this.eco_Content = new EcoOfflineValues();
      this.ObjectCreated();
    }
    
    /// <summary>This method is called when the object has been created the first time (not when loaded from a db)</summary>
    partial void ObjectCreated();
    
    /// <summary>This method is called when the object has been loaded from a db (not when it is created the first time)</summary>
    partial void ObjectFetched();
    
    /// <summary>This method is called before the object is deleted. You can perform custom clean up or prevent the deletion by returning false or throw an exception (preferably EcoObjectDeleteException)</summary>
    partial void PreDelete(ref System.Boolean canDelete);
    
    #endregion *** Constructors ***
    
    #region *** ILoopback implementation ***
    
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public override void set_MemberByIndex(int index, object value) {
      base.set_MemberByIndex(index, value);
    }
    
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public override object get_MemberByIndex(int index) {
      return base.get_MemberByIndex(index);
    }
    
    #endregion *** ILoopback implementation ***
    
    #region *** LoopbackIndex declarations ***
    
    new public struct Eco_LoopbackIndices {
      
      public const int Eco_FirstMember = App.Model.comm.base_class.Eco_LoopbackIndices.Eco_MemberCount;
      
      public const int value = Eco_FirstMember;
      
      public const int type = (value + 1);
      
      public const int name = (type + 1);
      
      public const int Eco_MemberCount = (name + 1);
    }
    
    #endregion *** LoopbackIndex declarations ***
    
    [UmlElement(Id="487e111d-a10d-4cbf-826c-27ee5b8c4b5f", Index=Eco_LoopbackIndices.value)]
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public string value {
      get {
        return ((string)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.value, typeof(string))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.value, ((object)(value)), "value");
      }
    }
    
    [UmlElement(Id="4eb59e8f-0c72-4395-bb39-944bb43e9c6b", Index=Eco_LoopbackIndices.type)]
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public string type {
      get {
        return ((string)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.type, typeof(string))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.type, ((object)(value)), "type");
      }
    }
    
    [UmlElement(Id="d9a45da3-4497-4024-bf4d-60c438d370bb", Index=Eco_LoopbackIndices.name)]
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public string name {
      get {
        return ((string)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.name, typeof(string))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.name, ((object)(value)), "name");
      }
    }
  }
}