// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SFA.DAS.RAA.Api.Client.V1
{
    using System.Threading.Tasks;
   using Models;

    /// <summary>
    /// Extension methods for ApiClient.
    /// </summary>
    public static partial class ApiClientExtensions
    {
            /// <summary>
            /// Endpoint for linking an employer to a provider site.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='employerProviderSiteLinkRequest'>
            /// Defines the provider site to link to as well as additional employer
            /// information. Note that you can specify the employer identifier in either
            /// the URL or the POST body
            /// </param>
            /// <param name='edsUrn'>
            /// The employer's secondary identifier.
            /// </param>
            public static EmployerProviderSiteLink LinkEmployer(this IApiClient operations, EmployerProviderSiteLinkRequest employerProviderSiteLinkRequest, int edsUrn)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApiClient)s).LinkEmployerAsync(employerProviderSiteLinkRequest, edsUrn), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Endpoint for linking an employer to a provider site.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='employerProviderSiteLinkRequest'>
            /// Defines the provider site to link to as well as additional employer
            /// information. Note that you can specify the employer identifier in either
            /// the URL or the POST body
            /// </param>
            /// <param name='edsUrn'>
            /// The employer's secondary identifier.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<EmployerProviderSiteLink> LinkEmployerAsync(this IApiClient operations, EmployerProviderSiteLinkRequest employerProviderSiteLinkRequest, int edsUrn, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.LinkEmployerWithHttpMessagesAsync(employerProviderSiteLinkRequest, edsUrn, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vacancyId'>
            /// </param>
            /// <param name='vacancyReferenceNumber'>
            /// </param>
            /// <param name='vacancyGuid'>
            /// </param>
            public static Vacancy GetVacancy(this IApiClient operations, int? vacancyId = default(int?), int? vacancyReferenceNumber = default(int?), System.Guid? vacancyGuid = default(System.Guid?))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApiClient)s).GetVacancyAsync(vacancyId, vacancyReferenceNumber, vacancyGuid), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vacancyId'>
            /// </param>
            /// <param name='vacancyReferenceNumber'>
            /// </param>
            /// <param name='vacancyGuid'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Vacancy> GetVacancyAsync(this IApiClient operations, int? vacancyId = default(int?), int? vacancyReferenceNumber = default(int?), System.Guid? vacancyGuid = default(System.Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetVacancyWithHttpMessagesAsync(vacancyId, vacancyReferenceNumber, vacancyGuid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Endpoint for changing the wage of a Live or Closed vacancy. The wage can
            /// only be increased from its current level.
            /// You must supply either the vacancyId, vacancyReferenceNumber or
            /// vacancyGuid as query string parameters to identify the vacancy you would
            /// like to change.
            /// The API key used must be authorized to modify the vacancy
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='wageUpdate'>
            /// Defines the changes to be made to a vacancies wage
            /// </param>
            /// <param name='vacancyId'>
            /// The vacancies primary identifier
            /// </param>
            /// <param name='vacancyReferenceNumber'>
            /// The vacancies secondary reference number identifier
            /// </param>
            /// <param name='vacancyGuid'>
            /// The vacancies secondary GUID identifier
            /// </param>
            public static Vacancy EditVacancyWage(this IApiClient operations, WageUpdate wageUpdate, int? vacancyId = default(int?), int? vacancyReferenceNumber = default(int?), System.Guid? vacancyGuid = default(System.Guid?))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApiClient)s).EditVacancyWageAsync(wageUpdate, vacancyId, vacancyReferenceNumber, vacancyGuid), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Endpoint for changing the wage of a Live or Closed vacancy. The wage can
            /// only be increased from its current level.
            /// You must supply either the vacancyId, vacancyReferenceNumber or
            /// vacancyGuid as query string parameters to identify the vacancy you would
            /// like to change.
            /// The API key used must be authorized to modify the vacancy
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='wageUpdate'>
            /// Defines the changes to be made to a vacancies wage
            /// </param>
            /// <param name='vacancyId'>
            /// The vacancies primary identifier
            /// </param>
            /// <param name='vacancyReferenceNumber'>
            /// The vacancies secondary reference number identifier
            /// </param>
            /// <param name='vacancyGuid'>
            /// The vacancies secondary GUID identifier
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Vacancy> EditVacancyWageAsync(this IApiClient operations, WageUpdate wageUpdate, int? vacancyId = default(int?), int? vacancyReferenceNumber = default(int?), System.Guid? vacancyGuid = default(System.Guid?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.EditVacancyWageWithHttpMessagesAsync(wageUpdate, vacancyId, vacancyReferenceNumber, vacancyGuid, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filterType'>
            /// Possible values include: 'All', 'Live', 'Submitted', 'Rejected',
            /// 'ClosingSoon', 'Closed', 'Draft', 'NewApplications', 'Withdrawn',
            /// 'Completed', 'SubmittedToday', 'SubmittedYesterday',
            /// 'SubmittedMoreThan48Hours', 'Resubmitted'
            /// </param>
            /// <param name='page'>
            /// </param>
            public static System.Collections.Generic.IList<VacancySummary> GetAll(this IApiClient operations, string filterType = default(string), int? page = default(int?))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IApiClient)s).GetAllAsync(filterType, page), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filterType'>
            /// Possible values include: 'All', 'Live', 'Submitted', 'Rejected',
            /// 'ClosingSoon', 'Closed', 'Draft', 'NewApplications', 'Withdrawn',
            /// 'Completed', 'SubmittedToday', 'SubmittedYesterday',
            /// 'SubmittedMoreThan48Hours', 'Resubmitted'
            /// </param>
            /// <param name='page'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<VacancySummary>> GetAllAsync(this IApiClient operations, string filterType = default(string), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetAllWithHttpMessagesAsync(filterType, page, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}