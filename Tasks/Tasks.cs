using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ModernUI;

namespace ModernUI
{
    public partial class Tasks: Component
    {
        public Form ParentForm
        {
            get;set;
        }
        public void LoadTasks()
        {
            AllTasks.Clear();
            foreach (Control ctl in ParentForm.Controls)
            {
                if (ctl is TaskPanel)
                    AllTasks.Add((TaskPanel)ctl);
            }
        }

        public void Hide()
        {
            foreach (TaskPanel taskPanel in AllTasks)
            {
                taskPanel.Visible = false;
            }
        }

        private List<TaskPanel> AllTasks;
        
        public TaskPanel this[int i]
        {
            get
            {
                return AllTasks[i];
            }
            set
            {
                AllTasks[i] = value;
            }
        }


        public Tasks()
        {
            AllTasks = new List<TaskPanel>();
        }
    }
}
