using System.Xml.Serialization;

namespace XmlSerializationBasics.Sequence;

[XmlRoot("BookInfo")]
public class BookInfo
{
    [XmlElement("title")]
    public string[] Titles { get; set; }

    [XmlElement("price")]
    public decimal[] Prices { get; set; }

    [XmlElement("genre")]
    public string[] Genres { get; set; }

    [XmlElement("international-standard-book-number")]
    public string[] Codes { get; set; }

    [XmlElement("publication-date")]
    public string[] PublicationDates { get; set; }
}
