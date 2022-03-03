using System;
using System.Runtime.InteropServices;

namespace DuckDB.NET.Windows
{
    class WindowsBindNativeMethods : IBindNativeMethods
    {
        public DuckDBState DuckDBOpen(string path, out DuckDBDatabase database)
        {
            return NativeMethods.DuckDBOpen(path, out database);
        }

        public void DuckDBClose(in IntPtr database)
        {
            NativeMethods.DuckDBClose(in database);
        }

        public DuckDBState DuckDBConnect(DuckDBDatabase database, out DuckDBNativeConnection connection)
        {
            return NativeMethods.DuckDBConnect(database, out connection);
        }

        public void DuckDBDisconnect(in IntPtr connection)
        {
            NativeMethods.DuckDBDisconnect(in connection);
        }

        public DuckDBState DuckDBQuery(DuckDBNativeConnection connection, string query, out DuckDBResult result)
        {
            return NativeMethods.DuckDBQuery(connection, query, out result);
        }

        public DuckDBState DuckDBQuery(DuckDBNativeConnection connection, SafeUnmanagedMemoryHandle query, out DuckDBResult result)
        {
            return NativeMethods.DuckDBQuery(connection, query, out result);
        }

        public void DuckDBDestroyResult(in DuckDBResult result)
        {
            NativeMethods.DuckDBDestroyResult(in result);
        }

        public string DuckDBColumnName(DuckDBResult result, long col)
        {
            return NativeMethods.DuckDBColumnName(result, col);
        }

        public bool DuckDBValueBoolean(DuckDBResult result, long col, long row)
        {
            return NativeMethods.DuckDBValueBoolean(result, col, row);
        }

        public sbyte DuckDBValueInt8(DuckDBResult result, long col, long row)
        {
            return NativeMethods.DuckDBValueInt8(result, col, row);
        }

        public short DuckDBValueInt16(DuckDBResult result, long col, long row)
        {
            return NativeMethods.DuckDBValueInt16(result, col, row);
        }

        public int DuckDBValueInt32(DuckDBResult result, long col, long row)
        {
            return NativeMethods.DuckDBValueInt32(result, col, row);
        }

        public long DuckDBValueInt64(DuckDBResult result, long col, long row)
        {
            return NativeMethods.DuckDBValueInt64(result, col, row);
        }

        public float DuckDBValueFloat(DuckDBResult result, long col, long row)
        {
            return NativeMethods.DuckDBValueFloat(result, col, row);
        }

        public double DuckDBValueDouble(DuckDBResult result, long col, long row)
        {
            return NativeMethods.DuckDBValueDouble(result, col, row);
        }
        
        public IntPtr DuckDBValueVarchar(DuckDBResult result, long col, long row)
        {
            return NativeMethods.DuckDBValueVarchar(result, col, row);
        }

        public DuckDBState DuckDBPrepare(DuckDBNativeConnection connection, string query, out DuckDBPreparedStatement preparedStatement)
        {
            return NativeMethods.DuckDBPrepare(connection, query, out preparedStatement);
        }

        public DuckDBState DuckDBParams(DuckDBPreparedStatement preparedStatement, out long numberOfParams)
        {
            return NativeMethods.DuckDBParams(preparedStatement, out numberOfParams);
        }

        public DuckDBState DuckDBBindBoolean(DuckDBPreparedStatement preparedStatement, long index, bool val)
        {
            return NativeMethods.DuckDBBindBoolean(preparedStatement, index, val);
        }

        public DuckDBState DuckDBBindInt8(DuckDBPreparedStatement preparedStatement, long index, sbyte val)
        {
            return NativeMethods.DuckDBBindInt8(preparedStatement, index, val);
        }

        public DuckDBState DuckDBBindInt16(DuckDBPreparedStatement preparedStatement, long index, short val)
        {
            return NativeMethods.DuckDBBindInt16(preparedStatement, index, val);
        }

        public DuckDBState DuckDBBindInt32(DuckDBPreparedStatement preparedStatement, long index, int val)
        {
            return NativeMethods.DuckDBBindInt32(preparedStatement, index, val);
        }

        public DuckDBState DuckDBBindInt64(DuckDBPreparedStatement preparedStatement, long index, long val)
        {
            return NativeMethods.DuckDBBindInt64(preparedStatement, index, val);
        }

        public DuckDBState DuckDBBindFloat(DuckDBPreparedStatement preparedStatement, long index, float val)
        {
            return NativeMethods.DuckDBBindFloat(preparedStatement, index, val);
        }

        public DuckDBState DuckDBBindDouble(DuckDBPreparedStatement preparedStatement, long index, double val)
        {
            return NativeMethods.DuckDBBindDouble(preparedStatement, index, val);
        }

