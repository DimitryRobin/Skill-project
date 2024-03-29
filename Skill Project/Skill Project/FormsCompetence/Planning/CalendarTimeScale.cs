using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Calendar;
using System.Windows.Forms;

namespace Skill_Project
{
    /// <summary>
    /// Enumerates possible timescales for <see cref="Calendar"/> control
    /// </summary>
    public enum CalendarTimeScale
    {
        /// <summary>
        /// Makes calendar show intervals of 60 minutes
        /// </summary>
        SixtyMinutes = 60,

        /// <summary>
        /// Makes calendar show intervals of 30 minutes
        /// </summary>
        ThirtyMinutes = 30,

        /// <summary>
        /// Makes calendar show intervals of 15 minutes
        /// </summary>
        FifteenMinutes = 15,

        /// <summary>
        /// Makes calendar show intervals of 10 minutes
        /// </summary>
        TenMinutes = 10,

        /// <summary>
        /// Makes calendar show intervals of 6 minutes
        /// </summary>
        SixMinutes = 6,

        /// <summary>
        /// Makes calendar show intervals of 5 minutes
        /// </summary>
        FiveMinutes = 5
    }
}
