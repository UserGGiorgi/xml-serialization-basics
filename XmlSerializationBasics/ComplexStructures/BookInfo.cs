using System.Xml.Serialization;

namespace XmlSerializationBasics.ComplexStructures;

[XmlRoot("book-info", Namespace = "http://contoso.com/book")]
public class BookInfo
{
    [XmlAttribute("title")]
    public BookTitle? Title { get; set; }

    [XmlAttribute("price")]
    public BookPrice? Price { get; set; }

    [XmlAttribute("genre")]
    public string? Genre { get; set; }

    [XmlAttribute("isbn")]
    public string? Isbn { get; set; }

    [XmlAttribute("publication-date")]
    public BookPublicationDate? PublicationDate { get; set; }
}
