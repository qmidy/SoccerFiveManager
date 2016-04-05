using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CommonLibrary
{
    public interface ICampaign
    {
        [XmlElement]
        string Name { get; set; }

        [XmlElement]
        string Description { get; set; }
    }
}
