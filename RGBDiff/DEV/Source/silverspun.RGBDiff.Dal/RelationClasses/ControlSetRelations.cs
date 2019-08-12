///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using silverspun.RGBDiff.Dal;
using silverspun.RGBDiff.Dal.FactoryClasses;
using silverspun.RGBDiff.Dal.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace silverspun.RGBDiff.Dal.RelationClasses
{
	/// <summary>Implements the static Relations variant for the entity: ControlSet. </summary>
	public partial class ControlSetRelations
	{
		/// <summary>CTor</summary>
		public ControlSetRelations()
		{
		}

		/// <summary>Gets all relations of the ControlSetEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ControlSetColourEntityUsingControlSetUID);
			toReturn.Add(this.ObserverDataSetEntityUsingControlSetUID);


			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ControlSetEntity and ControlSetColourEntity over the 1:n relation they have, using the relation between the fields:
		/// ControlSet.UID - ControlSetColour.ControlSetUID
		/// </summary>
		public virtual IEntityRelation ControlSetColourEntityUsingControlSetUID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ControlSetColourCollection" , true);
				relation.AddEntityFieldPair(ControlSetFields.UID, ControlSetColourFields.ControlSetUID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ControlSetEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ControlSetColourEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ControlSetEntity and ObserverDataSetEntity over the 1:n relation they have, using the relation between the fields:
		/// ControlSet.UID - ObserverDataSet.ControlSetUID
		/// </summary>
		public virtual IEntityRelation ObserverDataSetEntityUsingControlSetUID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ObserverDataSetCollection" , true);
				relation.AddEntityFieldPair(ControlSetFields.UID, ObserverDataSetFields.ControlSetUID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ControlSetEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ObserverDataSetEntity", false);
				return relation;
			}
		}



		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}

		#endregion

		#region Included Code

		#endregion
	}
}
