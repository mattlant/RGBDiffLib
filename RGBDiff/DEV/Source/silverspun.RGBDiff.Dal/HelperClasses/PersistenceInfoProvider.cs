///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 2.6
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SqlServerSpecific.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace silverspun.RGBDiff.Dal.HelperClasses
{
	/// <summary>
	/// Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.
	/// </summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal sealed class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion
		
		/// <summary>private ctor to prevent instances of this class.</summary>
		private PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			base.InitClass((4 + 0));
			InitControlSetEntityMappings();
			InitControlSetColourEntityMappings();
			InitObserverDataSetEntityMappings();
			InitObserverDataSetColourEntityMappings();

		}


		/// <summary>Inits ControlSetEntity's mappings</summary>
		private void InitControlSetEntityMappings()
		{
			base.AddElementMapping( "ControlSetEntity", "DeltaRGBsss", @"dbo", "ControlSet", 2 );
			base.AddElementFieldMapping( "ControlSetEntity", "UID", "UID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ControlSetEntity", "Name", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, "", null, typeof(System.String), 1 );
		}
		/// <summary>Inits ControlSetColourEntity's mappings</summary>
		private void InitControlSetColourEntityMappings()
		{
			base.AddElementMapping( "ControlSetColourEntity", "DeltaRGBsss", @"dbo", "ControlSetColour", 7 );
			base.AddElementFieldMapping( "ControlSetColourEntity", "UID", "UID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ControlSetColourEntity", "ControlSetUID", "ControlSetUID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ControlSetColourEntity", "Skip", "Skip", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 2 );
			base.AddElementFieldMapping( "ControlSetColourEntity", "SkipForObserverInput", "SkipForObserverInput", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 3 );
			base.AddElementFieldMapping( "ControlSetColourEntity", "XyY_x", "xyY_x", false, (int)SqlDbType.Float, 0, 0, 38, false, "", null, typeof(System.Double), 4 );
			base.AddElementFieldMapping( "ControlSetColourEntity", "XyY_y", "xyY_y", false, (int)SqlDbType.Float, 0, 0, 38, false, "", null, typeof(System.Double), 5 );
			base.AddElementFieldMapping( "ControlSetColourEntity", "XyY_YY", "xyY_YY", false, (int)SqlDbType.Float, 0, 0, 38, false, "", null, typeof(System.Double), 6 );
		}
		/// <summary>Inits ObserverDataSetEntity's mappings</summary>
		private void InitObserverDataSetEntityMappings()
		{
			base.AddElementMapping( "ObserverDataSetEntity", "DeltaRGBsss", @"dbo", "ObserverDataSet", 4 );
			base.AddElementFieldMapping( "ObserverDataSetEntity", "UID", "UID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ObserverDataSetEntity", "ControlSetUID", "ControlSetUID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ObserverDataSetEntity", "StartDateTime", "StartDateTime", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			base.AddElementFieldMapping( "ObserverDataSetEntity", "EndDateTime", "EndDateTime", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
		}
		/// <summary>Inits ObserverDataSetColourEntity's mappings</summary>
		private void InitObserverDataSetColourEntityMappings()
		{
			base.AddElementMapping( "ObserverDataSetColourEntity", "DeltaRGBsss", @"dbo", "ObserverDataSetColour", 12 );
			base.AddElementFieldMapping( "ObserverDataSetColourEntity", "UID", "UID", false, (int)SqlDbType.Int, 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			base.AddElementFieldMapping( "ObserverDataSetColourEntity", "ObserverDataSetUID", "ObserverDataSetUID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			base.AddElementFieldMapping( "ObserverDataSetColourEntity", "ControlSetColourUID", "ControlSetColourUID", false, (int)SqlDbType.Int, 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			base.AddElementFieldMapping( "ObserverDataSetColourEntity", "SubmitDateTime", "SubmitDateTime", false, (int)SqlDbType.DateTime, 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			base.AddElementFieldMapping( "ObserverDataSetColourEntity", "OutOfGamut", "OutOfGamut", false, (int)SqlDbType.Bit, 0, 0, 0, false, "", null, typeof(System.Boolean), 4 );
			base.AddElementFieldMapping( "ObserverDataSetColourEntity", "Angle", "Angle", false, (int)SqlDbType.Float, 0, 0, 38, false, "", null, typeof(System.Double), 5 );
			base.AddElementFieldMapping( "ObserverDataSetColourEntity", "ControlxyY_x", "ControlxyY_x", false, (int)SqlDbType.Float, 0, 0, 38, false, "", null, typeof(System.Double), 6 );
			base.AddElementFieldMapping( "ObserverDataSetColourEntity", "ControlxyY_y", "ControlxyY_y", false, (int)SqlDbType.Float, 0, 0, 38, false, "", null, typeof(System.Double), 7 );
			base.AddElementFieldMapping( "ObserverDataSetColourEntity", "ControlxyY_YY", "ControlxyY_YY", false, (int)SqlDbType.Float, 0, 0, 38, false, "", null, typeof(System.Double), 8 );
			base.AddElementFieldMapping( "ObserverDataSetColourEntity", "XyY_x", "xyY_x", false, (int)SqlDbType.Float, 0, 0, 38, false, "", null, typeof(System.Double), 9 );
			base.AddElementFieldMapping( "ObserverDataSetColourEntity", "XyY_y", "xyY_y", false, (int)SqlDbType.Float, 0, 0, 38, false, "", null, typeof(System.Double), 10 );
			base.AddElementFieldMapping( "ObserverDataSetColourEntity", "XyY_YY", "xyY_YY", false, (int)SqlDbType.Float, 0, 0, 38, false, "", null, typeof(System.Double), 11 );
		}

	}
}