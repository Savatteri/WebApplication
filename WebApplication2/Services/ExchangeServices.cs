using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Repositories;

namespace WebApplication2.Services
{
    public class ExchangeServices
    {

        public async Task<RatesModel> GetCurrenciesAsync(string baseCurrency)
        {
            //Initialize the mapper
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<CurrencyModel, CurrencyModelPrivate>()
                );
            var mapper = new Mapper(config);
            ExchangeRepository responseObjGet = new ExchangeRepository();
            //i'll obtain a CurrencyModel responde
            var response = await responseObjGet.GetRequestLatestAsync(baseCurrency);
            //mapping between CurrencyModel and RatesModelAPI
            var ratesresponde = mapper.Map<CurrencyModel, CurrencyModelPrivate>(response);
            return ratesresponde.Rates;
        }

        public async Task<RatesModel> GetHistoryAsync(int days)
        {
            ExchangeRepository responseObjGet = new ExchangeRepository();
            //Initialize the mapper
            var config = new MapperConfiguration(cfg =>
                    cfg.CreateMap<CurrencyModel, CurrencyModelPrivate>()
                );
            var mapper = new Mapper(config);
            var response = await responseObjGet.GetHistoricsAsync(days);
            var ratesresponde = mapper.Map<CurrencyModel, CurrencyModelPrivate>(response);
            return ratesresponde.Rates;
        }
    }
}
