// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.ProductExtension;
using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.GeometricConstraintResource;
using Xbim.Ifc4.RepresentationResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.Ifc4.SharedFacilitiesElements
{
	[ExpressType("IFCSYSTEMFURNITUREELEMENT", 1073)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSystemFurnitureElement : IfcFurnishingElement, IInstantiableEntity, IEqualityComparer<@IfcSystemFurnitureElement>, IEquatable<@IfcSystemFurnitureElement>
	{
		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSystemFurnitureElement(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSystemFurnitureElementTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, -1, -1)]
		public IfcSystemFurnitureElementTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _predefinedType;
				((IPersistEntity)this).Activate(false);
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType");
			} 
		}
	
		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
                    _predefinedType = (IfcSystemFurnitureElementTypeEnum) System.Enum.Parse(typeof (IfcSystemFurnitureElementTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*CorrectPredefinedType:                               ((PredefinedType = IfcSystemFurnitureElementTypeEnum.USERDEFINED) AND EXISTS (SELF\IfcObject.ObjectType));*/
		/*CorrectTypeAssigned:                                 ('IFC4.IFCSYSTEMFURNITUREELEMENTTYPE' IN TYPEOF(SELF\IfcObject.IsTypedBy[1].RelatingType));*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSystemFurnitureElement other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcSystemFurnitureElement
            var root = (@IfcSystemFurnitureElement)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcSystemFurnitureElement left, @IfcSystemFurnitureElement right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcSystemFurnitureElement left, @IfcSystemFurnitureElement right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcSystemFurnitureElement x, @IfcSystemFurnitureElement y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcSystemFurnitureElement obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}