namespace Mobapp.localEcoSpace
{
    public partial class l_EcoSpace
    {
        /// <summary>
        /// Required designer variable
        /// </summary>
        private System.ComponentModel.Container components = null;

        private Eco.Persistence.PersistenceMapperSharer persistenceMapperSharer1;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Active = false;
                if (this.components != null)
                {
                    this.components.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.persistenceMapperSharer1 = new Eco.Persistence.PersistenceMapperSharer();
            // 
            // persistenceMapperSharer1
            // 
            this.persistenceMapperSharer1.MapperProviderTypeName = "Mobapp.localEcoSpace.l_PMP";
            // 
            // l_EcoSpace
            // 
            this.PersistenceMapper = this.persistenceMapperSharer1;

        }

        protected App.Model.App_ModelPackage IncludeEcoPackage_App_Model_App_ModelPackage;
        protected App.Model.comm.commPackage IncludeEcoPackage_App_Model_comm_commPackage;
    }
}
