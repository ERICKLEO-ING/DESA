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
    using EasyFact.Constantes;
    using EasyFact.Models;
    public class DocumentoElectronicoController
    {
        public IFormatProvider Formato { get; set; }
        public List<string> RecibeDocumentoElectronio(DocumentoElectronicoModel DocElec)
        {
            List<string> Respuesta;
            try
            {
                // InvoiceLine(DocElec.Trama.ITEM, "PEN");
                //Respuesta = ValidaTramaEN(DocElec.Trama.EN);
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
                //Falta Validar signatureCac Tipo de firma
                // para la firma
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

                //proveedor
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

                //cliente
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
                            District = new DistrictType { Value = "Distrito" },
                            CityName = new CityNameType { Value = "Ciudad" },
                            StreetName = new StreetNameType { Value = "Calle 1" },
                            CitySubdivisionName = new CitySubdivisionNameType { Value = "" },
                            Country = new CountryType
                            {
                                IdentificationCode = new IdentificationCodeType { Value = "PE" }
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

                #region Montos - IGV - INAFECTOS - OTROS (cac:TaxTotal)
                //Impuestos
                List<TaxTotalType> taxTotal = new List<TaxTotalType>();
                foreach (var Impuestos in Doc.Trama.DI)
                {
                    string[] IMP = Impuestos.Split('|');
                    TaxTotalType taxTotalType = new TaxTotalType()
                    {
                        TaxAmount = new TaxAmountType { currencyID = "PEN", Value = Convert.ToDecimal(Cabecera[1].ToString()) },
                        TaxSubtotal = new TaxSubtotalType[]
                        {
                            new TaxSubtotalType
                            {
                                TaxAmount = new TaxAmountType{currencyID="PEN",Value=Convert.ToDecimal(Cabecera[2].ToString())},
                                TaxableAmount= new TaxableAmountType{Value=Convert.ToDecimal(Cabecera[6].ToString())},
                                TaxCategory = new TaxCategoryType
                                {
                                    ID= new IDType{ Value="S" },
                                    TierRange= new TierRangeType{ Value="S" },
                                    TaxExemptionReasonCode= new TaxExemptionReasonCodeType
                                    {
                                        Value=""
                                    },
                                    TaxScheme = new TaxSchemeType
                                    {
                                        ID= new IDType{ Value=Cabecera[3].ToString() },
                                        Name= new NameType1{ Value=Cabecera[4].ToString() },
                                        TaxTypeCode= new TaxTypeCodeType{ Value=Cabecera[5].ToString() }
                                    }
                                },
                                Percent=  new PercentType1{ Value=18 }
                            }
                        },

                    };
                    taxTotal.Add(taxTotalType);
                }

                #endregion

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

                Invoice Factura_Boleta = new Invoice()
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
                    ProfileID = new ProfileIDType
                    {
                        Value = "0101"
                    },
                    InvoiceLine = InvoiceLine(Doc.Trama.ITEM, "PEN")
            };


                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Invoice));

                using (Stream stream = new FileStream(@"D:\" + Doc.Ruc + "-" + Doc.Local + "-" + Doc.TipoDocumento + "-" + Doc.NumDocumento + ".xml", FileMode.Create))
                using (XmlWriter xmlWriter = new XmlTextWriter(stream, Encoding.Unicode))
                {
                    xmlSerializer.Serialize(xmlWriter, Factura_Boleta);
                }

                return new List<string>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        /// <summary>
        /// Generacion de InvoiceLine
        /// </summary>
        /// <returns></returns>
        private InvoiceLineType[] InvoiceLine(List<ITEM> ITEM_collection, string Moneda)
        {
            Moneda = "PEN";
            //string PESUNAT = "PE:SUNAT";
            List<InvoiceLineType> Items_Respuesta = new List<InvoiceLineType>(); ;
            try
            {
                foreach (var item in ITEM_collection)
                {
                    #region InvoiceLine
                    string[] DE = item.DE.Split('|');
                    string[] DEDR = item.DEDR.Split('|');
                    List<string> DEIM_LIST = item.DEIM;//.Split('|');
                    string[] DEDI = item.DEDI.Split('|');
                    InvoiceLineType Linea = new InvoiceLineType();
                    {
                        //numero de orden del item
                        Linea.ID = new IDType()
                        {
                            Value = DE[1].ToString()
                        };
                        //(InvoicedQuantity)cantidad de unidades del item
                        Linea.InvoicedQuantity = new InvoicedQuantityType()
                        {
                            Value = Convert.ToDecimal(DE[4].ToString()),
                            unitCode = DE[3].ToString(),
                            unitCodeListID = "UN/ECE rec 20",
                            unitCodeListAgencyName = "United Nations Economic Commission for Europe"
                        };
                        //(LineExtensionAmount)Valor de Venta del item
                        Linea.LineExtensionAmount = new LineExtensionAmountType()
                        {
                            Value = Convert.ToDecimal(DE[5].ToString()),
                            currencyID = Moneda
                        };

                        #region PricingReference
                        Linea.PricingReference = new PricingReferenceType()
                        {
                            //AlternativeConditionPrice
                            AlternativeConditionPrice = new PriceType[]
                            {
                               new PriceType()
                               {
                                   //(PriceAmount) precoi de venta unitario/ valor referencial
                                   PriceAmount = new PriceAmountType()
                                   {
                                       Value=Convert.ToDecimal(DE[2].ToString()),
                                       currencyID=Moneda
                                   },
                                   //(PriceTypeCode) codigo de tipo de precio
                                   PriceTypeCode = new PriceTypeCodeType()
                                   {
                                       Value = DE[7].ToString(),
                                       listName = "SUNAT:Indicador de Tipo de Precio",
                                       listAgencyName = ConstantesAtributo.PESUNAT,
                                       listURI = ConstantesAtributo.CATALOGO16
                                   }
                               }
                            }
                        };
                        #endregion

                        #region Delivery

                        #endregion

                        //Descuentos o Recargos
                        #region AllowanceCharge
                        Linea.AllowanceCharge = new AllowanceChargeType[]
                        {
                            new AllowanceChargeType()
                            {
                                ChargeIndicator =  new ChargeIndicatorType()
                                {
                                    Value= DEDR[1].ToString()=="true"?true :false
                                },
                                AllowanceChargeReasonCode = new AllowanceChargeReasonCodeType()
                                {
                                    Value=DEDR[3].ToString()
                                },
                                MultiplierFactorNumeric = new MultiplierFactorNumericType()
                                {
                                    Value = Convert.ToDecimal(DEDR[4].ToString())
                                },
                                Amount = new AmountType2()
                                {
                                    Value = Convert.ToDecimal(DEDR[2].ToString()),
                                    currencyID= Moneda
                                },
                                BaseAmount = new BaseAmountType()
                                {
                                    Value = Convert.ToDecimal(DEDR[5].ToString()),
                                    currencyID= Moneda
                                }
                            }
                        };
                        #endregion

                        //Monto de tributo del item
                        #region TaxTotal
                        List<TaxTotalType> taxTotals = new List<TaxTotalType>();
                        foreach (var DEIM in DEIM_LIST)
                        {
                            TaxTotalType taxTotalType = new TaxTotalType()
                            {
                                //Monto de tributo del ítem
                                TaxAmount = new TaxAmountType()
                                {
                                    Value = Convert.ToDecimal(DEIM[1].ToString()),
                                    currencyID = Moneda
                                },
                                TaxSubtotal = new TaxSubtotalType[]
                                {
                                    new TaxSubtotalType()
                                    {
                                        //Monto de la Operacion
                                        TaxableAmount = new TaxableAmountType()
                                        {
                                             Value=Convert.ToDecimal(DEIM[2].ToString()),
                                             currencyID = Moneda
                                        },
                                        //Monto de Tributo por Item
                                        TaxAmount = new TaxAmountType()
                                        {
                                             Value=Convert.ToDecimal(DEIM[3].ToString()),
                                             currencyID = Moneda
                                        },

                                        TaxCategory =  new TaxCategoryType()
                                        {
                                            ID = new IDType()
                                            {
                                                Value="S",
                                                schemeID = ConstantesAtributo.UNECE5305,
                                                schemeAgencyID ="6"
                                            },
                                            Percent= new PercentType1
                                            {
                                                Value = Convert.ToDecimal( DEIM[4].ToString())
                                            },
                                            TaxExemptionReasonCode= new TaxExemptionReasonCodeType()
                                            {
                                                Value =  DEIM[6].ToString(),
                                                listAgencyName = ConstantesAtributo.PESUNAT,
                                                listName = "SUNAT:Codigo de Tipo de Afectación del IGV",
                                                listURI=ConstantesAtributo.CATALOGO07
                                            },
                                            TaxScheme = new TaxSchemeType()
                                            {
                                                ID = new IDType()
                                                {
                                                    Value= DEIM[8].ToString(),

                                                },
                                                Name = new NameType1()
                                                {
                                                    Value= DEIM[9].ToString(),
                                                },
                                                TaxTypeCode = new TaxTypeCodeType()
                                                {
                                                    Value= DEIM[5].ToString()
                                                }
                                            }

                                        }
                                    }
                                }
                            };
                            taxTotals.Add(taxTotalType);
                        }
                        Linea.TaxTotal = taxTotals.ToArray();

                        #endregion

                        #region Item
                        Linea.Item = new ItemType()
                        {
                            Description = new DescriptionType[]
                            {
                                new DescriptionType()
                                {
                                    Value = DEDI[1].ToString()
                                }
                            },
                            SellersItemIdentification = new ItemIdentificationType()
                            {
                                ID = new IDType()
                                {
                                    Value = DE[6].ToString()
                                }
                            },
                            CommodityClassification = new CommodityClassificationType[]
                            {
                                new CommodityClassificationType()
                                {
                                    ItemClassificationCode = new ItemClassificationCodeType()
                                    {
                                        Value = DEDI[6].ToString()
                                    }
                                }
                            }
                        };
                        #endregion

                        #region Price
                        Linea.Price = new PriceType()
                        {
                            PriceAmount = new PriceAmountType()
                            {
                                Value = Convert.ToDecimal(DE[8].ToString()),
                            }
                        };
                        #endregion
                    }
                    #endregion

                    Items_Respuesta.Add(Linea);
                }
                return Items_Respuesta.ToArray();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
