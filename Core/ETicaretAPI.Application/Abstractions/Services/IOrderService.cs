﻿using ECommerce.Application.DTOs.Order;

namespace ECommerce.Application.Abstractions.Services;

public interface IOrderService
{
    Task CreateOrderAsync(CreateOrder createOrder);
    Task<ListOrder> GetAllOrdersAsync(int page, int size);
    Task<SingleOrder> GetOrderByIdAsync(string id);
    Task<(bool, CompletedOrderDTO)> CompleteOrderAsync(string id);
}
