﻿using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlims.DocumentManager.Manager.Interface
{
    public interface IAzureBlobService
    {
        Task<Azure.Response<BlobContentInfo>> UploadFiles(IFormFile files, string fileName);
        Task<List<BlobItem>> GetUploadedBlobs();
        byte[] GetFileFromAzure(string fileName);
    }
}
