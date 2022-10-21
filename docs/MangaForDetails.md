# Org.OpenAPITools.Model.MangaForDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] 
**Title** | **string** |  | [optional] 
**MainPicture** | [**WorkBaseMainPicture**](WorkBaseMainPicture.md) |  | [optional] 
**AlternativeTitles** | [**WorkForListAllOfAlternativeTitles**](WorkForListAllOfAlternativeTitles.md) |  | [optional] 
**StartDate** | **string** |  | [optional] 
**EndDate** | **string** |  | [optional] 
**Synopsis** | **string** | Synopsis.   The API strips BBCode tags from the result.  | [optional] 
**Mean** | **float?** | Mean score.  When the &#x60;mean&#x60; can not be calculated, such as when the number of user scores is small, the result does not include this field.   | [optional] 
**Rank** | **int?** | When the &#x60;rank&#x60; can not be calculated, such as when the number of user scores is small, the result does not include this field.   | [optional] 
**Popularity** | **int?** |  | [optional] 
**NumListUsers** | **int** | Number of users who have this work in their list.  | [optional] 
**NumScoringUsers** | **int** |  | [optional] 
**Nsfw** | **string** | | Value | Description | | - -- - | - -- - | | white | This work is safe for work | | gray | This work may be not safe for work | | black | This work is not safe for work |  | [optional] 
**Genres** | [**List&lt;Genre&gt;**](Genre.md) |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**MediaType** | **string** | - unknown - manga - novel - one_shot - doujinshi - manhwa - manhua - oel  | [optional] 
**Status** | **string** | Publishing status.  - finished - currently_publishing - not_yet_published  | [optional] 
**MyListStatus** | **Object** |  | [optional] 
**NumVolumes** | **int** | If unknown, it is 0.  | [optional] 
**NumChapters** | **int** | If unknown, it is 0.  | [optional] 
**Authors** | [**List&lt;PersonRoleEdge&gt;**](PersonRoleEdge.md) |  | [optional] 
**Pictures** | [**List&lt;Picture&gt;**](Picture.md) | You cannot contain this field in a list.   | [optional] 
**Background** | **string** | The API strips BBCode tags from the result.  You cannot contain this field in a list.    | [optional] 
**RelatedAnime** | [**List&lt;RelatedAnimeEdge&gt;**](RelatedAnimeEdge.md) | You cannot contain this field in a list.   | [optional] 
**RelatedManga** | [**List&lt;RelatedMangaEdge&gt;**](RelatedMangaEdge.md) | You cannot contain this field in a list.   | [optional] 
**Recommendations** | [**List&lt;MangaRecommendationAggregationEdgeBase&gt;**](MangaRecommendationAggregationEdgeBase.md) | Summary of recommended anime for those who like this manga.  You cannot contain this field in a list.   | [optional] 
**Serialization** | [**List&lt;MangaMagazineRelationEdge&gt;**](MangaMagazineRelationEdge.md) | You cannot contain this field in a list.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

