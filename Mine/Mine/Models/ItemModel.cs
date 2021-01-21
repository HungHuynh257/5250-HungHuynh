﻿using System;

namespace Mine.Models
{
    public class ItemModel
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        //The Value of the item +9 damange
        public int Value { get; set; } = 0;
    }
}