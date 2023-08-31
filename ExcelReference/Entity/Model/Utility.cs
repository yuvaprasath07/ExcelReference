using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Utility
    {
    
        public class ActivityLog
        {
            public string ActivityLogId { get; set; }
            public string ActivityLogTypeCode { get; set; }
            public string ActivityLogTypeDescription { get; set; }
            public string ActivityLogCategoryName { get; set; }
            public string ActivityLogCategoryCode { get; set; }
            public object ActivityLogSubCategoryName { get; set; }
            public bool IsInternalActivityLog { get; set; }
            public string ActivityLogText { get; set; }
            public object ActivityDate { get; set; }
            public object CreatedUser { get; set; }
            public int ActivityLogCreatedUserId { get; set; }
            public List<object> Files { get; set; }
            public List<object> DocumentList { get; set; }
            public string CustomerCommunicationRequestSubStatusDesc { get; set; }
        }

        public class AuthorizedContactAddress
        {
            public string AttentionTo { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string Address3 { get; set; }
            public string Address4 { get; set; }
            public string Address5 { get; set; }
            public string BuildingName { get; set; }
            public string City { get; set; }
            public object County { get; set; }
            public string State { get; set; }
            public string Zip5 { get; set; }
            public string Zip4 { get; set; }
            public object Country { get; set; }
            public object Chome { get; set; }
            public object Banchi { get; set; }
            public object Gou { get; set; }
            public string BuildingNumber { get; set; }
            public string RoomNumber { get; set; }
        }

        public class AuthorizedContactEmailList
        {
            public ContactEmail ContactEmail { get; set; }
        }

        public class AuthorizedContactList
        {
            public object BirthDate { get; set; }
            public bool IsPrimary { get; set; }
            public List<AuthorizedContactPhoneList> AuthorizedContactPhoneList { get; set; }
            public List<AuthorizedContactEmailList> AuthorizedContactEmailList { get; set; }
            public AuthorizedContactAddress AuthorizedContactAddress { get; set; }
            public string ContactTypeCode { get; set; }
            public string OtherContact { get; set; }
            public string Prefix { get; set; }
            public object FirstName { get; set; }
            public object LastName { get; set; }
            public string Suffix { get; set; }
            public string JpContactName { get; set; }
            public string ContactNameKana { get; set; }
            public string CompanyNameKana { get; set; }
            public string CompanyName { get; set; }
            public string DepartmentName { get; set; }
            public bool IsDoNotEmail { get; set; }
            public string StaffName { get; set; }
            public string StaffNameKana { get; set; }
            public object RecipientName { get; set; }
        }

        public class AuthorizedContactPhoneList
        {
            public ContactPhone ContactPhone { get; set; }
        }

        public class BankData
        {
            public object AccountNumber { get; set; }
            public object AccountName { get; set; }
            public object BankCode { get; set; }
            public object BankName { get; set; }
            public object BranchCode { get; set; }
            public object BranchName { get; set; }
            public object DraftDate { get; set; }
            public object AutoPayStartDate { get; set; }
            public object PaymentTypeId { get; set; }
            public object PaymentTypeCode { get; set; }
            public object BankDepositCategoryCode { get; set; }
        }

        public class BillingAccountList
        {
            public int PaymentTermOverride { get; set; }
            public MailAddress MailAddress { get; set; }
            public object SecondaryNotificationAddress { get; set; }
            public List<ServiceAccountList> ServiceAccountList { get; set; }
            public object BillDate { get; set; }
            public object SoldDate { get; set; }
            public List<AuthorizedContactList> AuthorizedContactList { get; set; }
            public string BillingAccountReferenceId { get; set; }
            public object IsBillHold { get; set; }
            public string ContractSourceCode { get; set; }
            public string DeliveryTypeCode { get; set; }
            public object BillingMethodCode { get; set; }
            public bool ApplyLateFees { get; set; }
            public int LateFeeOverride { get; set; }
            public int LateFeePercentOverride { get; set; }
            public object BillFormatCode { get; set; }
            public object BillTypeCode { get; set; }
            public object LinkToBillingAccountNumber { get; set; }
            public string PaymentCategoryCode { get; set; }
            public int PaymentCategoryId { get; set; }
            public object PassCode { get; set; }
        }

        public class ContactEmail
        {
            public object EmailTypeName { get; set; }
            public bool IsPrimary { get; set; }
            public string EmailAddress { get; set; }
            public string EmailTypeCode { get; set; }
        }

        public class ContactPhone
        {
            public object PhoneTypeName { get; set; }
            public bool IsPrimary { get; set; }
            public string PhoneCountryCode { get; set; }
            public string PhoneAreaCode { get; set; }
            public string PhoneNumber { get; set; }
            public string SubscriberNumber { get; set; }
            public string PhoneExtension { get; set; }
            public bool IsSMSAllowed { get; set; }
            public bool IsDoNotCall { get; set; }
            public string PhoneTypeCode { get; set; }
            public int PhoneTypeId { get; set; }
        }

        public class Contract
        {
            public int ContractTerm { get; set; }
            public object ServiceTypeName { get; set; }
            public object ServiceTypeCode { get; set; }
            public object ContractStartDate { get; set; }
            public object ContractEndDate { get; set; }
            public object ContractSignedDate { get; set; }
            public object ContractNumber { get; set; }
            public bool IsCreditRequirement { get; set; }
            public object ContractSource { get; set; }
            public object ContractVolume { get; set; }
            public bool CoTerminousEndDate { get; set; }
            public object DocumentUrl { get; set; }
        }

        public class ContractAttribute
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public object ReferralAgency { get; set; }
            public bool IsActive { get; set; }
            public int CreatedBy { get; set; }
            public object Attribute { get; set; }
        }

        public class ContractDetailList
        {
            public object ContractStartDate { get; set; }
            public object ContractEndDate { get; set; }
            public object ChannelFee { get; set; }
            public object BrokerFee { get; set; }
            public object PromoCode { get; set; }
            public ContractRateSchedule ContractRateSchedule { get; set; }
            public string ContractTypeCode { get; set; }
            public string SalesAgencyCode { get; set; }
            public string SalesChannelCode { get; set; }
            public string SalesChannelPartnerCode { get; set; }
            public object CommissionTypeCode { get; set; }
            public string SalesAgentCode { get; set; }
            public int SalesAgentUserId { get; set; }
            public string SalesBranchCode { get; set; }
        }

        public class ContractRateSchedule
        {
            public string RateScheduleName { get; set; }
            public int ETFAmount { get; set; }
            public List<ContractRateSegmentList> ContractRateSegmentList { get; set; }
            public object ETFCalculationTypeCode { get; set; }
        }

        public class ContractRateSegmentList
        {
            public string Term { get; set; }
            public object ContractStartDate { get; set; }
            public object ContractEndDate { get; set; }
            public List<ContractSegmentDetailList> ContractSegmentDetailList { get; set; }
            public string UtilityRateCode { get; set; }
        }

        public class ContractSegmentDetailList
        {
            public int ContractSegmentDetailId { get; set; }
            public object RateAmount { get; set; }
            public object CommercialSalesForce { get; set; }
            public object ContractSegmentDetailAttributeList { get; set; }
        }

        public class CreditData
        {
            public object AccountLastFour { get; set; }
            public object PaymentTypeId { get; set; }
            public object PaymentTypeCode { get; set; }
            public object CardBrandCode { get; set; }
            public object CardExpiryDate { get; set; }
        }

        public class Customer
        {
            public List<AuthorizedContactList> AuthorizedContactList { get; set; }
            public List<BillingAccountList> BillingAccountList { get; set; }
            public CustomerCommercial CustomerCommercial { get; set; }
            public CustomerIndividual CustomerIndividual { get; set; }
            public LegalAddress LegalAddress { get; set; }
            public bool IsVIP { get; set; }
            public object AccountManager { get; set; }
            public string CustomerProspectId { get; set; }
            public string PassCode { get; set; }
            public List<Contract> Contract { get; set; }
            public string CustomerTypeCode { get; set; }
            public string LanguageCode { get; set; }
            public object LinkToCustomerNumber { get; set; }
            public object CustomerSegmentCode { get; set; }
            public List<object> Deposit { get; set; }
            public object MemberName { get; set; }
            public object MemberNumber { get; set; }
            public bool IsMember { get; set; }
            public PaymentData PaymentData { get; set; }
            public object EnrollmentAttributes { get; set; }
            public string ReferralCode { get; set; }
            public object FriendReferralCode { get; set; }
            public bool IsNewConstruction { get; set; }
            public int DivisionId { get; set; }
            public object CustomerAttributes { get; set; }
        }

        public class CustomerCommercial
        {
            public object CompanyName { get; set; }
            public object CompanyNameKana { get; set; }
            public string Dba { get; set; }
            public object TaxId { get; set; }
        }

        public class CustomerIndividual
        {
            public object DriverLicenseStateProvince { get; set; }
            public object Prefix { get; set; }
            public object FirstName { get; set; }
            public object MiddleName { get; set; }
            public object LastName { get; set; }
            public object Suffix { get; set; }
            public bool IsDomesticViolence { get; set; }
            public bool IsSenior { get; set; }
            public bool IsEmployee { get; set; }
            public int Last4SSN { get; set; }
            public object BirthDate { get; set; }
            public string DriverLicenseNumber { get; set; }
            public string CustomerName { get; set; }
            public string CustomerNameKana { get; set; }
        }

        public class LegalAddress
        {
            public object AttentionTo { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public object Address3 { get; set; }
            public object Address4 { get; set; }
            public object Address5 { get; set; }
            public object BuildingName { get; set; }
            public object City { get; set; }
            public object County { get; set; }
            public object State { get; set; }
            public string Zip5 { get; set; }
            public string Zip4 { get; set; }
            public object Country { get; set; }
            public object Chome { get; set; }
            public object Banchi { get; set; }
            public object Gou { get; set; }
            public string BuildingNumber { get; set; }
            public string RoomNumber { get; set; }
        }

        public class MailAddress
        {
            public object AttentionTo { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public object Address3 { get; set; }
            public object Address4 { get; set; }
            public object Address5 { get; set; }
            public object BuildingName { get; set; }
            public object City { get; set; }
            public object County { get; set; }
            public object State { get; set; }
            public string Zip5 { get; set; }
            public string Zip4 { get; set; }
            public object Country { get; set; }
            public object Chome { get; set; }
            public object Banchi { get; set; }
            public object Gou { get; set; }
            public string BuildingNumber { get; set; }
            public string RoomNumber { get; set; }
        }

        public class PaymentData
        {
            public object BillingAccountNumber { get; set; }
            public object VendorCode { get; set; }
            public object EffectiveStartDate { get; set; }
            public object AutopayTransferDate { get; set; }
            public bool IsDirectDebit { get; set; }
            public bool IsCreditCard { get; set; }
            public PaymentTokenData PaymentTokenData { get; set; }
            public BankData BankData { get; set; }
            public CreditData CreditData { get; set; }
            public int PaymentCategoryId { get; set; }
        }

        public class PaymentTokenData
        {
            public object PaymentToken1 { get; set; }
            public object PaymentToken2 { get; set; }
        }

        public class Root
        {
            public string SaleType { get; set; }
            public bool CreateParent { get; set; }
            public Customer Customer { get; set; }
            public List<object> SaleDetails { get; set; }
            public object LinkToParentCustomerNumber { get; set; }
            public string CorrelationId { get; set; }
            public string ConfirmationNumber { get; set; }
            public string SourceSystemDetailCode { get; set; }
            public List<ActivityLog> ActivityLog { get; set; }
            public object TermsofServiceAgreement { get; set; }
        }

        public class ServiceAccountList
        {
            public List<ContractDetailList> ContractDetailList { get; set; }
            public ServiceAddress ServiceAddress { get; set; }
            public object SpecialNeedsAddress { get; set; }
            public Transaction Transaction { get; set; }
            public object UtilityBillingAccountNumber { get; set; }
            public string UtilityAccountNumber { get; set; }
            public object TaxDistrict { get; set; }
            public bool IsLowIncome { get; set; }
            public object ServiceDeliveryPoint { get; set; }
            public object IsSolar { get; set; }
            public object AggregationType { get; set; }
            public object AggregationCode { get; set; }
            public object NameKey { get; set; }
            public bool RescissionWaiver { get; set; }
            public object RateClass { get; set; }
            public bool NotificationWaiver { get; set; }
            public object SupplierAccountNumber { get; set; }
            public object UniversalServiceCode { get; set; }
            public object LastMeterRead { get; set; }
            public string PowerFactor { get; set; }
            public object MeterCycle { get; set; }
            public object MeterReadCycle { get; set; }
            public List<object> AuthorizedContactList { get; set; }
            public List<object> FlatRateContract { get; set; }
            public object MeterList { get; set; }
            public object TaxExemption { get; set; }
            public string ServiceAccountReferenceId { get; set; }
            public bool IsTOU { get; set; }
            public bool IsUnmetered { get; set; }
            public string ClientCode { get; set; }
            public object AuthorizationTypeCode { get; set; }
            public string UtilityCode { get; set; }
            public string ServiceTypeCode { get; set; }
            public object MinPriceContractCode { get; set; }
            public int VoltageTypeId { get; set; }
            public object PeakCapacityAllowanceCode { get; set; }
            public object AmpereBreakerAvailabilityCode { get; set; }
            public object MaxAmpereBreakerCapacity { get; set; }
            public object AmpereSizeCode { get; set; }
            public string WheelingServiceCalculationTypeCode { get; set; }
            public string WheelingServiceCalculationTypeName { get; set; }
            public object NextMeterReadDate { get; set; }
            public object RateClassCode { get; set; }
            public string BreakerKwCapacity { get; set; }
            public string BreakerKvaCapacity { get; set; }
            public object SupplyLineTypeCode { get; set; }
            public bool IsTermsAccepted { get; set; }
            public string DroppingRetailerCustomerNumber { get; set; }
            public string DroppingRetailerCode { get; set; }
            public object OtherRetailer { get; set; }
            public object MemberName { get; set; }
            public object MemberNumber { get; set; }
            public object HikariAccount { get; set; }
            public object QuotationDetail { get; set; }
            public object serviceAccountOtherAttributes { get; set; }
            public object CurrentRetailerInformation { get; set; }
            public object AuthorizedContacts { get; set; }
            public object RenewableEnergySurchargeExemption { get; set; }
            public object EnviornmentMenu { get; set; }
            public object MainContractInformation { get; set; }
            public object EnergyCharge { get; set; }
            public object ReserveLineContract { get; set; }
            public object ReservePowerContract { get; set; }
            public object SelfPowerSupplyContract { get; set; }
            public List<ContractAttribute> ContractAttribute { get; set; }
            public object PassCode { get; set; }
        }

        public class ServiceAddress
        {
            public object AttentionTo { get; set; }
            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public object Address3 { get; set; }
            public object Address4 { get; set; }
            public object Address5 { get; set; }
            public string BuildingName { get; set; }
            public object City { get; set; }
            public object County { get; set; }
            public object State { get; set; }
            public string Zip5 { get; set; }
            public string Zip4 { get; set; }
            public string Country { get; set; }
            public object Chome { get; set; }
            public object Banchi { get; set; }
            public object Gou { get; set; }
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
            public int MoveInTime { get; set; }
        }


    }
}
