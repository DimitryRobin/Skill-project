using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.Calendar;
using System.Windows.Forms;

namespace Skill_Project
{
    /// <summary>
    /// Contains information about a day to draw on the calendar
    /// </summary>
    public class CalendarRendererDayEventArgs
        : CalendarRendererEventArgs
    {
        #region Fields
        private CalendarDay _day;
        #endregion

        #region Ctor

        /// <summary>
        /// Creates a new <see cref="CalendarRendererDayEventArgs"/> object
        /// </summary>
        /// <param name="original">Orignal object to copy basic paramters</param>
        /// <param name="day">Day to render</param>
        public CalendarRendererDayEventArgs(CalendarRendererEventArgs original, CalendarDay day)
            : base(original)
        {
            _day = day;
        }

        #endregion

        #region Props

        /// <summary>
        /// Gets the day to paint
        /// </summary>
        public CalendarDay Day
        {
            get { return _day; }
        }


        #endregion
    }
}
