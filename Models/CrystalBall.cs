using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrystalBallDemo.Models
{
    public class CrystalBall
    {
        public string getResponse()
        {
            string[] responses = { "A rolling stone gathers no moss", "another response", "one more response" };
            Random randomNum = new Random();
            var num = randomNum.Next(0, responses.Length);
            return responses[num];
        }
    }
}