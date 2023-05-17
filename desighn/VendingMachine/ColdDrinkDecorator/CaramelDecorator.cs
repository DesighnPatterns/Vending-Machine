﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.ColdDrinkDecorator
{
    public class CaramelDecorator : IceCoffeeDecorator
    {
        public CaramelDecorator(IceCoffee ice_Coffee):base(ice_Coffee) { }
        public override int GetCost()
        {
            return base.GetCost()+1;
        }
    }
}
