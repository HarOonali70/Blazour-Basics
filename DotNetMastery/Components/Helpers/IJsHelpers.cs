using Microsoft.JSInterop;

namespace DotNetMastery.wwwroot.Helpers
{
    public static class IJsHelpers
    {
        public static async Task ToasterSuccess(this IJSRuntime jsRunctime, string message) 
        {
            await jsRunctime.InvokeVoidAsync("showToaster", "success", message);
        }
        public static async Task ToasterError(this IJSRuntime jsRunctime, string message)
        {
            await jsRunctime.InvokeVoidAsync("showToaster", "error", message);
        }
    }
}
