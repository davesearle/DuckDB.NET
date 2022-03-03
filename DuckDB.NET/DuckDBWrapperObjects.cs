using System;
using System.Runtime.InteropServices;

namespace DuckDB.NET
{
    public class DuckDBDatabase : SafeHandle
    {
        public DuckDBDatabase() : base(IntPtr.Zero, true)
        {
        }

        protected override bool ReleaseHandle()
        {
            PlatformIndependentBindings.NativeMethods.DuckDBClose(in handle);
            return true;
        }

        public override bool IsInvalid => handle == IntPtr.Zero;
    }

    public class DuckDBNativeConnection : SafeHandle
    {
        public DuckDBNativeConnection() : base(IntPtr.Zero, true)
        {
        }

        protected override bool ReleaseHandle()
        {
            PlatformIndependentBindings.NativeMethods.DuckDBDisconnect(in handle);
            return true;
        }

        public override bool IsInvalid => handle == IntPtr.Zero;
    }

    public class DuckDBPreparedStatement : SafeHandle
    {
        public DuckDBPreparedStatement() : base(IntPtr.Zero, true)
        {
        }

        protected override bool ReleaseHandle()
        {
            PlatformIndependentBindings.NativeMethods.DuckDBDestroyPrepare(in handle);
            return true;
        }

        public override bool IsInvalid => handle == IntPtr.Zero;
    }

    public class DuckDBAppender : SafeHandle
    {
        public DuckDBAppender() : base(IntPtr.Zero, true)
        {
        }

        protected override bool ReleaseHandle()
        {
            PlatformIndependentBindings.NativeMethods.DuckDBAppenderDestroy(in handle);
            return true;
        }

        public override bool IsInvalid => handle == IntPtr.Zero;
    }
}