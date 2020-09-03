using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System.Collections.Generic;

namespace GlobalizationPOC.Controllers
{
    [ApiController]
    [Route("v1/api/[controller]")]
    public class GlobalizationController : ControllerBase
    {
        private readonly IStringLocalizer<SharedResource> _localizer;

        public GlobalizationController(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
        }


        [HttpGet]
        [Route("{id}")]
        public List<string> GetById(string id)
        {
            var messages = new List<string>();

            var success = string.Format(_localizer["1"]);
            var getById = string.Format(_localizer["2", id]);
            var getByContractId = string.Format(_localizer["3", id]);
            var getData = string.Format(_localizer["4"]);
            var updateContractId = string.Format(_localizer["5", id]);
            var getHistoryByRegisterLoanId = string.Format(_localizer["6", id]);
            var getLastestHistoryByRegisterLoanId = string.Format(_localizer["7", id]);


            messages.Add(success);
            messages.Add(getById);
            messages.Add(getByContractId);
            messages.Add(getData);
            messages.Add(updateContractId);
            messages.Add(getHistoryByRegisterLoanId);
            messages.Add(getLastestHistoryByRegisterLoanId);

            return messages;
        }

    }
}
