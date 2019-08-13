using Newtonsoft.Json;
using System.ComponentModel;

namespace Entity
{
    public class OrderData : Order
    {
        [JsonProperty("invoice_no")]
        public int InvoiceNo { get; set; }
        [JsonProperty("invoice_prefix")]
        public string InvoicePrefix { get; set; }
        [JsonProperty("store")]
        public Store Store { get; set; }
        [JsonProperty("customer")]
        public new Customer Customer { get; set; }
        [JsonProperty("payment_custom_field")]
        public PaymentCustomField PaymentCustomField { get; set; }
        [JsonProperty("payment_address")]
        public Address PaymentAddress { get; set; }
        [JsonProperty("payment_method")]
        public PaymentMethod PaymentMethod { get; set; }
        [JsonProperty("shipping_address")]
        public Address ShippingAddress { get; set; }
        [JsonProperty("shipping_method")]
        public ShippingMethod ShippingMethod { get; set; }
        [JsonProperty("comment")]
        public string Comment { get; set; }
        [JsonProperty("reward")]
        public int Reward { get; set; }
        [JsonProperty("order_status_id")]
        public new int OrderStatus { get; set; }
        [JsonProperty("commission")]
        public double Commission { get; set; }
        [JsonProperty("currency")]
        public Currency Currency { get; set; }
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }
        [JsonProperty("order_total")]
        public BindingList<OrderTotal> OrderTotals { get; set; }
        [JsonProperty("order_products")]
        public BindingList<OrderProduct> Products { get; set; }
    }
}