        public DuckDBState DuckDBBindVarchar(DuckDBPreparedStatement preparedStatement, long index, string val)
        {
            return NativeMethods.DuckDBBindVarchar(preparedStatement, index, val);
        }

        public DuckDBState DuckDBBindNull(DuckDBPreparedStatement preparedStatement, long index)
        {
            return NativeMethods.DuckDBBindNull(preparedStatement, index);
        }

        public DuckDBState DuckDBExecutePrepared(DuckDBPreparedStatement preparedStatement, out DuckDBResult result)
        {
            return NativeMethods.DuckDBExecutePrepared(preparedStatement, out result);
        }

        public void DuckDBDestroyPrepare(in IntPtr preparedStatement)
        {
            NativeMethods.DuckDBDestroyPrepare(in preparedStatement);
        }

        /// <inheritdoc />
        public void DuckDBFree(IntPtr ptr)
        {
            NativeMethods.DuckDBFree(ptr);
        }

        public DuckDBState DuckDBAppenderDestroy(in IntPtr handle)
        {
            return NativeMethods.DuckDBAppenderDestroy(in handle);
        }

        public DuckDBState DuckDBAppenderCreate(DuckDBNativeConnection connection, string schema, string table, out DuckDBAppender appender)
        {
            return NativeMethods.DuckDBAppenderCreate(connection, schema, table, out appender);
        }

        public DuckDBState DuckDBAppenderBeginRow(DuckDBAppender appender)
        {
            return NativeMethods.DuckDBAppenderBeginRow(appender);
        }

        public DuckDBState DuckDBAppendVarChar(DuckDBAppender appender, string value)
        {
            return NativeMethods.DuckDBAppendVarChar(appender, value);
        }

        public DuckDBState DuckDBAppendDouble(DuckDBAppender appender, double value)
        {
            return NativeMethods.DuckDBAppendDouble(appender, value);
        }

        public DuckDBState DuckDBAppenderEndRow(DuckDBAppender appender)
        {
            return NativeMethods.DuckDBAppenderEndRow(appender);
        }

        public DuckDBState DuckDBAppendVarChar(DuckDBAppender appender, SafeUnmanagedMemoryHandle value)
        {
            return NativeMethods.DuckDBAppendVarChar(appender, value);
        }
    }

