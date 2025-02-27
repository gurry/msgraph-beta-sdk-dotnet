// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Company.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Company : Entity
    {
    
        /// <summary>
        /// Gets or sets system version.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "systemVersion", Required = Newtonsoft.Json.Required.Default)]
        public string SystemVersion { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets business profile id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "businessProfileId", Required = Newtonsoft.Json.Required.Default)]
        public string BusinessProfileId { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyItemsCollectionPage Items { get; set; }
    
        /// <summary>
        /// Gets or sets customers.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customers", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyCustomersCollectionPage Customers { get; set; }
    
        /// <summary>
        /// Gets or sets vendors.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vendors", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyVendorsCollectionPage Vendors { get; set; }
    
        /// <summary>
        /// Gets or sets company information.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "companyInformation", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyCompanyInformationCollectionPage CompanyInformation { get; set; }
    
        /// <summary>
        /// Gets or sets sales invoices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "salesInvoices", Required = Newtonsoft.Json.Required.Default)]
        public ICompanySalesInvoicesCollectionPage SalesInvoices { get; set; }
    
        /// <summary>
        /// Gets or sets sales invoice lines.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "salesInvoiceLines", Required = Newtonsoft.Json.Required.Default)]
        public ICompanySalesInvoiceLinesCollectionPage SalesInvoiceLines { get; set; }
    
        /// <summary>
        /// Gets or sets customer payment journals.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customerPaymentJournals", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyCustomerPaymentJournalsCollectionPage CustomerPaymentJournals { get; set; }
    
        /// <summary>
        /// Gets or sets customer payments.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customerPayments", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyCustomerPaymentsCollectionPage CustomerPayments { get; set; }
    
        /// <summary>
        /// Gets or sets accounts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accounts", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyAccountsCollectionPage Accounts { get; set; }
    
        /// <summary>
        /// Gets or sets tax groups.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "taxGroups", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyTaxGroupsCollectionPage TaxGroups { get; set; }
    
        /// <summary>
        /// Gets or sets journals.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "journals", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyJournalsCollectionPage Journals { get; set; }
    
        /// <summary>
        /// Gets or sets journal lines.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "journalLines", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyJournalLinesCollectionPage JournalLines { get; set; }
    
        /// <summary>
        /// Gets or sets employees.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "employees", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyEmployeesCollectionPage Employees { get; set; }
    
        /// <summary>
        /// Gets or sets general ledger entries.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "generalLedgerEntries", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyGeneralLedgerEntriesCollectionPage GeneralLedgerEntries { get; set; }
    
        /// <summary>
        /// Gets or sets currencies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currencies", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyCurrenciesCollectionPage Currencies { get; set; }
    
        /// <summary>
        /// Gets or sets payment methods.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "paymentMethods", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyPaymentMethodsCollectionPage PaymentMethods { get; set; }
    
        /// <summary>
        /// Gets or sets dimensions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dimensions", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyDimensionsCollectionPage Dimensions { get; set; }
    
        /// <summary>
        /// Gets or sets dimension values.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dimensionValues", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyDimensionValuesCollectionPage DimensionValues { get; set; }
    
        /// <summary>
        /// Gets or sets payment terms.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "paymentTerms", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyPaymentTermsCollectionPage PaymentTerms { get; set; }
    
        /// <summary>
        /// Gets or sets shipment methods.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shipmentMethods", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyShipmentMethodsCollectionPage ShipmentMethods { get; set; }
    
        /// <summary>
        /// Gets or sets item categories.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "itemCategories", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyItemCategoriesCollectionPage ItemCategories { get; set; }
    
        /// <summary>
        /// Gets or sets countries regions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "countriesRegions", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyCountriesRegionsCollectionPage CountriesRegions { get; set; }
    
        /// <summary>
        /// Gets or sets sales orders.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "salesOrders", Required = Newtonsoft.Json.Required.Default)]
        public ICompanySalesOrdersCollectionPage SalesOrders { get; set; }
    
        /// <summary>
        /// Gets or sets sales order lines.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "salesOrderLines", Required = Newtonsoft.Json.Required.Default)]
        public ICompanySalesOrderLinesCollectionPage SalesOrderLines { get; set; }
    
        /// <summary>
        /// Gets or sets units of measure.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unitsOfMeasure", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyUnitsOfMeasureCollectionPage UnitsOfMeasure { get; set; }
    
        /// <summary>
        /// Gets or sets aged accounts receivable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "agedAccountsReceivable", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyAgedAccountsReceivableCollectionPage AgedAccountsReceivable { get; set; }
    
        /// <summary>
        /// Gets or sets aged accounts payable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "agedAccountsPayable", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyAgedAccountsPayableCollectionPage AgedAccountsPayable { get; set; }
    
        /// <summary>
        /// Gets or sets tax areas.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "taxAreas", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyTaxAreasCollectionPage TaxAreas { get; set; }
    
        /// <summary>
        /// Gets or sets sales quotes.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "salesQuotes", Required = Newtonsoft.Json.Required.Default)]
        public ICompanySalesQuotesCollectionPage SalesQuotes { get; set; }
    
        /// <summary>
        /// Gets or sets sales quote lines.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "salesQuoteLines", Required = Newtonsoft.Json.Required.Default)]
        public ICompanySalesQuoteLinesCollectionPage SalesQuoteLines { get; set; }
    
        /// <summary>
        /// Gets or sets sales credit memos.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "salesCreditMemos", Required = Newtonsoft.Json.Required.Default)]
        public ICompanySalesCreditMemosCollectionPage SalesCreditMemos { get; set; }
    
        /// <summary>
        /// Gets or sets sales credit memo lines.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "salesCreditMemoLines", Required = Newtonsoft.Json.Required.Default)]
        public ICompanySalesCreditMemoLinesCollectionPage SalesCreditMemoLines { get; set; }
    
        /// <summary>
        /// Gets or sets purchase invoices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "purchaseInvoices", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyPurchaseInvoicesCollectionPage PurchaseInvoices { get; set; }
    
        /// <summary>
        /// Gets or sets purchase invoice lines.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "purchaseInvoiceLines", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyPurchaseInvoiceLinesCollectionPage PurchaseInvoiceLines { get; set; }
    
        /// <summary>
        /// Gets or sets picture.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "picture", Required = Newtonsoft.Json.Required.Default)]
        public ICompanyPictureCollectionPage Picture { get; set; }
    
    }
}

