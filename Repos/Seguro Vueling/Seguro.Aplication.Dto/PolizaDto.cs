using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguro.Aplication.Dto
{
    public class PolizaDto
    {
        public int Id { get; set; }
        public double AmountInsured { get; set; }
        public string Email { get; set; }
        public DateTime InceptionDate { get; set; }
        public bool InstallmentPayment { get; set; }
        public int ClientId { get; set; }

        public PolizaDto() { }
        public PolizaDto(int Id, double AmountInsured, string email, string Email, DateTime InceptionDate, bool InstallmentPayment, int ClientId)
        {
            this.Id = Id;
            this.AmountInsured = AmountInsured;
            this.InceptionDate = InceptionDate;
            this.InstallmentPayment = InstallmentPayment;
            this.ClientId = ClientId;
        }
    }
}
