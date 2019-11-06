
namespace Infomatica.Util
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using System.Drawing;
    using System.Drawing.Printing;

    public class ImpresionUtil
    {
        private Font printFont;
        private StreamReader streamToPrint;
        private String textImp;

        /// <summary>
        /// Captura la linea de impresion
        /// </summary>
        public String Print
        {
            get { return textImp; }
            set { textImp += value + Environment.NewLine; }
        }

        /// <summary>
        /// El evento PrintPage se genera para cada página que se va a imprimir.
        /// </summary>
        private void Pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            int count = 0;
            float leftMargin = 10;//ev.MarginBounds.Left;
            float topMargin = 10;//ev.MarginBounds.Top;
            String line = null;

            // Calculate the number of lines per page.
            float linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Iterate over the file, printing each line.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                float yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }

        /// <summary>
        /// Imprime texto en impresoras configuradas
        /// </summary>
        public void Imprimir(string Impresora)
        {
            try
            {
                streamToPrint = new StreamReader(GenerateStreamFromString(Print));
                try
                {
                    printFont = new Font("Courier New", 10);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler(Pd_PrintPage);
                    pd.PrinterSettings.PrinterName = "FinePrint";
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Convierte de un string a un Stream
        /// </summary>
        static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
