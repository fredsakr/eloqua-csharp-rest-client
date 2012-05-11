namespace Eloqua
{
    public class ApiException : System.Exception
    {
        private System.Exception _exception;

        public ApiException(System.Exception exception)
        {
            _exception = exception;
        }
    }
}
