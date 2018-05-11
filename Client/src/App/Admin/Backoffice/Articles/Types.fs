module Admin.Backoffice.Articles.Types

open Shared 

type State = {
    Articles : Remote<list<BlogPostItem>>
    DeletingArticle : Option<int> 
    MakingDraft : Option<int>
}

type Msg = 
    | LoadArticles 
    | ArticlesLoaded of list<BlogPostItem>
    | LoadArticlesError of string 
    | AskPermissionToDeleteArticle of articleId:int
    | DeleteArticle of articleId:int
    | CancelArticleDeletion 
    | ArticleDeleted
    | MakeIntoDraft of articleId:int 
    | DraftMade 
    | MakeDraftError of errorMsg:string
    | DeleteArticleError of string
    | EditArticle of articleId:int 
    | DoNothing