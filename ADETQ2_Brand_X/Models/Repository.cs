using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADETQ2_Brand_X.Models
{
    public static class Repository
    {
        private static List<list> responses = new List<list>();
        public static IEnumerable<list> Response => responses;
        public static void addResponse(list response)
        {
            responses.Add(response);
        }
    }
}
