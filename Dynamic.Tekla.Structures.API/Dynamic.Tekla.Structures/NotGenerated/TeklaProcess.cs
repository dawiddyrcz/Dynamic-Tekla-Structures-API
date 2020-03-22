/*
*Copyright (C) Dawid Dyrcz 2020 - All rights reserved
*/

using System.Diagnostics;
using System.IO;
using System.Text;

namespace Dynamic.Tekla.Structures
{
    internal class TeklaProcess
    {
        private const string TEKLA_PROCESS_NAME = "TeklaStructures";

        private bool isTeklaRunning = false;
        private Process teklaProcess;
        private readonly int teklaProcessesCount;

        public TeklaProcess()
        {
            var teklaProcesses = Process.GetProcessesByName(TEKLA_PROCESS_NAME);
            teklaProcessesCount = teklaProcesses.Length;
            this.teklaProcess = GetFirstActiveTeklaProcess(teklaProcesses);
        }

        public bool IsTeklaRunning()
        {
            return isTeklaRunning;
        }

        public TeklaFileVersion GetTeklaStructuresVersion()
        {
            if (isTeklaRunning)
            {
                string teklaFilePath = GetFilePathOfTeklaProcess();
                var fileVersion = GetFileVersion(teklaFilePath);
                return fileVersion;
            }
            else
            {
                return new TeklaFileVersion();
            }
        }

        public string GetTeklaProcessDirectoryPath()
        {
            if (isTeklaRunning) return Path.GetDirectoryName(GetFilePathOfTeklaProcess());
            else return "";
        }

        public int GetTeklaProcessesCount()
        {
            return teklaProcessesCount;
        }

        private string GetFilePathOfTeklaProcess()
        {
            return teklaProcess.MainModule.FileName; //TODO for 32 bits
        }

        private TeklaFileVersion GetFileVersion(string teklaFilePath)
        {
            var fvinfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(teklaFilePath);
            var sb = new StringBuilder();
            var teklaFileVersion = new TeklaFileVersion
            {
                Major = fvinfo.FileMajorPart,
                Minor = fvinfo.FileMinorPart,
                Build = fvinfo.FileBuildPart,
                Build2 = fvinfo.FilePrivatePart,
            };
            return teklaFileVersion;
        }

        private Process GetFirstActiveTeklaProcess(Process[] teklaProcesses)
        {
            if (teklaProcesses.Length == 0)
            {
                isTeklaRunning = false;
                return null;
            }
            else
            {
                isTeklaRunning = true;
                return teklaProcesses[0];
            }
        }
    }
}
