using System;
using System.Collections.Generic;
using System.Text;

namespace GCMechanism
{
    public class FileGenerator : IDisposable
    {
        public FileStream FileStream { get; set; }
        //dosyayı oluşturup, verinizi yazdınız.

        //destructor gibi Low-level bir işlem yerine....
        //~FileGenerator() 
        //{
        //    FileStream.Close();
        //    FileStream.Dispose();
        //}

        //OOP paradigmasına uygun bir yaklaşım:
        public void Dispose()
        {
            FileStream.Close();
            FileStream.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}
