namespace EasyFact.Controller
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml;
    using System.Xml.Serialization;
    using EasyFact.Models;
    public class DocumentoElectronicoController
    {
        public List<string> RecibeDocumentoElectronio(DocumentoElectronicoModel DocElec)
        {
            List<string> Respuesta;
            try
            {
                Respuesta = ValidaTramaEN(DocElec.Trama.EN);
                Respuesta = GeneraDocumentoXML(DocElec);

                return Respuesta;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #region ValidacionesInvoice
        private List<String> ValidaTramaEN(string EN)
        {
            List<string> Respuesta = new List<string>();
            try
            {
                string[] Cabecera = EN.Split('|');


                return Respuesta;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region GeneracionXML
        private List<String> GeneraDocumentoXML(DocumentoElectronicoModel Doc)
        {
            try
            {
                #region EN-ENEX

                string[] Cabecera = Doc.Trama.EN.Split('|');
                //Falta Validar signatureCac
                SignatureType[] signatureCac = new SignatureType[]
                {
                    new SignatureType()
                {
                    ID = new IDType { Value= "LlamaSign" },
                    SignatoryParty = new PartyType
                    {
                        PartyIdentification = new PartyIdentificationType[]
                        {
                            new PartyIdentificationType
                            {
                                ID = new IDType
                                {
                                    schemeID = Cabecera[8].ToString(),
                                    Value = Cabecera[8].ToString()
                                }
                            }
                        },
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = new NameType1{ Value=Cabecera[10].ToString() }
                            }
                        }
                    },
                    DigitalSignatureAttachment = new AttachmentType
                    {
                        ExternalReference = new ExternalReferenceType
                        {
                            URI = new URIType { Value= Cabecera[8].ToString() }
                        }
                    }
                }
                };

                SupplierPartyType accountingSupplierParty = new SupplierPartyType()
                {
                    Party = new PartyType
                    {
                        PartyLegalEntity = new PartyLegalEntityType[]
                        {
                            new PartyLegalEntityType
                            {
                                RegistrationName = new RegistrationNameType
                                {
                                    Value=Cabecera[10].ToString()
                                },
                            }
                        },
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = new NameType1{Value=Cabecera[11].ToString()}
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            ID = new IDType { Value = "0001" },
                            District = new DistrictType { Value = Cabecera[16].ToString() },
                            CityName = new CityNameType { Value = Cabecera[14].ToString() },
                            StreetName = new StreetNameType { Value = "" },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = "" },
                            Country = new CountryType
                            {
                                IdentificationCode = new IdentificationCodeType { Value = "" }
                            },
                            CountrySubentity = new CountrySubentityType { Value = "" },

                        }
                    },
                    AdditionalAccountID = new AdditionalAccountIDType[]
                    {
                        new AdditionalAccountIDType{ Value=Cabecera[8].ToString()}
                    },
                    CustomerAssignedAccountID = new CustomerAssignedAccountIDType { Value = Cabecera[8].ToString() }
                };

                CustomerPartyType accountingCustomerParty = new CustomerPartyType()
                {
                    Party = new PartyType
                    {
                        PartyLegalEntity = new PartyLegalEntityType[]
                        {
                            new PartyLegalEntityType
                            {
                                RegistrationName = new RegistrationNameType
                                {
                                    Value=Cabecera[19].ToString(),
                                }
                            }
                        },
                        PartyName = new PartyNameType[]
                        {
                            new PartyNameType
                            {
                                Name = new NameType1{Value=Cabecera[19].ToString()}
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            ID = new IDType { Value = "0001" },
                            District = new DistrictType { Value = "a" },
                            CityName = new CityNameType { Value = "a" },
                            StreetName = new StreetNameType { Value = "" },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = "" },
                            Country = new CountryType
                            {
                                IdentificationCode = new IdentificationCodeType { Value = "aaa" }
                            },
                            CountrySubentity = new CountrySubentityType { Value = "" },

                        }
                    },
                    AdditionalAccountID = new AdditionalAccountIDType[]
                    {
                        new AdditionalAccountIDType{ Value=Cabecera[18].ToString()}
                    },
                    CustomerAssignedAccountID = new CustomerAssignedAccountIDType { Value = Cabecera[18].ToString() }
                };
                #endregion


                List<TaxTotalType> taxTotal = new List<TaxTotalType>()
                {
                    new TaxTotalType()
                    {
                        TaxAmount = new TaxAmountType{currencyID="PEN",Value=Convert.ToDecimal(7891.2)},
                        TaxSubtotal = new TaxSubtotalType[]
                        {
                            new TaxSubtotalType
                            {
                                TaxAmount = new TaxAmountType{currencyID="PEN",Value=Convert.ToDecimal(7891.2)},
                                TaxableAmount= new TaxableAmountType{Value=Convert.ToDecimal(43840.00)},
                                TaxCategory = new TaxCategoryType
                                {
                                    ID= new IDType{ Value="S" },
                                    TierRange= new TierRangeType{ Value="s" },
                                    TaxExemptionReasonCode= new TaxExemptionReasonCodeType
                                    {
                                        Value=""
                                    },
                                    TaxScheme = new TaxSchemeType
                                    {
                                        ID= new IDType{ Value="1000" },
                                        Name= new NameType1{ Value="IGV" },
                                        TaxTypeCode= new TaxTypeCodeType{ Value="VAT" }
                                    }
                                },
                                Percent=  new PercentType1{ Value=18 }
                        }
                    },

                }
                };

                MonetaryTotalType legalMonetaryTotal = new MonetaryTotalType()
                {
                    PayableAmount = new PayableAmountType { currencyID = "PEN", Value = 15485 },
                    AllowanceTotalAmount = new AllowanceTotalAmountType { currencyID = "PEN", Value = 15424 },
                    ChargeTotalAmount = new ChargeTotalAmountType { currencyID = "PEN", Value = 5555 }
                };
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement xmlElement = xmlDoc.CreateElement("AdditionalInformation", "urn:sunat:names:specification:ubl:peru:schema:xsd:SunatAggregateComponents-1");
                UBLExtensionType[] uBLExtensions = new UBLExtensionType[]
                {
                    new UBLExtensionType
                    {
                        ExtensionContent = xmlElement
                    },
                    new UBLExtensionType()
                    {
                        ExtensionContent = xmlElement
                    },
                    //Extension1 = new UBLExtension { ExtensionContent = new ExtensionContent { AdditionalInformation = new AdditionalInformation { AdditionalMonetaryTotals = new List<AdditionalMonetaryTotal>(), SunatTransaction = new SunatTransaction(), AdditionalProperties = new List<AdditionalProperty>() } } },
                    //Extension2 = new UBLExtension { ExtensionContent = new ExtensionContent { AdditionalInformation = new AdditionalInformation { AdditionalMonetaryTotals = new List<AdditionalMonetaryTotal>(), SunatTransaction = new SunatTransaction(), AdditionalProperties = new List<AdditionalProperty>() } } },
                };

                Invoice invoice = new Invoice()
                {
                    UBLExtensions = uBLExtensions,
                    UBLVersionID = new UBLVersionIDType
                    {
                        Value = "2.1"
                    },
                    ID = new IDType
                    {
                        Value = "F001-1"
                    },
                    CustomizationID = new CustomizationIDType
                    {
                        Value = "2.0"
                    },
                    IssueDate = new IssueDateType
                    {
                        Value = Convert.ToDateTime("2017-05-14 15:42:20")
                    },
                    IssueTime = new IssueTimeType
                    {
                        Value = Convert.ToDateTime("2017-05-14 15:42:20"),
                    },
                    DueDate = new DueDateType
                    {
                        Value = Convert.ToDateTime("2017-05-15 15:42:20"),
                    },
                    InvoiceTypeCode = new InvoiceTypeCodeType
                    {
                        Value = "01"
                    },
                    Note = new List<NoteType>
                    {
                        new NoteType {Value="SETENTA Y UN MIL TRESCIENTOS CINCUENTICUATRO Y 99/100"}
                    }.ToArray(),
                    DocumentCurrencyCode = new DocumentCurrencyCodeType
                    {
                        Value = "PEN"
                    },
                    LineCountNumeric = new LineCountNumericType
                    {
                        Value = 1
                    },
                    Signature = signatureCac,
                    AccountingSupplierParty = accountingSupplierParty,
                    AccountingCustomerParty = accountingCustomerParty,
                    TaxTotal = taxTotal.ToArray(),
                    LegalMonetaryTotal = legalMonetaryTotal,

                };


                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Invoice));

                using (Stream stream = new FileStream(@"D:\"+ Doc.Ruc+"-"+ Doc .Local + "-" + Doc.TipoDocumento + "-"+Doc.NumDocumento+ ".xml", FileMode.Create))
                using (XmlWriter xmlWriter = new XmlTextWriter(stream, Encoding.Unicode))
                {
                    xmlSerializer.Serialize(xmlWriter, invoice);
                }

                return new List<string>();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        #endregion

    }
}
