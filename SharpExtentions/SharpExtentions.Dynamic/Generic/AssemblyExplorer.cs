using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SharpExtentions.Dynamic.Utility;

/*	CREATED BY Aliskhanov R. aka Ravillions (ravillion@mail.ru) */

namespace SharpExtentions.Dynamic.Generic {

    public class AssemblyExplorer {

        public static IEnumerable<Type> Successors<TInterface>(params Assembly[] assemblies) {
            assemblies = assemblies ?? AppDomain.CurrentDomain.GetAssemblies();
            return assemblies.SelectMany(assembly => assembly.GetTypes().Where(x => x != typeof (TInterface)).Where(y => !y.IsInterface).Where(z => typeof (TInterface).IsAssignableFrom(z)).ToList());
        }

        public static IEnumerable<Type> NameEnds(string name, params Assembly[] assemblies) {

            if (name.isEmptyOrWhiteSpace()) return Enumerable.Empty<Type>();

            assemblies = assemblies ?? AppDomain.CurrentDomain.GetAssemblies();
            return assemblies.SelectMany(x => x.GetTypes().Where(y => y.Name.EndsWith(name)));
        }

        public static IEnumerable<Type> NameEnds<TInterface>(string name, params Assembly[] assemblies) {
            if (name.isEmptyOrWhiteSpace()) return Enumerable.Empty<Type>();
            return Successors<TInterface>(assemblies).Where(x => x.Name.EndsWith(name));
        }

        public static IEnumerable<Type> NameStarts(string name, params Assembly[] assemblies) {
            if (name.isEmptyOrWhiteSpace()) return Enumerable.Empty<Type>();

            assemblies = assemblies ?? AppDomain.CurrentDomain.GetAssemblies();
            return assemblies.SelectMany(x => x.GetTypes().Where(y => y.Name.StartsWith(name)));
        }

        public static IEnumerable<Type> NameStarts<TInterface>(string name, params Assembly[] assemblies)
        {
            if (name.isEmptyOrWhiteSpace()) return Enumerable.Empty<Type>();
            return Successors<TInterface>(assemblies).Where(x => x.Name.StartsWith(name));
        }


    }
}
