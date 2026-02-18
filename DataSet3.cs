using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace GeoBaha
{
	[Serializable]
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[XmlRoot("DataSet3")]
	[HelpKeyword("vs.data.DataSet")]
	public class DataSet3 : DataSet
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DataTable3RowChangeEventHandler(object sender, DataTable3RowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class DataTable3DataTable : TypedTableBase<DataTable3Row>
		{
			private DataColumn columnId;

			private DataColumn columnردیف;

			private DataColumn columnردیف_ایتم;

			private DataColumn columnشماره_سند;

			private DataColumn columnشماره_ایتم;

			private DataColumn columnفصل;

			private DataColumn columnنوع_ایتم;

			private DataColumn columnشرح_ایتم;

			private DataColumn columnواحد;

			private DataColumn columnبهای_واحد;

			private DataColumn columnتعداد;

			private DataColumn columnبهای_کل;

			private DataColumn columnدرصد;

			private DataColumn columnدرصد_نسبت_به_ایتم;

			private DataColumn columnتوضیحات;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IdColumn => columnId;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ردیفColumn => columnردیف;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ردیف_ایتمColumn => columnردیف_ایتم;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn شماره_سندColumn => columnشماره_سند;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn شماره_ایتمColumn => columnشماره_ایتم;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn فصلColumn => columnفصل;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn نوع_ایتمColumn => columnنوع_ایتم;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn شرح_ایتمColumn => columnشرح_ایتم;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn واحدColumn => columnواحد;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn بهای_واحدColumn => columnبهای_واحد;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn تعدادColumn => columnتعداد;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn بهای_کلColumn => columnبهای_کل;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn درصدColumn => columnدرصد;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn درصد_نسبت_به_ایتمColumn => columnدرصد_نسبت_به_ایتم;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn توضیحاتColumn => columnتوضیحات;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[Browsable(false)]
			public int Count => base.Rows.Count;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable3Row this[int index] => (DataTable3Row)base.Rows[index];

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataTable3RowChangeEventHandler DataTable3RowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataTable3RowChangeEventHandler DataTable3RowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataTable3RowChangeEventHandler DataTable3RowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataTable3RowChangeEventHandler DataTable3RowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable3DataTable()
			{
				base.ColumnChanging += DataTable3DataTable_ColumnChanging;
				base.TableName = "DataTable3";
				BeginInit();
				InitClass();
				EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTable3DataTable(DataTable table)
			{
				base.ColumnChanging += DataTable3DataTable_ColumnChanging;
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), TextCompare: false) != 0)
				{
					base.Locale = table.Locale;
				}
				if (Operators.CompareString(table.Namespace, table.DataSet.Namespace, TextCompare: false) != 0)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected DataTable3DataTable(SerializationInfo info, StreamingContext context)
				: base(info, context)
			{
				base.ColumnChanging += DataTable3DataTable_ColumnChanging;
				InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddDataTable3Row(DataTable3Row row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable3Row AddDataTable3Row(string Id, string ردیف, string ردیف_ایتم, string شماره_سند, string شماره_ایتم, string فصل, string نوع_ایتم, string شرح_ایتم, string واحد, float بهای_واحد, float تعداد, float بهای_کل, float درصد, string درصد_نسبت_به_ایتم, string توضیحات)
			{
				DataTable3Row dataTable3Row = (DataTable3Row)NewRow();
				object[] itemArray = new object[15]
				{
					Id, ردیف, ردیف_ایتم, شماره_سند, شماره_ایتم, فصل, نوع_ایتم, شرح_ایتم, واحد, بهای_واحد,
					تعداد, بهای_کل, درصد, درصد_نسبت_به_ایتم, توضیحات
				};
				dataTable3Row.ItemArray = itemArray;
				base.Rows.Add(dataTable3Row);
				return dataTable3Row;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataTable3DataTable dataTable3DataTable = (DataTable3DataTable)base.Clone();
				dataTable3DataTable.InitVars();
				return dataTable3DataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataTable3DataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				columnId = base.Columns["Id"];
				columnردیف = base.Columns["ردیف"];
				columnردیف_ایتم = base.Columns["ردیف ایتم"];
				columnشماره_سند = base.Columns["شماره سند"];
				columnشماره_ایتم = base.Columns["شماره ایتم"];
				columnفصل = base.Columns["فصل"];
				columnنوع_ایتم = base.Columns["نوع ایتم"];
				columnشرح_ایتم = base.Columns["شرح ایتم"];
				columnواحد = base.Columns["واحد"];
				columnبهای_واحد = base.Columns["بهای واحد"];
				columnتعداد = base.Columns["تعداد"];
				columnبهای_کل = base.Columns["بهای_کل"];
				columnدرصد = base.Columns["درصد"];
				columnدرصد_نسبت_به_ایتم = base.Columns["درصد نسبت به ایتم"];
				columnتوضیحات = base.Columns["توضیحات"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				columnId = new DataColumn("Id", typeof(string), null, MappingType.Element);
				base.Columns.Add(columnId);
				columnردیف = new DataColumn("ردیف", typeof(string), null, MappingType.Element);
				base.Columns.Add(columnردیف);
				columnردیف_ایتم = new DataColumn("ردیف ایتم", typeof(string), null, MappingType.Element);
				base.Columns.Add(columnردیف_ایتم);
				columnشماره_سند = new DataColumn("شماره سند", typeof(string), null, MappingType.Element);
				base.Columns.Add(columnشماره_سند);
				columnشماره_ایتم = new DataColumn("شماره ایتم", typeof(string), null, MappingType.Element);
				base.Columns.Add(columnشماره_ایتم);
				columnفصل = new DataColumn("فصل", typeof(string), null, MappingType.Element);
				base.Columns.Add(columnفصل);
				columnنوع_ایتم = new DataColumn("نوع ایتم", typeof(string), null, MappingType.Element);
				base.Columns.Add(columnنوع_ایتم);
				columnشرح_ایتم = new DataColumn("شرح ایتم", typeof(string), null, MappingType.Element);
				base.Columns.Add(columnشرح_ایتم);
				columnواحد = new DataColumn("واحد", typeof(string), null, MappingType.Element);
				base.Columns.Add(columnواحد);
				columnبهای_واحد = new DataColumn("بهای واحد", typeof(float), null, MappingType.Element);
				base.Columns.Add(columnبهای_واحد);
				columnتعداد = new DataColumn("تعداد", typeof(float), null, MappingType.Element);
				base.Columns.Add(columnتعداد);
				columnبهای_کل = new DataColumn("بهای_کل", typeof(float), null, MappingType.Element);
				base.Columns.Add(columnبهای_کل);
				columnدرصد = new DataColumn("درصد", typeof(float), null, MappingType.Element);
				base.Columns.Add(columnدرصد);
				columnدرصد_نسبت_به_ایتم = new DataColumn("درصد نسبت به ایتم", typeof(string), null, MappingType.Element);
				base.Columns.Add(columnدرصد_نسبت_به_ایتم);
				columnتوضیحات = new DataColumn("توضیحات", typeof(string), null, MappingType.Element);
				base.Columns.Add(columnتوضیحات);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable3Row NewDataTable3Row()
			{
				return (DataTable3Row)NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataTable3Row(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataTable3Row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (DataTable3RowChanged != null)
				{
					DataTable3RowChanged?.Invoke(this, new DataTable3RowChangeEvent((DataTable3Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (DataTable3RowChanging != null)
				{
					DataTable3RowChanging?.Invoke(this, new DataTable3RowChangeEvent((DataTable3Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (DataTable3RowDeleted != null)
				{
					DataTable3RowDeleted?.Invoke(this, new DataTable3RowChangeEvent((DataTable3Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (DataTable3RowDeleting != null)
				{
					DataTable3RowDeleting?.Invoke(this, new DataTable3RowChangeEvent((DataTable3Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveDataTable3Row(DataTable3Row row)
			{
				base.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSet3 dataSet = new DataSet3();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DataTable3DataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						XmlSchema xmlSchema = null;
						schemaSerializable.Write(memoryStream);
						IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
						while (enumerator.MoveNext())
						{
							xmlSchema = (XmlSchema)enumerator.Current;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						memoryStream?.Close();
						memoryStream2?.Close();
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			private void DataTable3DataTable_ColumnChanging(object sender, DataColumnChangeEventArgs e)
			{
			}
		}

		public class DataTable3Row : DataRow
		{
			private DataTable3DataTable tableDataTable3;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Id
			{
				get
				{
					try
					{
						return Conversions.ToString(base[tableDataTable3.IdColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'Id' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.IdColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ردیف
			{
				get
				{
					try
					{
						return Conversions.ToString(base[tableDataTable3.ردیفColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'ردیف' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.ردیفColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ردیف_ایتم
			{
				get
				{
					try
					{
						return Conversions.ToString(base[tableDataTable3.ردیف_ایتمColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'ردیف ایتم' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.ردیف_ایتمColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string شماره_سند
			{
				get
				{
					try
					{
						return Conversions.ToString(base[tableDataTable3.شماره_سندColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'شماره سند' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.شماره_سندColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string شماره_ایتم
			{
				get
				{
					try
					{
						return Conversions.ToString(base[tableDataTable3.شماره_ایتمColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'شماره ایتم' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.شماره_ایتمColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string فصل
			{
				get
				{
					try
					{
						return Conversions.ToString(base[tableDataTable3.فصلColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'فصل' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.فصلColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string نوع_ایتم
			{
				get
				{
					try
					{
						return Conversions.ToString(base[tableDataTable3.نوع_ایتمColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'نوع ایتم' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.نوع_ایتمColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string شرح_ایتم
			{
				get
				{
					try
					{
						return Conversions.ToString(base[tableDataTable3.شرح_ایتمColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'شرح ایتم' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.شرح_ایتمColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string واحد
			{
				get
				{
					try
					{
						return Conversions.ToString(base[tableDataTable3.واحدColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'واحد' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.واحدColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public float بهای_واحد
			{
				get
				{
					try
					{
						return Conversions.ToSingle(base[tableDataTable3.بهای_واحدColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'بهای واحد' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.بهای_واحدColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public float تعداد
			{
				get
				{
					try
					{
						return Conversions.ToSingle(base[tableDataTable3.تعدادColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'تعداد' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.تعدادColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public float بهای_کل
			{
				get
				{
					try
					{
						return Conversions.ToSingle(base[tableDataTable3.بهای_کلColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'بهای_کل' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.بهای_کلColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public float درصد
			{
				get
				{
					try
					{
						return Conversions.ToSingle(base[tableDataTable3.درصدColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'درصد' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.درصدColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string درصد_نسبت_به_ایتم
			{
				get
				{
					try
					{
						return Conversions.ToString(base[tableDataTable3.درصد_نسبت_به_ایتمColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'درصد نسبت به ایتم' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.درصد_نسبت_به_ایتمColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string توضیحات
			{
				get
				{
					try
					{
						return Conversions.ToString(base[tableDataTable3.توضیحاتColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'توضیحات' in table 'DataTable3' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable3.توضیحاتColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTable3Row(DataRowBuilder rb)
				: base(rb)
			{
				tableDataTable3 = (DataTable3DataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsIdNull()
			{
				return IsNull(tableDataTable3.IdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetIdNull()
			{
				base[tableDataTable3.IdColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsردیفNull()
			{
				return IsNull(tableDataTable3.ردیفColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetردیفNull()
			{
				base[tableDataTable3.ردیفColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isردیف_ایتمNull()
			{
				return IsNull(tableDataTable3.ردیف_ایتمColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setردیف_ایتمNull()
			{
				base[tableDataTable3.ردیف_ایتمColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isشماره_سندNull()
			{
				return IsNull(tableDataTable3.شماره_سندColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setشماره_سندNull()
			{
				base[tableDataTable3.شماره_سندColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isشماره_ایتمNull()
			{
				return IsNull(tableDataTable3.شماره_ایتمColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setشماره_ایتمNull()
			{
				base[tableDataTable3.شماره_ایتمColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsفصلNull()
			{
				return IsNull(tableDataTable3.فصلColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetفصلNull()
			{
				base[tableDataTable3.فصلColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isنوع_ایتمNull()
			{
				return IsNull(tableDataTable3.نوع_ایتمColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setنوع_ایتمNull()
			{
				base[tableDataTable3.نوع_ایتمColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isشرح_ایتمNull()
			{
				return IsNull(tableDataTable3.شرح_ایتمColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setشرح_ایتمNull()
			{
				base[tableDataTable3.شرح_ایتمColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsواحدNull()
			{
				return IsNull(tableDataTable3.واحدColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetواحدNull()
			{
				base[tableDataTable3.واحدColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isبهای_واحدNull()
			{
				return IsNull(tableDataTable3.بهای_واحدColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setبهای_واحدNull()
			{
				base[tableDataTable3.بهای_واحدColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsتعدادNull()
			{
				return IsNull(tableDataTable3.تعدادColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetتعدادNull()
			{
				base[tableDataTable3.تعدادColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isبهای_کلNull()
			{
				return IsNull(tableDataTable3.بهای_کلColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setبهای_کلNull()
			{
				base[tableDataTable3.بهای_کلColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsدرصدNull()
			{
				return IsNull(tableDataTable3.درصدColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetدرصدNull()
			{
				base[tableDataTable3.درصدColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Isدرصد_نسبت_به_ایتمNull()
			{
				return IsNull(tableDataTable3.درصد_نسبت_به_ایتمColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setدرصد_نسبت_به_ایتمNull()
			{
				base[tableDataTable3.درصد_نسبت_به_ایتمColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsتوضیحاتNull()
			{
				return IsNull(tableDataTable3.توضیحاتColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetتوضیحاتNull()
			{
				base[tableDataTable3.توضیحاتColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DataTable3RowChangeEvent : EventArgs
		{
			private DataTable3Row eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable3Row Row => eventRow;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action => eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTable3RowChangeEvent(DataTable3Row row, DataRowAction action)
			{
				eventRow = row;
				eventAction = action;
			}
		}

		private DataTable3DataTable tableDataTable3;

		private SchemaSerializationMode _schemaSerializationMode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataTable3DataTable DataTable3 => tableDataTable3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return _schemaSerializationMode;
			}
			set
			{
				_schemaSerializationMode = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataTableCollection Tables => base.Tables;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataRelationCollection Relations => base.Relations;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSet3()
		{
			_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			BeginInit();
			InitClass();
			CollectionChangeEventHandler value = SchemaChanged;
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected DataSet3(SerializationInfo info, StreamingContext context)
			: base(info, context, ConstructSchema: false)
		{
			_schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			if (IsBinarySerialized(info, context))
			{
				InitVars(initTable: false);
				CollectionChangeEventHandler value = SchemaChanged;
				Tables.CollectionChanged += value;
				Relations.CollectionChanged += value;
				return;
			}
			string s = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
			if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				if (dataSet.Tables["DataTable3"] != null)
				{
					base.Tables.Add(new DataTable3DataTable(dataSet.Tables["DataTable3"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
				InitVars();
			}
			else
			{
				ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			}
			GetSerializationData(info, context);
			CollectionChangeEventHandler value2 = SchemaChanged;
			base.Tables.CollectionChanged += value2;
			Relations.CollectionChanged += value2;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataSet Clone()
		{
			DataSet3 dataSet = (DataSet3)base.Clone();
			dataSet.InitVars();
			dataSet.SchemaSerializationMode = SchemaSerializationMode;
			return dataSet;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["DataTable3"] != null)
				{
					base.Tables.Add(new DataTable3DataTable(dataSet.Tables["DataTable3"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
				InitVars();
			}
			else
			{
				ReadXml(reader);
				InitVars();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			InitVars(initTable: true);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars(bool initTable)
		{
			tableDataTable3 = (DataTable3DataTable)base.Tables["DataTable3"];
			if (initTable && tableDataTable3 != null)
			{
				tableDataTable3.InitVars();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			base.DataSetName = "DataSet3";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/DataSet3.xsd";
			base.EnforceConstraints = true;
			SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			tableDataTable3 = new DataTable3DataTable();
			base.Tables.Add(tableDataTable3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeDataTable3()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				InitVars();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			DataSet3 dataSet = new DataSet3();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = dataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}
}
