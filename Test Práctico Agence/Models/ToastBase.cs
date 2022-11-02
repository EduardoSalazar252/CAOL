using Microsoft.AspNetCore.Components;
using Test_Práctico_Agence.Services;

namespace Test_Práctico_Agence.Models
{
    public class ToastBase : ComponentBase
    {
        [Inject] ToastService ToastService { get; set; }

        protected string Heading { get; set; }
        protected string Message { get; set; }
        protected bool IsVisible { get; set; }
        protected string BackgroundCssClass { get; set; }
        protected string IconCssClass { get; set; }

        protected override void OnInitialized()
        {
            ToastService.OnShow += ShowToast;
            ToastService.OnHide += HideToast;
        }

        private async void ShowToast(string message, ToastLevel level)
        {
            BuildToastSettings(level, message);
            IsVisible = true;
            await InvokeAsync(StateHasChanged);
        }

        private async void HideToast()
        {
            IsVisible = false;
            await InvokeAsync(StateHasChanged);
        }
        private void BuildToastSettings(ToastLevel level, string message)
        {
            switch (level)
            {
                case ToastLevel.Info:
                    BackgroundCssClass = "has-background-info";
                    IconCssClass = "information-outline";
                    Heading = "Info";
                    break;
                case ToastLevel.Success:
                    BackgroundCssClass = "has-background-success";
                    IconCssClass = "check-circle-outline";
                    Heading = "Success";
                    break;
                case ToastLevel.Warning:
                    BackgroundCssClass = "has-background-warning";
                    IconCssClass = "alert-circle-outline";
                    Heading = "Warning";
                    break;
                case ToastLevel.Error:
                    BackgroundCssClass = "has-background-danger";
                    IconCssClass = "alpha-x-circle-outline";
                    Heading = "Error";
                    break;
            }

            Message = message;
        }
    }
}
