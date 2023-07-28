using FluentFTP;

FtpClient ftpClient = new FtpClient();

ftpClient.Host = "pannekake.samfundet.no";
ftpClient.Connect();



//string remoteFilePath = "/scene.org/demos/compilations/demodulate/pointbreak.mp3";
//var remoteFileInfo = new FileInfo(remoteFilePath);

//string localFilePath = $"downloads/{remoteFileInfo.Name}";

//var status = ftpClient.DownloadFile(localFilePath, remoteFilePath);

//Console.WriteLine($"Status: {status}");



var files = ftpClient.GetNameListing("/scene.org/demos/compilations/demodulate/");

foreach (var file in files) {
    Console.WriteLine(file);
}