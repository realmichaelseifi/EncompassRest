using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EncompassRest.Utilities;

namespace EncompassRest.Loans.Associates
{
    /// <summary>
    /// The Loan Associates Apis.
    /// </summary>
    public interface ILoanAssociates : ILoanApiObject
    {
        /// <summary>
        /// Assigns a loan associate to a milestone based on the specified milestone or milestone-free ID and log ID.
        /// </summary>
        /// <param name="logId">The milestone or milestone-free log ID.</param>
        /// <param name="associate">The loan associate to assign.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task AssignAssociateAsync(string logId, LoanAssociate associate, CancellationToken cancellationToken = default);
        /// <summary>
        /// Assigns a loan associate to a milestone based on the specified milestone or milestone-free ID and log ID from raw json.
        /// </summary>
        /// <param name="logId">The milestone or milestone-free log ID.</param>
        /// <param name="associate">The loan associate to assign as raw json.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task AssignAssociateRawAsync(string logId, string associate, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves information about a loan associate based on the milestone or milestone-free role ID. The response includes the associate's role and contact information.
        /// </summary>
        /// <param name="logId">The milestone or milestone-free log ID.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<LoanAssociate> GetAssociateAsync(string logId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves information about a loan associate based on the milestone or milestone-free role ID as raw json.
        /// </summary>
        /// <param name="logId">The milestone or milestone-free log ID.</param>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetAssociateRawAsync(string logId, string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a list of loan associates involved with the loan. The response includes role and contact information for each loan associate.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<LoanAssociate>> GetAssociatesAsync(CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a list of loan associates involved with the loan. The response includes role and contact information for each loan associate.
        /// </summary>
        /// <param name="userId">When provided, returns information about the Encompass user associated with the loan.</param>
        /// <param name="roleId">When provided, returns information about all Encompass users associated with the specified role ID.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<List<LoanAssociate>> GetAssociatesAsync(string? userId, string? roleId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a list of loan associates involved with the loan as raw json.
        /// </summary>
        /// <param name="queryString">The query string to include in the request.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<string> GetAssociatesRawAsync(string? queryString = null, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unassigns a loan associate from a milestone based on the specified milestone or milestone-free ID.
        /// </summary>
        /// <param name="logId">The milestone or milestone-free log ID.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task<bool> TryUnassignAssociateAsync(string logId, CancellationToken cancellationToken = default);
        /// <summary>
        /// Unassigns a loan associate from a milestone based on the specified milestone or milestone-free ID.
        /// </summary>
        /// <param name="logId">The milestone or milestone-free log ID.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="CancellationToken.None"/>.</param>
        /// <returns></returns>
        Task UnassignAssociateAsync(string logId, CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The Loan Associates Apis.
    /// </summary>
    public sealed class LoanAssociates : LoanApiObject, ILoanAssociates
    {
        internal LoanAssociates(EncompassRestClient client, string loanId)
            : base(client, loanId, "associates")
        {
        }

        /// <inheritdoc/>
        public Task<List<LoanAssociate>> GetAssociatesAsync(CancellationToken cancellationToken = default) => GetAssociatesAsync(null, null, cancellationToken);

        /// <inheritdoc/>
        public Task<List<LoanAssociate>> GetAssociatesAsync(string? userId, string? roleId, CancellationToken cancellationToken = default)
        {
            var queryParameters = new QueryParameters();
            if (!string.IsNullOrEmpty(userId))
            {
                queryParameters.Add("userId", userId);
            }
            if (!string.IsNullOrEmpty(roleId))
            {
                queryParameters.Add("roleId", roleId);
            }

            return GetDirtyListAsync<LoanAssociate>(null, queryParameters.ToString(), nameof(GetAssociatesAsync), null, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> GetAssociatesRawAsync(string? queryString = null, CancellationToken cancellationToken = default) => GetRawAsync(null, queryString, nameof(GetAssociatesRawAsync), null, cancellationToken);

        /// <inheritdoc/>
        public Task<LoanAssociate> GetAssociateAsync(string logId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetAsync<LoanAssociate>(logId, null, nameof(GetAssociateAsync), logId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<string> GetAssociateRawAsync(string logId, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return GetRawAsync(logId, queryString, nameof(GetAssociateRawAsync), logId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task AssignAssociateAsync(string logId, LoanAssociate associate, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));
            Preconditions.NotNull(associate, nameof(associate));
            Preconditions.NotNullOrEmpty(associate.Id, $"{nameof(associate)}.{nameof(associate.Id)}");
            Preconditions.NotNullOrEmpty(associate.LoanAssociateType.Value, $"{nameof(associate)}.{nameof(associate.LoanAssociateType)}");

            return PutAsync(logId, null, JsonStreamContent.Create(associate), nameof(AssignAssociateAsync), logId, cancellationToken);
        }

        /// <inheritdoc/>
        public Task AssignAssociateRawAsync(string logId, string associate, string? queryString = null, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));
            Preconditions.NotNullOrEmpty(associate, nameof(associate));

            return PutAsync(logId, queryString, new JsonStringContent(associate), nameof(AssignAssociateRawAsync), logId, cancellationToken);
        }

        /// <inheritdoc/>
        [Obsolete("Undocumented API")]
        public Task<bool> TryUnassignAssociateAsync(string logId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return TryDeleteAsync(logId, null, cancellationToken);
        }

        /// <inheritdoc/>
        [Obsolete("Undocumented API")]
        public Task UnassignAssociateAsync(string logId, CancellationToken cancellationToken = default)
        {
            Preconditions.NotNullOrEmpty(logId, nameof(logId));

            return DeleteAsync(logId, null, cancellationToken);
        }
    }
}