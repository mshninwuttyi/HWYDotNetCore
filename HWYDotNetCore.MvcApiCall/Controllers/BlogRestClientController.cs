﻿using System.Text;
using System.Text.Json.Serialization;
using HWYDotNetCore.MvcApiCall.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using static System.Net.Mime.MediaTypeNames;

namespace HWYDotNetCore.MvcApiCall.Controllers
{
    public class BlogRestClientController : Controller
    {
        private readonly RestClient _restClient;

        public BlogRestClientController(RestClient restClient)
        {
            _restClient = restClient;
        }

        [ActionName("Index")]
        public async Task<IActionResult> BlogIndexAsync(int pageNo = 1, int pageSize = 10)
        {
            BlogResponseModel model = new BlogResponseModel();
            RestRequest restRequest = new RestRequest($"api/blog/{pageNo}/{pageSize}", Method.Get);
            var response = await _restClient.ExecuteAsync(restRequest);
            if (response.IsSuccessStatusCode)
            {
                var jsonStr = response.Content;
                model = JsonConvert.DeserializeObject<BlogResponseModel>(jsonStr!)!;
            }
            return View("BlogIndex", model);
        }

        [ActionName("Create")]
        public IActionResult BlogCreate()
        {
            return View("BlogCreate");
        }

        [HttpPost]
        [ActionName("Save")]
        public async Task<IActionResult> BlogSave(BlogModel blog)
        {
            RestRequest restRequest = new RestRequest("api/blog", Method.Post);
            restRequest.AddJsonBody(blog);
            await _restClient.ExecuteAsync(restRequest);
            return Redirect("/Blog");
        }

        [ActionName("Edit")]
        public async Task<IActionResult> BlogEditAsync(int id)
        {
            RestRequest restRequest = new RestRequest($"api/blog/{id}", Method.Get);
            var response = await _restClient.ExecuteAsync(restRequest);
            if (!response.IsSuccessStatusCode)
            {
                return Redirect("/Blog");
            }
            var jsonStr = response.Content;
            BlogModel model = JsonConvert.DeserializeObject<BlogModel>(jsonStr!)!;
            return View("BlogEdit", model);
        }

        [ActionName("Update")]
        public async Task<IActionResult> BlogUpdate(int id, BlogModel blog)
        {
            RestRequest restRequest = new RestRequest($"api/blog/{id}", Method.Put);
            restRequest.AddJsonBody(blog);
            await _restClient.ExecuteAsync(restRequest);
            return Redirect("/Blog");
        }

        [ActionName("Delete")]
        public async Task<IActionResult> BlogDelete(int id)
        {
            RestRequest restRequest = new RestRequest($"api/blog/{id}", Method.Delete);
            await _restClient.ExecuteAsync(restRequest);
            return Redirect("/Blog");
        }
    }
}
