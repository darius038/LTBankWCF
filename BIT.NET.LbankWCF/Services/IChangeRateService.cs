﻿using BIT.NET.LbankWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BIT.NET.LbankWCF.Services
{
    public interface IChangeRateService
    {
        Task<List<CurrencyItemDTO>> ChangeCalc(string date);
    }
}
