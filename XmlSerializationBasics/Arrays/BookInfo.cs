using System.Xml.Serialization;

[assembly: CLSCompliant(true)]

namespace XmlSerializationBasics.Arrays;

[XmlRoot("BookInfo")]
public class BookInfo
{
    [XmlArray("Titles", Order = 1)]
    [XmlArrayItem("Title")]
    public string[]? Titles { get; set; } = Array.Empty<string>();

    [XmlArray("Prices", Order = 5)]
    [XmlArrayItem("Price")]
    public decimal[] Prices { get; set; } = Array.Empty<decimal>();

    [XmlArray("Genres", Order = 2)]
    [XmlArrayItem("Genre")]
    public string[]? Genres { get; set; } = Array.Empty<string>();

    [XmlArray("Codes", Order = 4)]
    [XmlArrayItem("Code")]
    public string[]? Codes { get; set; } = Array.Empty<string>();

    [XmlArray("PublicationDates", Order = 3)]
    [XmlArrayItem("PublicationDate")]
    public string[]? PublicationDates { get; set; } = Array.Empty<string>();
}
