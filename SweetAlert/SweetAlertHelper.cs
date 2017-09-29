namespace SweetAlert
{
    public class SweetAlertHelper
    {
        public static string ShowMessage(string messageCaption, string messageContent, SweetAlertMessageType messageType)
        {
            return $"swal('{messageCaption}','{messageContent}','{messageType}');";
        }
    }

    public enum SweetAlertMessageType
    {
        warning, error, success, info
    }
}