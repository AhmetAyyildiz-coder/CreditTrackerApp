using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
	public class Payment : BaseEntity
	{
		public decimal Amount { get; set; } // ödeme miktarı 
		public int CreditId { get; set; } // kredi id 
		public Credit Credit { get; set; }
		public DateTime PaymentDate { get; set; } = DateTime.Now;// ödeme tarihi  
	}
}
