using Volo.Abp;

namespace Acme.BookStore.Authors
{
    public class BirthayMustBeBeforeNowException: BusinessException
    {
        public BirthayMustBeBeforeNowException()
            : base(BookStoreDomainErrorCodes.BirthayMustBeBeforeNow)
        {
     
        }
    }
}