using System;
using System.Xml.Serialization;

namespace HoloXPLOR.Data.DataForge
{
    [XmlRoot(ElementName = "BTSetBranchTag")]
    public partial class BTSetBranchTag : BTNode
    {
        [XmlArray(ElementName = "BranchTag")]
        [XmlArrayItem(Type = typeof(BTInputTag))]
        [XmlArrayItem(Type = typeof(BTInputTagValue))]
        [XmlArrayItem(Type = typeof(BTInputTagVar))]
        [XmlArrayItem(Type = typeof(BTInputTagBB))]
        public BTInputTag[] BranchTag { get; set; }

        [XmlArray(ElementName = "Tag")]
        [XmlArrayItem(Type = typeof(BTInputTag))]
        [XmlArrayItem(Type = typeof(BTInputTagValue))]
        [XmlArrayItem(Type = typeof(BTInputTagVar))]
        [XmlArrayItem(Type = typeof(BTInputTagBB))]
        public BTInputTag[] Tag { get; set; }

        [XmlArray(ElementName = "EntityId")]
        [XmlArrayItem(Type = typeof(BTInputEntityId))]
        [XmlArrayItem(Type = typeof(BTInputEntityIdVar))]
        [XmlArrayItem(Type = typeof(BTInputEntityIdBB))]
        public BTInputEntityId[] EntityId { get; set; }

    }
}
