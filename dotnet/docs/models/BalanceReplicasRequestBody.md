# Org.OpenAPITools.Model.BalanceReplicasRequestBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Nodes** | **List&lt;string&gt;** | The set of nodes across which replicas will be balanced. Defaults to all live data nodes. | [optional] 
**WaitForFinalState** | **bool** | If true, the request will complete only when all affected replicas become active. If false, the API will return the status of the single action, which may be before the new replica is online and active. | [optional] 
**Async** | **string** | Request ID to track this action which will be processed asynchronously. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

