﻿using BussinessLayer.Interface;
using CommonLayer.PostModel;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Service
{
    public class OrderBL : IOrderBL
    {
        IOrderRL orderRL;

        public OrderBL(IOrderRL orderRL)
        {
            this.orderRL = orderRL;
        }

        public string AddOrder(OrderPostModel orderPost)
        {
            try
            {
                return orderRL.AddOrder(orderPost);

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public List<OrderModel> OrderBooks(int userId)
        {
            try
            {
                return orderRL.OrderBooks(userId);

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
