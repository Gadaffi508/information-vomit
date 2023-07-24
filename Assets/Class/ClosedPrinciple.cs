using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosedPrinciple : MonoBehaviour
{
    interface ILogger
    {
        bool log(string value);
    }

    class XmLog : ILogger
    {
        public bool log(string value)
        {
            return true;
        }
    }

    class DbLog : ILogger
    {
        public bool log(string value)
        {
            return true;
        }
    }

    class JsonLog : ILogger
    {
        public bool log(string value)
        {
            return true;
        }
    }

    class Logger
    {
        private readonly ILogger _logger;

        public Logger(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string value)
        {
            _logger.log(value);
        }
    }
}
