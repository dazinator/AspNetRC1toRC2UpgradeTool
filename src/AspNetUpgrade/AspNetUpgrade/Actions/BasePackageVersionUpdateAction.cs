using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace AspNetUpgrade.Actions
{

    public abstract class BaseDependenciesUpdateAction : IAction
    {

        private JToken _backup;

        private string[] _excludePackageNames;
        private string _packagePrefixToUpgrade;

        private string _oldVersionLabelContainsThis;
        private string _newVersionNumber;

        private Predicate<JProperty> _dependencyFilter;
        private Action<JObject, JProperty> _updateDependencyCallback;


        protected BaseDependenciesUpdateAction(Predicate<JProperty> dependencyPredicate, Action<JObject, JProperty> updateDependencyCallback)
        {
            _dependencyFilter = dependencyPredicate;
            _updateDependencyCallback = updateDependencyCallback;

            //  _packagePrefixToUpgrade = packageNameStartsWith;
            // _oldVersionLabelContainsThis = packageVersionNumberContains;
            //  _excludePackageNames = excludePackageNames ?? new[] { "" };
            //  _newVersionNumber = newVersionNumber;
        }

        public void Apply(IJsonFileUpgradeContext fileUpgradeContext)
        {
            JObject projectJsonObject = fileUpgradeContext.ProjectJsonObject;
            JObject dependencies = (JObject)projectJsonObject["dependencies"];
            _backup = dependencies.DeepClone();

            var dependenciesToUpdate = new List<JProperty>();
            foreach (var dependencyProp in dependencies.Properties())
            {
                if (_dependencyFilter(dependencyProp))
                {
                    dependenciesToUpdate.Add(dependencyProp);
                }
            }

            foreach (var dependencyForUpdate in dependenciesToUpdate)
            {
                _updateDependencyCallback(dependencies, dependencyForUpdate);
            }
        }

        public void Undo(IJsonFileUpgradeContext fileUpgradeContext)
        {
            // restore frameworks section
            JObject projectJsonObject = fileUpgradeContext.ProjectJsonObject;
            projectJsonObject["dependencies"].Replace(_backup);

        }
    }
}