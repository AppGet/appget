﻿using AppGet.HostSystem;
using AppGet.Manifests;
using AppGet.Processes;
using NLog;

namespace AppGet.Installers.Nsis
{
    public class NsisWhisperer : InstallerWhispererBase
    {
        public NsisWhisperer(IProcessController processController, IPathResolver pathResolver, Logger logger)
            : base(processController, pathResolver, logger)
        {

        }

        protected override InstallMethodTypes InstallMethod => InstallMethodTypes.NSIS;

        protected override bool HasLogs => false;

        protected override string InteractiveArgs => "";
        protected override string PassiveArgs => null;
        protected override string SilentArgs => "/S";
    }
}
