using System.Xml.Serialization;

namespace XmlSerializationBasics.ComplexStructures;

[XmlRoot("book-publication-date", Namespace = "http://contoso.com/book")]
public class BookPublicationDate
{
    [XmlElement("day")]
    public int Day { get; set; }

    [XmlElement("month")]
    public int Month { get; set; }

    [XmlElement("year")]
    public int Year { get; set; }

    [XmlElement("first-publication")]
    public bool FirstPublication { get; set; }
}
