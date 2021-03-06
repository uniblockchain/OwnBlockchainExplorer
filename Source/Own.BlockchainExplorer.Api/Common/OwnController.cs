﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Own.BlockchainExplorer.Common.Framework;

namespace Own.BlockchainExplorer.Api.Common
{
    public abstract class OwnController : ControllerBase
    {
        protected OwnController()
        {
        }

        protected IActionResult ValidationErrors => BadRequest(Result.Failure(this.GetValidationErrors()));

        /// <param name="mapFailure">Maps failure case into IActionResult. Uses BadRequest() by default.</param>
        protected IActionResult ApiResult<T>(Result<T> result, Func<Result<T>, IActionResult> mapFailure = null)
        {
            if (!result.Successful)
                return mapFailure == null ? BadRequest(result) : mapFailure(result);

            return Ok(result);
        }

        /// <param name="mapFailure">Maps failure case into IActionResult. Uses BadRequest() by default.</param>
        protected IActionResult ApiResult(Result result, Func<object, IActionResult> mapFailure = null)
        {
            if (!result.Successful)
                return mapFailure == null ? BadRequest(result) : mapFailure(result);

            return Ok(result);
        }

        protected async Task<IActionResult> AsyncApiResult<T>(
            Task<Result<T>> taskResult,
            Func<Result<T>, IActionResult> mapFailure = null)
        {
            return ApiResult<T>(await taskResult, mapFailure);
        }

        protected async Task<IActionResult> AsyncApiResult(
            Task<Result> taskResult,
            Func<object, IActionResult> mapFailure = null)
        {
            return ApiResult(await taskResult, mapFailure);
        }
    }
}
