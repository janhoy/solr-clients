# SolrClient.Model.MigrateReplicasRequestBodyModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceNodes** | **Collection&lt;string&gt;** | The set of nodes which all replicas will be migrated off of. | 
**TargetNodes** | **Collection&lt;string&gt;** | A set of nodes to migrate the replicas to. If this is not provided, then the API will use the live data nodes not in &#39;sourceNodes&#39;. | [optional] 
**WaitForFinalState** | **bool** | If true, the request will complete only when all affected replicas become active. If false, the API will return the status of the single action, which may be before the new replicas are online and active. | [optional] 
**Async** | **string** | Request ID to track this action which will be processed asynchronously. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

