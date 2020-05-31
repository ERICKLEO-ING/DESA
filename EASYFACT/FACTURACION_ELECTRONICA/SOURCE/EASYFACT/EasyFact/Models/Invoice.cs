using System;

namespace EasyFact.Models
{
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    public class EspacioNombres
    {
        public const string xmlnsRetention = "urn:sunat:names:specification:ubl:peru:schema:xsd:Retention-1";
        public const string xmlnsInvoice = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2";
        public const string xmlnsCreditNote = "urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2";
        public const string xmlnsDebitNote = "urn:oasis:names:specification:ubl:schema:xsd:DebitNote-2";
        public const string xmlnsVoidedDocuments = "urn:sunat:names:specification:ubl:peru:schema:xsd:VoidedDocuments-1";
        public const string xmlnsSummaryDocuments = "urn:sunat:names:specification:ubl:peru:schema:xsd:SummaryDocuments-1";
        //public const string sac = "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1";
        public const string cac = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2";
        public const string cbc = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2";
        public const string udt = "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2";
        public const string ccts = "urn:un:unece:uncefact:documentation:2";
        public const string ext = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2";
        public const string qdt = "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2";
        public const string ds = "http://www.w3.org/2000/09/xmldsig#";
        public const string xsi = "http://www.w3.org/2001/XMLSchema-instance";
    }
    /// <comentarios/>
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    //[System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    //[System.ComponentModel.DesignerCategoryAttribute("code")]
    //[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2")]
    //[System.Xml.Serialization.XmlRootAttribute("Invoice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2", IsNullable = false)]
    [Serializable]
    public class Invoice : IXmlSerializable
    {
        public IFormatProvider Formato { get; set; }

        #region Variables
        private UBLExtensionType[] uBLExtensionsField;

        private UBLVersionIDType uBLVersionIDField;

        private CustomizationIDType customizationIDField;

        private ProfileIDType profileIDField;

        private ProfileExecutionIDType profileExecutionIDField;

        private IDType idField;

        private CopyIndicatorType copyIndicatorField;

        private UUIDType uUIDField;

        private IssueDateType issueDateField;

        private IssueTimeType issueTimeField;

        private DueDateType dueDateField;

        private InvoiceTypeCodeType invoiceTypeCodeField;

        private NoteType[] noteField;

        private TaxPointDateType taxPointDateField;

        private DocumentCurrencyCodeType documentCurrencyCodeField;

        private TaxCurrencyCodeType taxCurrencyCodeField;

        private PricingCurrencyCodeType pricingCurrencyCodeField;

        private PaymentCurrencyCodeType paymentCurrencyCodeField;

        private PaymentAlternativeCurrencyCodeType paymentAlternativeCurrencyCodeField;

        private AccountingCostCodeType accountingCostCodeField;

        private AccountingCostType accountingCostField;

        private LineCountNumericType lineCountNumericField;

        private BuyerReferenceType buyerReferenceField;

        private PeriodType[] invoicePeriodField;

        private OrderReferenceType orderReferenceField;

        private BillingReferenceType[] billingReferenceField;

        private DocumentReferenceType[] despatchDocumentReferenceField;

        private DocumentReferenceType[] receiptDocumentReferenceField;

        private DocumentReferenceType[] statementDocumentReferenceField;

        private DocumentReferenceType[] originatorDocumentReferenceField;

        private DocumentReferenceType[] contractDocumentReferenceField;

        private DocumentReferenceType[] additionalDocumentReferenceField;

        private ProjectReferenceType[] projectReferenceField;

        private SignatureType[] signatureField;

        private SupplierPartyType accountingSupplierPartyField;

        private CustomerPartyType accountingCustomerPartyField;

        private PartyType payeePartyField;

        private CustomerPartyType buyerCustomerPartyField;

        private SupplierPartyType sellerSupplierPartyField;

        private PartyType taxRepresentativePartyField;

        private DeliveryType[] deliveryField;

        private DeliveryTermsType deliveryTermsField;

        private PaymentMeansType[] paymentMeansField;

        private PaymentTermsType[] paymentTermsField;

        private PaymentType[] prepaidPaymentField;

