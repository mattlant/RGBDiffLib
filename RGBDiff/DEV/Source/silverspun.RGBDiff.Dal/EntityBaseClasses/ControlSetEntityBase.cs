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
	/// <summary>Entity base class which represents the base class for the entity 'ControlSet'.<br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public abstract partial class ControlSetEntityBase : CommonEntityBase, ISerializable
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private silverspun.RGBDiff.Dal.CollectionClasses.ControlSetColourCollection	_controlSetColourCollection;
		private bool	_alwaysFetchControlSetColourCollection, _alreadyFetchedControlSetColourCollection;
		private silverspun.RGBDiff.Dal.CollectionClasses.ObserverDataSetCollection	_observerDataSetCollection;
		private bool	_alwaysFetchObserverDataSetCollection, _alreadyFetchedObserverDataSetCollection;



		
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{

			/// <summary>Member name ControlSetColourCollection</summary>
			public static readonly string ControlSetColourCollection = "ControlSetColourCollection";
			/// <summary>Member name ObserverDataSetCollection</summary>
			public static readonly string ObserverDataSetCollection = "ObserverDataSetCollection";


		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ControlSetEntityBase()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public ControlSetEntityBase()
		{
			InitClassEmpty(null);
		}

	
		/// <summary>CTor</summary>
		/// <param name="uID">PK value for ControlSet which data should be fetched into this ControlSet object</param>
		public ControlSetEntityBase(System.Int32 uID)
		{
			InitClassFetch(uID, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="uID">PK value for ControlSet which data should be fetched into this ControlSet object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public ControlSetEntityBase(System.Int32 uID, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(uID, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="uID">PK value for ControlSet which data should be fetched into this ControlSet object</param>
		/// <param name="validator">The custom validator object for this ControlSetEntity</param>
		public ControlSetEntityBase(System.Int32 uID, IValidator validator)
		{
			InitClassFetch(uID, validator, null);
		}
	

		/// <summary>Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ControlSetEntityBase(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_controlSetColourCollection = (silverspun.RGBDiff.Dal.CollectionClasses.ControlSetColourCollection)info.GetValue("_controlSetColourCollection", typeof(silverspun.RGBDiff.Dal.CollectionClasses.ControlSetColourCollection));
			_alwaysFetchControlSetColourCollection = info.GetBoolean("_alwaysFetchControlSetColourCollection");
			_alreadyFetchedControlSetColourCollection = info.GetBoolean("_alreadyFetchedControlSetColourCollection");
			_observerDataSetCollection = (silverspun.RGBDiff.Dal.CollectionClasses.ObserverDataSetCollection)info.GetValue("_observerDataSetCollection", typeof(silverspun.RGBDiff.Dal.CollectionClasses.ObserverDataSetCollection));
			_alwaysFetchObserverDataSetCollection = info.GetBoolean("_alwaysFetchObserverDataSetCollection");
			_alreadyFetchedObserverDataSetCollection = info.GetBoolean("_alreadyFetchedObserverDataSetCollection");



			base.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ControlSetFieldIndex)fieldIndex)
			{
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
			_alreadyFetchedControlSetColourCollection = (_controlSetColourCollection.Count > 0);
			_alreadyFetchedObserverDataSetCollection = (_observerDataSetCollection.Count > 0);



		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return ControlSetEntity.GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		public static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{

				case "ControlSetColourCollection":
					toReturn.Add(ControlSetEntity.Relations.ControlSetColourEntityUsingControlSetUID);
					break;
				case "ObserverDataSetCollection":
					toReturn.Add(ControlSetEntity.Relations.ObserverDataSetEntityUsingControlSetUID);
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
			info.AddValue("_controlSetColourCollection", (!this.MarkedForDeletion?_controlSetColourCollection:null));
			info.AddValue("_alwaysFetchControlSetColourCollection", _alwaysFetchControlSetColourCollection);
			info.AddValue("_alreadyFetchedControlSetColourCollection", _alreadyFetchedControlSetColourCollection);
			info.AddValue("_observerDataSetCollection", (!this.MarkedForDeletion?_observerDataSetCollection:null));
			info.AddValue("_alwaysFetchObserverDataSetCollection", _alwaysFetchObserverDataSetCollection);
			info.AddValue("_alreadyFetchedObserverDataSetCollection", _alreadyFetchedObserverDataSetCollection);



			
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

				case "ControlSetColourCollection":
					_alreadyFetchedControlSetColourCollection = true;
					if(entity!=null)
					{
						this.ControlSetColourCollection.Add((ControlSetColourEntity)entity);
					}
					break;
				case "ObserverDataSetCollection":
					_alreadyFetchedObserverDataSetCollection = true;
					if(entity!=null)
					{
						this.ObserverDataSetCollection.Add((ObserverDataSetEntity)entity);
					}
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

				case "ControlSetColourCollection":
					_controlSetColourCollection.Add((ControlSetColourEntity)relatedEntity);
					break;
				case "ObserverDataSetCollection":
					_observerDataSetCollection.Add((ObserverDataSetEntity)relatedEntity);
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

				case "ControlSetColourCollection":
					base.PerformRelatedEntityRemoval(_controlSetColourCollection, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ObserverDataSetCollection":
					base.PerformRelatedEntityRemoval(_observerDataSetCollection, relatedEntity, signalRelatedEntityManyToOne);
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



			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();
			toReturn.Add(_controlSetColourCollection);
			toReturn.Add(_observerDataSetCollection);

			return toReturn;
		}

		

		

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="uID">PK value for ControlSet which data should be fetched into this ControlSet object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 uID)
		{
			return FetchUsingPK(uID, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="uID">PK value for ControlSet which data should be fetched into this ControlSet object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 uID, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(uID, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="uID">PK value for ControlSet which data should be fetched into this ControlSet object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 uID, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return Fetch(uID, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="uID">PK value for ControlSet which data should be fetched into this ControlSet object</param>
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
		public bool TestOriginalFieldValueForNull(ControlSetFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}
		
		/// <summary>Returns true if the current value for the field with the fieldIndex passed in represents null/not defined, false otherwise.
		/// Should not be used for testing if the original value (read from the db) is NULL</summary>
		/// <param name="fieldIndex">Index of the field to test if its currentvalue is null/undefined</param>
		/// <returns>true if the field's value isn't defined yet, false otherwise</returns>
		public bool TestCurrentFieldValueForNull(ControlSetFieldIndex fieldIndex)
		{
			return base.CheckIfCurrentFieldValueIsNull((int)fieldIndex);
		}

				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			return new ControlSetRelations().GetAllRelations();
		}


		/// <summary> Retrieves all related entities of type 'ControlSetColourEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ControlSetColourEntity'</returns>
		public silverspun.RGBDiff.Dal.CollectionClasses.ControlSetColourCollection GetMultiControlSetColourCollection(bool forceFetch)
		{
			return GetMultiControlSetColourCollection(forceFetch, _controlSetColourCollection.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ControlSetColourEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ControlSetColourEntity'</returns>
		public silverspun.RGBDiff.Dal.CollectionClasses.ControlSetColourCollection GetMultiControlSetColourCollection(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiControlSetColourCollection(forceFetch, _controlSetColourCollection.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ControlSetColourEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public silverspun.RGBDiff.Dal.CollectionClasses.ControlSetColourCollection GetMultiControlSetColourCollection(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiControlSetColourCollection(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ControlSetColourEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual silverspun.RGBDiff.Dal.CollectionClasses.ControlSetColourCollection GetMultiControlSetColourCollection(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedControlSetColourCollection || forceFetch || _alwaysFetchControlSetColourCollection) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_controlSetColourCollection.ParticipatesInTransaction)
					{
						base.Transaction.Add(_controlSetColourCollection);
					}
				}
				_controlSetColourCollection.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_controlSetColourCollection.EntityFactoryToUse = entityFactoryToUse;
				}
				_controlSetColourCollection.GetMultiManyToOne(this, filter);
				_controlSetColourCollection.SuppressClearInGetMulti=false;
				_alreadyFetchedControlSetColourCollection = true;
			}
			return _controlSetColourCollection;
		}

		/// <summary> Sets the collection parameters for the collection for 'ControlSetColourCollection'. These settings will be taken into account
		/// when the property ControlSetColourCollection is requested or GetMultiControlSetColourCollection is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersControlSetColourCollection(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_controlSetColourCollection.SortClauses=sortClauses;
			_controlSetColourCollection.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

		/// <summary> Retrieves all related entities of type 'ObserverDataSetEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ObserverDataSetEntity'</returns>
		public silverspun.RGBDiff.Dal.CollectionClasses.ObserverDataSetCollection GetMultiObserverDataSetCollection(bool forceFetch)
		{
			return GetMultiObserverDataSetCollection(forceFetch, _observerDataSetCollection.EntityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ObserverDataSetEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ObserverDataSetEntity'</returns>
		public silverspun.RGBDiff.Dal.CollectionClasses.ObserverDataSetCollection GetMultiObserverDataSetCollection(bool forceFetch, IPredicateExpression filter)
		{
			return GetMultiObserverDataSetCollection(forceFetch, _observerDataSetCollection.EntityFactoryToUse, filter);
		}

		/// <summary> Retrieves all related entities of type 'ObserverDataSetEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public silverspun.RGBDiff.Dal.CollectionClasses.ObserverDataSetCollection GetMultiObserverDataSetCollection(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
			return GetMultiObserverDataSetCollection(forceFetch, entityFactoryToUse, null);
		}

		/// <summary> Retrieves all related entities of type 'ObserverDataSetEntity' using a relation of type '1:n'.</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual silverspun.RGBDiff.Dal.CollectionClasses.ObserverDataSetCollection GetMultiObserverDataSetCollection(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedObserverDataSetCollection || forceFetch || _alwaysFetchObserverDataSetCollection) && !base.IsSerializing && !base.IsDeserializing && !base.InDesignMode)
			{
				if(base.ParticipatesInTransaction)
				{
					if(!_observerDataSetCollection.ParticipatesInTransaction)
					{
						base.Transaction.Add(_observerDataSetCollection);
					}
				}
				_observerDataSetCollection.SuppressClearInGetMulti=!forceFetch;
				if(entityFactoryToUse!=null)
				{
					_observerDataSetCollection.EntityFactoryToUse = entityFactoryToUse;
				}
				_observerDataSetCollection.GetMultiManyToOne(this, filter);
				_observerDataSetCollection.SuppressClearInGetMulti=false;
				_alreadyFetchedObserverDataSetCollection = true;
			}
			return _observerDataSetCollection;
		}

		/// <summary> Sets the collection parameters for the collection for 'ObserverDataSetCollection'. These settings will be taken into account
		/// when the property ObserverDataSetCollection is requested or GetMultiObserverDataSetCollection is called.</summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersObserverDataSetCollection(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_observerDataSetCollection.SortClauses=sortClauses;
			_observerDataSetCollection.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}




		/// <summary> Performs the insert action of a new Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			ControlSetDAO dao = (ControlSetDAO)CreateDAOInstance();
			return dao.AddNew(base.Fields, base.Transaction);
		}
		
		/// <summary> Adds the internals to the active context. </summary>
		protected override void AddInternalsToContext()
		{
			_controlSetColourCollection.ActiveContext = base.ActiveContext;
			_observerDataSetCollection.ActiveContext = base.ActiveContext;




		}


		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ControlSetDAO dao = (ControlSetDAO)CreateDAOInstance();
			return dao.UpdateExisting(base.Fields, base.Transaction);
		}
		
		/// <summary> Performs the update action of an existing Entity to the persistent storage.</summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ControlSetDAO dao = (ControlSetDAO)CreateDAOInstance();
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
			return EntityFieldsFactory.CreateEntityFieldsObject(silverspun.RGBDiff.Dal.EntityType.ControlSetEntity);
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

			toReturn.Add("ControlSetColourCollection", _controlSetColourCollection);
			toReturn.Add("ObserverDataSetCollection", _observerDataSetCollection);


			return toReturn;
		}
		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="uID">PK value for ControlSet which data should be fetched into this ControlSet object</param>
		/// <param name="validator">The validator object for this ControlSetEntity</param>
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
			_controlSetColourCollection = new silverspun.RGBDiff.Dal.CollectionClasses.ControlSetColourCollection(new ControlSetColourEntityFactory());
			_controlSetColourCollection.SetContainingEntityInfo(this, "ControlSet");
			_alwaysFetchControlSetColourCollection = false;
			_alreadyFetchedControlSetColourCollection = false;
			_observerDataSetCollection = new silverspun.RGBDiff.Dal.CollectionClasses.ObserverDataSetCollection(new ObserverDataSetEntityFactory());
			_observerDataSetCollection.SetContainingEntityInfo(this, "ControlSet");
			_alwaysFetchObserverDataSetCollection = false;
			_alreadyFetchedObserverDataSetCollection = false;




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

			_fieldsCustomProperties.Add("Name", fieldHashtable);
		}
		#endregion




		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="uID">PK value for ControlSet which data should be fetched into this ControlSet object</param>
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
				base.Fields[(int)ControlSetFieldIndex.UID].ForcedCurrentValueWrite(uID);
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
			return DAOFactory.CreateControlSetDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new ControlSetEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ControlSetRelations Relations
		{
			get	{ return new ControlSetRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ControlSetColour' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathControlSetColourCollection
		{
			get
			{
				return new PrefetchPathElement(new silverspun.RGBDiff.Dal.CollectionClasses.ControlSetColourCollection(),
					(IEntityRelation)GetRelationsForField("ControlSetColourCollection")[0], (int)silverspun.RGBDiff.Dal.EntityType.ControlSetEntity, (int)silverspun.RGBDiff.Dal.EntityType.ControlSetColourEntity, 0, null, null, null, "ControlSetColourCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'ObserverDataSet' 
		/// for this entity. Add the object returned by this property to an existing PrefetchPath instance.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathObserverDataSetCollection
		{
			get
			{
				return new PrefetchPathElement(new silverspun.RGBDiff.Dal.CollectionClasses.ObserverDataSetCollection(),
					(IEntityRelation)GetRelationsForField("ObserverDataSetCollection")[0], (int)silverspun.RGBDiff.Dal.EntityType.ControlSetEntity, (int)silverspun.RGBDiff.Dal.EntityType.ObserverDataSetEntity, 0, null, null, null, "ObserverDataSetCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);
			}
		}




		/// <summary>Returns the full name for this entity, which is important for the DAO to find back persistence info for this entity.</summary>
		[Browsable(false), XmlIgnore]
		public override string LLBLGenProEntityName
		{
			get { return "ControlSetEntity";}
		}

		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		public override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return ControlSetEntity.CustomProperties;}
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
			get { return ControlSetEntity.FieldsCustomProperties;}
		}

		/// <summary> The UID property of the Entity ControlSet<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ControlSet"."UID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 UID
		{
			get { return (System.Int32)GetValue((int)ControlSetFieldIndex.UID, true); }
			set	{ SetValue((int)ControlSetFieldIndex.UID, value, true); }
		}
		/// <summary> The Name property of the Entity ControlSet<br/><br/>
		/// </summary>
		/// <remarks>Mapped on  table field: "ControlSet"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ControlSetFieldIndex.Name, true); }
			set	{ SetValue((int)ControlSetFieldIndex.Name, value, true); }
		}

		/// <summary> Retrieves all related entities of type 'ControlSetColourEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiControlSetColourCollection()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual silverspun.RGBDiff.Dal.CollectionClasses.ControlSetColourCollection ControlSetColourCollection
		{
			get	{ return GetMultiControlSetColourCollection(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ControlSetColourCollection. When set to true, ControlSetColourCollection is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ControlSetColourCollection is accessed. You can always execute
		/// a forced fetch by calling GetMultiControlSetColourCollection(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchControlSetColourCollection
		{
			get	{ return _alwaysFetchControlSetColourCollection; }
			set	{ _alwaysFetchControlSetColourCollection = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ControlSetColourCollection already has been fetched. Setting this property to false when ControlSetColourCollection has been fetched
		/// will clear the ControlSetColourCollection collection well. Setting this property to true while ControlSetColourCollection hasn't been fetched disables lazy loading for ControlSetColourCollection</summary>
		[Browsable(false)]
		public bool AlreadyFetchedControlSetColourCollection
		{
			get { return _alreadyFetchedControlSetColourCollection;}
			set 
			{
				if(_alreadyFetchedControlSetColourCollection && !value && (_controlSetColourCollection != null))
				{
					_controlSetColourCollection.Clear();
				}
				_alreadyFetchedControlSetColourCollection = value;
			}
		}
		/// <summary> Retrieves all related entities of type 'ObserverDataSetEntity' using a relation of type '1:n'.</summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiObserverDataSetCollection()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the same scope.</remarks>
		public virtual silverspun.RGBDiff.Dal.CollectionClasses.ObserverDataSetCollection ObserverDataSetCollection
		{
			get	{ return GetMultiObserverDataSetCollection(false); }
		}

		/// <summary> Gets / sets the lazy loading flag for ObserverDataSetCollection. When set to true, ObserverDataSetCollection is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ObserverDataSetCollection is accessed. You can always execute
		/// a forced fetch by calling GetMultiObserverDataSetCollection(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchObserverDataSetCollection
		{
			get	{ return _alwaysFetchObserverDataSetCollection; }
			set	{ _alwaysFetchObserverDataSetCollection = value; }	
		}		
				
		/// <summary>Gets / Sets the lazy loading flag if the property ObserverDataSetCollection already has been fetched. Setting this property to false when ObserverDataSetCollection has been fetched
		/// will clear the ObserverDataSetCollection collection well. Setting this property to true while ObserverDataSetCollection hasn't been fetched disables lazy loading for ObserverDataSetCollection</summary>
		[Browsable(false)]
		public bool AlreadyFetchedObserverDataSetCollection
		{
			get { return _alreadyFetchedObserverDataSetCollection;}
			set 
			{
				if(_alreadyFetchedObserverDataSetCollection && !value && (_observerDataSetCollection != null))
				{
					_observerDataSetCollection.Clear();
				}
				_alreadyFetchedObserverDataSetCollection = value;
			}
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
			get { return (int)silverspun.RGBDiff.Dal.EntityType.ControlSetEntity; }
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
