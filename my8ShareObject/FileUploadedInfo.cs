
public class FileUploadedInfo
{
    public FileUploadedInfo(string name, string url, string extension, long size, string folder)
    {
        this.Name = name;
        this.Url = url;
        this.Ext = extension;
        this.Size = size;
        this.Folder = folder;
    }
    public string Name { get; set; }
    public string Url { get; set; }
    public string Ext { get; set; }
    public long Size { get; set; }
    public string Folder { get; set; }
}

