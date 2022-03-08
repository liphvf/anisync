﻿// <auto-generated/>
#nullable enable

namespace GraphQL.Client
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial class GetUserIdResult : global::System.IEquatable<GetUserIdResult>, IGetUserIdResult
    {
        public GetUserIdResult(global::GraphQL.Client.IGetUserId_User? user)
        {
            User = user;
        }

        /// <summary>
        /// User query
        /// </summary>
        public global::GraphQL.Client.IGetUserId_User? User { get; }

        public virtual global::System.Boolean Equals(GetUserIdResult? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((User is null && other.User is null) || User != null && User.Equals(other.User)));
        }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetUserIdResult)obj);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                if (User != null)
                {
                    hash ^= 397 * User.GetHashCode();
                }

                return hash;
            }
        }
    }

    /// <summary>
    /// A user
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial class GetUserId_User_User : global::System.IEquatable<GetUserId_User_User>, IGetUserId_User_User
    {
        public GetUserId_User_User(global::System.Int32 id)
        {
            Id = id;
        }

        /// <summary>
        /// The id of the user
        /// </summary>
        public global::System.Int32 Id { get; }

        public virtual global::System.Boolean Equals(GetUserId_User_User? other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id);
        }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetUserId_User_User)obj);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;
                hash ^= 397 * Id.GetHashCode();
                return hash;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial interface IGetUserIdResult
    {
        /// <summary>
        /// User query
        /// </summary>
        public global::GraphQL.Client.IGetUserId_User? User { get; }
    }

    /// <summary>
    /// A user
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial interface IGetUserId_User
    {
        /// <summary>
        /// The id of the user
        /// </summary>
        public global::System.Int32 Id { get; }
    }

    /// <summary>
    /// A user
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial interface IGetUserId_User_User : IGetUserId_User
    {
    }

    /// <summary>
    /// Represents the operation service of the GetUserId GraphQL operation
    /// <code>
    /// query GetUserId {
    ///   User(name: "liphvf") {
    ///     __typename
    ///     id
    ///     ... on User {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial class GetUserIdQueryDocument : global::StrawberryShake.IDocument
    {
        private GetUserIdQueryDocument()
        {
        }

        public static GetUserIdQueryDocument Instance { get; } = new GetUserIdQueryDocument();
        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;
        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x55, 0x73, 0x65, 0x72, 0x49, 0x64, 0x20, 0x7b, 0x20, 0x55, 0x73, 0x65, 0x72, 0x28, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x22, 0x6c, 0x69, 0x70, 0x68, 0x76, 0x66, 0x22, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x69, 0x64, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x55, 0x73, 0x65, 0x72, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d};
        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("md5Hash", "9a29e08bb32c8c72e71fb0d20fe31eac");
        public override global::System.String ToString()
        {
#if NETSTANDARD2_0
        return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
#else
            return global::System.Text.Encoding.UTF8.GetString(Body);
#endif
        }
    }

    /// <summary>
    /// Represents the operation service of the GetUserId GraphQL operation
    /// <code>
    /// query GetUserId {
    ///   User(name: "liphvf") {
    ///     __typename
    ///     id
    ///     ... on User {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial class GetUserIdQuery : global::GraphQL.Client.IGetUserIdQuery
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetUserIdResult> _operationExecutor;
        public GetUserIdQuery(global::StrawberryShake.IOperationExecutor<IGetUserIdResult> operationExecutor)
        {
            _operationExecutor = operationExecutor ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetUserIdResult);
        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetUserIdResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest();
            return await _operationExecutor.ExecuteAsync(request, cancellationToken).ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetUserIdResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest();
            return _operationExecutor.Watch(request, strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest()
        {
            return CreateRequest(null);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return new global::StrawberryShake.OperationRequest(id: GetUserIdQueryDocument.Instance.Hash.Value, name: "GetUserId", document: GetUserIdQueryDocument.Instance, strategy: global::StrawberryShake.RequestStrategy.Default);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest();
        }
    }

    /// <summary>
    /// Represents the operation service of the GetUserId GraphQL operation
    /// <code>
    /// query GetUserId {
    ///   User(name: "liphvf") {
    ///     __typename
    ///     id
    ///     ... on User {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial interface IGetUserIdQuery : global::StrawberryShake.IOperationRequestFactory
    {
        global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetUserIdResult>> ExecuteAsync(global::System.Threading.CancellationToken cancellationToken = default);
        global::System.IObservable<global::StrawberryShake.IOperationResult<IGetUserIdResult>> Watch(global::StrawberryShake.ExecutionStrategy? strategy = null);
    }

    /// <summary>
    /// Represents the GraphQlClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial class GraphQlClient : global::GraphQL.Client.IGraphQlClient
    {
        private readonly global::GraphQL.Client.IGetUserIdQuery _getUserId;
        public GraphQlClient(global::GraphQL.Client.IGetUserIdQuery getUserId)
        {
            _getUserId = getUserId ?? throw new global::System.ArgumentNullException(nameof(getUserId));
        }

        public static global::System.String ClientName => "GraphQlClient";
        public global::GraphQL.Client.IGetUserIdQuery GetUserId => _getUserId;
    }

    /// <summary>
    /// Represents the GraphQlClient GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial interface IGraphQlClient
    {
        global::GraphQL.Client.IGetUserIdQuery GetUserId { get; }
    }
}

