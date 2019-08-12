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
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using silverspun.RGBDiff.Dal;
using silverspun.RGBDiff.Dal.FactoryClasses;
using silverspun.RGBDiff.Dal.DaoClasses;
using silverspun.RGBDiff.Dal.RelationClasses;
using silverspun.RGBDiff.Dal.HelperClasses;
using silverspun.RGBDiff.Dal.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace silverspun.RGBDiff.Dal.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity base class which represents the base class for the entity 'ObserverDataSetColour'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract partial class ObserverDataSetColourEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations


		private ObserverDataSetEntity _observerDataSet;
		private bool	_alwaysFetchObserverDataSet, _alreadyFetchedObserverDataSet, _observerDataSetReturnsNewIfNotFound;

		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ObserverDataSet</summary>
			public static readonly string ObserverDataSet = "ObserverDataSet";



		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ObserverDataSetColourEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ObserverDataSetColourEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="uID">PK value for ObserverDataSetColour which data should be fetched into this ObserverDataSetColour object</param>
		public ObserverDataSetColourEntityBase(System.Int32 uID)
		{
			InitClassFetch(uID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="uID">PK value for ObserverDataSetColour which data should be fetched into this ObserverDataSetColour object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ObserverDataSetColourEntityBase(System.Int32 uID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(uID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="uID">PK value for ObserverDataSetColour which data should be fetched into this ObserverDataSetColour object</param>
		/// <param name="validator">The custom validator object for this ObserverDataSetColourEntity</param>
		public ObserverDataSetColourEntityBase(System.Int32 uID, IValidator validator)
		{
			InitClassFetch(uID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ObserverDataSetColourEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_observerDataSet = (ObserverDataSetEntity)info.GetValue("_observerDataSet", typeof(ObserverDataSetEntity));
			if(_observerDataSet!=null)
			{
				_observerDataSet.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_observerDataSetReturnsNewIfNotFound = info.GetBoolean("_observerDataSetReturnsNewIfNotFound");
			_alwaysFetchObserverDataSet = info.GetBoolean("_alwaysFetchObserverDataSet");
			_alreadyFetchedObserverDataSet = info.GetBoolean("_alreadyFetchedObserverDataSet");

			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ObserverDataSetColourFieldIndex)fieldIndex)
			{
				case ObserverDataSetColourFieldIndex.ObserverDataSetUID:
					DesetupSyncObserverDataSet(true, false);
					_alreadyFetchedObserverDataSet = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}
		
		/// <summary>Gets the inheritance info provider instance of the project this entity instance is located in. </summary>
		/// <returns>ready to use inheritance info provider instance.</returns>
		protected override IInheritanceInfoProvider GetInheritanceInfoProvider()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}
		
		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PostReadXmlFixups()
		{


			_alreadyFetchedObserverDataSet = (_observerDataSet != null);

		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ObserverDataSetColourEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "ObserverDataSet":
					toReturn.Add(ObserverDataSetColourEntity.Relations.ObserverDataSetEntityUsingObserverDataSetUID);
					break;



				default:

					break;				
			}
			return toReturn;
		}



		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{


			info.AddValue("_observerDataSet", (!this.MarkedForDeletion?_observerDataSet:null));
			info.AddValue("_observerDataSetReturnsNewIfNotFound", _observerDataSetReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchObserverDataSet", _alwaysFetchObserverDataSet);
			info.AddValue("_alreadyFetchedObserverDataSet", _alreadyFetchedObserverDataSet);

			
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntityProperty(string propertyName, IEntity entity)
		{
			switch(propertyName)
			{
				case "ObserverDataSet":
					_alreadyFetchedObserverDataSet = true;
					this.ObserverDataSet = (ObserverDataSetEntity)entity;
					break;



				default:

					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "ObserverDataSet":
					SetupSyncObserverDataSet(relatedEntity);
					break;


				default:

					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "ObserverDataSet":
					DesetupSyncObserverDataSet(false, true);
					break;


				default:

					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();


			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_observerDataSet!=null)
			{
				toReturn.Add(_observerDataSet);
			}


			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();


			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="uID">PK value for ObserverDataSetColour which data should be fetched into this ObserverDataSetColour object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 uID)
		{
			return FetchUsingPK(uID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="uID">PK value for ObserverDataSetColour which data should be fetched into this ObserverDataSetColour object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 uID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(uID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="uID">PK value for ObserverDataSetColour which data should be fetched into this ObserverDataSetColour object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 uID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(uID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="uID">PK value for ObserverDataSetColour which data should be fetched into this ObserverDataSetColour object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 uID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(uID, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.UID, null, null, null);
		}

		/// <summary> Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, use <see cref="TestCurrentFieldValueForNull"/> for that.</summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(ObserverDataSetColourFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ObserverDataSetColourFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ObserverDataSetColourRelations().GetAllRelations();
		}




		/// <summary> Retrieves the related entity of type 'ObserverDataSetEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'ObserverDataSetEntity' which is related to this entity.</returns>
		public ObserverDataSetEntity GetSingleObserverDataSet()
		{
			return GetSingleObserverDataSet(false);
		}

		/// <summary> Retrieves the related entity of type 'ObserverDataSetEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'ObserverDataSetEntity' which is related to this entity.</returns>
		public virtual ObserverDataSetEntity GetSingleObserverDataSet(bool forceFetch)
		{
			if( ( !_alreadyFetchedObserverDataSet || forceFetch || _alwaysFetchObserverDataSet) && !base.IsSerializing && !base.IsDeserializing  && !base.InDesignMode)			
			{
				bool performLazyLoading = base.CheckIfLazyLoadingShouldOccur(ObserverDataSetColourEntity.Relations.ObserverDataSetEntityUsingObserverDataSetUID);

				ObserverDataSetEntity newEntity = new ObserverDataSetEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				bool fetchResult = false;
				if(performLazyLoading)
				{
					fetchResult = newEntity.FetchUsingPK(this.ObserverDataSetUID);
				}
				if(fetchResult)
				{
					if(base.ActiveContext!=null)
					{
						newEntity = (ObserverDataSetEntity)base.ActiveContext.Get(newEntity);
					}
					this.ObserverDataSet = newEntity;
				}
				else
				{
					if(_observerDataSetReturnsNewIfNotFound)
					{
						if(performLazyLoading || (!performLazyLoading && (_observerDataSet == null)))
						{
							this.ObserverDataSet = newEntity;
						}
					}
					else
					{
						this.ObserverDataSet = null;
					}
				}
				_alreadyFetchedObserverDataSet = fetchResult;
				if(base.ParticipatesInTransaction && !fetchResult)
				{
					base.Transaction.Remove(newEntity);
				}
			}
			return _observerDataSet;
		}


		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ObserverDataSetColourDAO dao = (ObserverDataSetColourDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{


			if(_observerDataSet!=null)
			{
				_observerDataSet.ActiveContext = base.ActiveContext;
			}


		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ObserverDataSetColourDAO dao = (ObserverDataSetColourDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ObserverDataSetColourDAO dao = (ObserverDataSetColourDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction, updateRestriction);
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		protected virtual void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			base.Fields = CreateFields();
			base.IsNew=true;
			base.Validator = validatorToUse;

			InitClassMembers();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}
		
		/// <summary>Creates entity fields object for this entity. Used in constructor to setup this entity in a polymorphic scenario.</summary>
		protected virtual IEntityFields CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(silverspun.RGBDiff.Dal.EntityType.ObserverDataSetColourEntity);
		}
		
		/// <summary>Creates a new transaction object</summary>
		/// <param name="levelOfIsolation">The level of isolation.</param>
		/// <param name="name">The name.</param>
		protected override ITransaction CreateTransaction( IsolationLevel levelOfIsolation, string name )
		{
			return new Transaction(levelOfIsolation, name);
		}

		/// <summary>
		/// Creates the ITypeDefaultValue instance used to provide default values for value types which aren't of type nullable(of T)
		/// </summary>
		/// <returns></returns>
		protected override ITypeDefaultValue CreateTypeDefaultValueProvider()
		{
			return new TypeDefaultValue();
		}

		/// <summary>
		/// Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element. 
		/// </summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		public override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ObserverDataSet", _observerDataSet);



			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="uID">PK value for ObserverDataSetColour which data should be fetched into this ObserverDataSetColour object</param>
		/// <param name="validator">The validator object for this ObserverDataSetColourEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		protected virtual void InitClassFetch(System.Int32 uID, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			base.Validator = validator;
			InitClassMembers();
			base.Fields = CreateFields();
			bool wasSuccesful = Fetch(uID, prefetchPathToUse, null, null);
			base.IsNew = !wasSuccesful;

			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{


			_observerDataSet = null;
			_observerDataSetReturnsNewIfNotFound = true;
			_alwaysFetchObserverDataSet = false;
			_alreadyFetchedObserverDataSet = false;


			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();

			Dictionary<string, string> fieldHashtable = null;
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("UID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ObserverDataSetUID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ControlSetColourUID", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("SubmitDateTime", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("OutOfGamut", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("Angle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ControlxyY_x", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ControlxyY_y", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("ControlxyY_YY", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("XyY_x", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("XyY_y", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();

			_fieldsCustomProperties.Add("XyY_YY", fieldHashtable);
		}
		#endregion


		/// <summary> Removes the sync logic for member _observerDataSet</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncObserverDataSet(bool signalRelatedEntity, bool resetFKFields)
		{
			base.PerformDesetupSyncRelatedEntity( _observerDataSet, new PropertyChangedEventHandler( OnObserverDataSetPropertyChanged ), "ObserverDataSet", ObserverDataSetColourEntity.Relations.ObserverDataSetEntityUsingObserverDataSetUID, true, signalRelatedEntity, "ObserverDataSetColourCollection", resetFKFields, new int[] { (int)ObserverDataSetColourFieldIndex.ObserverDataSetUID } );		
			_observerDataSet = null;
		}
		
		/// <summary> setups the sync logic for member _observerDataSet</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncObserverDataSet(IEntity relatedEntity)
		{
			if(_observerDataSet!=relatedEntity)
			{		
				DesetupSyncObserverDataSet(true, true);
				_observerDataSet = (ObserverDataSetEntity)relatedEntity;
				base.PerformSetupSyncRelatedEntity( _observerDataSet, new PropertyChangedEventHandler( OnObserverDataSetPropertyChanged ), "ObserverDataSet", ObserverDataSetColourEntity.Relations.ObserverDataSetEntityUsingObserverDataSetUID, true, ref _alreadyFetchedObserverDataSet, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnObserverDataSetPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}


		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="uID">PK value for ObserverDataSetColour which data should be fetched into this ObserverDataSetColour object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 uID, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				IDao dao = this.CreateDAOInstance();
				base.Fields[(int)ObserverDataSetColourFieldIndex.UID].ForcedCurrentValueWrite(uID);
				dao.FetchExisting(this, base.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (base.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}


		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateObserverDataSetColourDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ObserverDataSetColourEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ObserverDataSetColourRelations Relations
		{
			get	{ return new ObserverDataSetColourRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}




		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ObserverDataSet' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathObserverDataSet
		{
			get
			{
				return new PrefetchPathElement(new silverspun.RGBDiff.Dal.CollectionClasses.ObserverDataSetCollection(),
					(IEntityRelation)GetRelationsForField("ObserverDataSet")[0], (int)silverspun.RGBDiff.Dal.EntityType.ObserverDataSetColourEntity, (int)silverspun.RGBDiff.Dal.EntityType.ObserverDataSetEntity, 0, null, null, null, "ObserverDataSet", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne);
			}
		}


		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ObserverDataSetColourEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ObserverDataSetColourEntity.CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return ObserverDataSetColourEntity.FieldsCustomProperties;}
		}

		/// <summary> The UID property of the Entity ObserverDataSetColour<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ObserverDataSetColour"."UID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 UID
		{
			get { return (System.Int32)GetValue((int)ObserverDataSetColourFieldIndex.UID, true); }
			set	{ SetValue((int)ObserverDataSetColourFieldIndex.UID, value, true); }
		}
		/// <summary> The ObserverDataSetUID property of the Entity ObserverDataSetColour<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ObserverDataSetColour"."ObserverDataSetUID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ObserverDataSetUID
		{
			get { return (System.Int32)GetValue((int)ObserverDataSetColourFieldIndex.ObserverDataSetUID, true); }
			set	{ SetValue((int)ObserverDataSetColourFieldIndex.ObserverDataSetUID, value, true); }
		}
		/// <summary> The ControlSetColourUID property of the Entity ObserverDataSetColour<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ObserverDataSetColour"."ControlSetColourUID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ControlSetColourUID
		{
			get { return (System.Int32)GetValue((int)ObserverDataSetColourFieldIndex.ControlSetColourUID, true); }
			set	{ SetValue((int)ObserverDataSetColourFieldIndex.ControlSetColourUID, value, true); }
		}
		/// <summary> The SubmitDateTime property of the Entity ObserverDataSetColour<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ObserverDataSetColour"."SubmitDateTime"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime SubmitDateTime
		{
			get { return (System.DateTime)GetValue((int)ObserverDataSetColourFieldIndex.SubmitDateTime, true); }
			set	{ SetValue((int)ObserverDataSetColourFieldIndex.SubmitDateTime, value, true); }
		}
		/// <summary> The OutOfGamut property of the Entity ObserverDataSetColour<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ObserverDataSetColour"."OutOfGamut"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean OutOfGamut
		{
			get { return (System.Boolean)GetValue((int)ObserverDataSetColourFieldIndex.OutOfGamut, true); }
			set	{ SetValue((int)ObserverDataSetColourFieldIndex.OutOfGamut, value, true); }
		}
		/// <summary> The Angle property of the Entity ObserverDataSetColour<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ObserverDataSetColour"."Angle"<br/>
		/// Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Double Angle
		{
			get { return (System.Double)GetValue((int)ObserverDataSetColourFieldIndex.Angle, true); }
			set	{ SetValue((int)ObserverDataSetColourFieldIndex.Angle, value, true); }
		}
		/// <summary> The ControlxyY_x property of the Entity ObserverDataSetColour<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ObserverDataSetColour"."ControlxyY_x"<br/>
		/// Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Double ControlxyY_x
		{
			get { return (System.Double)GetValue((int)ObserverDataSetColourFieldIndex.ControlxyY_x, true); }
			set	{ SetValue((int)ObserverDataSetColourFieldIndex.ControlxyY_x, value, true); }
		}
		/// <summary> The ControlxyY_y property of the Entity ObserverDataSetColour<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ObserverDataSetColour"."ControlxyY_y"<br/>
		/// Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Double ControlxyY_y
		{
			get { return (System.Double)GetValue((int)ObserverDataSetColourFieldIndex.ControlxyY_y, true); }
			set	{ SetValue((int)ObserverDataSetColourFieldIndex.ControlxyY_y, value, true); }
		}
		/// <summary> The ControlxyY_YY property of the Entity ObserverDataSetColour<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ObserverDataSetColour"."ControlxyY_YY"<br/>
		/// Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Double ControlxyY_YY
		{
			get { return (System.Double)GetValue((int)ObserverDataSetColourFieldIndex.ControlxyY_YY, true); }
			set	{ SetValue((int)ObserverDataSetColourFieldIndex.ControlxyY_YY, value, true); }
		}
		/// <summary> The XyY_x property of the Entity ObserverDataSetColour<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ObserverDataSetColour"."xyY_x"<br/>
		/// Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Double XyY_x
		{
			get { return (System.Double)GetValue((int)ObserverDataSetColourFieldIndex.XyY_x, true); }
			set	{ SetValue((int)ObserverDataSetColourFieldIndex.XyY_x, value, true); }
		}
		/// <summary> The XyY_y property of the Entity ObserverDataSetColour<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ObserverDataSetColour"."xyY_y"<br/>
		/// Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Double XyY_y
		{
			get { return (System.Double)GetValue((int)ObserverDataSetColourFieldIndex.XyY_y, true); }
			set	{ SetValue((int)ObserverDataSetColourFieldIndex.XyY_y, value, true); }
		}
		/// <summary> The XyY_YY property of the Entity ObserverDataSetColour<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ObserverDataSetColour"."xyY_YY"<br/>
		/// Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Double XyY_YY
		{
			get { return (System.Double)GetValue((int)ObserverDataSetColourFieldIndex.XyY_YY, true); }
			set	{ SetValue((int)ObserverDataSetColourFieldIndex.XyY_YY, value, true); }
		}



		/// <summary> Gets / sets related entity of type 'ObserverDataSetEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.</summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleObserverDataSet()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ObserverDataSetEntity ObserverDataSet
		{
			get	{ return GetSingleObserverDataSet(false); }
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncObserverDataSet(value);
				}
				else
				{
					if(value==null)
					{
						if(_observerDataSet != null)
						{
							_observerDataSet.UnsetRelatedEntity(this, "ObserverDataSetColourCollection");
						}
					}
					else
					{
						if(_observerDataSet!=value)
						{
							((IEntity)value).SetRelatedEntity(this, "ObserverDataSetColourCollection");
						}
					}
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for ObserverDataSet. When set to true, ObserverDataSet is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ObserverDataSet is accessed. You can always execute
		/// a forced fetch by calling GetSingleObserverDataSet(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchObserverDataSet
		{
			get	{ return _alwaysFetchObserverDataSet; }
			set	{ _alwaysFetchObserverDataSet = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property ObserverDataSet already has been fetched. Setting this property to false when ObserverDataSet has been fetched
		/// will set ObserverDataSet to null as well. Setting this property to true while ObserverDataSet hasn't been fetched disables lazy loading for ObserverDataSet</summary>
		[Browsable(false)]
		public bool AlreadyFetchedObserverDataSet
		{
			get { return _alreadyFetchedObserverDataSet;}
			set 
			{
				if(_alreadyFetchedObserverDataSet && !value)
				{
					this.ObserverDataSet = null;
				}
				_alreadyFetchedObserverDataSet = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property ObserverDataSet is not found
		/// in the database. When set to true, ObserverDataSet will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool ObserverDataSetReturnsNewIfNotFound
		{
			get	{ return _observerDataSetReturnsNewIfNotFound; }
			set { _observerDataSetReturnsNewIfNotFound = value; }	
		}



		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary>Returns the silverspun.RGBDiff.Dal.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)silverspun.RGBDiff.Dal.EntityType.ObserverDataSetColourEntity; }
		}
		#endregion

		
		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
