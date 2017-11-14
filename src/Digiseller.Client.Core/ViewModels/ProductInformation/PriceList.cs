using Digiseller.Client.Core.Interfaces.ProductInformation;
using Digiseller.Client.Core.Models.ProductInformation.Response;

namespace Digiseller.Client.Core.ViewModels.ProductInformation
{
    public class PriceList : IPriceList
    {
        public decimal Wmz { get; }
        public decimal Wmr { get; }
        public decimal Wme { get; }
        public decimal Wmu { get; }
        public decimal Wmx { get; }
        public decimal Rcc { get; }
        public decimal Zcc { get; }
        public decimal Ecc { get; }
        public decimal Mts { get; }
        public decimal Bln { get; }
        public decimal Mgf { get; }
        public decimal Tl2 { get; }
        public decimal Pcr { get; }
        public decimal Mrr { get; }
        public decimal Qsr { get; }
        public decimal Atm { get; }
        public decimal Rub { get; }
        public decimal Bnk { get; }

        public PriceList(Prices prices)
        {
            Wmz = prices.Wmz;
            Wmr = prices.Wmr;
            Wme = prices.Wme;
            Wmu = prices.Wmu;
            Wmx = prices.Wmx;
            Rcc = prices.Rcc;
            Zcc = prices.Zcc;
            Ecc = prices.Ecc;
            Mts = prices.Mts;
            Bln = prices.Bln;
            Mgf = prices.Mgf;
            Tl2 = prices.Tl2;
            Pcr = prices.Pcr;
            Mrr = prices.Mrr;
            Qsr = prices.Qsr;
            Atm = prices.Atm;
            Rub = prices.Rub;
            Bnk = prices.Bnk;
        }
    }
}
