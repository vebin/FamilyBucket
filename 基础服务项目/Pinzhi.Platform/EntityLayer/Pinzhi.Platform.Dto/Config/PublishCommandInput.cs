﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pinzhi.Platform.Dto.Config
{
    public class PublishCommandInput
    {
        public string ProjectName { set; get; }
        public string CommandType { set; get; }
        public string CommandText { set; get; }
    }
}
