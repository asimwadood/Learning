using ASmarte.Core.Domain.Localization;

namespace ASmarte.Core.Domain.Shipping
{
    /// <summary>
    /// Represents a delivery date 
    /// </summary>
    public partial class DeliveryDate : BaseEntity, ILocalizedEntity
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display order
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}