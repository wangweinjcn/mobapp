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
  
  
  public partial class basetree {
      [UmlElement(Id = "e7c6560b-118b-450b-8767-6f3c37f74605")]
      public basetree getparent()
      {
          if (this.basetree_parent == null)
          {
              return null;
          }
          else {
              return this.basetree_parent;
          }
      }

      [UmlElement(Id = "e0ba3563-1592-428f-85e3-be922569528c")]
      public void setparent(string pkey)
      {
          basetree pnode =
              this.ServiceProvider().GetEcoService<IExternalIdService>().ObjectForId(pkey).GetValue<basetree>();
          this.basetree_parent.basetree_children.Remove(this);
          this.basetree_parent = pnode;
          
      }
  }
}