using System;

/// <summary> Base Class to be inherited from </summary>
public class BaseClass
{
    /// <summary> ID of object </summary>
    public string id { get; set; }
    /// <summary> Creation datetime of object </summary>
    public DateTime date_created { get; set; }
    /// <summary> last updated datetime of object </summary>
    public DateTime date_updated { get; set; }

    /// <summary> Base Class constructor </summary>
    public BaseClass() {
        this.id = System.Guid.NewGuid().ToString();
        this.date_created = DateTime.Now;
        this.date_updated = DateTime.Now;
    }
}
