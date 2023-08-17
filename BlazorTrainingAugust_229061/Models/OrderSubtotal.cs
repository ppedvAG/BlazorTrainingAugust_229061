using System;
using System.Collections.Generic;

namespace BlazorTrainingAugust_229061.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
