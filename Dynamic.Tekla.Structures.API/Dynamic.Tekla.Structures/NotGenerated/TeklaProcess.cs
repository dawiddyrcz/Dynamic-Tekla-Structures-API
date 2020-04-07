/*Copyright (C) Dawid Dyrcz 2020
* This program is free software. You may use, distribute and modify 
* this code under the terms of the LGPL3 license. This program is distributed 
* in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
* without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
* For more details see GNU LESSER GENERAL PUBLIC LICENSE Version 3, 29 June 2007
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Dynamic.Tekla.Structures
{
    public static class TeklaProcess
    {
        private const string TEKLA_PROCESS_NAME = "TeklaStructures";

        /// <summary>Holds TypeFull name in c# style with assembly where type should be</summary>
        internal static Dictionary<string, Assembly> APIAssemblies { get; private set; } = new Dictionary<string, Assembly>();

        public static string BinPath { get; private set; } = string.Empty;
        public static TeklaFileVersion TeklaFileVersion { get; private set; }

        public static Process teklaProcess { get; private set; }

        public static bool IsTeklaRunning()
        {
            if (teklaProcess is null)
            {
                return GetTeklaProcess();
            }
            else
            {
                if (teklaProcess.HasExited)
                {
                    return GetTeklaProcess();
                }
                else return true;
            }
        }

        private static bool GetTeklaProcess()
        {
            var teklaProcesses = Process.GetProcessesByName(TEKLA_PROCESS_NAME);

            if (teklaProcesses.Length != 0)
            {
                teklaProcess = teklaProcesses[0];

                var teklaFilePath = GetProcessFilename(teklaProcess);
                BinPath = Path.GetDirectoryName(teklaFilePath);
                TeklaFileVersion = GetFileVersion(teklaFilePath);
                APIAssemblies = GetAssemblies();
                return true;
            }
            return false;
        }


        private static string GetProcessFilename(Process process)
        {
            return process.MainModule.FileName; //TODO for 32 bits
        }

        private static TeklaFileVersion GetFileVersion(string teklaFilePath)
        {
            var fvinfo = FileVersionInfo.GetVersionInfo(teklaFilePath);
            var sb = new StringBuilder();

            return new TeklaFileVersion
            {
                Major = fvinfo.FileMajorPart,
                Minor = fvinfo.FileMinorPart,
                Build = fvinfo.FileBuildPart,
                Build2 = fvinfo.FilePrivatePart,
            };
        }

        private static Dictionary<string, Assembly> GetAssemblies()
        {
            var output = new Dictionary<string, Assembly>();

            foreach (var dllPath in GetDllPathes(BinPath))
            {
                var assembly = Assembly.LoadFrom(dllPath);

                foreach (var tsType in assembly.GetTypes().Where(t => t.IsPublic))
                {
                    var typeFullName = TypeFullName.GetTypeFullName(tsType);
                    output.Add(typeFullName, assembly);

                    foreach (var nestedType in NestedTypes(tsType))
                    {
                        var nestedTypeFullName = TypeFullName.GetTypeFullName(nestedType);
                        output.Add(nestedTypeFullName, assembly);
                    }
                }
            }

            return output;
        }

        private static List<Type> NestedTypes(Type type)
        {
            var output = new List<Type>();

            foreach (var nestedType in type.GetNestedTypes())
            {
                output.Add(nestedType);
                output.AddRange(NestedTypes(nestedType));
            }
            return output;
        }

        private static List<string> GetDllPathes(string binPath)
        {
            return new List<string>()
            {
                Path.Combine(binPath, "plugins", "Tekla.Structures.dll"),
                Path.Combine(binPath, "plugins",  "Tekla.Structures.Model.dll"),
                Path.Combine(binPath, "plugins",  "Tekla.Structures.Datatype.dll"),
                Path.Combine(binPath, "plugins",  "Tekla.Structures.Drawing.dll"),
                Path.Combine(binPath, "applications", "Tekla", "Common", "Tekla.Application.Library.dll"),
                Path.Combine(binPath, "dialogs", "Tekla.Structures.Dialog.dll"),
            };

        }
    }
}
