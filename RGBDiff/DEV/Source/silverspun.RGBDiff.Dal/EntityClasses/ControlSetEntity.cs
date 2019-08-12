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
	/// Entity class which represents the entity 'ControlSet'. <br/>
	/// This class is used for Business Logic or for framework extension code. 
	/// </summary>
	[Serializable]
	public partial class ControlSetEntity : ControlSetEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Constructors
		/// <summary>
		/// CTor
		/// </summary>
		public ControlSetEntity():base()
		{
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="uID">PK value for ControlSet which data should be fetched into this ControlSet object</param>
		public ControlSetEntity(System.Int32 uID):
			base(uID)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="uID">PK value for ControlSet which data should be fetched into this ControlSet object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ControlSetEntity(System.Int32 uID, IPrefetchPath prefetchPathToUse):
			base(uID, prefetchPathToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="uID">PK value for ControlSet which data should be fetched into this ControlSet object</param>
		/// <param name="validator">The custom validator object for this ControlSetEntity</param>
		public ControlSetEntity(System.Int32 uID, IValidator validator):
			base(uID, validator)
		{
		}
	
		
		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ControlSetEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
