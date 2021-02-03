using SQLite;
using System;

namespace Mine.Models
{
    /// <summary>
    /// Items for characters and monsters to use
    /// </summary>
    public class ItemModel
    {   
        //id for item
        [PrimaryKey]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Text { get; set; }
        public string Description { get; set; }

        //The Value of the item +9 damange
        public int Value { get; set; } = 0;
    }
}