        private AllowanceChargeType[] allowanceChargeField;

        private ExchangeRateType taxExchangeRateField;

        private ExchangeRateType pricingExchangeRateField;

        private ExchangeRateType paymentExchangeRateField;

        private ExchangeRateType paymentAlternativeExchangeRateField;

        private TaxTotalType[] taxTotalField;

        private TaxTotalType[] withholdingTaxTotalField;

        private MonetaryTotalType legalMonetaryTotalField;

        private InvoiceLineType[] invoiceLineField;
        #endregion

        #region Cuerpo Documento

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable = false)]
        public UBLExtensionType[] UBLExtensions
        {
            get
            {
                return this.uBLExtensionsField;
            }
            set
            {
                this.uBLExtensionsField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UBLVersionIDType UBLVersionID
        {
            get
            {
                return this.uBLVersionIDField;
            }
            set
            {
                this.uBLVersionIDField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CustomizationIDType CustomizationID
        {
            get
            {
                return this.customizationIDField;
            }
            set
            {
                this.customizationIDField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProfileIDType ProfileID
        {
            get
            {
                return this.profileIDField;
            }
            set
            {
                this.profileIDField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public ProfileExecutionIDType ProfileExecutionID
        {
            get
            {
                return this.profileExecutionIDField;
            }
            set
            {
                this.profileExecutionIDField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IDType ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CopyIndicatorType CopyIndicator
        {
            get
            {
                return this.copyIndicatorField;
            }
            set
            {
                this.copyIndicatorField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public UUIDType UUID
        {
            get
            {
                return this.uUIDField;
            }
            set
            {
                this.uUIDField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueDateType IssueDate
        {
            get
            {
                return this.issueDateField;
            }
            set
            {
                this.issueDateField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IssueTimeType IssueTime
        {
            get
            {
                return this.issueTimeField;
            }
            set
            {
                this.issueTimeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DueDateType DueDate
        {
            get
            {
                return this.dueDateField;
            }
            set
            {
                this.dueDateField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public InvoiceTypeCodeType InvoiceTypeCode
        {
            get
            {
                return this.invoiceTypeCodeField;
            }
            set
            {
                this.invoiceTypeCodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NoteType[] Note
        {
            get
            {
                return this.noteField;
            }
            set
            {
                this.noteField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxPointDateType TaxPointDate
        {
            get
            {
                return this.taxPointDateField;
            }
            set
            {
                this.taxPointDateField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DocumentCurrencyCodeType DocumentCurrencyCode
        {
            get
            {
                return this.documentCurrencyCodeField;
            }
            set
            {
                this.documentCurrencyCodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TaxCurrencyCodeType TaxCurrencyCode
        {
            get
            {
                return this.taxCurrencyCodeField;
            }
            set
            {
                this.taxCurrencyCodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PricingCurrencyCodeType PricingCurrencyCode
        {
            get
            {
                return this.pricingCurrencyCodeField;
            }
            set
            {
                this.pricingCurrencyCodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentCurrencyCodeType PaymentCurrencyCode
        {
            get
            {
                return this.paymentCurrencyCodeField;
            }
            set
            {
                this.paymentCurrencyCodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public PaymentAlternativeCurrencyCodeType PaymentAlternativeCurrencyCode
        {
            get
            {
                return this.paymentAlternativeCurrencyCodeField;
            }
            set
            {
                this.paymentAlternativeCurrencyCodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostCodeType AccountingCostCode
        {
            get
            {
                return this.accountingCostCodeField;
            }
            set
            {
                this.accountingCostCodeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AccountingCostType AccountingCost
        {
            get
            {
                return this.accountingCostField;
            }
            set
            {
                this.accountingCostField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public LineCountNumericType LineCountNumeric
        {
            get
            {
                return this.lineCountNumericField;
            }
            set
            {
                this.lineCountNumericField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public BuyerReferenceType BuyerReference
        {
            get
            {
                return this.buyerReferenceField;
            }
            set
            {
                this.buyerReferenceField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType[] InvoicePeriod
        {
            get
            {
                return this.invoicePeriodField;
            }
            set
            {
                this.invoicePeriodField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public OrderReferenceType OrderReference
        {
            get
            {
                return this.orderReferenceField;
            }
            set
            {
                this.orderReferenceField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public BillingReferenceType[] BillingReference
        {
            get
            {
                return this.billingReferenceField;
            }
            set
            {
                this.billingReferenceField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("DespatchDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] DespatchDocumentReference
        {
            get
            {
                return this.despatchDocumentReferenceField;
            }
            set
            {
                this.despatchDocumentReferenceField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("ReceiptDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] ReceiptDocumentReference
        {
            get
            {
                return this.receiptDocumentReferenceField;
            }
            set
            {
                this.receiptDocumentReferenceField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("StatementDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] StatementDocumentReference
        {
            get
            {
                return this.statementDocumentReferenceField;
            }
            set
            {
                this.statementDocumentReferenceField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("OriginatorDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] OriginatorDocumentReference
        {
            get
            {
                return this.originatorDocumentReferenceField;
            }
            set
            {
                this.originatorDocumentReferenceField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("ContractDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] ContractDocumentReference
        {
            get
            {
                return this.contractDocumentReferenceField;
            }
            set
            {
                this.contractDocumentReferenceField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] AdditionalDocumentReference
        {
            get
            {
                return this.additionalDocumentReferenceField;
            }
            set
            {
                this.additionalDocumentReferenceField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("ProjectReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ProjectReferenceType[] ProjectReference
        {
            get
            {
                return this.projectReferenceField;
            }
            set
            {
                this.projectReferenceField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType AccountingSupplierParty
        {
            get
            {
                return this.accountingSupplierPartyField;
            }
            set
            {
                this.accountingSupplierPartyField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType AccountingCustomerParty
        {
            get
            {
                return this.accountingCustomerPartyField;
            }
            set
            {
                this.accountingCustomerPartyField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType PayeeParty
        {
            get
            {
                return this.payeePartyField;
            }
            set
            {
                this.payeePartyField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType BuyerCustomerParty
        {
            get
            {
                return this.buyerCustomerPartyField;
            }
            set
            {
                this.buyerCustomerPartyField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType SellerSupplierParty
        {
            get
            {
                return this.sellerSupplierPartyField;
            }
            set
            {
                this.sellerSupplierPartyField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType TaxRepresentativeParty
        {
            get
            {
                return this.taxRepresentativePartyField;
            }
            set
            {
                this.taxRepresentativePartyField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DeliveryType[] Delivery
        {
            get
            {
                return this.deliveryField;
            }
            set
            {
                this.deliveryField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DeliveryTermsType DeliveryTerms
        {
            get
            {
                return this.deliveryTermsField;
            }
            set
            {
                this.deliveryTermsField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentMeansType[] PaymentMeans
        {
            get
            {
                return this.paymentMeansField;
            }
            set
            {
                this.paymentMeansField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentTermsType[] PaymentTerms
        {
            get
            {
                return this.paymentTermsField;
            }
            set
            {
                this.paymentTermsField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("PrepaidPayment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentType[] PrepaidPayment
        {
            get
            {
                return this.prepaidPaymentField;
            }
            set
            {
                this.prepaidPaymentField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public AllowanceChargeType[] AllowanceCharge
        {
            get
            {
                return this.allowanceChargeField;
            }
            set
            {
                this.allowanceChargeField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType TaxExchangeRate
        {
            get
            {
                return this.taxExchangeRateField;
            }
            set
            {
                this.taxExchangeRateField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PricingExchangeRate
        {
            get
            {
                return this.pricingExchangeRateField;
            }
            set
            {
                this.pricingExchangeRateField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentExchangeRate
        {
            get
            {
                return this.paymentExchangeRateField;
            }
            set
            {
                this.paymentExchangeRateField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ExchangeRateType PaymentAlternativeExchangeRate
        {
            get
            {
                return this.paymentAlternativeExchangeRateField;
            }
            set
            {
                this.paymentAlternativeExchangeRateField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotalType[] TaxTotal
        {
            get
            {
                return this.taxTotalField;
            }
            set
            {
                this.taxTotalField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("WithholdingTaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotalType[] WithholdingTaxTotal
        {
            get
            {
                return this.withholdingTaxTotalField;
            }
            set
            {
                this.withholdingTaxTotalField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public MonetaryTotalType LegalMonetaryTotal
        {
            get
            {
                return this.legalMonetaryTotalField;
            }
            set
            {
                this.legalMonetaryTotalField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlElementAttribute("InvoiceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public InvoiceLineType[] InvoiceLine
        {
            get
            {
                return this.invoiceLineField;
            }
            set
            {
                this.invoiceLineField = value;
            }
        }
        #endregion

        /// <summary>
        /// ***************************************************************************************************************************
        /// </summary>
        /// <returns></returns>
        public XmlSchema GetSchema()
        {
            return null;
        }
        public void ReadXml(XmlReader reader)
        {
            throw new NotImplementedException();
        }
        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("xmlns", EspacioNombres.xmlnsInvoice);
            writer.WriteAttributeString("xmlns:cac", EspacioNombres.cac);
            writer.WriteAttributeString("xmlns:cbc", EspacioNombres.cbc);
            writer.WriteAttributeString("xmlns:ccts", EspacioNombres.ccts);
            writer.WriteAttributeString("xmlns:ds", EspacioNombres.ds);
            writer.WriteAttributeString("xmlns:ext", EspacioNombres.ext);
            writer.WriteAttributeString("xmlns:qdt", EspacioNombres.qdt);
            //writer.WriteAttributeString("xmlns:sac", EspacioNombres.sac);
            writer.WriteAttributeString("xmlns:udt", EspacioNombres.udt);
            writer.WriteAttributeString("xmlns:xsi", EspacioNombres.xsi);

            //#region UBLExtensions
            //writer.WriteStartElement("ext:UBLExtensions");

            //#region UBLExtension
            ////var ext2 = ubl.Extension2.ExtensionContent.AdditionalInformation;
            //writer.WriteStartElement("ext:UBLExtension");

            //#region ExtensionContent
            //writer.WriteStartElement("ext:ExtensionContent");
            //writer.WriteEndElement();
            //#endregion

            //writer.WriteEndElement();
            //#endregion

            //writer.WriteEndElement();
            //#endregion
            #region UBLExtensions
            writer.WriteStartElement("ext:UBLExtensions");

            #region UBLExtension
            //var ext2 = UblExtensions.Extension2.ExtensionContent.AdditionalInformation;
            writer.WriteStartElement("ext:UBLExtension");

            #region ExtensionContent
            writer.WriteStartElement("ext:ExtensionContent");

            writer.WriteEndElement();
            #endregion

            writer.WriteEndElement();
            #endregion

            #region UBLExtension
            writer.WriteStartElement("ext:UBLExtension");
            #region ExtensionContent
            writer.WriteStartElement("ext:ExtensionContent");

            // En esta zona va el certificado digital.

            writer.WriteEndElement();
            #endregion
            writer.WriteEndElement();
            #endregion

            writer.WriteEndElement();
            #endregion
            //********************************CERTIFICADO DIGITAL*****************************

            //********************************************************************************************************
            writer.WriteElementString("cbc:UBLVersionID", UBLVersionID.Value);
            writer.WriteElementString("cbc:CustomizationID", CustomizationID.Value);
            writer.WriteElementString("cbc:ID", ID.Value);
            writer.WriteElementString("cbc:IssueDate", IssueDate.Value.ToString("yyyy-MM-dd"));
            writer.WriteElementString("cbc:IssueTime", IssueTime.Value.ToString("HH:mm:ss"));
            writer.WriteElementString("cbc:DueDate", DueDate.Value.ToString("yyyy-MM-dd"));

            writer.WriteStartElement("cbc:InvoiceTypeCode");
            writer.WriteAttributeString("listID", "0101");
            writer.WriteAttributeString("listAgencyName", "PE:SUNAT");
            writer.WriteAttributeString("listName", "SUNAT:Identificador de Tipo de Documento");
            writer.WriteAttributeString("listURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo01");
            writer.WriteString(InvoiceTypeCode.Value);
            writer.WriteEndElement();

            writer.WriteStartElement("cbc:Note");
            writer.WriteAttributeString("languageLocaleID", "1000");
            writer.WriteString(Note[0].Value);
            writer.WriteEndElement();

            writer.WriteStartElement("cbc:DocumentCurrencyCode");
            writer.WriteAttributeString("listID", "ISO 4217 Alpha");
            writer.WriteAttributeString("listName", "Currency");
            writer.WriteAttributeString("listAgencyName", "United Nations Economic Commission for Europe");
            writer.WriteString(DocumentCurrencyCode.Value);
            writer.WriteEndElement();

            writer.WriteElementString("cbc:LineCountNumeric", LineCountNumeric.Value.ToString());

            //*************************************************************************************************************************

            #region Signature
            writer.WriteStartElement("cac:Signature");
            writer.WriteElementString("cbc:ID", Signature[0].ID.Value);

            #region SignatoryParty

            writer.WriteStartElement("cac:SignatoryParty");
            writer.WriteStartElement("cac:PartyIdentification");
            writer.WriteElementString("cbc:ID", Signature[0].SignatoryParty.PartyIdentification[0].ID.Value);
            writer.WriteEndElement();

            #region PartyName
            writer.WriteStartElement("cac:PartyName");

            //writer.WriteStartElement("cbc:Name");
            //writer.WriteCData(Signature.SignatoryParty.PartyName.Name);
            //writer.WriteEndElement();
            writer.WriteElementString("cbc:Name", Signature[0].SignatoryParty.PartyName[0].Name.Value);

            writer.WriteEndElement();
            #endregion

            writer.WriteEndElement();
            #endregion

            #region DigitalSignatureAttachment
            writer.WriteStartElement("cac:DigitalSignatureAttachment");

            writer.WriteStartElement("cac:ExternalReference");
            writer.WriteElementString("cbc:URI", Signature[0].DigitalSignatureAttachment.ExternalReference.URI.Value);
            writer.WriteEndElement();

            writer.WriteEndElement();
            #endregion

            writer.WriteEndElement();
            #endregion

            //************************************************************************************************************************

            #region AccountingSupplierParty
            writer.WriteStartElement("cac:AccountingSupplierParty");

            #region Party
            writer.WriteStartElement("cac:Party");

            #region PartyIdentification
            writer.WriteStartElement("cac:PartyIdentification");

            writer.WriteStartElement("cbc:ID");
            writer.WriteAttributeString("schemeID", "6");
            writer.WriteAttributeString("schemeName", "SUNAT:Identificador de Documento de Identidad");
            writer.WriteAttributeString("schemeAgencyName", "PE:SUNAT"); 
            writer.WriteAttributeString("schemeURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo06");
            writer.WriteString(AccountingSupplierParty.AdditionalAccountID[0].Value);
            writer.WriteEndElement();

            writer.WriteEndElement();
            #endregion

            #region PartyName
            writer.WriteStartElement("cac:PartyName");
            writer.WriteElementString("cbc:Name", AccountingSupplierParty.Party.PartyName[0].Name.Value);
            writer.WriteEndElement();
            #endregion

            #region PartyLegalEntity
            writer.WriteStartElement("cac:PartyLegalEntity");
            writer.WriteElementString("cbc:RegistrationName",AccountingSupplierParty.Party.PartyLegalEntity[0].RegistrationName.Value);
            
            writer.WriteStartElement("cac:RegistrationAddress");
            writer.WriteElementString("cbc:AddressTypeCode", AccountingSupplierParty.Party.PostalAddress.ID.Value);
            writer.WriteEndElement();

            writer.WriteEndElement();
            #endregion

            writer.WriteEndElement();
            #endregion

            writer.WriteEndElement();
            #endregion

            //**************************************************************************************************************************
            
            #region AccountingCustomerParty
            writer.WriteStartElement("cac:AccountingCustomerParty");

            #region Party
            writer.WriteStartElement("cac:Party");

            writer.WriteStartElement("cac:PartyIdentification");

            writer.WriteStartElement("cbc:ID");
            writer.WriteAttributeString("schemeID", "6");
            writer.WriteAttributeString("schemeName", "SUNAT:Identificador de Documento de Identidad");
            writer.WriteAttributeString("schemeAgencyName", "PE:SUNAT");
            writer.WriteAttributeString("schemeURI", "urn:pe:gob:sunat:cpe:see:gem:catalogos:catalogo06");
            writer.WriteString(AccountingCustomerParty.CustomerAssignedAccountID.Value);
            writer.WriteEndElement();

            writer.WriteEndElement();

            #region cbc:PartyLegalEntity
            writer.WriteStartElement("cac:PartyLegalEntity");

            //writer.WriteStartElement("cbc:RegistrationName");
            //writer.WriteCData(AccountingCustomerParty.Party.PartyLegalEntity.RegistrationName);
            //writer.WriteEndElement();
            writer.WriteElementString("cbc:RegistrationName",
                AccountingCustomerParty.Party.PartyLegalEntity[0].RegistrationName.Value);

            writer.WriteEndElement();
            #endregion

            writer.WriteEndElement();
            #endregion

            writer.WriteEndElement();
            #endregion

            //*********************************************************************************************
            
            #region TaxTotal

            foreach (var taxTotal in TaxTotal)
            {
                writer.WriteStartElement("cac:TaxTotal");

                writer.WriteStartElement("cbc:TaxAmount");
                writer.WriteAttributeString("currencyID", taxTotal.TaxAmount.currencyID);
                writer.WriteString(taxTotal.TaxAmount.Value.ToString(Constantes.Constantes.FormatoNumerico, Formato));
                writer.WriteEndElement();

                #region TaxSubtotal
                {
                    writer.WriteStartElement("cac:TaxSubtotal");

                    writer.WriteStartElement("cbc:TaxableAmount");
                    writer.WriteAttributeString("currencyID", taxTotal.TaxSubtotal[0].TaxAmount.currencyID);
                    writer.WriteString(taxTotal.TaxSubtotal[0].TaxableAmount.Value.ToString(Constantes.Constantes.FormatoNumerico, Formato));
                    writer.WriteEndElement();

                    writer.WriteStartElement("cbc:TaxAmount");
                    writer.WriteAttributeString("currencyID", taxTotal.TaxSubtotal[0].TaxAmount.currencyID);
                    writer.WriteString(taxTotal.TaxAmount.Value.ToString(Constantes.Constantes.FormatoNumerico, Formato));
                    writer.WriteEndElement();

                    #region TaxCategory
                    {
                        writer.WriteStartElement("cac:TaxCategory");

                        writer.WriteStartElement("cbc:ID");
                        writer.WriteAttributeString("schemeID", "UN/ECE 5153");
                        writer.WriteAttributeString("schemeName", "Tax Category Identifier");
                        writer.WriteAttributeString("schemeAgencyName", "United Nations Economic Commission for Europe");
                        writer.WriteString(taxTotal.TaxSubtotal[0].TaxCategory.ID.Value);
                        writer.WriteEndElement();

                        #region TaxScheme
                        {
                            writer.WriteStartElement("cac:TaxScheme");

                            writer.WriteStartElement("cbc:ID");
                            writer.WriteAttributeString("schemeID", "UN/ECE 5153");
                            writer.WriteAttributeString("schemeAgencyID", "6");
                            writer.WriteString(taxTotal.TaxSubtotal[0].TaxCategory.TaxScheme.ID.Value);
                            writer.WriteEndElement();

                            writer.WriteElementString("cbc:Name", taxTotal.TaxSubtotal[0].TaxCategory.TaxScheme.Name.Value);
                            writer.WriteElementString("cbc:TaxTypeCode", taxTotal.TaxSubtotal[0].TaxCategory.TaxScheme.TaxTypeCode.Value);

                            writer.WriteEndElement();
                        }
                        #endregion

                        writer.WriteEndElement();
                    }
                    #endregion

                    writer.WriteEndElement();
                }
                #endregion
                writer.WriteEndElement();
            }
            #endregion

            //***********************************************************************************************************************

            //#region LegalMonetaryTotal
            //writer.WriteStartElement("cac:LegalMonetaryTotal");
            //{
            //    if (LegalMonetaryTotal.AllowanceTotalAmount.value > 0)
            //    {
            //        writer.WriteStartElement("cbc:AllowanceTotalAmount");
            //        {
            //            writer.WriteAttributeString("currencyID", LegalMonetaryTotal.AllowanceTotalAmount.currencyID);
            //            writer.WriteValue(LegalMonetaryTotal.AllowanceTotalAmount.value.ToString(Constantes.Constantes.FormatoNumerico, Formato));
            //        }
            //        writer.WriteEndElement();
            //    }
            //    writer.WriteStartElement("cbc:PayableAmount");
            //    {
            //        writer.WriteAttributeString("currencyID", LegalMonetaryTotal.PayableAmount.currencyID);
            //        writer.WriteValue(LegalMonetaryTotal.PayableAmount.value.ToString(Constantes.Constantes.FormatoNumerico, Formato));
            //    }
            //    writer.WriteEndElement();

            //}
            //writer.WriteEndElement();
            //#endregion

            //#region InvoiceLines
            //foreach (var invoiceLine in InvoiceLines)
            //{
            //    writer.WriteStartElement("cac:InvoiceLine");

            //    writer.WriteElementString("cbc:ID", invoiceLine.ID.ToString());

            //    #region InvoicedQuantity
            //    writer.WriteStartElement("cbc:InvoicedQuantity");
            //    writer.WriteAttributeString("unitCode", invoiceLine.InvoicedQuantity.unitCode);
            //    writer.WriteValue(invoiceLine.InvoicedQuantity.Value.ToString(Constantes.Constantes.FormatoNumerico, Formato));
            //    writer.WriteEndElement();
            //    #endregion

            //    #region LineExtensionAmount
            //    writer.WriteStartElement("cbc:LineExtensionAmount");
            //    writer.WriteAttributeString("currencyID", invoiceLine.LineExtensionAmount.currencyID);
            //    writer.WriteValue(invoiceLine.LineExtensionAmount.value.ToString(Constantes.Constantes.FormatoNumerico, Formato));
            //    writer.WriteEndElement();
            //    #endregion

            //    #region PricingReference
            //    writer.WriteStartElement("cac:PricingReference");

            //    #region AlternativeConditionPrice
            //    foreach (var item in invoiceLine.PricingReference.AlternativeConditionPrices)
            //    {
            //        writer.WriteStartElement("cac:AlternativeConditionPrice");

            //        #region PriceAmount
            //        writer.WriteStartElement("cbc:PriceAmount");
            //        writer.WriteAttributeString("currencyID", item.PriceAmount.currencyID);
            //        writer.WriteValue(item.PriceAmount.value.ToString(Constantes.Constantes.FormatoNumerico, Formato));
            //        writer.WriteEndElement();
            //        #endregion

            //        writer.WriteElementString("cbc:PriceTypeCode", item.PriceTypeCode);

            //        writer.WriteEndElement();
            //    }
            //    #endregion

            //    writer.WriteEndElement();
            //    #endregion

            //    #region AllowanceCharge
            //    if (invoiceLine.AllowanceCharge.ChargeIndicator)
            //    {
            //        writer.WriteStartElement("cac:AllowanceCharge");

            //        writer.WriteElementString("cbc:ChargeIndicator", invoiceLine.AllowanceCharge.ChargeIndicator.ToString());

            //        #region Amount
            //        writer.WriteStartElement("cbc:Amount");
            //        writer.WriteAttributeString("currencyID", invoiceLine.AllowanceCharge.Amount.currencyID);
            //        writer.WriteValue(invoiceLine.AllowanceCharge.Amount.value.ToString(Constantes.Constantes.FormatoNumerico, Formato));
            //        writer.WriteEndElement();
            //        #endregion

            //        writer.WriteEndElement();
            //    }
            //    #endregion

            //    #region TaxTotal
            //    {
            //        foreach (var taxTotal in invoiceLine.TaxTotals)
            //        {
            //            writer.WriteStartElement("cac:TaxTotal");

            //            writer.WriteStartElement("cbc:TaxAmount");
            //            writer.WriteAttributeString("currencyID", taxTotal.TaxAmount.currencyID);
            //            writer.WriteString(taxTotal.TaxAmount.value.ToString(Constantes.Constantes.FormatoNumerico, Formato));
            //            writer.WriteEndElement();

            //            #region TaxSubtotal
            //            writer.WriteStartElement("cac:TaxSubtotal");

            //            #region TaxableAmount

            //            if (!string.IsNullOrEmpty(taxTotal.TaxableAmount.currencyID))
            //            {
            //                writer.WriteStartElement("cbc:TaxableAmount");
            //                writer.WriteAttributeString("currencyID", taxTotal.TaxableAmount.currencyID);
            //                writer.WriteString(taxTotal.TaxableAmount.value.ToString(Constantes.Constantes.FormatoNumerico, Formato));
            //                writer.WriteEndElement();
            //            }

            //            #endregion

            //            writer.WriteStartElement("cbc:TaxAmount");
            //            writer.WriteAttributeString("currencyID", taxTotal.TaxSubtotal.TaxAmount.currencyID);
            //            writer.WriteString(taxTotal.TaxAmount.value.ToString(Constantes.Constantes.FormatoNumerico, Formato));
            //            writer.WriteEndElement();
            //            if (taxTotal.TaxSubtotal.Percent > 0)
            //                writer.WriteElementString("cbc:Percent", taxTotal.TaxSubtotal.Percent.ToString(Constantes.Constantes.FormatoNumerico, Formato));

            //            #region TaxCategory
            //            writer.WriteStartElement("cac:TaxCategory");
            //            //writer.WriteElementString("cbc:ID", invoiceLine.TaxTotal.TaxSubtotal.TaxCategory.ID);
            //            writer.WriteElementString("cbc:TaxExemptionReasonCode", taxTotal.TaxSubtotal.TaxCategory.TaxExemptionReasonCode.ToString());
            //            if (!string.IsNullOrEmpty(taxTotal.TaxSubtotal.TaxCategory.TierRange))
            //                writer.WriteElementString("cbc:TierRange", taxTotal.TaxSubtotal.TaxCategory.TierRange);

            //            #region TaxScheme
            //            {
            //                writer.WriteStartElement("cac:TaxScheme");

            //                writer.WriteElementString("cbc:ID", taxTotal.TaxSubtotal.TaxCategory.TaxScheme.ID);
            //                writer.WriteElementString("cbc:Name", taxTotal.TaxSubtotal.TaxCategory.TaxScheme.Name);
            //                writer.WriteElementString("cbc:TaxTypeCode", taxTotal.TaxSubtotal.TaxCategory.TaxScheme.TaxTypeCode);

            //                writer.WriteEndElement();
            //            }
            //            #endregion

            //            writer.WriteEndElement();
            //            #endregion

            //            writer.WriteEndElement();
            //            #endregion

            //            writer.WriteEndElement();
            //        }
            //    }
            //    #endregion

            //    #region Item
            //    writer.WriteStartElement("cac:Item");

            //    #region Description
            //    writer.WriteElementString("cbc:Description", invoiceLine.Item.Description);
            //    //writer.WriteStartElement("cbc:Description");
            //    //writer.WriteCData(invoiceLine.Item.Description);
            //    //writer.WriteEndElement();
            //    #endregion

            //    #region SellersItemIdentification
            //    writer.WriteStartElement("cac:SellersItemIdentification");
            //    writer.WriteElementString("cbc:ID", invoiceLine.Item.SellersItemIdentification.ID);
            //    writer.WriteEndElement();
            //    #endregion


            //    writer.WriteEndElement();
            //    #endregion

            //    #region Price
            //    writer.WriteStartElement("cac:Price");

            //    writer.WriteStartElement("cbc:PriceAmount");
            //    writer.WriteAttributeString("currencyID", invoiceLine.Price.PriceAmount.currencyID);
            //    writer.WriteString(invoiceLine.Price.PriceAmount.value.ToString(Constantes.Constantes.FormatoNumerico, Formato));
            //    writer.WriteEndElement();

            //    writer.WriteEndElement();
            //    #endregion

            //    writer.WriteEndElement();
            //}
            //#endregion

        }


    }
}
