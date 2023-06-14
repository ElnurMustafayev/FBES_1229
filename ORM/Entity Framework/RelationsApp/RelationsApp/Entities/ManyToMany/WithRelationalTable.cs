namespace RelationsApp.Entities.ManyToMany {
    public class Product {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductTag> ProductTags { get; }

        public Product(string name) {
            Name = name;
        }

        public Product() {

        }
    }

    public class Tag {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductTag> ProductTags { get; }

        public Tag(string name) {
            Name = name;
        }

        public Tag() {

        }
    }

    public class ProductTag {
        //public Guid Id { get; set; }
        public int ProductId { get; set; }
        public int TagId { get; set; }
        public Product Product { get; set; }
        public Tag Tag { get; set; }
    }
}
