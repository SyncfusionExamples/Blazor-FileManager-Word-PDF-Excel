﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SfFileService.FileManager.Base;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Net.Http.Headers;
using Syncfusion.Blazor.FileManager.Base;

namespace Syncfusion.Blazor.FileManager.Base
{
    public interface FTPFileProviderBase : FileProviderBase
    {
        void SetFTPConnection(string hostName, string userName, string password);
    }

}
