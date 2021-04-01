using System;

/// <summary> Inventory Class </summary>
public class Inventory : BaseClass
{
    /// <summary> User ID from user object </summary>
    public string user_id { get; set; }
    /// <summary> Item ID from item object </summary>
    public string item_id { get; set; }
    /// <summary> Quantity of item </summary>
    public int quantity {get; set; }
    /// <summary> Inventory constructor </summary>
    public Inventory(string user_id, string item_id, int quantity=1) {
        this.user_id = user_id;
        this.item_id = item_id;
        if (quantity > 0)
            this.quantity = quantity;
        else
            this.quantity = 1;
    }
}
