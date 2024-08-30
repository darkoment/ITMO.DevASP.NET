using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCreditApp1.Models
{
    public class Bid
    {
        //ID Заявки
        public virtual int BidId { get; set; }
        //Имя заявителя
        public virtual string Name { get; set; }
        //Название кредита
        public virtual string CreditHead { get; set; }
        //Дата получения заявки
        public virtual DateTime BidDate { get; set; }
    }
}