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
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace silverspun.RGBDiff.Dal.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>
	/// Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal sealed class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private FieldInfoProviderSingleton()
		{
		}

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			base.InitClass( (4 + 0));
			InitControlSetEntityInfos();
			InitControlSetColourEntityInfos();
			InitObserverDataSetEntityInfos();
			InitObserverDataSetColourEntityInfos();

			base.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits ControlSetEntity's FieldInfo objects</summary>
		private void InitControlSetEntityInfos()
		{
			base.AddElementFieldInfo("ControlSetEntity", "UID", typeof(System.Int32), true, false, true, false,  (int)ControlSetFieldIndex.UID, 0, 0, 10);
			base.AddElementFieldInfo("ControlSetEntity", "Name", typeof(System.String), false, false, false, false,  (int)ControlSetFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits ControlSetColourEntity's FieldInfo objects</summary>
		private void InitControlSetColourEntityInfos()
		{
			base.AddElementFieldInfo("ControlSetColourEntity", "UID", typeof(System.Int32), true, false, true, false,  (int)ControlSetColourFieldIndex.UID, 0, 0, 10);
			base.AddElementFieldInfo("ControlSetColourEntity", "ControlSetUID", typeof(System.Int32), false, true, false, false,  (int)ControlSetColourFieldIndex.ControlSetUID, 0, 0, 10);
			base.AddElementFieldInfo("ControlSetColourEntity", "Skip", typeof(System.Boolean), false, false, false, false,  (int)ControlSetColourFieldIndex.Skip, 0, 0, 0);
			base.AddElementFieldInfo("ControlSetColourEntity", "SkipForObserverInput", typeof(System.Boolean), false, false, false, false,  (int)ControlSetColourFieldIndex.SkipForObserverInput, 0, 0, 0);
			base.AddElementFieldInfo("ControlSetColourEntity", "XyY_x", typeof(System.Double), false, false, false, false,  (int)ControlSetColourFieldIndex.XyY_x, 0, 0, 38);
			base.AddElementFieldInfo("ControlSetColourEntity", "XyY_y", typeof(System.Double), false, false, false, false,  (int)ControlSetColourFieldIndex.XyY_y, 0, 0, 38);
			base.AddElementFieldInfo("ControlSetColourEntity", "XyY_YY", typeof(System.Double), false, false, false, false,  (int)ControlSetColourFieldIndex.XyY_YY, 0, 0, 38);
		}
		/// <summary>Inits ObserverDataSetEntity's FieldInfo objects</summary>
		private void InitObserverDataSetEntityInfos()
		{
			base.AddElementFieldInfo("ObserverDataSetEntity", "UID", typeof(System.Int32), true, false, true, false,  (int)ObserverDataSetFieldIndex.UID, 0, 0, 10);
			base.AddElementFieldInfo("ObserverDataSetEntity", "ControlSetUID", typeof(System.Int32), false, true, false, false,  (int)ObserverDataSetFieldIndex.ControlSetUID, 0, 0, 10);
			base.AddElementFieldInfo("ObserverDataSetEntity", "StartDateTime", typeof(System.DateTime), false, false, false, false,  (int)ObserverDataSetFieldIndex.StartDateTime, 0, 0, 0);
			base.AddElementFieldInfo("ObserverDataSetEntity", "EndDateTime", typeof(System.DateTime), false, false, false, false,  (int)ObserverDataSetFieldIndex.EndDateTime, 0, 0, 0);
		}
		/// <summary>Inits ObserverDataSetColourEntity's FieldInfo objects</summary>
		private void InitObserverDataSetColourEntityInfos()
		{
			base.AddElementFieldInfo("ObserverDataSetColourEntity", "UID", typeof(System.Int32), true, false, true, false,  (int)ObserverDataSetColourFieldIndex.UID, 0, 0, 10);
			base.AddElementFieldInfo("ObserverDataSetColourEntity", "ObserverDataSetUID", typeof(System.Int32), false, true, false, false,  (int)ObserverDataSetColourFieldIndex.ObserverDataSetUID, 0, 0, 10);
			base.AddElementFieldInfo("ObserverDataSetColourEntity", "ControlSetColourUID", typeof(System.Int32), false, false, false, false,  (int)ObserverDataSetColourFieldIndex.ControlSetColourUID, 0, 0, 10);
			base.AddElementFieldInfo("ObserverDataSetColourEntity", "SubmitDateTime", typeof(System.DateTime), false, false, false, false,  (int)ObserverDataSetColourFieldIndex.SubmitDateTime, 0, 0, 0);
			base.AddElementFieldInfo("ObserverDataSetColourEntity", "OutOfGamut", typeof(System.Boolean), false, false, false, false,  (int)ObserverDataSetColourFieldIndex.OutOfGamut, 0, 0, 0);
			base.AddElementFieldInfo("ObserverDataSetColourEntity", "Angle", typeof(System.Double), false, false, false, false,  (int)ObserverDataSetColourFieldIndex.Angle, 0, 0, 38);
			base.AddElementFieldInfo("ObserverDataSetColourEntity", "ControlxyY_x", typeof(System.Double), false, false, false, false,  (int)ObserverDataSetColourFieldIndex.ControlxyY_x, 0, 0, 38);
			base.AddElementFieldInfo("ObserverDataSetColourEntity", "ControlxyY_y", typeof(System.Double), false, false, false, false,  (int)ObserverDataSetColourFieldIndex.ControlxyY_y, 0, 0, 38);
			base.AddElementFieldInfo("ObserverDataSetColourEntity", "ControlxyY_YY", typeof(System.Double), false, false, false, false,  (int)ObserverDataSetColourFieldIndex.ControlxyY_YY, 0, 0, 38);
			base.AddElementFieldInfo("ObserverDataSetColourEntity", "XyY_x", typeof(System.Double), false, false, false, false,  (int)ObserverDataSetColourFieldIndex.XyY_x, 0, 0, 38);
			base.AddElementFieldInfo("ObserverDataSetColourEntity", "XyY_y", typeof(System.Double), false, false, false, false,  (int)ObserverDataSetColourFieldIndex.XyY_y, 0, 0, 38);
			base.AddElementFieldInfo("ObserverDataSetColourEntity", "XyY_YY", typeof(System.Double), false, false, false, false,  (int)ObserverDataSetColourFieldIndex.XyY_YY, 0, 0, 38);
		}
		
	}
}




