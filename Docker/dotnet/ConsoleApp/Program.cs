/*
while (true) {
    Thread.Sleep(1000);

    var processEnvironmentVariables = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Process);

    foreach (var processEnvironmentVariable in processEnvironmentVariables)
    {
        System.Console.WriteLine(processEnvironmentVariable);
    }

    System.Console.WriteLine("* * * \n\n\n");
}
*/



// Создать универсальный образ, при создании контейнера которого 
// будет предоставлен следующий функционал: 
//   
//   заменa слов TICK и TACK (обязательные параметры)
//   задачa интервала таймера (по умолчанию 1 секунда)

var tickWord = Environment.GetEnvironmentVariable("TICK");
ArgumentNullException.ThrowIfNullOrEmpty(tickWord);

var tackWord = Environment.GetEnvironmentVariable("TACK");
ArgumentNullException.ThrowIfNullOrEmpty(tackWord);

int timerIntervalMs = 1000;

var timerIntervalStr = Environment.GetEnvironmentVariable("INTERVAL");
if(int.TryParse(timerIntervalStr, out int timerIntervalMsResult)) {
    timerIntervalMs = timerIntervalMsResult;
}

int counter = 0;
while (true)
{
    System.Console.WriteLine((counter++ % 2 == 1) ? tackWord : tickWord);
    Thread.Sleep(timerIntervalMs);
}