using System.Xml.Serialization;

namespace XmlSerializationBasics.ComplexStructures;

[XmlRoot("book-price", Namespace = "http://contoso.com/book")]
public class BookPrice
{
    [XmlElement("price")]
    public decimal Price { get; set; }

    [XmlElement("currency")]
    public string? Currency { get; set; }
}
