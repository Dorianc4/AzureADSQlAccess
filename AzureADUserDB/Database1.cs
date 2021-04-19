// Licence file C:\Users\RodriguezDA\Documents\ReversePOCO.txt not found.
// Please obtain your licence file at www.ReversePOCO.co.uk, and place it in your documents folder shown above.
// Defaulting to Trial version.


// ------------------------------------------------------------------------------------------------
// WARNING: Failed to load provider "System.Data.SqlClient" - Cannot open database "Northwind" requested by the login. The login failed. Login failed for user 'VALUETEAM\RodriguezDa'.
// Allowed providers:
//    "System.Data.Odbc"
//    "System.Data.OleDb"
//    "System.Data.OracleClient"
//    "System.Data.SqlClient"
//    "Microsoft.SqlServerCe.Client.4.0"

/*   at System.Data.SqlClient.SqlInternalConnectionTds..ctor(DbConnectionPoolIdentity identity, SqlConnectionString connectionOptions, SqlCredential credential, Object providerInfo, String newPassword, SecureString newSecurePassword, Boolean redirectedUserInstance, SqlConnectionString userConnectionOptions, SessionData reconnectSessionData, DbConnectionPool pool, String accessToken, Boolean applyTransientFaultHandling, SqlAuthenticationProviderManager sqlAuthProviderManager)
   at System.Data.SqlClient.SqlConnectionFactory.CreateConnection(DbConnectionOptions options, DbConnectionPoolKey poolKey, Object poolGroupProviderInfo, DbConnectionPool pool, DbConnection owningConnection, DbConnectionOptions userOptions)
   at System.Data.ProviderBase.DbConnectionFactory.CreatePooledConnection(DbConnectionPool pool, DbConnection owningObject, DbConnectionOptions options, DbConnectionPoolKey poolKey, DbConnectionOptions userOptions)
   at System.Data.ProviderBase.DbConnectionPool.CreateObject(DbConnection owningObject, DbConnectionOptions userOptions, DbConnectionInternal oldConnection)
   at System.Data.ProviderBase.DbConnectionPool.UserCreateRequest(DbConnection owningObject, DbConnectionOptions userOptions, DbConnectionInternal oldConnection)
   at System.Data.ProviderBase.DbConnectionPool.TryGetConnection(DbConnection owningObject, UInt32 waitForMultipleObjectsTimeout, Boolean allowCreate, Boolean onlyOneCheckConnection, DbConnectionOptions userOptions, DbConnectionInternal& connection)
   at System.Data.ProviderBase.DbConnectionPool.TryGetConnection(DbConnection owningObject, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal& connection)
   at System.Data.ProviderBase.DbConnectionFactory.TryGetConnection(DbConnection owningConnection, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal oldConnection, DbConnectionInternal& connection)
   at System.Data.ProviderBase.DbConnectionInternal.TryOpenConnectionInternal(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   at System.Data.ProviderBase.DbConnectionClosed.TryOpenConnection(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   at System.Data.SqlClient.SqlConnection.TryOpenInner(TaskCompletionSource`1 retry)
   at System.Data.SqlClient.SqlConnection.TryOpen(TaskCompletionSource`1 retry)
   at System.Data.SqlClient.SqlConnection.Open()
   at Microsoft.VisualStudio.TextTemplating3DB1E5E173EE24C5733C8E6384BE0CB4B914EF02DF4E136E4D12B37CC6165DDA5E4DC9B64B86B42622FE072470B1B1C247955471BFEF0553A32B9C1BF8ED61F1.GeneratedTextTransformation.DatabaseReader.Init() in C:\Repos\AzureADSQlAccess\AzureADUserDB\EF.Reverse.POCO.v3.ttinclude:line 11761
   at Microsoft.VisualStudio.TextTemplating3DB1E5E173EE24C5733C8E6384BE0CB4B914EF02DF4E136E4D12B37CC6165DDA5E4DC9B64B86B42622FE072470B1B1C247955471BFEF0553A32B9C1BF8ED61F1.GeneratedTextTransformation.SqlServerDatabaseReader.Init() in C:\Repos\AzureADSQlAccess\AzureADUserDB\EF.Reverse.POCO.v3.ttinclude:line 14932
   at Microsoft.VisualStudio.TextTemplating3DB1E5E173EE24C5733C8E6384BE0CB4B914EF02DF4E136E4D12B37CC6165DDA5E4DC9B64B86B42622FE072470B1B1C247955471BFEF0553A32B9C1BF8ED61F1.GeneratedTextTransformation.Generator.Init(String singleDbContextSubNamespace) in C:\Repos\AzureADSQlAccess\AzureADUserDB\EF.Reverse.POCO.v3.ttinclude:line 3873*/
// ------------------------------------------------------------------------------------------------

