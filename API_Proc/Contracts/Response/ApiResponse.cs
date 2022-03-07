using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Proc.Contracts.Response
{
    public class ApiResponse
    {
        public int status { get; set; }
        public string error { get; set; }
        public string message { get; set; }
        public dynamic data { get; set; }
        public string token { get; set; }
    }
}