    public class NativeMethods
    {
        private const string DuckDbLibrary = "duckdb.dll";

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_open")]
        public static extern DuckDBState DuckDBOpen(string path, out DuckDBDatabase database);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_close")]
        public static extern void DuckDBClose(in IntPtr database);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_connect")]
        public static extern DuckDBState DuckDBConnect(DuckDBDatabase database, out DuckDBNativeConnection connection);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_disconnect")]
        public static extern void DuckDBDisconnect(in IntPtr connection);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_query")]
        public static extern DuckDBState DuckDBQuery(DuckDBNativeConnection connection, string query, out DuckDBResult result);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_query")]
        public static extern DuckDBState DuckDBQuery(DuckDBNativeConnection connection, SafeUnmanagedMemoryHandle query, out DuckDBResult result);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_destroy_result")]
        public static extern void DuckDBDestroyResult(in DuckDBResult result);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_column_name")]
        public static extern string DuckDBColumnName(DuckDBResult result, long col);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_value_boolean")]
        public static extern bool DuckDBValueBoolean(DuckDBResult result, long col, long row);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_value_int8")]
        public static extern sbyte DuckDBValueInt8(DuckDBResult result, long col, long row);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_value_int16")]
        public static extern short DuckDBValueInt16(DuckDBResult result, long col, long row);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_value_int32")]
        public static extern int DuckDBValueInt32(DuckDBResult result, long col, long row);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_value_int64")]
        public static extern long DuckDBValueInt64(DuckDBResult result, long col, long row);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_value_float")]
        public static extern float DuckDBValueFloat(DuckDBResult result, long col, long row);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_value_double")]
        public static extern double DuckDBValueDouble(DuckDBResult result, long col, long row);
        
        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_value_varchar")]
        public static extern IntPtr DuckDBValueVarchar(DuckDBResult result, long col, long row);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_prepare")]
        public static extern DuckDBState DuckDBPrepare(DuckDBNativeConnection connection, string query, out DuckDBPreparedStatement preparedStatement);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_nparams")]
        public static extern DuckDBState DuckDBParams(DuckDBPreparedStatement preparedStatement, out long numberOfParams);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_bind_boolean")]
        public static extern DuckDBState DuckDBBindBoolean(DuckDBPreparedStatement preparedStatement, long index, bool val);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_bind_int8")]
        public static extern DuckDBState DuckDBBindInt8(DuckDBPreparedStatement preparedStatement, long index, sbyte val);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_bind_int16")]
        public static extern DuckDBState DuckDBBindInt16(DuckDBPreparedStatement preparedStatement, long index, short val);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_bind_int32")]
        public static extern DuckDBState DuckDBBindInt32(DuckDBPreparedStatement preparedStatement, long index, int val);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_bind_int64")]
        public static extern DuckDBState DuckDBBindInt64(DuckDBPreparedStatement preparedStatement, long index, long val);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_bind_float")]
        public static extern DuckDBState DuckDBBindFloat(DuckDBPreparedStatement preparedStatement, long index, float val);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_bind_double")]
        public static extern DuckDBState DuckDBBindDouble(DuckDBPreparedStatement preparedStatement, long index, double val);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_bind_varchar")]
        public static extern DuckDBState DuckDBBindVarchar(DuckDBPreparedStatement preparedStatement, long index, string val);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_bind_null")]
        public static extern DuckDBState DuckDBBindNull(DuckDBPreparedStatement preparedStatement, long index);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_execute_prepared")]
        public static extern DuckDBState DuckDBExecutePrepared(DuckDBPreparedStatement preparedStatement, out DuckDBResult result);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_destroy_prepare")]
        public static extern void DuckDBDestroyPrepare(in IntPtr preparedStatement);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_free")]
        public static extern void DuckDBFree(IntPtr ptr);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_appender_create")]
        public static extern DuckDBState DuckDBAppenderCreate(DuckDBNativeConnection connection, string schema, string table, out DuckDBAppender appender);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_appender_error")]
        public static extern string DuckDBAppenderError(DuckDBAppender appender);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_appender_flush")]
        public static extern DuckDBState DuckDBAppenderFlush(DuckDBAppender appender);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_appender_close")]
        public static extern DuckDBState DuckDBAppenderClose(DuckDBAppender appender);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_appender_destroy")]
        public static extern DuckDBState DuckDBAppenderDestroy(in IntPtr appender);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_appender_begin_row")]
        public static extern DuckDBState DuckDBAppenderBeginRow(DuckDBAppender appender);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_appender_end_row")]
        public static extern DuckDBState DuckDBAppenderEndRow(DuckDBAppender appender);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_bool")]
        public static extern DuckDBState DuckDBAppendBool(DuckDBAppender appender, bool value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_int8")]
        public static extern DuckDBState DuckDBAppendInt8(DuckDBAppender appender, sbyte value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_int16")]
        public static extern DuckDBState DuckDBAppendInt16(DuckDBAppender appender, short value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_int32")]
        public static extern DuckDBState DuckDBAppendInt32(DuckDBAppender appender, int value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_int64")]
        public static extern DuckDBState DuckDBAppendInt64(DuckDBAppender appender, long value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_uint8")]
        public static extern DuckDBState DuckDBAppendUInt8(DuckDBAppender appender, byte value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_uint16")]
        public static extern DuckDBState DuckDBAppendUInt16(DuckDBAppender appender, ushort value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_uint32")]
        public static extern DuckDBState DuckDBAppendUInt32(DuckDBAppender appender, uint value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_uint64")]
        public static extern DuckDBState DuckDBAppendUInt64(DuckDBAppender appender, ulong value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_float")]
        public static extern DuckDBState DuckDBAppendFloat(DuckDBAppender appender, float value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_double")]
        public static extern DuckDBState DuckDBAppendDouble(DuckDBAppender appender, double value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_date")]
        public static extern DuckDBState DuckDBAppendDate(DuckDBAppender appender, DuckDBDate value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_time")]
        public static extern DuckDBState DuckDBAppendTime(DuckDBAppender appender, DuckDBTime value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_timestamp")]
        public static extern DuckDBState DuckDBAppendTimestamp(DuckDBAppender appender, DuckDBTimestamp value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_varchar")]
        public static extern DuckDBState DuckDBAppendVarChar(DuckDBAppender appender, string value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_varchar")]
        public static extern DuckDBState DuckDBAppendVarChar(DuckDBAppender appender, SafeUnmanagedMemoryHandle value);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_append_null")]
        public static extern DuckDBState DuckDBAppendNull(DuckDBAppender appender);

        //TODO:
        //duckdb_state duckdb_append_blob(duckdb_appender appender, const void* data, idx_t length);
        //duckdb_state duckdb_append_varchar_length(duckdb_appender appender, const char* val, idx_t length);
        //duckdb_state duckdb_append_interval(duckdb_appender appender, duckdb_interval value);
        //duckdb_state duckdb_append_hugeint(duckdb_appender appender, duckdb_hugeint value);
    }
}
