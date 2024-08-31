using System.Xml.Serialization;

namespace XmlSerializationBasics.ComplexStructures;

[XmlRoot("book-title")]
public class BookTitle
{
    [XmlElement("text")]
    public string? Title { get; set; }

    [XmlAttribute("language")]
    public string? Language { get; set; }
}
