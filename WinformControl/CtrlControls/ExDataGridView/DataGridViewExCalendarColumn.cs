﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CtrlControls.ExDataGridView
{
    public class DataGridViewExCalendarColumn : DataGridViewColumn
    {
        public DataGridViewExCalendarColumn()
            : base(new DataGridViewExCalendarCell())
        {
        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                // Ensure that the cell used for the template is a CalendarCell.
                if (value != null &&
                    !value.GetType().IsAssignableFrom(typeof(DataGridViewExCalendarCell)))
                {
                    throw new InvalidCastException("Must be a CalendarCell");
                }
                base.CellTemplate = value;
            }
        }
    }
}
