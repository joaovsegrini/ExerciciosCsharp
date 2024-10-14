using Enum.Entities;
using Enum.Entities.Enums;
using System;

Order order = new Order
{
    id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PedingPayment
};

Console.WriteLine(order);

String txt = OrderStatus.PedingPayment.ToString();

Console.WriteLine(txt);