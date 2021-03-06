﻿using Microsoft.AspNetCore.Mvc;
using Grand.Web.Services;
using Grand.Services.Forums;
using Grand.Framework.Components;

namespace Grand.Web.ViewComponents
{
    public class ForumBreadcrumbViewComponent : BaseViewComponent
    {
        private readonly IForumService _forumService;
        private readonly IBoardsWebService _boardsWebService;
        public ForumBreadcrumbViewComponent(IForumService forumService, IBoardsWebService boardsWebService)
        {
            this._forumService = forumService;
            this._boardsWebService = boardsWebService;
        }

        public IViewComponentResult Invoke(string forumGroupId, string forumId, string forumTopicId)
        {
            var model = _boardsWebService.PrepareForumBreadcrumb(forumGroupId, forumId, forumTopicId);
            return View(model);
        }
    }
}