﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 
namespace OSATypes
{

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]

	[System.Diagnostics.DebuggerStepThroughAttribute()]

	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class TileSet
	{

		private object[] itemsField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TileSize", typeof(TileSetTileSize), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[System.Xml.Serialization.XmlElementAttribute("TileTemplates", typeof(TileSetTileTemplates), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		[XmlChoiceIdentifier("TileSetTypesArray")]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		public TileSetTypes[] TileSetTypesArray;

	}

	public enum TileSetTypes
	{
		TileSize,
		TileTemplates
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]

	[System.Diagnostics.DebuggerStepThroughAttribute()]

	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TileSetTileSize
	{

		private string widthField;

		private string heightField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Width
		{
			get
			{
				return this.widthField;
			}
			set
			{
				this.widthField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Height
		{
			get
			{
				return this.heightField;
			}
			set
			{
				this.heightField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]

	[System.Diagnostics.DebuggerStepThroughAttribute()]

	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TileSetTileTemplates
	{

		private TileSetTileTemplatesTileTemplate[] tileTemplateField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("TileTemplate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public TileSetTileTemplatesTileTemplate[] TileTemplate
		{
			get
			{
				return this.tileTemplateField;
			}
			set
			{
				this.tileTemplateField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]

	[System.Diagnostics.DebuggerStepThroughAttribute()]

	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class TileSetTileTemplatesTileTemplate
	{

		private string pathField;

		private string gridSymbolField;

		private string heightField;

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Path
		{
			get
			{
				return this.pathField;
			}
			set
			{
				this.pathField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string GridSymbol
		{
			get
			{
				return this.gridSymbolField;
			}
			set
			{
				this.gridSymbolField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string Height
		{
			get
			{
				return this.heightField;
			}
			set
			{
				this.heightField = value;
			}
		}
	}
}