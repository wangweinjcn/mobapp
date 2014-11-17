using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Eco.MVC;
using Eco.Handles;
using Eco.ObjectRepresentation;
using Eco.Ocl.Support;
using Eco.Services;
using Eco.UmlRt;
using Eco.ViewModel.Runtime;

namespace Mobapp.mvcapi.Appcode
{
    public class EcoApiController<ESType> : ApiController where ESType : DefaultEcoSpace, new()
    {
        private Eco.Handles.EcoSpace _AdditionalEcoSpaceForDeactivationOnDone;
        private bool _DoNotDeactivateEcoSpaceOnDone;
        private DefaultEcoSpace _EcoSpace;

        protected void AddAdditionalEcoSpaceForDeactivationOnDone(Eco.Handles.EcoSpace es2)
        {
            this._AdditionalEcoSpaceForDeactivationOnDone = es2;
        }

        protected virtual void AfterEcoSpaceCreate()
        {
          //  if ((base.User.Identity is FormsIdentity) && base.User.Identity.IsAuthenticated)
      //      {
              //  EcoEnvironment.OverrideCurrentUserAndDomainSetting((base.User.Identity as FormsIdentity).Name, "");
      //      }
      //      else
            {
                EcoEnvironment.OverrideCurrentUserAndDomainSetting("", "");
            }
        }

        public void ApplyValues(IEcoObject offline, IEcoObject online)
        {
            EcoOfflineObjectHelper.ApplyValues(offline, online);
        }

        public void ApplyValues(VMClass offline, VMClass online)
        {
            ViewModelHelper.ApplyValues(offline, online, null);
        }

        public bool BusinessDelete(IEcoObject obj)
        {
            bool flag;
            string str;
            IConstraint constraint;
            if (obj.AsIObject().Deleted)
            {
                return false;
            }
            EcoServiceHelper.GetEcoService<IBusinessDeleteService>(this.GetEcoSpace()).CheckDeleteConstraints(obj.AsIObject(), out flag, out str, out constraint, true);
            if (!string.IsNullOrEmpty(str))
            {
                if (str != null)
                {
                    base.ModelState.AddModelError("", str);
                }
                if (constraint != null)
                {
                    base.ModelState.AddModelError("", constraint.Description);
                }
                return false;
            }
            obj.AsIObject().Delete();
            return true;
        }

        public bool Commit()
        {
            this.ValidateChanges();
            return this.CommitSkipValidate();
        }

        public bool Commit(VMClass viewmodel)
        {
            this.ValidateChanges(viewmodel);
            return this.CommitSkipValidate();
        }

        protected bool CommitSkipValidate()
        {
            if (base.ModelState.IsValid)
            {
                this.UpdateDatabase();
            }
            if (!base.ModelState.IsValid)
            {
                this.GetEcoSpace().AllowDeactivateDirty = true;
            }
            return base.ModelState.IsValid;
        }

        private DefaultEcoSpace CreateEcoSpace()
        {
            return Activator.CreateInstance<ESType>();
        }

        protected void DoNotDeactivateEcoSpaceOnDone()
        {
            this._DoNotDeactivateEcoSpaceOnDone = true;
        }

        public DefaultEcoSpace EnsuredEcoSpace()
        {
            if (this._EcoSpace == null)
            {
                this._EcoSpace = this.CreateEcoSpace();
                this._EcoSpace.Active = true;
                this.AfterEcoSpaceCreate();
            }
            return this._EcoSpace;
        }

        public DefaultEcoSpace GetEcoSpace()
        {
            return this.EnsuredEcoSpace();
        }

       

        public IObjectInstance ObjectForId(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }
            return this.EcoSpace.ExternalIds.ObjectForId(id);
        }

       
     
        public void UpdateDatabase()
        {
            EcoServiceHelper.GetPersistenceService(this._EcoSpace).UpdateDatabaseWithList<IObjectInstance>(EcoServiceHelper.GetDirtyListService(this._EcoSpace).AllDirtyObjects());
        }

        private void ValidateChanges()
        {
            foreach (IObject obj2 in this.GetEcoSpace().DirtyList.AllDirtyObjects())
            {
                this.ValidateObject(obj2);
            }
        }

        protected void ValidateChanges(VMClass viewmodel)
        {
            List<string> errors = new List<string>();
            List<string> info = new List<string>();
            List<string> warnings = new List<string>();
            viewmodel.ViewModelClass.ViewModel.UpdateErrorsFromConstraints(errors, warnings, info, null);
            foreach (string str in errors)
            {
                base.ModelState.AddModelError("", str);
            }
            foreach (string str in warnings)
            {
                base.ModelState.AddModelError("", str);
            }
            foreach (string str in info)
            {
                base.ModelState.AddModelError("", str);
            }
        }

        private void ValidateObject(IObject obj)
        {
            if (!obj.Deleted)
            {
                foreach (IConstraint constraint in obj.UmlType.Constraints)
                {
                    if (!constraint.IsDeleteConstraint && !this.GetEcoSpace().Ocl.Evaluate(obj, constraint.Body.Body).GetValue<bool>())
                    {
                        string[] strArray = constraint.Name.Split(new char[] { '/' });
                        if (strArray.Length == 1)
                        {
                            base.ModelState.AddModelError("", constraint.Description);
                        }
                        else
                        {
                            base.ModelState.AddModelError(strArray[0], constraint.Description);
                        }
                    }
                }
            }
        }

        public DefaultEcoSpace EcoSpace
        {
            get
            {
                return this.GetEcoSpace();
            }
        }


    }
}