namespace GraphQL.Client.State
{
    ///<summary>A user</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial class UserEntity
    {
        public UserEntity(global::System.Int32 id = default !)
        {
            Id = id;
        }

        ///<summary>The id of the user</summary>
        public global::System.Int32 Id { get; }
    }

    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial class GetUserIdResultFactory : global::StrawberryShake.IOperationResultDataFactory<global::GraphQL.Client.GetUserIdResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::GraphQL.Client.State.UserEntity, GetUserId_User_User> _getUserId_User_UserFromUserEntityMapper;
        public GetUserIdResultFactory(global::StrawberryShake.IEntityStore entityStore, global::StrawberryShake.IEntityMapper<global::GraphQL.Client.State.UserEntity, GetUserId_User_User> getUserId_User_UserFromUserEntityMapper)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getUserId_User_UserFromUserEntityMapper = getUserId_User_UserFromUserEntityMapper ?? throw new global::System.ArgumentNullException(nameof(getUserId_User_UserFromUserEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::GraphQL.Client.IGetUserIdResult);
        public GetUserIdResult Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetUserIdResultInfo info)
            {
                return new GetUserIdResult(MapIGetUserId_User(info.User, snapshot));
            }

            throw new global::System.ArgumentException("GetUserIdResultInfo expected.");
        }

        private global::GraphQL.Client.IGetUserId_User? MapIGetUserId_User(global::StrawberryShake.EntityId? entityId, global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }

            if (entityId.Value.Name.Equals("User", global::System.StringComparison.Ordinal))
            {
                return _getUserId_User_UserFromUserEntityMapper.Map(snapshot.GetEntity<global::GraphQL.Client.State.UserEntity>(entityId.Value) ?? throw new global::StrawberryShake.GraphQLClientException());
            }

            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(global::StrawberryShake.IOperationResultDataInfo dataInfo, global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(dataInfo, snapshot);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial class GetUserIdResultInfo : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;
        public GetUserIdResultInfo(global::StrawberryShake.EntityId? user, global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds, global::System.UInt64 version)
        {
            User = user;
            _entityIds = entityIds ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        /// <summary>
        /// User query
        /// </summary>
        public global::StrawberryShake.EntityId? User { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;
        public global::System.UInt64 Version => _version;
        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetUserIdResultInfo(User, _entityIds, version);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial class GetUserId_User_UserFromUserEntityMapper : global::StrawberryShake.IEntityMapper<global::GraphQL.Client.State.UserEntity, GetUserId_User_User>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        public GetUserId_User_UserFromUserEntityMapper(global::StrawberryShake.IEntityStore entityStore)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
        }

        public GetUserId_User_User Map(global::GraphQL.Client.State.UserEntity entity, global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetUserId_User_User(entity.Id);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial class GetUserIdBuilder : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::GraphQL.Client.IGetUserIdResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::GraphQL.Client.IGetUserIdResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;
        public GetUserIdBuilder(global::StrawberryShake.IEntityStore entityStore, global::StrawberryShake.IEntityIdSerializer idSerializer, global::StrawberryShake.IOperationResultDataFactory<global::GraphQL.Client.IGetUserIdResult> resultDataFactory, global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int") ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetUserIdResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetUserIdResult Result, GetUserIdResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;
            if (response.Exception is null)
            {
                try
                {
                    if (response.Body != null)
                    {
                        if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement) && dataElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                        {
                            data = BuildData(dataElement);
                        }

                        if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                        {
                            errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                        }
                    }
                }
                catch (global::System.Exception ex)
                {
                    errors = new global::StrawberryShake.IClientError[]{new global::StrawberryShake.ClientError(ex.Message, exception: ex, extensions: new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>{{"body", response.Body?.RootElement.ToString()}})};
                }
            }
            else
            {
                if (response.Body != null && response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                {
                    errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                }
                else
                {
                    errors = new global::StrawberryShake.IClientError[]{new global::StrawberryShake.ClientError(response.Exception.Message, exception: response.Exception, extensions: new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>{{"body", response.Body?.RootElement.ToString()}})};
                }
            }

            return new global::StrawberryShake.OperationResult<IGetUserIdResult>(data?.Result, data?.Info, _resultDataFactory, errors);
        }

        private (IGetUserIdResult, GetUserIdResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default !;
            global::StrawberryShake.EntityId? userId = default !;
            _entityStore.Update(session =>
            {
                userId = UpdateIGetUserId_UserEntity(session, global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "User"), entityIds);
                snapshot = session.CurrentSnapshot;
            });
            var resultInfo = new GetUserIdResultInfo(userId, entityIds, snapshot.Version);
            return (_resultDataFactory.Create(resultInfo), resultInfo);
        }

        private global::StrawberryShake.EntityId? UpdateIGetUserId_UserEntity(global::StrawberryShake.IEntityStoreUpdateSession session, global::System.Text.Json.JsonElement? obj, global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);
            if (entityId.Name.Equals("User", global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(entityId, out global::GraphQL.Client.State.UserEntity? entity))
                {
                    session.SetEntity(entityId, new global::GraphQL.Client.State.UserEntity(DeserializeNonNullableInt32(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "id"))));
                }
                else
                {
                    session.SetEntity(entityId, new global::GraphQL.Client.State.UserEntity(DeserializeNonNullableInt32(global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(obj, "id"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial class GraphQlClientEntityIdFactory : global::StrawberryShake.IEntityIdSerializer
    {
        private static readonly global::System.Text.Json.JsonWriterOptions _options = new global::System.Text.Json.JsonWriterOptions()
        {Indented = false};
        public global::StrawberryShake.EntityId Parse(global::System.Text.Json.JsonElement obj)
        {
            global::System.String __typename = obj.GetProperty("__typename").GetString()!;
            return __typename switch
            {
                "User" => ParseUserEntityId(obj, __typename),
                _ => throw new global::System.NotSupportedException()};
        }

        public global::System.String Format(global::StrawberryShake.EntityId entityId)
        {
            return entityId.Name switch
            {
                "User" => FormatUserEntityId(entityId),
                _ => throw new global::System.NotSupportedException()};
        }

        private global::StrawberryShake.EntityId ParseUserEntityId(global::System.Text.Json.JsonElement obj, global::System.String type)
        {
            return new global::StrawberryShake.EntityId(type, obj.GetProperty("id").GetInt32()!);
        }

        private global::System.String FormatUserEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(writer, _options);
            jsonWriter.WriteStartObject();
            jsonWriter.WriteString("__typename", entityId.Name);
            jsonWriter.WriteNumber("id", (global::System.Int32)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();
            return global::System.Text.Encoding.UTF8.GetString(writer.GetInternalBuffer(), 0, writer.Length);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public partial class GraphQlClientStoreAccessor : global::StrawberryShake.StoreAccessor
    {
        public GraphQlClientStoreAccessor(global::StrawberryShake.IOperationStore operationStore, global::StrawberryShake.IEntityStore entityStore, global::StrawberryShake.IEntityIdSerializer entityIdSerializer, global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory> requestFactories, global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory> resultDataFactories) : base(operationStore, entityStore, entityIdSerializer, requestFactories, resultDataFactories)
        {
        }
    }
}

namespace Microsoft.Extensions.DependencyInjection
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "12.6.2.0")]
    public static partial class GraphQlClientServiceCollectionExtensions
    {
        public static global::StrawberryShake.IClientBuilder<global::GraphQL.Client.State.GraphQlClientStoreAccessor> AddGraphQlClient(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            var serviceCollection = new global::Microsoft.Extensions.DependencyInjection.ServiceCollection();
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp =>
            {
                ConfigureClientDefault(sp, serviceCollection, strategy);
                return new ClientServiceProvider(global::Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(serviceCollection));
            });
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => new global::GraphQL.Client.State.GraphQlClientStoreAccessor(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityIdSerializer>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory>>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory>>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp))));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GraphQL.Client.GetUserIdQuery>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GraphQL.Client.GraphQlClient>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GraphQL.Client.IGraphQlClient>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            return new global::StrawberryShake.ClientBuilder<global::GraphQL.Client.State.GraphQlClientStoreAccessor>("GraphQlClient", services, serviceCollection);
        }

        private static global::Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureClientDefault(global::System.IServiceProvider parentServices, global::Microsoft.Extensions.DependencyInjection.ServiceCollection services, global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IEntityStore, global::StrawberryShake.EntityStore>(services);
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IOperationStore>(services, sp => new global::StrawberryShake.OperationStore(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Transport.Http.IHttpConnection>(services, sp =>
            {
                var clientFactory = global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Net.Http.IHttpClientFactory>(parentServices);
                return new global::StrawberryShake.Transport.Http.HttpConnection(() => clientFactory.CreateClient("GraphQlClient"));
            });
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::GraphQL.Client.State.UserEntity, global::GraphQL.Client.GetUserId_User_User>, global::GraphQL.Client.State.GetUserId_User_UserFromUserEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.StringSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.BooleanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ShortSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IntSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.LongSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.FloatSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DecimalSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UrlSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UUIDSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IdSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateTimeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteArraySerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.TimeSpanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.JsonSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializerResolver>(services, sp => new global::StrawberryShake.Serialization.SerializerResolver(global::System.Linq.Enumerable.Concat(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(parentServices), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(sp))));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::GraphQL.Client.IGetUserIdResult>, global::GraphQL.Client.State.GetUserIdResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::GraphQL.Client.IGetUserIdResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GraphQL.Client.IGetUserIdQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::GraphQL.Client.IGetUserIdResult>, global::GraphQL.Client.State.GetUserIdBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::GraphQL.Client.IGetUserIdResult>>(services, sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::GraphQL.Client.IGetUserIdResult>(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.IHttpConnection>(sp), () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::GraphQL.Client.IGetUserIdResult>>(sp), global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp), strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::GraphQL.Client.GetUserIdQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::GraphQL.Client.IGetUserIdQuery>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GraphQL.Client.GetUserIdQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityIdSerializer, global::GraphQL.Client.State.GraphQlClientEntityIdFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::GraphQL.Client.GraphQlClient>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::GraphQL.Client.IGraphQlClient>(services, sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::GraphQL.Client.GraphQlClient>(sp));
            return services;
        }

        private class ClientServiceProvider : System.IServiceProvider, System.IDisposable
        {
            private readonly System.IServiceProvider _provider;
            public ClientServiceProvider(System.IServiceProvider provider)
            {
                _provider = provider;
            }

            public object? GetService(System.Type serviceType)
            {
                return _provider.GetService(serviceType);
            }

            public void Dispose()
            {
                if (_provider is System.IDisposable d)
                {
                    d.Dispose();
                }
            }
        }
    }
}