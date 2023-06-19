using System.Diagnostics;
using System.Collections.ObjectModel;

//Process.Start("calc.exe");
//Process.Start("notepad.exe");
//Process.Start("mspaint.exe");
//Process.Start("dotnet.exe");
//Process.Start("ping.exe");
//Process.Start("notepad.exe", "test.txt");
//Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", @"https://logbook.itstep.org/");







//var processStartInfo = new ProcessStartInfo() {
//    FileName = @"ping",
//    Arguments = @"8.8.8.8",
//};

//Process process1 = Process.Start(processStartInfo);

//Process process2 = new Process() {
//    StartInfo = processStartInfo,
//};
//process2.Start();







//const string appName = "mspaint";
//Process process = new Process() {
//    StartInfo = new ProcessStartInfo(appName),
//    EnableRaisingEvents = true,
//};

//process.Exited += (sender, e) => {
//    Console.WriteLine($"{appName} end");
//};

//Console.WriteLine($"{appName} start");
//process.Start();
//process.WaitForExit();

//Console.WriteLine($"Application '{appName}' exit with code: {process.ExitCode}");





//var process = Process.GetCurrentProcess();

//process.PriorityClass = ProcessPriorityClass.High;

//Thread.Sleep(100000);

//Console.WriteLine(process);


//var processes = Process.GetProcesses();

//foreach (var process in processes) {
//    try {
//        Console.WriteLine();
//        Console.Write($"{process.Id} - ");
//        Console.Write($"{process.ProcessName} - ");
//        Console.Write($"{process.PriorityClass} - ");
//        Console.Write($"{process.MachineName}");
//    }
//    catch { }
//}

//var result = Process.GetProcesses()
//    .First(proc => proc.ProcessName.Contains("devenv"));

////Console.WriteLine(result.PriorityClass);
//foreach (var item in result.Modules) {
//    Console.WriteLine(item);
//}




//foreach (var proc in Process.GetProcesses()) {
//    Console.WriteLine($"{proc.Id}: {proc.ProcessName}");
//}

//const int nodepadProcessId = 4836;
//var nodepadProcess = Process.GetProcessById(nodepadProcessId);

//nodepadProcess.Kill();
//Console.WriteLine();


//Process.GetProcesses().First(proc => proc.ProcessName.Contains("devenv")).Kill();

//Process.GetCurrentProcess().Kill();