using HWYDotNetCore.RestApiWithNLayer.Features.MyanmarProverbs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HWYDotNetCore.RestApiWithNLayer.Features.MyanmarMonths
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyanmarMonthsController : ControllerBase
    {
        private async Task<Rootobject> GetDataFromJsonData()
        {
            var jsonStr = await System.IO.File.ReadAllTextAsync("data3.json");
            var model = JsonConvert.DeserializeObject<Rootobject>(jsonStr);
            return model;
        }

        [HttpGet("MonthNames")]
        public async Task<IActionResult> GetMonths()
        {
            var model = await GetDataFromJsonData();
            var result = model.Tbl_Months;
            List<MonthNames> lst = result.Select(x => new MonthNames
            {
                MonthMm = x.MonthMm
            }).ToList();
            return Ok(lst);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var model = await GetDataFromJsonData();
            var item = model.Tbl_Months.FirstOrDefault(x => x.Id == id);
            return Ok(item);
        }
    }

    public class Rootobject
    {
        public Tbl_Months[] Tbl_Months { get; set; }
    }

    public class Tbl_Months
    {
        public int Id { get; set; }
        public string MonthMm { get; set; }
        public string MonthEn { get; set; }
        public string FestivalMm { get; set; }
        public string FestivalEn { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
    }

    public class MonthNames
    {
        public string MonthMm { get; set; }
    }
}
