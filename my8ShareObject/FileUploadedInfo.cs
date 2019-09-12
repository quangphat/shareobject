using System;
using System.Collections.Generic;
using System.Text;

namespace my8ShareObject
{
    public class FileUploadedInfo
    {
        public FileUploadedInfo(string name, string url, string extension, long size)
        {
            this.Name = name;
            this.Url = url;
            this.Ext = extension;
            this.Size = size;
        }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Ext { get; set; }
        public long Size { get; set; }
    }
}
