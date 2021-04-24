using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Project2.Models
{
    public class PriceSession
    {
        private const string PriceKey = "price";

        private ISession session { get; set; }

        public PriceSession(ISession session)
        {
            this.session = session;
        }

        public void SetPrice(Price price)
        {
            session.SetObject<Price>(PriceKey, price);
        }

        public Price GetPrice() => session.GetObject<Price>(PriceKey);
    }
}
