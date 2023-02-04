press windows key and type cmd
click on command prompt
cd "C:\Dev\github\Fifa22\Fifa22.WebService"
dotnet run => build and start service
ctrl+c => stop service

cd "C:\Dev\github\Fifa22\Fifa22.Tests"
dotnet test => run all test
dotnet test --filter "Fifa22.Tests.Fifa22CalculatorTest.CalculatorSum_Test" => run single test