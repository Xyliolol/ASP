using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;


namespace Lesson1.Controllers
{
    [ApiController]
    [Route("/")]
    public class Lesson_1Controller : ControllerBase
    {

        private readonly ILogger<Lesson_1Controller> _logger;
        private readonly ValuesHolder _holder;

        public Lesson_1Controller(ILogger<Lesson_1Controller> logger, ValuesHolder holder)
        {
            _logger = logger;
            _holder = holder;
        }


        [HttpPost, Route("Save/{dd}/{temp}")]//dd - (20-02-02) temp - (20)
        public string SaveData([FromRoute] DateTime dd, int temp)
        {

            Lesson_1 newWeather = new Lesson_1() { Date = dd, TemperatureC = temp };

            int updated = 0;
            string status = "оригинал";
            foreach (var Temper in _holder.Values)
            {
                if (dd == Temper.Date)
                {
                    Temper.TemperatureC = temp;
                    updated = 1;
                    status = "изменено";
                }
            }
            if (updated == 0)
            {
                _holder.Values.Add(newWeather);
                status = "оригинал";
            }

            return $" ({status})статус температуры для {temp} на {dd.ToString()}";
        }

        [HttpDelete, Route("Delete/{dateFrom}/{dateTo}")]//пример записи даты (2022-02-02)
        public string DeleteData([FromRoute] DateTime dateFrom, DateTime dateTo)
        {
            string ReturnData = "";
            foreach (var Temper in _holder.Values)
            {
                if (dateFrom <= Temper.Date && dateTo >= Temper.Date)
                {
                    ReturnData += $"Температура {Temper.Date.ToString()} была {Temper.TemperatureC.ToString()} и удалена \n";

                }
            }
            _holder.Values.RemoveAll(x => x.Date >= dateFrom && x.Date <= dateTo);
            return ReturnData;
        }
        [HttpGet, Route("Load/{dateFrom}/{dateTo}")]//пример записи даты (2022-02-02)
        public string LoadData([FromRoute] DateTime dateFrom, DateTime dateTo)
        {
            string ReturnData = "";
            foreach (var Temper in _holder.Values)
            {
                if (dateFrom <= Temper.Date && dateTo >= Temper.Date)
                {
                    ReturnData += $"Температура для {Temper.Date.ToString()} это {Temper.TemperatureC.ToString()} \n";
                }
            }
            return ReturnData;
        }
    }
}