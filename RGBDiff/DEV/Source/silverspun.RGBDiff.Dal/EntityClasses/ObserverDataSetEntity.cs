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
using System.ComponentModel;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using silverspun.RGBDiff.Dal.FactoryClasses;
using silverspun.RGBDiff.Dal.CollectionClasses;
using silverspun.RGBDiff.Dal.DaoClasses;
using silverspun.RGBDiff.Dal.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace silverspun.RGBDiff.Dal.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>
	/// Entity class which represents the entity 'ObserverDataSet'. <br/>
	/// This class is used for Business Logic or for framework extension code. 
	/// </summary>
	[Serializable]
	public partial class ObserverDataSetEntity : ObserverDataSetEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Constructors
		/// <summary>
		/// CTor
		/// </summary>
		public ObserverDataSetEntity():base()
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="uID">PK value for ObserverDataSet which data should be fetched into this ObserverDataSet object</param>
		public ObserverDataSetEntity(System.Int32 uID):
			base(uID)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="uID">PK value for ObserverDataSet which data should be fetched into this ObserverDataSet object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ObserverDataSetEntity(System.Int32 uID, IPrefetchPath prefetchPathToUse):
			base(uID, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="uID">PK value for ObserverDataSet which data should be fetched into this ObserverDataSet object</param>
		/// <param name="validator">The custom validator object for this ObserverDataSetEntity</param>
		public ObserverDataSetEntity(System.Int32 uID, IValidator validator):
			base(uID, validator)
		{
		}
	
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ObserverDataSetEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		#endregion

		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included Code

		#endregion
	}
}
