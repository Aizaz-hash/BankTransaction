using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace BankTransaction.Models
{
    public class Transaction
    {

        //primary key id
        [Key]
        public int TransactionId { get; set; }


        //accout number
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "Account Number is required ")]
        [MaxLength(12,ErrorMessage = "Account Number cannot be larger than 12 digits")]
        public string AccountNumber { get; set; }


        //benficery name
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "Beneficiary Name is required ")]
        [MaxLength(100,ErrorMessage = "Beneficiary Name length reached")]
        [MinLength(3, ErrorMessage = "Beneficiary Name should be atleast 3 alphabets")]

        public string BeneficiaryName { get; set; }


        //bank name
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "Bnk Name is required ")]
        [MaxLength(100, ErrorMessage = "Bank Name length reached")]
        [MinLength(3, ErrorMessage = "Bank Name should be atleast 3 alphabets")]
        public string BankName { get; set; }


        //swift code
        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "11 digit SWIFT Code is required ")]
        [MaxLength(11, ErrorMessage = "SWIFT Codecannot be larger than 11 digits")]
        [MinLength(11, ErrorMessage = "SWIFT Code cannot be smaller  than 11 digits")]
        public string SWIFFTCode { get; set; }


        //amount
        [Required(ErrorMessage = "Amount is required")]
        public decimal Amount { get; set; }


        //date
        [DisplayName("Account Opening Date")]
        [Required(ErrorMessage = "Date is required ")]
        [DisplayFormat(DataFormatString ="{0:MMM-dd-yyyy}")]
        public DateTime Date { get; set; }

    }
}
