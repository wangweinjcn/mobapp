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
  
  
  public partial class dept {
      [UmlElement(Id = "a52e40a3-9ce3-4fb2-851d-01f1dd2af239")]
      public user addnewuser(string username)
      {
          user newuser = new user(this.AsIObject().ServiceProvider);
          newuser.Username = username;
          return addnewuser(newuser);
      }

      [UmlElement(Id = "3f950039-4b32-4d58-9e80-67fd917c6c9d")]
      public user addnewuser(user newuser)
      {
          newuser.my_dept.Add( this);
          return newuser;
      }

      [UmlElement(Id = "643d72df-3bd6-4844-9593-7e2b728fb7cd")]
      public dept addsubdept(string name)
      {
          dept newdept = new dept(this.AsIObject().ServiceProvider);
        return   addsubdept(newdept);
      }

      [UmlElement(Id = "24359b27-b6e9-4d4f-b008-d85f248226d9")]
      public dept addsubdept(dept newdept)
      {
          newdept.basetree_parent = this;
          return newdept;
      }

      [UmlElement(Id = "85025b1c-b15e-4501-a467-176ad1f2695f")]
      public void setdeptmanager(user owner)
      {
          this.dept_manager = owner;

      }

      [UmlElement(Id = "1f85b637-be04-4e0f-86d6-b8d6177c33aa")]
      public void setdeptmanager(string userid)
      {
          IExternalIdService ids = this.AsIObject().ServiceProvider.GetEcoService<IExternalIdService>();
          user owner = ids.ObjectForId(userid).AsObject as user;
          setdeptmanager(owner);
      }
  }
}