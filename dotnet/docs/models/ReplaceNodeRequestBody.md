# Org.OpenAPITools.Model.ReplaceNodeRequestBody

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TargetNodeName** | **string** | The target node where replicas will be copied. If this parameter is not provided, Solr will identify nodes automatically based on policies or number of cores in each node. | [optional] 
**WaitForFinalState** | **bool** | If true, the request will complete only when all affected replicas become active. If false, the API will return the status of the single action, which may be before the new replica is online and active. | [optional] 
**Async** | **string** | Request ID to track this action which will be processed asynchronously. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

