using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.FilterJson
{
    
    public class Address
    {
        public string AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public object Address3 { get; set; }
        public string BuildingName { get; set; }
        public object City { get; set; }
        public object State { get; set; }
        public string Zip5 { get; set; }
        public string Zip4 { get; set; }
        public object IsAddressActive { get; set; }
        public object CountryCode { get; set; }
        public string PostalCode { get; set; }
        public object County { get; set; }
        public string Chome { get; set; }
        public string Banchi { get; set; }
        public string Gou { get; set; }
        public string BuildingNumber { get; set; }
        public string RoomNumber { get; set; }
    }

    public class AuthorizedContact
    {
        public string ContactId { get; set; }
        public object? ContactTypeId { get; set; }
        public string EnrollmentContactCustomerId { get; set; }
        public object EnrollmentServiceAccountId { get; set; }
        public object EnrollmentBillingAccountId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNameKana { get; set; }
        public string PersonInChargeFirstName { get; set; }
        public object PersonInChargeLasttName { get; set; }
        public string PersonInChargeFirstNameKana { get; set; }
        public object PersonInChargeLasttNameKana { get; set; }
        public string DepartmentName { get; set; }
        public string ContactName { get; set; }
        public string ContactNameKana { get; set; }
        public object DateOfBirth { get; set; }
        public object IsAuthorizedContactActive { get; set; }
        public bool IsAuthorizedContactPrimary { get; set; }
        public string ContactTypeCode { get; set; }
        public object OtherContact { get; set; }
        public bool IsDoNotEmail { get; set; }
        public Address Address { get; set; }
        public List<EmailList> EmailList { get; set; }
        public List<PhoneList> PhoneList { get; set; }
    }

    public class AuthorizedContact3
    {
        public string ContactId { get; set; }
        public object ContactTypeId { get; set; }
        public object EnrollmentContactCustomerId { get; set; }
        public object EnrollmentServiceAccountId { get; set; }
        public object EnrollmentBillingAccountId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNameKana { get; set; }
        public string PersonInChargeFirstName { get; set; }
        public object PersonInChargeLasttName { get; set; }
        public string PersonInChargeFirstNameKana { get; set; }
        public object PersonInChargeLasttNameKana { get; set; }
        public string DepartmentName { get; set; }
        public string ContactName { get; set; }
        public string ContactNameKana { get; set; }
        public object DateOfBirth { get; set; }
        public object IsAuthorizedContactActive { get; set; }
        public bool IsAuthorizedContactPrimary { get; set; }
        public string ContactTypeCode { get; set; }
        public object OtherContact { get; set; }
        public bool IsDoNotEmail { get; set; }
        public Address Address { get; set; }
        public List<EmailList> EmailList { get; set; }
        public List<PhoneList> PhoneList { get; set; }
    }

    public class BaseInputPartialSupply
    {
        public object BaseContractDemand { get; set; }
        public string CurrentRetailerName { get; set; }
        public object CurrentRetailerNameDirectInput { get; set; }
    }

    public class BillingAccount
    {
        public string BillingAccountConfirmationCode { get; set; }
        public List<AuthorizedContact> AuthorizedContact { get; set; }
        public MailingAddress MailingAddress { get; set; }
        public List<ServiceAccount> ServiceAccounts { get; set; }
        public object AutoRechargeConfigs { get; set; }
        public List<PaymentDetail> PaymentDetails { get; set; }
        public object Deposit { get; set; }
        public object BillingMethod { get; set; }
    }

    public class ContractAutomaticRenewalCategory
    {
        public string Estimate { get; set; }
        public string TaxRate { get; set; }
        public object ContractStartDate { get; set; }
        public object ContractEndDate { get; set; }
        public object ContractChangeDate { get; set; }
    }

    public class CurrentRetailerInformation
    {
        public string OldInvoiceName { get; set; }
        public string Supply { get; set; }
        public object Contracts { get; set; }
        public string CurrentRetailerName { get; set; }
        public string CurrentRetailerNameDirectInput { get; set; }
        public BaseInputPartialSupply BaseInputPartialSupply { get; set; }
        public object CurrentCustomerNumber { get; set; }
    }

    public class EmailList
    {
        public string ContactEmailId { get; set; }
        public object ContactId { get; set; }
        public string EmailTypeCode { get; set; }
        public object IsContactEmailActive { get; set; }
        public bool IsDoNotEmail { get; set; }
        public bool IsContactEmailPrimary { get; set; }
        public object? EmailTypeId { get; set; }
        public string EmailAddress { get; set; }
    }

    public class EnergyCharge
    {
        public object GeneralUnitPrice { get; set; }
        public object WeekDayPrice { get; set; }
        public object WeekendPrice { get; set; }
        public object DayTimeUnitPrice { get; set; }
        public object NightTimeUnitPrice { get; set; }
        public object HolidayUnitPrice { get; set; }
        public object HeavyLoadUnitPrice { get; set; }
        public object PeakUnitPrice { get; set; }
        public object SummerSeasonUnitPrice { get; set; }
        public object SummerWeekdayUnitPrice { get; set; }
        public object SummerDayTimeUnitPrice { get; set; }
        public object SummerHolidayUnitPrice { get; set; }
        public object OtherSeasonUnitPrice { get; set; }
        public object OtherSeasonWeekdayUnitPrice { get; set; }
        public object OtherSeasonDayTimeUnitPrice { get; set; }
        public object OtherSeasonHolidayUnitPrice { get; set; }
    }

    public class EnrollmentAttributes
    {
        public object EnrollmentCustomerAttributeId { get; set; }
        public object EnrollmentAttributesCustomerId { get; set; }
        public object AttributeKey1 { get; set; }
        public object AttributeValue1 { get; set; }
        public object AttributeKey2 { get; set; }
        public object AttributeValue2 { get; set; }
        public object AttributeKey3 { get; set; }
        public object AttributeValue3 { get; set; }
        public object AttributeKey4 { get; set; }
        public object AttributeValue4 { get; set; }
        public object AttributeKey5 { get; set; }
        public object AttributeValue5 { get; set; }
        public bool IsEnrollmentAttributesActive { get; set; }
        public object CreatedByName { get; set; }
        public object CreateDate { get; set; }
        public object LastModifiedByName { get; set; }
        public object LastModifyDate { get; set; }
    }

    public class EnrollmentCustomer
    {
        public string EnrollmentCustomerId { get; set; }
        public string EnrollmentId { get; set; }
        public object CustomerTypeId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNameKana { get; set; }
        public object DBA { get; set; }
        public object TaxID { get; set; }
        public object BillTypeId { get; set; }
        public object BillFormatId { get; set; }
        public object LanguageId { get; set; }
        public object BillingAddressId { get; set; }
        public string CustomerCorrelationId { get; set; }
        public object ReferenceCustomerId { get; set; }
        public object InvoiceDeliveryMethod { get; set; }
        public object IsCustomerActive { get; set; }
        public object FirstName { get; set; }
        public object MiddleName { get; set; }
        public object LastName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNameKana { get; set; }
        public object BirthDate { get; set; }
        public object Last4SSN { get; set; }
        public object Suffix { get; set; }
        public object Prefix { get; set; }
        public object PaymentTermsOverride { get; set; }
        public object DeliveryTypeId { get; set; }
        public string CustomerTypeCode { get; set; }
        public object BillTypeCode { get; set; }
        public object BillFormatCode { get; set; }
        public string LanguageCode { get; set; }
        public object DeliveryTypeCode { get; set; }
        public object ReferenceCustomerNumber { get; set; }
        public object KanaName { get; set; }
        public string PaymentCategoryCode { get; set; }
        public bool IsMember { get; set; }
        public object MemberName { get; set; }
        public object MemberNumber { get; set; }
        public object ReferralCode { get; set; }
        public object FriendReferralCode { get; set; }
        public bool IsNewConstruction { get; set; }
        public string SalesChannelPartnerCode { get; set; }
        public object SalesAgencyCode { get; set; }
        public object Contract { get; set; }
        public List<AuthorizedContact> AuthorizedContact { get; set; }
        public List<BillingAccount> BillingAccounts { get; set; }
        public EnrollmentAttributes EnrollmentAttributes { get; set; }
    }

    public class EnviornmentMenu
    {
        public string Initiative { get; set; }
        public object EnviornmentalValue { get; set; }
        public string PowerConfiguration { get; set; }
        public string CertificateUsage { get; set; }
        public object RenewableEnergyRatio { get; set; }
        public string Contracts { get; set; }
        public object RenewableEnergySupplyStartDate { get; set; }
        public object RenewableEnergySupplyEndDate { get; set; }
    }

    public class MailingAddress
    {
        public object AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public object Address3 { get; set; }
        public string BuildingName { get; set; }
        public object City { get; set; }
        public object State { get; set; }
        public string Zip5 { get; set; }
        public string Zip4 { get; set; }
        public object IsAddressActive { get; set; }
        public object CountryCode { get; set; }
        public string PostalCode { get; set; }
        public object County { get; set; }
        public string Chome { get; set; }
        public string Banchi { get; set; }
        public string Gou { get; set; }
        public string BuildingNumber { get; set; }
        public string RoomNumber { get; set; }
    }

    public class MainContractInformation
    {
        public object Supply { get; set; }
        public object MeteringVoltage { get; set; }
        public string Category { get; set; }
        public string PartialSupplySelection { get; set; }
        public object Contracts { get; set; }
        public string BaseContractDemand { get; set; }
        public object BasicChargeUnitPrice { get; set; }
    }

    public class PaymentDetail
    {
        public string EnrollmentPaymentDetailsId { get; set; }
        public object EnrollmentPaymentDetailsCustomerId { get; set; }
        public object PaymentToken1 { get; set; }
        public object PaymentToken2 { get; set; }
        public object AccountNumber { get; set; }
        public object AccountName { get; set; }
        public object BankCode { get; set; }
        public object BankName { get; set; }
        public object BranchCode { get; set; }
        public object BranchName { get; set; }
        public object AutoPayStartDate { get; set; }
        public object DraftDate { get; set; }
        public object AccountLastFour { get; set; }
        public object PaymentTypeId { get; set; }
        public object ReferenceNumber { get; set; }
        public object IsEnrollmentPaymentDetailsActive { get; set; }
        public object CreatedByName { get; set; }
        public object CreatedDate { get; set; }
        public object LastModifiedDate { get; set; }
        public object LastModifiedByName { get; set; }
        public object VendorCode { get; set; }
        public string PaymentTypeCode { get; set; }
        public bool IsCreditCard { get; set; }
        public bool IsDebitCard { get; set; }
    }

    public class PhoneList
    {
        public string ContactPhoneId { get; set; }
        public object ContactId { get; set; }
        public object IsContactPhoneActive { get; set; }
        public bool IsContactPhonePrimary { get; set; }
        public string PhoneTypeCode { get; set; }
        public object? PhoneTypeId { get; set; }
        public object PhoneCountryCode { get; set; }
        public string PhoneAreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FAX { get; set; }
        public string SubscriberNumber { get; set; }
        public object PhoneExtension { get; set; }
        public object IsSMSAllowed { get; set; }
        public object IsDoNotCall { get; set; }
    }

    public class QuotationDetail
    {
        public string QuotationId { get; set; }
        public string Nameoffacility { get; set; }
        public string QuotationLineNumber { get; set; }
        public string ContractType { get; set; }
        public string ContractPower { get; set; }
        public string SupplyType { get; set; }
        public string PeriodOfSupply { get; set; }
        public object ScheduledSupplyStartDate { get; set; }
        public object SupplyStartDate { get; set; }
        public string Status { get; set; }
        public string ApplicationFormStatus { get; set; }
        public string Area { get; set; }
        public string Plan { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public object Category3 { get; set; }
        public object Category4 { get; set; }
        public object RateofCategory1 { get; set; }
        public object RateofCategory2 { get; set; }
        public object RateofCategory3 { get; set; }
        public object RateofCategory4 { get; set; }
        public object Current_BaseContractPower { get; set; }
        public object main_baseContractPower { get; set; }
        public object PlannedAnnualPowerConsumption { get; set; }
        public string SpareLine_TargetClassification { get; set; }
        public object ReserveLine_ContractPower { get; set; }
        public object BackupLine_BasicUnitPrice { get; set; }
        public string StandbyPowerSupply_TargetCategory { get; set; }
        public object StandbyPowerSupply_BasicChargeUnitPrice { get; set; }
        public object StandbyPowerSource_ContractPower { get; set; }
        public string EnvironmentMenuTargetCategory { get; set; }
        public string Initiative { get; set; }
        public object EnvironmentalValue { get; set; }
        public string PowerCord { get; set; }
        public object CertificateUsage { get; set; }
        public object RenewableEnergyRatio { get; set; }
        public object Main_SupplyVoltage { get; set; }
        public object Main_ContractPower { get; set; }
        public object Main_BaseUnitPrice { get; set; }
        public object PartitionBasicChargeUnitPrice { get; set; }
        public string PaymentMethod { get; set; }
    }

    public class QuotationDetail2
    {
        public string QuotationId { get; set; }
        public string Nameoffacility { get; set; }
        public string QuotationLineNumber { get; set; }
        public string ContractType { get; set; }
        public string ContractPower { get; set; }
        public string SupplyType { get; set; }
        public string PeriodOfSupply { get; set; }
        public object? ScheduledSupplyStartDate { get; set; }
        public object SupplyStartDate { get; set; }
        public string Status { get; set; }
        public string ApplicationFormStatus { get; set; }
        public string Area { get; set; }
        public string Plan { get; set; }
        public string Category1 { get; set; }
        public string Category2 { get; set; }
        public string Category3 { get; set; }
        public string Category4 { get; set; }
        public object RateofCategory1 { get; set; }
        public object RateofCategory2 { get; set; }
        public object RateofCategory3 { get; set; }
        public object RateofCategory4 { get; set; }
        public object Current_BaseContractPower { get; set; }
        public object main_baseContractPower { get; set; }
        public object? PlannedAnnualPowerConsumption { get; set; }
        public string SpareLine_TargetClassification { get; set; }
        public object ReserveLine_ContractPower { get; set; }
        public object? BackupLine_BasicUnitPrice { get; set; }
        public string StandbyPowerSupply_TargetCategory { get; set; }
        public object StandbyPowerSupply_BasicChargeUnitPrice { get; set; }
        public object? StandbyPowerSource_ContractPower { get; set; }
        public string EnvironmentMenuTargetCategory { get; set; }
        public string Initiative { get; set; }
        public object EnvironmentalValue { get; set; }
        public string PowerCord { get; set; }
        public object CertificateUsage { get; set; }
        public object RenewableEnergyRatio { get; set; }
        public object? Main_SupplyVoltage { get; set; }
        public object? Main_ContractPower { get; set; }
        public object? Main_BaseUnitPrice { get; set; }
        public object PartitionBasicChargeUnitPrice { get; set; }
        public string PaymentMethod { get; set; }
    }

    public class RenewableEnergySurchargeExemption
    {
        public string ReductionOfExemptionStartDate { get; set; }
        public string ExemptionEndDate { get; set; }
        public object ExemptionRate { get; set; }
        public object DocumentIds { get; set; }
    }

    public class ReserveLineContract
    {
        public object ContractPower { get; set; }
        public object BasicChargeUnitPrice { get; set; }
        public object SupplyVoltage { get; set; }
        public object MeteringVoltage { get; set; }
    }

    public class ReservePowerContract
    {
        public object ContractPower { get; set; }
        public object BasicChargeUnitPrice { get; set; }
        public object SupplyVoltage { get; set; }
        public object MeteringVoltage { get; set; }
    }

    public class FilterData
    {
        public string QuotationNo { get; set; }
        public string ApplicationKey { get; set; }
        public object ConfirmerCategory { get; set; }
        public bool NotificationItemsExplainedCheck1 { get; set; }
        public bool NotificationItemsExplainedCheck2 { get; set; }
        public bool PrivacyPolicyConsentCheck1 { get; set; }
        public bool PrivacyPolicyConsentCheck2 { get; set; }
        public bool AnnouncementItemElectromagneticDeliveryConsentCheck1 { get; set; }
        public bool AnnouncementItemElectromagneticDeliveryConsentCheck2 { get; set; }
        public bool ProxyApplicationConsentCheck { get; set; }
        public string EnrollmentBatchDetailId { get; set; }
        public object EnrollmentSalesTypeId { get; set; }
        public object EnrollmentStatusId { get; set; }
        public string CorrelationId { get; set; }
        public object TermsofServiceAgreement { get; set; }
        public object TermsofUseAgreement { get; set; }
        public bool IsActive { get; set; }
        public string EnrollmentSourceCode { get; set; }
        public string ConfirmationNumber { get; set; }
        public object EnrollmentHoldReasonCode { get; set; }
        public object TPVCode { get; set; }
        public string EnrollmentStatusCode { get; set; }
        public string EnrollmentCompletedStatus { get; set; }
        public string EnrollmentStatusReasonCode { get; set; }
        public object EnrollmentStatusJSON { get; set; }
        public bool IsPicked { get; set; }
        public object? LastCompletedStep { get; set; }
        public object ReferenceNumber { get; set; }
        public object Latitude { get; set; }
        public object Longitude { get; set; }
        public List<QuotationDetail> QuotationDetails { get; set; }
        public EnrollmentCustomer EnrollmentCustomer { get; set; }
        public object ExtendedProperties { get; set; }
        public object RequestDate { get; set; }
        public object? DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string DivisionCode { get; set; }
        public string CreatedByName { get; set; }
        public object CreateDate { get; set; }
        public string LastModifiedByName { get; set; }
        public object? LastModifiedDate { get; set; }
        public string id { get; set; }
        public string _rid { get; set; }
        public string _self { get; set; }
        public string _etag { get; set; }
        public string _attachments { get; set; }
        public object _ts { get; set; }
        public bool? IsBatch { get; set; }
        public bool? IsCustomerEnrolled { get; set; }
        public object EnrolledCustomerID { get; set; }
    }

    public class SelfPowerSupplyContract
    {
        public object Power { get; set; }
        public object Contracts { get; set; }
        public string ReferencePowerCalculationMethod { get; set; }
        public string ContractsType { get; set; }
        public object MonthlyBasicChargeUnitPrice { get; set; }
        public object BasicChargeUnitPriceNonUse { get; set; }
        public object RegularSummerUnitPrice { get; set; }
        public object IrrRegularSummerUnitPrice { get; set; }
        public object PeriodicOtherSeasonalUnitPrice { get; set; }
        public object IrregularOtherSeasonalUnitPrice { get; set; }
    }

    public class ServiceAccount
    {
        public string EnrollmentServiceAccountId { get; set; }
        public string EnrollmentServiceAccountCustomerId { get; set; }
        public string Area { get; set; }
        public object ServiceTypeId { get; set; }
        public object ClientId { get; set; }
        public string ClientCode { get; set; }
        public object UtilityId { get; set; }
        public string StateCode { get; set; }
        public object AddressId { get; set; }
        public string UtilityAccountNumber { get; set; }
        public string MeterNumber { get; set; }
        public string NameKey { get; set; }
        public bool IsUnmetered { get; set; }
        public bool IsTOU { get; set; }
        public object TransactionHoldReasonId { get; set; }
        public object TransactionRequestTypeId { get; set; }
        public object TransactionReleaseDate { get; set; }
        public object TransactionRequestedEffectiveDate { get; set; }
        public string ContractNumber { get; set; }
        public string PromoCode { get; set; }
        public object ContractStartDate { get; set; }
        public object ContractEndDate { get; set; }
        public object ContractTerm { get; set; }
        public object ContractSignedDate { get; set; }
        public object SalesAgency { get; set; }
        public object SalesAgent { get; set; }
        public object CommissionAmount { get; set; }
        public object TPVCode { get; set; }
        public object ReferenceServiceAccountId { get; set; }
        public bool IsEnrollmentServiceAccountActive { get; set; }
        public object RateClassId { get; set; }
        public object? LoadProfileId { get; set; }
        public bool IsTransationHold { get; set; }
        public object SalesAgentCode { get; set; }
        public object RateClassCode { get; set; }
        public string LoadProfileCode { get; set; }
        public object SalesChannelCode { get; set; }
        public object SalesChannelPartnerCode { get; set; }
        public object ContractTypeId { get; set; }
        public object ChannelFeeAmount { get; set; }
        public object ContractSourceId { get; set; }
        public string ServiceTypeCode { get; set; }
        public string UtilityCode { get; set; }
        public object TransactionHoldReasonCode { get; set; }
        public object TransactionRequestTypeCode { get; set; }
        public object ContractTypeCode { get; set; }
        public string ContractSourceCode { get; set; }
        public object SalesAgencyCode { get; set; }
        public object SalesAgentEmail { get; set; }
        public object CommissionTypeCode { get; set; }
        public object ReferenceBillingAccountNumber { get; set; }
        public object UtilityBillingAccountNumber { get; set; }
        public object RateScheduleName { get; set; }
        public object ProductCode { get; set; }
        public object IsTransactionHold { get; set; }
        public object ProductTypeCode { get; set; }
        public object ProductTypeName { get; set; }
        public object UtilityRateCode { get; set; }
        public object EnergyRate { get; set; }
        public object EnergyRateUOM { get; set; }
        public object CancelFeeType { get; set; }
        public object MonthlyFee { get; set; }
        public object CancelFee { get; set; }
        public object CrmUtilityAccountNumber { get; set; }
        public object RateAmount { get; set; }
        public bool IsVariableRate { get; set; }
        public object MonthlyFeeUOM { get; set; }
        public object VoltageTypeId { get; set; }
        public object WheelingServiceCalculationTypeCode { get; set; }
        public object AmpereSizeCode { get; set; }
        public object AmpereBreakerAvailabilityCode { get; set; }
        public object PeakCapacityAllowanceCode { get; set; }
        public object MinPriceContractCode { get; set; }
        public object MaxAmpereBreakerCapacity { get; set; }
        public object DroppingRetailerCode { get; set; }
        public object OtherRetailer { get; set; }
        public object DroppingRetailerCustomerNumber { get; set; }
        public object NextMeterReadDate { get; set; }
        public object NextNextMeterReadDate { get; set; }
        public object MeterobjectervalCode1 { get; set; }
        public object BreakerKwCapacity { get; set; }
        public object BreakerKvaCapacity { get; set; }
        public object SupplyLineTypeCode { get; set; }
        public object PremiseStatus { get; set; }
        public object WheelingServiceCalculationTypeName { get; set; }
        public object AmpereMaxCapacity { get; set; }
        public object UniversalService { get; set; }
        public object UtilityNameNativeDescription { get; set; }
        public object MeterCycle { get; set; }
        public object PowerFactor { get; set; }
        public bool IsConfirmationSent { get; set; }
        public object MemberName { get; set; }
        public object MemberNumber { get; set; }
        public object AcceptedTermsCode { get; set; }
        public object FixedEnergyRate { get; set; }
        public object SummerEnergyRate { get; set; }
        public object NonSummerEnergyRate { get; set; }
        public object SummerWeekdayRate { get; set; }
        public object SummerWeekendRate { get; set; }
        public object NonSummerWeekdayRate { get; set; }
        public object NonSummerWeekendRate { get; set; }
        public object Peak { get; set; }
        public object SummerDaytime { get; set; }
        public object NonSummerDaytime { get; set; }
        public object OffPeak { get; set; }
        public object BasicChargeKW { get; set; }
        public object Moveobjectime { get; set; }
        public object IsRequestedEffectiveDateOverridden { get; set; }
        public object OfferCode { get; set; }
        public ServiceAddress ServiceAddress { get; set; }
        public Transaction Transaction { get; set; }
        public object ContractDetails { get; set; }
        public QuotationDetail QuotationDetail { get; set; }
        public ServiceAccountOtherAttributes serviceAccountOtherAttributes { get; set; }
        public CurrentRetailerInformation CurrentRetailerInformation { get; set; }
        public List<AuthorizedContact> AuthorizedContacts { get; set; }
        public RenewableEnergySurchargeExemption RenewableEnergySurchargeExemption { get; set; }
        public EnviornmentMenu EnviornmentMenu { get; set; }
        public MainContractInformation MainContractInformation { get; set; }
        public EnergyCharge EnergyCharge { get; set; }
        public ReserveLineContract ReserveLineContract { get; set; }
        public ReservePowerContract ReservePowerContract { get; set; }
        public SelfPowerSupplyContract SelfPowerSupplyContract { get; set; }
        public ContractAutomaticRenewalCategory ContractAutomaticRenewalCategory { get; set; }
        public object serviceContracts { get; set; }
    }

    public class ServiceAccountOtherAttributes
    {
        public string NewlyEstablished { get; set; }
        public string RegisteredName { get; set; }
        public string RegisteredNameKana { get; set; }
        public object SupplyPoobjectIdentificationNumber { get; set; }
        public object DemandBaseSalesforceID { get; set; }
        public object ScheduledSupplyStartDate { get; set; }
        public object WeighingDay { get; set; }
        public object WeighingDate { get; set; }
        public object BusinessPattern { get; set; }
        public object TransmissionandDistributionCompany { get; set; }
        public object CurrentSupplyClass { get; set; }
        public object OldInvoiceName { get; set; }
        public object CurrentContractPower { get; set; }
        public object CurrentBaseContractPower { get; set; }
        public object CurrentBaseContractSupplyCompanyName { get; set; }
        public string NewContinuationCategory { get; set; }
        public object? LoadPattrenId { get; set; }
        public object CurrentCustomerNumber { get; set; }
        public object Contracts { get; set; }
        public object CurrentRetailerName { get; set; }
        public object CurrentRetailerNameDirect { get; set; }
        public string ContractSystem { get; set; }
        public object QuotationLineNumber { get; set; }
    }

    public class ServiceAddress
    {
        public object AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public object Address3 { get; set; }
        public string BuildingName { get; set; }
        public object City { get; set; }
        public object State { get; set; }
        public string Zip5 { get; set; }
        public string Zip4 { get; set; }
        public object IsAddressActive { get; set; }
        public object CountryCode { get; set; }
        public string PostalCode { get; set; }
        public object County { get; set; }
        public string Chome { get; set; }
        public string Banchi { get; set; }
        public string Gou { get; set; }
        public string BuildingNumber { get; set; }
        public string RoomNumber { get; set; }
    }

    public class Transaction
    {
        public object ScheduledTransactionReleaseDate { get; set; }
        public object RequestedEffectiveDate { get; set; }
        public object EstimatedEffectiveDate { get; set; }
        public object AccessDescription { get; set; }
        public bool IsTransactionHold { get; set; }
        public object HoldReasonCode { get; set; }
        public object MonthlyUsageTypeCode { get; set; }
        public string TransactionRequestTypeCode { get; set; }
        public object HuRequestTypeCode { get; set; }
        public object NextMeterReadDate { get; set; }
        public object Moveobjectime { get; set; }
    }


}
