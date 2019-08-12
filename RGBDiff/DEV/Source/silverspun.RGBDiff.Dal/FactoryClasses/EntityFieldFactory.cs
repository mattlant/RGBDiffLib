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
using System.Data;
using silverspun.RGBDiff.Dal;
using silverspun.RGBDiff.Dal.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace silverspun.RGBDiff.Dal.FactoryClasses
{
	/// <summary>
	/// Factory class for IEntityField instances, used in IEntityFields instances.
	/// </summary>
	public partial class EntityFieldFactory
	{
		/// <summary>
		/// Private CTor, no instantiation possible.
		/// </summary>
		private EntityFieldFactory()
		{
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the ControlSetEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(ControlSetFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ControlSetEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the ControlSetColourEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(ControlSetColourFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ControlSetColourEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the ObserverDataSetEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(ObserverDataSetFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ObserverDataSetEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the ObserverDataSetColourEntity.  Which EntityField is created is specified by fieldIndex</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(ObserverDataSetColourFieldIndex fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo("ObserverDataSetColourEntity", (int)fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}


		/// <summary>Creates a new IEntityField instance, which represents the field objectName.fieldName</summary>
		/// <param name="objectName">the name of the object the field belongs to, like CustomerEntity or OrdersTypedView</param>
		/// <param name="fieldName">the name of the field to create</param>
		public static IEntityField Create(string objectName, string fieldName)
        {
			return new EntityField(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(objectName, fieldName), PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(objectName, fieldName));
        }

		#region Included Code

		#endregion
	}
}
