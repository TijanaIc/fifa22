//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fifa22.Library.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TeamQueries {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TeamQueries() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Fifa22.Library.Resources.TeamQueries", typeof(TeamQueries).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select top {0} Teamid as Team_id, sum(GoalCount) as TeamsGoals, Team_name, Team_group from PlayerEx group by Teamid, Team_name, Team_group  order by TeamsGoals desc.
        /// </summary>
        internal static string GET_TEAM_BY_GOAL {
            get {
                return ResourceManager.GetString("GET_TEAM_BY_GOAL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select Team_name, Team_group, Team_id from Team where Team_id = &apos;{0}&apos;.
        /// </summary>
        internal static string GET_TEAM_BY_ID {
            get {
                return ResourceManager.GetString("GET_TEAM_BY_ID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select Team_name, Team_group, Team_id from Team where Team_group = &apos;{0}&apos;.
        /// </summary>
        internal static string GET_TEAM_BY_NAME {
            get {
                return ResourceManager.GetString("GET_TEAM_BY_NAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select Team_name, Team_group, Team_id from Team.
        /// </summary>
        internal static string TEAM_LIST {
            get {
                return ResourceManager.GetString("TEAM_LIST", resourceCulture);
            }
        }
    }
}
