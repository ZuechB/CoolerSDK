using CoolerSDK;

Console.WriteLine("Request API");

var coolerService = new CoolerService();
var response = await coolerService.RequestFootprint("API Key", new CoolerSDK.Models.ProductFootprintItem()
{

});

if (response.httpStatusCode == System.Net.HttpStatusCode.Created)
{
    var item = response.Content.items.FirstOrDefault();

    Console.WriteLine(item.footprint.carbonFootprintSavings + " co2e");
}