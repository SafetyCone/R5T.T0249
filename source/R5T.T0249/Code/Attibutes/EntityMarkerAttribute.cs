using System;

using R5T.T0143;


namespace R5T.T0249
{
    /// <summary>
    /// Attribute indicating a class is an entity (a class specialized to participate in data storage with Entity Framework Core).
    /// The marker attribute is useful for surveying entity classes and building a catalogue of entities.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class EntityMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        private readonly bool zIsEntity;

        /// <summary>
        /// Allows specifying that a class is *not* an entity class.
        /// This is useful for marking classes that end up canonical entity code file locations, but are not entity classes.
        /// </summary>
        public bool IsEntity
        {
            get
            {
                return this.zIsEntity;
            }
        }


        public EntityMarkerAttribute(
            bool isEntity = true)
        {
            this.zIsEntity = isEntity;
        }
    }
}
