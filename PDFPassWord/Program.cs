using iTextSharp;
using iTextSharp.text.pdf;

namespace PDFPassWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\user\Desktop\pdfPassWord\CUSTOMER_LOG.pdf";
            string OutputFile = @"C:\Users\user\Desktop\GenerateFile\Test_enc.pdf";

            using (Stream input = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (Stream output = new FileStream(OutputFile, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfReader reader = new PdfReader(input);
                    PdfEncryptor.Encrypt(reader, output, true, null, "55555", PdfWriter.ALLOW_SCREENREADERS);
                }
            }
        }
    }
}