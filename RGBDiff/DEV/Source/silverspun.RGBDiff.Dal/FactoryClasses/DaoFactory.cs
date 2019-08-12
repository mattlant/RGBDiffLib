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

using silverspun.RGBDiff.Dal.DaoClasses;
using silverspun.RGBDiff.Dal.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace silverspun.RGBDiff.Dal.FactoryClasses
{
	/// <summary>
	/// Generic factory for DAO objects. 
	/// </summary>
	public partial class DAOFactory
	{
		/// <summary>
		/// Private CTor, no instantiation possible.
		/// </summary>
		private DAOFactory()
		{
		}

		/// <summary>Creates a new ControlSetDAO object</summary>
		/// <returns>the new DAO object ready to use for ControlSet Entities</returns>
		public static ControlSetDAO CreateControlSetDAO()
		{
			return new ControlSetDAO();
		}

		/// <summary>Creates a new ControlSetColourDAO object</summary>
		/// <returns>the new DAO object ready to use for ControlSetColour Entities</returns>
		public static ControlSetColourDAO CreateControlSetColourDAO()
		{
			return new ControlSetColourDAO();
		}

		/// <summary>Creates a new ObserverDataSetDAO object</summary>
		/// <returns>the new DAO object ready to use for ObserverDataSet Entities</returns>
		public static ObserverDataSetDAO CreateObserverDataSetDAO()
		{
			return new ObserverDataSetDAO();
		}

		/// <summary>Creates a new ObserverDataSetColourDAO object</summary>
		/// <returns>the new DAO object ready to use for ObserverDataSetColour Entities</returns>
		public static ObserverDataSetColourDAO CreateObserverDataSetColourDAO()
		{
			return new ObserverDataSetColourDAO();
		}

		/// <summary>Creates a new TypedListDAO object</summary>
		/// <returns>The new DAO object ready to use for Typed Lists</returns>
		public static TypedListDAO CreateTypedListDAO()
		{
			return new TypedListDAO();
		}

		#region Included Code

		#endregion
	}
}
