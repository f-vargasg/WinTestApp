using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountToReprocess
{
    public class CuentasAReprocesar
    {
//        List<ClteCtaBe> lstCtaCte;

        public List<ClteCtaBe> LstCtaCte  { get; set; }

        public CuentasAReprocesar()
        {
            this.LstCtaCte = new List<ClteCtaBe>();
        }

         public CuentasAReprocesar(string fname)
        {
            ProcessFile(fname);
        }

        private void ProcessFile(string fname)
        {
            ClteCtaBe ctaClteBe;
            int ind;
            int ind1;

            this.LstCtaCte = new List<ClteCtaBe>();
            try
            {

                // Example #2
                // Read each line of the file into a string array. Each element
                // of the array is one line of the file.
                string[] lines = File.ReadAllLines(fname);

                // Display the file contents by using a foreach loop.
                Console.WriteLine("Contents of WriteLines2.txt = ");
                foreach (string line in lines)
                {
                    // Use a tab to indent each line of the file.
                    ind = line.IndexOf('(');
                    if (ind >= 0)
                    {
                        ind1 = line.IndexOf(')');
                        if (ind1 > 0)
                        {
                            string scrap = line.Substring(ind + 1, ind1 - ind - 1);
                            string[] cteCta = scrap.Split(',');

                            ctaClteBe = new ClteCtaBe();
                            ctaClteBe.CodClienteN = Convert.ToInt32(cteCta[0]);
                            ctaClteBe.CodCuentaN = Convert.ToInt32(cteCta[1]);
                            this.LstCtaCte.Add(ctaClteBe);
                        }
                    }

                    // Console.WriteLine("\t" + line);
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
