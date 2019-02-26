using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models {
    /// <summary>A model for the TodoItem</summary> 
    public class TodoItem {

        /// <summary>Id of the item</summary>
        public long Id { get; set; }

        /// <summary>Name of the Todo Item</summary>
        [Required]
        public string Name { get; set; }

        /// <summary>Boolean representing if the item has been completed or not</summary>
        [DefaultValue (false)]
        public bool IsComplete { get; set; }
    }
}