while (true) {
    Thread.Sleep(1000);

    var processEnvironmentVariables = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Process);

    foreach (var processEnvironmentVariable in processEnvironmentVariables)
    {
        System.Console.WriteLine(processEnvironmentVariable);
    }

    System.Console.WriteLine("* * * \n\n\n");
}