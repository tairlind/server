using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace SimpleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private static List<Message> messages = new List<Message>();
        private static int nextId = 1;//

        [HttpGet]
        public ActionResult<IEnumerable<Message>> Get()
        {
            return Ok(messages);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Message message)
        {
            message.Id = nextId++;//
            message.����� = DateTime.Now;//
            messages.Add(message);
            return Ok();
        }
    }

    public class Message
    {
        public int Id { get; set; }
        public string ������������ { get; set; }
        public string ����� { get; set; }
        public DateTime ����� { get; set; }
    }
}
