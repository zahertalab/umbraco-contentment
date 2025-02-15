//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.17.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Test Data List Page</summary>
	[PublishedModel("testDataListPage")]
	public partial class TestDataListPage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public new const string ModelTypeAlias = "testDataListPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TestDataListPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public TestDataListPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Data List Countries
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListCountries")]
		public virtual global::System.Collections.Generic.List<string> DataListCountries => this.Value<global::System.Collections.Generic.List<string>>("dataListCountries");

		///<summary>
		/// Data List CSV
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListCsv")]
		public virtual string DataListCsv => this.Value<string>("dataListCsv");

		///<summary>
		/// Data List Currencies
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListCurrencies")]
		public virtual global::System.Collections.Generic.List<string> DataListCurrencies => this.Value<global::System.Collections.Generic.List<string>>("dataListCurrencies");

		///<summary>
		/// Data List Enumeration
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListEnumeration")]
		public virtual global::System.Collections.Generic.List<global::System.ConsoleColor> DataListEnumeration => this.Value<global::System.Collections.Generic.List<global::System.ConsoleColor>>("dataListEnumeration");

		///<summary>
		/// Data List File System
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListFileSystem")]
		public virtual global::System.Collections.Generic.List<string> DataListFileSystem => this.Value<global::System.Collections.Generic.List<string>>("dataListFileSystem");

		///<summary>
		/// Data List JSON
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListJson")]
		public virtual string DataListJson => this.Value<string>("dataListJson");

		///<summary>
		/// Data List Languages
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListLanguages")]
		public virtual global::System.Collections.Generic.List<string> DataListLanguages => this.Value<global::System.Collections.Generic.List<string>>("dataListLanguages");

		///<summary>
		/// Data List Number Range
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListNumberRange")]
		public virtual double DataListNumberRange => this.Value<double>("dataListNumberRange");

		///<summary>
		/// Data List SQL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListSql")]
		public virtual string DataListSql => this.Value<string>("dataListSql");

		///<summary>
		/// Data List Time Zones
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListTimeZones")]
		public virtual global::System.Collections.Generic.List<global::System.TimeZoneInfo> DataListTimeZones => this.Value<global::System.Collections.Generic.List<global::System.TimeZoneInfo>>("dataListTimeZones");

		///<summary>
		/// Data List uCssClassName
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUCssClassName")]
		public virtual global::System.Collections.Generic.List<string> DataListUcssClassName => this.Value<global::System.Collections.Generic.List<string>>("dataListUCssClassName");

		///<summary>
		/// Data List Umbraco Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUmbracoContent")]
		public virtual global::Umbraco.Core.Models.PublishedContent.IPublishedContent DataListUmbracoContent => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("dataListUmbracoContent");

		///<summary>
		/// Data List Umbraco Content by XPath
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUmbracoContentByXPath")]
		public virtual global::Umbraco.Core.Models.PublishedContent.IPublishedContent DataListUmbracoContentByXpath => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("dataListUmbracoContentByXPath");

		///<summary>
		/// Data List Umbraco Content Properties
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUmbracoContentProperties")]
		public virtual string DataListUmbracoContentProperties => this.Value<string>("dataListUmbracoContentProperties");

		///<summary>
		/// Data List Umbraco Content Types
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUmbracoContentTypes")]
		public virtual global::Umbraco.Core.Models.PublishedContent.IPublishedContentType DataListUmbracoContentTypes => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContentType>("dataListUmbracoContentTypes");

		///<summary>
		/// Data List Umbraco Dictionary Items
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUmbracoDictionaryItems")]
		public virtual string DataListUmbracoDictionaryItems => this.Value<string>("dataListUmbracoDictionaryItems");

		///<summary>
		/// Data List Umbraco Entities
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUmbracoEntities")]
		public virtual global::Umbraco.Core.Models.Entities.IEntitySlim DataListUmbracoEntities => this.Value<global::Umbraco.Core.Models.Entities.IEntitySlim>("dataListUmbracoEntities");

		///<summary>
		/// Data List Umbraco Examine Query
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUmbracoExamineQuery")]
		public virtual string DataListUmbracoExamineQuery => this.Value<string>("dataListUmbracoExamineQuery");

		///<summary>
		/// Data List Umbraco Image Crops
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUmbracoImageCrops")]
		public virtual string DataListUmbracoImageCrops => this.Value<string>("dataListUmbracoImageCrops");

		///<summary>
		/// Data List Umbraco Languages
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUmbracoLanguages")]
		public virtual string DataListUmbracoLanguages => this.Value<string>("dataListUmbracoLanguages");

		///<summary>
		/// Data List Umbraco Member Groups: Add member groups to test this.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUmbracoMemberGroups")]
		public virtual global::System.Guid DataListUmbracoMemberGroups => this.Value<global::System.Guid>("dataListUmbracoMemberGroups");

		///<summary>
		/// Data List Umbraco Members: Add members to test this.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUmbracoMembers")]
		public virtual global::Umbraco.Core.Models.PublishedContent.IPublishedContent DataListUmbracoMembers => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("dataListUmbracoMembers");

		///<summary>
		/// Data List Umbraco Tags
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUmbracoTags")]
		public virtual string DataListUmbracoTags => this.Value<string>("dataListUmbracoTags");

		///<summary>
		/// Data List Umbraco User Groups
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUmbracoUserGroups")]
		public virtual global::Umbraco.Core.Models.Membership.IUserGroup DataListUmbracoUserGroups => this.Value<global::Umbraco.Core.Models.Membership.IUserGroup>("dataListUmbracoUserGroups");

		///<summary>
		/// Data List Umbraco Users
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUmbracoUsers")]
		public virtual global::Umbraco.Core.Models.Membership.IUser DataListUmbracoUsers => this.Value<global::Umbraco.Core.Models.Membership.IUser>("dataListUmbracoUsers");

		///<summary>
		/// Data List User-defined
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListUserDefined")]
		public virtual string DataListUserDefined => this.Value<string>("dataListUserDefined");

		///<summary>
		/// Data List XML
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListXml")]
		public virtual string DataListXml => this.Value<string>("dataListXml");

		///<summary>
		/// Data List XML Sitemap Change Frequency
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListXmlSitemapChangeFrequency")]
		public virtual string DataListXmlSitemapChangeFrequency => this.Value<string>("dataListXmlSitemapChangeFrequency");

		///<summary>
		/// Data List XML Sitemap: Priority
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("dataListXmlSitemapPriority")]
		public virtual string DataListXmlSitemapPriority => this.Value<string>("dataListXmlSitemapPriority");
	}
}
