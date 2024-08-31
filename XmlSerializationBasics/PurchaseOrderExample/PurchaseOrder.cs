using System.Xml.Serialization;

namespace XmlSerializationBasics.PurchaseOrderExample;

[XmlRoot("purchase-order", Namespace = "http://www.cpandl.com/purchase-order")]
public class PurchaseOrder
{
    [XmlAttribute("ship-cost")]
    public decimal ShipCost { get; set; }

    [XmlAttribute("total-cost")]
    public decimal TotalCost { get; set; }

    [XmlElement("order-date")]
    public string? OrderDate { get; set; }

    [XmlElement("delivery-date")]
    public DeliveryDate? DeliveryDate { get; set; }

    [XmlElement("items")]
    public OrderedItem[]? OrderedItems { get; set; }

    [XmlElement("destination-address")]
    public Address? ShipTo { get; set; }

    [XmlIgnore]
    public decimal SubTotal { get; set; }

    public void CalculateSubTotal()
    {
        if (this.OrderedItems is not null)
        {
            decimal subTotal = 0;
            foreach (var item in this.OrderedItems)
            {
                subTotal += item.UnitPrice * item.Quantity;
            }

            this.SubTotal = subTotal;
        }
    }

    public void CalculateTotalCost()
    {
        this.TotalCost = this.SubTotal + this.ShipCost;
    }
}
