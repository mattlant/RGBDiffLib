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
	/// <summary>Implements the static Relations variant for the entity: ObserverDataSet. </summary>
	public partial class ObserverDataSetRelations
	{
		/// <summary>CTor</summary>
		public ObserverDataSetRelations()
		{
		}

		/// <summary>Gets all relations of the ObserverDataSetEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ObserverDataSetColourEntityUsingObserverDataSetUID);

			toReturn.Add(this.ControlSetEntityUsingControlSetUID);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ObserverDataSetEntity and ObserverDataSetColourEntity over the 1:n relation they have, using the relation between the fields:
		/// ObserverDataSet.UID - ObserverDataSetColour.ObserverDataSetUID
		/// </summary>
		public virtual IEntityRelation ObserverDataSetColourEntityUsingObserverDataSetUID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ObserverDataSetColourCollection" , true);
				relation.AddEntityFieldPair(ObserverDataSetFields.UID, ObserverDataSetColourFields.ObserverDataSetUID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ObserverDataSetEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ObserverDataSetColourEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ObserverDataSetEntity and ControlSetEntity over the m:1 relation they have, using the relation between the fields:
		/// ObserverDataSet.ControlSetUID - ControlSet.UID
		/// </summary>
		public virtual IEntityRelation ControlSetEntityUsingControlSetUID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ControlSet", false);
				relation.AddEntityFieldPair(ControlSetFields.UID, ObserverDataSetFields.ControlSetUID);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ControlSetEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ObserverDataSetEntity", true);
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
