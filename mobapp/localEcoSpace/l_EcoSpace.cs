namespace Mobapp.localEcoSpace
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Eco.Handles;
    using Eco.Linq;
    using Eco.Services;
    using Eco.UmlCodeAttributes;

    [EcoSpace]
    [UmlTaggedValue("Eco.InitializeNullableStringsToNull", "true")]
    [UmlTaggedValue("Eco.GenerateMultiplicityConstraints", "true")]
    public partial class l_EcoSpace : Eco.Handles.DefaultEcoSpace
    {
        #region Eco Managed code
        private static ITypeSystemService typeSystemProvider;
        #endregion Eco Managed code

        public l_EcoSpace()
            : base()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Persist all changes to the domain objects.
        /// </summary>
        /// <remarks>
        /// This function persists all changes to the eco space, including object creation,
        /// object manipulation, changed associations and object deletions. After invoking this method
        /// all undo information is removed.
        /// If the application does not have any persistence layer defined the operation does nothing.
        /// </remarks>
        public void UpdateDatabase()
        {
            if ((Persistence != null) && (DirtyList != null))
            {
                Persistence.UpdateDatabaseWithList(DirtyList.AllDirtyObjects());
            }
        }

        #region Eco Managed code
        public static new ITypeSystemService GetTypeSystemService()
        {
            if (typeSystemProvider == null)
            {
                lock (typeof(l_EcoSpace))
                {
                    if (typeSystemProvider == null)
                        typeSystemProvider = MakeTypeService(typeof(l_EcoSpace));
                }
            }

            return typeSystemProvider;
        }

        protected override ITypeSystemService GetTypeSystemProvider()
        {
            return l_EcoSpace.GetTypeSystemService();
        }
        #endregion

        // Add user written methods here
    }
}
