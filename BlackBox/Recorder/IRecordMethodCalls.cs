﻿using System.Reflection;

namespace BlackBox.Recorder
{
    public interface IRecordMethodCalls
    {
        void RecordEntry(object instance, MethodBase method, object[] parameters);
        void RecordExit(MethodBase method, object returnValue);
    }
}