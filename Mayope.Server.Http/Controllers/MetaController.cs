using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Mayope.Api;
using Mayope.Api.Requests;
using Mayope.Api.Responses;

namespace Mayope.Server.Http.Controllers
{
    public class MetaController : Controller
    {
        private IMayopeService Service { get; }
        private ILogger Logger { get; }

        public MetaController(
            IMayopeService service,
            ILogger<AuthController> logger)
        {
            Service = service;
            Logger = logger;
        }

        [HttpPost("ListForests")]
        public ListForestsResponse ListForests(
            [FromBody] ListForestsRequest request)
        {
            return Service.ListForests(request);
        }

        [HttpPost("ListTrees")]
        public ListTreesResponse ListTrees(
            [FromBody] ListTreesRequest request)
        {
            return Service.ListTrees(request);
        }

        [HttpPost("ListBranches")]
        public ListBranchesResponse ListBranches(
            [FromBody] ListBranchesRequest request)
        {
            return Service.ListBranches(request);
        }
    }
}
