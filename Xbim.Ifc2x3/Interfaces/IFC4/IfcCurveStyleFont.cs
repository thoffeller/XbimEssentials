// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcCurveStyleFont : IIfcCurveStyleFont
	{
		Ifc4.MeasureResource.IfcLabel? IIfcCurveStyleFont.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Name.Value);
			} 
		}
		IEnumerable<IIfcCurveStyleFontPattern> IIfcCurveStyleFont.PatternList 
		{ 
			get
			{
			foreach (var member in PatternList)
			{
				yield return member as IIfcCurveStyleFontPattern;
			}
			} 
		}

	//## Custom code
	//##
	}
}