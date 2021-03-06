﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HoloXPLOR.Data.Xml.Inventory
{
    [XmlRoot(ElementName = "rooms")]
    public class RoomCollection : XmlCollection<Room>
    {
        [XmlElement(ElementName = "room")]
        public override Room[] Items { get; set; }
    }
}