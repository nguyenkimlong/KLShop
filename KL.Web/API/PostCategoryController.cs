using KL.Service;
using KL.Web.Infrastructure.Core;
using KLShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KL.Web.API
{
    [RoutePrefix("api/postcategory")]
    public class PostCategoryController : ApiControllerBase
    {
        IPostCategoryService _postCategoryService;
        public PostCategoryController(IErrorService erroService, IPostCategoryService postCategoryService) : base(erroService)
        {
            this._postCategoryService = postCategoryService;
        }
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request, PostCategory postCategory)
        {
            return CreateHttpReponse(request, () =>
            {
                HttpResponseMessage reponse = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var listcategory = _postCategoryService.GetAll();
                    _postCategoryService.Save();

                    reponse = request.CreateResponse(HttpStatusCode.Created, listcategory);
                }
                return reponse;
            });
        }
        [HttpPost]
        public HttpResponseMessage Create(HttpRequestMessage request, PostCategory postCategory)
        {
            return CreateHttpReponse(request, () =>
             {
                 HttpResponseMessage reponse = null;
                 if (ModelState.IsValid)
                 {
                     request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                 }
                 else
                 {
                     var category = _postCategoryService.Add(postCategory);
                     _postCategoryService.Save();

                     reponse = request.CreateResponse(HttpStatusCode.Created, category);
                 }
                 return reponse;
             });
        }
        [HttpPut]
        public HttpResponseMessage Update(HttpRequestMessage request, PostCategory postCategory)
        {
            return CreateHttpReponse(request, () =>
            {
                HttpResponseMessage reponse = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                     _postCategoryService.Update(postCategory);
                    _postCategoryService.Save();

                    reponse = request.CreateResponse(HttpStatusCode.OK);
                }
                return reponse;
            });
        }
       
        [HttpDelete]
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpReponse(request, () =>
            {
                HttpResponseMessage reponse = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _postCategoryService.Delete(id);
                    _postCategoryService.Save();

                    reponse = request.CreateResponse(HttpStatusCode.OK);
                }
                return reponse;
            });
        }
    }
}