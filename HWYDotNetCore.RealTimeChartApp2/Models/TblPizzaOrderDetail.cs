﻿using System;
using System.Collections.Generic;

namespace HWYDotNetCore.RealTimeChartApp2.Models;

public partial class TblPizzaOrderDetail
{
    public int PizzaOrderDetailId { get; set; }

    public string PizzaOrderInvoiceNo { get; set; } = null!;

    public int PizzaExtraId { get; set; }
}
