﻿using SangoUtils_Server.Core;

namespace SangoUtils_Server.IOCP
{
    public class IOCPConfig : BaseConfig
    {
        public const int ServerMaxConnectCount = 10000;
        public const int ServerBackLogCount = 100;
        public const int ServerBufferCount = 2048;
    }
}
