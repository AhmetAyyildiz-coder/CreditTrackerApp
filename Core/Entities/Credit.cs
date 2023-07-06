using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
	public class Credit  : BaseEntity
	{
		


		public string CreditName { get; set; }
		public string Statement { get; set; } // kredi açıklaması 
		public decimal CreditAmount { get; set; }// ödeme miktar
		public decimal TotalCreditAmount { get; set; } // faizli olarak toplam ödeme miktarı ( aylık ve yıllık faiz gibi iki ayrım var.) 
		public DateTime CreditStartDate { get; set; } // kredi ödeme başlangıç tarihi 
		public int InstallmentCount { get; set; }// taksit sayısı
		public List<Payment> Payments { get; set; } // krediye ait ödemeler 
		public string AppUserId { get; set; } // bu kredi hangi kullanıcıya ait 1-n ilişki 
		public AppUser AppUser { get; set; }
	}
}
