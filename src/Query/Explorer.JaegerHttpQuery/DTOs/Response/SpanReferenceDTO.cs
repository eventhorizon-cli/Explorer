namespace Explorer.JaegerHttpQuery.DTOs.Response
{
    public class SpanReferenceDTO
    {
        public string TraceID { get; set; }

        public string SpanID { get; set; }

        public string RefType { get; set; }
    }
}