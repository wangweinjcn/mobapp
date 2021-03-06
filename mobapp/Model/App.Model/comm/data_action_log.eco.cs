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
  
  
  [UmlElement(Id="667976fc-4f78-4a01-9bff-c37c737970c5")]
  public partial class data_action_log : Eco.ObjectImplementation.ILoopBack3, System.ComponentModel.INotifyPropertyChanged {
    
    #region *** Constructors ***
    
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public data_action_log(Eco.ObjectRepresentation.IEcoServiceProvider serviceProvider) {
      this.Initialize(serviceProvider);
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
    public data_action_log(Eco.ObjectImplementation.IContent content) {
      this.eco_Content = content;
      content.AssertLoopbackUnassigned();
      this.ObjectFetched();
    }
    
    /// <summary>
    /// Creates an Offline object. Can for example be used by MVC runtime to pass values
    /// This is type equivalent to the eco object in everyway - but has none of the eco services
    /// It does however implement INotifyPropertyChanged and INotifyCollectionChanged
    /// </summary>
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public data_action_log() {
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
    public virtual void set_MemberByIndex(int index, object value) {
      throw new System.IndexOutOfRangeException();
    }
    
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public virtual object get_MemberByIndex(int index) {
      throw new System.IndexOutOfRangeException();
    }
    
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    Eco.ObjectRepresentation.IObject Eco.ObjectRepresentation.IObjectProvider.AsIObject() {
      return this.eco_Content.AsIObject();
    }
    
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    void Eco.ObjectImplementation.ILoopBack2.SetContent(Eco.ObjectImplementation.IContent content) {
      if ((this.eco_Content != null)) {
        throw new System.InvalidOperationException();
      }
      this.eco_Content = content;
    }
    
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    Eco.ObjectImplementation.IContent Eco.ObjectImplementation.ILoopBack3.GetContent() {
      return this.eco_Content;
    }
    
    #endregion *** ILoopback implementation ***
    
    #region *** LoopbackIndex declarations ***
    
    public struct Eco_LoopbackIndices {
      
      public const int Eco_FirstMember = 0;
      
      public const int fromip = Eco_FirstMember;
      
      public const int charcount = (fromip + 1);
      
      public const int delete_obj_jsonobj = (charcount + 1);
      
      public const int clienttype = (delete_obj_jsonobj + 1);
      
      public const int ecoid = (clienttype + 1);
      
      public const int do_dt = (ecoid + 1);
      
      public const int action = (do_dt + 1);
      
      public const int user = (action + 1);
      
      public const int delete_obj = (user + 1);
      
      public const int Eco_MemberCount = (delete_obj + 1);
    }
    
    #endregion *** LoopbackIndex declarations ***
    
    #region *** IObjectProvider implementation ***
    
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public virtual Eco.ObjectRepresentation.IObjectInstance AsIObject() {
      return this.eco_Content.AsIObject();
    }
    
    #endregion *** IObjectProvider implementation ***
    
    #region *** INotifyPropertyChanged implementation ***
    
    event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged {
    
      add { eco_Content.PropertyChanged += value; }
    
      remove { eco_Content.PropertyChanged -= value; }
    
    }
    
    #endregion *** INotifyPropertyChanged implementation ***
    
    #region *** ECO framework implementations ***
    
    protected Eco.ObjectImplementation.IContent eco_Content;
    
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    protected virtual void Initialize(Eco.ObjectRepresentation.IEcoServiceProvider serviceProvider) {
      if ((this.eco_Content == null)) {
        Eco.ObjectImplementation.IInternalObjectContentFactory factory = serviceProvider.GetEcoService<Eco.ObjectImplementation.IInternalObjectContentFactory>();
        factory.CreateContent(this);
        this.eco_Content.LoopbackValid();
      }
    }
    
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    protected virtual void Deinitialize(Eco.ObjectRepresentation.IEcoServiceProvider serviceProvider) {
      if ((this.eco_Content == null)) {
        Eco.ObjectImplementation.IInternalObjectContentFactory factory = serviceProvider.GetEcoService<Eco.ObjectImplementation.IInternalObjectContentFactory>();
        factory.CreateContentFailed(this.eco_Content, this);
        this.eco_Content = null;
      }
    }
    
    #endregion *** ECO framework implementations ***
    
    [UmlElement(Id="15c30adc-45c9-447a-a32d-b40e12b36b04", Index=Eco_LoopbackIndices.fromip)]
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public string fromip {
      get {
        return ((string)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.fromip, typeof(string))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.fromip, ((object)(value)), "fromip");
      }
    }
    
    [UmlElement(Id="3804808d-2c87-4767-b7ea-298c9825ea24", Index=Eco_LoopbackIndices.charcount)]
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public long charcount {
      get {
        return ((long)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.charcount, typeof(long))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.charcount, ((object)(value)), "charcount");
      }
    }
    
    [UmlTaggedValue("Eco.AllowNULL", "True")]
    [UmlElement(Id="763fe675-071b-499d-be0e-e373255e78d1", Index=Eco_LoopbackIndices.delete_obj_jsonobj)]
    [UmlTaggedValue("Eco.PMapper", "StringAsText")]
    [UmlTaggedValue("Eco.Length", "-1")]
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public string delete_obj_jsonobj {
      get {
        return ((string)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.delete_obj_jsonobj, typeof(string))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.delete_obj_jsonobj, ((object)(value)), "delete_obj_jsonobj");
      }
    }
    
    [UmlElement(Id="7f25e4d3-0c6b-445b-8435-6e9d38dac886", Index=Eco_LoopbackIndices.clienttype)]
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public int? clienttype {
      get {
        return ((int?)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.clienttype, typeof(int?))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.clienttype, ((object)(value)), "clienttype");
      }
    }
    
    [UmlElement(Id="8dfeb7f9-fd67-4918-a812-f1c3841a7deb", Index=Eco_LoopbackIndices.ecoid)]
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public string ecoid {
      get {
        return ((string)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.ecoid, typeof(string))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.ecoid, ((object)(value)), "ecoid");
      }
    }
    
    [UmlElement(Id="bacede2c-4418-4fbd-be18-7958ab08f341", Index=Eco_LoopbackIndices.do_dt)]
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public System.DateTime do_dt {
      get {
        return ((System.DateTime)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.do_dt, typeof(System.DateTime))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.do_dt, ((object)(value)), "do_dt");
      }
    }
    
    [UmlElement(Id="dadeda6c-2a52-4fb4-b0d1-cff57d1534cc", Index=Eco_LoopbackIndices.action)]
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public string action {
      get {
        return ((string)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.action, typeof(string))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.action, ((object)(value)), "action");
      }
    }
    
    [UmlElement("AssociationEnd", Id="1595f309-ddf2-48fb-bce3-63ebc07f57f7", Index=Eco_LoopbackIndices.user)]
    [UmlMetaAttribute("association", typeof(commPackage.data_action_logdata_action_loguseruser), Index=0)]
    [UmlMetaAttribute("multiplicity", "0..1")]
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public user user {
      get {
        return ((user)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.user, typeof(user))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.user, ((object)(value)), "user");
      }
    }
    
    [UmlElement("AssociationEnd", Id="4e2aa653-c57c-4c91-8786-c25a8d6e29af", Index=Eco_LoopbackIndices.delete_obj)]
    [UmlMetaAttribute("aggregation", AggregationKind.Composite)]
    [UmlMetaAttribute("association", typeof(commPackage.data_action_logdata_action_logdelete_objdelete_obj), Index=1)]
    [UmlMetaAttribute("multiplicity", "1")]
    [GeneratedCodeAttribute("ECO", "7.0.0.0")]
    public delete_obj delete_obj {
      get {
        return ((delete_obj)(this.eco_Content.get_MemberByIndex_OfflineAware(Eco_LoopbackIndices.delete_obj, typeof(delete_obj))));
      }
      set {
        this.eco_Content.set_MemberByIndex_OfflineAware(Eco_LoopbackIndices.delete_obj, ((object)(value)), "delete_obj");
      }
    }
  }
}
