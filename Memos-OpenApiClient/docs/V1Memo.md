# Org.OpenAPITools.Model.V1Memo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the memo. Format: memos/{id} id is the system generated id. | [optional] 
**Uid** | **string** | The user defined id of the memo. | [optional] 
**RowStatus** | **V1RowStatus** |  | [optional] 
**Creator** | **string** |  | [optional] 
**CreateTime** | **DateTime** |  | [optional] 
**UpdateTime** | **DateTime** |  | [optional] 
**DisplayTime** | **DateTime** |  | [optional] 
**Content** | **string** |  | [optional] 
**Nodes** | [**List&lt;V1Node&gt;**](V1Node.md) |  | [optional] [readonly] 
**Visibility** | **V1Visibility** |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**Pinned** | **bool** |  | [optional] 
**ParentId** | **int** |  | [optional] [readonly] 
**Resources** | [**List&lt;V1Resource&gt;**](V1Resource.md) |  | [optional] [readonly] 
**Relations** | [**List&lt;V1MemoRelation&gt;**](V1MemoRelation.md) |  | [optional] [readonly] 
**Reactions** | [**List&lt;V1Reaction&gt;**](V1Reaction.md) |  | [optional] [readonly] 
**Property** | [**V1MemoProperty**](V1MemoProperty.md) |  | [optional] 
**Parent** | **string** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

