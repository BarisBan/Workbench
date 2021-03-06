﻿using BlogProject.DAL.ORM.Entity;
using BlogProject.UI.Areas.Admin.Models.DTO;
using BlogProject.UI.Areas.Admin.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProject.UI.Areas.Admin.Controllers
{
    public class ArticleController : BaseController
    {
        public ActionResult Add()
        {
            AddArticleVM model = new AddArticleVM()
            {
                Categories = service.CatetegoryService.GetActive(),

                AppUsers = service.AppUserService.GetActive(),

            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Article data)
        {
            service.ArticleService.Add(data);
            return Redirect("/Admin/Article/List");
        }

        public ActionResult List()
        {
            List<Article> model = service.ArticleService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            UpdateArticleVM model = new UpdateArticleVM();

            Article article = service.ArticleService.GetById(id);
            model.Article.ID = article.ID;
            model.Article.Header = article.Header;
            model.Article.Content = article.Content;

            model.Categories = service.CatetegoryService.GetActive();
            model.AppUsers = service.AppUserService.GetActive();

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(ArticleDTO data)
        {
            Article article = service.ArticleService.GetById(data.ID);

            article.Header = data.Header;
            article.Content = data.Content;
            article.CategoryID = data.CategoryID;
            article.AppUserID = data.AppUserID;

            service.ArticleService.Update(article);

            return Redirect("/Admin/Article/List");
        }


        public ActionResult Delete(Guid id)
        {
            service.ArticleService.Remove(id);
            return Redirect("/Admin/Article/List");

        }

    }
}