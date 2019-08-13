namespace Service.PDF
{
    public class PDFDocBuilder
    {
        private readonly IPDFBuilder builder;

        public PDFDocBuilder(IPDFBuilder builder) => this.builder = builder;

        public string BuildPDF() => builder.Build();
    }
}
