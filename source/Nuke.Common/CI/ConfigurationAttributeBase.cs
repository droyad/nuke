// Copyright 2021 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using JetBrains.Annotations;
using Nuke.Common.Execution;
using Nuke.Common.IO;
using Nuke.Common.Utilities;
using static Nuke.Common.CI.BuildServerConfigurationGenerationAttributeBase;

namespace Nuke.Common.CI
{
    [PublicAPI]
    [AttributeUsage(AttributeTargets.Class)]
    public abstract class ConfigurationAttributeBase : Attribute, IConfigurationGenerator
    {
        public string DisplayName => HostType.Name + (string.IsNullOrEmpty(IdPostfix) ? string.Empty : $" ({IdPostfix})");
        public string HostName => HostType.Name;
        public string Id => HostName + (string.IsNullOrEmpty(IdPostfix) ? string.Empty : $"_{IdPostfix}");
        public virtual string IdPostfix => string.Empty;

        public bool AutoGenerate { get; set; } = true;
        public abstract Type HostType { get; }
        public abstract string ConfigurationFile { get; }
        public abstract IEnumerable<string> GeneratedFiles { get; }

        public abstract IEnumerable<string> RelevantTargetNames { get; }
        public abstract IEnumerable<string> IrrelevantTargetNames { get; }

        public abstract CustomFileWriter CreateWriter(StreamWriter streamWriter);
        public abstract ConfigurationEntity GetConfiguration(NukeBuild build, IReadOnlyCollection<ExecutableTarget> relevantTargets);

        protected virtual string BuildCmdPath =>
            NukeBuild.RootDirectory.GlobFiles("build.cmd", "*/build.cmd")
                .Select(x => NukeBuild.RootDirectory.GetUnixRelativePathTo(x))
                .FirstOrDefault().NotNull("BuildCmdPath != null");

        public void Generate(NukeBuild build, IReadOnlyCollection<ExecutableTarget> executableTargets)
        {
            var relevantTargets = RelevantTargetNames
                .SelectMany(x => ExecutionPlanner.GetExecutionPlan(executableTargets, new[] { x }))
                .Distinct()
                .Where(x => !IrrelevantTargetNames.Contains(x.Name)).ToList();
            var configuration = GetConfiguration(build, relevantTargets);

            using var stream = CreateStream();
            var writer = CreateWriter(stream);
            writer.WriteComment("------------------------------------------------------------------------------");
            writer.WriteComment("<auto-generated>");
            writer.WriteComment();
            writer.WriteComment("    This code was generated.");
            writer.WriteComment();
            writer.WriteComment("    - To turn off auto-generation set:");
            writer.WriteComment();
            writer.WriteComment($"        [{GetType().Name.TrimEnd(nameof(Attribute))} ({nameof(IConfigurationGenerator.AutoGenerate)} = false)]");
            writer.WriteComment();
            writer.WriteComment("    - To trigger manual generation invoke:");
            writer.WriteComment();
            writer.WriteComment($"        nuke --{ConfigurationParameterName} {Id} --host {HostName}");
            writer.WriteComment();
            writer.WriteComment("</auto-generated>");
            writer.WriteComment("------------------------------------------------------------------------------");
            writer.WriteLine();
            writer.Write(configuration.Write);
        }

        protected virtual StreamWriter CreateStream()
        {
            return new StreamWriter(File.Open(ConfigurationFile, FileMode.Create));
        }

        public virtual void SerializeState()
        {
        }
    }
}
