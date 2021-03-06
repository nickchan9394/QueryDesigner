﻿namespace QueryDesignerCore
{
    /// <summary>
    /// Additional setting for where filter
    /// </summary>
    public class WhereFilterSetting
    {
        /// <summary>
        /// Indicate case sensitive when use Contain operator
        /// </summary>
        public bool CaseInsensitive { get; set; }

        /// <summary>
        /// Supress exception when property cannot be found
        /// </summary>
        public bool SupressPropertyNotFoundException { get; set; }
    }
}
