using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms.Calendar;
using System.Windows.Forms;

namespace Skill_Project
{
    public class CalendarItemCancelEventArgs
        : CancelEventArgs
    {
         #region Ctor

        /// <summary>
        /// Creates a new <see cref="CalendarItemEventArgs"/>
        /// </summary>
        /// <param name="item">Related Item</param>
        public CalendarItemCancelEventArgs(CalendarItem item)
        {
            _item = item;
        }

        #endregion

        #region Props

        private CalendarItem _item;

        /// <summary>
        /// Gets the <see cref="CalendarItem"/> related to the event
        /// </summary>
        public CalendarItem Item
        {
            get { return _item; }
        }


        #endregion
    }
}
