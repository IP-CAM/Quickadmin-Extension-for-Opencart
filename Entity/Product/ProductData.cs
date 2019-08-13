using Entity.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Entity
{
    public class ProductData : Product
    {
        [JsonProperty("sku")]
        public string SKU { get; set; }
        [JsonProperty("upc")]
        public string UPC { get; set; }
        [JsonProperty("ean")]
        public string EAN { get; set; }
        [JsonProperty("jan")]
        public string JAN { get; set; }
        [JsonProperty("isbn")]
        public string ISBN { get; set; }
        [JsonProperty("mpn")]
        public string MPN { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
        [JsonProperty("stock_status_id")]
        public int StockStatusID { get; set; }
        [JsonProperty("manufacturer_id")]
        public int ManufacturerID { get; set; }
        [JsonProperty("shipping"), JsonConverter(typeof(BoolConverter))]
        public bool Shipping { get; set; }
        [JsonProperty("points")]
        public int Points { get; set; }
        [JsonProperty("tax_class_id")]
        public int TaxClassID { get; set; }
        [JsonProperty("date_available")]
        public DateTime DateAvailable { get; set; }
        [JsonProperty("weight")]
        public double Weight { get; set; }
        [JsonProperty("weight_class_id")]
        public int WeightClassID { get; set; }
        [JsonProperty("length")]
        public double Length { get; set; }
        [JsonProperty("width")]
        public double Width { get; set; }
        [JsonProperty("height")]
        public double Height { get; set; }
        [JsonProperty("length_class_id")]
        public int LengthClassID { get; set; }
        [JsonProperty("subtract"), JsonConverter(typeof(BoolConverter))]
        public bool Subtract { get; set; }
        [JsonProperty("minimum")]
        public int Minimum { get; set; }
        [JsonProperty("sort_order")]
        public int SortOrder { get; set; }
        [JsonProperty("viewed")]
        public int Viewed { get; set; }
        [JsonProperty("date_added"), JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime DateAdded { get; set; }
        [JsonProperty("date_modified"), JsonConverter(typeof(Converters.DateTimeConverter))]
        public DateTime DateModified { get; set; }
        [JsonProperty("product_category")]
        public IList<int> Categories { get; set;  }
        [JsonProperty("product_image")]
        public IList<ProductImage> Images { get; set; }
        [JsonProperty("product_store")]
        public IList<int> Stores { get; set; }
        [JsonProperty("product_layout")]
        public IList<int> Layouts { get; set; }
        [JsonProperty("product_related")]
        public IList<int> RelatedProducts { get; set; }
        [JsonProperty("product_special")]
        public BindingList<SpecialOffer> Specials { get; set; }
        [JsonProperty("product_discount")]
        public BindingList<Discount> Discounts { get; set; }
        [JsonProperty("product_description")]
        public IDictionary<int, Description> Descriptions { get; set; }
        [JsonProperty("image")]
        public new ProductImage Image { get; set; }
    }
}
