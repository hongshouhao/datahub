using Elastic.Apm;
using Elastic.Apm.DiagnosticSource;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Geone.DataHub.Core.APM
{
    public class DbClientDiagnosticsSubscriber : IDiagnosticsSubscriber
    {
        public IDisposable Subscribe(IApmAgent components)
        {
            var retVal = new CompositeDisposable();
            var initializer = new DbClientDiagnosticInitializer(components);

            retVal.Add(initializer);

            retVal.Add(DiagnosticListener
                .AllListeners
                .Subscribe(initializer));

            return retVal;
        }
    }
}
