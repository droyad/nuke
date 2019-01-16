// Copyright 2018 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Nuke.Common.Execution
{
    /// <summary>
    /// Validates all requirements for targets that are part of the execution plan.
    /// </summary>
    internal static class RequirementService
    {
        public static void ValidateRequirements(NukeBuild build)
        {
            foreach (var target in build.ExecutionPlan)
            foreach (var requirement in target.Requirements)
            {
                if (requirement is Expression<Func<bool>> boolExpression)
                {
                    ControlFlow.Assert(boolExpression.Compile().Invoke(), $"Target '{target.Name}' requires '{requirement.Body}'.");
                }
                else
                {
                    var member = requirement.GetMemberInfo();
                    switch (member)
                    {
                       case FieldInfo field:
                           ControlFlow.Assert(
                               field.GetValue(build) != null,
                               $"Target '{target.Name}' requires that field '{field.Name}' must be not null.");
                           break;
                       case PropertyInfo property:
                           ControlFlow.Assert(
                               property.GetValue(build) != null,
                               $"Target '{target.Name}' requires that property '{property.Name}' must be not null.");
                           break;
                       default:
                           throw new Exception($"Member type {member} not supported.");
                    }
                }
            }
        }
    }
}
