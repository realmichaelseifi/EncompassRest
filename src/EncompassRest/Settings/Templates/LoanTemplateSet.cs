namespace EncompassRest.Settings.Templates
{
    /// <summary>
    /// The Loan Template Set Apis.
    /// </summary>
    public interface ILoanTemplateSet : ITemplateApiObject
    {
    }

    /// <summary>
    /// The Loan Template Set Apis.
    /// </summary>
    public sealed class LoanTemplateSet : TemplateApiObject, ILoanTemplateSet
    {
        internal LoanTemplateSet(EncompassRestClient client)
            : base(client, "loanTemplateSet")
        {
        }
    }
}