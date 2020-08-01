using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class RatesModel
    {
        public double CAD { get; set; }
        public double HKD { get; set; }
        public double ISK { get; set; }
        public double PHP { get; set; }
        public double DKK { get; set; }
        public double HUF { get; set; }
        public double CZK { get; set; }
        public double AUD { get; set; }
        public double RON { get; set; }
        public double SEK { get; set; }
        public double IDR { get; set; }
        public double INR { get; set; }
        public double BRL { get; set; }
        public double RUB { get; set; }
        public double HRK { get; set; }
        public double JPY { get; set; }
        public double THB { get; set; }
        public double CHF { get; set; }
        public double SGD { get; set; }
        public double PLN { get; set; }
        public double BGN { get; set; }
        public double TRY { get; set; }
        public double CNY { get; set; }
        public double NOK { get; set; }
        public double NZD { get; set; }
        public double ZAR { get; set; }
        public double USD { get; set; }
        public double MXN { get; set; }
        public double ILS { get; set; }
        public double GBP { get; set; }
        public double KRW { get; set; }
        public double MYR { get; set; }

        public double FindCurrency(string str)
        {

            if(str == "CAD")
            {
                return this.CAD;
            }
            if (str == "HKD")
            {
                return this.HKD;
            }
            if (str == "ISK")
            {
                return this.ISK;
            }
            if (str == "PHP")
            {
                return this.PHP;
            }
            if (str == "DKK")
            {
                return this.DKK;
            }
            if (str == "HUF")
            {
                return this.HUF;
            }
            if (str == "CZK")
            {
                return this.CZK;
            }
            if (str == "AUD")
            {
                return this.AUD;
            }
            if (str == "RON")
            {
                return this.RON;
            }
            if (str == "SEK")
            {
                return this.SEK;
            }
            if (str == "IDR")
            {
                return this.IDR;
            }
            if (str == "INR")
            {
                return this.INR;
            }
            if (str == "BRL")
            {
                return this.BRL;
            }
            if (str == "RUB")
            {
                return this.RUB;
            }
            if (str == "HRK")
            {
                return this.HRK;
            }
            if (str == "JPY")
            {
                return this.JPY;
            }
            if (str == "THB")
            {
                return this.THB;
            }
            if (str == "CHF")
            {
                return this.CHF;
            }
            if (str == "SGD")
            {
                return this.SGD;
            }
            if (str == "PLN")
            {
                return this.PLN;
            }
            if (str == "BGN")
            {
                return this.BGN;
            }
            if (str == "TRY")
            {
                return this.TRY;
            }
            if (str == "CNY")
            {
                return this.CNY;
            }
            if (str == "NOK")
            {
                return this.NOK;
            }
            if (str == "NZD")
            {
                return this.NZD;
            }
            if (str == "ZAR")
            {
                return this.ZAR;
            }
            if (str == "USD")
            {
                return this.USD;
            }
            if (str == "MXN")
            {
                return this.MXN;
            }
            if (str == "ILS")
            {
                return this.ILS;
            }
            if (str == "GBP")
            {
                return this.GBP;
            }
            if (str == "KRW")
            {
                return this.KRW;
            }
            return -1;
        }
    }
}
