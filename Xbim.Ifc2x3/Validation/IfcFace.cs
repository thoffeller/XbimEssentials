using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ProfileResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.TopologyResource
{
	public partial class IfcFace : IExpressValidatable
	{
		public enum IfcFaceClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcFaceClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcFaceClause.WR1:
						retVal = Functions.SIZEOF(Bounds.Where(temp => Functions.TYPEOF(temp).Contains("IFC2X3.IFCFACEOUTERBOUND"))) <= 1;
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc2x3.TopologyResource.IfcFace");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcFace.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcFaceClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcFace.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
