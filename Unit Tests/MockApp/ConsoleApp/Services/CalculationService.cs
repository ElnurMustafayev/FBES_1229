using ConsoleApp.Services.Base;

namespace ConsoleApp.Services;

public class CalculationService {
    private readonly INumberService numberService;

    public CalculationService(INumberService numberService)
    {
        this.numberService = numberService;
    }

    public int Calculate(int num) {
        var numberAsString = this.numberService.GetNumberAsString(num);
        return numberAsString.Length;
    }
}