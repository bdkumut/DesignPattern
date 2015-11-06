using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Harezmi.ChainOfResponsibility
{
    public class Talep
    {
        public decimal Tutar { get; private set; }
        public TalepStatus Status { get; private set; }
        public IMakam Makam { get; set; }

        public Talep(decimal tutar)
        {
            Tutar = tutar;
            Status = TalepStatus.ONAYDA;
        }

        public void Onayla()
        {
            Status = TalepStatus.ONAYLI;
        }

        public void Reddet()
        {
            Status = TalepStatus.REDLI;
        }
    }

    public enum TalepStatus
    {
        ONAYDA,
        ONAYLI,
        REDLI
    }
}
