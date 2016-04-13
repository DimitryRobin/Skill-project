using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms.Calendar;
using System.Windows.Forms;

namespace Skill_Project
{
    /// <summary>
    /// Represents a clickable element of <see cref="MonthView"/> control
    /// </summary>
    public interface ISelectableElement
    {

        /// <summary>
        /// Gets the bounds of the element
        /// </summary>
        Rectangle Bounds { get; }

        /// <summary>
        /// Gets if the element is currently selected
        /// </summary>
        bool Selected { get; }
    }
}
