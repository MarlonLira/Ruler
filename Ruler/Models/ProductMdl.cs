using System;
using System.ComponentModel;

namespace Ruler.Models {
    public class ProductMdl {

        [DisplayName("Nome")]
        public String Name { get; set; }

        [DisplayName("Quantidade")]
        public Int32 Amount { get; set; }

        [DisplayName("Tipo")]
        public String Type { get; set; }

        [DisplayName("Grupo")]
        public ProductGroupMdl Group { get; set; }

    }
}