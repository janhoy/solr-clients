# ApacheSolr.Model.CreateCoreBackupRequestBodyModel
Additional backup params

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Repository** | **string** | The name of the repository to be used for backup. | [optional] 
**Location** | **string** | The path where the backup will be created | [optional] 
**ShardBackupId** | **string** |  | [optional] 
**PrevShardBackupId** | **string** |  | [optional] 
**CommitName** | **string** | The name of the commit which was used while taking a snapshot using the CREATESNAPSHOT command. | [optional] 
**Incremental** | **bool** | To turn on incremental backup feature | [optional] 
**Async** | **string** | Request ID to track this action which will be processed asynchronously. | [optional] 
**BackupName** | **string** | A descriptive name for the backup.  Only used by non-incremental backups. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

