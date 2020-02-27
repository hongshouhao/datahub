// System.Web.Services.Protocols.Fx
using System;

internal class Fx
{
    internal static bool IsFatal(Exception e)
    {
        return e is OutOfMemoryException;
    }
}
