using System.Xml.Serialization;

namespace XmlSerializationBasics.PurchaseOrderExample;

[XmlRoot("delivery-date", Namespace = "http://www.cpandl.com/delivery-date")]
public class DeliveryDate
{
    [XmlAttribute("month")]
    public int DeliveryMonth { get; set; }

    [XmlAttribute("day")]
    public int DeliveryDay { get; set; }

    [XmlElement("year")]
    public int DeliveryYear { get; set; }
}
