//Module contain funcions used to calculate the charge amount for each Customer type
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_bill
{
    public static class Calcul_functions
    {
        const decimal BASE_RESIDENTIAL = 6m;//flate rate of 6
        const decimal BASE_COMMERCIAL = 60m;//flat rate of 60 for the first 1000kwh
        const decimal FRPH_INDUSTRIAL = 76m;//flat rate peak hours for first 1000kwh
        const decimal FROFFPH_INDUSTRIAL = 40m;//flat rate Off peak hours for first 1000kwh
        const decimal RATE_RESIDENTIAL = 0.052m;//rate for residential by kwh
        const decimal RATE_COMMERCIAL = 0.045m;//rate for commercial by kwh
        const decimal RATEPH_INDUSTRIAL = 0.065m;//rate for industrial by kwh on peak hours
        const decimal RATEOFFPH_INDUSTRIAL = 0.028m;//rate for industrial by kwh on off peak hours

        
        /// <summary>
        /// calculate charge Amount for residential 
        /// </summary>
        /// <param name="kwh"> kwh consumed </param>
        /// <returns>Amount</returns>
        public static Decimal GetAmount_Residential(decimal kwh)
        {
            return BASE_RESIDENTIAL + (kwh * RATE_RESIDENTIAL);

        }
        /// <summary>
        /// calculate charge Amount for Commercial
        /// </summary>
        /// <param name="kwh"> kwh consumed </param>
        /// <returns>Amount</returns>
        public static Decimal GetAmount_Commercial(decimal kwh)
        {
            decimal amount = BASE_COMMERCIAL;//contain cost for a commercial customer
            if (kwh > 1000)
            {
                amount = amount + ((kwh - 1000) * RATE_COMMERCIAL);
            }
            return amount;
        }
        /// <summary>
        /// calculate charge Amount for KWH consumed on Peak hours  
        /// </summary>
        /// <param name="PHkwh">Peak hours kwh consumed </param>
        /// <returns>Amount</returns>
        public static Decimal GetAmount_Industrial_PeakHours(decimal PHkwh)
        {
            decimal amount = FRPH_INDUSTRIAL;//contain cost for a Indutrial customer On Peak hours
            if (PHkwh > 1000)
            {
                amount = amount + ((PHkwh - 1000) * RATEPH_INDUSTRIAL);
            }
            return amount;
        }

       

        /// <summary>
        /// calculate charge Amount for KWH consumed on off Peak hours  
        /// </summary>
        /// <param name="OffPHkwh">Off Peak hours kwh consumed </param>
        /// <returns>Amount</returns>
        public static Decimal GetAmount_Industrial_OffPeakHours(decimal OffPHkwh)
        {
            decimal amount = FROFFPH_INDUSTRIAL;//contain cost for a Indutrial customer On Off Peak hours
            if (OffPHkwh > 1000)
            {
                amount = amount + ((OffPHkwh - 1000) * RATEOFFPH_INDUSTRIAL);
            }
            return amount;
        }
        /// <summary>
        /// calculate total charge Amount for Industrial   
        /// </summary>
        /// <param name="OffPHkwh">Off Peak hours kwh consumed </param>
        /// <param name="PHkwh">Peak hours kwh consumed </param>
        /// <returns>Amount</returns>
        public static Decimal GettotalAmount_Industrial(decimal OffPHkwh, decimal PHkwh)
        {
            //amount will contain a total amount for an Industrial customer
            decimal amount = GetAmount_Industrial_PeakHours(PHkwh) + GetAmount_Industrial_OffPeakHours(OffPHkwh);
            return amount;
        }
    }
}
