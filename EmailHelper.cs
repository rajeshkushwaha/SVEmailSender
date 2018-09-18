using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SVEmailSender
{
    class EmailHelper: IDisposable
    {
        bool disposed = false;
        public string fromemail { get; set; }
        public string password { get; set; }
        public string smtpaddress { get; set; }
        public int port { get; set; }
        public bool isssl { get; set; }
        public string toemail { get; set; }
        public string body { get; set; }
        public string subject { get; set; }

        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
            }

            disposed = true;
        }
    }
}
