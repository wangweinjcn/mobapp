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
  
  
  public partial class base_class {
      partial void ObjectCreated()
      {
          this.update_dt = DateTime.Now;
          this.create_dt = DateTime.Now;
      }

      [UmlElement(Id = "0c3f2e56-3111-4164-a5fb-43fda11aa557")]
      public void OnCreate()
      {
          this.create_dt = DateTime.Now;
          this.update_dt = DateTime.Now;
          
          sys_function sf = sys_function.getsysfunction(this.AsIObject().ServiceProvider);
          user tmpuser=sf.getcurruser();
          if (tmpuser!=null)
          {
              this.create_user = tmpuser;
              this.update_user = tmpuser;
          }
          data_action_log newobj = new data_action_log(this.AsIObject().ServiceProvider);
          newobj.action = "Create";
          newobj.clienttype = sys_function.getclienttype();
          newobj.fromip = sys_function.getcurrIP();
          newobj.user = this.create_user;
          newobj.do_dt = DateTime.Now;
          this.newobj_id =this.EID;
          newobj.ecoid = this.EID;
          newobj.charcount = sys_function.objecttojson(this).Length;
       //   this.AsIObject().ServiceProvider.GetEcoService<IPersistenceService>().UpdateDatabase(newobj.AsIObject());
                    }

      [UmlElement(Id = "251d89af-5d75-434a-9131-fa448608fc13")]
      public void OnUpdate()
      {
          
          if ((this==null)||(this.AsIObject().ServiceProvider.GetEcoService<IStateService>().IsDirty(this)))
              return;
          this.update_dt = DateTime.Now;
          sys_function sf = sys_function.getsysfunction(this.AsIObject().ServiceProvider);
          user tmpuser = sf.getcurruser();
          if (tmpuser != null)
          {
             
              this.update_user = tmpuser;
          }
          data_action_log newobj = new data_action_log(this.AsIObject().ServiceProvider);
          newobj.action = "Update";
          newobj.clienttype = sys_function.getclienttype();
          newobj.fromip = sys_function.getcurrIP();
          newobj.user = this.update_user;
          newobj.do_dt = DateTime.Now;
          newobj.ecoid = sf.idforobject(this);
          newobj.charcount = sys_function.objecttojson(this).Length;
         
      }

      [UmlElement(Id = "6ccb52be-8dc2-479f-8ab1-4f8ead284f4a")]
      public void OnDelete()
      {
         if (this.AsIObject().ServiceProvider.GetEcoService<IStateService>().IsNew(this))
          return;
          sys_function sf = sys_function.getsysfunction(this.AsIObject().ServiceProvider);
          user update_user = sf.getcurruser();
          data_action_log newobj = new data_action_log(this.AsIObject().ServiceProvider);
          newobj.action = "Delete";
          newobj.clienttype = sys_function.getclienttype();
          newobj.fromip = sys_function.getcurrIP();
          newobj.user = update_user;
          newobj.do_dt = DateTime.Now;
          newobj.ecoid = sf.idforobject(this);
          newobj.delete_obj_jsonobj = sys_function.objecttojson(this);
        
          newobj.charcount = newobj.delete_obj_jsonobj.Length;
        
        
      }

  }
}