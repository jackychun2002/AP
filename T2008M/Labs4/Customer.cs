﻿using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.Arm;

namespace T2008M.Labs4
{
    public abstract class Customer
    {
        public int id;
        public string name;
        public string dateTime;
        public int amount;
        public double total;

        public Customer(int id, string name, string dateTime, int amount, double total)
        {
            this.id = id;
            this.name = name;
            this.dateTime = dateTime;
            this.amount = amount;
            this.total = total;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string DateTime
        {
            get => dateTime;
            set => dateTime = value;
        }

        public int Amount
        {
            get => amount;
            set => amount = value;
        }

        public double Total
        {
            get => total;
            set => total = value;
        }

        public abstract double totalPrice();
    }
}