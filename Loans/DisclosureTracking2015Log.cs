using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class DisclosureTracking2015Log
    {
        public string Id { get; set; }
        public List<LogAlert> Alerts { get; set; }
        public string BorrowerPairId { get; set; }
        public List<LogComment> CommentList { get; set; }
        public string Comments { get; set; }
        public bool? ContainCD { get; set; }
        public bool? ContainSafeHarbor { get; set; }
        public bool? ProviderListSent { get; set; }
        public bool? ContainLE { get; set; }
        public DateTime? DateUtc { get; set; }
        public string DisclosedBy { get; set; }
        public string DisclosedByFullName { get; set; }
        public string DisclosedMethod { get; set; }
        public string DisclosedMethodOther { get; set; }
        public DateTime? DisclosureCreatedDttmUtc { get; set; }
        public bool? EDisclosureApplicationPackageIndicator { get; set; }
        public bool? EDisclosureApprovalPackageIndicator { get; set; }
        public DateTime? EDisclosureBorrowerAcceptConsentDate { get; set; }
        public DateTime? EDisclosureBorrowereSignedDate { get; set; }
        public DateTime? EDisclosureBorrowerRejectConsentDate { get; set; }
        public DateTime? EDisclosureBorrowerViewConsentDate { get; set; }
        public DateTime? EDisclosureBorrowerViewMessageDate { get; set; }
        public DateTime? EDisclosureBorrowerWetSignedDate { get; set; }
        public DateTime? EDisclosureCoBorrowerAcceptConsentDate { get; set; }
        public DateTime? EDisclosureCoBorrowereSignedDate { get; set; }
        public DateTime? EDisclosureCoBorrowerRejectConsentDate { get; set; }
        public DateTime? EDisclosureCoBorrowerViewConsentDate { get; set; }
        public DateTime? EDisclosureCoBorrowerViewMessageDate { get; set; }
        public DateTime? EDisclosureCoBorrowerWebSignedDate { get; set; }
        public string EDisclosureConsentPdf { get; set; }
        public string EDisclosureDisclosedMessage { get; set; }
        public bool? EDisclosureLockPackageIndicator { get; set; }
        public string EDisclosureManualFulfillmentComment { get; set; }
        public DateTime? EDisclosureManualFulfillmentDate { get; set; }
        public string EDisclosureManualFulfillmentMethod { get; set; }
        public string EDisclosureManuallyFulfilledBy { get; set; }
        public DateTime? EDisclosurePackageCreatedDate { get; set; }
        public string EDisclosurePackageId { get; set; }
        public string EDisclosurePackageViewableFile { get; set; }
        public bool? EDisclosureThreeDayPackageIndicator { get; set; }
        public bool? FileAttachmentsMigrated { get; set; }
        public List<DisclosureForm> Forms { get; set; }
        public string FulfillmentOrderedBy { get; set; }
        public string FullfillmentProcessedDate { get; set; }
        public string Guid { get; set; }
        public string IsDisclosed { get; set; }
        public string IsDisclosedAprLocked { get; set; }
        public string IsDisclosedByLocked { get; set; }
        public string IsDisclosedFinanceChargeLocked { get; set; }
        public string IsDisclosedReceivedDateLocked { get; set; }
        public string IsLocked { get; set; }
        public bool? IsSystemSpecificIndicator { get; set; }
        public bool? IsWetSignedIndicator { get; set; }
        public string LockedDisclosedAprField { get; set; }
        public string LockedDisclosedByField { get; set; }
        public string LockedDisclosedFinanceChargeField { get; set; }
        public DateTime? LockedDisclosedReceivedDate { get; set; }
        public int? LogRecordIndex { get; set; }
        public string ManuallyCreated { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public string DisclosureType { get; set; }
        public bool? LEReasonIsChangedCircumstanceSettlementCharges { get; set; }
        public bool? LEReasonIsChangedCircumstanceEligibility { get; set; }
        public bool? LEReasonIsRevisionsRequestedByConsumer { get; set; }
        public bool? LEReasonIsInterestRateDependentCharges { get; set; }
        public bool? LEReasonIsExpiration { get; set; }
        public bool? LEReasonIsDelayedSettlementOnConstructionLoans { get; set; }
        public bool? LEReasonIsOther { get; set; }
        public string LEReasonOther { get; set; }
        public bool? CDReasonIsChangeInAPR { get; set; }
        public bool? CDReasonIsChangeInLoanProduct { get; set; }
        public bool? CDReasonIsPrepaymentPenaltyAdded { get; set; }
        public bool? CDReasonIsChangeInSettlementCharges { get; set; }
        public bool? CDReasonIs24HourAdvancePreview { get; set; }
        public bool? CDReasonIsToleranceCure { get; set; }
        public bool? CDReasonIsClericalErrorCorrection { get; set; }
        public bool? CDReasonIsOther { get; set; }
        public string CDReasonOther { get; set; }
        public string ChangeInCircumstance { get; set; }
        public string ChangeInCircumstanceComments { get; set; }
        public string IntentToProceedReceivedBy { get; set; }
        public string IntentToProceedReceivedMethod { get; set; }
        public string IntentToProceedReceivedMethodOther { get; set; }
        public string IntentToProceedComments { get; set; }
        public string BorrowerDisclosedMethod { get; set; }
        public string BorrowerDisclosedMethodOther { get; set; }
        public DateTime? BorrowerPresumedReceivedDate { get; set; }
        public DateTime? BorrowerActualReceivedDate { get; set; }
        public string CoBorrowerDisclosedMethod { get; set; }
        public string CoBorrowerDisclosedMethodOther { get; set; }
        public DateTime? CoBorrowerPresumedReceivedDate { get; set; }
        public DateTime? CoBorrowerActualReceivedDate { get; set; }
        public List<LogSnapshotField> SnapshotFields { get; set; }
        public string SystemId { get; set; }
        public bool? IntentToProceed { get; set; }
        public DateTime? IntentToProceedDate { get; set; }
        public string BorrowerType { get; set; }
        public string CoBorrowerType { get; set; }
        public string FormsXml { get; set; }
        public string SnapshotXml { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public string BorrowerName { get; set; }
        public string CoBorrowerName { get; set; }
        public string DisclosedAPR { get; set; }
        public string FinanceCharge { get; set; }
        public string LoanProgram { get; set; }
        public string LoanAmount { get; set; }
        public string PropertyAddress { get; set; }
        public string PropertyCity { get; set; }
        public string PropertyState { get; set; }
        public string PropertyZip { get; set; }
        public string AlertsXml { get; set; }
        public string CommentListXml { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DisclosedDate { get; set; }
        public bool? DisclosedForCD { get; set; }
        public string DisclosureMethod { get; set; }
        public bool? IsBorrowerPresumedDateLocked { get; set; }
        public bool? IsCoBorrowerPresumedDateLocked { get; set; }
        public DateTime? LockedBorrowerPresumedReceivedDate { get; set; }
        public DateTime? LockedCoBorrowerPresumedReceivedDate { get; set; }
        public string DisclosedMethodName { get; set; }
        public string LenderTotalPaidOriginatorAmount { get; set; }
        public string LoanPurchaseCreditType1 { get; set; }
        public string LoanPurchaseCreditAmount1 { get; set; }
        public string LoanPurchaseCreditType2 { get; set; }
        public string LoanPurchaseCreditAmount2 { get; set; }
        public string LoanPurchaseCreditType3 { get; set; }
        public string LoanPurchaseCreditAmount3 { get; set; }
        public string LoanPurchaseCreditType4 { get; set; }
        public string LoanPurchaseCreditAmount4 { get; set; }
        public string LoanClosingCostLenderCredits { get; set; }
        public string LoanClosingCostTotalFeeAmount2015 { get; set; }
        public string LoanClosingCost3StdLegalLimit { get; set; }
        public string LoanClosingCost2TotalLoanCost { get; set; }
        public string LoanClosingCost2TotalOtherCost { get; set; }
        public string LoanClosingCost2BorrowerClosingCostAtClosing { get; set; }
        public string LoanEstimate2TotalLoanCosts { get; set; }
        public string LoanEstimate2TotalOtherCosts { get; set; }
        public string LoanEstimate2TotalLoanAndOtherCosts { get; set; }
        public string LoanEstimate2UnroundedTotalLoanCosts { get; set; }
        public string LoanEstimate2UnroundedTotalOtherCosts { get; set; }
        public string PurchasePriceAmount { get; set; }
        public string LoanClosingCost2LenderCredits { get; set; }
        public string Line907PropertyIndicator2015 { get; set; }
        public string Line908PropertyIndicator2015 { get; set; }
        public string Line909PropertyIndicator2015 { get; set; }
        public string Line910PropertyIndicator2015 { get; set; }
        public string Line911PropertyIndicator2015 { get; set; }
        public string Line912PropertyIndicator2015 { get; set; }
        public string Line907InsuranceIndicator2015 { get; set; }
        public string Line908InsuranceIndicator2015 { get; set; }
        public string Line909InsuranceIndicator2015 { get; set; }
        public string Line910InsuranceIndicator2015 { get; set; }
        public string Line911InsuranceIndicator2015 { get; set; }
        public string Line912InsuranceIndicator2015 { get; set; }
        public string Line907TaxesIndicator2015 { get; set; }
        public string Line908TaxesIndicator2015 { get; set; }
        public string Line909TaxesIndicator2015 { get; set; }
        public string Line910TaxesIndicator2015 { get; set; }
        public string Line911TaxesIndicator2015 { get; set; }
        public string Line912TaxesIndicator2015 { get; set; }
        public string LoanClosingCostGfe800BorPaidAmount { get; set; }
        public string LoanFeesCityTaxBorPaidAmount { get; set; }
        public string LoanFeesStateTaxBorPaidAmount { get; set; }
        public string LoanClosingCostGfe1200BorPaidAmount { get; set; }
        public string LoanClosingCostSection1000BorrowerTotalPaidAmount { get; set; }
        public string LoanGfeAgregateAdjustment { get; set; }
        public string LoanGfeGovermentRecordingCharges { get; set; }
        public string LoanSection1000SellerPaidTotalAmount { get; set; }
        public string LoanAdjustmentsOtherCredits { get; set; }
        public string LoanDownPayment { get; set; }
        public string LoanFundsForBorrower { get; set; }
        public string LoanLineItemAmount { get; set; }
        public string LoanRefinanceIncludingDebtsToBePaidOffAmount { get; set; }
        public string LoanSellerCreditAmount { get; set; }
        public string LoanTotalClosingCosts { get; set; }
        public string LoanClosingCostsFinanced { get; set; }
        public string PrepaymentPenaltyIndicator { get; set; }
        public string LoanEstimateLoanProduct { get; set; }
        public string DisclosedDailyInterest { get; set; }
        public string AppliedCureAmount { get; set; }
        public string LenderCompensationCreditAmount2 { get; set; }
        public string Line802LOCompAdditionalAmount1 { get; set; }
        public string Line802LOCompAdditionalAmount2 { get; set; }
        public string ChargesThatCannotDecreaseItemization9 { get; set; }
        public string ChargesThatCannotIncreaseItemization13 { get; set; }
        public string ChargesCannotIncrease10Itemization34 { get; set; }
        public string ChargesThatCannotDecreaseLE7 { get; set; }
        public string ChargesThatCannotIncreaseLE11 { get; set; }
        public string ChargesCannotIncrease10LE32 { get; set; }
        public string EstimatedTotalPayoffsAndPaymentsAmount { get; set; }
    }
}