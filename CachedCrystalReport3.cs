using System;
using System.ComponentModel;
using System.Drawing;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace GeoBaha
{
	[ToolboxBitmap(typeof(ExportOptions), "report.bmp")]
	public class CachedCrystalReport3 : Component, ICachedReport
	{
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual bool IsCacheable
		{
			get
			{
				return true;
			}
			set
			{
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual bool ShareDBLogonInfo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public virtual TimeSpan CacheTimeOut
		{
			get
			{
				return CachedReportConstants.DEFAULT_TIMEOUT;
			}
			set
			{
			}
		}

		public virtual ReportDocument CreateReport()
		{
			CrystalReport3 crystalReport = new CrystalReport3();
			crystalReport.Site = Site;
			return crystalReport;
		}

		ReportDocument ICachedReport.CreateReport()
		{
			//ILSpy generated this explicit interface implementation from .override directive in CreateReport
			return this.CreateReport();
		}

		public virtual string GetCustomizedCacheKey(RequestContext request)
		{
			return null;
		}

		string ICachedReport.GetCustomizedCacheKey(RequestContext request)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetCustomizedCacheKey
			return this.GetCustomizedCacheKey(request);
		}
	}
}
