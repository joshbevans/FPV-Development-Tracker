namespace FPVDevelopment.Components.Services
{
    public class ToastService
    {
        public event Action<string, string, int> OnShow;
        public event Action OnHide;
        public async Task ShowToast(string message, string type = "info", int dismissAfter = 3)
        {
            OnShow?.Invoke(message, type, dismissAfter);
        }
        public void HideToast()
        {
            OnHide?.Invoke();
        }
        public async Task ShowSuccess(string message, int dismissAfter = 3) => ShowToast(message, "success", dismissAfter);
        public async Task ShowError(string message, int dismissAfter = 3) => ShowToast(message, "failure", dismissAfter);
        public async Task ShowWarning(string message, int dismissAfter = 3) => ShowToast(message, "warning", dismissAfter);
        public async Task ShowInfo(string message, int dismissAfter = 3) => ShowToast(message, "info", dismissAfter);
        public async Task ShowAlert(string message, int dismissAfter = 3) => ShowToast(message, "alert", dismissAfter);
    }
}
