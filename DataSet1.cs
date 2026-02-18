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
	[XmlRoot("DataSet1")]
	[HelpKeyword("vs.data.DataSet")]
	public class DataSet1 : DataSet
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public delegate void DataTable1RowChangeEventHandler(object sender, DataTable1RowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class DataTable1DataTable : TypedTableBase<DataTable1Row>
		{
			private DataColumn columnSanadNo;

			private DataColumn columnردیف;

			private DataColumn columnفصل;

			private DataColumn columnشرح;

			private DataColumn columnجمع_بدون_ضریب;

			private DataColumn columnضریب;

			private DataColumn columnجمع_با_ضریب;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataColumn SanadNoColumn => columnSanadNo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataColumn ردیفColumn => columnردیف;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataColumn فصلColumn => columnفصل;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataColumn شرحColumn => columnشرح;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataColumn جمع_بدون_ضریبColumn => columnجمع_بدون_ضریب;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataColumn ضریبColumn => columnضریب;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataColumn جمع_با_ضریبColumn => columnجمع_با_ضریب;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			[Browsable(false)]
			public int Count => base.Rows.Count;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataTable1Row this[int index] => (DataTable1Row)base.Rows[index];

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public event DataTable1RowChangeEventHandler DataTable1RowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public event DataTable1RowChangeEventHandler DataTable1RowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public event DataTable1RowChangeEventHandler DataTable1RowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public event DataTable1RowChangeEventHandler DataTable1RowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataTable1DataTable()
			{
				base.ColumnChanging += DataTable1DataTable_ColumnChanging;
				base.TableName = "DataTable1";
				BeginInit();
				InitClass();
				EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			internal DataTable1DataTable(DataTable table)
			{
				base.ColumnChanging += DataTable1DataTable_ColumnChanging;
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
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected DataTable1DataTable(SerializationInfo info, StreamingContext context)
				: base(info, context)
			{
				base.ColumnChanging += DataTable1DataTable_ColumnChanging;
				InitVars();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public void AddDataTable1Row(DataTable1Row row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataTable1Row AddDataTable1Row(string SanadNo, short ردیف, string فصل, string شرح, float جمع_بدون_ضریب, float ضریب, float جمع_با_ضریب)
			{
				DataTable1Row dataTable1Row = (DataTable1Row)NewRow();
				object[] itemArray = new object[7] { SanadNo, ردیف, فصل, شرح, جمع_بدون_ضریب, ضریب, جمع_با_ضریب };
				dataTable1Row.ItemArray = itemArray;
				base.Rows.Add(dataTable1Row);
				return dataTable1Row;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public override DataTable Clone()
			{
				DataTable1DataTable dataTable1DataTable = (DataTable1DataTable)base.Clone();
				dataTable1DataTable.InitVars();
				return dataTable1DataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataTable1DataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			internal void InitVars()
			{
				columnSanadNo = base.Columns["SanadNo"];
				columnردیف = base.Columns["ردیف"];
				columnفصل = base.Columns["فصل"];
				columnشرح = base.Columns["شرح"];
				columnجمع_بدون_ضریب = base.Columns["جمع_بدون_ضریب"];
				columnضریب = base.Columns["ضریب"];
				columnجمع_با_ضریب = base.Columns["جمع_با_ضریب"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			private void InitClass()
			{
				columnSanadNo = new DataColumn("SanadNo", typeof(string), null, MappingType.Element);
				base.Columns.Add(columnSanadNo);
				columnردیف = new DataColumn("ردیف", typeof(short), null, MappingType.Element);
				base.Columns.Add(columnردیف);
				columnفصل = new DataColumn("فصل", typeof(string), null, MappingType.Element);
				base.Columns.Add(columnفصل);
				columnشرح = new DataColumn("شرح", typeof(string), null, MappingType.Element);
				base.Columns.Add(columnشرح);
				columnجمع_بدون_ضریب = new DataColumn("جمع_بدون_ضریب", typeof(float), null, MappingType.Element);
				base.Columns.Add(columnجمع_بدون_ضریب);
				columnضریب = new DataColumn("ضریب", typeof(float), null, MappingType.Element);
				base.Columns.Add(columnضریب);
				columnجمع_با_ضریب = new DataColumn("جمع_با_ضریب", typeof(float), null, MappingType.Element);
				base.Columns.Add(columnجمع_با_ضریب);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataTable1Row NewDataTable1Row()
			{
				return (DataTable1Row)NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataTable1Row(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataTable1Row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (DataTable1RowChanged != null)
				{
					DataTable1RowChanged?.Invoke(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (DataTable1RowChanging != null)
				{
					DataTable1RowChanging?.Invoke(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (DataTable1RowDeleted != null)
				{
					DataTable1RowDeleted?.Invoke(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (DataTable1RowDeleting != null)
				{
					DataTable1RowDeleting?.Invoke(this, new DataTable1RowChangeEvent((DataTable1Row)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public void RemoveDataTable1Row(DataTable1Row row)
			{
				base.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSet1 dataSet = new DataSet1();
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
				xmlSchemaAttribute2.FixedValue = "DataTable1DataTable";
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

			private void DataTable1DataTable_ColumnChanging(object sender, DataColumnChangeEventArgs e)
			{
				if (Operators.CompareString(e.Column.ColumnName, جمع_با_ضریبColumn.ColumnName, TextCompare: false) != 0)
				{
				}
			}
		}

		public class DataTable1Row : DataRow
		{
			private DataTable1DataTable tableDataTable1;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public string SanadNo
			{
				get
				{
					try
					{
						return Conversions.ToString(base[tableDataTable1.SanadNoColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'SanadNo' in table 'DataTable1' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable1.SanadNoColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public short ردیف
			{
				get
				{
					try
					{
						return Conversions.ToShort(base[tableDataTable1.ردیفColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'ردیف' in table 'DataTable1' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable1.ردیفColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public string فصل
			{
				get
				{
					try
					{
						return Conversions.ToString(base[tableDataTable1.فصلColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'فصل' in table 'DataTable1' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable1.فصلColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public string شرح
			{
				get
				{
					try
					{
						return Conversions.ToString(base[tableDataTable1.شرحColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'شرح' in table 'DataTable1' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable1.شرحColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public float جمع_بدون_ضریب
			{
				get
				{
					try
					{
						return Conversions.ToSingle(base[tableDataTable1.جمع_بدون_ضریبColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'جمع_بدون_ضریب' in table 'DataTable1' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable1.جمع_بدون_ضریبColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public float ضریب
			{
				get
				{
					try
					{
						return Conversions.ToSingle(base[tableDataTable1.ضریبColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'ضریب' in table 'DataTable1' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable1.ضریبColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public float جمع_با_ضریب
			{
				get
				{
					try
					{
						return Conversions.ToSingle(base[tableDataTable1.جمع_با_ضریبColumn]);
					}
					catch (InvalidCastException ex)
					{
						ProjectData.SetProjectError(ex);
						InvalidCastException innerException = ex;
						throw new StrongTypingException("The value for column 'جمع_با_ضریب' in table 'DataTable1' is DBNull.", innerException);
					}
				}
				set
				{
					base[tableDataTable1.جمع_با_ضریبColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			internal DataTable1Row(DataRowBuilder rb)
				: base(rb)
			{
				tableDataTable1 = (DataTable1DataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public bool IsSanadNoNull()
			{
				return IsNull(tableDataTable1.SanadNoColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public void SetSanadNoNull()
			{
				base[tableDataTable1.SanadNoColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public bool IsردیفNull()
			{
				return IsNull(tableDataTable1.ردیفColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public void SetردیفNull()
			{
				base[tableDataTable1.ردیفColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public bool IsفصلNull()
			{
				return IsNull(tableDataTable1.فصلColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public void SetفصلNull()
			{
				base[tableDataTable1.فصلColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public bool IsشرحNull()
			{
				return IsNull(tableDataTable1.شرحColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public void SetشرحNull()
			{
				base[tableDataTable1.شرحColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public bool Isجمع_بدون_ضریبNull()
			{
				return IsNull(tableDataTable1.جمع_بدون_ضریبColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public void Setجمع_بدون_ضریبNull()
			{
				base[tableDataTable1.جمع_بدون_ضریبColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public bool IsضریبNull()
			{
				return IsNull(tableDataTable1.ضریبColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public void SetضریبNull()
			{
				base[tableDataTable1.ضریبColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public bool Isجمع_با_ضریبNull()
			{
				return IsNull(tableDataTable1.جمع_با_ضریبColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public void Setجمع_با_ضریبNull()
			{
				base[tableDataTable1.جمع_با_ضریبColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public class DataTable1RowChangeEvent : EventArgs
		{
			private DataTable1Row eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataTable1Row Row => eventRow;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataRowAction Action => eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
			public DataTable1RowChangeEvent(DataTable1Row row, DataRowAction action)
			{
				eventRow = row;
				eventAction = action;
			}
		}

		private DataTable1DataTable tableDataTable1;

		private SchemaSerializationMode _schemaSerializationMode;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataTable1DataTable DataTable1 => tableDataTable1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
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
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataTableCollection Tables => base.Tables;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataRelationCollection Relations => base.Relations;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public DataSet1()
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
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected DataSet1(SerializationInfo info, StreamingContext context)
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
				if (dataSet.Tables["DataTable1"] != null)
				{
					base.Tables.Add(new DataTable1DataTable(dataSet.Tables["DataTable1"]));
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
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public override DataSet Clone()
		{
			DataSet1 dataSet = (DataSet1)base.Clone();
			dataSet.InitVars();
			dataSet.SchemaSerializationMode = SchemaSerializationMode;
			return dataSet;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["DataTable1"] != null)
				{
					base.Tables.Add(new DataTable1DataTable(dataSet.Tables["DataTable1"]));
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
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars()
		{
			InitVars(initTable: true);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		internal void InitVars(bool initTable)
		{
			tableDataTable1 = (DataTable1DataTable)base.Tables["DataTable1"];
			if (initTable && tableDataTable1 != null)
			{
				tableDataTable1.InitVars();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void InitClass()
		{
			base.DataSetName = "DataSet1";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/DataSet1.xsd";
			base.EnforceConstraints = true;
			SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			tableDataTable1 = new DataTable1DataTable();
			base.Tables.Add(tableDataTable1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private bool ShouldSerializeDataTable1()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				InitVars();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "16.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			DataSet1 dataSet = new DataSet1();
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
