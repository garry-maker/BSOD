using System;
using System.Runtime.InteropServices;

class Program
{
    [DllImport("ntdll.dll")]
    static extern uint RtlAdjustPrivilege(
        int Privilege,
        bool Enable,
        bool CurrentThread,
        out bool Enabled
    );

    [DllImport("ntdll.dll")]
    static extern uint NtRaiseHardError(
        uint ErrorStatus,
        uint NumberOfParameters,
        uint UnicodeStringParameterMask,
        IntPtr Parameters,
        uint ValidResponseOption,
        out uint Response
    );

    static void Main()
    {
        bool enabled;
        uint response;


        RtlAdjustPrivilege(19, true, false, out enabled);


        NtRaiseHardError(0xC0000022, 0, 0, IntPtr.Zero, 6, out response);
    }
}
